using MarketObserver.Business.Generics;
using MarketObserver.Model.Config;
using MarketObserver.Model.HttpClientResponses;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MarketObserver.Business.HttpClients
{
    public interface IMarketStackHttpClient
    {
        Task<IntradayStockResponse> GetIntradayStocks(string symbol);
    }

    public class MarketStackHttpClient : HttpClient, IHttpClient, IMarketStackHttpClient
    {
        public MarketObserverConfiguration _Configuration { get; set; }

        public MarketStackHttpClient(IOptions<MarketObserverConfiguration> marketObserverConfiguration)
        {
            this._Configuration = marketObserverConfiguration.Value;
            base.BaseAddress = new Uri(this._Configuration.ApiEndpoints.MarketStack.BaseUrl);
            base.DefaultRequestHeaders.Clear();
        }

        public async Task<IntradayStockResponse> GetIntradayStocks(string symbol)
        {
            var url = $"intraday?access_key={this._Configuration.ApiEndpoints.MarketStack.AccessKey}&symbols={symbol}";
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await this.SendAsync(request);
            if (response != null && response.IsSuccessStatusCode == true)
            {
                var data = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IntradayStockResponse>(data);
            }
            return new IntradayStockResponse();
        }
    }
}
