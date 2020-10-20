using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace McShares.Models
{
    [Serializable()]
    public class Mailing_Address
    {
        [System.Xml.Serialization.XmlElement("Address_Line1")]
        public string Address_Line1 { get; set; }

        [System.Xml.Serialization.XmlElement("Address_Line2")]
        public string Address_Line2 { get; set; }

        [System.Xml.Serialization.XmlElement("Town_City")]
        public string Town_City { get; set; }

        [System.Xml.Serialization.XmlElement("Country")]
        public string Country { get; set; }
    }
}