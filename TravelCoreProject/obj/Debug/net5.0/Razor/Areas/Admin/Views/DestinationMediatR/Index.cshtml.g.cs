#pragma checksum "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Admin\Views\DestinationMediatR\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0a310b8b60cfaecafbf4d1e54d65282e798be15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_DestinationMediatR_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/DestinationMediatR/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0a310b8b60cfaecafbf4d1e54d65282e798be15", @"/Areas/Admin/Views/DestinationMediatR/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13a4ae9454dd90d527ed7abac117a7e5e4e77b04", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_DestinationMediatR_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GetAllGuideQueryResult>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Admin\Views\DestinationMediatR\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>CQRS MeditR Rehber Listesi</h1>\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Rehber Adı</th>\r\n        <th>Açıklama</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n    </tr>\r\n");
#nullable restore
#line 16 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Admin\Views\DestinationMediatR\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Admin\Views\DestinationMediatR\Index.cshtml"
           Write(item.GuideId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Admin\Views\DestinationMediatR\Index.cshtml"
           Write(item.GuideName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Admin\Views\DestinationMediatR\Index.cshtml"
           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a href=\"#\" class=\"btn btn-outline-warning\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 614, "\"", 670, 2);
            WriteAttributeValue("", 621, "/Admin/DestinationMediatR/GetGuides/", 621, 36, true);
#nullable restore
#line 23 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Admin\Views\DestinationMediatR\Index.cshtml"
WriteAttributeValue("", 657, item.GuideId, 657, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-secondary\">Güncelle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 25 "C:\Users\aysenur\source\repos\TravelCoreProject\Areas\Admin\Views\DestinationMediatR\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Admin/DestinationMediatR/AddGuides/\" class=\"btn btn-outline-success\">Yeni Rehber Ekle</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GetAllGuideQueryResult>> Html { get; private set; }
    }
}
#pragma warning restore 1591
