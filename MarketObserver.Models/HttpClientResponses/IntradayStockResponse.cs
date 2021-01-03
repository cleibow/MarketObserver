using System;
using System.Collections.Generic;
using System.Text;

namespace MarketObserver.Model.HttpClientResponses
{
    public class IntradayStockResponse
    {
        public List<Stock> Data { get; set; }
    }

    public class Stock
    {
        public string Exchange { get; set; }
        public decimal Open { get; set; }
        public decimal Close { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Volume { get; set; }
    }
}
