#pragma checksum "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getReceita.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68e81945c97df4f7a0dcbca472fed2faa41fd812"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Receitas_getReceita), @"mvc.1.0.view", @"/Views/Receitas/getReceita.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Receitas/getReceita.cshtml", typeof(AspNetCore.Views_Receitas_getReceita))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68e81945c97df4f7a0dcbca472fed2faa41fd812", @"/Views/Receitas/getReceita.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86a90c57a68cdbde153aed1e2defab61f9de9b49", @"/Views/_ViewImports.cshtml")]
    public class Views_Receitas_getReceita : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cookboard.Models.ReceitaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/clock-regular.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:15px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/star-half-alt-solid.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:15px;margin-top:-5px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/utensils-solid.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:13px;margin-top:-5px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/balance-scale-solid.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getReceita.cshtml"
  
    ViewBag.Title = "getReceita";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(131, 97, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <!-- Portfolio Item Heading -->\r\n    <h1 class=\"my-4\">\r\n        ");
            EndContext();
            BeginContext(229, 48, false);
#line 11 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getReceita.cshtml"
   Write(Html.DisplayFor(modelItem => Model.Receita.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(277, 139, true);
            WriteLiteral("\r\n    </h1>\r\n\r\n    <!-- Portfolio Item Row -->\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-md-8\">\r\n            <img class=\"img-fluid\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 416, "\"", 473, 1);
#line 18 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getReceita.cshtml"
WriteAttributeValue("", 422, Html.DisplayFor(modelItem => Model.Receita.Imagem), 422, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(474, 144, true);
            WriteLiteral(" style=\"height:290px;width:480px;\" alt=\"\">\r\n        </div>\r\n\r\n        <div class=\"col-md-4\">\r\n            <h3 class=\"my-3\">Ingredientes</h3>\r\n\r\n");
            EndContext();
#line 24 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getReceita.cshtml"
             foreach (var item in Model.Ingredientes)
            {

#line default
#line hidden
            BeginContext(688, 39, true);
            WriteLiteral("                <input type=\"checkbox\">");
            EndContext();
            BeginContext(728, 39, false);
#line 26 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getReceita.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(767, 6, true);
            WriteLiteral("<br>\r\n");
            EndContext();
#line 27 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getReceita.cshtml"
            }

#line default
#line hidden
            BeginContext(788, 79, true);
            WriteLiteral("        </div>\r\n\r\n        <ul style=\"list-style-type: none;\">\r\n            <li>");
            EndContext();
            BeginContext(867, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "68e81945c97df4f7a0dcbca472fed2faa41fd8128338", async() => {
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
            BeginContext(922, 20, true);
            WriteLiteral(" Tempo de confeção: ");
            EndContext();
            BeginContext(943, 57, false);
#line 31 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getReceita.cshtml"
                                                                                      Write(Html.DisplayFor(modelItem => Model.Receita.TempoConfecao));

#line default
#line hidden
            EndContext();
            BeginContext(1000, 23, true);
            WriteLiteral("</li>\r\n            <li>");
            EndContext();
            BeginContext(1023, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "68e81945c97df4f7a0dcbca472fed2faa41fd81210088", async() => {
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
            BeginContext(1100, 14, true);
            WriteLiteral(" Dificuldade: ");
            EndContext();
            BeginContext(1115, 55, false);
#line 32 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getReceita.cshtml"
                                                                                                      Write(Html.DisplayFor(modelItem => Model.Receita.Dificuldade));

#line default
#line hidden
            EndContext();
            BeginContext(1170, 23, true);
            WriteLiteral("</li>\r\n            <li>");
            EndContext();
            BeginContext(1193, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "68e81945c97df4f7a0dcbca472fed2faa41fd81211849", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1265, 9, true);
            WriteLiteral(" Porção: ");
            EndContext();
            BeginContext(1275, 50, false);
#line 33 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getReceita.cshtml"
                                                                                            Write(Html.DisplayFor(modelItem => Model.Receita.Porcao));

#line default
#line hidden
            EndContext();
            BeginContext(1325, 23, true);
            WriteLiteral("</li>\r\n            <h6>");
            EndContext();
            BeginContext(1348, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "68e81945c97df4f7a0dcbca472fed2faa41fd81213589", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1409, 46, true);
            WriteLiteral(" Informação Nutricional</h6>\r\n            <li>");
            EndContext();
            BeginContext(1456, 59, false);
#line 35 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Receitas\getReceita.cshtml"
           Write(Html.DisplayFor(modelItem => Model.Receita.InfoNutricional));

#line default
#line hidden
            EndContext();
            BeginContext(1515, 293, true);
            WriteLiteral(@"</li>
        </ul>
    </div>
    <input type=""button"" class=""btn btn-outline-light-light text-dark"" value=""Localizar Ingredientes"" onclick=""location.href='';"" />
    <input type=""button"" class=""btn btn-outline-light-light text-dark"" value=""Iniciar"" onclick=""location.href='';"" />
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cookboard.Models.ReceitaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
