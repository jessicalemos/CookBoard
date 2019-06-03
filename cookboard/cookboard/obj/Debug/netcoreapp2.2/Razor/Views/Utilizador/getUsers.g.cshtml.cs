#pragma checksum "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Utilizador\getUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "015ccfad64142e595b653d4871d2035c201b6d07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Utilizador_getUsers), @"mvc.1.0.view", @"/Views/Utilizador/getUsers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Utilizador/getUsers.cshtml", typeof(AspNetCore.Views_Utilizador_getUsers))]
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
#line 1 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\_ViewImports.cshtml"
using cookboard;

#line default
#line hidden
#line 2 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\_ViewImports.cshtml"
using cookboard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"015ccfad64142e595b653d4871d2035c201b6d07", @"/Views/Utilizador/getUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86a90c57a68cdbde153aed1e2defab61f9de9b49", @"/Views/_ViewImports.cshtml")]
    public class Views_Utilizador_getUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<cookboard.Models.Utilizador>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Utilizador\getUsers.cshtml"
  
    ViewBag.Title = "getUsers";
    string currentType = (string)@ViewData["Type"];

    switch (currentType)
    {
        case "Professor":
            Layout = "~/Views/Shared/_LayoutProfessor.cshtml";
            break;
        case "Aluno":
            Layout = "~/Views/Shared/_LayoutAluno.cshtml";
            break;
    }

#line default
#line hidden
            BeginContext(398, 210, true);
            WriteLiteral("\r\n<div style=\"margin-left: 24px; font-weight: 900; font-size: 30px; padding-bottom: 20px;\">Lista de Utilizadores</div>\r\n\r\n\r\n<table class=\"table\" style=\"margin-left: 24px;\">\r\n    <tr>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(609, 40, false);
#line 23 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Utilizador\getUsers.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(649, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(693, 44, false);
#line 26 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Utilizador\getUsers.cshtml"
       Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
            EndContext();
            BeginContext(737, 47, true);
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n");
            EndContext();
#line 30 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Utilizador\getUsers.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(825, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(874, 39, false);
#line 34 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Utilizador\getUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(913, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(969, 43, false);
#line 37 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Utilizador\getUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Username));

#line default
#line hidden
            EndContext();
            BeginContext(1012, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1068, 72, false);
#line 40 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Utilizador\getUsers.cshtml"
           Write(Html.ActionLink("Consultar", "Consultar", new { idServico = item.Nome }));

#line default
#line hidden
            EndContext();
            BeginContext(1140, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 43 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Utilizador\getUsers.cshtml"
    }

#line default
#line hidden
            BeginContext(1183, 10, true);
            WriteLiteral("</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<cookboard.Models.Utilizador>> Html { get; private set; }
    }
}
#pragma warning restore 1591
