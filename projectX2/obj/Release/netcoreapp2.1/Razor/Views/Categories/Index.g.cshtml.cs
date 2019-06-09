#pragma checksum "F:\projects\projectX5\projectX2\Views\Categories\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9e8857bf5278073330ffc2841c83a5c52d8d951"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Index), @"mvc.1.0.view", @"/Views/Categories/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Categories/Index.cshtml", typeof(AspNetCore.Views_Categories_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9e8857bf5278073330ffc2841c83a5c52d8d951", @"/Views/Categories/Index.cshtml")]
    public class Views_Categories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DAL.Models.Categories>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bower_components/datatables.net/js/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bower_components/datatables.net-bs/js/dataTables.bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 1245, true);
            WriteLiteral(@"
<section class=""content-header"">
    <h1>
        Categories
    </h1>
    <ol class=""breadcrumb"">
        <li><a href=""/""><i class=""fa fa-dashboard""></i> Home</a></li>
        <li class=""active"">Categories</li>
    </ol>
</section>
<!-- Main content -->
<section class=""content"">
    <div class=""row"">
        <div class=""col-xs-12"">
            <div class=""box"">
                <div class=""box-header"">
                    <h3 class=""box-title"">Manage Categories</h3>
                </div>
                <!-- /.box-header -->
                <div class=""box-body"">
                    <table id=""example1"" class=""table table-bordered table-striped"">
                        <thead>
                            <tr>
                                <th>Id</th>
                                <th>Parent</th>
                                <th>Name</th>
                                <th>Description</th>
                                <th>Price Min</th>
                                ");
            WriteLiteral("<th>Price Max</th>\r\n                                <th>Created</th>\r\n                                <th>Action</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
            EndContext();
#line 36 "F:\projects\projectX5\projectX2\Views\Categories\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(1377, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(1448, 37, false);
#line 39 "F:\projects\projectX5\projectX2\Views\Categories\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1485, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1529, 43, false);
#line 40 "F:\projects\projectX5\projectX2\Views\Categories\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.ParentId));

#line default
#line hidden
            EndContext();
            BeginContext(1572, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1616, 39, false);
#line 41 "F:\projects\projectX5\projectX2\Views\Categories\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1655, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1699, 46, false);
#line 42 "F:\projects\projectX5\projectX2\Views\Categories\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1745, 45, true);
            WriteLiteral("</td>\r\n                                <td>\r\n");
            EndContext();
#line 44 "F:\projects\projectX5\projectX2\Views\Categories\Index.cshtml"
                                      
                                        float priceMin = item.CategoriesPrices.Where(c => c.CategoryId == item.Id).Select(c => c.PriceMin).First().Value;
                                    

#line default
#line hidden
            BeginContext(2024, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(2061, 38, false);
#line 47 "F:\projects\projectX5\projectX2\Views\Categories\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => priceMin));

#line default
#line hidden
            EndContext();
            BeginContext(2099, 79, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n");
            EndContext();
#line 50 "F:\projects\projectX5\projectX2\Views\Categories\Index.cshtml"
                                      
                                        float priceMax = item.CategoriesPrices.Where(c => c.CategoryId == item.Id).Select(c => c.PriceMax).First().Value;
                                    

#line default
#line hidden
            BeginContext(2412, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(2449, 38, false);
#line 53 "F:\projects\projectX5\projectX2\Views\Categories\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => priceMax));

#line default
#line hidden
            EndContext();
            BeginContext(2487, 77, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>");
            EndContext();
            BeginContext(2565, 42, false);
#line 55 "F:\projects\projectX5\projectX2\Views\Categories\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Created));

#line default
#line hidden
            EndContext();
            BeginContext(2607, 45, true);
            WriteLiteral("</td>\r\n                                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2652, "\"", 2674, 2);
            WriteAttributeValue("", 2659, "Update/", 2659, 7, true);
#line 56 "F:\projects\projectX5\projectX2\Views\Categories\Index.cshtml"
WriteAttributeValue("", 2666, item.Id, 2666, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2675, 24, true);
            WriteLiteral(">Update</a> | <a href=\"\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2699, "\"", 2727, 3);
            WriteAttributeValue("", 2709, "Delete(\'", 2709, 8, true);
#line 56 "F:\projects\projectX5\projectX2\Views\Categories\Index.cshtml"
WriteAttributeValue("", 2717, item.Id, 2717, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2725, "\')", 2725, 2, true);
            EndWriteAttribute();
            BeginContext(2728, 53, true);
            WriteLiteral(">Delete</a></td>\r\n                            </tr>\r\n");
            EndContext();
#line 58 "F:\projects\projectX5\projectX2\Views\Categories\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(2812, 248, true);
            WriteLiteral("                    </table>\r\n                </div>\r\n                <!-- /.box-body -->\r\n            </div>\r\n            <!-- /.box -->\r\n        </div>\r\n        <!-- /.col -->\r\n    </div>\r\n    <!-- /.row -->\r\n</section>\r\n\r\n<!-- DataTables -->\r\n\r\n");
            EndContext();
            BeginContext(3060, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "852a263f5b234be6add843874a4697ec", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3145, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3147, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07e665d07e404b8bb68219cc069d4d96", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3238, 348, true);
            WriteLiteral(@"

<!-- page script -->
<script>
    $(function () {
        $('#example1').DataTable();
    });
    function Delete(id){
        //alert(id);
        var txt;
        var r = confirm(""Are you sure you want to Delete?"");
        if (r == true) {

            $.ajax(
            {
                type: ""POST"",
                url: '");
            EndContext();
            BeginContext(3587, 34, false);
#line 89 "F:\projects\projectX5\projectX2\Views\Categories\Index.cshtml"
                 Write(Url.Action("Delete", "Categories"));

#line default
#line hidden
            EndContext();
            BeginContext(3621, 568, true);
            WriteLiteral(@"',
                data: {
                    id: id
                },
                error: function (result) {
                    alert(""error"");
                },
                success: function (result) {
                    if (result == true) {
                        var baseUrl=""/Index"";
                        window.location.reload();
                    }
                    else {
                        alert(""There is a problem, Try Later!"");
                    }
                }
            });
        }
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DAL.Models.Categories>> Html { get; private set; }
    }
}
#pragma warning restore 1591