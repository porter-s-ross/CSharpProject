#pragma checksum "/Users/o2.os/Dev/Projects/Coding_Dojo_Assignments/cSharp/Project/CSharpProject/Views/Admin/AdminProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "562dfb890dc69e5bf98c5df9ae2ef85a851193be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminProducts), @"mvc.1.0.view", @"/Views/Admin/AdminProducts.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"562dfb890dc69e5bf98c5df9ae2ef85a851193be", @"/Views/Admin/AdminProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1d822ae380dac6388ac464769e46b807940c1bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AdminProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline d-flex justify-content-center md-form form-sm mt-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/o2.os/Dev/Projects/Coding_Dojo_Assignments/cSharp/Project/CSharpProject/Views/Admin/AdminProducts.cshtml"
  
    ViewBag.Title = "Home Page";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row d-flex justify-content-between m-5\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "562dfb890dc69e5bf98c5df9ae2ef85a851193be4011", async() => {
                WriteLiteral("\n        <i class=\"fas fa-search\" aria-hidden=\"true\"></i>\n        <input class=\"form-control form-control-sm ml-3 w-75\" type=\"text\" placeholder=\"Search\" aria-label=\"Search\">\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <div class=""btn-group"">
        <a href=""/NewProduct"" class=""btn btn-success"">Add New Product</a>
    </div>
</div>
    <table class=""table m-5"">
        <thead class=""thead-dark"">
            <tr>
                <th>Picture</th>
                <th>ID</th>
                <th>Category</th>
                <th>Artist</th>
                <th>Title</th>
                <th>Inventory Count</th>
                <th>Quantity Sold</th>
                <th>Action</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 29 "/Users/o2.os/Dev/Projects/Coding_Dojo_Assignments/cSharp/Project/CSharpProject/Views/Admin/AdminProducts.cshtml"
              
                foreach(Product p in @ViewBag.AllProducts)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"table-light\">\n                        <th scope=\"row\"><img width=\"50px\"");
            BeginWriteAttribute("src", " src=\"", 1127, "\"", 1144, 1);
#nullable restore
#line 33 "/Users/o2.os/Dev/Projects/Coding_Dojo_Assignments/cSharp/Project/CSharpProject/Views/Admin/AdminProducts.cshtml"
WriteAttributeValue("", 1133, p.ImageUrl, 1133, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1145, "\"", 1169, 3);
#nullable restore
#line 33 "/Users/o2.os/Dev/Projects/Coding_Dojo_Assignments/cSharp/Project/CSharpProject/Views/Admin/AdminProducts.cshtml"
WriteAttributeValue("", 1151, p.Artist, 1151, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1160, "-", 1160, 1, true);
#nullable restore
#line 33 "/Users/o2.os/Dev/Projects/Coding_Dojo_Assignments/cSharp/Project/CSharpProject/Views/Admin/AdminProducts.cshtml"
WriteAttributeValue("", 1161, p.Title, 1161, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></th>\n                        <td>");
#nullable restore
#line 34 "/Users/o2.os/Dev/Projects/Coding_Dojo_Assignments/cSharp/Project/CSharpProject/Views/Admin/AdminProducts.cshtml"
                       Write(p.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 35 "/Users/o2.os/Dev/Projects/Coding_Dojo_Assignments/cSharp/Project/CSharpProject/Views/Admin/AdminProducts.cshtml"
                       Write(p.MediaType.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 36 "/Users/o2.os/Dev/Projects/Coding_Dojo_Assignments/cSharp/Project/CSharpProject/Views/Admin/AdminProducts.cshtml"
                       Write(p.Artist);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 37 "/Users/o2.os/Dev/Projects/Coding_Dojo_Assignments/cSharp/Project/CSharpProject/Views/Admin/AdminProducts.cshtml"
                       Write(p.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 38 "/Users/o2.os/Dev/Projects/Coding_Dojo_Assignments/cSharp/Project/CSharpProject/Views/Admin/AdminProducts.cshtml"
                       Write(p.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>0</td>\n                        <td>Action</td>\n                    </tr>\n");
#nullable restore
#line 42 "/Users/o2.os/Dev/Projects/Coding_Dojo_Assignments/cSharp/Project/CSharpProject/Views/Admin/AdminProducts.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n");
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
