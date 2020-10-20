using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace McShares.Models
{
    [Serializable()]
    public class Contact_Details
    {
        [System.Xml.Serialization.XmlElement("Contact_Name")]
        public string Contact_Name { get; set; }

        [System.Xml.Serialization.XmlElement("Contact_Number")]
        public string Contact_Number { get; set; }
    }
}