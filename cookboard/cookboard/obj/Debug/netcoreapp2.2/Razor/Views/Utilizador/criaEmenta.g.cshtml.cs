#pragma checksum "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Utilizador\criaEmenta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b042675b21b5a3cc78633033a0f4f1fb72749c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Utilizador_criaEmenta), @"mvc.1.0.view", @"/Views/Utilizador/criaEmenta.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Utilizador/criaEmenta.cshtml", typeof(AspNetCore.Views_Utilizador_criaEmenta))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b042675b21b5a3cc78633033a0f4f1fb72749c1", @"/Views/Utilizador/criaEmenta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86a90c57a68cdbde153aed1e2defab61f9de9b49", @"/Views/_ViewImports.cshtml")]
    public class Views_Utilizador_criaEmenta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cookboard.Models.Utilizador>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\X556\Documents\GitHub\LI4\cookboard\cookboard\Views\Utilizador\criaEmenta.cshtml"
  
    ViewData["Title"] = "registaReceita";

#line default
#line hidden
            BeginContext(86, 206, true);
            WriteLiteral("<h1> Criar Ementa Semanal</h1>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <div class=\"register-photo\">\r\n            <div class=\"registar-clean\" style=\"background-size:cover;\">\r\n                ");
            EndContext();
            BeginContext(292, 3712, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b042675b21b5a3cc78633033a0f4f1fb72749c14117", async() => {
                BeginContext(312, 3685, true);
                WriteLiteral(@"
                    <h1 class=""text-center"">Ementa Semanal</h1>
                    <div class=""input-group"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text"" id=""inputGroupFileAddon01"">Segunda-Feira</span>
                        </div>
                        <div class=""custom-file"">
                            <input type=""file"" class=""custom-file-input"" id=""inputGroupFile01""
                                   aria-describedby=""inputGroupFileAddon01"">
                            <label class=""custom-file-label"" for=""inputGroupFile01"">Selecionar Receita</label>
                        </div>
                    </div>
                    <p>


                    </p>
                    <div class=""input-group"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text"" id=""inputGroupFileAddon01"">Terça-Feira  </span>
                        </div>
             ");
                WriteLiteral(@"           <div class=""custom-file"">
                            <input type=""file"" class=""custom-file-input"" id=""inputGroupFile01""
                                   aria-describedby=""inputGroupFileAddon01"">
                            <label class=""custom-file-label"" for=""inputGroupFile01"">Selecionar Receita</label>
                        </div>
                    </div>
                    <p>


                    </p>
                    <div class=""input-group"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text"" id=""inputGroupFileAddon01"">Quarta-Feira </span>
                        </div>
                        <div class=""custom-file"">
                            <input type=""file"" class=""custom-file-input"" id=""inputGroupFile01""
                                   aria-describedby=""inputGroupFileAddon01"">
                            <label class=""custom-file-label"" for=""inputGroupFile01"">Selecionar Receita</label>
  ");
                WriteLiteral(@"                      </div>
                    </div>
                    <p>


                    </p>
                    <div class=""input-group"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text"" id=""inputGroupFileAddon01"">Quinta-Feira </span>
                        </div>
                        <div class=""custom-file"">
                            <input type=""file"" class=""custom-file-input"" id=""inputGroupFile01""
                                   aria-describedby=""inputGroupFileAddon01"">
                            <label class=""custom-file-label"" for=""inputGroupFile01"">Selecionar Receita</label>
                        </div>
                    </div>
                    <p>


                    </p>
                    <div class=""input-group"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text"" id=""inputGroupFileAddon01"">Sexta-Feira  </span>");
                WriteLiteral(@"
                        </div>
                        <div class=""custom-file"">
                            <input type=""file"" class=""custom-file-input"" id=""inputGroupFile01""
                                   aria-describedby=""inputGroupFileAddon01"">
                            <label class=""custom-file-label"" for=""inputGroupFile01"">Selecionar Receita</label>
                        </div>
                    </div>
                    <div class=""form-group""><button class=""btn btn-primary btn-block"" type=""submit"" style=""background-color:rgb(146,141,142);"">Guardar</button></div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4004, 57, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div> ");
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
