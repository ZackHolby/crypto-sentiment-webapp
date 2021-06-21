#pragma checksum "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea7048dc034abe9da07ddf14600c2a6c07c2b4b2"
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
#line 3 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
using crypto_sentiment.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
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
#line 14 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
 if (searchList == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"spinner-border text-dark\"></div>\r\n    ");
            __builder.OpenElement(1, "h1");
            __builder.AddContent(2, "Blazor is ");
            __builder.AddContent(3, 
#nullable restore
#line 17 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                   searchTerm

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, "!");
            __builder.CloseElement();
#nullable restore
#line 18 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                                     searchTerm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchTerm = __value, searchTerm));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "button");
            __builder.AddAttribute(12, "value", "Search");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                                                  () => SearchForCrypto()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "table");
            __builder.AddAttribute(16, "class", "table");
            __builder.AddMarkupContent(17, "<thead><tr><th>Date</th>\r\n                <th>CryptoID</th>\r\n                <th>Symbol</th>\r\n                <th>Current Price</th>\r\n                <th>Market Cap</th>\r\n                <th>Slug</th></tr></thead>\r\n        ");
            __builder.OpenElement(18, "tbody");
#nullable restore
#line 35 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
             foreach (var cryptoData in searchList)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "tr");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 38 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                         cryptoData.date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 39 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                         cryptoData.cryptoID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 40 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                         cryptoData.symbol

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 41 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                         cryptoData.currPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 42 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                         cryptoData.marketCap

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 43 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
                         cryptoData.slug

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 48 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
       

    private List<CryptoData> searchList;

    [Parameter]    
    public string searchTerm {get;set;}

    void SearchForCrypto()
    {
        NavigationManager.NavigateTo("/crypto/" + searchTerm, forceLoad: true);
        Console.WriteLine("Called func");
    }


    protected override async Task OnInitializedAsync()
    {
        using (var context = contextFactory.CreateDbContext())
        {
            searchList = await context.Currencies.Where(b => b.symbol.Contains(searchTerm)).OrderByDescending(s => s.date).Take(10).ToListAsync();
        }
        Console.WriteLine(searchList.Count());
        Console.WriteLine("Hello");

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
