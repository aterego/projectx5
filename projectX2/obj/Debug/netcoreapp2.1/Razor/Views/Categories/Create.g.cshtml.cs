#pragma checksum "f:\projects\projectX5_git\projectx5\projectX2\Views\Categories\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb566bcf9f8682c71353bbe29280b5884cdd4049"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Create), @"mvc.1.0.view", @"/Views/Categories/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Categories/Create.cshtml", typeof(AspNetCore.Views_Categories_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb566bcf9f8682c71353bbe29280b5884cdd4049", @"/Views/Categories/Create.cshtml")]
    public class Views_Categories_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1031, true);
            WriteLiteral(@"<!-- Content Header (Page header) -->
<section class=""content-header"">
    <h1>
        Categories
    </h1>
</section>
<!-- Main content -->
<section class=""content container-fluid"">
    <!-- Horizontal Form -->
    <div class=""box box-info"">
        <div class=""box-header with-border"">
            <h3 class=""box-title"">Add Category</h3>
        </div>
        <!-- /.box-header -->
        <!-- form start -->
        <form class=""form-horizontal"" method=""post"" action=""CreateCategory"">
            <div class=""box-body"">

                <div class=""form-group"">
                    <label for=""inputTitle"" class=""col-sm-2 control-label"">Title</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""Name"" placeholder=""Name"">
                    </div>
                </div>
                <div class=""form-group"">
                    <label for=""Parent"" class=""col-sm-2 control-label for-select"">Parent</label>
             ");
            WriteLiteral("       ");
            EndContext();
            BeginContext(1032, 109, false);
#line 27 "f:\projects\projectX5_git\projectx5\projectX2\Views\Categories\Create.cshtml"
               Write(Html.DropDownList("Parents", null, htmlAttributes: new { @class = "form-control", @style = "width: 200px;" }));

#line default
#line hidden
            EndContext();
            BeginContext(1141, 1481, true);
            WriteLiteral(@"
                </div>
            
                <div class=""form-group"">
                    <label for=""inputDescription"" class=""col-sm-2 control-label"">Description</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""Description"" placeholder=""Description"">
                    </div>
                </div>

                <div class=""form-group"">
                    <label for=""inputPriceMin"" class=""col-sm-2 control-label"">Min Price</label>
                    <div class=""col-sm-10"">
                        <input type=""number"" class=""form-control"" name=""PriceMin"" placeholder=""Min Price"">
                    </div>
                </div>

                <div class=""form-group"">
                    <label for=""inputPriceMax"" class=""col-sm-2 control-label"">Max Price</label>
                    <div class=""col-sm-10"">
                        <input type=""number"" class=""form-control"" name=""PriceMax"" placeholder=""max P");
            WriteLiteral(@"rice"">
                    </div>
                </div>

                </div>
                <!-- /.box-body -->
                <div class=""box-footer"">
                    <button type=""submit"" class=""btn btn-default"">Cancel</button>
                    <button type=""submit"" class=""btn btn-info pull-right"">Create</button>
                </div>
            <!-- /.box-footer -->
        </form>
    </div>
    <!-- /.box -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
