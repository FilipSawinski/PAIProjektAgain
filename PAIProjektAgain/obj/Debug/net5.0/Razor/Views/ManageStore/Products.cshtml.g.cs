#pragma checksum "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\ManageStore\Products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ca2eadf6d515919f236d270f77395ebdff88173"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManageStore_Products), @"mvc.1.0.view", @"/Views/ManageStore/Products.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ca2eadf6d515919f236d270f77395ebdff88173", @"/Views/ManageStore/Products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14918f3080af8fa3f3b423d8ea088080d8383ead", @"/Views/_ViewImports.cshtml")]
    public class Views_ManageStore_Products : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PAIProjektAgain.Models.ProductViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ca2eadf6d515919f236d270f77395ebdff881733484", async() => {
                WriteLiteral("Dodaj nowy produkt");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<table class=""table table-hover"">
    <thead>
        <tr>
            <th scope=""col""><b>Nazwa</b></th>
            <th scope=""col""><b>Kategoria</b></th>
            <th scope=""col""><b>Ilość na stanie</b></th>
            <th scope=""col""><b>Cena</b></th>
            <th scope=""col""><b>Zniżka</b></th>
            <th scope=""col""><b>Akcje</b></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 15 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\ManageStore\Products.cshtml"
         foreach (var i in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 19 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\ManageStore\Products.cshtml"
               Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 22 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\ManageStore\Products.cshtml"
               Write(i.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 25 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\ManageStore\Products.cshtml"
               Write(i.AvailableNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 28 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\ManageStore\Products.cshtml"
               Write(i.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" zł (");
#nullable restore
#line 28 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\ManageStore\Products.cshtml"
                            Write(i.PriceAfterDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" zł)\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 31 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\ManageStore\Products.cshtml"
               Write(i.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("%\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 34 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\ManageStore\Products.cshtml"
               Write(Html.ActionLink("Edytuj", "EditProduct", new { id = i.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 35 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\ManageStore\Products.cshtml"
               Write(Html.ActionLink("Usuń", "DeleteProduct", new { id = i.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 38 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\ManageStore\Products.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PAIProjektAgain.Models.ProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
