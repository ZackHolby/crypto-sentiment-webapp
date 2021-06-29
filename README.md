# Crypto Sentiment Blazor Webapp
Blazor webapp using CoinMarketCap API to pull crypto data and analyze sentiment from various sources (Twitter, Reddit, possibly StockTwits)

### API calls
- ##### CoinMarketCap
    CoinMarketCap API calls are limited to 333 each day so a call will be scheduled for every 5 mins for market data using Azure Function pull

- ##### Twitter
    Twitter API calls will be ran synchronously with search on web app to scrape twitter and calculate sentiment based on coin you are searching for

### Database schema

| Property |  Type | Description |
| ------ | ------ | ------ |
| cryptoID | nvarchar(450) / Primary Key | GUID for cryptocurrency pull to store in database |
| currPrice | float | Price at time of data pull of cryptocurrency |
| currencyID | int | ID of cryptocurrency given by CoinMarketCap API |
| date | datetime(7) | Datetime of data pull of cryptocurrency |
| marketCap | bigint | Current market cap of respective cryptocurrency |
| slug | nvarchar(max) | Full name of cryptocurrency (Ex. bitcoin) |
| symbol | nvarchar(max) | Abbreviated name of cryptocurrency (Ex.  BTC) |


# Helpful Notes
#### Start .NET server for blazor app: 
```sh
$ dotnet watch run
```	

#### Use smss to connect to cloud DB using following command as Server Name (will have to provide credentials sepearte):
```sh
$ crypto-sentiment-sqlserver.database.windows.net
```	
