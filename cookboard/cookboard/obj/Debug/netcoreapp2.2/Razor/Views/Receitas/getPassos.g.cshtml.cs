#pragma checksum "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b3d75479862d7266825e47798df22261390ba37"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b3d75479862d7266825e47798df22261390ba37", @"/Views/Receitas/getPassos.cshtml")]
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
            BeginContext(152, 547, true);
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
            BeginContext(756, 96, true);
            WriteLiteral("                <li class=\"nav-item\">\r\n                    <a class=\"nav-link js-scroll-trigger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 852, "\"", 904, 2);
            WriteAttributeValue("", 859, "#", 859, 1, true);
#line 19 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 860, Html.DisplayFor(modelItem => item.NumPasso), 860, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(905, 7, true);
            WriteLiteral(">Passo ");
            EndContext();
            BeginContext(913, 43, false);
#line 19 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
                                                                                                                Write(Html.DisplayFor(modelItem => item.NumPasso));

#line default
#line hidden
            EndContext();
            BeginContext(956, 29, true);
            WriteLiteral("</a>\r\n                </li>\r\n");
            EndContext();
#line 21 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
            }

#line default
#line hidden
            BeginContext(1000, 74, true);
            WriteLiteral("        </ul>\r\n    </div>\r\n</nav>\r\n\r\n<div class=\"container-fluid p-0\">\r\n\r\n");
            EndContext();
#line 28 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(1115, 76, true);
            WriteLiteral("        <section class=\"resume-section p-3 p-lg-5 d-flex align-items-center\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1191, "\"", 1240, 1);
#line 30 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
WriteAttributeValue("", 1196, Html.DisplayFor(modelItem => item.NumPasso), 1196, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1241, 56, true);
            WriteLiteral(">\r\n            <div class=\"w-100\">\r\n                <h6>");
            EndContext();
            BeginContext(1298, 40, false);
#line 32 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
               Write(Html.DisplayFor(modelItem => item.Passo));

#line default
#line hidden
            EndContext();
            BeginContext(1338, 47, true);
            WriteLiteral("</h6>\r\n            </div>\r\n        </section>\r\n");
            EndContext();
            BeginContext(1387, 26, true);
            WriteLiteral("        <hr class=\"m-0\">\r\n");
            EndContext();
#line 37 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getPassos.cshtml"
    }

#line default
#line hidden
            BeginContext(1420, 10, true);
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
