#pragma checksum "A:\Microsoft Visual Studio\SOURCE\repository\CoffeeShop2EFCORELab\CoffeeShop2EFCORELab\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d87a1951a3a01256386d9a2329cd70fd051b47a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d87a1951a3a01256386d9a2329cd70fd051b47a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ba5001ab9e60c913d6fbb53512c19bf586712f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "A:\Microsoft Visual Studio\SOURCE\repository\CoffeeShop2EFCORELab\CoffeeShop2EFCORELab\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h2>");
#nullable restore
#line 6 "A:\Microsoft Visual Studio\SOURCE\repository\CoffeeShop2EFCORELab\CoffeeShop2EFCORELab\Views\Home\Index.cshtml"
   Write(Html.ActionLink("Registration", "Registration", "Home", null, new { @class = "page-scroll" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" will bring you to customer registration</h2>\r\n</div>\r\n\r\n");
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
