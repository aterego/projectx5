#pragma checksum "D:\MyProjects\projectX5\projectX2\Views\Admins\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9d34e15fbc5590d0b5a1ea756b25b24c3ab8c02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admins_Create), @"mvc.1.0.view", @"/Views/Admins/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admins/Create.cshtml", typeof(AspNetCore.Views_Admins_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9d34e15fbc5590d0b5a1ea756b25b24c3ab8c02", @"/Views/Admins/Create.cshtml")]
    public class Views_Admins_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<projectX2.Models.AdminsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\MyProjects\projectX5\projectX2\Views\Admins\Create.cshtml"
  
    ViewData["Title"] = "Create Admin";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(136, 91, true);
            WriteLiteral("<!-- Content Header (Page header) -->\r\n<section class=\"content-header\">\r\n    <h1>\r\n        ");
            EndContext();
            BeginContext(228, 17, false);
#line 9 "D:\MyProjects\projectX5\projectX2\Views\Admins\Create.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(245, 668, true);
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
                    <h3 class=""box-title"">Add New Admin</h3>
                </div>
                <!-- /.box-header -->
                <!-- form start -->
                <form method=""post"" asp-action=""/Admins/Create"">
                    <div class=""box-body"">
                        <div class=""form-group"">
                            ");
            EndContext();
            BeginContext(914, 26, false);
#line 27 "D:\MyProjects\projectX5\projectX2\Views\Admins\Create.cshtml"
                       Write(Html.LabelFor(x => x.Name));

#line default
#line hidden
            EndContext();
            BeginContext(940, 177, true);
            WriteLiteral("\r\n                            <input type=\"text\" class=\"form-control\" id=\"Name\" name=\"Name\" placeholder=\"Enter Full Name\">\r\n                            <div class=\"is-invalid\"> ");
            EndContext();
            BeginContext(1118, 38, false);
#line 29 "D:\MyProjects\projectX5\projectX2\Views\Admins\Create.cshtml"
                                                Write(Html.ValidationMessageFor(x => x.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1156, 118, true);
            WriteLiteral("</div>\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(1275, 30, false);
#line 32 "D:\MyProjects\projectX5\projectX2\Views\Admins\Create.cshtml"
                       Write(Html.LabelFor(x => x.Username));

#line default
#line hidden
            EndContext();
            BeginContext(1305, 184, true);
            WriteLiteral("\r\n                            <input type=\"text\" class=\"form-control\" id=\"Username\" name=\"Username\" placeholder=\"Enter Username\">\r\n                            <div class=\"is-invalid\"> ");
            EndContext();
            BeginContext(1490, 42, false);
#line 34 "D:\MyProjects\projectX5\projectX2\Views\Admins\Create.cshtml"
                                                Write(Html.ValidationMessageFor(x => x.Username));

#line default
#line hidden
            EndContext();
            BeginContext(1532, 118, true);
            WriteLiteral("</div>\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(1651, 27, false);
#line 37 "D:\MyProjects\projectX5\projectX2\Views\Admins\Create.cshtml"
                       Write(Html.LabelFor(x => x.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1678, 176, true);
            WriteLiteral("\r\n                            <input type=\"email\" class=\"form-control\" id=\"Email\" name=\"Email\" placeholder=\"Enter Email\">\r\n                            <div class=\"is-invalid\"> ");
            EndContext();
            BeginContext(1855, 39, false);
#line 39 "D:\MyProjects\projectX5\projectX2\Views\Admins\Create.cshtml"
                                                Write(Html.ValidationMessageFor(x => x.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1894, 118, true);
            WriteLiteral("</div>\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(2013, 30, false);
#line 42 "D:\MyProjects\projectX5\projectX2\Views\Admins\Create.cshtml"
                       Write(Html.LabelFor(x => x.Password));

#line default
#line hidden
            EndContext();
            BeginContext(2043, 188, true);
            WriteLiteral("\r\n                            <input type=\"password\" class=\"form-control\" id=\"Password\" name=\"Password\" placeholder=\"Enter Password\">\r\n                            <div class=\"is-invalid\"> ");
            EndContext();
            BeginContext(2232, 42, false);
#line 44 "D:\MyProjects\projectX5\projectX2\Views\Admins\Create.cshtml"
                                                Write(Html.ValidationMessageFor(x => x.Password));

#line default
#line hidden
            EndContext();
            BeginContext(2274, 118, true);
            WriteLiteral("</div>\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(2393, 37, false);
#line 47 "D:\MyProjects\projectX5\projectX2\Views\Admins\Create.cshtml"
                       Write(Html.LabelFor(x => x.ConfirmPassword));

#line default
#line hidden
            EndContext();
            BeginContext(2430, 204, true);
            WriteLiteral("\r\n                            <input type=\"password\" class=\"form-control\" id=\"ConfirmPassword\" name=\"ConfirmPassword\" placeholder=\"Confirm Password\">\r\n                            <div class=\"is-invalid\"> ");
            EndContext();
            BeginContext(2635, 49, false);
#line 49 "D:\MyProjects\projectX5\projectX2\Views\Admins\Create.cshtml"
                                                Write(Html.ValidationMessageFor(x => x.ConfirmPassword));

#line default
#line hidden
            EndContext();
            BeginContext(2684, 207, true);
            WriteLiteral("</div>\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label asp-for=\"RolesId\" class=\"control-label\">Role</label>\r\n                            ");
            EndContext();
            BeginContext(2892, 109, false);
#line 53 "D:\MyProjects\projectX5\projectX2\Views\Admins\Create.cshtml"
                       Write(Html.DropDownList("RolesId", null, htmlAttributes: new { @class = "form-control", @style = "width: 200px;" }));

#line default
#line hidden
            EndContext();
            BeginContext(3001, 377, true);
            WriteLiteral(@"
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
</section>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<projectX2.Models.AdminsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
