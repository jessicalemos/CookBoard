#pragma checksum "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0c1efc0ea5a8c7867baaec32460d4210635ba9d"
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
#line 1 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\_ViewImports.cshtml"
using cookboard;

#line default
#line hidden
#line 2 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\_ViewImports.cshtml"
using cookboard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0c1efc0ea5a8c7867baaec32460d4210635ba9d", @"/Views/Receitas/getPassos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86a90c57a68cdbde153aed1e2defab61f9de9b49", @"/Views/_ViewImports.cshtml")]
    public class Views_Receitas_getPassos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<cookboard.Models.PassosViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
  
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
#line 16 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(748, 96, true);
            WriteLiteral("                <li class=\"nav-item\">\r\n                    <a class=\"nav-link js-scroll-trigger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 844, "\"", 896, 2);
            WriteAttributeValue("", 851, "#", 851, 1, true);
#line 19 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 852, Html.DisplayFor(modelItem => item.NumPasso), 852, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(897, 7, true);
            WriteLiteral(">Passo ");
            EndContext();
            BeginContext(905, 43, false);
#line 19 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
                                                                                                                Write(Html.DisplayFor(modelItem => item.NumPasso));

#line default
#line hidden
            EndContext();
            BeginContext(948, 29, true);
            WriteLiteral("</a>\r\n                </li>\r\n");
            EndContext();
#line 21 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
            }

#line default
#line hidden
            BeginContext(992, 74, true);
            WriteLiteral("        </ul>\r\n    </div>\r\n</nav>\r\n\r\n<div class=\"container-fluid p-0\">\r\n\r\n");
            EndContext();
#line 28 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
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
#line 34 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 1296, Html.DisplayFor(modelItem => item.NumPasso), 1296, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1341, 72, true);
            WriteLiteral(">\r\n                    <div class=\"w-100\">\r\n                        <h6>");
            EndContext();
            BeginContext(1414, 40, false);
#line 36 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Passo));

#line default
#line hidden
            EndContext();
            BeginContext(1454, 151, true);
            WriteLiteral("</h6>\r\n                    </div>\r\n                    <input type=\"button\" class=\"btn btn-light\" style=\"float:right; margin-top:50%;\" value=\"Anterior\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1605, "\"", 1679, 3);
            WriteAttributeValue("", 1615, "location.href=\'#", 1615, 16, true);
#line 38 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
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
#line 39 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
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
#line 40 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 2026, Html.Raw(@Url.Action("getPassosAuxiliar","Receitas", new { idReceita = item.Auxiliar, idReceitaInit = item.IdReceita })), 2026, 121, false);

#line default
#line hidden
            WriteAttributeValue("", 2147, "\'", 2147, 1, true);
            EndWriteAttribute();
            BeginContext(2149, 36, true);
            WriteLiteral(" ;\" />\r\n                </section>\r\n");
            EndContext();
#line 42 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(2233, 84, true);
            WriteLiteral("                <section class=\"resume-section p-3 p-lg-5 d-flex align-items-center\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2317, "\"", 2366, 1);
#line 45 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 2322, Html.DisplayFor(modelItem => item.NumPasso), 2322, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2367, 72, true);
            WriteLiteral(">\r\n                    <div class=\"w-100\">\r\n                        <h6>");
            EndContext();
            BeginContext(2440, 40, false);
#line 47 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Passo));

#line default
#line hidden
            EndContext();
            BeginContext(2480, 151, true);
            WriteLiteral("</h6>\r\n                    </div>\r\n                    <input type=\"button\" class=\"btn btn-light\" style=\"float:right; margin-top:50%;\" value=\"Anterior\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2631, "\"", 2705, 3);
            WriteAttributeValue("", 2641, "location.href=\'#", 2641, 16, true);
#line 49 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 2657, Html.DisplayFor(modelItem => item.NumPassoAnt), 2657, 47, false);

#line default
#line hidden
            WriteAttributeValue("", 2704, "\'", 2704, 1, true);
            EndWriteAttribute();
            BeginContext(2706, 124, true);
            WriteLiteral(" ;\" />\r\n                    <input type=\"button\" class=\"btn btn-light\" style=\"float:right; margin-top:50%;\" value=\"Terminar\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2830, "\"", 2905, 3);
            WriteAttributeValue("", 2840, "location.href=\'#", 2840, 16, true);
#line 50 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 2856, Html.DisplayFor(modelItem => item.NumPassoProx), 2856, 48, false);

#line default
#line hidden
            WriteAttributeValue("", 2904, "\'", 2904, 1, true);
            EndWriteAttribute();
            BeginContext(2906, 36, true);
            WriteLiteral(" ;\" />\r\n                </section>\r\n");
            EndContext();
#line 52 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
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
            BeginContext(3111, 88, true);
            WriteLiteral("                    <section class=\"resume-section p-3 p-lg-5 d-flex align-items-center\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3199, "\"", 3248, 1);
#line 60 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 3204, Html.DisplayFor(modelItem => item.NumPasso), 3204, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3249, 80, true);
            WriteLiteral(">\r\n                        <div class=\"w-100\">\r\n                            <h6>");
            EndContext();
            BeginContext(3330, 40, false);
#line 62 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Passo));

#line default
#line hidden
            EndContext();
            BeginContext(3370, 158, true);
            WriteLiteral("</h6>\r\n                        </div>\r\n                        <input type=\"button\" class=\"btn btn-light\" style=\"float:right; margin-top:50%;\" value=\"Proximo\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3528, "\"", 3603, 3);
            WriteAttributeValue("", 3538, "location.href=\'#", 3538, 16, true);
#line 64 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 3554, Html.DisplayFor(modelItem => item.NumPassoProx), 3554, 48, false);

#line default
#line hidden
            WriteAttributeValue("", 3602, "\'", 3602, 1, true);
            EndWriteAttribute();
            BeginContext(3604, 125, true);
            WriteLiteral(" ;\" />\r\n                        <input type=\"button\" class=\"btn btn-light\" style=\"float:right; margin-top:50%;\" value=\"Ajuda\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3729, "\"", 3876, 3);
            WriteAttributeValue("", 3739, "location.href=\'", 3739, 15, true);
#line 65 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 3754, Html.Raw(@Url.Action("getPassosAuxiliar","Receitas", new { idReceita = item.Auxiliar, idReceitaInit = item.IdReceita })), 3754, 121, false);

#line default
#line hidden
            WriteAttributeValue("", 3875, "\'", 3875, 1, true);
            EndWriteAttribute();
            BeginContext(3877, 40, true);
            WriteLiteral(" ;\" />\r\n                    </section>\r\n");
            EndContext();
#line 67 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(3977, 88, true);
            WriteLiteral("                    <section class=\"resume-section p-3 p-lg-5 d-flex align-items-center\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4065, "\"", 4114, 1);
#line 70 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 4070, Html.DisplayFor(modelItem => item.NumPasso), 4070, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4115, 80, true);
            WriteLiteral(">\r\n                        <div class=\"w-100\">\r\n                            <h6>");
            EndContext();
            BeginContext(4196, 40, false);
#line 72 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Passo));

#line default
#line hidden
            EndContext();
            BeginContext(4236, 158, true);
            WriteLiteral("</h6>\r\n                        </div>\r\n                        <input type=\"button\" class=\"btn btn-light\" style=\"float:right; margin-top:50%;\" value=\"Proximo\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4394, "\"", 4469, 3);
            WriteAttributeValue("", 4404, "location.href=\'#", 4404, 16, true);
#line 74 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 4420, Html.DisplayFor(modelItem => item.NumPassoProx), 4420, 48, false);

#line default
#line hidden
            WriteAttributeValue("", 4468, "\'", 4468, 1, true);
            EndWriteAttribute();
            BeginContext(4470, 40, true);
            WriteLiteral(" ;\" />\r\n                    </section>\r\n");
            EndContext();
#line 76 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
                }
            }
            else
            {
                if (item.Auxiliar != -1)
                {

#line default
#line hidden
            BeginContext(4638, 88, true);
            WriteLiteral("                    <section class=\"resume-section p-3 p-lg-5 d-flex align-items-center\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4726, "\"", 4775, 1);
#line 82 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 4731, Html.DisplayFor(modelItem => item.NumPasso), 4731, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4776, 80, true);
            WriteLiteral(">\r\n                        <div class=\"w-100\">\r\n                            <h6>");
            EndContext();
            BeginContext(4857, 40, false);
#line 84 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Passo));

#line default
#line hidden
            EndContext();
            BeginContext(4897, 159, true);
            WriteLiteral("</h6>\r\n                        </div>\r\n                        <input type=\"button\" class=\"btn btn-light\" style=\"float:right; margin-top:50%;\" value=\"Anterior\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5056, "\"", 5130, 3);
            WriteAttributeValue("", 5066, "location.href=\'#", 5066, 16, true);
#line 86 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 5082, Html.DisplayFor(modelItem => item.NumPassoAnt), 5082, 47, false);

#line default
#line hidden
            WriteAttributeValue("", 5129, "\'", 5129, 1, true);
            EndWriteAttribute();
            BeginContext(5131, 127, true);
            WriteLiteral(" ;\" />\r\n                        <input type=\"button\" class=\"btn btn-light\" style=\"float:right; margin-top:50%;\" value=\"Proximo\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5258, "\"", 5333, 3);
            WriteAttributeValue("", 5268, "location.href=\'#", 5268, 16, true);
#line 87 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 5284, Html.DisplayFor(modelItem => item.NumPassoProx), 5284, 48, false);

#line default
#line hidden
            WriteAttributeValue("", 5332, "\'", 5332, 1, true);
            EndWriteAttribute();
            BeginContext(5334, 125, true);
            WriteLiteral(" ;\" />\r\n                        <input type=\"button\" class=\"btn btn-light\" style=\"float:right; margin-top:50%;\" value=\"Ajuda\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5459, "\"", 5606, 3);
            WriteAttributeValue("", 5469, "location.href=\'", 5469, 15, true);
#line 88 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 5484, Html.Raw(@Url.Action("getPassosAuxiliar","Receitas", new { idReceita = item.Auxiliar, idReceitaInit = item.IdReceita })), 5484, 121, false);

#line default
#line hidden
            WriteAttributeValue("", 5605, "\'", 5605, 1, true);
            EndWriteAttribute();
            BeginContext(5607, 40, true);
            WriteLiteral(" ;\" />\r\n                    </section>\r\n");
            EndContext();
#line 90 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(5707, 88, true);
            WriteLiteral("                    <section class=\"resume-section p-3 p-lg-5 d-flex align-items-center\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5795, "\"", 5844, 1);
#line 93 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 5800, Html.DisplayFor(modelItem => item.NumPasso), 5800, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5845, 72, true);
            WriteLiteral(">\r\n                    <div class=\"w-100\">\r\n                        <h6>");
            EndContext();
            BeginContext(5918, 40, false);
#line 95 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Passo));

#line default
#line hidden
            EndContext();
            BeginContext(5958, 151, true);
            WriteLiteral("</h6>\r\n                    </div>\r\n                    <input type=\"button\" class=\"btn btn-light\" style=\"float:right; margin-top:50%;\" value=\"Anterior\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 6109, "\"", 6183, 3);
            WriteAttributeValue("", 6119, "location.href=\'#", 6119, 16, true);
#line 97 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 6135, Html.DisplayFor(modelItem => item.NumPassoAnt), 6135, 47, false);

#line default
#line hidden
            WriteAttributeValue("", 6182, "\'", 6182, 1, true);
            EndWriteAttribute();
            BeginContext(6184, 123, true);
            WriteLiteral(" ;\" />\r\n                    <input type=\"button\" class=\"btn btn-light\" style=\"float:right; margin-top:50%;\" value=\"Proximo\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 6307, "\"", 6382, 3);
            WriteAttributeValue("", 6317, "location.href=\'#", 6317, 16, true);
#line 98 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 6333, Html.DisplayFor(modelItem => item.NumPassoProx), 6333, 48, false);

#line default
#line hidden
            WriteAttributeValue("", 6381, "\'", 6381, 1, true);
            EndWriteAttribute();
            BeginContext(6383, 36, true);
            WriteLiteral(" ;\" />\r\n                </section>\r\n");
            EndContext();
#line 100 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
                }
            }
        }


#line default
#line hidden
            BeginContext(6466, 26, true);
            WriteLiteral("        <hr class=\"m-0\">\r\n");
            EndContext();
#line 105 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
    }

#line default
#line hidden
            BeginContext(6499, 10, true);
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
