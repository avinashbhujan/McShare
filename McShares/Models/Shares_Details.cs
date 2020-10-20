using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace McShares.Models
{
    [Serializable()]
    public class Shares_Details
    {
        [System.Xml.Serialization.XmlElement("Num_Shares")]
        public string Num_Shares { get; set; }

        [System.Xml.Serialization.XmlElement("Share_Price")]
        public string Share_Price { get; set; }
    }
}