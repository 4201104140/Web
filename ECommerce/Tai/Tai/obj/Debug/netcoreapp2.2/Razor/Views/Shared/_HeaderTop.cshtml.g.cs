#pragma checksum "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\_HeaderTop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "743583f7a9a036bffbfec6743d722fea14ff3338"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__HeaderTop), @"mvc.1.0.view", @"/Views/Shared/_HeaderTop.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_HeaderTop.cshtml", typeof(AspNetCore.Views_Shared__HeaderTop))]
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
#line 1 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\_ViewImports.cshtml"
using Tai;

#line default
#line hidden
#line 2 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\_ViewImports.cshtml"
using Tai.Models;

#line default
#line hidden
#line 3 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\_ViewImports.cshtml"
using Tai.Models.CartModels;

#line default
#line hidden
#line 4 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\_ViewImports.cshtml"
using Tai.DataModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"743583f7a9a036bffbfec6743d722fea14ff3338", @"/Views/Shared/_HeaderTop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f30cbd38c6f989b7773fdb519eef7f8d551d4ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__HeaderTop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("header-search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SignIn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("item1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\_HeaderTop.cshtml"
   
    List<CartItem> cartItems = Context.Session.GetObject<List<CartItem>>("Cart");
    var count = 0;
    var sumPrice = 0.0;
    if (cartItems?.Count>0)
    {
        count = cartItems.Count;
        sumPrice = cartItems.Sum(item => item.Price);
    }
    var user = Context.Session.GetObject<Customer>("user");

#line default
#line hidden
            BeginContext(329, 242, true);
            WriteLiteral("<div class=\"header-top\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-2 text-center text-lg-left\">\r\n                <!-- logo -->\r\n                <a href=\"/\" class=\"site-logo\">\r\n                    ");
            EndContext();
            BeginContext(571, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "743583f7a9a036bffbfec6743d722fea14ff33387287", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(607, 105, true);
            WriteLiteral("\r\n                </a>\r\n            </div>\r\n            <div class=\"col-xl-6 col-lg-5\">\r\n                ");
            EndContext();
            BeginContext(712, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "743583f7a9a036bffbfec6743d722fea14ff33388653", async() => {
                BeginContext(745, 167, true);
                WriteLiteral("\r\n                    <input type=\"text\" placeholder=\"Search on divisima ....\">\r\n                    <button><i class=\"flaticon-search\"></i></button>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(919, 210, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-xl-4 col-lg-5\">\r\n                <div class=\"user-panel\">\r\n                    <div class=\"up-item\">\r\n                        <i class=\"flaticon-profile\"></i>\r\n");
            EndContext();
#line 31 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\_HeaderTop.cshtml"
                         if (user != null)
                        {

#line default
#line hidden
            BeginContext(1200, 43, true);
            WriteLiteral("                            <a href=\"#\">Hi ");
            EndContext();
            BeginContext(1244, 17, false);
#line 33 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\_HeaderTop.cshtml"
                                      Write(user.CustomerName);

#line default
#line hidden
            EndContext();
            BeginContext(1261, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 34 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\_HeaderTop.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1351, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1379, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "743583f7a9a036bffbfec6743d722fea14ff333811619", async() => {
                BeginContext(1469, 9, true);
                WriteLiteral("Đăng nhập");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 37 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\_HeaderTop.cshtml"
                                                                                   WriteLiteral(Context.Request.Path);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1482, 1, true);
            WriteLiteral(" ");
            EndContext();
#line 37 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\_HeaderTop.cshtml"
                                                                                                                                                                                
                        }

#line default
#line hidden
            BeginContext(1556, 216, true);
            WriteLiteral("                    </div>\r\n                    <div class=\"up-item\">\r\n                        <div class=\"shopping-card\">\r\n                            <i class=\"flaticon-bag\"></i>\r\n                            <span>");
            EndContext();
            BeginContext(1773, 5, false);
#line 43 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\_HeaderTop.cshtml"
                             Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(1778, 452, true);
            WriteLiteral(@"</span>
                        </div>
                        <a href=""#"" id=""cart"">Shopping Cart</a>
                    </div>
                    <div class=""container"" style=""z-index:20;position:absolute;"">
                        <div class=""shopping-cart"" style=""display:none"">
                            <div class=""shopping-cart-header"">
                                <i class=""fa fa-shopping-cart cart-icon""></i><span class=""badge"">");
            EndContext();
            BeginContext(2231, 5, false);
#line 50 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\_HeaderTop.cshtml"
                                                                                            Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(2236, 220, true);
            WriteLiteral("</span>\r\n                                <div class=\"shopping-cart-total\">\r\n                                    <span class=\"lighter-text\">Total:</span>\r\n                                    <span class=\"main-color-text\">");
            EndContext();
            BeginContext(2457, 8, false);
#line 53 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\_HeaderTop.cshtml"
                                                             Write(sumPrice);

#line default
#line hidden
            EndContext();
            BeginContext(2465, 182, true);
            WriteLiteral("</span>\r\n                                </div>\r\n                            </div> <!--end shopping-cart-header -->\r\n\r\n                            <ul class=\"shopping-cart-items\">\r\n");
            EndContext();
#line 58 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\_HeaderTop.cshtml"
                                 if (cartItems?.Count > 0)
                                {
                                    

#line default
#line hidden
#line 60 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\_HeaderTop.cshtml"
                                     foreach (var item in cartItems)
                                    {

#line default
#line hidden
            BeginContext(2851, 107, true);
            WriteLiteral("                                        <li class=\"clearfix\">\r\n                                            ");
            EndContext();
            BeginContext(2958, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "743583f7a9a036bffbfec6743d722fea14ff333817584", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2968, "~/Hinh/product/", 2968, 15, true);
#line 63 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\_HeaderTop.cshtml"
AddHtmlAttributeValue("", 2983, item.Product.Images, 2983, 20, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3041, 70, true);
            WriteLiteral("\r\n                                            <span class=\"item-name\">");
            EndContext();
            BeginContext(3112, 24, false);
#line 64 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\_HeaderTop.cshtml"
                                                               Write(item.Product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(3136, 78, true);
            WriteLiteral("</span>\r\n                                            <span class=\"item-price\">");
            EndContext();
            BeginContext(3215, 10, false);
#line 65 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\_HeaderTop.cshtml"
                                                                Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(3225, 91, true);
            WriteLiteral("</span>\r\n                                            <span class=\"item-quantity\">Quantity: ");
            EndContext();
            BeginContext(3317, 13, false);
#line 66 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\_HeaderTop.cshtml"
                                                                             Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(3330, 56, true);
            WriteLiteral("</span>\r\n                                        </li>\r\n");
            EndContext();
#line 68 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\_HeaderTop.cshtml"
                                    }

#line default
#line hidden
#line 68 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\_HeaderTop.cshtml"
                                     
                                }

#line default
#line hidden
            BeginContext(3460, 319, true);
            WriteLiteral(@"


                            </ul>

                            <a class=""button"" href=""/gio-hang/thanh-toan"">Checkout</a>
                        </div> <!--end shopping-cart -->
                    </div> <!--end container -->
                </div>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
