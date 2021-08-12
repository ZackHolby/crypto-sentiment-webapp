// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
<<<<<<< HEAD
using MoreLinq;
=======
using Blazorise;
>>>>>>> c930ad5e12f89ec669f3a3ba428331b4faefac68

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\zackh\Coding\crypto-sentiment-webapp\_Imports.razor"
<<<<<<< HEAD
using BlazorStrap;
=======
using MoreLinq;
>>>>>>> c930ad5e12f89ec669f3a3ba428331b4faefac68

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
