#pragma checksum "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Member\Views\Destination\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c849f342241de920a76b2928eca6e13cd19d193"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Destination_Index), @"mvc.1.0.view", @"/Areas/Member/Views/Destination/Index.cshtml")]
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
#line 1 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Member\Views\_ViewImports.cshtml"
using TravelCoreProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Member\Views\_ViewImports.cshtml"
using TravelCoreProject.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Member\Views\Destination\Index.cshtml"
using TEntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c849f342241de920a76b2928eca6e13cd19d193", @"/Areas/Member/Views/Destination/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b237a0e58f02d784d053a87bfb972e34e33ba60", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_Destination_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Destination>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Member\Views\Destination\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Aktif Tur Rotalarımız</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Şehir</th>\r\n        <th>Süre</th>\r\n        <th>Kapasite</th>\r\n        <th>Fiyat</th>\r\n        <th>Detay</th>\r\n    </tr>\r\n");
#nullable restore
#line 19 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Member\Views\Destination\Index.cshtml"
   foreach (var item in Model)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr>\r\n          <td>");
#nullable restore
#line 22 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Member\Views\Destination\Index.cshtml"
         Write(item.DestinationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 23 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Member\Views\Destination\Index.cshtml"
         Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 24 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Member\Views\Destination\Index.cshtml"
         Write(item.DayNight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 25 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Member\Views\Destination\Index.cshtml"
         Write(item.Capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 26 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Member\Views\Destination\Index.cshtml"
         Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td><a href=\"#\" class=\"btn btn-outline-info\"> Detaylı Görüntüle</a></td>\r\n      </tr>\r\n");
#nullable restore
#line 29 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Member\Views\Destination\Index.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Destination>> Html { get; private set; }
    }
}
#pragma warning restore 1591