#pragma checksum "C:\Users\aysenur\source\repos\TravelCoreProject\Views\Shared\Components\statistics\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f065dc7446024656eaf406200d79670e57b4b0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_statistics_Default), @"mvc.1.0.view", @"/Views/Shared/Components/statistics/Default.cshtml")]
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
#line 1 "C:\Users\aysenur\source\repos\TravelCoreProject\Views\_ViewImports.cshtml"
using TravelCoreProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aysenur\source\repos\TravelCoreProject\Views\_ViewImports.cshtml"
using TravelCoreProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\aysenur\source\repos\TravelCoreProject\Views\_ViewImports.cshtml"
using TEntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f065dc7446024656eaf406200d79670e57b4b0c", @"/Views/Shared/Components/statistics/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffb93191c7ef3c53b65d8d81382f9350bf2e4e73", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_statistics_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<section class=\"w3l-stats py-5\" id=\"stats\">\r\n    <div class=\"gallery-inner container py-lg-0 py-3\">\r\n        <div class=\"row stats-con pb-lg-3\">\r\n            <div class=\"col-lg-3 col-6 stats_info counter_grid\">\r\n                <p class=\"counter\">");
#nullable restore
#line 7 "C:\Users\aysenur\source\repos\TravelCoreProject\Views\Shared\Components\statistics\Default.cshtml"
                              Write(ViewBag.v1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <h4>Rotalar</h4>\r\n            </div>\r\n            <div class=\"col-lg-3 col-6 stats_info counter_grid1\">\r\n                <p class=\"counter\">");
#nullable restore
#line 11 "C:\Users\aysenur\source\repos\TravelCoreProject\Views\Shared\Components\statistics\Default.cshtml"
                              Write(ViewBag.v2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <h4>Tur Rehberleri</h4>\r\n            </div>\r\n            <div class=\"col-lg-3 col-6 stats_info counter_grid mt-lg-0 mt-5\">\r\n                <p class=\"counter\">");
#nullable restore
#line 15 "C:\Users\aysenur\source\repos\TravelCoreProject\Views\Shared\Components\statistics\Default.cshtml"
                              Write(ViewBag.v3);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                <h4>Müşteri Memnuniyeti</h4>
            </div>
            <div class=""col-lg-3 col-6 stats_info counter_grid2 mt-lg-0 mt-5"">
                <p class=""counter"">990</p>
                <h4>Ödüller</h4>
            </div>
        </div>
    </div>
</section>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591