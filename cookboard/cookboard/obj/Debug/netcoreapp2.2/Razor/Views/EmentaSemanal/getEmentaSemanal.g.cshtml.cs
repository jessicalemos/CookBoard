#pragma checksum "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\EmentaSemanal\getEmentaSemanal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a35dc9724b79259e15905525d012dded3e88e818"
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
#line 1 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\_ViewImports.cshtml"
using cookboard;

#line default
#line hidden
#line 2 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\_ViewImports.cshtml"
using cookboard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a35dc9724b79259e15905525d012dded3e88e818", @"/Views/EmentaSemanal/getEmentaSemanal.cshtml")]
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
#line 3 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\EmentaSemanal\getEmentaSemanal.cshtml"
  
    string u = (string) TempData["Utilizador"];
    if (u.Equals("Professor")){
        Layout = "~/Views/Shared/_LayoutProfessor.cshtml";

    }
    if (u.Equals("Aluno"))
    {
        Layout = "~/Views/Shared/_LayoutAluno.cshtml";

    }
    ViewBag.Title = "getEmentaSemanal";

#line default
#line hidden
            BeginContext(355, 142, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h1 class=\"my-4\">Ementa Semanal</h1>\r\n    <input type=\"button\" class=\"btn btn-light\" value=\"Lista Ingredientes\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 497, "\"", 570, 3);
            WriteAttributeValue("", 507, "location.href=\'", 507, 15, true);
#line 19 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\EmentaSemanal\getEmentaSemanal.cshtml"
WriteAttributeValue("", 522, Url.Action("getIngredientes","EmentaSemanal"), 522, 46, false);

#line default
#line hidden
            WriteAttributeValue("", 568, "\';", 568, 2, true);
            EndWriteAttribute();
            BeginContext(571, 7, true);
            WriteLiteral(" />\r\n\r\n");
            EndContext();
#line 21 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\EmentaSemanal\getEmentaSemanal.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(619, 170, true);
            WriteLiteral("        <hr>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-7\">\r\n                <a href=\"#\">\r\n                    <img class=\"img-fluid rounded mb-3 mb-md-0\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 789, "\"", 845, 1);
#line 27 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\EmentaSemanal\getEmentaSemanal.cshtml"
WriteAttributeValue("", 795, Html.DisplayFor(modelItem => item.Receita.Imagem), 795, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(846, 137, true);
            WriteLiteral(" alt=\"\" style=\"height:90%;width:90%\">\r\n                </a>\r\n            </div>\r\n            <div class=\"col-md-5\">\r\n                <h1>");
            EndContext();
            BeginContext(984, 38, false);
#line 31 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\EmentaSemanal\getEmentaSemanal.cshtml"
               Write(Html.DisplayFor(modelItem => item.Dia));

#line default
#line hidden
            EndContext();
            BeginContext(1022, 27, true);
            WriteLiteral("</h1>\r\n                <h4>");
            EndContext();
            BeginContext(1050, 47, false);
#line 32 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\EmentaSemanal\getEmentaSemanal.cshtml"
               Write(Html.DisplayFor(modelItem => item.Receita.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1097, 26, true);
            WriteLiteral("</h4>\r\n                <p>");
            EndContext();
            BeginContext(1123, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a35dc9724b79259e15905525d012dded3e88e8187957", async() => {
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
            BeginContext(1200, 20, true);
            WriteLiteral("&nbsp; Dificuldade: ");
            EndContext();
            BeginContext(1221, 54, false);
#line 33 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\EmentaSemanal\getEmentaSemanal.cshtml"
                                                                                                               Write(Html.DisplayFor(modelItem => item.Receita.Dificuldade));

#line default
#line hidden
            EndContext();
            BeginContext(1275, 25, true);
            WriteLiteral("</p>\r\n                <p>");
            EndContext();
            BeginContext(1300, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a35dc9724b79259e15905525d012dded3e88e8189739", async() => {
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
            BeginContext(1355, 14, true);
            WriteLiteral("&nbsp; Tempo: ");
            EndContext();
            BeginContext(1370, 56, false);
#line 34 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\EmentaSemanal\getEmentaSemanal.cshtml"
                                                                                   Write(Html.DisplayFor(modelItem => item.Receita.TempoConfecao));

#line default
#line hidden
            EndContext();
            BeginContext(1426, 82, true);
            WriteLiteral("</p>\r\n                <input type=\"button\" class=\"btn btn-light\" value=\"Consultar\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1508, "\"", 1608, 3);
            WriteAttributeValue("", 1518, "location.href=\'", 1518, 15, true);
#line 35 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\EmentaSemanal\getEmentaSemanal.cshtml"
WriteAttributeValue("", 1533, Url.Action("getReceita","Receitas", new { idReceita = item.Receita.Id }), 1533, 73, false);

#line default
#line hidden
            WriteAttributeValue("", 1606, "\';", 1606, 2, true);
            EndWriteAttribute();
            BeginContext(1609, 41, true);
            WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 38 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\EmentaSemanal\getEmentaSemanal.cshtml"
    }

#line default
#line hidden
            BeginContext(1657, 8, true);
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
