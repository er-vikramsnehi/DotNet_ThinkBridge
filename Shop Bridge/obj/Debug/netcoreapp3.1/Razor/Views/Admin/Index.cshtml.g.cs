#pragma checksum "X:\Think Bridge\Shop Bridge\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9778c8eeb3f9732e9a677daee5e10b5234395f4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#nullable restore
#line 1 "X:\Think Bridge\Shop Bridge\Views\_ViewImports.cshtml"
using Shop_Bridge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "X:\Think Bridge\Shop Bridge\Views\_ViewImports.cshtml"
using Shop_Bridge.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9778c8eeb3f9732e9a677daee5e10b5234395f4e", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"effd497b511bd4a1aeb1acb6c6159016d7930d80", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Shop_Bridge.Models.Inventory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1 class=\"display-4\"> <tt> Admin Panel</tt> </h1>\r\n<hr />\r\n\r\n<p>\r\n    ");
#nullable restore
#line 12 "X:\Think Bridge\Shop Bridge\Views\Admin\Index.cshtml"
Write(Html.ActionLink("Add New Record", "Create", new { @class = "btn btn-secondary small" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 17 "X:\Think Bridge\Shop Bridge\Views\Admin\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 20 "X:\Think Bridge\Shop Bridge\Views\Admin\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 23 "X:\Think Bridge\Shop Bridge\Views\Admin\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 26 "X:\Think Bridge\Shop Bridge\Views\Admin\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 29 "X:\Think Bridge\Shop Bridge\Views\Admin\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n       \r\n        <th></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 35 "X:\Think Bridge\Shop Bridge\Views\Admin\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "X:\Think Bridge\Shop Bridge\Views\Admin\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "X:\Think Bridge\Shop Bridge\Views\Admin\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "X:\Think Bridge\Shop Bridge\Views\Admin\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "X:\Think Bridge\Shop Bridge\Views\Admin\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "X:\Think Bridge\Shop Bridge\Views\Admin\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n            <td>\r\n                ");
#nullable restore
#line 55 "X:\Think Bridge\Shop Bridge\Views\Admin\Index.cshtml"
           Write(Html.ActionLink("Modify Record", "Edit", new { id = item.id }, new { @class = "btn btn-secondary small" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 56 "X:\Think Bridge\Shop Bridge\Views\Admin\Index.cshtml"
           Write(Html.ActionLink("Records Details", "Details", new { id = item.id }, new { @class = "btn btn-secondary small" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 57 "X:\Think Bridge\Shop Bridge\Views\Admin\Index.cshtml"
           Write(Html.ActionLink("Delete Record", "Delete", new { id = item.id }, new { @class = "btn btn-secondary small" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 60 "X:\Think Bridge\Shop Bridge\Views\Admin\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Shop_Bridge.Models.Inventory>> Html { get; private set; }
    }
}
#pragma warning restore 1591