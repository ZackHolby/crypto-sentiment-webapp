#pragma checksum "C:\Users\Zack\Coding\crypto-sentiment-webapp\Pages\Crypto.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7867fed7f10fb60306a1712b0f077aeba0bf6a29"
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
#line 1 "C:\Users\Zack\Coding\crypto-sentiment-webapp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zack\Coding\crypto-sentiment-webapp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Zack\Coding\crypto-sentiment-webapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Zack\Coding\crypto-sentiment-webapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Zack\Coding\crypto-sentiment-webapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Zack\Coding\crypto-sentiment-webapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Zack\Coding\crypto-sentiment-webapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Zack\Coding\crypto-sentiment-webapp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Zack\Coding\crypto-sentiment-webapp\_Imports.razor"
using crypto_sentiment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Zack\Coding\crypto-sentiment-webapp\_Imports.razor"
using crypto_sentiment.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Zack\Coding\crypto-sentiment-webapp\Pages\Crypto.razor"
using crypto_sentiment.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Zack\Coding\crypto-sentiment-webapp\Pages\Crypto.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Zack\Coding\crypto-sentiment-webapp\Pages\Crypto.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Zack\Coding\crypto-sentiment-webapp\Pages\Crypto.razor"
using crypto_sentiment.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/crypto")]
    public partial class Crypto : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Crypto</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, " Bitcoin price: ");
            __builder.AddContent(3, 
#nullable restore
#line 12 "C:\Users\Zack\Coding\crypto-sentiment-webapp\Pages\Crypto.razor"
                    currentPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 15 "C:\Users\Zack\Coding\crypto-sentiment-webapp\Pages\Crypto.razor"
 if (cryptoDatas == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<p><em>Loading...</em></p>");
#nullable restore
#line 18 "C:\Users\Zack\Coding\crypto-sentiment-webapp\Pages\Crypto.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "<thead><tr><th>Date</th>\r\n                <th>CryptoID</th>\r\n                <th>Symbol</th>\r\n                <th>Current Price</th>\r\n                <th>Market Cap</th>\r\n                <th>Slug</th></tr></thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
#nullable restore
#line 33 "C:\Users\Zack\Coding\crypto-sentiment-webapp\Pages\Crypto.razor"
             foreach (var cryptoData in cryptoDatas)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "tr");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 36 "C:\Users\Zack\Coding\crypto-sentiment-webapp\Pages\Crypto.razor"
                         cryptoData.date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 37 "C:\Users\Zack\Coding\crypto-sentiment-webapp\Pages\Crypto.razor"
                         cryptoData.cryptoID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 38 "C:\Users\Zack\Coding\crypto-sentiment-webapp\Pages\Crypto.razor"
                         cryptoData.symbol

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 39 "C:\Users\Zack\Coding\crypto-sentiment-webapp\Pages\Crypto.razor"
                         cryptoData.currPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 40 "C:\Users\Zack\Coding\crypto-sentiment-webapp\Pages\Crypto.razor"
                         cryptoData.market_cap

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 41 "C:\Users\Zack\Coding\crypto-sentiment-webapp\Pages\Crypto.razor"
                         cryptoData.slug

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "C:\Users\Zack\Coding\crypto-sentiment-webapp\Pages\Crypto.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\Zack\Coding\crypto-sentiment-webapp\Pages\Crypto.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\Zack\Coding\crypto-sentiment-webapp\Pages\Crypto.razor"
       
    private int currentPrice = 0;

    private void getPrice()
    {
        var rand = new Random();
        currentPrice = rand.Next(20000, 50000);
    }


    private List<CryptoData> cryptoDatas;
    protected override async Task OnInitializedAsync()
    {
        cryptoDatas = await cryptoDbService.GetCryptosAsync();
    } 


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CryptoDbService cryptoDbService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CryptoService cryptoservice { get; set; }
    }
}
#pragma warning restore 1591
