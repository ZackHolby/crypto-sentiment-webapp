#pragma checksum "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\MainLayout.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4311a60f614ee1d433b633dc1d2d52564d03d72d7d898ce6f4e16bf0bf1b4285"
// <auto-generated/>
#pragma warning disable 1591
namespace crypto_sentiment.Shared
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
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
#line 2 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\MainLayout.razor"
using Microsoft.AspNetCore.Mvc.Rendering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\MainLayout.razor"
using crypto_sentiment.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\MainLayout.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\MainLayout.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\MainLayout.razor"
using crypto_sentiment.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\MainLayout.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\MainLayout.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 15 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\MainLayout.razor"
 if (searchList == null){

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"center\" b-8s2cww08tf><p b-8s2cww08tf>Loading your content...</p>\r\n        <div class=\"spinner-border text-dark\" b-8s2cww08tf></div></div>");
#nullable restore
#line 20 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\MainLayout.razor"
    
}
else{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "page");
            __builder.AddAttribute(3, "b-8s2cww08tf");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "sidebar");
            __builder.AddAttribute(6, "b-8s2cww08tf");
            __builder.OpenComponent<global::crypto_sentiment.Shared.NavMenu>(7);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "main");
            __builder.AddAttribute(11, "b-8s2cww08tf");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "top-row px-4");
            __builder.AddAttribute(14, "b-8s2cww08tf");
            __builder.OpenComponent<global::MudBlazor.MudThemeProvider>(15);
            __builder.AddAttribute(16, "Theme", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.MudTheme>(
#nullable restore
#line 31 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\MainLayout.razor"
                                         MyCustomTheme

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenComponent<global::MudBlazor.MudDialogProvider>(18);
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenComponent<global::MudBlazor.MudSnackbarProvider>(20);
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenComponent<global::MudBlazor.MudItem>(22);
            __builder.AddAttribute(23, "xs", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 34 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\MainLayout.razor"
                             12

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(24, "sm", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 34 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\MainLayout.razor"
                                     6

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(25, "md", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 34 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\MainLayout.razor"
                                            4

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(26, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudAutocomplete<string>>(27);
                __builder2.AddAttribute(28, "Label", (object)("Ex. Bitcoin, Ethereum..."));
                __builder2.AddAttribute(29, "SearchFunc", (object)((global::System.Func<global::System.String, global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<string>>>)(
#nullable restore
#line 35 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\MainLayout.razor"
                                                                                                                       SearchCryptoList

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(30, "ResetValueOnEmptyText", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 36 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\MainLayout.razor"
                                           true

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(31, "CoerceText", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 36 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\MainLayout.razor"
                                                             true

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(32, "CoerceValue", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 36 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\MainLayout.razor"
                                                                                 true

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(33, "AdornmentIcon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 36 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\MainLayout.razor"
                                                                                                       Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(34, "AdornmentColor", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 36 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\MainLayout.razor"
                                                                                                                                                     MudBlazor.Color.Default

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(35, "OnAdornmentClick", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\MainLayout.razor"
                                                                                                                                                                                                SearchForCrypto

#line default
#line hidden
#nullable disable
                ))));
                __builder2.AddAttribute(36, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 35 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\MainLayout.razor"
                                                                                              searchTerm

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(37, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<string>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => searchTerm = __value, searchTerm)))));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n\r\n            \r\n\r\n            ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "content px-4");
            __builder.AddAttribute(41, "b-8s2cww08tf");
#nullable restore
#line 43 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\MainLayout.razor"
__builder.AddContent(42, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\MainLayout.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Shared\MainLayout.razor"
       

    [Parameter]    
    public string searchTerm {get;set;}

    public CryptoData searchedData;

    private string[] searchList = {"aave","algorand","amp","ankr","avalanche","axie-infinity","bakerytoken","bancor","basic-attention-token","binance-coin",
    "binance-usd","bitcoin","bitcoin-bep2","bitcoin-cash","bitcoin-gold","bitcoin-sv","bittorrent","cardano","celo","celsius","chainlink","chiliz","compound",
    "cosmos","crypto-com-coin","curve-dao-token","dash","decentraland","decred","digibyte","dogecoin","elrond-egld","enjin-coin","eos","ethereum","ethereum-classic",
    "fantom","filecoin","flow","ftx-token","harmony","hedera-hashgraph","helium","holo","horizen","huobi-token","husd","icon","internet-computer","iota","klaytn","kucoin-token",
    "kusama","litecoin","maker","mdex","mobilego","monero","multi-collateral-dai","nano","near-protocol","nem","neo","nexo","okb","omg","ontology","pancakeswap","paxos-standard",
    "polkadot-new","polygon","qtum","quant","ravencoin","revain","shiba-inu","siacoin","solana","stacks","stellar","sushiswap","swissborg","synthetix-network-token","telcoin","terra-luna",
    "terrausd","tether","tezos","the-graph","the-sandbox","theta","theta-fuel","thorchain","tron","trueusd","uma","uniswap","unus-sed-leo","usd-coin","vechain","voyager-token","waves","wrapped-bitcoin",
    "xinfin-network","xrp","yearn-finance","zcash","zilliqa","AAVE","ADA","ALGO","AMP","ANKR","ATOM","AVAX","AXS","BAT","BCH","BNB","BNT","BSV","BTC","BTCB","BTG","BTT","BUSD","CAKE","CEL","CELO",
    "CHSB","CHZ","COMP","CRO","CRV","DAI","DASH","DCR","DGB","DOGE","DOT","EGLD","ENJ","EOS","ETC","ETH","FIL","FLOW","FTM","FTT","GRT","HBAR","HNT","HO","THT","ICP","ICX","KCS","KLAY","KSM","LEO","LINK","LTC","LUNA","MANA",
    "MATIC","MDXM","IOTA","MKR","NANO","NEAR","NEO","NEXO","OKB","OMG","ONE","ONT","PAX","PERP","PLA","QNT","QTUM","RUNE","RVN","SC","SHIB","SNX","SOL","STX","SUSHI","TELT","FUEL","THETA","TRX","TUSD","UMA","UNI","USDC",
    "USDT","UST","VET","VGX","WAVES","WBTC","XDC","XEM","XLM","XMR","XRP","XTZ","YFI","ZEC","ZEN","ZIL","ZRX" };



    private async Task<IEnumerable<string>> SearchCryptoList(string value)
    {
         await Task.Delay(5);
        // if text is null or empty, don't return values (drop-down will not open)
        if (string.IsNullOrEmpty(value))
            return new string[0];
        return searchList.Where(x => x.Contains(value, StringComparison.InvariantCultureIgnoreCase));
    }
    void SearchForCrypto()
    {

        NavigationManager.NavigateTo("/crypto/" + searchTerm,true);
        
        Console.WriteLine("Called func with searchterm: "+searchTerm);
    }

    MudTheme MyCustomTheme = new MudTheme()
    {
        Palette = new Palette()
        {
            Primary = Colors.Blue.Lighten1,
            Secondary = Colors.Green.Accent4,
            AppbarBackground = Colors.Red.Default,
        }
    };




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
