#pragma checksum "/Users/o2.os/Dev/Projects/Coding_Dojo_Assignments/cSharp/Project/CSharpProject/Views/Home/ProductInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6ce03787e205090a4f632ca10e88a4813a42486"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProductInfo), @"mvc.1.0.view", @"/Views/Home/ProductInfo.cshtml")]
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
#line 1 "/Users/o2.os/Dev/Projects/Coding_Dojo_Assignments/cSharp/Project/CSharpProject/Views/_ViewImports.cshtml"
using CSharpProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/o2.os/Dev/Projects/Coding_Dojo_Assignments/cSharp/Project/CSharpProject/Views/_ViewImports.cshtml"
using CSharpProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6ce03787e205090a4f632ca10e88a4813a42486", @"/Views/Home/ProductInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1d822ae380dac6388ac464769e46b807940c1bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ProductInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/o2.os/Dev/Projects/Coding_Dojo_Assignments/cSharp/Project/CSharpProject/Views/Home/ProductInfo.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container\">\n    <div class=\"row mt-5\">\n        <div class=\"col\">\n            <img");
            BeginWriteAttribute("src", " src=\"", 136, "\"", 171, 1);
#nullable restore
#line 8 "/Users/o2.os/Dev/Projects/Coding_Dojo_Assignments/cSharp/Project/CSharpProject/Views/Home/ProductInfo.cshtml"
WriteAttributeValue("", 142, ViewBag.ProductInfo.ImageUrl, 142, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 172, "\"", 248, 6);
            WriteAttributeValue("", 178, "Album", 178, 5, true);
            WriteAttributeValue(" ", 183, "art", 184, 4, true);
            WriteAttributeValue(" ", 187, "for", 188, 4, true);
#nullable restore
#line 8 "/Users/o2.os/Dev/Projects/Coding_Dojo_Assignments/cSharp/Project/CSharpProject/Views/Home/ProductInfo.cshtml"
WriteAttributeValue(" ", 191, ViewBag.ProductInfo.Artist, 192, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 219, "-", 220, 2, true);
#nullable restore
#line 8 "/Users/o2.os/Dev/Projects/Coding_Dojo_Assignments/cSharp/Project/CSharpProject/Views/Home/ProductInfo.cshtml"
WriteAttributeValue(" ", 221, ViewBag.ProductInfo.Title, 222, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        </div>\n        <div class=\"col ProductInfoText\">\n            <div style=\"border: 1px black solid;border-radius: 5px;padding: 25px; margin-bottom: 50px\">\n                <h1 style=\"font-style: italic; font-weight: bold\">");
#nullable restore
#line 12 "/Users/o2.os/Dev/Projects/Coding_Dojo_Assignments/cSharp/Project/CSharpProject/Views/Home/ProductInfo.cshtml"
                                                             Write(ViewBag.ProductInfo.Artist);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 12 "/Users/o2.os/Dev/Projects/Coding_Dojo_Assignments/cSharp/Project/CSharpProject/Views/Home/ProductInfo.cshtml"
                                                                                           Write(ViewBag.ProductInfo.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                <h3>");
#nullable restore
#line 13 "/Users/o2.os/Dev/Projects/Coding_Dojo_Assignments/cSharp/Project/CSharpProject/Views/Home/ProductInfo.cshtml"
               Write(ViewBag.ProductInfo.Label);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                <h4>$");
#nullable restore
#line 14 "/Users/o2.os/Dev/Projects/Coding_Dojo_Assignments/cSharp/Project/CSharpProject/Views/Home/ProductInfo.cshtml"
                Write(ViewBag.ProductInfo.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                <p>In Stock: ");
#nullable restore
#line 15 "/Users/o2.os/Dev/Projects/Coding_Dojo_Assignments/cSharp/Project/CSharpProject/Views/Home/ProductInfo.cshtml"
                        Write(ViewBag.ProductInfo.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <a");
            BeginWriteAttribute("href", " href=\"", 726, "\"", 774, 2);
            WriteAttributeValue("", 733, "/AddToCart/", 733, 11, true);
#nullable restore
#line 16 "/Users/o2.os/Dev/Projects/Coding_Dojo_Assignments/cSharp/Project/CSharpProject/Views/Home/ProductInfo.cshtml"
WriteAttributeValue("", 744, ViewBag.ProductInfo.ProductId, 744, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Add To Cart</a>\n            </div>\n            <p>Label: ");
#nullable restore
#line 18 "/Users/o2.os/Dev/Projects/Coding_Dojo_Assignments/cSharp/Project/CSharpProject/Views/Home/ProductInfo.cshtml"
                 Write(ViewBag.ProductInfo.Label);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 18 "/Users/o2.os/Dev/Projects/Coding_Dojo_Assignments/cSharp/Project/CSharpProject/Views/Home/ProductInfo.cshtml"
                                              Write(ViewBag.ProductInfo.CatalogNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p>Released: </p>\n            <p>Genre: ");
#nullable restore
#line 20 "/Users/o2.os/Dev/Projects/Coding_Dojo_Assignments/cSharp/Project/CSharpProject/Views/Home/ProductInfo.cshtml"
                 Write(ViewBag.ProductInfo.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p>Style: ");
#nullable restore
#line 21 "/Users/o2.os/Dev/Projects/Coding_Dojo_Assignments/cSharp/Project/CSharpProject/Views/Home/ProductInfo.cshtml"
                 Write(ViewBag.ProductInfo.Style);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p>Format: ");
#nullable restore
#line 22 "/Users/o2.os/Dev/Projects/Coding_Dojo_Assignments/cSharp/Project/CSharpProject/Views/Home/ProductInfo.cshtml"
                  Write(ViewBag.ProductInfo.Format);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p>Description: ");
#nullable restore
#line 23 "/Users/o2.os/Dev/Projects/Coding_Dojo_Assignments/cSharp/Project/CSharpProject/Views/Home/ProductInfo.cshtml"
                       Write(ViewBag.ProductInfo.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        </div>\n    </div>\n");
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
