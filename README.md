# Crypto Sentiment Blazor Webapp
Visit my site at [Cryptoment](https://cryptoment.azurewebsites.net/)
```
https://cryptoment.azurewebsites.net/
```
###### Blazor webapp using CoinMarketCap API to pull crypto data and analyze sentiment from social media

### Technologies Used
- C#/.Net 5.0
- Blazor Server
- Azure Functions
- Python Flask API for twitter sentiment
- Azure Cloud SqlServer Database
- Azure App Service for deployment

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
| slug | nvarchar(20) | Full name of cryptocurrency (Ex. bitcoin) |
| symbol | nvarchar(100) | Abbreviated name of cryptocurrency (Ex.  BTC) |
| percentChange24 | float | Amount a crypto has changed in value over 24 hour span |


# Key Takeaways
1. Serverless computing - huge advantage to freshen data through serverless computation over constantly running a server to perform API calls and populate DB. I utilized a cloud DB and Azure functions to pull data every 5 minutes and populate DB.
2. Nvarchar(max) nightmare - this data type in SQLserver DB's casues runtimes of LINQ queries to be extremely slow (>15 seconds at times). Avoid this by using a fixed length such as Nvarchar(50) to get a fast query and load data quickly.
3. Blazor Server and Razor pages are awesome! - Blazor made writing client side code with the logic right next to it very simple and continuous for the developer. It made for quick and efficient development on my end that was greatly appreciated while learning C#/.NET.
