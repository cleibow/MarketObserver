using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MarketObserver.Business.Generics
{
    public class BaseHttpClient
    {
        //protected HttpClient _httpClient { get; set; }

        //// Constructor
        //public BaseHttpClient(HttpClient httpClient)
        //{
        //    this._httpClient = httpClient;
        //    this._httpClient.BaseAddress = new Uri(baseUrl);
        //    base.Timeout = new TimeSpan(0, 0, 30);
        //    base.DefaultRequestHeaders.Clear();
        //}

        //public Task<HttpResponseMessage> GetAsync(string url)
        //{
        //    // Set the request message
        //    var request = new HttpRequestMessage(HttpMethod.Get, url);
        //    request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //    //// Call API and get the response
        //    //using (var response = base.SendAsync(request))
        //    //{
        //    //    // Ensure we have a Success Status Code
        //    //    response.EnsureSuccessStatusCode();

        //    //    // Read Response Content (this will usually be JSON content)
        //    //    return response.Content.ReadAsStringAsync();

        //    //    // Deserialize the JSON into the C# List<Movie> object and return
        //    //}

        //    return this._httpClient.SendAsync(request);
        //}
    }
}
