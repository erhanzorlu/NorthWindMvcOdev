#pragma checksum "C:\Users\zorlu\OneDrive\Masaüstü\----\MVC\Yeni klasör\24.01\MVC_Layout\MVC_Layout\Views\Shared\_NavbarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1236f37e043baca0aeb9e8eb1192bd23be9c1541"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__NavbarPartial), @"mvc.1.0.view", @"/Views/Shared/_NavbarPartial.cshtml")]
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
#line 1 "C:\Users\zorlu\OneDrive\Masaüstü\----\MVC\Yeni klasör\24.01\MVC_Layout\MVC_Layout\Views\_ViewImports.cshtml"
using MVC_Layout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zorlu\OneDrive\Masaüstü\----\MVC\Yeni klasör\24.01\MVC_Layout\MVC_Layout\Views\_ViewImports.cshtml"
using MVC_Layout.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1236f37e043baca0aeb9e8eb1192bd23be9c1541", @"/Views/Shared/_NavbarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5fda8892e4c93dcfbb08b441f6a075f1a61d4a6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__NavbarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\zorlu\OneDrive\Masaüstü\----\MVC\Yeni klasör\24.01\MVC_Layout\MVC_Layout\Views\Shared\_NavbarPartial.cshtml"
  
    
    MVC_Layout.Models.Context.DatabaseContext db = new MVC_Layout.Models.Context.DatabaseContext();

     

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<nav class=""navbar navbar-expand-lg navbar-light bg-light"">
    <div class=""container px-4 px-lg-5"">
        <a class=""navbar-brand"" href=""/Home/Index"">Yok Yok Burada !!</a>
        <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation""><span class=""navbar-toggler-icon""></span></button>
        <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
            <ul class=""navbar-nav me-auto mb-2 mb-lg-0 ms-lg-4"">
                <li class=""nav-item""><a class=""nav-link active"" aria-current=""page"" href=""/Home/Index"">Home</a></li>
");
#nullable restore
#line 17 "C:\Users\zorlu\OneDrive\Masaüstü\----\MVC\Yeni klasör\24.01\MVC_Layout\MVC_Layout\Views\Shared\_NavbarPartial.cshtml"
                foreach (var category in db.Categories)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                     <li class=\"nav-item\">\r\n                        <a class=\"nav-link text-dark\"");
            BeginWriteAttribute("href", " href=\"", 1003, "\"", 1040, 2);
            WriteAttributeValue("", 1010, "/Category/Details/", 1010, 18, true);
#nullable restore
#line 20 "C:\Users\zorlu\OneDrive\Masaüstü\----\MVC\Yeni klasör\24.01\MVC_Layout\MVC_Layout\Views\Shared\_NavbarPartial.cshtml"
WriteAttributeValue("", 1028, category.ID, 1028, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "C:\Users\zorlu\OneDrive\Masaüstü\----\MVC\Yeni klasör\24.01\MVC_Layout\MVC_Layout\Views\Shared\_NavbarPartial.cshtml"
                                                                                       Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </li>\r\n");
#nullable restore
#line 22 "C:\Users\zorlu\OneDrive\Masaüstü\----\MVC\Yeni klasör\24.01\MVC_Layout\MVC_Layout\Views\Shared\_NavbarPartial.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <li class=""nav-item"">
                    <a class=""nav-link text-dark"" href=""/User/Index"" style=""padding-left:350px"">Sign in</a>
               
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link text-dark"" href=""/User/Login"" >Login</a>

                </li>
            </ul>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1236f37e043baca0aeb9e8eb1192bd23be9c15416732", async() => {
                WriteLiteral(@"
                <button class=""btn btn-outline-dark"" type=""submit"">
                    <i class=""bi-cart-fill me-1""></i>
                    Cart
                    <span class=""badge bg-dark text-white ms-1 rounded-pill"">0</span>
                </button>
            ");
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
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</nav>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591