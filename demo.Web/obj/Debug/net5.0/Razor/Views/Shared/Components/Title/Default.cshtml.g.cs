#pragma checksum "D:\desarrollo\sources\globons\i+d\demo\demo.Web\Views\Shared\Components\Title\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ed43206fce5114ec6e7b4de01e99a671a8c34a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Title_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Title/Default.cshtml")]
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
#line 1 "D:\desarrollo\sources\globons\i+d\demo\demo.Web\Views\_ViewImports.cshtml"
using demo.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\desarrollo\sources\globons\i+d\demo\demo.Web\Views\_ViewImports.cshtml"
using demo.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\desarrollo\sources\globons\i+d\demo\demo.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\desarrollo\sources\globons\i+d\demo\demo.Web\Views\_ViewImports.cshtml"
using demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\desarrollo\sources\globons\i+d\demo\demo.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\desarrollo\sources\globons\i+d\demo\demo.Web\Views\_ViewImports.cshtml"
using demo.Infrastructure.Identity.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ed43206fce5114ec6e7b4de01e99a671a8c34a2", @"/Views/Shared/Components/Title/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dda3b18d34b1d006a64ab65bcc5da0e14866405", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Title_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"d-sm-flex align-items-center justify-content-between\">\r\n    <h1 class=\"h3 mb-0 text-gray-800\">");
#nullable restore
#line 2 "D:\desarrollo\sources\globons\i+d\demo\demo.Web\Views\Shared\Components\Title\Default.cshtml"
                                 Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n<p></p>\r\n<h6>");
#nullable restore
#line 5 "D:\desarrollo\sources\globons\i+d\demo\demo.Web\Views\Shared\Components\Title\Default.cshtml"
Write(ViewBag.Caption);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n<p></p>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer localizer { get; private set; }
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
