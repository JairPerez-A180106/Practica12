#pragma checksum "C:\Users\Zuki\Documents\UNACH\5to Semestre\Programacion de aplicaciones web\PRACTICA 12\Views\Home\Area.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f23dda6565a1fd59ada8aac678b5387e91b667c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Area), @"mvc.1.0.view", @"/Views/Home/Area.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Zuki\Documents\UNACH\5to Semestre\Programacion de aplicaciones web\PRACTICA 12\Views\_ViewImports.cshtml"
using PRACTICA_11;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zuki\Documents\UNACH\5to Semestre\Programacion de aplicaciones web\PRACTICA 12\Views\_ViewImports.cshtml"
using PRACTICA_11.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f23dda6565a1fd59ada8aac678b5387e91b667c1", @"/Views/Home/Area.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b62f624f9c04eccccd4824feea1e10e791d0a2c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Area : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Zuki\Documents\UNACH\5to Semestre\Programacion de aplicaciones web\PRACTICA 12\Views\Home\Area.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">CALCULADORA DE AREAS</h1>\r\n    <center>\r\n");
#nullable restore
#line 7 "C:\Users\Zuki\Documents\UNACH\5to Semestre\Programacion de aplicaciones web\PRACTICA 12\Views\Home\Area.cshtml"
     using (Html.BeginForm()){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table>
            <tr>
                <th>Base:</th>
                <td><input type=""text"" id=""txtNumero1"" name=""Base"" class=""form-control"" /></td>
            </tr>
            <tr>
                <th>Altura:</th>
                <td><input type=""text"" id=""txtNumero2"" name=""Altura"" class=""form-control"" /></td>
            </tr>
            <tr>
                <td><input type=""submit"" name=""tipo"" value=""Triangulo"" class=""btn btn-primary"" /></td>
                <td><input type=""submit"" name=""tipo"" value=""Rectangulo"" class=""btn btn-primary"" /></td>
            </tr>
            <tr>
                <th>Resultado</th>
                <td><input type=""text"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 883, "\"", 906, 1);
#nullable restore
#line 23 "C:\Users\Zuki\Documents\UNACH\5to Semestre\Programacion de aplicaciones web\PRACTICA 12\Views\Home\Area.cshtml"
WriteAttributeValue("", 891, ViewBag.Result, 891, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n            </tr>\r\n        </table>\r\n");
#nullable restore
#line 26 "C:\Users\Zuki\Documents\UNACH\5to Semestre\Programacion de aplicaciones web\PRACTICA 12\Views\Home\Area.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
