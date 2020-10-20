using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace McShares.Models
{
    [Serializable]
    [System.Xml.Serialization.XmlRoot("RequestDoc")]
    public class RequestDoc
    {
        [System.Xml.Serialization.XmlElement("Doc_Date")]
        public string Doc_Date { get; set; }

        [System.Xml.Serialization.XmlElement("Doc_Ref")]
        public string Doc_Ref { get; set; }

        [System.Xml.Serialization.XmlElement("Doc_Data")]
        public Doc_Data Doc_Data { get; set; }
    }
}