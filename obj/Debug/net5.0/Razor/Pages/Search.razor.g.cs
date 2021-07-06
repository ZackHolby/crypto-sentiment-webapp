#pragma checksum "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6c66a78ddf59e7386a106f68645cd2752550e5c"
// <auto-generated/>
#pragma warning disable 1591
namespace crypto_sentiment.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\zackh\Coding\crypto-sentiment-webapp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zackh\Coding\crypto-sentiment-webapp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\zackh\Coding\crypto-sentiment-webapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\zackh\Coding\crypto-sentiment-webapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\zackh\Coding\crypto-sentiment-webapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\zackh\Coding\crypto-sentiment-webapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\zackh\Coding\crypto-sentiment-webapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\zackh\Coding\crypto-sentiment-webapp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\zackh\Coding\crypto-sentiment-webapp\_Imports.razor"
using crypto_sentiment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\zackh\Coding\crypto-sentiment-webapp\_Imports.razor"
using crypto_sentiment.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
using crypto_sentiment.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
using crypto_sentiment.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/crypto/{searchTerm}")]
    public partial class Search : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 19 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
 if (searchList == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"spinner-border text-dark\"></div>");
#nullable restore
#line 22 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
}
else if (cryptoArray.Length == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<h2>Crypto not found...</h2>\r\n    ");
            __builder.AddMarkupContent(2, "<h2>search again!</h2>");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "top-row px-4");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "placeholder", "Ex. Bitcoin, ETH...");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                                             searchTerm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchTerm = __value, searchTerm));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "button");
            __builder.AddAttribute(13, "value", "Search");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                                                          () => SearchForCrypto()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
}
else
{



#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "row");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-md-4 offset-md-4");
            __builder.OpenElement(19, "h1");
            __builder.AddAttribute(20, "style", "text-align: center;");
            __builder.AddContent(21, 
#nullable restore
#line 39 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                                             cryptoArray[0].symbol

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(22, " Chart");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "col-md-3 d-flex justify-content-center");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "dropdown");
#nullable restore
#line 43 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                 if(timeSelect == 15){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "class", "dropbtn");
            __builder.AddContent(30, 
#nullable restore
#line 44 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                                         timeSelect

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(31, " min");
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                }
                else if(timeSelect == 60){

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(32, "<button class=\"dropbtn\">1 hr</button>");
#nullable restore
#line 48 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                }
                else{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(33, "<button class=\"dropbtn\">24 hr</button>");
#nullable restore
#line 51 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "dropdown-content");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                                      () => refreshPage(15)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(38, "15 m");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.OpenElement(40, "button");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                                      () => refreshPage(60)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(42, "1 hr");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                                      () => refreshPage(1440)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(46, "24 hr");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "row");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "col-xl-10 offset-xl-1 col-lg-10 offset-lg-1 col-md-10 offset-md-1 col-sm-12 col-sm-offset-0");
            __builder.OpenComponent<Radzen.Blazor.RadzenChart>(51);
            __builder.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __Blazor.crypto_sentiment.Pages.Search.TypeInference.CreateRadzenLineSeries_0(__builder2, 53, 54, 
#nullable restore
#line 66 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                                         cryptoArray

#line default
#line hidden
#nullable disable
                , 55, "date", 56, 
#nullable restore
#line 66 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                                                                                      searchTerm

#line default
#line hidden
#nullable disable
                , 57, "currPrice", 58, (__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMarkers>(59);
                    __builder3.AddAttribute(60, "MarkerType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.MarkerType>(
#nullable restore
#line 67 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                                               MarkerType.Circle

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                );
#nullable restore
#line 69 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                 if(timeSelect == 15){

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<Radzen.Blazor.RadzenCategoryAxis>(61);
                __builder2.AddAttribute(62, "Padding", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 70 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                                                 5

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "FormatString", "{0:hh:mm tt}");
                __builder2.AddAttribute(64, "Step", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 70 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                                                                                      spanLastFifteen

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenAxisTitle>(66);
                    __builder3.AddAttribute(67, "Text", "Time (UTC)");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 73 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                }
                else if(timeSelect == 60){

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<Radzen.Blazor.RadzenCategoryAxis>(68);
                __builder2.AddAttribute(69, "Padding", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 75 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                                                 5

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "FormatString", "{0:hh:mm tt}");
                __builder2.AddAttribute(71, "Step", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 75 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                                                                                      spanLastHour

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenAxisTitle>(73);
                    __builder3.AddAttribute(74, "Text", "Time (UTC)");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 78 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                }
                else{

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<Radzen.Blazor.RadzenCategoryAxis>(75);
                __builder2.AddAttribute(76, "Padding", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 80 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                                                 5

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(77, "FormatString", "{0:hh:mm tt}");
                __builder2.AddAttribute(78, "Step", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 80 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                                                                                      spanLastDay

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenAxisTitle>(80);
                    __builder3.AddAttribute(81, "Text", "Time (UTC)");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 83 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<Radzen.Blazor.RadzenValueAxis>(82);
                __builder2.AddAttribute(83, "Formatter", new System.Func<System.Object, System.String>(
#nullable restore
#line 84 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                                             FormatAsUSD

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(84, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridLines>(85);
                    __builder3.AddAttribute(86, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 85 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                                              true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(87, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenAxisTitle>(88);
                    __builder3.AddAttribute(89, "Text", "Current Price ($)");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n    <br>\r\n    <br>\r\n    <br>\r\n    ");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "row");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "col-lg-2 offset-lg-1 col-md-10 offset-md-1 col-sm-10 offset-sm-1 col-10 offset-1 text-center");
            __builder.AddMarkupContent(95, "<h3>Cryptocurrency</h3>\r\n            ");
            __builder.OpenElement(96, "p");
            __builder.AddContent(97, 
#nullable restore
#line 98 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                cryptoArray[0].symbol

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n        ");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "col-lg-2 offset-lg-0 col-md-10 offset-md-1 col-sm-10 offset-sm-1 col-10 offset-1 text-center");
            __builder.AddMarkupContent(101, "<h3>Current Price</h3>\r\n\r\n            ");
            __builder.OpenElement(102, "p");
            __builder.AddContent(103, "$");
            __builder.AddContent(104, 
#nullable restore
#line 103 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                 Convert.ToDecimal(Math.Round(cryptoArray[0].currPrice,2)).ToString("#,##0.00")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 104 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
             if(percentChangeCurrPrice(cryptoArray) >= 0){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(105, "p");
            __builder.AddAttribute(106, "style", "color:green;");
            __builder.AddContent(107, "(");
            __builder.AddContent(108, 
#nullable restore
#line 105 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                                          Math.Round(percentChangeCurrPrice(cryptoArray),2)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(109, "%)");
            __builder.CloseElement();
#nullable restore
#line 106 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
            }else{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(110, "p");
            __builder.AddAttribute(111, "style", "color:red;");
            __builder.AddContent(112, "(");
            __builder.AddContent(113, 
#nullable restore
#line 107 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                                        Math.Round(percentChangeCurrPrice(cryptoArray),2)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(114, "%)");
            __builder.CloseElement();
#nullable restore
#line 108 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n        ");
            __builder.OpenElement(116, "div");
            __builder.AddAttribute(117, "class", "col-lg-2 offset-lg-0 col-md-10 offset-md-1 col-sm-10 offset-sm-1 col-10 offset-1 text-center");
            __builder.AddMarkupContent(118, "<h3>Market Cap</h3>\r\n            ");
            __builder.OpenElement(119, "p");
            __builder.AddContent(120, "$");
            __builder.AddContent(121, 
#nullable restore
#line 113 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                 Convert.ToDecimal(cryptoArray[0].marketCap).ToString("#,##0.00")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n        \r\n        ");
            __builder.OpenElement(123, "div");
            __builder.AddAttribute(124, "class", "col-lg-2 offset-lg-0 col-md-10 offset-md-1 col-sm-10 offset-sm-1 col-10 offset-1 text-center");
            __builder.AddMarkupContent(125, "<h3>Sentiment</h3>");
#nullable restore
#line 119 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
             if(stringToDouble(sentiment) >= 0){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(126, "p");
            __builder.AddAttribute(127, "style", "color:green;");
            __builder.AddContent(128, 
#nullable restore
#line 120 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                                             Math.Round(stringToDouble(sentiment),3)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(129, "%");
            __builder.CloseElement();
#nullable restore
#line 121 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                }else{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(130, "p");
            __builder.AddAttribute(131, "style", "color:red;");
            __builder.AddContent(132, 
#nullable restore
#line 122 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                                           Math.Round(stringToDouble(sentiment),3)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(133, "%");
            __builder.CloseElement();
#nullable restore
#line 123 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n        ");
            __builder.OpenElement(135, "div");
            __builder.AddAttribute(136, "class", "col-lg-2 offset-lg-0 col-md-10 offset-md-1 col-sm-10 offset-sm-1 col-10 offset-1 text-center");
            __builder.AddMarkupContent(137, "<h3>Last Updated</h3>\r\n            ");
            __builder.OpenElement(138, "p");
            __builder.AddContent(139, 
#nullable restore
#line 127 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                cryptoArray[0].date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n    <br>\r\n    <br>\r\n    <br>\r\n    <br>");
            __builder.AddMarkupContent(141, "<h2 style=\"text-align: center; text-decoration: underline; \">Recent Data Pulls</h2> \r\n    <br>\r\n    ");
            __builder.OpenElement(142, "table");
            __builder.AddAttribute(143, "class", "table");
            __builder.AddMarkupContent(144, "<thead><tr><th>Date</th>\r\n                <th>CryptoID</th>\r\n                <th>Symbol</th>\r\n                <th>Current Price</th>\r\n                <th>Market Cap</th>\r\n                <th>Slug</th></tr></thead>\r\n        ");
            __builder.OpenElement(145, "tbody");
#nullable restore
#line 149 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
             foreach (var cryptoData in searchList)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(146, "tr");
            __builder.OpenElement(147, "td");
            __builder.AddContent(148, 
#nullable restore
#line 152 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                         cryptoData.date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(149, " at ");
            __builder.AddContent(150, 
#nullable restore
#line 152 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                                                                 cryptoData.date.ToShortTimeString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n                    ");
            __builder.OpenElement(152, "td");
            __builder.AddContent(153, 
#nullable restore
#line 153 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                         cryptoData.cryptoID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n                    ");
            __builder.OpenElement(155, "td");
            __builder.AddContent(156, 
#nullable restore
#line 154 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                         cryptoData.symbol

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\r\n                    ");
            __builder.OpenElement(158, "td");
            __builder.AddContent(159, 
#nullable restore
#line 155 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                         cryptoData.currPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\r\n                    ");
            __builder.OpenElement(161, "td");
            __builder.AddContent(162, 
#nullable restore
#line 156 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                         cryptoData.marketCap

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(163, "\r\n                    ");
            __builder.OpenElement(164, "td");
            __builder.AddContent(165, 
#nullable restore
#line 157 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                         cryptoData.slug

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 159 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 162 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 164 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
       

    private List<CryptoData> searchList;
    string sentiment;
    CryptoData[] cryptoArray = new CryptoData[100];

    [Parameter]    
    public string searchTerm {get;set;}

    [Parameter]    
    public int timeSelect {get;set;} = 60;



    TimeSpan spanLastFifteen = TimeSpan.FromMinutes(4);
    TimeSpan spanLastHour = TimeSpan.FromMinutes(15);

    TimeSpan spanLastDay = TimeSpan.FromMinutes(360);


    protected override async Task OnInitializedAsync()
    {
        using (var context = contextFactory.CreateDbContext())
        {
            searchList = await context.Currencies.Where(b => (b.symbol == searchTerm || b.slug == searchTerm)).OrderByDescending(s => s.date).Take(12).ToListAsync();
        }
        
        cryptoArray = searchList.ToArray();
        sentiment = await tweetAPIservice.GetTweetSentiment(searchTerm);

    }

    double stringToDouble(string str){
        return Convert.ToDouble(str);
    }

    string FormatAsUSD(object value)
    {
        return ((double)value).ToString("C0", CultureInfo.CreateSpecificCulture("en-US"));
    }

    //need to add dropdown to switch time and repopulate chart and data
    double percentChangeCurrPrice(CryptoData[] arr){
        int arrLen = arr.Length;
        double change = ((arr[0].currPrice - arr[arrLen - 1].currPrice)/arr[arrLen-1].currPrice)*100;
        return change;
    }



    
    async Task refreshPage(int timeSel)
    {
        timeSelect = timeSel;
        using (var context = contextFactory.CreateDbContext())
        {
            if (timeSel == 15)
            {
            searchList = await context.Currencies.Where(b => (b.symbol == searchTerm || b.slug == searchTerm)).OrderByDescending(s => s.date).Take(4).ToListAsync();
            }
            else if (timeSel == 60)
            {
            searchList = await context.Currencies.Where(b => (b.symbol == searchTerm || b.slug == searchTerm)).OrderByDescending(s => s.date).Take(13).ToListAsync();
            }
            else if (timeSel == 1440)
            {
            searchList = await context.Currencies.Where(b => (b.symbol == searchTerm || b.slug == searchTerm)).OrderByDescending(s => s.date).Take(289).ToListAsync();
            }
        }
        cryptoArray = searchList.ToArray();
    }


    void SearchForCrypto()
    {
        NavigationManager.NavigateTo("/crypto/" + searchTerm, forceLoad: true);
        Console.WriteLine("Called func");
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.EntityFrameworkCore.IDbContextFactory<CryptoDbContext> contextFactory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TweetAPIService tweetAPIservice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CryptoDbService cryptoDbService { get; set; }
    }
}
namespace __Blazor.crypto_sentiment.Pages.Search
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenLineSeries_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenLineSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "CategoryProperty", __arg1);
        __builder.AddAttribute(__seq2, "Title", __arg2);
        __builder.AddAttribute(__seq3, "ValueProperty", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
