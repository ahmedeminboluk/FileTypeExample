using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileTypeExample.API.Models
{
    public class PushContent : IDocument
    {
        
        [BsonElement("Title")]
        public string Title { get; set; }
        [BsonElement("Spot")]
        public string Spot { get; set; }
        [BsonElement("Category")]
        public string Category { get; set; }
    }
}
