#pragma checksum "C:\Users\mpadmin\source\repos\ASPdotNET\Assignment 2\YasinHabib_CPRG214_Lab2\Presentation.AssetTracking\Views\Shared\Components\AssetsByType\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa4c245cdacb484c67bc3632ddb2f2fc33d6c678"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AssetsByType_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AssetsByType/Default.cshtml")]
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
#line 1 "C:\Users\mpadmin\source\repos\ASPdotNET\Assignment 2\YasinHabib_CPRG214_Lab2\Presentation.AssetTracking\Views\_ViewImports.cshtml"
using Presentation.AssetTracking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mpadmin\source\repos\ASPdotNET\Assignment 2\YasinHabib_CPRG214_Lab2\Presentation.AssetTracking\Views\_ViewImports.cshtml"
using Presentation.AssetTracking.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa4c245cdacb484c67bc3632ddb2f2fc33d6c678", @"/Views/Shared/Components/AssetsByType/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"746789842ccfc75fc9da5451c131e66c5eb44a50", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AssetsByType_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Presentation.AssetTracking.Models.AssetViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\mpadmin\source\repos\ASPdotNET\Assignment 2\YasinHabib_CPRG214_Lab2\Presentation.AssetTracking\Views\Shared\Components\AssetsByType\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /><br />\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 11 "C:\Users\mpadmin\source\repos\ASPdotNET\Assignment 2\YasinHabib_CPRG214_Lab2\Presentation.AssetTracking\Views\Shared\Components\AssetsByType\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.TagNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\mpadmin\source\repos\ASPdotNET\Assignment 2\YasinHabib_CPRG214_Lab2\Presentation.AssetTracking\Views\Shared\Components\AssetsByType\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\mpadmin\source\repos\ASPdotNET\Assignment 2\YasinHabib_CPRG214_Lab2\Presentation.AssetTracking\Views\Shared\Components\AssetsByType\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.SerialNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\mpadmin\source\repos\ASPdotNET\Assignment 2\YasinHabib_CPRG214_Lab2\Presentation.AssetTracking\Views\Shared\Components\AssetsByType\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.AssetType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 26 "C:\Users\mpadmin\source\repos\ASPdotNET\Assignment 2\YasinHabib_CPRG214_Lab2\Presentation.AssetTracking\Views\Shared\Components\AssetsByType\Default.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 29 "C:\Users\mpadmin\source\repos\ASPdotNET\Assignment 2\YasinHabib_CPRG214_Lab2\Presentation.AssetTracking\Views\Shared\Components\AssetsByType\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.TagNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "C:\Users\mpadmin\source\repos\ASPdotNET\Assignment 2\YasinHabib_CPRG214_Lab2\Presentation.AssetTracking\Views\Shared\Components\AssetsByType\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "C:\Users\mpadmin\source\repos\ASPdotNET\Assignment 2\YasinHabib_CPRG214_Lab2\Presentation.AssetTracking\Views\Shared\Components\AssetsByType\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.SerialNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "C:\Users\mpadmin\source\repos\ASPdotNET\Assignment 2\YasinHabib_CPRG214_Lab2\Presentation.AssetTracking\Views\Shared\Components\AssetsByType\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.AssetType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 41 "C:\Users\mpadmin\source\repos\ASPdotNET\Assignment 2\YasinHabib_CPRG214_Lab2\Presentation.AssetTracking\Views\Shared\Components\AssetsByType\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Presentation.AssetTracking.Models.AssetViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
