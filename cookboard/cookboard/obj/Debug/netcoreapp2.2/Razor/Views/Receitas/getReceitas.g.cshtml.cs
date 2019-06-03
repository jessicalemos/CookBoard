#pragma checksum "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\Receitas\getReceitas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3cff8156ebc440aa16115230dcd66460c82b49e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Receitas_getReceitas), @"mvc.1.0.view", @"/Views/Receitas/getReceitas.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Receitas/getReceitas.cshtml", typeof(AspNetCore.Views_Receitas_getReceitas))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3cff8156ebc440aa16115230dcd66460c82b49e", @"/Views/Receitas/getReceitas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86a90c57a68cdbde153aed1e2defab61f9de9b49", @"/Views/_ViewImports.cshtml")]
    public class Views_Receitas_getReceitas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<cookboard.Models.Receita>>
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
#line 2 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\Receitas\getReceitas.cshtml"
  
        ViewBag.Title = "getReceitas";
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
            BeginContext(446, 135, true);
            WriteLiteral("\r\n<section class=\"resume-section p-3 p-lg-5 d-flex flex-column\" id=\"interests\">\r\n    <div class=\"my-auto\">\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 20 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\Receitas\getReceitas.cshtml"
             foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(630, 88, true);
            WriteLiteral("                <div class=\"col-lg-4 col-sm-6 text-center mb-4\">\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 718, "\'", 790, 1);
#line 23 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\Receitas\getReceitas.cshtml"
WriteAttributeValue("", 725, Url.Action("getReceita","Receitas", new { idReceita = item.Id }), 725, 65, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(791, 66, true);
            WriteLiteral(">\r\n                        <img class=\"img-fluid3 d-block mx-auto\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 857, "\"", 905, 1);
#line 24 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\Receitas\getReceitas.cshtml"
WriteAttributeValue("", 863, Html.DisplayFor(modelItem => item.Imagem), 863, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(906, 93, true);
            WriteLiteral(" alt=\"\" style=\"width:320px; height:180px; border-radius: 5px;\">\r\n                        <h3>");
            EndContext();
            BeginContext(1000, 39, false);
#line 25 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\Receitas\getReceitas.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1039, 76, true);
            WriteLiteral("</h3>\r\n                    </a>\r\n                    <p class=\"description\">");
            EndContext();
            BeginContext(1115, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c3cff8156ebc440aa16115230dcd66460c82b49e7260", async() => {
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
            BeginContext(1192, 20, true);
            WriteLiteral("&nbsp; Dificuldade: ");
            EndContext();
            BeginContext(1213, 46, false);
#line 27 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\Receitas\getReceitas.cshtml"
                                                                                                                                       Write(Html.DisplayFor(modelItem => item.Dificuldade));

#line default
#line hidden
            EndContext();
            BeginContext(1259, 7, true);
            WriteLiteral(" &nbsp;");
            EndContext();
            BeginContext(1266, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c3cff8156ebc440aa16115230dcd66460c82b49e9027", async() => {
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
            BeginContext(1321, 7, true);
            WriteLiteral("Tempo: ");
            EndContext();
            BeginContext(1329, 48, false);
#line 27 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\Receitas\getReceitas.cshtml"
                                                                                                                                                                                                                                                           Write(Html.DisplayFor(modelItem => item.TempoConfecao));

#line default
#line hidden
            EndContext();
            BeginContext(1377, 34, true);
            WriteLiteral("<br></p>\r\n                </div>\r\n");
            EndContext();
#line 29 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\Receitas\getReceitas.cshtml"
            }

#line default
#line hidden
            BeginContext(1426, 40, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n");
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
