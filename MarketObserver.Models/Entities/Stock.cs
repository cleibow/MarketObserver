using MarketObserver.Model.Generics;
using MarketViewer.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketObserver.Model.Entities
{
    [BsonCollection("Stock")]
    public class Stock : Entity
    {
        public string Symbol { get; set; }

        public double Volume { get; set; }
    }
}
