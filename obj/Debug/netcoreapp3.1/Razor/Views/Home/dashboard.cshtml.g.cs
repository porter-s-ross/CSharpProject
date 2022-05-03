#pragma checksum "/Users/o2.os/Dropbox/Dev/Coding_Dojo/dojo_assignments/csharp/Project/CSharpProject/Views/Home/dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd1c58315d8b5c8810c3b1da5b370eb9532c0ecb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_dashboard), @"mvc.1.0.view", @"/Views/Home/dashboard.cshtml")]
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
#line 1 "/Users/o2.os/Dropbox/Dev/Coding_Dojo/dojo_assignments/csharp/Project/CSharpProject/Views/_ViewImports.cshtml"
using CSharpProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/o2.os/Dropbox/Dev/Coding_Dojo/dojo_assignments/csharp/Project/CSharpProject/Views/_ViewImports.cshtml"
using CSharpProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd1c58315d8b5c8810c3b1da5b370eb9532c0ecb", @"/Views/Home/dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1d822ae380dac6388ac464769e46b807940c1bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/o2.os/Dropbox/Dev/Coding_Dojo/dojo_assignments/csharp/Project/CSharpProject/Views/Home/dashboard.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container p-3\">\n");
            WriteLiteral("    <div class=\"text-center\">\n        <h1 class=\"m-3\">All Products</h1>\n    </div>\n");
            WriteLiteral("    <div class=\"d-flex justify-content-center flex-wrap\">\n");
#nullable restore
#line 12 "/Users/o2.os/Dropbox/Dev/Coding_Dojo/dojo_assignments/csharp/Project/CSharpProject/Views/Home/dashboard.cshtml"
          
            foreach(Product p in ViewBag.AllProducts) 

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/o2.os/Dropbox/Dev/Coding_Dojo/dojo_assignments/csharp/Project/CSharpProject/Views/Home/dashboard.cshtml"
                                                                                                                        
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""card-group m-2"">
                    <div class=""card d-flex justify-content-center"" style=""width: 400px; border: none"">
                        <div class=""card-body mx-auto d-flex flex-column align-items-center"">
                            <img height=""300px"" width=""300px""");
            BeginWriteAttribute("src", " src=\"", 707, "\"", 724, 1);
#nullable restore
#line 18 "/Users/o2.os/Dropbox/Dev/Coding_Dojo/dojo_assignments/csharp/Project/CSharpProject/Views/Home/dashboard.cshtml"
WriteAttributeValue("", 713, p.ImageUrl, 713, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 725, "\"", 749, 3);
#nullable restore
#line 18 "/Users/o2.os/Dropbox/Dev/Coding_Dojo/dojo_assignments/csharp/Project/CSharpProject/Views/Home/dashboard.cshtml"
WriteAttributeValue("", 731, p.Artist, 731, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 740, "-", 740, 1, true);
#nullable restore
#line 18 "/Users/o2.os/Dropbox/Dev/Coding_Dojo/dojo_assignments/csharp/Project/CSharpProject/Views/Home/dashboard.cshtml"
WriteAttributeValue("", 741, p.Title, 741, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                            <div>\n                                <h4 class=\"card-title\"><a");
            BeginWriteAttribute("href", " href=\"", 843, "\"", 868, 3);
            WriteAttributeValue("", 850, "/", 850, 1, true);
#nullable restore
#line 20 "/Users/o2.os/Dropbox/Dev/Coding_Dojo/dojo_assignments/csharp/Project/CSharpProject/Views/Home/dashboard.cshtml"
WriteAttributeValue("", 851, p.ProductId, 851, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 863, "/info", 863, 5, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "/Users/o2.os/Dropbox/Dev/Coding_Dojo/dojo_assignments/csharp/Project/CSharpProject/Views/Home/dashboard.cshtml"
                                                                               Write(p.Artist);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 20 "/Users/o2.os/Dropbox/Dev/Coding_Dojo/dojo_assignments/csharp/Project/CSharpProject/Views/Home/dashboard.cshtml"
                                                                                           Write(p.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a> </h4>\n                                <p class=\"card-text\">");
#nullable restore
#line 21 "/Users/o2.os/Dropbox/Dev/Coding_Dojo/dojo_assignments/csharp/Project/CSharpProject/Views/Home/dashboard.cshtml"
                                                Write(p.Label);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                <p class=\"card-text\">$");
#nullable restore
#line 22 "/Users/o2.os/Dropbox/Dev/Coding_Dojo/dojo_assignments/csharp/Project/CSharpProject/Views/Home/dashboard.cshtml"
                                                 Write(p.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            </div>\n                        </div>\n                    </div>\n                </div>\n");
#nullable restore
#line 27 "/Users/o2.os/Dropbox/Dev/Coding_Dojo/dojo_assignments/csharp/Project/CSharpProject/Views/Home/dashboard.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>");
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
