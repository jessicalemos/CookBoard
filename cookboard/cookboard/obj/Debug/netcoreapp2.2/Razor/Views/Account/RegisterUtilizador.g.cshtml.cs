#pragma checksum "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Account\RegisterUtilizador.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b1d686d607e533fae6e077045032a06361f5c44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_RegisterUtilizador), @"mvc.1.0.view", @"/Views/Account/RegisterUtilizador.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/RegisterUtilizador.cshtml", typeof(AspNetCore.Views_Account_RegisterUtilizador))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b1d686d607e533fae6e077045032a06361f5c44", @"/Views/Account/RegisterUtilizador.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86a90c57a68cdbde153aed1e2defab61f9de9b49", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_RegisterUtilizador : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cookboard.Models.Utilizador>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Account\RegisterUtilizador.cshtml"
  
    ViewData["Title"] = "RegisterUtilizador";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(142, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Account\RegisterUtilizador.cshtml"
         if (TempData["Success"] != null)
        {

#line default
#line hidden
            BeginContext(198, 43, true);
            WriteLiteral("            <p class=\"alert alert-success\">");
            EndContext();
            BeginContext(242, 19, false);
#line 9 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Account\RegisterUtilizador.cshtml"
                                      Write(TempData["Success"]);

#line default
#line hidden
            EndContext();
            BeginContext(261, 7, true);
            WriteLiteral(" </p>\r\n");
            EndContext();
#line 10 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Account\RegisterUtilizador.cshtml"
        }

#line default
#line hidden
            BeginContext(279, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 11 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Account\RegisterUtilizador.cshtml"
         if (TempData["Fail"] != null)
        {

#line default
#line hidden
            BeginContext(330, 42, true);
            WriteLiteral("            <p class=\"alert alert-danger\">");
            EndContext();
            BeginContext(373, 16, false);
#line 13 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Account\RegisterUtilizador.cshtml"
                                     Write(TempData["Fail"]);

#line default
#line hidden
            EndContext();
            BeginContext(389, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 14 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Account\RegisterUtilizador.cshtml"
        }

#line default
#line hidden
            BeginContext(406, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(414, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b1d686d607e533fae6e077045032a06361f5c446432", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 15 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Account\RegisterUtilizador.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(480, 115, true);
            WriteLiteral("\r\n        <div class=\"registar-clean\" style=\"background-repeat: no-repeat; background-size: cover;\" >\r\n            ");
            EndContext();
            BeginContext(595, 1359, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b1d686d607e533fae6e077045032a06361f5c448277", async() => {
                BeginContext(615, 1332, true);
                WriteLiteral(@"
                <div style=""text-align: center; font-weight: 900; font-size: 18px; padding-bottom: 20px;"">Registar Utilizador</div>
                <div class=""form-group""><input class=""form-control"" type=""text"" name=""Username"" placeholder=""Username"" required> </div>
                <div class=""form-group""><input class=""form-control"" type=""text"" name=""Password"" placeholder=""Password"" required></div>
                <div class=""form-group""><input class=""form-control"" type=""text"" name=""Email"" placeholder=""Email"" required></div>
                <div class=""form-group""><input class=""form-control"" type=""text"" name=""Nome"" placeholder=""Nome"" required></div>
                <div class=""form-group""><input class=""form-control"" type=""text"" name=""DataNascimento"" placeholder=""DataNascimento"" required></div>

                <div class=""col-md-10"">
                    Aluno
                    <input id=""Tipo"" name=""Tipo"" value=""Aluno"" type=""radio"">
                    <hr style=""border-color: #ffffff;"">
     ");
                WriteLiteral(@"               Professor
                    <input id=""Tipo"" name=""Tipo"" value=""Professor"" type=""radio"">
                </div>
                <div class=""form-group""><button class=""btn btn-primary btn-block"" type=""submit"" style=""background-color:rgb(146,141,142);"">Register</button></div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1954, 20, true);
            WriteLiteral("\r\n        </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cookboard.Models.Utilizador> Html { get; private set; }
    }
}
#pragma warning restore 1591
