#pragma checksum "C:\Users\marta\OneDrive\Área de Trabalho\LI4\cookboard\cookboard\Views\Utilizador\getHistorico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a600aff0915e879f4e3292ea71478134a05fb4f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Utilizador_getHistorico), @"mvc.1.0.view", @"/Views/Utilizador/getHistorico.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Utilizador/getHistorico.cshtml", typeof(AspNetCore.Views_Utilizador_getHistorico))]
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
#line 1 "C:\Users\marta\OneDrive\Área de Trabalho\LI4\cookboard\cookboard\Views\_ViewImports.cshtml"
using cookboard;

#line default
#line hidden
#line 2 "C:\Users\marta\OneDrive\Área de Trabalho\LI4\cookboard\cookboard\Views\_ViewImports.cshtml"
using cookboard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a600aff0915e879f4e3292ea71478134a05fb4f2", @"/Views/Utilizador/getHistorico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86a90c57a68cdbde153aed1e2defab61f9de9b49", @"/Views/_ViewImports.cshtml")]
    public class Views_Utilizador_getHistorico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<cookboard.Models.Receita>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\marta\OneDrive\Área de Trabalho\LI4\cookboard\cookboard\Views\Utilizador\getHistorico.cshtml"
  
    ViewBag.Title = "getHistorico";
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
            BeginContext(399, 203, true);
            WriteLiteral("<div style=\"margin-left: 24px; font-weight: 900; font-size: 30px; padding-bottom: 20px;\">Histórico Receitas</div>\r\n\r\n<table class=\"table\" style=\"margin-left: 24px;\">\r\n    <tr>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(603, 40, false);
#line 21 "C:\Users\marta\OneDrive\Área de Trabalho\LI4\cookboard\cookboard\Views\Utilizador\getHistorico.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(643, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(687, 47, false);
#line 24 "C:\Users\marta\OneDrive\Área de Trabalho\LI4\cookboard\cookboard\Views\Utilizador\getHistorico.cshtml"
       Write(Html.DisplayNameFor(model => model.Dificuldade));

#line default
#line hidden
            EndContext();
            BeginContext(734, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(778, 49, false);
#line 27 "C:\Users\marta\OneDrive\Área de Trabalho\LI4\cookboard\cookboard\Views\Utilizador\getHistorico.cshtml"
       Write(Html.DisplayNameFor(model => model.TempoConfecao));

#line default
#line hidden
            EndContext();
            BeginContext(827, 47, true);
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n");
            EndContext();
#line 31 "C:\Users\marta\OneDrive\Área de Trabalho\LI4\cookboard\cookboard\Views\Utilizador\getHistorico.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(915, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(964, 39, false);
#line 35 "C:\Users\marta\OneDrive\Área de Trabalho\LI4\cookboard\cookboard\Views\Utilizador\getHistorico.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1003, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1059, 46, false);
#line 38 "C:\Users\marta\OneDrive\Área de Trabalho\LI4\cookboard\cookboard\Views\Utilizador\getHistorico.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dificuldade));

#line default
#line hidden
            EndContext();
            BeginContext(1105, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1161, 48, false);
#line 41 "C:\Users\marta\OneDrive\Área de Trabalho\LI4\cookboard\cookboard\Views\Utilizador\getHistorico.cshtml"
           Write(Html.DisplayFor(modelItem => item.TempoConfecao));

#line default
#line hidden
            EndContext();
            BeginContext(1209, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1265, 82, false);
#line 44 "C:\Users\marta\OneDrive\Área de Trabalho\LI4\cookboard\cookboard\Views\Utilizador\getHistorico.cshtml"
           Write(Html.ActionLink("Consultar","getReceita", "Receitas", new { idReceita = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1347, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 47 "C:\Users\marta\OneDrive\Área de Trabalho\LI4\cookboard\cookboard\Views\Utilizador\getHistorico.cshtml"
    }

#line default
#line hidden
            BeginContext(1390, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<cookboard.Models.Receita>> Html { get; private set; }
    }
}
#pragma warning restore 1591
