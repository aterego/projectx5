#pragma checksum "F:\projects\projectX5\projectX2\Views\RefRoles\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb85d23f5edb37d15061cbcc822e51e7ac6a47ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RefRoles_Create), @"mvc.1.0.view", @"/Views/RefRoles/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RefRoles/Create.cshtml", typeof(AspNetCore.Views_RefRoles_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb85d23f5edb37d15061cbcc822e51e7ac6a47ff", @"/Views/RefRoles/Create.cshtml")]
    public class Views_RefRoles_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DAL.Models.RefRoles>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\projects\projectX5\projectX2\Views\RefRoles\Create.cshtml"
  
    ViewData["Title"] = "Create Role";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(122, 91, true);
            WriteLiteral("<!-- Content Header (Page header) -->\r\n<section class=\"content-header\">\r\n    <h1>\r\n        ");
            EndContext();
            BeginContext(214, 17, false);
#line 9 "F:\projects\projectX5\projectX2\Views\RefRoles\Create.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(231, 1510, true);
            WriteLiteral(@"
    </h1>
</section>
<!-- Main content -->
<section class=""content container-fluid"">
    <div class=""row"">
        <!-- left column -->
        <div class=""col-md-12"">
            <!-- general form elements -->
            <div class=""box box-primary"">
                <div class=""box-header with-border"">
                    <h3 class=""box-title"">Add New Role</h3>
                </div>
                <!-- /.box-header -->
                <!-- form start -->
                <form method=""post"" asp-action=""/Roles/Create"">
                    <div class=""box-body"">
                        <div class=""form-group"">
                            <label for=""exampleInputEmail1"">Title</label>
                            <input type=""text"" class=""form-control"" id=""Title"" name=""Title"" placeholder=""Enter Title"">
                        </div>
                        <div class=""form-group"">
                            <label for=""exampleInputPassword1"">Description</label>
                         ");
            WriteLiteral(@"   <input type=""text"" class=""form-control"" id=""Description"" name=""Description"" placeholder=""Enter Description"">
                        </div>
                    </div>
                    <!-- /.box-body -->
                    <div class=""box-footer"">
                        <button type=""submit"" class=""btn btn-primary"">Submit</button>
                    </div>
                </form>
            </div>
            <!-- /.box -->
        </div>
    </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DAL.Models.RefRoles> Html { get; private set; }
    }
}
#pragma warning restore 1591
