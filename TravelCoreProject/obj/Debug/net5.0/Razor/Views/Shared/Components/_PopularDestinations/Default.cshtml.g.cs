#pragma checksum "C:\Users\aysenur\source\repos\TravelCoreProject\Views\Shared\Components\_PopularDestinations\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d978231d89eb42ca95fc65c0a52c0d8816793e16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__PopularDestinations_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_PopularDestinations/Default.cshtml")]
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
#line 1 "C:\Users\aysenur\source\repos\TravelCoreProject\Views\Shared\Components\_PopularDestinations\Default.cshtml"
using TEntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d978231d89eb42ca95fc65c0a52c0d8816793e16", @"/Views/Shared/Components/_PopularDestinations/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffb93191c7ef3c53b65d8d81382f9350bf2e4e73", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__PopularDestinations_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Destination>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""w3l-grids-3 py-5"">
    <div class=""container py-md-5"">
        <div class=""title-content text-left mb-lg-5 mb-4"">
            <h6 class=""sub-title"">Visit</h6>
            <h3 class=""hny-title"">Popular Destinations</h3>
        </div>
        <div class=""row bottom-ab-grids"">
            <!--/row-grids-->
");
#nullable restore
#line 11 "C:\Users\aysenur\source\repos\TravelCoreProject\Views\Shared\Components\_PopularDestinations\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-lg-6 subject-card mt-lg-0 mt-4"">
                <div class=""subject-card-header p-4"">
                    <a href=""#"" class=""card_title p-lg-4d-block"">
                        <div class=""row align-items-center"">
                            <div class=""col-sm-5 subject-img"">
                                <img");
            BeginWriteAttribute("src", " src=\"", 789, "\"", 806, 1);
#nullable restore
#line 18 "C:\Users\aysenur\source\repos\TravelCoreProject\Views\Shared\Components\_PopularDestinations\Default.cshtml"
WriteAttributeValue("", 795, item.image, 795, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 825, "\"", 831, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"col-sm-7 subject-content mt-sm-0 mt-4\">\r\n                                <h4>");
#nullable restore
#line 21 "C:\Users\aysenur\source\repos\TravelCoreProject\Views\Shared\Components\_PopularDestinations\Default.cshtml"
                               Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <p>");
#nullable restore
#line 22 "C:\Users\aysenur\source\repos\TravelCoreProject\Views\Shared\Components\_PopularDestinations\Default.cshtml"
                              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <div class=\"dst-btm\">\r\n                                    <h6");
            BeginWriteAttribute("class", " class=\"", 1157, "\"", 1165, 0);
            EndWriteAttribute();
            WriteLiteral("> Başlayan Fiyatlarla </h6>\r\n                                    <span>");
#nullable restore
#line 25 "C:\Users\aysenur\source\repos\TravelCoreProject\Views\Shared\Components\_PopularDestinations\Default.cshtml"
                                     Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                                <p class=\"sub-para\">");
#nullable restore
#line 27 "C:\Users\aysenur\source\repos\TravelCoreProject\Views\Shared\Components\_PopularDestinations\Default.cshtml"
                                               Write(item.DayNight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </a>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 33 "C:\Users\aysenur\source\repos\TravelCoreProject\Views\Shared\Components\_PopularDestinations\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n            \r\n    </div>\r\n</section>");
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
