#pragma checksum "C:\Users\sumeru.k.danawade\Desktop\mvc\AssetManagementSysteM\AssetManagementSysteM\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28bd5b4b9459cbef5e4f54641bba2f75fef3aa33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
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
#line 1 "C:\Users\sumeru.k.danawade\Desktop\mvc\AssetManagementSysteM\AssetManagementSysteM\Views\_ViewImports.cshtml"
using AssetManagementSysteM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sumeru.k.danawade\Desktop\mvc\AssetManagementSysteM\AssetManagementSysteM\Views\_ViewImports.cshtml"
using AssetManagementSysteM.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28bd5b4b9459cbef5e4f54641bba2f75fef3aa33", @"/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1198b02c2e8f0e9aeb8a9c422222c7e831397ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AssetManagementSysteM.Models.BookAsset>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sumeru.k.danawade\Desktop\mvc\AssetManagementSysteM\AssetManagementSysteM\Views\Book\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Available Books</h1>\r\n\r\n<p>\r\n   \r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\sumeru.k.danawade\Desktop\mvc\AssetManagementSysteM\AssetManagementSysteM\Views\Book\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SerialNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\sumeru.k.danawade\Desktop\mvc\AssetManagementSysteM\AssetManagementSysteM\Views\Book\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BookName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\sumeru.k.danawade\Desktop\mvc\AssetManagementSysteM\AssetManagementSysteM\Views\Book\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AuthorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\sumeru.k.danawade\Desktop\mvc\AssetManagementSysteM\AssetManagementSysteM\Views\Book\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DateOfPublish));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\sumeru.k.danawade\Desktop\mvc\AssetManagementSysteM\AssetManagementSysteM\Views\Book\Index.cshtml"
 foreach (var item in BookAsset.bookList) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\sumeru.k.danawade\Desktop\mvc\AssetManagementSysteM\AssetManagementSysteM\Views\Book\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SerialNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\sumeru.k.danawade\Desktop\mvc\AssetManagementSysteM\AssetManagementSysteM\Views\Book\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BookName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\sumeru.k.danawade\Desktop\mvc\AssetManagementSysteM\AssetManagementSysteM\Views\Book\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AuthorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\sumeru.k.danawade\Desktop\mvc\AssetManagementSysteM\AssetManagementSysteM\Views\Book\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateOfPublish));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\sumeru.k.danawade\Desktop\mvc\AssetManagementSysteM\AssetManagementSysteM\Views\Book\Index.cshtml"
           Write(Html.ActionLink("Update", "UpdateBooK", new { SerialNo = item.SerialNo }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 47 "C:\Users\sumeru.k.danawade\Desktop\mvc\AssetManagementSysteM\AssetManagementSysteM\Views\Book\Index.cshtml"
           Write(Html.ActionLink("Delete", "DeleteBook", new { SerialNo = item.SerialNo }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 51 "C:\Users\sumeru.k.danawade\Desktop\mvc\AssetManagementSysteM\AssetManagementSysteM\Views\Book\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AssetManagementSysteM.Models.BookAsset>> Html { get; private set; }
    }
}
#pragma warning restore 1591
