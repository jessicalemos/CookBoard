#pragma checksum "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\Aluno\getFavoritos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3e0ce4ae19bbf4e10b38302e43bfcde1c5c0ace"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aluno_getFavoritos), @"mvc.1.0.view", @"/Views/Aluno/getFavoritos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Aluno/getFavoritos.cshtml", typeof(AspNetCore.Views_Aluno_getFavoritos))]
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
#line 1 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\_ViewImports.cshtml"
using cookboard;

#line default
#line hidden
#line 2 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\_ViewImports.cshtml"
using cookboard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3e0ce4ae19bbf4e10b38302e43bfcde1c5c0ace", @"/Views/Aluno/getFavoritos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86a90c57a68cdbde153aed1e2defab61f9de9b49", @"/Views/_ViewImports.cshtml")]
    public class Views_Aluno_getFavoritos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<cookboard.Models.Receita>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\Aluno\getFavoritos.cshtml"
  
    ViewBag.Title = "getFavoritos";
    Layout = "~/Views/Shared/_LayoutAluno.cshtml";


#line default
#line hidden
            BeginContext(146, 92, true);
            WriteLiteral("\r\n<h1>Receitas Favoritas</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(239, 40, false);
#line 14 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\Aluno\getFavoritos.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(279, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(323, 47, false);
#line 17 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\Aluno\getFavoritos.cshtml"
       Write(Html.DisplayNameFor(model => model.Dificuldade));

#line default
#line hidden
            EndContext();
            BeginContext(370, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(414, 49, false);
#line 20 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\Aluno\getFavoritos.cshtml"
       Write(Html.DisplayNameFor(model => model.TempoConfecao));

#line default
#line hidden
            EndContext();
            BeginContext(463, 47, true);
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n");
            EndContext();
#line 24 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\Aluno\getFavoritos.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(551, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(600, 39, false);
#line 28 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\Aluno\getFavoritos.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(639, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(695, 46, false);
#line 31 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\Aluno\getFavoritos.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dificuldade));

#line default
#line hidden
            EndContext();
            BeginContext(741, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(797, 48, false);
#line 34 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\Aluno\getFavoritos.cshtml"
           Write(Html.DisplayFor(modelItem => item.TempoConfecao));

#line default
#line hidden
            EndContext();
            BeginContext(845, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(901, 72, false);
#line 37 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\Aluno\getFavoritos.cshtml"
           Write(Html.ActionLink("Consultar", "Consultar", new { idReceita = item.Nome }));

#line default
#line hidden
            EndContext();
            BeginContext(973, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 40 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\Aluno\getFavoritos.cshtml"
    }

#line default
#line hidden
            BeginContext(1016, 10, true);
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
