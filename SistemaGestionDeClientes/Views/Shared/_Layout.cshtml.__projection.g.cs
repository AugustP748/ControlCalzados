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

public class _Page_Views_Shared__Layout_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_Views_Shared__Layout_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
      __o = ViewBag.Title;


#line default
#line hidden

#line 2 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
__o = Styles.Render("~/Content/css");


#line default
#line hidden

#line 3 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
__o = Scripts.Render("~/bundles/modernizr");


#line default
#line hidden

#line 4 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
           __o = Html.ActionLink("Control de Calzado", "Index", "Home", new { area = "" }, new { @class = "navbar-brand" });


#line default
#line hidden

#line 5 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
                   __o = Html.ActionLink("Inicio", "Index", "Home");


#line default
#line hidden

#line 6 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
                    if (Request.IsAuthenticated)
                    {
                        

#line default
#line hidden

#line 7 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
                       __o = Html.ActionLink("Usuarios", "Index", "User");


#line default
#line hidden

#line 8 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
                                                                              
                    }

#line default
#line hidden

#line 9 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
           __o = Html.Partial("_LoginPartial");


#line default
#line hidden

#line 10 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
   __o = RenderBody();


#line default
#line hidden

#line 11 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
                           __o = DateTime.Now.Year;


#line default
#line hidden

#line 12 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
__o = Scripts.Render("~/bundles/jquery");


#line default
#line hidden

#line 13 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
__o = Scripts.Render("~/bundles/bootstrap");


#line default
#line hidden

#line 14 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
__o = Scripts.Render("~/bundles/ajax");


#line default
#line hidden

#line 15 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
__o = RenderSection("scripts", required: false);


#line default
#line hidden
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

public class _Page_Views_Shared__Layout_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_Views_Shared__Layout_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
      __o = ViewBag.Title;


#line default
#line hidden

#line 2 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
__o = Styles.Render("~/Content/css");


#line default
#line hidden

#line 3 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
__o = Scripts.Render("~/bundles/modernizr");


#line default
#line hidden

#line 4 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
           __o = Html.ActionLink("Control de Calzado", "Index", "Home", new { area = "" }, new { @class = "navbar-brand" });


#line default
#line hidden

#line 5 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
                   __o = Html.ActionLink("Inicio", "Index", "Home");


#line default
#line hidden

#line 6 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
                    if (Request.IsAuthenticated)
                    {
                        

#line default
#line hidden

#line 7 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
                       __o = Html.ActionLink("Usuarios", "Index", "User");


#line default
#line hidden

#line 8 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
                                                                              
                    }

#line default
#line hidden

#line 9 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
           __o = Html.Partial("_LoginPartial");


#line default
#line hidden

#line 10 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
   __o = RenderBody();


#line default
#line hidden

#line 11 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
                           __o = DateTime.Now.Year;


#line default
#line hidden

#line 12 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
__o = Scripts.Render("~/bundles/jquery");


#line default
#line hidden

#line 13 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
__o = Scripts.Render("~/bundles/bootstrap");


#line default
#line hidden

#line 14 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
__o = RenderSection("scripts", required: false);


#line default
#line hidden
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

public class _Page__Layout_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page__Layout_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
      __o = ViewBag.Title;


#line default
#line hidden

#line 2 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
__o = Styles.Render("~/Content/css");


#line default
#line hidden

#line 3 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
__o = Scripts.Render("~/bundles/modernizr");


#line default
#line hidden

#line 4 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
           __o = Html.ActionLink("Control de Calzado", "Index", "Home", new { area = "" }, new { @class = "navbar-brand" });


#line default
#line hidden

#line 5 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
                   __o = Html.ActionLink("Inicio", "Index", "Home");


#line default
#line hidden

#line 6 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
                    if (Request.IsAuthenticated)
                    {
                        

#line default
#line hidden

#line 7 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
                       __o = Html.ActionLink("Usuarios", "Index", "User");


#line default
#line hidden

#line 8 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
                                                                              
                        

#line default
#line hidden

#line 9 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
                       __o = Html.ActionLink("Roles", "Index", "RolesEmp");


#line default
#line hidden

#line 10 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
                                                                               
                        

#line default
#line hidden

#line 11 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
                       __o = Html.ActionLink("Empleados", "Index", "Empleado");


#line default
#line hidden

#line 12 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
                                                                                   
                    }

#line default
#line hidden

#line 13 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
           __o = Html.Partial("_LoginPartial");


#line default
#line hidden

#line 14 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
   __o = RenderBody();


#line default
#line hidden

#line 15 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
                           __o = DateTime.Now.Year;


#line default
#line hidden

#line 16 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
__o = Scripts.Render("~/bundles/jquery");


#line default
#line hidden

#line 17 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
__o = Scripts.Render("~/bundles/bootstrap");


#line default
#line hidden

#line 18 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Shared\_Layout.cshtml"
__o = RenderSection("scripts", required: false);


#line default
#line hidden
}
}
}
