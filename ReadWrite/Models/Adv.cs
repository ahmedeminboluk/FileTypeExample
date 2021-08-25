using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ReadWrite.Models
{
    [Serializable()]
    public class Adv
    {
        [XmlElement("adv_text")]
        public string Text { get; set; }
        [XmlElement("adv_def_link")]
        public string DefLink { get; set; }
        [XmlElement("adv_location")]
        public string Location { get; set; }
        [XmlElement("adv_price")]
        public string Price { get; set; }
        [XmlElement("adv_title")]
        public string Title { get; set; }
        [XmlElement("adv_imagename")]
        public string ImageName { get; set; }
        [XmlElement("adv_image")]
        public string Image { get; set; }
        [XmlElement("adv_city_id")]
        public int CityId { get; set; }
        [XmlElement("adv_cityname")]
        public string CityName { get; set; }
    }
}
