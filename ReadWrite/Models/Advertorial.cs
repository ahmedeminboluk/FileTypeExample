using ReadWrite.Interfaces;
using ReadWrite.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ReadWrite
{
    [XmlRoot("Advertorial")]
    public class Advertorial : IEntity
    {
        [XmlElement("adv")]
        public List<Adv> Advs { get; set; }
    }
}
