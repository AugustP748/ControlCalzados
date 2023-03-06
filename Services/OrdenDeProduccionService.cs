﻿using Model.Domain;
using Model.Domain.ControlDeCalzado;
using Persistanse;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class OrdenDeProduccionService
    {
        public static IEnumerable<OrdenDeProduccion> GetAll()
        {
            var result = new List<OrdenDeProduccion>();

            using (var db = new ApplicationDbContext())
            {
                result = (
                          from col in db.OrdenesDeProduccion
                          select col
                          ).ToList();
            }
            return result;
        }
        public static OrdenDeProduccion Get(string id)
        {
            var result = new OrdenDeProduccion();

            using (var db = new ApplicationDbContext())
            {
                result = db.OrdenesDeProduccion.Where(x => x.Numero == id).Single();
            }
            return result;
        }
        public static void Create(OrdenDeProduccion model)
        {
            //validar turno a la hora de crear
            bool estaEnTurno = TurnoService.EstaEnTurno();
            var lineaOcupada = LineaOcupada(model.IdLinea);
            if (estaEnTurno == true)
            {
                using (var db = new ApplicationDbContext())
                {
                    var OrdenDeProduccion = new OrdenDeProduccion();
                    if (db.OrdenesDeProduccion.Any())
                    {
                        var NumeroOp = db.OrdenesDeProduccion.Where(x => x.Numero == model.Numero).DefaultIfEmpty().Single();
                        if (NumeroOp == null)
                        {
                            OrdenDeProduccion.Numero = model.Numero;
                        }
                        else
                        {
                            throw new ApplicationException("Ya existe una OP con este Numero");
                        }
                    }
                    else OrdenDeProduccion.Numero = model.Numero;
                    if (lineaOcupada == null)
                    {
                        OrdenDeProduccion.IdLinea = model.IdLinea;
                    }
                    else
                    {
                        throw new ApplicationException("Esta linea ya esta ocupada en una OP activa");
                    }

                    OrdenDeProduccion.Sku = model.Sku;
                    OrdenDeProduccion.CodigoColor = model.CodigoColor;
                    OrdenDeProduccion.UserId = model.UserId;
                    //validar op
                    OrdenDeProduccion.FechaDeInicio = model.FechaDeInicio;
                    OrdenDeProduccion.Estado = Common.EstadoOp.Pausada;
                    //OrdenDeProduccion.FechaDeFin = model.FechaDeInicio;
                    //OrdenDeProduccion.CantidadDePrimera = model.CantidadDePrimera;
                    //OrdenDeProduccion.CantidadPorHermanado = model.CantidadPorHermanado;
                    //OrdenDeProduccion.Jornadas = model.Jornadas;

                    db.OrdenesDeProduccion.Add(OrdenDeProduccion);
                    db.SaveChanges();
                }
            }
            else
            {
                //o no devolver nada y validar en el controller
                throw new ApplicationException("No existe turno");
            }
        }
        public static void Update(OrdenDeProduccion model)
        {
            using (var db = new ApplicationDbContext())
            {
                var originalEntity = db.OrdenesDeProduccion.Where(x => x.Numero == model.Numero).Single();

                originalEntity.Numero = model.Numero;
                originalEntity.Sku = model.Sku;
                originalEntity.CodigoColor = model.CodigoColor;
                originalEntity.IdLinea = model.IdLinea;
                originalEntity.FechaDeFin = model.FechaDeFin;
                originalEntity.Jornadas = model.Jornadas;

                db.Entry(originalEntity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public static bool JornadaActiva(string numero)
        {
            var idTurno = TurnoService.GetId();
            var FinJornada = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day) + TurnoService.Get(idTurno).HoraDeFin;
            using (var db = new ApplicationDbContext())
            {
                return db.JornadasLaborales
                    .Where(j => j.FechaFinJornada == FinJornada && j.Numero == numero)
                    .Any();
            }
        }
        public static void AgregarJornada(string Numero)
        {
            var op = Get(Numero);
            var idTurno = TurnoService.GetId();
            var FinJornada = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day) + TurnoService.Get(idTurno).HoraDeFin;
            using (var db = new ApplicationDbContext())
            {
                var jornada = new JornadaLaboral
                {
                    Numero = Numero,
                    FechaInicioJornada = DateTime.Now,
                    IdTurno = idTurno,
                    FechaFinJornada = FinJornada
                };
                op.Jornadas.Add(jornada);
                db.JornadasLaborales.Add(jornada);
                db.SaveChanges();
            }
        }
        public static void AgregarHorarioDeControl(string Numero)
        {
            var op = Get(Numero);
            var idTurno = TurnoService.GetId();
            var FinJornada = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day) + TurnoService.Get(idTurno).HoraDeFin;
            
                using (var db = new ApplicationDbContext())
                {
                var horarioDeControl = new HorarioDeControl
                {
                    HoraInicio = DateTime.Now,
                    HoraFin = FinJornada,
                    IdJornada = db.JornadasLaborales.Where(j=>j.FechaFinJornada == FinJornada && j.Numero == Numero).Single().IdJornada,
                };
                db.HorariosDeControl.Add(horarioDeControl);
                db.SaveChanges();
            }
        }
        public static void CargarAlertas(string id)
        {
            OrdenDeProduccion op = OrdenDeProduccionService.Get(id);

            using (var db = new ApplicationDbContext())
            {
                Modelo modelo = db.Modelos.Find(op.Sku);
                JornadaLaboral jornada = db.JornadasLaborales
                    .Where(j => j.Numero == id)
                    .OrderByDescending(j => j.FechaFinJornada)
                    .FirstOrDefault();
                db.Alertas.Add(new Alerta
                {
                    TipoDefecto = Common.TipoDefecto.Observado,
                    IdJornada = jornada.IdJornada,
                    LimiteInferior = modelo.LimiteInferiorDeObservado,
                    LimiteSuperior = modelo.LimiteSuperiorDeObservado
                });
                jornada.Alertas.AddRange(db.Alertas.Where(a => a.IdJornada == jornada.IdJornada).ToArray());
                db.Alertas.Add(new Alerta
                {
                    TipoDefecto = Common.TipoDefecto.Reproceso,
                    IdJornada = jornada.IdJornada,
                    LimiteInferior = modelo.LimiteInferiorDeReproceso,
                    LimiteSuperior = modelo.LimiteSuperiorDeReproceso
                });
                db.SaveChanges();
            }
        }
        public static void Delete(string id)
        {
            try
            {
                using (var db = new ApplicationDbContext())
                {
                    OrdenDeProduccion OrdenDeProduccion = db.OrdenesDeProduccion.Where(x => x.Numero == id).Single();

                    db.OrdenesDeProduccion.Remove(OrdenDeProduccion);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new ApplicationException("No se puede eliminar la Orden de Produccion" + id);
            }
        }
        public static OrdenDeProduccion GetOP(string user)
        {
            var result = new OrdenDeProduccion();

            using (var ctx = new ApplicationDbContext())
            {
                result = ctx.OrdenesDeProduccion.Where(x => x.UserId == user).FirstOrDefault();
            }
            return result;
        }
        public static void ChangeUserToOp(string numero, string userid)
        {
            try
            {
                using (var ctx = new ApplicationDbContext())
                {
                    var Op = ctx.OrdenesDeProduccion.Where(x => x.Numero == numero).Single();

                    Op.UserId = userid;

                    ctx.Entry(Op).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static OrdenDeProduccion LineaOcupada(int linea)
        {
            var result = new OrdenDeProduccion();

            using (var ctx = new ApplicationDbContext())
            {
                result = ctx.OrdenesDeProduccion.Where(x => x.IdLinea == linea && (x.Estado == Common.EstadoOp.Iniciada || x.Estado == Common.EstadoOp.Pausada)).DefaultIfEmpty().Single();
            }

            return result;
        }

        public static void UpdateCantidadDeParesDePrimera(string Numero, int cantidad)
        {
            using(var db = new ApplicationDbContext())
            {
                var originalEntity = db.OrdenesDeProduccion.Where(x => x.Numero == Numero).Single();

                originalEntity.CantidadDePrimera = cantidad;

                db.Entry(originalEntity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static HorarioDeControl ObtenerHorarioDeControl(string NumeroDeOrden)
        {
            HorarioDeControl horarioDeControl = null;
            using (var db = new ApplicationDbContext())
            {
                horarioDeControl = (
                                    from j in db.JornadasLaborales.Where(j => j.Numero == NumeroDeOrden)
                                    from hdc in db.HorariosDeControl.Where(h => h.IdJornada == j.IdJornada)
                                    select hdc
                                    ).OrderByDescending(h => h.HoraInicio).First();
            }
            return horarioDeControl;
        }
    }
}

