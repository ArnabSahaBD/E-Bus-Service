#pragma checksum "E:\c#\EBus\Ebus\Views\Passenger\showBus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a370fe8f5a2af4fb8ae88057b13179f617fecd52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Passenger_showBus), @"mvc.1.0.view", @"/Views/Passenger/showBus.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Passenger/showBus.cshtml", typeof(AspNetCore.Views_Passenger_showBus))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a370fe8f5a2af4fb8ae88057b13179f617fecd52", @"/Views/Passenger/showBus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02ad30c4f751e99dbd563e33deae9e688e594211", @"/Views/_ViewImports.cshtml")]
    public class Views_Passenger_showBus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<showBus>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\c#\EBus\Ebus\Views\Passenger\showBus.cshtml"
  
    ViewData["Title"] = "showBus";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(112, 164, true);
            WriteLiteral("<style>\r\n    .myaction {\r\n        color : white;\r\n    }\r\n</style>\r\n<br />\r\n<div class=\"container\">\r\n\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n");
            EndContext();
            BeginContext(320, 354, true);
            WriteLiteral(@"                <th scope=""col"">Bus number</th>
                <th scope=""col"">Bus service</th>
                <th scope=""col"">Male seat available</th>
                <th scope=""col"">Female seat available</th>
                <th scope=""col"">Distance</th>
                <th scope=""col"">Fare</th>
                <th scope=""col"">Ticket</th>

");
            EndContext();
            BeginContext(761, 50, true);
            WriteLiteral("\r\n\r\n            </tr>\r\n        </thead>\r\n<tbody>\r\n");
            EndContext();
#line 34 "E:\c#\EBus\Ebus\Views\Passenger\showBus.cshtml"
                    
        foreach (var i in Model)
        {
            

#line default
#line hidden
            BeginContext(927, 22, true);
            WriteLiteral("    <tr>\r\n        <td>");
            EndContext();
            BeginContext(950, 11, false);
#line 39 "E:\c#\EBus\Ebus\Views\Passenger\showBus.cshtml"
       Write(i.busNumber);

#line default
#line hidden
            EndContext();
            BeginContext(961, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(981, 12, false);
#line 40 "E:\c#\EBus\Ebus\Views\Passenger\showBus.cshtml"
       Write(i.busService);

#line default
#line hidden
            EndContext();
            BeginContext(993, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1013, 10, false);
#line 41 "E:\c#\EBus\Ebus\Views\Passenger\showBus.cshtml"
       Write(i.maleSeat);

#line default
#line hidden
            EndContext();
            BeginContext(1023, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1043, 12, false);
#line 42 "E:\c#\EBus\Ebus\Views\Passenger\showBus.cshtml"
       Write(i.femaleSeat);

#line default
#line hidden
            EndContext();
            BeginContext(1055, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1075, 10, false);
#line 43 "E:\c#\EBus\Ebus\Views\Passenger\showBus.cshtml"
       Write(i.distance);

#line default
#line hidden
            EndContext();
            BeginContext(1085, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1105, 6, false);
#line 44 "E:\c#\EBus\Ebus\Views\Passenger\showBus.cshtml"
       Write(i.fare);

#line default
#line hidden
            EndContext();
            BeginContext(1111, 102, true);
            WriteLiteral("</td>\r\n        <td>\r\n            <button class=\"btn btn-light \" style=\"color:white\">\r\n                ");
            EndContext();
            BeginContext(1214, 146, false);
#line 47 "E:\c#\EBus\Ebus\Views\Passenger\showBus.cshtml"
           Write(Html.ActionLink("Purchase Ticket","request","Passenger", new  {number = @i.busNumber, male = @i.maleSeat ,female = @i.femaleSeat,fare = @i.fare} ));

#line default
#line hidden
            EndContext();
            BeginContext(1360, 51, true);
            WriteLiteral("\r\n            </button>\r\n        </td>\r\n    </tr>\r\n");
            EndContext();
#line 51 "E:\c#\EBus\Ebus\Views\Passenger\showBus.cshtml"


        }

    

#line default
#line hidden
            BeginContext(1435, 46, true);
            WriteLiteral("\r\n\r\n\r\n</tbody>\r\n        </table>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<showBus>> Html { get; private set; }
    }
}
#pragma warning restore 1591
