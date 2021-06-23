# Crypto Sentiment Blazor Webapp
Blazor webapp using CoinMarketCap API to pull crypto data and analyze sentiment from various sources (Twitter, Reddit, possibly StockTwits)

### API calls
- ##### CoinMarketCap
    CoinMarketCap API calls are limited to 333 each day so a call will be scheduled for every 5 mins for market data using Azure Function pull

- ##### Twitter
    Twitter API calls will be ran synchronously with search on web app to scrape twitter and calculate sentiment based on coin you are searching for



## Helpful Notes
#### Start .NET server for blazor app: 
```sh
$ dotnet watch run
```	

#### Use smss to connect to cloud DB using following command as Server Name (will have to provide credentials sepearte):
```sh
$ crypto-sentiment-sqlserver.database.windows.net
```	


