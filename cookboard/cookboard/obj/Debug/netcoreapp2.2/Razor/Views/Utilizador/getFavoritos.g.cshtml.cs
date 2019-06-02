#pragma checksum "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Utilizador\getFavoritos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0aa981bedd90ebb6b1196240bd43c9ff6be1ca38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Utilizador_getFavoritos), @"mvc.1.0.view", @"/Views/Utilizador/getFavoritos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Utilizador/getFavoritos.cshtml", typeof(AspNetCore.Views_Utilizador_getFavoritos))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0aa981bedd90ebb6b1196240bd43c9ff6be1ca38", @"/Views/Utilizador/getFavoritos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86a90c57a68cdbde153aed1e2defab61f9de9b49", @"/Views/_ViewImports.cshtml")]
    public class Views_Utilizador_getFavoritos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<cookboard.Models.Receita>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Utilizador\getFavoritos.cshtml"
  
    ViewBag.Title = "getFavoritos";
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
            BeginContext(399, 92, true);
            WriteLiteral("\r\n<h1>Receitas Favoritas</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(492, 40, false);
#line 22 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Utilizador\getFavoritos.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(532, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(576, 47, false);
#line 25 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Utilizador\getFavoritos.cshtml"
       Write(Html.DisplayNameFor(model => model.Dificuldade));

#line default
#line hidden
            EndContext();
            BeginContext(623, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(667, 49, false);
#line 28 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Utilizador\getFavoritos.cshtml"
       Write(Html.DisplayNameFor(model => model.TempoConfecao));

#line default
#line hidden
            EndContext();
            BeginContext(716, 47, true);
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n");
            EndContext();
#line 32 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Utilizador\getFavoritos.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(804, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(853, 39, false);
#line 36 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Utilizador\getFavoritos.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(892, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(948, 46, false);
#line 39 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Utilizador\getFavoritos.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dificuldade));

#line default
#line hidden
            EndContext();
            BeginContext(994, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1050, 48, false);
#line 42 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Utilizador\getFavoritos.cshtml"
           Write(Html.DisplayFor(modelItem => item.TempoConfecao));

#line default
#line hidden
            EndContext();
            BeginContext(1098, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1154, 70, false);
#line 45 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Utilizador\getFavoritos.cshtml"
           Write(Html.ActionLink("getReceita", "Receitas", new { idReceita = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1224, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 48 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Utilizador\getFavoritos.cshtml"
    }

#line default
#line hidden
            BeginContext(1267, 10, true);
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
