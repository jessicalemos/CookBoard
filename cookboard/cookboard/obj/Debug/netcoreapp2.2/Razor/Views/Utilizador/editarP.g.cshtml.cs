#pragma checksum "C:\Users\marta\OneDrive\Área de Trabalho\LI4\cookboard\cookboard\Views\Utilizador\editarP.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "407a047030f7157f126e7bd610c78ac44a292a77"
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
#line 1 "C:\Users\marta\OneDrive\Área de Trabalho\LI4\cookboard\cookboard\Views\_ViewImports.cshtml"
using cookboard;

#line default
#line hidden
#line 2 "C:\Users\marta\OneDrive\Área de Trabalho\LI4\cookboard\cookboard\Views\_ViewImports.cshtml"
using cookboard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"407a047030f7157f126e7bd610c78ac44a292a77", @"/Views/Utilizador/editarP.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86a90c57a68cdbde153aed1e2defab61f9de9b49", @"/Views/_ViewImports.cshtml")]
    public class Views_Utilizador_editarP : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<cookboard.Models.Receita>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\marta\OneDrive\Área de Trabalho\LI4\cookboard\cookboard\Views\Utilizador\editarP.cshtml"
  
    ViewData["Title"] = "editarP";

#line default
#line hidden
            BeginContext(89, 2402, true);
            WriteLiteral(@"
<div class=""container"">
    <h1>Editar Perfil</h1>
    <hr>
    <div class=""row"">
        <!-- left column -->
        <div class=""col-md-3"">
            <div class=""text-center"">
                <img src=""//placehold.it/100"" class=""avatar img-circle"" alt=""avatar"">
                <h6>Upload a different photo...</h6>

                <input type=""file"" class=""form-control"">
            </div>
        </div>

        <!-- edit form column -->
        <div class=""col-md-9 personal-info"">
            <div class=""alert alert-info alert-dismissable"">
                <a class=""panel-close close"" data-dismiss=""alert"">×</a>
                <i class=""fa fa-coffee""></i>
                This is an <strong>.alert</strong>. Use this to show important messages to the user.
            </div>
            <h3>Informação Pessoal</h3>


            <div class=""form-group"">
                <label class=""col-lg-3 control-label"">Nome:</label>
                <div class=""col-lg-8"">
                    ");
            WriteLiteral(@"<input class=""form-control"" type=""text"" value=""Jane"">
                </div>
            </div>
            <div class=""form-group"">
                <label class=""col-lg-3 control-label"">Email:</label>
                <div class=""col-lg-8"">
                    <input class=""form-control"" type=""text"" value=""janesemail@gmail.com"">
                </div>
            </div>
            <div class=""form-group"">
                <label class=""col-md-3 control-label"">Password:</label>
                <div class=""col-md-8"">
                    <input class=""form-control"" type=""password"" value=""11111122333"">
                </div>
            </div>
            <div class=""form-group"">
                <label class=""col-md-3 control-label"">Confirm password:</label>
                <div class=""col-md-8"">
                    <input class=""form-control"" type=""password"" value=""11111122333"">
                </div>
            </div>
            <div class=""form-group"">
                <label class=""col-");
            WriteLiteral(@"md-3 control-label""></label>
                <div class=""col-md-8"">
                    <input type=""button"" class=""btn btn-primary"" value=""Save Changes"">
                    <span></span>
                    <input type=""reset"" class=""btn btn-default"" value=""Cancel"">
                </div>
            </div>

        </div>
    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<cookboard.Models.Receita>> Html { get; private set; }
    }
}
#pragma warning restore 1591
