#pragma checksum "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\EmentaSemanal\getEmentaSemanal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9fdf20ddbfd1105b1c0eb8b50324a140bc10370"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmentaSemanal_getEmentaSemanal), @"mvc.1.0.view", @"/Views/EmentaSemanal/getEmentaSemanal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EmentaSemanal/getEmentaSemanal.cshtml", typeof(AspNetCore.Views_EmentaSemanal_getEmentaSemanal))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9fdf20ddbfd1105b1c0eb8b50324a140bc10370", @"/Views/EmentaSemanal/getEmentaSemanal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86a90c57a68cdbde153aed1e2defab61f9de9b49", @"/Views/_ViewImports.cshtml")]
    public class Views_EmentaSemanal_getEmentaSemanal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<cookboard.Models.EmentaViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/star-half-alt-solid.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:15px;margin-top:-5px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/clock-regular.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:15px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\EmentaSemanal\getEmentaSemanal.cshtml"
  
    ViewBag.Title = "getEmentaSemanal";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(151, 166, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h1 class=\"my-4\">Ementa Semanal</h1>\r\n    <input type=\"button\" class=\"btn btn-outline-light-light text-dark\" value=\"Lista Ingredientes\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 317, "\"", 390, 3);
            WriteAttributeValue("", 327, "location.href=\'", 327, 15, true);
#line 10 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\EmentaSemanal\getEmentaSemanal.cshtml"
WriteAttributeValue("", 342, Url.Action("getIngredientes","EmentaSemanal"), 342, 46, false);

#line default
#line hidden
            WriteAttributeValue("", 388, "\';", 388, 2, true);
            EndWriteAttribute();
            BeginContext(391, 7, true);
            WriteLiteral(" />\r\n\r\n");
            EndContext();
#line 12 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\EmentaSemanal\getEmentaSemanal.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(439, 170, true);
            WriteLiteral("        <hr>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-7\">\r\n                <a href=\"#\">\r\n                    <img class=\"img-fluid rounded mb-3 mb-md-0\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 609, "\"", 665, 1);
#line 18 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\EmentaSemanal\getEmentaSemanal.cshtml"
WriteAttributeValue("", 615, Html.DisplayFor(modelItem => item.Receita.Imagem), 615, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(666, 137, true);
            WriteLiteral(" alt=\"\" style=\"height:90%;width:90%\">\r\n                </a>\r\n            </div>\r\n            <div class=\"col-md-5\">\r\n                <h1>");
            EndContext();
            BeginContext(804, 38, false);
#line 22 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\EmentaSemanal\getEmentaSemanal.cshtml"
               Write(Html.DisplayFor(modelItem => item.Dia));

#line default
#line hidden
            EndContext();
            BeginContext(842, 27, true);
            WriteLiteral("</h1>\r\n                <h4>");
            EndContext();
            BeginContext(870, 47, false);
#line 23 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\EmentaSemanal\getEmentaSemanal.cshtml"
               Write(Html.DisplayFor(modelItem => item.Receita.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(917, 26, true);
            WriteLiteral("</h4>\r\n                <p>");
            EndContext();
            BeginContext(943, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a9fdf20ddbfd1105b1c0eb8b50324a140bc103707818", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1020, 20, true);
            WriteLiteral("&nbsp; Dificuldade: ");
            EndContext();
            BeginContext(1041, 54, false);
#line 24 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\EmentaSemanal\getEmentaSemanal.cshtml"
                                                                                                               Write(Html.DisplayFor(modelItem => item.Receita.Dificuldade));

#line default
#line hidden
            EndContext();
            BeginContext(1095, 25, true);
            WriteLiteral("</p>\r\n                <p>");
            EndContext();
            BeginContext(1120, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a9fdf20ddbfd1105b1c0eb8b50324a140bc103709605", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1175, 14, true);
            WriteLiteral("&nbsp; Tempo: ");
            EndContext();
            BeginContext(1190, 56, false);
#line 25 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\EmentaSemanal\getEmentaSemanal.cshtml"
                                                                                   Write(Html.DisplayFor(modelItem => item.Receita.TempoConfecao));

#line default
#line hidden
            EndContext();
            BeginContext(1246, 106, true);
            WriteLiteral("</p>\r\n                <input type=\"button\" class=\"btn btn-outline-light-light text-dark\" value=\"Consultar\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1352, "\"", 1452, 3);
            WriteAttributeValue("", 1362, "location.href=\'", 1362, 15, true);
#line 26 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\EmentaSemanal\getEmentaSemanal.cshtml"
WriteAttributeValue("", 1377, Url.Action("getReceita","Receitas", new { idReceita = item.Receita.Id }), 1377, 73, false);

#line default
#line hidden
            WriteAttributeValue("", 1450, "\';", 1450, 2, true);
            EndWriteAttribute();
            BeginContext(1453, 41, true);
            WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 29 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\EmentaSemanal\getEmentaSemanal.cshtml"
    }

#line default
#line hidden
            BeginContext(1501, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<cookboard.Models.EmentaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
