#pragma checksum "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45159fbacc868f1834b0945ce1c2ad64d8286f28"
// <auto-generated/>
#pragma warning disable 1591
namespace crypto_sentiment.Shared
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
#line 11 "C:\Users\zackh\Coding\crypto-sentiment-webapp\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\zackh\Coding\crypto-sentiment-webapp\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\zackh\Coding\crypto-sentiment-webapp\_Imports.razor"
using MoreLinq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\zackh\Coding\crypto-sentiment-webapp\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\NavMenu.razor"
using crypto_sentiment.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\NavMenu.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\NavMenu.razor"
using crypto_sentiment.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\NavMenu.razor"
using crypto_sentiment.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\NavMenu.razor"
using Radzen;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-nbbge4sxlp");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-nbbge4sxlp>Crypto Sentiment</a>\r\n        \r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-nbbge4sxlp");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-nbbge4sxlp></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 21 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "b-nbbge4sxlp");
            __builder.OpenElement(13, "ul");
            __builder.AddAttribute(14, "class", "nav flex-column");
            __builder.AddAttribute(15, "b-nbbge4sxlp");
            __builder.OpenElement(16, "li");
            __builder.AddAttribute(17, "class", "nav-item px-3");
            __builder.AddAttribute(18, "b-nbbge4sxlp");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(19);
            __builder.AddAttribute(20, "class", "nav-link");
            __builder.AddAttribute(21, "href", "");
            __builder.AddAttribute(22, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 24 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(24, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-nbbge4sxlp></span> Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        <br b-nbbge4sxlp>\r\n        <br b-nbbge4sxlp>\r\n        ");
            __builder.AddMarkupContent(26, "<li class=\"nav-item px-3\" b-nbbge4sxlp><h3 class=\"popular\" b-nbbge4sxlp>Popular Cryptos</h3></li>\r\n            \r\n        ");
            __builder.OpenElement(27, "li");
            __builder.AddAttribute(28, "class", "nav-item px-3");
            __builder.AddAttribute(29, "b-nbbge4sxlp");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(30);
            __builder.AddAttribute(31, "class", "nav-link");
            __builder.AddAttribute(32, "href", "crypto/bitcoin");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\NavMenu.razor"
                                                                      (() => SearchForCryptoRef("bitcoin"))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(35, "<span class=\"oi oi-minus\" aria-hidden=\"true\" b-nbbge4sxlp></span> Bitcoin\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.OpenElement(37, "li");
            __builder.AddAttribute(38, "class", "nav-item px-3");
            __builder.AddAttribute(39, "b-nbbge4sxlp");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(40);
            __builder.AddAttribute(41, "class", "nav-link");
            __builder.AddAttribute(42, "href", "crypto/ethereum");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\NavMenu.razor"
                                                                       (() => SearchForCryptoRef("ethereum"))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(45, "<span class=\"oi oi-minus\" aria-hidden=\"true\" b-nbbge4sxlp></span> Ethereum\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.OpenElement(47, "li");
            __builder.AddAttribute(48, "class", "nav-item px-3");
            __builder.AddAttribute(49, "b-nbbge4sxlp");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(50);
            __builder.AddAttribute(51, "class", "nav-link");
            __builder.AddAttribute(52, "href", "crypto/link");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\NavMenu.razor"
                                                                   (() => SearchForCryptoRef("chainlink"))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(55, "<span class=\"oi oi-minus\" aria-hidden=\"true\" b-nbbge4sxlp></span> ChainLink\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.OpenElement(57, "li");
            __builder.AddAttribute(58, "class", "nav-item px-3");
            __builder.AddAttribute(59, "b-nbbge4sxlp");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(60);
            __builder.AddAttribute(61, "class", "nav-link");
            __builder.AddAttribute(62, "href", "crypto/doge");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\NavMenu.razor"
                                                                   (() => SearchForCryptoRef("dogecoin"))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(65, "<span class=\"oi oi-minus\" aria-hidden=\"true\" b-nbbge4sxlp></span> Doge\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n\r\n\r\n        ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "collapsedSearchbar");
            __builder.AddAttribute(69, "b-nbbge4sxlp");
            __builder.OpenComponent<MudBlazor.MudItem>(70);
            __builder.AddAttribute(71, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 57 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\NavMenu.razor"
                         10

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 57 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\NavMenu.razor"
                                 8

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 57 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\NavMenu.razor"
                                        4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudAutocomplete<string>>(75);
                __builder2.AddAttribute(76, "Class", "auto-search");
                __builder2.AddAttribute(77, "Label", "Ex. Bitcoin, Ethereum...");
                __builder2.AddAttribute(78, "SearchFunc", new System.Func<System.String, System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<string>>>(
#nullable restore
#line 58 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\NavMenu.razor"
                                                                                                                                       SearchCryptoList

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(79, "ResetValueOnEmptyText", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 59 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\NavMenu.razor"
                                       true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(80, "CoerceText", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 59 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\NavMenu.razor"
                                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(81, "CoerceValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 59 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\NavMenu.razor"
                                                                             true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(82, "AdornmentIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 59 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\NavMenu.razor"
                                                                                                   Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(83, "AdornmentColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 59 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\NavMenu.razor"
                                                                                                                                                 MudBlazor.Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(84, "OnAdornmentClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\NavMenu.razor"
                                                                                                                                                                                            SearchForCrypto

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(85, "Style", "color:white !important");
                __builder2.AddAttribute(86, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 58 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\NavMenu.razor"
                                                                                                              searchTerm

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(87, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => searchTerm = __value, searchTerm))));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    [Parameter]
    public string searchTerm { get; set; }

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;


     private string[] searchList = {};


    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

     void SearchForCrypto()
    {
        NavigationManager.NavigateTo("/crypto/" + searchTerm,true);
        
        Console.WriteLine("Called func");
    }

    void SearchForCryptoRef(string refString)
    {
        NavigationManager.NavigateTo("/crypto/" + refString,true);
        
        Console.WriteLine("Called func");
    }

    private async Task<IEnumerable<string>> SearchCryptoList(string value)
    {
         await Task.Delay(5);
        // if text is null or empty, don't return values (drop-down will not open)
        if (string.IsNullOrEmpty(value))
            return new string[0];
        return searchList.Where(x => x.Contains(value, StringComparison.InvariantCultureIgnoreCase));
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
#pragma warning restore 1591
