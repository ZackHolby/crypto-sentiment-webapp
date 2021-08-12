// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace crypto_sentiment.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\zackh\Coding\crypto-sentiment-webapp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\zackh\Coding\crypto-sentiment-webapp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\zackh\Coding\crypto-sentiment-webapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\zackh\Coding\crypto-sentiment-webapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\zackh\Coding\crypto-sentiment-webapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\zackh\Coding\crypto-sentiment-webapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\zackh\Coding\crypto-sentiment-webapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\zackh\Coding\crypto-sentiment-webapp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\zackh\Coding\crypto-sentiment-webapp\_Imports.razor"
using crypto_sentiment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\zackh\Coding\crypto-sentiment-webapp\_Imports.razor"
using crypto_sentiment.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "c:\Users\zackh\Coding\crypto-sentiment-webapp\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "c:\Users\zackh\Coding\crypto-sentiment-webapp\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
using crypto_sentiment.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
using crypto_sentiment.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "c:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
using MoreLinq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "c:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Index.razor"
       

    DateTime minAgo=DateTime.Now.AddMinutes(-0);

    CryptoData[] cryptoArray = new CryptoData[13];

    private List<CryptoData> searchList;



    
    protected override void OnInitialized(){
        Console.WriteLine(minAgo);
        using (var context = contextFactory.CreateDbContext())
        {
            searchList = context.Currencies.Where(s => s.date >= minAgo).DistinctBy(x => x.slug).OrderByDescending(o => o.percentChange24).Take(6).ToList();
        }


        foreach (CryptoData crypto in searchList){
            Console.WriteLine(crypto.slug+"had change of "+crypto.percentChange24+"%");
        }
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
