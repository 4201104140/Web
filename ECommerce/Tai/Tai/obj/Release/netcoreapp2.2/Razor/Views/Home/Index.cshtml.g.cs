#pragma checksum "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cd3e49e1002dbeb0590ec3423ce770bbe7e8e84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 3 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\_ViewImports.cshtml"
using Tai.Models.CartModels;

#line default
#line hidden
#line 4 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\_ViewImports.cshtml"
using Tai.DataModels;

#line default
#line hidden
#line 2 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Home\Index.cshtml"
using Tai.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cd3e49e1002dbeb0590ec3423ce770bbe7e8e84", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f30cbd38c6f989b7773fdb519eef7f8d551d4ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tai.Models.HomeModels.IndexModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Trang chủ";

#line default
#line hidden
            BeginContext(105, 241, true);
            WriteLiteral("\r\n<!-- letest product section -->\r\n<section class=\"top-letest-product-section\">\r\n    <div class=\"container\">\r\n        <div class=\"section-title\">\r\n            <h2>Sale</h2>\r\n        </div>\r\n        <div class=\"product-slider owl-carousel\">\r\n");
            EndContext();
#line 14 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Home\Index.cshtml"
             foreach (var item in Model.ProductSales)
            {
                

#line default
#line hidden
            BeginContext(433, 57, false);
#line 16 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Home\Index.cshtml"
           Write(await Component.InvokeAsync("Item",new { product = item}));

#line default
#line hidden
            EndContext();
#line 16 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Home\Index.cshtml"
                                                                          
            }

#line default
#line hidden
            BeginContext(507, 326, true);
            WriteLiteral(@"        </div>
    </div>
</section>
<!-- letest product section end -->
<!-- Product filter section -->
<section class=""product-filter-section"">
    <div class=""container"">
        <div class=""section-title"">
            <h2>BROWSE TOP SELLING PRODUCTS</h2>
        </div>
        <ul class=""product-filter-menu"">
");
            EndContext();
#line 29 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Home\Index.cshtml"
             foreach (var item in Model.GetCategories)
            {

#line default
#line hidden
            BeginContext(904, 22, true);
            WriteLiteral("                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 926, "\"", 978, 2);
            WriteAttributeValue("", 933, "/trang-chu/", 933, 11, true);
#line 31 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Home\Index.cshtml"
WriteAttributeValue("", 944, item.CategoryName.ToUrlFriendly(), 944, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(979, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(981, 17, false);
#line 31 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Home\Index.cshtml"
                                                                       Write(item.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(998, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 32 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1024, 42, true);
            WriteLiteral("        </ul>\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 35 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Home\Index.cshtml"
             foreach (var item in Model.ProductTopSells)
            {

#line default
#line hidden
            BeginContext(1139, 69, true);
            WriteLiteral("                <div class=\"col-lg-3 col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(1209, 59, false);
#line 38 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Home\Index.cshtml"
               Write(await Component.InvokeAsync("Item", new { product = item }));

#line default
#line hidden
            EndContext();
            BeginContext(1268, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 40 "C:\Users\Hello\Desktop\Web\ECommerce\Tai\Tai\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1309, 16, true);
            WriteLiteral("        </div>\r\n");
            EndContext();
            BeginContext(1458, 61, true);
            WriteLiteral("    </div>\r\n</section>\r\n<!-- Product filter section end -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tai.Models.HomeModels.IndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
