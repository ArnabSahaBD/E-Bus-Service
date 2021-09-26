#pragma checksum "E:\c#\EBus\Ebus\Views\Admin\daily.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72672ba63d2ee02d50f9ec0f3c5d6143c9bac49d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_daily), @"mvc.1.0.view", @"/Views/Admin/daily.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/daily.cshtml", typeof(AspNetCore.Views_Admin_daily))]
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
#line 1 "E:\c#\EBus\Ebus\Views\_ViewImports.cshtml"
using Ebus;

#line default
#line hidden
#line 2 "E:\c#\EBus\Ebus\Views\_ViewImports.cshtml"
using Ebus.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72672ba63d2ee02d50f9ec0f3c5d6143c9bac49d", @"/Views/Admin/daily.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02ad30c4f751e99dbd563e33deae9e688e594211", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_daily : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Record>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\c#\EBus\Ebus\Views\Admin\daily.cshtml"
  
    ViewData["Title"] = "daily";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(109, 479, true);
            WriteLiteral(@"
<div class=""container"">
<h2 class=""text-center"">Daily bus schedule</h2>
<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Customer Id</th>
            <th scope=""col"">Driver Id</th>
            <th scope=""col"">Bus number</th>
            <th scope=""col"">Fare</th>
            <th scope=""col"">Starting Location</th>
            <th scope=""col"">Destination</th>
            <th scope=""col"">Date</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 22 "E:\c#\EBus\Ebus\Views\Admin\daily.cshtml"
          
            foreach (var i in Model)
            {

#line default
#line hidden
            BeginContext(653, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(684, 12, false);
#line 26 "E:\c#\EBus\Ebus\Views\Admin\daily.cshtml"
           Write(i.customerId);

#line default
#line hidden
            EndContext();
            BeginContext(696, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(720, 10, false);
#line 27 "E:\c#\EBus\Ebus\Views\Admin\daily.cshtml"
           Write(i.driverId);

#line default
#line hidden
            EndContext();
            BeginContext(730, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(754, 11, false);
#line 28 "E:\c#\EBus\Ebus\Views\Admin\daily.cshtml"
           Write(i.busNumber);

#line default
#line hidden
            EndContext();
            BeginContext(765, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(789, 6, false);
#line 29 "E:\c#\EBus\Ebus\Views\Admin\daily.cshtml"
           Write(i.fare);

#line default
#line hidden
            EndContext();
            BeginContext(795, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(819, 6, false);
#line 30 "E:\c#\EBus\Ebus\Views\Admin\daily.cshtml"
           Write(i.from);

#line default
#line hidden
            EndContext();
            BeginContext(825, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(849, 4, false);
#line 31 "E:\c#\EBus\Ebus\Views\Admin\daily.cshtml"
           Write(i.to);

#line default
#line hidden
            EndContext();
            BeginContext(853, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(877, 6, false);
#line 32 "E:\c#\EBus\Ebus\Views\Admin\daily.cshtml"
           Write(i.date);

#line default
#line hidden
            EndContext();
            BeginContext(883, 24, true);
            WriteLiteral("</td>\r\n\r\n        </tr>\r\n");
            EndContext();
#line 35 "E:\c#\EBus\Ebus\Views\Admin\daily.cshtml"
            }
        

#line default
#line hidden
            BeginContext(933, 34, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Record>> Html { get; private set; }
    }
}
#pragma warning restore 1591