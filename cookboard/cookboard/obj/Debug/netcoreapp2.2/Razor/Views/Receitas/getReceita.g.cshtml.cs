#pragma checksum "C:\Users\marta\OneDrive\Área de Trabalho\LI4\cookboard\cookboard\Views\Receitas\getReceita.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4155bdea0d613e7efd83256d13b09a0f08a0e5bf"
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
#line 1 "C:\Users\marta\OneDrive\Área de Trabalho\LI4\cookboard\cookboard\Views\_ViewImports.cshtml"
using cookboard;

#line default
#line hidden
#line 2 "C:\Users\marta\OneDrive\Área de Trabalho\LI4\cookboard\cookboard\Views\_ViewImports.cshtml"
using cookboard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4155bdea0d613e7efd83256d13b09a0f08a0e5bf", @"/Views/Receitas/getReceita.cshtml")]
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
#line 2 "C:\Users\marta\OneDrive\Área de Trabalho\LI4\cookboard\cookboard\Views\Receitas\getReceita.cshtml"
  
    ViewBag.Title = "getReceita";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(131, 97, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <!-- Portfolio Item Heading -->\r\n    <h1 class=\"my-4\">\r\n        ");
            EndContext();
            BeginContext(229, 48, false);
#line 11 "C:\Users\marta\OneDrive\Área de Trabalho\LI4\cookboard\cookboard\Views\Receitas\getReceita.cshtml"
   Write(Html.DisplayFor(modelItem => Model.Receita.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(277, 97, true);
            WriteLiteral("\r\n        <input type=\"button\" class=\"btn btn-light\" style=\"float:right;\" value=\"Iniciar Receita\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 374, "\"", 474, 3);
            WriteAttributeValue("", 384, "location.href=\'", 384, 15, true);
#line 12 "C:\Users\marta\OneDrive\Área de Trabalho\LI4\cookboard\cookboard\Views\Receitas\getReceita.cshtml"
WriteAttributeValue("", 399, Url.Action("getPassos","Receitas", new { idReceita = Model.Receita.Id }), 399, 73, false);

#line default
#line hidden
            WriteAttributeValue("", 472, "\';", 472, 2, true);
            EndWriteAttribute();
            BeginContext(475, 207, true);
            WriteLiteral(" />\r\n    </h1>\r\n\r\n    <!-- Portfolio Item Row -->\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-md-6\">\r\n            <div class=\"receita\" style=\"margin-left:20px;\">\r\n                <img class=\"img-fluid\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 682, "\"", 739, 1);
#line 20 "C:\Users\marta\OneDrive\Área de Trabalho\LI4\cookboard\cookboard\Views\Receitas\getReceita.cshtml"
WriteAttributeValue("", 688, Html.DisplayFor(modelItem => Model.Receita.Imagem), 688, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(740, 170, true);
            WriteLiteral(" style=\"height:290px;width:480px;border-radius: 5px;\" alt=\"\">\r\n            </div>\r\n            <ul style=\"list-style-type: none; margin-top: 10px;\">\r\n                <li>");
            EndContext();
            BeginContext(910, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4155bdea0d613e7efd83256d13b09a0f08a0e5bf8148", async() => {
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
            BeginContext(965, 20, true);
            WriteLiteral(" Tempo de confeção: ");
            EndContext();
            BeginContext(986, 57, false);
#line 23 "C:\Users\marta\OneDrive\Área de Trabalho\LI4\cookboard\cookboard\Views\Receitas\getReceita.cshtml"
                                                                                          Write(Html.DisplayFor(modelItem => Model.Receita.TempoConfecao));

#line default
#line hidden
            EndContext();
            BeginContext(1043, 27, true);
            WriteLiteral("</li>\r\n                <li>");
            EndContext();
            BeginContext(1070, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4155bdea0d613e7efd83256d13b09a0f08a0e5bf9916", async() => {
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
            BeginContext(1147, 14, true);
            WriteLiteral(" Dificuldade: ");
            EndContext();
            BeginContext(1162, 55, false);
#line 24 "C:\Users\marta\OneDrive\Área de Trabalho\LI4\cookboard\cookboard\Views\Receitas\getReceita.cshtml"
                                                                                                          Write(Html.DisplayFor(modelItem => Model.Receita.Dificuldade));

#line default
#line hidden
            EndContext();
            BeginContext(1217, 27, true);
            WriteLiteral("</li>\r\n                <li>");
            EndContext();
            BeginContext(1244, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4155bdea0d613e7efd83256d13b09a0f08a0e5bf11694", async() => {
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
            BeginContext(1316, 9, true);
            WriteLiteral(" Porção: ");
            EndContext();
            BeginContext(1326, 50, false);
#line 25 "C:\Users\marta\OneDrive\Área de Trabalho\LI4\cookboard\cookboard\Views\Receitas\getReceita.cshtml"
                                                                                                Write(Html.DisplayFor(modelItem => Model.Receita.Porcao));

#line default
#line hidden
            EndContext();
            BeginContext(1376, 49, true);
            WriteLiteral("</li>\r\n                <hr>\r\n                <h6>");
            EndContext();
            BeginContext(1425, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4155bdea0d613e7efd83256d13b09a0f08a0e5bf13476", async() => {
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
            BeginContext(1486, 50, true);
            WriteLiteral(" Informação Nutricional</h6>\r\n                <li>");
            EndContext();
            BeginContext(1537, 59, false);
#line 28 "C:\Users\marta\OneDrive\Área de Trabalho\LI4\cookboard\cookboard\Views\Receitas\getReceita.cshtml"
               Write(Html.DisplayFor(modelItem => Model.Receita.InfoNutricional));

#line default
#line hidden
            EndContext();
            BeginContext(1596, 187, true);
            WriteLiteral("</li>\r\n            </ul>\r\n        </div>\r\n\r\n        <div class=\"col-md-6\">\r\n            <div class=\"ing\" style=\"margin-left:40px;\">\r\n                <h3 class=\"my-3\">Ingredientes</h3>\r\n\r\n");
            EndContext();
#line 36 "C:\Users\marta\OneDrive\Área de Trabalho\LI4\cookboard\cookboard\Views\Receitas\getReceita.cshtml"
                 foreach (var item in Model.Ingredientes)
                {

#line default
#line hidden
            BeginContext(1861, 44, true);
            WriteLiteral("                    <input type=\"checkbox\"> ");
            EndContext();
            BeginContext(1906, 45, false);
#line 38 "C:\Users\marta\OneDrive\Área de Trabalho\LI4\cookboard\cookboard\Views\Receitas\getReceita.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Quantidade));

#line default
#line hidden
            EndContext();
            BeginContext(1953, 51, false);
#line 38 "C:\Users\marta\OneDrive\Área de Trabalho\LI4\cookboard\cookboard\Views\Receitas\getReceita.cshtml"
                                                                                      Write(Html.DisplayFor(modelItem => item.Ingrediente.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(2004, 6, true);
            WriteLiteral("<br>\r\n");
            EndContext();
#line 39 "C:\Users\marta\OneDrive\Área de Trabalho\LI4\cookboard\cookboard\Views\Receitas\getReceita.cshtml"
                }

#line default
#line hidden
            BeginContext(2029, 110, true);
            WriteLiteral("                <input type=\"button\" class=\"btn btn-light\" style=\"float:right;\" value=\"Localizar Ingredientes\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2139, "\"", 2252, 3);
            WriteAttributeValue("", 2149, "location.href=\'", 2149, 15, true);
#line 40 "C:\Users\marta\OneDrive\Área de Trabalho\LI4\cookboard\cookboard\Views\Receitas\getReceita.cshtml"
WriteAttributeValue("", 2164, Url.Action("getLocalizacao","LocalIngrediente", new { idReceita = Model.Receita.Id }), 2164, 86, false);

#line default
#line hidden
            WriteAttributeValue("", 2250, "\';", 2250, 2, true);
            EndWriteAttribute();
            BeginContext(2253, 65, true);
            WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n    \r\n</div>");
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
