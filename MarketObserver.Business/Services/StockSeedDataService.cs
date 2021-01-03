using MarketObserver.Business.Generics;
using MarketObserver.Model.Config;
using MarketObserver.Model.Entities;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketObserver.Business.Services
{
    public interface IStockSeedDataService
    {
        List<string> GetStockSymbols();
    }

    public class StockSeedDataService : MongoDataService<StockSeedData>, IStockSeedDataService
    {
        public StockSeedDataService(IOptions<MarketObserverConfiguration> options) : base(options.Value)
        {

        }

        public List<string> GetStockSymbols()
        {
            return base.AsQueryable()
                .Select(s => s.Symbol)
                .ToList();
        }
    }
}
