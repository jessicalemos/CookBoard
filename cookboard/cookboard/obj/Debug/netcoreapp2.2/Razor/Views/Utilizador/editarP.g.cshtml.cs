#pragma checksum "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Utilizador\editarP.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b83f45125125278cffdbb503b9eff23ecbe3f1d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Utilizador_editarP), @"mvc.1.0.view", @"/Views/Utilizador/editarP.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Utilizador/editarP.cshtml", typeof(AspNetCore.Views_Utilizador_editarP))]
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
#line 1 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\_ViewImports.cshtml"
using cookboard;

#line default
#line hidden
#line 2 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\_ViewImports.cshtml"
using cookboard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b83f45125125278cffdbb503b9eff23ecbe3f1d5", @"/Views/Utilizador/editarP.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86a90c57a68cdbde153aed1e2defab61f9de9b49", @"/Views/_ViewImports.cshtml")]
    public class Views_Utilizador_editarP : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cookboard.Models.Utilizador>
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
#line 2 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Utilizador\editarP.cshtml"
  
    ViewBag.Title = "editarP";
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
            BeginContext(384, 138, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h1>Editar Perfil</h1>\r\n    <hr>\r\n    <!-- edit form column -->\r\n    <div class=\"col-md-9 personal-info\">\r\n");
            EndContext();
#line 22 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Utilizador\editarP.cshtml"
         if (TempData["Success"] != null)
        {

#line default
#line hidden
            BeginContext(576, 43, true);
            WriteLiteral("            <p class=\"alert alert-success\">");
            EndContext();
            BeginContext(620, 19, false);
#line 24 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Utilizador\editarP.cshtml"
                                      Write(TempData["Success"]);

#line default
#line hidden
            EndContext();
            BeginContext(639, 7, true);
            WriteLiteral(" </p>\r\n");
            EndContext();
#line 25 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Utilizador\editarP.cshtml"
        }

#line default
#line hidden
            BeginContext(657, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(665, 1076, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b83f45125125278cffdbb503b9eff23ecbe3f1d55312", async() => {
                BeginContext(685, 220, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <label class=\"col-lg-3 control-label\">Nome:</label>\r\n                <div class=\"col-lg-8\">\r\n                    <input class=\"form-control\" type=\"text\" name=\"nome\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 905, "\"", 924, 1);
#line 30 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Utilizador\editarP.cshtml"
WriteAttributeValue("", 913, Model.Nome, 913, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(925, 267, true);
                WriteLiteral(@">
                </div>
            </div>
            <div class=""form-group"">
                <label class=""col-lg-3 control-label"">Email:</label>
                <div class=""col-lg-8"">
                    <input class=""form-control"" type=""text"" name=""email""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1192, "\"", 1212, 1);
#line 36 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Utilizador\editarP.cshtml"
WriteAttributeValue("", 1200, Model.Email, 1200, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1213, 277, true);
                WriteLiteral(@">
                </div>
            </div>
            <div class=""form-group"">
                <label class=""col-md-3 control-label"">Password:</label>
                <div class=""col-md-8"">
                    <input class=""form-control"" type=""password"" name=""password""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1490, "\"", 1513, 1);
#line 42 "C:\Users\Utilizador\Documents\GitHub\LI4\cookboard\cookboard\Views\Utilizador\editarP.cshtml"
WriteAttributeValue("", 1498, Model.Password, 1498, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1514, 220, true);
                WriteLiteral(">\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\"><button class=\"btn btn-primary btn-block\" type=\"submit\" style=\"background-color:rgb(146,141,142);width:25%\">Save</button></div>\r\n        ");
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
            BeginContext(1741, 22, true);
            WriteLiteral("\r\n    </div>\r\n\r\n</div>");
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
