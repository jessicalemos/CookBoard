#pragma checksum "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abf26b5d0191b38ea6522806238abd784a515f75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Receitas_getPassos), @"mvc.1.0.view", @"/Views/Receitas/getPassos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Receitas/getPassos.cshtml", typeof(AspNetCore.Views_Receitas_getPassos))]
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
#line 1 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\_ViewImports.cshtml"
using cookboard;

#line default
#line hidden
#line 2 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\_ViewImports.cshtml"
using cookboard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abf26b5d0191b38ea6522806238abd784a515f75", @"/Views/Receitas/getPassos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86a90c57a68cdbde153aed1e2defab61f9de9b49", @"/Views/_ViewImports.cshtml")]
    public class Views_Receitas_getPassos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<cookboard.Models.PassosViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
  
    ViewData["Title"] = "getPassos";
    Layout = "~/Views/Shared/_LayoutPassos.cshtml";


#line default
#line hidden
            BeginContext(154, 537, true);
            WriteLiteral(@"
<nav class=""navbar navbar-expand-lg navbar-dark bg-primary fixed-top"" id=""sideNav"">
    <a class=""navbar-brand js-scroll-trigger"" href=""#page-top"">
    </a>
    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
        <span class=""navbar-toggler-icon""></span>
    </button>
    <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
        <ul class=""navbar-nav"">
");
            EndContext();
#line 16 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(748, 96, true);
            WriteLiteral("                <li class=\"nav-item\">\r\n                    <a class=\"nav-link js-scroll-trigger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 844, "\"", 896, 2);
            WriteAttributeValue("", 851, "#", 851, 1, true);
#line 19 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 852, Html.DisplayFor(modelItem => item.NumPasso), 852, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(897, 7, true);
            WriteLiteral(">Passo ");
            EndContext();
            BeginContext(905, 43, false);
#line 19 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
                                                                                                                Write(Html.DisplayFor(modelItem => item.NumPasso));

#line default
#line hidden
            EndContext();
            BeginContext(948, 29, true);
            WriteLiteral("</a>\r\n                </li>\r\n");
            EndContext();
#line 21 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
            }

#line default
#line hidden
            BeginContext(992, 74, true);
            WriteLiteral("        </ul>\r\n    </div>\r\n</nav>\r\n\r\n<div class=\"container-fluid p-0\">\r\n\r\n");
            EndContext();
#line 28 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
     foreach (var item in Model)
    {
        if (item.Type == "ultimo")
        {
            if (item.Auxiliar != -1)
            {

#line default
#line hidden
            BeginContext(1207, 84, true);
            WriteLiteral("                <section class=\"resume-section p-3 p-lg-5 d-flex align-items-center\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1291, "\"", 1340, 1);
#line 34 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 1296, Html.DisplayFor(modelItem => item.NumPasso), 1296, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1341, 72, true);
            WriteLiteral(">\r\n                    <div class=\"w-100\">\r\n                        <h6>");
            EndContext();
            BeginContext(1414, 40, false);
#line 36 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Passo));

#line default
#line hidden
            EndContext();
            BeginContext(1454, 151, true);
            WriteLiteral("</h6>\r\n                    </div>\r\n                    <input type=\"button\" class=\"btn btn-light\" style=\"float:right; margin-top:50%;\" value=\"Anterior\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1605, "\"", 1679, 3);
            WriteAttributeValue("", 1615, "location.href=\'#", 1615, 16, true);
#line 38 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 1631, Html.DisplayFor(modelItem => item.NumPassoAnt), 1631, 47, false);

#line default
#line hidden
            WriteAttributeValue("", 1678, "\'", 1678, 1, true);
            EndWriteAttribute();
            BeginContext(1680, 124, true);
            WriteLiteral(" ;\" />\r\n                    <input type=\"button\" class=\"btn btn-light\" style=\"float:right; margin-top:50%;\" value=\"Terminar\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1804, "\"", 1879, 3);
            WriteAttributeValue("", 1814, "location.href=\'#", 1814, 16, true);
#line 39 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 1830, Html.DisplayFor(modelItem => item.NumPassoProx), 1830, 48, false);

#line default
#line hidden
            WriteAttributeValue("", 1878, "\'", 1878, 1, true);
            EndWriteAttribute();
            BeginContext(1880, 121, true);
            WriteLiteral(" ;\" />\r\n                    <input type=\"button\" class=\"btn btn-light\" style=\"float:right; margin-top:50%;\" value=\"Ajuda\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2001, "\"", 2148, 3);
            WriteAttributeValue("", 2011, "location.href=\'", 2011, 15, true);
#line 40 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 2026, Html.Raw(@Url.Action("getPassosAuxiliar","Receitas", new { idReceita = item.Auxiliar, idReceitaInit = item.IdReceita })), 2026, 121, false);

#line default
#line hidden
            WriteAttributeValue("", 2147, "\'", 2147, 1, true);
            EndWriteAttribute();
            BeginContext(2149, 36, true);
            WriteLiteral(" ;\" />\r\n                </section>\r\n");
            EndContext();
#line 42 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(2233, 84, true);
            WriteLiteral("                <section class=\"resume-section p-3 p-lg-5 d-flex align-items-center\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2317, "\"", 2366, 1);
#line 45 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 2322, Html.DisplayFor(modelItem => item.NumPasso), 2322, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2367, 72, true);
            WriteLiteral(">\r\n                    <div class=\"w-100\">\r\n                        <h6>");
            EndContext();
            BeginContext(2440, 40, false);
#line 47 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Passo));

#line default
#line hidden
            EndContext();
            BeginContext(2480, 151, true);
            WriteLiteral("</h6>\r\n                    </div>\r\n                    <input type=\"button\" class=\"btn btn-light\" style=\"float:right; margin-top:50%;\" value=\"Anterior\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2631, "\"", 2705, 3);
            WriteAttributeValue("", 2641, "location.href=\'#", 2641, 16, true);
#line 49 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 2657, Html.DisplayFor(modelItem => item.NumPassoAnt), 2657, 47, false);

#line default
#line hidden
            WriteAttributeValue("", 2704, "\'", 2704, 1, true);
            EndWriteAttribute();
            BeginContext(2706, 124, true);
            WriteLiteral(" ;\" />\r\n                    <input type=\"button\" class=\"btn btn-light\" style=\"float:right; margin-top:50%;\" value=\"Terminar\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2830, "\"", 2929, 3);
            WriteAttributeValue("", 2840, "location.href=\'", 2840, 15, true);
#line 50 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 2855, Url.Action("getAvaliacao","Receitas",new { idReceita = item.IdReceita }), 2855, 73, false);

#line default
#line hidden
            WriteAttributeValue("", 2928, "\'", 2928, 1, true);
            EndWriteAttribute();
            BeginContext(2930, 36, true);
            WriteLiteral(" ;\" />\r\n                </section>\r\n");
            EndContext();
#line 52 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
            }
        }
        else
        {
            if (item.Type == "primeiro")
            {
                if (item.Auxiliar != -1)
                {

#line default
#line hidden
            BeginContext(3135, 88, true);
            WriteLiteral("                    <section class=\"resume-section p-3 p-lg-5 d-flex align-items-center\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3223, "\"", 3272, 1);
#line 60 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 3228, Html.DisplayFor(modelItem => item.NumPasso), 3228, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3273, 80, true);
            WriteLiteral(">\r\n                        <div class=\"w-100\">\r\n                            <h6>");
            EndContext();
            BeginContext(3354, 40, false);
#line 62 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Passo));

#line default
#line hidden
            EndContext();
            BeginContext(3394, 158, true);
            WriteLiteral("</h6>\r\n                        </div>\r\n                        <input type=\"button\" class=\"btn btn-light\" style=\"float:right; margin-top:50%;\" value=\"Proximo\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3552, "\"", 3627, 3);
            WriteAttributeValue("", 3562, "location.href=\'#", 3562, 16, true);
#line 64 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 3578, Html.DisplayFor(modelItem => item.NumPassoProx), 3578, 48, false);

#line default
#line hidden
            WriteAttributeValue("", 3626, "\'", 3626, 1, true);
            EndWriteAttribute();
            BeginContext(3628, 125, true);
            WriteLiteral(" ;\" />\r\n                        <input type=\"button\" class=\"btn btn-light\" style=\"float:right; margin-top:50%;\" value=\"Ajuda\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3753, "\"", 3900, 3);
            WriteAttributeValue("", 3763, "location.href=\'", 3763, 15, true);
#line 65 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 3778, Html.Raw(@Url.Action("getPassosAuxiliar","Receitas", new { idReceita = item.Auxiliar, idReceitaInit = item.IdReceita })), 3778, 121, false);

#line default
#line hidden
            WriteAttributeValue("", 3899, "\'", 3899, 1, true);
            EndWriteAttribute();
            BeginContext(3901, 40, true);
            WriteLiteral(" ;\" />\r\n                    </section>\r\n");
            EndContext();
#line 67 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(4001, 88, true);
            WriteLiteral("                    <section class=\"resume-section p-3 p-lg-5 d-flex align-items-center\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4089, "\"", 4138, 1);
#line 70 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 4094, Html.DisplayFor(modelItem => item.NumPasso), 4094, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4139, 80, true);
            WriteLiteral(">\r\n                        <div class=\"w-100\">\r\n                            <h6>");
            EndContext();
            BeginContext(4220, 40, false);
#line 72 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Passo));

#line default
#line hidden
            EndContext();
            BeginContext(4260, 158, true);
            WriteLiteral("</h6>\r\n                        </div>\r\n                        <input type=\"button\" class=\"btn btn-light\" style=\"float:right; margin-top:50%;\" value=\"Proximo\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4418, "\"", 4493, 3);
            WriteAttributeValue("", 4428, "location.href=\'#", 4428, 16, true);
#line 74 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 4444, Html.DisplayFor(modelItem => item.NumPassoProx), 4444, 48, false);

#line default
#line hidden
            WriteAttributeValue("", 4492, "\'", 4492, 1, true);
            EndWriteAttribute();
            BeginContext(4494, 40, true);
            WriteLiteral(" ;\" />\r\n                    </section>\r\n");
            EndContext();
#line 76 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
                }
            }
            else
            {
                if (item.Auxiliar != -1)
                {

#line default
#line hidden
            BeginContext(4662, 88, true);
            WriteLiteral("                    <section class=\"resume-section p-3 p-lg-5 d-flex align-items-center\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4750, "\"", 4799, 1);
#line 82 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 4755, Html.DisplayFor(modelItem => item.NumPasso), 4755, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4800, 80, true);
            WriteLiteral(">\r\n                        <div class=\"w-100\">\r\n                            <h6>");
            EndContext();
            BeginContext(4881, 40, false);
#line 84 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Passo));

#line default
#line hidden
            EndContext();
            BeginContext(4921, 159, true);
            WriteLiteral("</h6>\r\n                        </div>\r\n                        <input type=\"button\" class=\"btn btn-light\" style=\"float:right; margin-top:50%;\" value=\"Anterior\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5080, "\"", 5154, 3);
            WriteAttributeValue("", 5090, "location.href=\'#", 5090, 16, true);
#line 86 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 5106, Html.DisplayFor(modelItem => item.NumPassoAnt), 5106, 47, false);

#line default
#line hidden
            WriteAttributeValue("", 5153, "\'", 5153, 1, true);
            EndWriteAttribute();
            BeginContext(5155, 127, true);
            WriteLiteral(" ;\" />\r\n                        <input type=\"button\" class=\"btn btn-light\" style=\"float:right; margin-top:50%;\" value=\"Proximo\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5282, "\"", 5357, 3);
            WriteAttributeValue("", 5292, "location.href=\'#", 5292, 16, true);
#line 87 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 5308, Html.DisplayFor(modelItem => item.NumPassoProx), 5308, 48, false);

#line default
#line hidden
            WriteAttributeValue("", 5356, "\'", 5356, 1, true);
            EndWriteAttribute();
            BeginContext(5358, 125, true);
            WriteLiteral(" ;\" />\r\n                        <input type=\"button\" class=\"btn btn-light\" style=\"float:right; margin-top:50%;\" value=\"Ajuda\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5483, "\"", 5630, 3);
            WriteAttributeValue("", 5493, "location.href=\'", 5493, 15, true);
#line 88 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 5508, Html.Raw(@Url.Action("getPassosAuxiliar","Receitas", new { idReceita = item.Auxiliar, idReceitaInit = item.IdReceita })), 5508, 121, false);

#line default
#line hidden
            WriteAttributeValue("", 5629, "\'", 5629, 1, true);
            EndWriteAttribute();
            BeginContext(5631, 40, true);
            WriteLiteral(" ;\" />\r\n                    </section>\r\n");
            EndContext();
#line 90 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(5731, 88, true);
            WriteLiteral("                    <section class=\"resume-section p-3 p-lg-5 d-flex align-items-center\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5819, "\"", 5868, 1);
#line 93 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 5824, Html.DisplayFor(modelItem => item.NumPasso), 5824, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5869, 72, true);
            WriteLiteral(">\r\n                    <div class=\"w-100\">\r\n                        <h6>");
            EndContext();
            BeginContext(5942, 40, false);
#line 95 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Passo));

#line default
#line hidden
            EndContext();
            BeginContext(5982, 151, true);
            WriteLiteral("</h6>\r\n                    </div>\r\n                    <input type=\"button\" class=\"btn btn-light\" style=\"float:right; margin-top:50%;\" value=\"Anterior\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 6133, "\"", 6207, 3);
            WriteAttributeValue("", 6143, "location.href=\'#", 6143, 16, true);
#line 97 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 6159, Html.DisplayFor(modelItem => item.NumPassoAnt), 6159, 47, false);

#line default
#line hidden
            WriteAttributeValue("", 6206, "\'", 6206, 1, true);
            EndWriteAttribute();
            BeginContext(6208, 123, true);
            WriteLiteral(" ;\" />\r\n                    <input type=\"button\" class=\"btn btn-light\" style=\"float:right; margin-top:50%;\" value=\"Proximo\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 6331, "\"", 6406, 3);
            WriteAttributeValue("", 6341, "location.href=\'#", 6341, 16, true);
#line 98 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 6357, Html.DisplayFor(modelItem => item.NumPassoProx), 6357, 48, false);

#line default
#line hidden
            WriteAttributeValue("", 6405, "\'", 6405, 1, true);
            EndWriteAttribute();
            BeginContext(6407, 36, true);
            WriteLiteral(" ;\" />\r\n                </section>\r\n");
            EndContext();
#line 100 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
                }
            }
        }


#line default
#line hidden
            BeginContext(6490, 26, true);
            WriteLiteral("        <hr class=\"m-0\">\r\n");
            EndContext();
#line 105 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
    }

#line default
#line hidden
            BeginContext(6523, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<cookboard.Models.PassosViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
