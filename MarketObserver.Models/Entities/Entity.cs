using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketViewer.Models.Entities
{
    public interface IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        ObjectId Id { get; set; }

        DateTime Created { get; set; }
        DateTime? Modified { get; set; }
    }

    public abstract class Entity : IEntity
    {
        public ObjectId Id { get; set; }

        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
    }
}
