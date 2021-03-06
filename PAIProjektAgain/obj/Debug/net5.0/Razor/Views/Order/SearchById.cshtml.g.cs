#pragma checksum "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\Order\SearchById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3716b56921689258a30cf29bc7e93e4dce770e39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_SearchById), @"mvc.1.0.view", @"/Views/Order/SearchById.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3716b56921689258a30cf29bc7e93e4dce770e39", @"/Views/Order/SearchById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14918f3080af8fa3f3b423d8ea088080d8383ead", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_SearchById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PAIProjektAgain.Models.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3>Przegląd zamówienia</h3>\r\n<h4>Numer: ");
#nullable restore
#line 4 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\Order\SearchById.cshtml"
      Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<br />\r\n<h4>Zamawiane produkty:</h4>\r\n");
#nullable restore
#line 7 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\Order\SearchById.cshtml"
 foreach (var p in Model.ProductList)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a>");
#nullable restore
#line 9 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\Order\SearchById.cshtml"
  Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 9 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\Order\SearchById.cshtml"
            Write(p.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" zł</a>\r\n    <br />\r\n");
#nullable restore
#line 11 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\Order\SearchById.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<a>Po uwzględnieniu zniżek dostępnych w czasie wykonania zamówienia, zapłaciłeś łącznie <b>");
#nullable restore
#line 12 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\Order\SearchById.cshtml"
                                                                                      Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" zł</b></a>\r\n<h4 style=\"margin-top: 20px\">Status zamówienia:</h4>\r\n");
#nullable restore
#line 14 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\Order\SearchById.cshtml"
 if (Model.Status == "Ordered")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a>Zamówienie zostało przyjęte</a>\r\n");
#nullable restore
#line 17 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\Order\SearchById.cshtml"
}
else if (Model.Status == "Claimed")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a>Właśnie pracujemy nad twoim zamówieniem w naszym punkcie</a>\r\n");
#nullable restore
#line 21 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\Order\SearchById.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a>Zamówienie zostało wysłane</a>\r\n");
#nullable restore
#line 25 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\Order\SearchById.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 27 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\Order\SearchById.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 30 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\Order\SearchById.cshtml"
Write(Html.ActionLink("Powrót do moich zamówień", "MyOrders"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\Dokumenty\GitHub\PAIProjektCorrect\PAIProjektAgain\PAIProjektAgain\Views\Order\SearchById.cshtml"
                                                            
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PAIProjektAgain.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
