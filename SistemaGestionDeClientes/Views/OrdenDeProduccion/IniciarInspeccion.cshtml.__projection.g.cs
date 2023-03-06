//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP {
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Security;
using System.Web.UI;
using System.Web.WebPages;
using System.Web.WebPages.Html;

#line 2 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
using Services;

#line default
#line hidden

#line 3 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
using Model.Domain.ControlDeCalzado;

#line default
#line hidden

public class _Page_Views_OrdenDeProduccion_IniciarInspeccion_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_Views_OrdenDeProduccion_IniciarInspeccion_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
__o = model;


#line default
#line hidden

#line 4 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
  
	ViewBag.Title = "Iniciar Inspeccion";
	Modelo modelo = ModeloService.Get(Model.Sku);
	Color color = ColorService.Get(Model.CodigoColor);
	var Defectos = DefectoService.GetAll();
	var DefectosR = Defectos.Where(d => d.TipoDefecto == Common.TipoDefecto.Reproceso);
	var DefectosO = Defectos.Where(d => d.TipoDefecto == Common.TipoDefecto.Observado);
	var horaActual = DateTime.Now.TimeOfDay;
	int contadorParesDePrimera = Model.CantidadDePrimera;


#line default
#line hidden

#line 5 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                                                         __o = Model.FechaDeInicio;


#line default
#line hidden

#line 6 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                                               __o = Model.IdLinea;


#line default
#line hidden

#line 7 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                                             __o = Model.Sku;


#line default
#line hidden

#line 8 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                                                __o = modelo.Denominacion;


#line default
#line hidden

#line 9 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                                                      __o = Model.CodigoColor;


#line default
#line hidden

#line 10 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                                               __o = color.DescripcionColor;


#line default
#line hidden

#line 11 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                                              __o = Model.CantidadDePrimera;


#line default
#line hidden

#line 12 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
            foreach (var item in DefectosO)
			{
				

#line default
#line hidden

#line 13 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                   __o = Html.Raw(item.DescripcionDefecto);


#line default
#line hidden

#line 14 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                     
			}

#line default
#line hidden

#line 15 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
            foreach (var item in DefectosR)
			{
				

#line default
#line hidden

#line 16 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Ini                                                       ml"
 contadorReprocesoIzqitem.DescripcionDefecto);


#line default
#line hidden

#line 17 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Ini                   __o = Html.Raw(item.DescripcionDefecto);


#line default
#line hidden

#line 18 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
ciarInspeccion.cshtml"
                     
			}

#line default19#line hidden

#line 18 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
__o = Html.ActionLink("Pausar OP", "Detalles", "OrdenDeProduccion", new { numero = Model.Numero }, new { @class = "btn" });


#line default20#line hidden

#line 19 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
__o = Html.ActionLink("Terminar OP", "Detalles", "OrdenDeProduccion", new { numero = Model.Numero }, new { @class = "btn" });


#line default
#line hidden
DefineSection("Scrip21", () => {


#line 20 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
__o = Scripts.Render("~/bundles/jqueryval");


#line default22#line hidden

#line 21 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                           __o = Model.Numero;


#line default23#line hidden

#line 22 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                 __o = Url.Action("ActualizarCantidad", "OrdenDeProduccion");


#l
#line 23 24:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                           __o = ;


#line default
#line hidden
ine default
#line 24 25:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                 __o = Url.Action("ActualizarCantidad", "OrdenDeProduccion");


#line default
#line hidden

#line hidden
});

}
}
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP {
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Security;
using System.Web.UI;
using System.Web.WebPages;
using System.Web.WebPages.Html;

#line 2 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
using Services;

#line default
#line hidden

#line 3 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
using Model.Domain.ControlDeCalzado;

#line default
#line hidden

public class _Page_IniciarInspeccion_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_IniciarInspeccion_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
__o = model;


#line default
#line hidden

#line 4 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
  
	ViewBag.Title = "Iniciar Inspeccion";
	Modelo modelo = ModeloService.Get(Model.Sku);
	Color color = ColorService.Get(Model.CodigoColor);
	var Defectos = DefectoService.GetAll();
	var DefectosR = Defectos.Where(d => d.TipoDefecto == Common.TipoDefecto.Reproceso);
	var DefectosO = Defectos.Where(d => d.TipoDefecto == Common.TipoDefecto.Observado);
	var horaActual = DateTime.Now.TimeOfDay;
	int contadorParesDePrimera = Model.CantidadDePrimera;


#line default
#line hidden

#line 5 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                                                         __o = Model.FechaDeInicio;


#line default
#line hidden

#line 6 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                                               __o = Model.IdLinea;


#line default
#line hidden

#line 7 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                                             __o = Model.Sku;


#line default
#line hidden

#line 8 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                                                __o = modelo.Denominacion;


#line default
#line hidden

#line 9 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                                                      __o = Model.CodigoColor;


#line default
#line hidden

#line 10 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                                               __o = color.DescripcionColor;


#line default
#line hidden

#line 11 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                                              __o = Model.CantidadDePrimera;


#line default
#line hidden

#line 12 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
            foreach (var item in DefectosO)
			{
				

#line default
#line hidden

#line 13 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                   __o = Html.Raw(item.DescripcionDefecto);


#line default
#line hidden

#line 14 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                     
			}

#line default
#line hidden

#line 15 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
            foreach (var item in DefectosR)
			{
				

#line default
#line hidden

#line 16 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                   __o = Html.Raw(item.DescripcionDefecto);


#line default
#line hidden

#line 17 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                     
			}

#line default
#line hidden

#line 18 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
__o = Html.ActionLink("Pausar OP", "Detalles", "OrdenDeProduccion", new { numero = Model.Numero }, new { @class = "btn" });


#line default
#line hidden

#line 19 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
__o = Html.ActionLink("Terminar OP", "Detalles", "OrdenDeProduccion", new { numero = Model.Numero }, new { @class = "btn" });


#line default
#line hidden
DefineSection("Scripts", () => {


#line 20 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
__o = Scripts.Render("~/bundles/jqueryval");


#line default
#line hidden

#line 21 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                           __o = Model.Numero;


#line default
#line hidden

#line 22 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                 __o = Url.Action("ActualizarCantidad", "OrdenDeProduccion");


#line default
#line hidden
});

}
}
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP {
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Security;
using System.Web.UI;
using System.Web.WebPages;
using System.Web.WebPages.Html;

#line 2 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
using Services;

#line default
#line hidden

#line 3 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
using Model.Domain.ControlDeCalzado;

#line default
#line hidden

public class _Page_Views_OrdenDeProduccion_IniciarInspeccion_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
#line 21 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
           
	public void BotonRestarParDePrimera()
	{

		
		//void o devuelve el total de pares registrados
		//OrdenDeProduccionService.RegistrarParDePrimera(-1);
		//@model.ParesDePrimera--;
	}
	public void BotonSumarParDePrimera()
	{
		
		//OrdenDeProduccionService.RegistrarParDePrimera(1);
		//@model.ParesDePrimera++;
	}
	//public void RegistrarDefecto()
	//{
	//    IncidenciaService.Create(TipoDefecto t);
	//}
	//public string GetCodigoCorto()
	//{

	//    return @Model.CadenaCodificada.Length > 150 ? Model.CadenaCodificada.Substring(0, 100) + "..." : Model.CadenaCodificada;
	//}

#line default
#line hidden

public _Page_Views_OrdenDeProduccion_IniciarInspeccion_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
__o = model;


#line default
#line hidden

#line 4 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
  
	ViewBag.Title = "Iniciar Inspeccion";
	Modelo modelo = ModeloService.Get(Model.Sku);
	Color color = ColorService.Get(Model.CodigoColor);
	var Defectos = DefectoService.GetAll();
	var DefectosR = Defectos.Where(d => d.TipoDefecto == Common.TipoDefecto.Reproceso);
	var DefectosO = Defectos.Where(d => d.TipoDefecto == Common.TipoDefecto.Observado);
	var horaActual = DateTime.Now.TimeOfDay;
	int contadorParesDePrimera = Defecto.ContadorDeParesDePrimera(Model.CantidadDePrimera, " ");


#line default
#line hidden

#line 5 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                                                         __o = Model.FechaDeInicio;


#line default
#line hidden

#line 6 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                                               __o = Model.IdLinea;


#line default
#line hidden

#line 7 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                                             __o = Model.Sku;


#line default
#line hidden

#line 8 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                                                __o = modelo.Denominacion;


#line default
#line hidden

#line 9 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                                                      __o = Model.CodigoColor;


#line default
#line hidden

#line 10 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                                               __o = color.DescripcionColor;


#line default
#line hidden

#line 11 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                                                                    __o = Defecto.ContadorDeParesDePrimera(contadorParesDePrimera, "+");


#line default
#line hidden

#line 12 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                       __o = contadorParesDePrimera;


#line default
#line hidden

#line 13 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                       __o = ;

.CantidadDePrimera
#line default
#line hidden

#line 14 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                                                                    __o = Defecto.ContadorDeParesDePrimera(contadorParesDePrimera, "-");


#line default
#line hidden

#line 15 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
            foreach (var item in DefectosO)
			{
				

#line default
#line hidden

#line 16 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                   __o = Html.Raw(item.DescripcionDefecto);


#line default
#line hidden

#line 17 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                     
			}

#line default
#line hidden

#line 18 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
            foreach (var item in DefectosR)
			{
				

#line default
#line hidden

#line 19 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                   __o = Html.Raw(item.DescripcionDefecto);


#line default
#line hidden

#line 20 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
                     
			}

#line default
#line hidden
DefineSection("Scripts", () => {


#line 22 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\IniciarInspeccion.cshtml"
__o = Scripts.Render("~/bundles/jqueryval");


#line default
#line hidden
});

}
}
}