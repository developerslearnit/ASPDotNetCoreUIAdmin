#pragma checksum "C:\dev\WebApp\DotNetCoreUIAdmin\DotNetCoreUIAdmin\Views\component\jumbotron.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18da15d8e86f8b858e01c229c8ae947adcccc861"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_component_jumbotron), @"mvc.1.0.view", @"/Views/component/jumbotron.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/component/jumbotron.cshtml", typeof(AspNetCore.Views_component_jumbotron))]
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
#line 1 "C:\dev\WebApp\DotNetCoreUIAdmin\DotNetCoreUIAdmin\Views\_ViewImports.cshtml"
using DotNetCoreUIAdmin;

#line default
#line hidden
#line 2 "C:\dev\WebApp\DotNetCoreUIAdmin\DotNetCoreUIAdmin\Views\_ViewImports.cshtml"
using DotNetCoreUIAdmin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18da15d8e86f8b858e01c229c8ae947adcccc861", @"/Views/component/jumbotron.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e75961811504b900323d7c07cd85d88bb36b7333", @"/Views/_ViewImports.cshtml")]
    public class Views_component_jumbotron : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\dev\WebApp\DotNetCoreUIAdmin\DotNetCoreUIAdmin\Views\component\jumbotron.cshtml"
  
    ViewData["Title"] = "jumbotron";

#line default
#line hidden
            BeginContext(47, 2095, true);
            WriteLiteral(@"


<div class=""animated fadeIn"">
    <div class=""row"">
        <div class=""col-sm-12 col-xl-6"">
            <div class=""card"">
                <div class=""card-header"">
                    <i class=""fa fa-align-justify""></i> Jumbotron
                    <div class=""card-header-actions"">
                        <a class=""card-header-action"" href=""http://coreui.io/docs/components/bootstrap-jumbotron/"" target=""_blank"">
                            <small class=""text-muted"">docs</small>
                        </a>
                    </div>
                </div>
                <div class=""card-body"">
                    <div class=""jumbotron"">
                        <h1 class=""display-3"">Hello, world!</h1>
                        <p class=""lead"">This is a simple hero unit, a simple jumbotron-style component for calling extra attention to featured content or information.</p>
                        <hr class=""my-4"">
                        <p>It uses utility classes for typography and spaci");
            WriteLiteral(@"ng to space content out within the larger container.</p>
                        <p class=""lead"">
                            <a class=""btn btn-primary btn-lg"" href=""#"" role=""button"">Learn more</a>
                        </p>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-sm-12 col-xl-6"">
            <div class=""card"">
                <div class=""card-header"">
                    <i class=""fa fa-align-justify""></i> Jumbotron
                    <small>fluid</small>
                </div>
                <div class=""card-body"">
                    <div class=""jumbotron jumbotron-fluid"">
                        <div class=""container"">
                            <h1 class=""display-3"">Fluid jumbotron</h1>
                            <p class=""lead"">This is a modified jumbotron that occupies the entire horizontal space of its parent.</p>
                        </div>
                    </div>
                </div>
            <");
            WriteLiteral("/div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591