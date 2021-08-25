using ReadWrite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ReadWrite
{
    [XmlRoot("Advertorial")]
    public class Advertorial
    {
        [XmlElement("adv")]
        public List<Adv> Advs { get; set; }
    }
}
