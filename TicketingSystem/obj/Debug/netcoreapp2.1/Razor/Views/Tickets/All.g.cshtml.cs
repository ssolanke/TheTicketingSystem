#pragma checksum "C:\Users\TEMP.LAPTOP-HUIVU44P.000.001.002\source\repos\TicketingSystem\TicketingSystem\Views\Tickets\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b3ef24f9e3ff494732099ae1c3f65ee5319cadb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tickets_All), @"mvc.1.0.view", @"/Views/Tickets/All.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tickets/All.cshtml", typeof(AspNetCore.Views_Tickets_All))]
namespace AspNetCore
{
    #line hidden
    using System;
#line 5 "C:\Users\TEMP.LAPTOP-HUIVU44P.000.001.002\source\repos\TicketingSystem\TicketingSystem\Views\Tickets\All.cshtml"
using System.Collections.Generic;

#line default
#line hidden
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\TEMP.LAPTOP-HUIVU44P.000.001.002\source\repos\TicketingSystem\TicketingSystem\Views\_ViewImports.cshtml"
using TicketingSystem;

#line default
#line hidden
#line 4 "C:\Users\TEMP.LAPTOP-HUIVU44P.000.001.002\source\repos\TicketingSystem\TicketingSystem\Views\Tickets\All.cshtml"
using TicketingSystem.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b3ef24f9e3ff494732099ae1c3f65ee5319cadb", @"/Views/Tickets/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd57ce5b7b2afa85b27a24e1db4401554cba05c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Tickets_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ticket>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "All", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-includeClosed", "true", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Open", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\TEMP.LAPTOP-HUIVU44P.000.001.002\source\repos\TicketingSystem\TicketingSystem\Views\Tickets\All.cshtml"
  
    ViewData["Title"] = "All Tickets";

#line default
#line hidden
            BeginContext(141, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\TEMP.LAPTOP-HUIVU44P.000.001.002\source\repos\TicketingSystem\TicketingSystem\Views\Tickets\All.cshtml"
 if ((bool)ViewData["includeClosed"])
{

#line default
#line hidden
            BeginContext(185, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(189, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "976db9c644674556ba444a5e5adb177e", async() => {
                BeginContext(209, 22, true);
                WriteLiteral("Exclude Closed Tickets");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(235, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 11 "C:\Users\TEMP.LAPTOP-HUIVU44P.000.001.002\source\repos\TicketingSystem\TicketingSystem\Views\Tickets\All.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(249, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(253, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9c1f80069004b38b55e2881f86addfb", async() => {
                BeginContext(304, 22, true);
                WriteLiteral("Include Closed Tickets");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-includeClosed", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["includeClosed"] = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(330, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 15 "C:\Users\TEMP.LAPTOP-HUIVU44P.000.001.002\source\repos\TicketingSystem\TicketingSystem\Views\Tickets\All.cshtml"
}

#line default
#line hidden
            BeginContext(335, 37, true);
            WriteLiteral("\r\n<h2>All</h2>\r\n\r\n<div class=\"row\">\r\n");
            EndContext();
#line 20 "C:\Users\TEMP.LAPTOP-HUIVU44P.000.001.002\source\repos\TicketingSystem\TicketingSystem\Views\Tickets\All.cshtml"
     foreach (var ticket in Model)
    {



#line default
#line hidden
            BeginContext(419, 217, true);
            WriteLiteral("        <div class=\"col s12 m6 l3\">\r\n            <div class=\"card stickey-action grey darken-1 hoverable activato\">\r\n                <div class=\"card-content white-text\">\r\n                    <span class=\"card-title\">");
            EndContext();
            BeginContext(637, 12, false);
#line 27 "C:\Users\TEMP.LAPTOP-HUIVU44P.000.001.002\source\repos\TicketingSystem\TicketingSystem\Views\Tickets\All.cshtml"
                                        Write(ticket.Title);

#line default
#line hidden
            EndContext();
            BeginContext(649, 68, true);
            WriteLiteral("</span>\r\n                    <i class=\"medium material-icons right\">");
            EndContext();
            BeginContext(719, 30, false);
#line 28 "C:\Users\TEMP.LAPTOP-HUIVU44P.000.001.002\source\repos\TicketingSystem\TicketingSystem\Views\Tickets\All.cshtml"
                                                       Write(ticket.IsUrgent ? "error" : "");

#line default
#line hidden
            EndContext();
            BeginContext(750, 29, true);
            WriteLiteral("</i>\r\n                    <p>");
            EndContext();
            BeginContext(780, 18, false);
#line 29 "C:\Users\TEMP.LAPTOP-HUIVU44P.000.001.002\source\repos\TicketingSystem\TicketingSystem\Views\Tickets\All.cshtml"
                  Write(ticket.Description);

#line default
#line hidden
            EndContext();
            BeginContext(798, 49, true);
            WriteLiteral("</p><br>\r\n                    <p>This ticket is  ");
            EndContext();
            BeginContext(849, 40, false);
#line 30 "C:\Users\TEMP.LAPTOP-HUIVU44P.000.001.002\source\repos\TicketingSystem\TicketingSystem\Views\Tickets\All.cshtml"
                                   Write(ticket.TicketStatus ? "open." : "closed");

#line default
#line hidden
            EndContext();
            BeginContext(890, 33, true);
            WriteLiteral("</p><br>\r\n                    <p>");
            EndContext();
            BeginContext(924, 30, false);
#line 31 "C:\Users\TEMP.LAPTOP-HUIVU44P.000.001.002\source\repos\TicketingSystem\TicketingSystem\Views\Tickets\All.cshtml"
                  Write(ticket.DateAdded.ToString("d"));

#line default
#line hidden
            EndContext();
            BeginContext(954, 148, true);
            WriteLiteral("</p><br>\r\n                </div>\r\n\r\n                <div class=\"card-reveal\">\r\n                    <span class=\"card-title grey-text text-darken-4\">");
            EndContext();
            BeginContext(1103, 12, false);
#line 35 "C:\Users\TEMP.LAPTOP-HUIVU44P.000.001.002\source\repos\TicketingSystem\TicketingSystem\Views\Tickets\All.cshtml"
                                                                Write(ticket.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1115, 73, true);
            WriteLiteral("<i class=\"material-icons right\">close</i></span>\r\n                    <p>");
            EndContext();
            BeginContext(1189, 12, false);
#line 36 "C:\Users\TEMP.LAPTOP-HUIVU44P.000.001.002\source\repos\TicketingSystem\TicketingSystem\Views\Tickets\All.cshtml"
                  Write(ticket.Notes);

#line default
#line hidden
            EndContext();
            BeginContext(1201, 93, true);
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"card-action\">\r\n                    ");
            EndContext();
            BeginContext(1294, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1101f5c2e72f492298b36b1d1ae8f076", async() => {
                BeginContext(1347, 4, true);
                WriteLiteral("Open");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 39 "C:\Users\TEMP.LAPTOP-HUIVU44P.000.001.002\source\repos\TicketingSystem\TicketingSystem\Views\Tickets\All.cshtml"
                                           WriteLiteral(ticket.TicketId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1355, 62, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 43 "C:\Users\TEMP.LAPTOP-HUIVU44P.000.001.002\source\repos\TicketingSystem\TicketingSystem\Views\Tickets\All.cshtml"


    }

#line default
#line hidden
            BeginContext(1428, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ticket>> Html { get; private set; }
    }
}
#pragma warning restore 1591
