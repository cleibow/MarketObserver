using MarketObserver.Model.Generics;
using MarketViewer.Models.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketObserver.Model.Entities
{
    [BsonCollection("StockSeedData")]
    public class StockSeedData : Entity
    {
        public string Symbol { get; set; }

        [BsonElement("Security Name")]
        public string SecurityName { get; set; }

        //[JsonConverter(typeof(StringEnumConverter))]
        //[BsonRepresentation(BsonType.String)]
        [BsonElement("Market Category")]
        public string MarketCategory { get; set; }

        [BsonElement("Test Issue")]
        public string TestIssue { get; set; }

        [BsonElement("Financial Status")]
        public string FinancialStatus { get; set; }

        [BsonElement("Round Lot Size")]
        public double RoundLotSize { get; set; }

        [BsonElement("ETF")]
        public string ETF { get; set; }

        [BsonElement("NextShares")]
        public string NextShares { get; set; }
    }

    // TODO: change values to enums
    public enum MarketCategory
    {
        Test, 
        TestAgain
    }
}
