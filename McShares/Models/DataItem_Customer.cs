using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace McShares.Models
{
    [Serializable()]
    public class DataItem_Customer
    {
        [System.Xml.Serialization.XmlElement("customer_id")]
        public string Customer_id { get; set; }

        [System.Xml.Serialization.XmlElement("Customer_Type")]
        public string Customer_Type { get; set; }

        [System.Xml.Serialization.XmlElement("Date_Of_Birth")]
        public string Date_Of_Birth { get; set; }

        [System.Xml.Serialization.XmlElement("Date_Incorp")]
        public string Date_Incorp { get; set; }

        [System.Xml.Serialization.XmlElement("Registration_No")]
        public string Registration_No { get; set; }

        [System.Xml.Serialization.XmlElement("Mailing_Address")]
        public Mailing_Address Mailing_Address { get; set; }

        [System.Xml.Serialization.XmlElement("Contact_Details")]
        public Contact_Details Contact_Details { get; set; }

        [System.Xml.Serialization.XmlElement("Shares_Details")]
        public Shares_Details Shares_Details { get; set; }
    }
}