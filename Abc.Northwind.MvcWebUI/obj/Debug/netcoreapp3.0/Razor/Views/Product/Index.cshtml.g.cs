#pragma checksum "C:\Users\furka\source\repos\Abc\Abc.Northwind.MvcWebUI\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ba2cfa1fc86fe7f0833f2183d403d0abb06affb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(AspNetCore.Views_Product_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ba2cfa1fc86fe7f0833f2183d403d0abb06affb", @"/Views/Product/Index.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Abc.Northwind.MvcWebUI.Models.ProductListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\furka\source\repos\Abc\Abc.Northwind.MvcWebUI\Views\Product\Index.cshtml"
  
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
            BeginContext(108, 189, true);
            WriteLiteral("\r\n\r\n    <div>\r\n        <table>\r\n            <tr>\r\n                <td> Product Name</td>\r\n                <td> Unit Price</td>\r\n                <td> units In Stock</td>\r\n            </tr>\r\n");
            EndContext();
#line 15 "C:\Users\furka\source\repos\Abc\Abc.Northwind.MvcWebUI\Views\Product\Index.cshtml"
             foreach (var product in Model.Products)
            {

#line default
#line hidden
            BeginContext(366, 44, true);
            WriteLiteral("                <tr>\r\n                  <td>");
            EndContext();
            BeginContext(411, 19, false);
#line 18 "C:\Users\furka\source\repos\Abc\Abc.Northwind.MvcWebUI\Views\Product\Index.cshtml"
                 Write(product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(430, 29, true);
            WriteLiteral("</td>\r\n                  <td>");
            EndContext();
            BeginContext(460, 17, false);
#line 19 "C:\Users\furka\source\repos\Abc\Abc.Northwind.MvcWebUI\Views\Product\Index.cshtml"
                 Write(product.UnitPrice);

#line default
#line hidden
            EndContext();
            BeginContext(477, 29, true);
            WriteLiteral("</td>\r\n                  <td>");
            EndContext();
            BeginContext(507, 20, false);
#line 20 "C:\Users\furka\source\repos\Abc\Abc.Northwind.MvcWebUI\Views\Product\Index.cshtml"
                 Write(product.UnitsInStock);

#line default
#line hidden
            EndContext();
            BeginContext(527, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 22 "C:\Users\furka\source\repos\Abc\Abc.Northwind.MvcWebUI\Views\Product\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(572, 30, true);
            WriteLiteral("        </table>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Abc.Northwind.MvcWebUI.Models.ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
