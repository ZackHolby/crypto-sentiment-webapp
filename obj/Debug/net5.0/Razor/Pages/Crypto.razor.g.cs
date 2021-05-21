#pragma checksum "C:\Users\Zack\Coding\crypto-sentiment-webapp\Pages\Crypto.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4313fd03ac6e817ff3cbe3652d68be3b55cbb2d"
// <auto-generated/>
#pragma warning disable 1591
namespace crypto_sentiment.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
#line 8 "C:\Users\Zack\Coding\crypto-sentiment-webapp\Pages\Crypto.razor"
                    currentPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 11 "C:\Users\Zack\Coding\crypto-sentiment-webapp\Pages\Crypto.razor"
 if (cryptoData == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<p><em>Loading...</em></p>");
#nullable restore
#line 14 "C:\Users\Zack\Coding\crypto-sentiment-webapp\Pages\Crypto.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "<thead><tr><th>Date</th>\r\n                <th>Symbol</th>\r\n                <th>Current Price</th>\r\n                <th>Market Cap</th>\r\n                <th>Slug</th></tr></thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.OpenElement(9, "tr");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 30 "C:\Users\Zack\Coding\crypto-sentiment-webapp\Pages\Crypto.razor"
                         cryptoData.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 31 "C:\Users\Zack\Coding\crypto-sentiment-webapp\Pages\Crypto.razor"
                         cryptoData.symbol

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 32 "C:\Users\Zack\Coding\crypto-sentiment-webapp\Pages\Crypto.razor"
                         cryptoData.currPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 33 "C:\Users\Zack\Coding\crypto-sentiment-webapp\Pages\Crypto.razor"
                         cryptoData.market_cap

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 34 "C:\Users\Zack\Coding\crypto-sentiment-webapp\Pages\Crypto.razor"
                         cryptoData.slug

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\Zack\Coding\crypto-sentiment-webapp\Pages\Crypto.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\Zack\Coding\crypto-sentiment-webapp\Pages\Crypto.razor"
       
    private int currentPrice = 0;

    private void getPrice()
    {
        var rand = new Random();
        currentPrice = rand.Next(20000, 50000);
    }


    private CryptoData cryptoData;

    protected override async Task OnInitializedAsync()
    {
        cryptoData = await CryptoService.getCryptoData(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CryptoService cryptoservice { get; set; }
    }
}
#pragma warning restore 1591
