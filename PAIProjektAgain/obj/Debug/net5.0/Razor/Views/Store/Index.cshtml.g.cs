#pragma checksum "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\Store\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ebfc581c3b9e3878462988dc9560946d4a2d998"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_Index), @"mvc.1.0.view", @"/Views/Store/Index.cshtml")]
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
#line 1 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\_ViewImports.cshtml"
using PAIProjektAgain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\_ViewImports.cshtml"
using PAIProjektAgain.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ebfc581c3b9e3878462988dc9560946d4a2d998", @"/Views/Store/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14918f3080af8fa3f3b423d8ea088080d8383ead", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PAIProjektAgain.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/imgs/misc/no-image.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Store", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Buy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Produkty</h1>\r\n<div class=\"prod-container\">\r\n");
#nullable restore
#line 5 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\Store\Index.cshtml"
     foreach (var m in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ebfc581c3b9e3878462988dc9560946d4a2d9984589", async() => {
                WriteLiteral("\r\n            <div class=\"product-card\">\r\n                <div class=\"image-prod\">\r\n                    <div class=\"img-wrap\">\r\n");
#nullable restore
#line 11 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\Store\Index.cshtml"
                         if (string.IsNullOrEmpty(m.photoPath))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1ebfc581c3b9e3878462988dc9560946d4a2d9985313", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 14 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\Store\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1ebfc581c3b9e3878462988dc9560946d4a2d9986722", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 623, "~/imgs/products/", 623, 16, true);
#nullable restore
#line 17 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\Store\Index.cshtml"
AddHtmlAttributeValue("", 639, m.photoPath, 639, 12, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 18 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\Store\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n                </div>\r\n                <div class=\"prod-header\">\r\n                    <h5>");
#nullable restore
#line 22 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\Store\Index.cshtml"
                   Write(m.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                    <h6>");
#nullable restore
#line 23 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\Store\Index.cshtml"
                   Write(m.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                </div>\r\n");
#nullable restore
#line 25 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\Store\Index.cshtml"
                 if (m.Discount > 0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"price-prod\">\r\n                        <p class=\"discounted-price\">");
#nullable restore
#line 28 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\Store\Index.cshtml"
                                                Write(m.Price-(((float)m.Discount/100)*m.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral(" zł</p>\r\n                        <p class=\"crossed-price\">");
#nullable restore
#line 29 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\Store\Index.cshtml"
                                            Write(m.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" zł</p>\r\n                        <p class=\"discount\">-");
#nullable restore
#line 30 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\Store\Index.cshtml"
                                        Write(m.Discount);

#line default
#line hidden
#nullable disable
                WriteLiteral("%</p>\r\n                    </div>\r\n");
#nullable restore
#line 32 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\Store\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"price-prod\">\r\n                        <p class=\"price\">");
#nullable restore
#line 36 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\Store\Index.cshtml"
                                    Write(m.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" zł</p>\r\n                    </div>\r\n");
#nullable restore
#line 38 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\Store\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 7 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\Store\Index.cshtml"
                                                     WriteLiteral(m.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 41 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\Store\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PAIProjektAgain.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
