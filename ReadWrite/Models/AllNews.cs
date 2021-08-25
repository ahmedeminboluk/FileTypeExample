using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ReadWrite.Models
{
    [XmlRoot("HABERLER")]
    public class AllNews
    {
        [XmlElement("HABER")]
        public List<News> News { get; set; }
    }
}
