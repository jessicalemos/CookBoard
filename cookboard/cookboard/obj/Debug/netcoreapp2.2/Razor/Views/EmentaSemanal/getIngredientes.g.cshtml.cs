#pragma checksum "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\EmentaSemanal\getIngredientes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14b758a8d9c87e818d8ca54a26de95f0735406d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmentaSemanal_getIngredientes), @"mvc.1.0.view", @"/Views/EmentaSemanal/getIngredientes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EmentaSemanal/getIngredientes.cshtml", typeof(AspNetCore.Views_EmentaSemanal_getIngredientes))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14b758a8d9c87e818d8ca54a26de95f0735406d8", @"/Views/EmentaSemanal/getIngredientes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86a90c57a68cdbde153aed1e2defab61f9de9b49", @"/Views/_ViewImports.cshtml")]
    public class Views_EmentaSemanal_getIngredientes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<cookboard.Models.Ingrediente>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\EmentaSemanal\getIngredientes.cshtml"
  
    ViewData["Title"] = "getIngredientes";

#line default
#line hidden
            BeginContext(101, 125, true);
            WriteLiteral("\r\n<h1>\r\n    Lista Ingredientes <input type=\"button\" class=\"btn btn-light\" style=\"float:right;\" value=\"Localizar Ingredientes\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 226, "\"", 324, 3);
            WriteAttributeValue("", 236, "location.href=\'", 236, 15, true);
#line 7 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\EmentaSemanal\getIngredientes.cshtml"
WriteAttributeValue("", 251, Url.Action("getLocalizacao","LocalIngrediente", new { idReceita = 1 }), 251, 71, false);

#line default
#line hidden
            WriteAttributeValue("", 322, "\';", 322, 2, true);
            EndWriteAttribute();
            BeginContext(325, 22, true);
            WriteLiteral(" />\r\n</h1>\r\n\r\n<hr>\r\n\r\n");
            EndContext();
#line 12 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\EmentaSemanal\getIngredientes.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(380, 27, true);
            WriteLiteral("   <input type=\"checkbox\"> ");
            EndContext();
            BeginContext(408, 39, false);
#line 14 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\EmentaSemanal\getIngredientes.cshtml"
                      Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(449, 9, true);
            WriteLiteral("   <br>\r\n");
            EndContext();
#line 16 "C:\Users\Operador\Desktop\LI4\cookboard\cookboard\Views\EmentaSemanal\getIngredientes.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<cookboard.Models.Ingrediente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
