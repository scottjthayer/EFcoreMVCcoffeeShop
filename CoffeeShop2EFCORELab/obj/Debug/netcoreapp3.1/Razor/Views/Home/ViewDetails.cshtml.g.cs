#pragma checksum "A:\Microsoft Visual Studio\SOURCE\repository\CoffeeShop2EFCORELab\CoffeeShop2EFCORELab\Views\Home\ViewDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2aad02ed31d258cfd726179ed45d2b48c9e8d152"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewDetails), @"mvc.1.0.view", @"/Views/Home/ViewDetails.cshtml")]
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
#nullable restore
#line 1 "A:\Microsoft Visual Studio\SOURCE\repository\CoffeeShop2EFCORELab\CoffeeShop2EFCORELab\Views\_ViewImports.cshtml"
using CoffeeShop2EFCORELab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "A:\Microsoft Visual Studio\SOURCE\repository\CoffeeShop2EFCORELab\CoffeeShop2EFCORELab\Views\_ViewImports.cshtml"
using CoffeeShop2EFCORELab.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2aad02ed31d258cfd726179ed45d2b48c9e8d152", @"/Views/Home/ViewDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ba5001ab9e60c913d6fbb53512c19bf586712f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Customer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3>Full Name:&#160;");
#nullable restore
#line 8 "A:\Microsoft Visual Studio\SOURCE\repository\CoffeeShop2EFCORELab\CoffeeShop2EFCORELab\Views\Home\ViewDetails.cshtml"
               Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 8 "A:\Microsoft Visual Studio\SOURCE\repository\CoffeeShop2EFCORELab\CoffeeShop2EFCORELab\Views\Home\ViewDetails.cshtml"
                                Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<p>CustomerID:&#160;");
#nullable restore
#line 9 "A:\Microsoft Visual Studio\SOURCE\repository\CoffeeShop2EFCORELab\CoffeeShop2EFCORELab\Views\Home\ViewDetails.cshtml"
               Write(Model.CustomerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Email:&#160;");
#nullable restore
#line 10 "A:\Microsoft Visual Studio\SOURCE\repository\CoffeeShop2EFCORELab\CoffeeShop2EFCORELab\Views\Home\ViewDetails.cshtml"
          Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n<p>Password:&#160;");
#nullable restore
#line 11 "A:\Microsoft Visual Studio\SOURCE\repository\CoffeeShop2EFCORELab\CoffeeShop2EFCORELab\Views\Home\ViewDetails.cshtml"
             Write(Model.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Homestore:&#160;");
#nullable restore
#line 12 "A:\Microsoft Visual Studio\SOURCE\repository\CoffeeShop2EFCORELab\CoffeeShop2EFCORELab\Views\Home\ViewDetails.cshtml"
              Write(Model.HomeStore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Senior Discount:&#160;");
#nullable restore
#line 13 "A:\Microsoft Visual Studio\SOURCE\repository\CoffeeShop2EFCORELab\CoffeeShop2EFCORELab\Views\Home\ViewDetails.cshtml"
                    Write(Model.SeniorDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
