#pragma checksum "C:\Users\Melis Akarcay\source\repos\kopya\kopya\Views\Orders\price.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d637673adda1b66c5b43226f9cf3ac4fba2e5ec2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_price), @"mvc.1.0.view", @"/Views/Orders/price.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/price.cshtml", typeof(AspNetCore.Views_Orders_price))]
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
#line 1 "C:\Users\Melis Akarcay\source\repos\kopya\kopya\Views\_ViewImports.cshtml"
using OrderManagement;

#line default
#line hidden
#line 2 "C:\Users\Melis Akarcay\source\repos\kopya\kopya\Views\_ViewImports.cshtml"
using OrderManagement.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d637673adda1b66c5b43226f9cf3ac4fba2e5ec2", @"/Views/Orders/price.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdb47bb8a3f15f61954358f49816cb9f078483ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_price : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OrderManagement.Models.Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteTable", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Det", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 10, true);
            WriteLiteral("\r\n<html>\r\n");
            EndContext();
            BeginContext(60, 1006, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d637673adda1b66c5b43226f9cf3ac4fba2e5ec24103", async() => {
                BeginContext(66, 993, true);
                WriteLiteral(@"
    <style>
        

        .h1 {
            color: black;
            font-size: 30px;
            text-transform: uppercase;
        }

        .myBox {
            width: 500px;
            padding: 20px;
            left: 30%;
        top: 17%;
            position: absolute;
            transform: translate(-%50,-%50);
            background: #ffffff;
            text-align: center;
        }

        body {
            margin: 0;
            padding: 0;
            background: black;
            
            background-repeat: no-repeat;
            background-size: cover;
        }

        .myButton {
            border: 0;
            display: block;
            margin: 20px auto;
            text-align: center;
            border: 2px solid black;
            padding: 14px 40px;
            outline: none;
            color: black;
            border-radius: 20px;
            font-weight: bold;
        }
    </style>



");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1066, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1068, 1329, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d637673adda1b66c5b43226f9cf3ac4fba2e5ec26278", async() => {
                BeginContext(1074, 428, true);
                WriteLiteral(@"
    <br />

    <div class=""myBox"">
       



        <table class=""table"">
            <thead class=""thead-light"">
                <tr>


                    <th>
                        Order Name
                    </th>

                    <th>
                        Quantity
                    </th>
                    




                </tr>
            </thead>
            <tbody>
");
                EndContext();
#line 79 "C:\Users\Melis Akarcay\source\repos\kopya\kopya\Views\Orders\price.cshtml"
                 foreach (var item in Model)
                {
                   






#line default
#line hidden
                BeginContext(1598, 98, true);
                WriteLiteral("                        <tr>\r\n                            <td>\r\n\r\n                                ");
                EndContext();
                BeginContext(1697, 44, false);
#line 90 "C:\Users\Melis Akarcay\source\repos\kopya\kopya\Views\Orders\price.cshtml"
                           Write(Html.DisplayFor(modelItem => item.OrderName));

#line default
#line hidden
                EndContext();
                BeginContext(1741, 111, true);
                WriteLiteral("\r\n\r\n                            </td>\r\n\r\n\r\n                            <td>\r\n\r\n                                ");
                EndContext();
                BeginContext(1853, 41, false);
#line 97 "C:\Users\Melis Akarcay\source\repos\kopya\kopya\Views\Orders\price.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
                EndContext();
                BeginContext(1894, 100, true);
                WriteLiteral("\r\n\r\n                            </td>\r\n                            \r\n                        </tr>\r\n");
                EndContext();
#line 102 "C:\Users\Melis Akarcay\source\repos\kopya\kopya\Views\Orders\price.cshtml"



                    
                }

#line default
#line hidden
                BeginContext(2041, 60, true);
                WriteLiteral("            </tbody>\r\n        </table>\r\n        Total : <h2>");
                EndContext();
                BeginContext(2102, 17, false);
#line 109 "C:\Users\Melis Akarcay\source\repos\kopya\kopya\Views\Orders\price.cshtml"
               Write(TempData["fiyat"]);

#line default
#line hidden
                EndContext();
                BeginContext(2119, 28, true);
                WriteLiteral(" tl</h2>\r\n        \r\n        ");
                EndContext();
                BeginContext(2147, 112, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d637673adda1b66c5b43226f9cf3ac4fba2e5ec29265", async() => {
                    BeginContext(2210, 45, true);
                    WriteLiteral("<button class=\"myButton\">Close Table</button>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 111 "C:\Users\Melis Akarcay\source\repos\kopya\kopya\Views\Orders\price.cshtml"
                                      WriteLiteral(TempData["TableN"]);

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
                BeginContext(2259, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2269, 103, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d637673adda1b66c5b43226f9cf3ac4fba2e5ec211770", async() => {
                    BeginContext(2324, 44, true);
                    WriteLiteral("<button class=\"myButton\">Order Page</button>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 112 "C:\Users\Melis Akarcay\source\repos\kopya\kopya\Views\Orders\price.cshtml"
                              WriteLiteral(TempData["TableN"]);

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
                BeginContext(2372, 18, true);
                WriteLiteral("\r\n    </div>\r\n\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2397, 104, true);
            WriteLiteral("\r\n\r\n\r\n</html>\r\n\r\n<!-- js fonk : model boşsa - boş yazdır eğer masa dolu ise dışı kırmızı olsun mesela-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OrderManagement.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
