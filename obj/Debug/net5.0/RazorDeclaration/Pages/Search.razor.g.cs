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
        }
        #pragma warning restore 1998
#nullable restore
#line 152 "C:\Users\zackh\Coding\crypto-sentiment-webapp\Pages\Search.razor"
       

    private List<CryptoData> searchList;
    string sentiment;
    CryptoData[] cryptoArray = new CryptoData[100];

    [Parameter]    
    public string searchTerm {get;set;}

    [Parameter]    
    public int timeSelect {get;set;} = 60;



    TimeSpan spanLastFifteen = TimeSpan.FromMinutes(1);
    TimeSpan spanLastHour = TimeSpan.FromMinutes(10);

    TimeSpan spanLastDay = TimeSpan.FromMinutes(120);


    protected override async Task OnInitializedAsync()
    {
        using (var context = contextFactory.CreateDbContext())
        {
            searchList = await context.Currencies.Where(b => (b.symbol == searchTerm || b.slug == searchTerm)).OrderByDescending(s => s.date).Take(12).ToListAsync();
        }

        cryptoArray = searchList.ToArray();
        sentiment = await tweetAPIservice.GetTweetSentiment(searchTerm);
        Console.WriteLine(cryptoArray[0].date.ToString("hh:mm:ss tt",CultureInfo.InvariantCulture));
        Console.WriteLine("Returned this many results from search: "+searchList.Count());

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
