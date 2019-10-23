#pragma checksum "C:\Users\phant\OneDrive\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\_MyHeader.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af84ee9e1eced6d2621e93fbfb66b05be65f4167"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__MyHeader), @"mvc.1.0.view", @"/Views/Shared/_MyHeader.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_MyHeader.cshtml", typeof(AspNetCore.Views_Shared__MyHeader))]
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
#line 1 "C:\Users\phant\OneDrive\Desktop\Web\ECommerce\Tai\Tai\Views\_ViewImports.cshtml"
using Tai;

#line default
#line hidden
#line 2 "C:\Users\phant\OneDrive\Desktop\Web\ECommerce\Tai\Tai\Views\_ViewImports.cshtml"
using Tai.Models;

#line default
#line hidden
#line 3 "C:\Users\phant\OneDrive\Desktop\Web\ECommerce\Tai\Tai\Views\_ViewImports.cshtml"
using Tai.Models.CartModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af84ee9e1eced6d2621e93fbfb66b05be65f4167", @"/Views/Shared/_MyHeader.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f9b7745c2e643501d3439bff4cb481f55e89933", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__MyHeader : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("ShopMart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("ShopMart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("html Template"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("65"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(71, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\phant\OneDrive\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\_MyHeader.cshtml"
   
    List<CartItem> cartItems = Context.Session.GetObject<List<CartItem>>("Cart");
    var count = 0;
    var sumPrice = 0.0;
    if (cartItems.Count != 0)
    {
        count = cartItems.Count;
        sumPrice = cartItems.Sum(item => item.Price);
    }


#line default
#line hidden
            BeginContext(345, 2546, true);
            WriteLiteral(@"<div class=""header-container"">
    <div class=""header-top"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-sm-4 col-md-4 col-xs-12"">
                    <!-- Default Welcome Message -->
                    <div class=""welcome-msg hidden-xs hidden-sm"">Welcome MyStore! </div>
                    <span id=""dongHo"" class=""text-danger""></span>
                </div>

                <!-- top links -->
                <div class=""headerlinkmenu col-md-8 col-sm-8 col-xs-12"">
                    <span class=""phone  hidden-xs hidden-sm""> <i class=""fa-mobile""></i>Call Us: (+84) 028393 22735</span>
                    <ul class=""links"">
                        <li class=""hidden-xs""><a title=""Help Center"" href=""#""><span>Help Center</span></a></li>
                        <li><a title=""Store Locator"" href=""#""><span>Store Locator</span></a></li>
                        <li><a title=""Checkout"" href=""checkout.html""><span>Checkout</span></a></li>
                ");
            WriteLiteral(@"        <li>
                            <div class=""dropdown"">
                                <a class=""current-open"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"" href=""#""><span>My Account</span> <i class=""fa fa-angle-down""></i></a>
                                <ul class=""dropdown-menu"" role=""menu"">
                                    <li><a href=""account_page.html"">Account</a></li>
                                    <li><a href=""wishlist.html"">Wishlist</a></li>
                                    <li><a href=""orders_list.html"">Order Tracking</a></li>
                                    <li><a href=""/Home/About"">About us</a></li>
                                    <li class=""divider""></li>
                                    <li><a href=""/KhachHang/Login"">Log In</a></li>
                                    <li><a href=""/KhachHang/Register"">Register</a></li>
                                </ul>
                            </div>
                        </li>
         ");
            WriteLiteral(@"               <li><a title=""login"" href=""/KhachHang/Login""><span>Login</span></a></li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <!-- header inner -->
    <div class=""header-inner"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-sm-3 col-xs-12 jtv-logo-block"">

                    <!-- Header Logo -->
                    <div class=""logo""><a title=""e-commerce"" href=""index.html"">");
            EndContext();
            BeginContext(2891, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "af84ee9e1eced6d2621e93fbfb66b05be65f41678726", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2952, 269, true);
            WriteLiteral(@"</a> </div>
                </div>
                <div class=""col-xs-12 col-sm-5 col-md-6 jtv-top-search"">

                    <!-- Search -->

                    <div class=""top-search"">
                        <div id=""search"">
                            ");
            EndContext();
            BeginContext(3221, 1488, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af84ee9e1eced6d2621e93fbfb66b05be65f416710339", async() => {
                BeginContext(3227, 208, true);
                WriteLiteral("\r\n                                <div class=\"input-group\">\r\n                                    <select class=\"cate-dropdown hidden-xs hidden-sm\" name=\"category_id\">\r\n                                        ");
                EndContext();
                BeginContext(3435, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af84ee9e1eced6d2621e93fbfb66b05be65f416710941", async() => {
                    BeginContext(3443, 14, true);
                    WriteLiteral("All Categories");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3466, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(3508, 22, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af84ee9e1eced6d2621e93fbfb66b05be65f416712247", async() => {
                    BeginContext(3516, 5, true);
                    WriteLiteral("women");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3530, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(3572, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af84ee9e1eced6d2621e93fbfb66b05be65f416713543", async() => {
                    BeginContext(3580, 24, true);
                    WriteLiteral("&nbsp;&nbsp;&nbsp;Chair ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3613, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(3655, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af84ee9e1eced6d2621e93fbfb66b05be65f416714859", async() => {
                    BeginContext(3663, 28, true);
                    WriteLiteral("&nbsp;&nbsp;&nbsp;Decoration");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3700, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(3742, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af84ee9e1eced6d2621e93fbfb66b05be65f416716179", async() => {
                    BeginContext(3750, 22, true);
                    WriteLiteral("&nbsp;&nbsp;&nbsp;Lamp");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3781, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(3823, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af84ee9e1eced6d2621e93fbfb66b05be65f416717493", async() => {
                    BeginContext(3831, 27, true);
                    WriteLiteral("&nbsp;&nbsp;&nbsp;Handbags ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3867, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(3909, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af84ee9e1eced6d2621e93fbfb66b05be65f416718812", async() => {
                    BeginContext(3917, 24, true);
                    WriteLiteral("&nbsp;&nbsp;&nbsp;Sofas ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3950, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(3992, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af84ee9e1eced6d2621e93fbfb66b05be65f416720128", async() => {
                    BeginContext(4000, 28, true);
                    WriteLiteral("&nbsp;&nbsp;&nbsp;Essential ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4037, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(4079, 20, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af84ee9e1eced6d2621e93fbfb66b05be65f416721448", async() => {
                    BeginContext(4087, 3, true);
                    WriteLiteral("Men");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4099, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(4141, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af84ee9e1eced6d2621e93fbfb66b05be65f416722742", async() => {
                    BeginContext(4149, 11, true);
                    WriteLiteral("Electronics");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4169, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(4211, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af84ee9e1eced6d2621e93fbfb66b05be65f416724045", async() => {
                    BeginContext(4219, 26, true);
                    WriteLiteral("&nbsp;&nbsp;&nbsp;Mobiles ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4254, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(4296, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af84ee9e1eced6d2621e93fbfb66b05be65f416725363", async() => {
                    BeginContext(4304, 36, true);
                    WriteLiteral("&nbsp;&nbsp;&nbsp;Music &amp; Audio ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4349, 353, true);
                WriteLiteral(@"
                                    </select>
                                    <input type=""text"" class=""form-control"" placeholder=""Bạn tìm gì..."" name=""search"">
                                    <button class=""btn-search"" type=""button""><i class=""fa fa-search""></i></button>
                                </div>
                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4709, 646, true);
            WriteLiteral(@"
                        </div>
                    </div>

                    <!-- End Search -->

                </div>
                <div class=""col-xs-12 col-sm-4 col-md-3 top-cart"">
                    
                    <!-- top cart -->
                    <div class=""top-cart-contain"">
                        <div class=""mini-cart"">
                            <div data-toggle=""dropdown"" data-hover=""dropdown"" class=""basket dropdown-toggle"">
                                <a href=""/Cart"">
                                    <div class=""cart-icon""><i class=""icon-basket-loaded icons""></i><span class=""cart-total"">");
            EndContext();
            BeginContext(5356, 5, false);
#line 101 "C:\Users\phant\OneDrive\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\_MyHeader.cshtml"
                                                                                                                       Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(5361, 501, true);
            WriteLiteral(@"</span></div>
                                    <div class=""shoppingcart-inner hidden-xs""><span class=""cart-title"">Giỏ hàng</span> </div>
                                </a>
                            </div>
                            <div>
                                <div class=""top-cart-content"">
                                    <div class=""block-subtitle hidden"">Recently added items</div>
                                    <ul id=""cart-sidebar"" class=""mini-products-list"">
");
            EndContext();
#line 109 "C:\Users\phant\OneDrive\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\_MyHeader.cshtml"
                                         if (cartItems != null)
                                        {
                                            

#line default
#line hidden
#line 111 "C:\Users\phant\OneDrive\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\_MyHeader.cshtml"
                                             foreach (var product in cartItems.ToList())
                                            {


#line default
#line hidden
            BeginContext(6109, 201, true);
            WriteLiteral("                                                <li class=\"item odd\">\r\n                                                    <a href=\"shopping_cart.html\" title=\"Product title here\" class=\"product-image\">");
            EndContext();
            BeginContext(6310, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "af84ee9e1eced6d2621e93fbfb66b05be65f416730556", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6320, "~/Hinh/HangHoa/", 6320, 15, true);
#line 115 "C:\Users\phant\OneDrive\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\_MyHeader.cshtml"
AddHtmlAttributeValue("", 6335, product.Product.Images, 6335, 23, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6391, 457, true);
            WriteLiteral(@"</a>
                                                    <div class=""product-details"">
                                                        <a href=""#"" title=""Remove This Item"" class=""remove-cart""><i class=""pe-7s-trash""></i></a>
                                                        <p class=""product-name""><a href=""shopping_cart.html"">Lorem ipsum dolor sit amet Consectetur</a> </p>
                                                        <strong>");
            EndContext();
            BeginContext(6849, 16, false);
#line 119 "C:\Users\phant\OneDrive\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\_MyHeader.cshtml"
                                                           Write(product.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(6865, 32, true);
            WriteLiteral("</strong> x <span class=\"price\">");
            EndContext();
            BeginContext(6898, 21, false);
#line 119 "C:\Users\phant\OneDrive\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\_MyHeader.cshtml"
                                                                                                            Write(product.Product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(6919, 124, true);
            WriteLiteral("</span>\r\n                                                    </div>\r\n                                                </li>\r\n");
            EndContext();
#line 122 "C:\Users\phant\OneDrive\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\_MyHeader.cshtml"
                                            }

#line default
#line hidden
#line 122 "C:\Users\phant\OneDrive\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\_MyHeader.cshtml"
                                             
                                        }

#line default
#line hidden
            BeginContext(7133, 135, true);
            WriteLiteral("                                    </ul>\r\n                                    <div class=\"top-subtotal\">Subtotal: <span class=\"price\">");
            EndContext();
            BeginContext(7269, 8, false);
#line 125 "C:\Users\phant\OneDrive\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\_MyHeader.cshtml"
                                                                                       Write(sumPrice);

#line default
#line hidden
            EndContext();
            BeginContext(7277, 714, true);
            WriteLiteral(@"</span></div>
                                    <div class=""actions"">
                                        <button class=""btn-checkout"" type=""button"" onClick=""location.href='/thanh-toan/paypal'""><i class=""fa fa-check""></i><span>Checkout</span></button>
                                        <button class=""view-cart"" type=""button"" onClick=""location.href='shopping_cart.html'""><i class=""fa fa-shopping-cart""></i><span>View Cart</span></button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
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
