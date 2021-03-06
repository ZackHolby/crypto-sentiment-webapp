#pragma checksum "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39773c0cb9f390cb614937249ba759b0ce0da4e2"
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
#line 12 "C:\Users\zackh\Coding\crypto-sentiment-webapp\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
using crypto_sentiment.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
using crypto_sentiment.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
using MoreLinq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 style=\"text-align:center;\">Crypto Sentiment</h1>\r\n");
            __builder.AddMarkupContent(1, "<h6 class=\"subtext\" style=\"text-align:center;\">Get started by searching your favorite Cryptocurrencies above!</h6>\r\n");
            __builder.AddMarkupContent(2, "<div class=\"collapsedIMG\"><div class=\"hero-image\"></div></div>\r\n\r\n");
            __builder.AddMarkupContent(3, "<h4 style=\"text-decoration:underline;text-align:center;\">Largest Movers in past 24 Hours</h4>\r\n");
            __builder.AddMarkupContent(4, "<p style=\"text-align:center;\">(Top 100 MarketCap)</p>\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "className", "container-fluid d-flex justify-content-center");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
#nullable restore
#line 28 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
         foreach(CryptoData crypto in moverList){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-lg-3 offset-lg-0 col-md-6 offset-md-0 col-sm-10 offset-sm-1 col-10 offset-1");
#nullable restore
#line 30 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
                 if(@crypto.percentChange24 >= 0){
                    

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorStrap.BSCard>(11);
            __builder.AddAttribute(12, "Class", "clickable");
            __builder.AddAttribute(13, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Color>(
#nullable restore
#line 32 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
                                                     BlazorStrap.Color.Success

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "Alignment", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Alignment>(
#nullable restore
#line 32 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
                                                                                           Alignment.Center

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
                                                                                                                       (() => SearchForCryptoRef(crypto.slug))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<BlazorStrap.BSCard>(17);
                __builder2.AddAttribute(18, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 33 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
                                          CardType.Body

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<BlazorStrap.BSCard>(20);
                    __builder3.AddAttribute(21, "Class", "under");
                    __builder3.AddAttribute(22, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 34 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
                                                            CardType.Title

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(24, 
#nullable restore
#line 34 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
                                                                             FirstLetterToUpper(crypto.slug)

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddContent(25, " (");
                        __builder4.AddContent(26, 
#nullable restore
#line 34 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
                                                                                                               crypto.symbol

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddContent(27, ")");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(28, "\r\n                                ");
                    __builder3.OpenComponent<BlazorStrap.BSCard>(29);
                    __builder3.AddAttribute(30, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 35 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
                                                  CardType.Text

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(32, 
#nullable restore
#line 35 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
                                                                  crypto.percentChange24

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddContent(33, "%");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 38 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
                }else{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorStrap.BSCard>(34);
            __builder.AddAttribute(35, "Class", "clickable");
            __builder.AddAttribute(36, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Color>(
#nullable restore
#line 39 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
                                                     BlazorStrap.Color.Danger

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "Alignment", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Alignment>(
#nullable restore
#line 39 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
                                                                                          Alignment.Center

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
                                                                                                                      (() => SearchForCryptoRef(crypto.slug))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<BlazorStrap.BSCard>(40);
                __builder2.AddAttribute(41, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 40 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
                                          CardType.Body

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<BlazorStrap.BSCard>(43);
                    __builder3.AddAttribute(44, "Class", "under");
                    __builder3.AddAttribute(45, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 41 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
                                                            CardType.Title

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(47, 
#nullable restore
#line 41 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
                                                                             FirstLetterToUpper(crypto.slug)

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddContent(48, " (");
                        __builder4.AddContent(49, 
#nullable restore
#line 41 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
                                                                                                               crypto.symbol

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddContent(50, ")");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(51, "\r\n                                ");
                    __builder3.OpenComponent<BlazorStrap.BSCard>(52);
                    __builder3.AddAttribute(53, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 42 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
                                                  CardType.Text

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(55, 
#nullable restore
#line 42 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
                                                                  crypto.percentChange24

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddContent(56, "%");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 45 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 47 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"

        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
      
    DateTime minAgo=DateTime.Now.AddMinutes(-0);


    private List<CryptoData> searchList;

    private List<CryptoData> moverList;



    
    protected override void OnInitialized(){
        Console.WriteLine(minAgo);
        using (var context = contextFactory.CreateDbContext())
        {
            searchList = context.Currencies.Where(s => s.date> minAgo).DistinctBy(x => x.slug).OrderByDescending(d => d.marketCap).Take(100).ToList();
            moverList = searchList.OrderByDescending(d => Math.Abs(d.percentChange24)).Take(4).ToList();
        }

        foreach(CryptoData c in moverList){
            Console.WriteLine(c.slug+ "   "+c.percentChange24);
        }
        


    }


    public string FirstLetterToUpper(string str)
    {
        if (str == null)
            return null;

        if (str.Length > 1)
            return char.ToUpper(str[0]) + str.Substring(1);

        return str.ToUpper();
    }

    void SearchForCryptoRef(string refString)
    {
        NavigationManager.NavigateTo("/crypto/" + refString,true);
        
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
#pragma warning restore 1591
