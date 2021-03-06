#pragma checksum "C:\dev\WebApp\DotNetCoreUIAdmin\DotNetCoreUIAdmin\Views\component\modals.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc03f73f1b70fd1a366ea781e1fe8e351f03534c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_component_modals), @"mvc.1.0.view", @"/Views/component/modals.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/component/modals.cshtml", typeof(AspNetCore.Views_component_modals))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc03f73f1b70fd1a366ea781e1fe8e351f03534c", @"/Views/component/modals.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e75961811504b900323d7c07cd85d88bb36b7333", @"/Views/_ViewImports.cshtml")]
    public class Views_component_modals : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\dev\WebApp\DotNetCoreUIAdmin\DotNetCoreUIAdmin\Views\component\modals.cshtml"
  
    ViewData["Title"] = "Modals";

#line default
#line hidden
            BeginContext(44, 9359, true);
            WriteLiteral(@"

<div class=""animated fadeIn"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""card"">
                <div class=""card-header"">
                    <i class=""fa fa-align-justify""></i> Bootstrap Modals
                </div>
                <div class=""card-body"">
                    <!-- Button trigger modal-->
                    <button class=""btn btn-secondary"" type=""button"" data-toggle=""modal"" data-target=""#myModal"">Launch demo modal</button>
                    <button class=""btn btn-secondary"" type=""button"" data-toggle=""modal"" data-target=""#largeModal"">Launch large modal</button>
                    <button class=""btn btn-secondary"" type=""button"" data-toggle=""modal"" data-target=""#smallModal"">Launch small modal</button>
                    <hr>
                    <button class=""btn btn-primary"" type=""button"" data-toggle=""modal"" data-target=""#primaryModal"">Primary modal</button>
                    <button class=""btn btn-success"" type=""button"" data-toggle=""m");
            WriteLiteral(@"odal"" data-target=""#successModal"">Success modal</button>
                    <button class=""btn btn-warning"" type=""button"" data-toggle=""modal"" data-target=""#warningModal"">Warning modal</button>
                    <button class=""btn btn-danger"" type=""button"" data-toggle=""modal"" data-target=""#dangerModal"">Danger modal</button>
                    <button class=""btn btn-info"" type=""button"" data-toggle=""modal"" data-target=""#infoModal"">Info modal</button>
                </div>
            </div>
        </div>
        <!-- /.col-->
    </div>
    <!-- /.row-->
</div>


<div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Modal title</h4>
                <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true""");
            WriteLiteral(@">×</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>One fine body…</p>
            </div>
            <div class=""modal-footer"">
                <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Close</button>
                <button class=""btn btn-primary"" type=""button"">Save changes</button>
            </div>
        </div>
        <!-- /.modal-content-->
    </div>
    <!-- /.modal-dialog-->
</div>
<!-- /.modal-->
<div class=""modal fade"" id=""largeModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Modal title</h4>
                <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
 ");
            WriteLiteral(@"           <div class=""modal-body"">
                <p>One fine body…</p>
            </div>
            <div class=""modal-footer"">
                <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Close</button>
                <button class=""btn btn-primary"" type=""button"">Save changes</button>
            </div>
        </div>
        <!-- /.modal-content-->
    </div>
    <!-- /.modal-dialog-->
</div>
<!-- /.modal-->
<div class=""modal fade"" id=""smallModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-sm"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Modal title</h4>
                <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>One");
            WriteLiteral(@" fine body…</p>
            </div>
            <div class=""modal-footer"">
                <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Close</button>
                <button class=""btn btn-primary"" type=""button"">Save changes</button>
            </div>
        </div>
        <!-- /.modal-content-->
    </div>
    <!-- /.modal-dialog-->
</div>
<!-- /.modal-->
<div class=""modal fade"" id=""primaryModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-primary"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Modal title</h4>
                <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>One fine body…</p>
            </div>
            <di");
            WriteLiteral(@"v class=""modal-footer"">
                <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Close</button>
                <button class=""btn btn-primary"" type=""button"">Save changes</button>
            </div>
        </div>
        <!-- /.modal-content-->
    </div>
    <!-- /.modal-dialog-->
</div>
<!-- /.modal-->
<div class=""modal fade"" id=""successModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-success"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Modal title</h4>
                <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>One fine body…</p>
            </div>
            <div class=""modal-footer"">
                <button cla");
            WriteLiteral(@"ss=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Close</button>
                <button class=""btn btn-success"" type=""button"">Save changes</button>
            </div>
        </div>
        <!-- /.modal-content-->
    </div>
    <!-- /.modal-dialog-->
</div>
<!-- /.modal-->
<div class=""modal fade"" id=""warningModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-warning"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Modal title</h4>
                <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>One fine body…</p>
            </div>
            <div class=""modal-footer"">
                <button class=""btn btn-secondary"" type=""button"" data-dismiss=""m");
            WriteLiteral(@"odal"">Close</button>
                <button class=""btn btn-warning"" type=""button"">Save changes</button>
            </div>
        </div>
        <!-- /.modal-content-->
    </div>
    <!-- /.modal-dialog-->
</div>
<!-- /.modal-->
<div class=""modal fade"" id=""dangerModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-danger"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Modal title</h4>
                <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>One fine body…</p>
            </div>
            <div class=""modal-footer"">
                <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Close</button>
                <button class=""b");
            WriteLiteral(@"tn btn-danger"" type=""button"">Save changes</button>
            </div>
        </div>
        <!-- /.modal-content-->
    </div>
    <!-- /.modal-dialog-->
</div>
<!-- /.modal-->
<div class=""modal fade"" id=""infoModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-info"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Modal title</h4>
                <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>One fine body…</p>
            </div>
            <div class=""modal-footer"">
                <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Close</button>
                <button class=""btn btn-info"" type=""button"">Save changes</button>
         ");
            WriteLiteral("   </div>\r\n        </div>\r\n        <!-- /.modal-content-->\r\n    </div>\r\n    <!-- /.modal-dialog-->\r\n</div>\r\n<!-- /.modal-->\r\n        </div>\r\n\r\n");
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
