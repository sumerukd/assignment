#pragma checksum "C:\Users\sumeru.k.danawade\Desktop\.net_sumeru-kuber-danawade\AssetManagementSystem\AssetManagementSysteM\Views\Hardware\Displayhardware.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "637b79aeb3728a88b801efcabfcda112ab9a62bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hardware_Displayhardware), @"mvc.1.0.view", @"/Views/Hardware/Displayhardware.cshtml")]
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
#line 1 "C:\Users\sumeru.k.danawade\Desktop\.net_sumeru-kuber-danawade\AssetManagementSystem\AssetManagementSysteM\Views\_ViewImports.cshtml"
using AssetManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sumeru.k.danawade\Desktop\.net_sumeru-kuber-danawade\AssetManagementSystem\AssetManagementSysteM\Views\_ViewImports.cshtml"
using AssetManagementSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"637b79aeb3728a88b801efcabfcda112ab9a62bc", @"/Views/Hardware/Displayhardware.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40e88a69747af55506521459522a8f1a7d830bf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Hardware_Displayhardware : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AssetManagementSystem.Models.HardwareAsset>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sumeru.k.danawade\Desktop\.net_sumeru-kuber-danawade\AssetManagementSystem\AssetManagementSysteM\Views\Hardware\Displayhardware.cshtml"
  
    ViewBag.Title = "hardwareAsset";
    var hardwareAsset = ViewBag.hardwareAsset;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Available Hardwares</h1>\r\n\r\n<p>\r\n\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\sumeru.k.danawade\Desktop\.net_sumeru-kuber-danawade\AssetManagementSystem\AssetManagementSysteM\Views\Hardware\Displayhardware.cshtml"
           Write(Html.DisplayNameFor(model => model.SerialNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\sumeru.k.danawade\Desktop\.net_sumeru-kuber-danawade\AssetManagementSystem\AssetManagementSysteM\Views\Hardware\Displayhardware.cshtml"
           Write(Html.DisplayNameFor(model => model.HardwareName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\sumeru.k.danawade\Desktop\.net_sumeru-kuber-danawade\AssetManagementSystem\AssetManagementSysteM\Views\Hardware\Displayhardware.cshtml"
           Write(Html.DisplayNameFor(model => model.ManufacturerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\sumeru.k.danawade\Desktop\.net_sumeru-kuber-danawade\AssetManagementSystem\AssetManagementSysteM\Views\Hardware\Displayhardware.cshtml"
           Write(Html.DisplayNameFor(model => model.DateOfManufacture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n\r\n\r\n        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Users\sumeru.k.danawade\Desktop\.net_sumeru-kuber-danawade\AssetManagementSystem\AssetManagementSysteM\Views\Hardware\Displayhardware.cshtml"
           Write(hardwareAsset.SerialNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\sumeru.k.danawade\Desktop\.net_sumeru-kuber-danawade\AssetManagementSystem\AssetManagementSysteM\Views\Hardware\Displayhardware.cshtml"
           Write(hardwareAsset.HardwareName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Users\sumeru.k.danawade\Desktop\.net_sumeru-kuber-danawade\AssetManagementSystem\AssetManagementSysteM\Views\Hardware\Displayhardware.cshtml"
           Write(hardwareAsset.ManufacturerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\sumeru.k.danawade\Desktop\.net_sumeru-kuber-danawade\AssetManagementSystem\AssetManagementSysteM\Views\Hardware\Displayhardware.cshtml"
           Write(hardwareAsset.DateOfManufacture);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AssetManagementSystem.Models.HardwareAsset>> Html { get; private set; }
    }
}
#pragma warning restore 1591
