using System;
using System.Collections.Generic;
using System.Text;

namespace MarketObserver.Model.Config
{
    public interface IMarketObserverConfiguration
    {
        ApiEndpoints ApiEndpoints { get; set; }
        ConnectionStrings ConnectionStrings { get; set; }
        MarketObserverDbSettings MarketObserverDbSettings { get; set; }
    }

    public class MarketObserverConfiguration : IMarketObserverConfiguration
    {
        public ApiEndpoints ApiEndpoints { get; set; }
        public ConnectionStrings ConnectionStrings { get; set; }
        public MarketObserverDbSettings MarketObserverDbSettings { get; set; }
    }

    public class MarketObserverDbSettings
    {
        public string StockSeedDataCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }

    }

    public class ApiEndpoints
    {
        public ApiEndpoint MarketStack { get; set; }
    }

    public class ApiEndpoint
    {
        public string AccessKey { get; set; }
        public string BaseUrl { get; set; }
    }

    public class ConnectionStrings
    {
        public string MarketObserverConnectionString { get; set; }
    }

}
