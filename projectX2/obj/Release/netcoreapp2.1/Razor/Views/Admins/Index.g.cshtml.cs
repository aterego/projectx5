#pragma checksum "F:\projects\projectX5\projectX2\Views\Admins\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3228443dc0afe18558537397db463645246dd3bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admins_Index), @"mvc.1.0.view", @"/Views/Admins/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admins/Index.cshtml", typeof(AspNetCore.Views_Admins_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3228443dc0afe18558537397db463645246dd3bd", @"/Views/Admins/Index.cshtml")]
    public class Views_Admins_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DAL.Models.Admins>>
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
#line 2 "F:\projects\projectX5\projectX2\Views\Admins\Index.cshtml"
  
    ViewData["Title"] = "Admins";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(128, 91, true);
            WriteLiteral("<!-- Content Header (Page header) -->\r\n<section class=\"content-header\">\r\n    <h1>\r\n        ");
            EndContext();
            BeginContext(220, 17, false);
#line 9 "F:\projects\projectX5\projectX2\Views\Admins\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(237, 140, true);
            WriteLiteral("\r\n    </h1>\r\n    <ol class=\"breadcrumb\">\r\n        <li><a href=\"/\"><i class=\"fa fa-dashboard\"></i> Home</a></li>\r\n        <li class=\"active\">");
            EndContext();
            BeginContext(378, 17, false);
#line 13 "F:\projects\projectX5\projectX2\Views\Admins\Index.cshtml"
                      Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(395, 880, true);
            WriteLiteral(@"</li>
    </ol>
</section>
<!-- Main content -->
<section class=""content container-fluid"">
    <div class=""row"">
        <div class=""col-xs-12"">
            <div class=""box"">
                <div class=""box-header"">
                    <h3 class=""box-title"">Manage Admins</h3>
                </div>
                <!-- /.box-header -->
                <div class=""box-body"">
                    <table id=""table"" class=""table table-bordered table-hover"">
                        <thead>
                            <tr>
                                <th>Id</th>
                                <th>Usermane</th>
                                <th>Email</th>
                                <th>Role</th>
                                <th>Action</th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 37 "F:\projects\projectX5\projectX2\Views\Admins\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(1364, 120, true);
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(1485, 37, false);
#line 41 "F:\projects\projectX5\projectX2\Views\Admins\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1522, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(1650, 43, false);
#line 44 "F:\projects\projectX5\projectX2\Views\Admins\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Username));

#line default
#line hidden
            EndContext();
            BeginContext(1693, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(1821, 40, false);
#line 47 "F:\projects\projectX5\projectX2\Views\Admins\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1861, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(1989, 46, false);
#line 50 "F:\projects\projectX5\projectX2\Views\Admins\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Roles.Title));

#line default
#line hidden
            EndContext();
            BeginContext(2035, 129, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2164, "\"", 2192, 2);
            WriteAttributeValue("", 2171, "/Admins/Edit/", 2171, 13, true);
#line 53 "F:\projects\projectX5\projectX2\Views\Admins\Index.cshtml"
WriteAttributeValue("", 2184, item.Id, 2184, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2193, 55, true);
            WriteLiteral(">Edit</a> |\r\n                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2248, "\"", 2278, 2);
            WriteAttributeValue("", 2255, "/Admins/Delete/", 2255, 15, true);
#line 54 "F:\projects\projectX5\projectX2\Views\Admins\Index.cshtml"
WriteAttributeValue("", 2270, item.Id, 2270, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2279, 95, true);
            WriteLiteral(">Delete</a>\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 57 "F:\projects\projectX5\projectX2\Views\Admins\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(2405, 173, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<!-- DataTables -->\r\n\r\n");
            EndContext();
            BeginContext(2578, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb56ccae32d44c4b96f8dff3fb7ec058", async() => {
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
            BeginContext(2663, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2665, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0555c211c4664676a4744edba6c633f4", async() => {
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
            BeginContext(2756, 285, true);
            WriteLiteral(@"


<script>
    $(function () {
        $('#table').DataTable({
            'paging': true,
            'lengthChange': false,
            'searching': false,
            'ordering': true,
            'info': true,
            'autoWidth': false
        })
    })</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DAL.Models.Admins>> Html { get; private set; }
    }
}
#pragma warning restore 1591
