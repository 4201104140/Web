#pragma checksum "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\Components\HorizontalMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8dd916207b97aaa0943e2c1b41dbc693e05bebb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_HorizontalMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/HorizontalMenu/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/HorizontalMenu/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_HorizontalMenu_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8dd916207b97aaa0943e2c1b41dbc693e05bebb", @"/Views/Shared/Components/HorizontalMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f9b7745c2e643501d3439bff4cb481f55e89933", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_HorizontalMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Tai.DataModels.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 158, true);
            WriteLiteral("\r\n\r\n<nav class=\"main-navbar\">\r\n    <div class=\"container\">\r\n        <!-- menu -->\r\n        <ul class=\"main-menu\">\r\n            <li><a href=\"/\">Home</a></li>\r\n");
            EndContext();
#line 9 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\Components\HorizontalMenu\Default.cshtml"
             foreach (var category in Model) {
                if (category.CategoryParentId == null)
                {

#line default
#line hidden
            BeginContext(326, 62, true);
            WriteLiteral("                    <li>\r\n                        <a href=\"#\">");
            EndContext();
            BeginContext(389, 21, false);
#line 13 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\Components\HorizontalMenu\Default.cshtml"
                               Write(category.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(410, 53, true);
            WriteLiteral("</a>\r\n                        <ul class=\"sub-menu\">\r\n");
            EndContext();
#line 15 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\Components\HorizontalMenu\Default.cshtml"
                             foreach (var child in category.Categories)
                            {

#line default
#line hidden
            BeginContext(567, 48, true);
            WriteLiteral("                                <li><a href=\"#\">");
            EndContext();
            BeginContext(616, 18, false);
#line 17 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\Components\HorizontalMenu\Default.cshtml"
                                           Write(child.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(634, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 18 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\Components\HorizontalMenu\Default.cshtml"
                            }

#line default
#line hidden
            BeginContext(676, 58, true);
            WriteLiteral("                        </ul>\r\n                    </li>\r\n");
            EndContext();
#line 21 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Shared\Components\HorizontalMenu\Default.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(768, 572, true);
            WriteLiteral(@"            <li>
                <a href=""#"">Pages</a>
                <ul class=""sub-menu"">
                    <li><a href=""./product.html"">Product Page</a></li>
                    <li><a href=""./category.html"">Category Page</a></li>
                    <li><a href=""./cart.html"">Cart Page</a></li>
                    <li><a href=""./checkout.html"">Checkout Page</a></li>
                    <li><a href=""./contact.html"">Contact Page</a></li>
                </ul>
            </li>
            <li><a href=""#"">Blog</a></li>
        </ul>
    </div>
</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Tai.DataModels.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
