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

public class _Page_Views_User_Register_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_Views_User_Register_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\User\Register.cshtml"
__o = model;


#line default
#line hidden

#line 2 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\User\Register.cshtml"
  
    ViewBag.Title = "Registrar Nuevo Usuario";


#line default
#line hidden

#line 3 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\User\Register.cshtml"
__o = ViewBag.Title;


#line default
#line hidden

#line 4 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\User\Register.cshtml"
using (Html.BeginForm("Register", "User", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
{
    

#line default
#line hidden

#line 5 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\User\Register.cshtml"
__o = Html.AntiForgeryToken();


#line default
#line hidden

#line 6 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\User\Register.cshtml"
                            
    

#line default
#line hidden

#line 7 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\User\Register.cshtml"
                                   
    

#line default
#line hidden

#line 8 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\User\Register.cshtml"
          
    

#line default
#line hidden

#line 9 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\User\Register.cshtml"
__o = Html.ValidationSummary("", new { @class = "text-danger" });


#line default
#line hidden

#line 10 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\User\Register.cshtml"
                                                               
    

#line default
#line hidden

#line 11 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\User\Register.cshtml"
   __o = Html.LabelFor(m => m.Email, new { @class = "col-md-2 control-label" });


#line default
#line hidden

#line 12 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\User\Register.cshtml"
       __o = Html.TextBoxFor(m => m.Email, new { @class = "form-control" });


#line default
#line hidden

#line 13 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\User\Register.cshtml"
          
    

#line default
#line hidden

#line 14 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\User\Register.cshtml"
   __o = Html.LabelFor(m => m.Name, new { @class = "col-md-2 control-label" });


#line default
#line hidden

#line 15 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\User\Register.cshtml"
       __o = Html.TextBoxFor(m => m.Name, new { @class = "form-control" });


#line default
#line hidden

#line 16 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\User\Register.cshtml"
          
    

#line default
#line hidden

#line 17 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\User\Register.cshtml"
   __o = Html.LabelFor(m => m.LastName, new { @class = "col-md-2 control-label" });


#line default
#line hidden

#line 18 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\User\Register.cshtml"
       __o = Html.TextBoxFor(m => m.LastName, new { @class = "form-control" });


#line default
#line hidden

#line 19 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\User\Register.cshtml"
          
    

#line default
#line hidden

#line 20 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\User\Register.cshtml"
   __o = Html.LabelFor(m => m.Password, new { @class = "col-md-2 control-label" });


#line default
#line hidden

#line 21 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\User\Register.cshtml"
       __o = Html.PasswordFor(m => m.Password, new { @class = "form-control" });


#line default
#line hidden

#line 22 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\User\Register.cshtml"
          
    

#line default
#line hidden

#line 23 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\User\Register.cshtml"
   __o = Html.LabelFor(m => m.ConfirmPassword, new { @class = "col-md-2 control-label" });


#line default
#line hidden

#line 24 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\User\Register.cshtml"
       __o = Html.PasswordFor(m => m.ConfirmPassword, new { @class = "form-control" });


#line default
#line hidden

#line 25 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\User\Register.cshtml"
          
    

#line default
#line hidden

#line 26 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\User\Register.cshtml"
          
}

#line default
#line hidden
DefineSection("Scripts", () => {


#line 27 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\User\Register.cshtml"
__o = Scripts.Render("~/bundles/jqueryval");


#line default
#line hidden
});

}
}
}
