#pragma checksum "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c91e82fbf7b715d2b44075dafcabb7730af5a8ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Reservation_MyApprovalReservation), @"mvc.1.0.view", @"/Areas/Member/Views/Reservation/MyApprovalReservation.cshtml")]
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
#line 1 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
using TEntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c91e82fbf7b715d2b44075dafcabb7730af5a8ac", @"/Areas/Member/Views/Reservation/MyApprovalReservation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b237a0e58f02d784d053a87bfb972e34e33ba60", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_Reservation_MyApprovalReservation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Reservation>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
  
    ViewData["Title"] = "MyApprovalReservation";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Onay Bekleyen Rezervasyonlarım</h1>\r\n<table class=\"table table-hover\">\r\n    <tr>\r\n        <th>Lokasyon</th>\r\n        <th>Kişi Sayısı</th>\r\n        <th>Rezervasyon Tarihi</th>\r\n        <th>Durum</th>\r\n    </tr>\r\n");
#nullable restore
#line 17 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
           Write(item.Destination.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
           Write(item.PersonCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
           Write(item.ReservationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
           Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 25 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Reservation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
