#pragma checksum "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Home\Pesquisa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af7694d77614570994d211b430b130b6e1341cd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Pesquisa), @"mvc.1.0.view", @"/Views/Home/Pesquisa.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Pesquisa.cshtml", typeof(AspNetCore.Views_Home_Pesquisa))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af7694d77614570994d211b430b130b6e1341cd5", @"/Views/Home/Pesquisa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86a90c57a68cdbde153aed1e2defab61f9de9b49", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Pesquisa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<cookboard.Models.Receita>>
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
#line 2 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Home\Pesquisa.cshtml"
  
    ViewBag.Title = "Pesquisa";
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
            BeginContext(395, 262, true);
            WriteLiteral(@"<div style=""margin-left: 24px; font-weight: 900; font-size: 30px; padding-bottom: 20px;"">Resultados da Pesquisa</div>

<hr />
<section class=""resume-section p-3 p-lg-5 d-flex flex-column"" id=""interests"">
    <div class=""my-auto"">
        <div class=""row"">
");
            EndContext();
#line 22 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Home\Pesquisa.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(714, 88, true);
            WriteLiteral("                <div class=\"col-lg-4 col-sm-6 text-center mb-4\">\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 802, "\'", 874, 1);
#line 25 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Home\Pesquisa.cshtml"
WriteAttributeValue("", 809, Url.Action("getReceita","Receitas", new { idReceita = item.Id }), 809, 65, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(875, 66, true);
            WriteLiteral(">\r\n                        <img class=\"img-fluid3 d-block mx-auto\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 941, "\"", 989, 1);
#line 26 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Home\Pesquisa.cshtml"
WriteAttributeValue("", 947, Html.DisplayFor(modelItem => item.Imagem), 947, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(990, 93, true);
            WriteLiteral(" alt=\"\" style=\"width:320px; height:180px; border-radius: 5px;\">\r\n                        <h3>");
            EndContext();
            BeginContext(1084, 39, false);
#line 27 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Home\Pesquisa.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1123, 76, true);
            WriteLiteral("</h3>\r\n                    </a>\r\n                    <p class=\"description\">");
            EndContext();
            BeginContext(1199, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "af7694d77614570994d211b430b130b6e1341cd57293", async() => {
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
            BeginContext(1276, 20, true);
            WriteLiteral("&nbsp; Dificuldade: ");
            EndContext();
            BeginContext(1297, 46, false);
#line 29 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Home\Pesquisa.cshtml"
                                                                                                                                       Write(Html.DisplayFor(modelItem => item.Dificuldade));

#line default
#line hidden
            EndContext();
            BeginContext(1343, 7, true);
            WriteLiteral(" &nbsp;");
            EndContext();
            BeginContext(1350, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "af7694d77614570994d211b430b130b6e1341cd59058", async() => {
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
            BeginContext(1405, 7, true);
            WriteLiteral("Tempo: ");
            EndContext();
            BeginContext(1413, 48, false);
#line 29 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Home\Pesquisa.cshtml"
                                                                                                                                                                                                                                                           Write(Html.DisplayFor(modelItem => item.TempoConfecao));

#line default
#line hidden
            EndContext();
            BeginContext(1461, 34, true);
            WriteLiteral("<br></p>\r\n                </div>\r\n");
            EndContext();
#line 31 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Home\Pesquisa.cshtml"
            }

#line default
#line hidden
            BeginContext(1510, 44, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n");
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
