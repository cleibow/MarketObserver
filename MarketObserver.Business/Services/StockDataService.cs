using MarketObserver.Business.Generics;
using MarketObserver.Model.Config;
using MarketObserver.Model.Entities;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MarketObserver.Business.Services
{
    public interface IStockDataService
    {
        List<Stock> GetStocks();
    }

    public class StockDataService : MongoDataService<Stock>, IStockDataService
    {
        public StockDataService(IOptions<MarketObserverConfiguration> options) : base(options.Value)
        {

        }

        public List<Stock> GetStocks()
        {
            return base.AsQueryable()
                .ToList();
        }
    }
}
