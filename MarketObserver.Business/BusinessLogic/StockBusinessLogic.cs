using MarketObserver.Business.Generics;
using MarketObserver.Business.HttpClients;
using MarketObserver.Business.Services;
using MarketObserver.Model.Config;
using MarketObserver.Model.Entities;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketObserver.Business.BusinessLogic
{
    public interface IStockBusinessLogic
    {
        BusinessResult<List<Stock>> CheckStockChanges();
    }

    public class StockBusinessLogic : IStockBusinessLogic
    {
        public MarketObserverConfiguration _marketObserverConfiguration { get; set; }
        public IStockSeedDataService _stockSeedDataService { get; set; }
        public IStockDataService _stockDataService { get; set; }
        public IMarketStackHttpClient _marketStackHttpClient { get; set; }

        public StockBusinessLogic(IOptions<MarketObserverConfiguration> options, 
                                    IStockSeedDataService stockSeedDataService, 
                                    IStockDataService stockDataService,
                                    IMarketStackHttpClient marketStackHttpClient)
        {
            this._marketObserverConfiguration = options.Value;
            this._stockSeedDataService = stockSeedDataService;
            this._stockDataService = stockDataService;
            this._marketStackHttpClient = marketStackHttpClient;
        }

        public BusinessResult<List<Stock>> CheckStockChanges()
        {
            try
            {
                // get symbols
                var symbols = this._stockSeedDataService.GetStockSymbols();
                var stocks = new List<Stock>();

                if (symbols != null && symbols.Count > 0)
                {
                    // call market stack client to get latest values for stocks
                    var marketStackStocks = Task.Run(() => this._marketStackHttpClient.GetIntradayStocks(symbols.First()));

                    // get saved stocks from DB
                    var savedStocks = this._stockDataService.GetStocks();

                    // if saved stocks exist, compare and perform update of records
                    if (savedStocks != null && savedStocks.Count > 0)
                    {
                        // compare retrieved stocks

                        // update saved stocks

                        // return any stocks that have changed significantly
                    }

                    var marketStock = marketStackStocks.Result.Data.First();

                    // otherwise create new stock records using data from market stack
                    return BusinessResult<List<Stock>>.CreateSuccessResult(stocks);
                }

                return BusinessResult<List<Stock>>.CreateSuccessResult(stocks);

            }
            catch (Exception e)
            {
                return BusinessResult<List<Stock>>.CreateFailure(e);
            }
        }
    }
}
