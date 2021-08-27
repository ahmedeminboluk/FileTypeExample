using ReadWrite.Interfaces;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ReadWrite.Models
{
    [XmlRoot("HABERLER")]
    public class AllNews : IEntity
    {
        [XmlElement("HABER")]
        public List<News> News { get; set; }
    }
}
