#pragma checksum "F:\projects\projectX5\projectX2\Views\Admins\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c88977b98cf08bcbb0486f4d7cb53f0305686256"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admins_Edit), @"mvc.1.0.view", @"/Views/Admins/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admins/Edit.cshtml", typeof(AspNetCore.Views_Admins_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c88977b98cf08bcbb0486f4d7cb53f0305686256", @"/Views/Admins/Edit.cshtml")]
    public class Views_Admins_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<projectX2.Models.AdminsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\projects\projectX5\projectX2\Views\Admins\Edit.cshtml"
  
    ViewData["Title"] = "Edit Admin";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(134, 91, true);
            WriteLiteral("<!-- Content Header (Page header) -->\r\n<section class=\"content-header\">\r\n    <h1>\r\n        ");
            EndContext();
            BeginContext(226, 17, false);
#line 9 "F:\projects\projectX5\projectX2\Views\Admins\Edit.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(243, 668, true);
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
                    <h3 class=""box-title"">Edit Admin Info</h3>
                </div>
                <!-- /.box-header -->
                <!-- form start -->
                <form method=""post"" asp-action=""/Admins/Edit"">
                    <div class=""box-body"">
                        <div class=""form-group"">
                            ");
            EndContext();
            BeginContext(912, 26, false);
#line 27 "F:\projects\projectX5\projectX2\Views\Admins\Edit.cshtml"
                       Write(Html.LabelFor(x => x.Name));

#line default
#line hidden
            EndContext();
            BeginContext(938, 91, true);
            WriteLiteral("\r\n                            <input type=\"text\" class=\"form-control\" id=\"Name\" name=\"Name\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1029, "\"", 1048, 1);
#line 28 "F:\projects\projectX5\projectX2\Views\Admins\Edit.cshtml"
WriteAttributeValue("", 1037, Model.Name, 1037, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1049, 80, true);
            WriteLiteral(" placeholder=\"Full Name\">\r\n                            <div class=\"is-invalid\"> ");
            EndContext();
            BeginContext(1130, 38, false);
#line 29 "F:\projects\projectX5\projectX2\Views\Admins\Edit.cshtml"
                                                Write(Html.ValidationMessageFor(x => x.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1168, 118, true);
            WriteLiteral("</div>\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(1287, 30, false);
#line 32 "F:\projects\projectX5\projectX2\Views\Admins\Edit.cshtml"
                       Write(Html.LabelFor(x => x.Username));

#line default
#line hidden
            EndContext();
            BeginContext(1317, 99, true);
            WriteLiteral("\r\n                            <input type=\"text\" class=\"form-control\" id=\"Username\" name=\"Username\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1416, "\"", 1439, 1);
#line 33 "F:\projects\projectX5\projectX2\Views\Admins\Edit.cshtml"
WriteAttributeValue("", 1424, Model.Username, 1424, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1440, 79, true);
            WriteLiteral(" placeholder=\"Username\">\r\n                            <div class=\"is-invalid\"> ");
            EndContext();
            BeginContext(1520, 42, false);
#line 34 "F:\projects\projectX5\projectX2\Views\Admins\Edit.cshtml"
                                                Write(Html.ValidationMessageFor(x => x.Username));

#line default
#line hidden
            EndContext();
            BeginContext(1562, 118, true);
            WriteLiteral("</div>\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(1681, 27, false);
#line 37 "F:\projects\projectX5\projectX2\Views\Admins\Edit.cshtml"
                       Write(Html.LabelFor(x => x.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1708, 94, true);
            WriteLiteral("\r\n                            <input type=\"email\" class=\"form-control\" id=\"Email\" name=\"Email\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1802, "\"", 1822, 1);
#line 38 "F:\projects\projectX5\projectX2\Views\Admins\Edit.cshtml"
WriteAttributeValue("", 1810, Model.Email, 1810, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1823, 76, true);
            WriteLiteral(" placeholder=\"Email\">\r\n                            <div class=\"is-invalid\"> ");
            EndContext();
            BeginContext(1900, 39, false);
#line 39 "F:\projects\projectX5\projectX2\Views\Admins\Edit.cshtml"
                                                Write(Html.ValidationMessageFor(x => x.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1939, 118, true);
            WriteLiteral("</div>\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(2058, 30, false);
#line 42 "F:\projects\projectX5\projectX2\Views\Admins\Edit.cshtml"
                       Write(Html.LabelFor(x => x.Password));

#line default
#line hidden
            EndContext();
            BeginContext(2088, 192, true);
            WriteLiteral("\r\n                            <input type=\"password\" class=\"form-control\" id=\"Password\" name=\"Password\" placeholder=\"Enter New Password\">\r\n                            <div class=\"is-invalid\"> ");
            EndContext();
            BeginContext(2281, 42, false);
#line 44 "F:\projects\projectX5\projectX2\Views\Admins\Edit.cshtml"
                                                Write(Html.ValidationMessageFor(x => x.Password));

#line default
#line hidden
            EndContext();
            BeginContext(2323, 118, true);
            WriteLiteral("</div>\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(2442, 37, false);
#line 47 "F:\projects\projectX5\projectX2\Views\Admins\Edit.cshtml"
                       Write(Html.LabelFor(x => x.ConfirmPassword));

#line default
#line hidden
            EndContext();
            BeginContext(2479, 204, true);
            WriteLiteral("\r\n                            <input type=\"password\" class=\"form-control\" id=\"ConfirmPassword\" name=\"ConfirmPassword\" placeholder=\"Confirm Password\">\r\n                            <div class=\"is-invalid\"> ");
            EndContext();
            BeginContext(2684, 49, false);
#line 49 "F:\projects\projectX5\projectX2\Views\Admins\Edit.cshtml"
                                                Write(Html.ValidationMessageFor(x => x.ConfirmPassword));

#line default
#line hidden
            EndContext();
            BeginContext(2733, 207, true);
            WriteLiteral("</div>\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label asp-for=\"RolesId\" class=\"control-label\">Role</label>\r\n                            ");
            EndContext();
            BeginContext(2941, 109, false);
#line 53 "F:\projects\projectX5\projectX2\Views\Admins\Edit.cshtml"
                       Write(Html.DropDownList("RolesId", null, htmlAttributes: new { @class = "form-control", @style = "width: 200px;" }));

#line default
#line hidden
            EndContext();
            BeginContext(3050, 88, true);
            WriteLiteral("\r\n                        </div>\r\n                        <input type=\"hidden\" name=\"Id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3138, "\"", 3155, 1);
#line 55 "F:\projects\projectX5\projectX2\Views\Admins\Edit.cshtml"
WriteAttributeValue("", 3146, Model.Id, 3146, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3156, 348, true);
            WriteLiteral(@" />
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
