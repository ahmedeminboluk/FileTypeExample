using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ReadWrite
{
    [Serializable()]
    public class News 
    {
        [XmlElement("BASLIK")]
        public string Title { get; set; }
        [XmlElement("METIN")]
        public string Text { get; set; }
        [XmlElement("RESIMADI")]
        public string ImageName { get; set; }
        [XmlElement("RESIM")]
        public string Image { get; set; }
        [XmlElement("LINK")]
        public string Link { get; set; }
        [XmlElement("TARIH")]
        public string Date { get; set; }
    }
}
