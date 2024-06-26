#pragma checksum "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Admin\Views\Announcement\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e292c4629d44d8e31ace6bf69225bc20372273c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Announcement_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Announcement/Index.cshtml")]
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
#line 1 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Admin\_ViewImports.cshtml"
using TravelCoreProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Admin\_ViewImports.cshtml"
using TravelCoreProject.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Admin\_ViewImports.cshtml"
using TEntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Admin\_ViewImports.cshtml"
using TravelCoreProject.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Admin\_ViewImports.cshtml"
using TravelCoreProject.CQRS.Results.DestinationResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Admin\_ViewImports.cshtml"
using TravelCoreProject.CQRS.Results.GetAllGuideQueryResult;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Admin\_ViewImports.cshtml"
using TravelCoreProject.CQRS.Commands;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e292c4629d44d8e31ace6bf69225bc20372273c1", @"/Areas/Admin/Views/Announcement/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13a4ae9454dd90d527ed7abac117a7e5e4e77b04", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Announcement_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DTOLayer.DTOs.AnnouncementDTOs.AnnouncementListDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Admin\Views\Announcement\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Duyuru Listesi</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Başlık</th>\r\n        <th>İçerik</th>\r\n        <th>Detaylar</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n    </tr>\r\n");
#nullable restore
#line 18 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Admin\Views\Announcement\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Admin\Views\Announcement\Index.cshtml"
           Write(item.AnnouncementId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Admin\Views\Announcement\Index.cshtml"
           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Admin\Views\Announcement\Index.cshtml"
           Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a href=\"#\" class=\"btn btn-outline-dark\">Detaylar</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 654, "\"", 720, 2);
            WriteAttributeValue("", 661, "/Admin/Announcement/DeleteAnanuncement/", 661, 39, true);
#nullable restore
#line 25 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Admin\Views\Announcement\Index.cshtml"
WriteAttributeValue("", 700, item.AnnouncementId, 700, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 786, "\"", 852, 2);
            WriteAttributeValue("", 793, "/Admin/Announcement/UpdateAnnouncement/", 793, 39, true);
#nullable restore
#line 26 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Admin\Views\Announcement\Index.cshtml"
WriteAttributeValue("", 832, item.AnnouncementId, 832, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Güncelle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 28 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Admin\Views\Announcement\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Admin/Announcement/AddAnnouncement/\">Yeni Oluştur</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DTOLayer.DTOs.AnnouncementDTOs.AnnouncementListDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
