#pragma checksum "E:\c#\EBus\Ebus\Views\Owner\addRoute.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8eecaa3f814d534b0bdcbee7448c27ce3e7fb34c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Owner_addRoute), @"mvc.1.0.view", @"/Views/Owner/addRoute.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Owner/addRoute.cshtml", typeof(AspNetCore.Views_Owner_addRoute))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eecaa3f814d534b0bdcbee7448c27ce3e7fb34c", @"/Views/Owner/addRoute.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02ad30c4f751e99dbd563e33deae9e688e594211", @"/Views/_ViewImports.cshtml")]
    public class Views_Owner_addRoute : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<route>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("inputFromOption"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\c#\EBus\Ebus\Views\Owner\addRoute.cshtml"
  
    ViewData["Title"] = "addRoute";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(111, 58, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        ");
            EndContext();
            BeginContext(169, 792, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00f3c87cd5684e6fa2e42774d8bc7f1a", async() => {
                BeginContext(200, 219, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <label for=\"exampleFormControlSelect1\">Example select</label>\r\n                <select multiple class=\"form-control\" id=\"exampleFormControlSelect1\" name=\"input\">\r\n");
                EndContext();
#line 13 "E:\c#\EBus\Ebus\Views\Owner\addRoute.cshtml"
                     foreach (var i in Model)
                    {

#line default
#line hidden
                BeginContext(489, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(513, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88abdde8260f42c3b5bc6a544dfdadc5", async() => {
                    BeginContext(538, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(540, 9, false);
#line 15 "E:\c#\EBus\Ebus\Views\Owner\addRoute.cshtml"
                                             Write(i.busStop);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 15 "E:\c#\EBus\Ebus\Views\Owner\addRoute.cshtml"
                          WriteLiteral(i.busStop);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(558, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 16 "E:\c#\EBus\Ebus\Views\Owner\addRoute.cshtml"
                    }

#line default
#line hidden
                BeginContext(583, 211, true);
                WriteLiteral("                </select>\r\n            </div>\r\n\r\n           \r\n\r\n\r\n            <br>\r\n            <div class=\"form-group\">\r\n                <input class=\"form-control mt-2\"  type=\"text\" name=\"textBox\" id=\"textBox\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 794, "", 825, 1);
#line 25 "E:\c#\EBus\Ebus\Views\Owner\addRoute.cshtml"
WriteAttributeValue("", 801, TempData["inputoption"], 801, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(825, 129, true);
                WriteLiteral(" />\r\n            </div>\r\n       \r\n            <button type=\"submit\" class=\"btn btn-success btn-block\">Submit</button>\r\n\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(961, 63, true);
            WriteLiteral("\r\n       \r\n            \r\n            <button>\r\n                ");
            EndContext();
            BeginContext(1025, 90, false);
#line 34 "E:\c#\EBus\Ebus\Views\Owner\addRoute.cshtml"
           Write(Html.ActionLink("add", "routeValue", "Owner", new {totalRoute = TempData["inputoption"] }));

#line default
#line hidden
            EndContext();
            BeginContext(1115, 249, true);
            WriteLiteral("\r\n               \r\n            </button>\r\n      \r\n        \r\n    </div>\r\n    \r\n</div>\r\n<script>\r\n    function myFun() {\r\n        var a = document.getElementById(\'textBox\').value;\r\n        document.getElementById(\"second\").value = a;\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<route>> Html { get; private set; }
    }
}
#pragma warning restore 1591
