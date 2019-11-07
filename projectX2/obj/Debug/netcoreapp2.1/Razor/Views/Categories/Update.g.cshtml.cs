#pragma checksum "f:\projects\projectX5_git\projectx5\projectX2\Views\Categories\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b33fc38b1b52c3e7e499d8e66ee0c4b3745435b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Update), @"mvc.1.0.view", @"/Views/Categories/Update.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Categories/Update.cshtml", typeof(AspNetCore.Views_Categories_Update))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b33fc38b1b52c3e7e499d8e66ee0c4b3745435b7", @"/Views/Categories/Update.cshtml")]
    public class Views_Categories_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DAL.Models.Categories>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 773, true);
            WriteLiteral(@"
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
            <h3 class=""box-title"">Update Category</h3>
        </div>
        <!-- /.box-header -->
        <!-- form start -->
        <form class=""form-horizontal"" method=""post"" action=""/Categories/UpdateCategory"">
            <div class=""box-body"">
                <div class=""form-group"">
                    <label for=""inputTitle"" class=""col-sm-2 control-label"">Title</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""Name""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 803, "\"", 822, 1);
#line 22 "f:\projects\projectX5_git\projectx5\projectX2\Views\Categories\Update.cshtml"
WriteAttributeValue("", 811, Model.Name, 811, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(823, 237, true);
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"Parent\" class=\"col-sm-2 control-label for-select\">Parent</label>\r\n                    \r\n                    ");
            EndContext();
            BeginContext(1061, 109, false);
#line 28 "f:\projects\projectX5_git\projectx5\projectX2\Views\Categories\Update.cshtml"
               Write(Html.DropDownList("Parents", null, htmlAttributes: new { @class = "form-control", @style = "width: 200px;" }));

#line default
#line hidden
            EndContext();
            BeginContext(1170, 299, true);
            WriteLiteral(@"
                </div>

                <div class=""form-group"">
                    <label for=""inputDescription"" class=""col-sm-2 control-label"">Description</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""Description""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1469, "\"", 1495, 1);
#line 34 "f:\projects\projectX5_git\projectx5\projectX2\Views\Categories\Update.cshtml"
WriteAttributeValue("", 1477, Model.Description, 1477, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1496, 322, true);
            WriteLiteral(@">
                    </div>
                </div>

                <div class=""form-group"">
                    <label for=""inputPriceMin"" class=""col-sm-2 control-label"">Min Price</label>
                    <div class=""col-sm-10"">
                        <input type=""number"" class=""form-control"" name=""PriceMin""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1818, "\"", 1919, 1);
#line 41 "f:\projects\projectX5_git\projectx5\projectX2\Views\Categories\Update.cshtml"
WriteAttributeValue("", 1826, Model.CategoriesPrices.Where(c => c.CategoryId == @Model.Id).Select(c => c.PriceMin).First(), 1826, 93, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1920, 322, true);
            WriteLiteral(@">
                    </div>
                </div>

                <div class=""form-group"">
                    <label for=""inputPriceMax"" class=""col-sm-2 control-label"">Max Price</label>
                    <div class=""col-sm-10"">
                        <input type=""number"" class=""form-control"" name=""PriceMax""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2242, "\"", 2343, 1);
#line 48 "f:\projects\projectX5_git\projectx5\projectX2\Views\Categories\Update.cshtml"
WriteAttributeValue("", 2250, Model.CategoriesPrices.Where(c => c.CategoryId == @Model.Id).Select(c => c.PriceMax).First(), 2250, 93, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2344, 101, true);
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <input type=\"hidden\" name=\"Id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2445, "\"", 2462, 1);
#line 51 "f:\projects\projectX5_git\projectx5\projectX2\Views\Categories\Update.cshtml"
WriteAttributeValue("", 2453, Model.Id, 2453, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2463, 376, true);
            WriteLiteral(@" />
            </div>
            <!-- /.box-body -->
            <div class=""box-footer"">
                <button type=""submit"" class=""btn btn-default"">Cancel</button>
                <button type=""submit"" class=""btn btn-info pull-right"">Update</button>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DAL.Models.Categories> Html { get; private set; }
    }
}
#pragma warning restore 1591
