#pragma checksum "D:\MyProjects\projectX5\projectX2\Views\Admins\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2ddf0b247dc46fe3214537fbea16c39a98c831e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admins_Delete), @"mvc.1.0.view", @"/Views/Admins/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admins/Delete.cshtml", typeof(AspNetCore.Views_Admins_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2ddf0b247dc46fe3214537fbea16c39a98c831e", @"/Views/Admins/Delete.cshtml")]
    public class Views_Admins_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DAL.Models.Admins>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\MyProjects\projectX5\projectX2\Views\Admins\Delete.cshtml"
  
    ViewData["Title"] = "Delete Admin";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(121, 91, true);
            WriteLiteral("<!-- Content Header (Page header) -->\r\n<section class=\"content-header\">\r\n    <h1>\r\n        ");
            EndContext();
            BeginContext(213, 17, false);
#line 9 "D:\MyProjects\projectX5\projectX2\Views\Admins\Delete.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(230, 350, true);
            WriteLiteral(@"
    </h1>
</section>
<!-- Main content -->
<section class=""content container-fluid"">
    <div class=""row"">
        <!-- left column -->
        <div class=""col-md-12"">
            <h3>Are you sure you want to delete this?</h3>
            <div>
                <dl class=""dl-horizontal"">
                    <dt>
                        ");
            EndContext();
            BeginContext(581, 40, false);
#line 21 "D:\MyProjects\projectX5\projectX2\Views\Admins\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(621, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(701, 36, false);
#line 24 "D:\MyProjects\projectX5\projectX2\Views\Admins\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(737, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(817, 44, false);
#line 27 "D:\MyProjects\projectX5\projectX2\Views\Admins\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
            EndContext();
            BeginContext(861, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(941, 40, false);
#line 30 "D:\MyProjects\projectX5\projectX2\Views\Admins\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Username));

#line default
#line hidden
            EndContext();
            BeginContext(981, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1061, 41, false);
#line 33 "D:\MyProjects\projectX5\projectX2\Views\Admins\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1102, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1182, 37, false);
#line 36 "D:\MyProjects\projectX5\projectX2\Views\Admins\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1219, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1299, 41, false);
#line 39 "D:\MyProjects\projectX5\projectX2\Views\Admins\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Roles));

#line default
#line hidden
            EndContext();
            BeginContext(1340, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1420, 43, false);
#line 42 "D:\MyProjects\projectX5\projectX2\Views\Admins\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Roles.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1463, 173, true);
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n                <form method=\"post\" action=\"/Admins/DeleteConfirmed\">\r\n                    <input type=\"hidden\" name=\"id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1636, "\"", 1653, 1);
#line 46 "D:\MyProjects\projectX5\projectX2\Views\Admins\Delete.cshtml"
WriteAttributeValue("", 1644, Model.Id, 1644, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1654, 172, true);
            WriteLiteral(" />\r\n                    <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" />\r\n                </form>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DAL.Models.Admins> Html { get; private set; }
    }
}
#pragma warning restore 1591
