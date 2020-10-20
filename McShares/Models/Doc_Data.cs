using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace McShares.Models
{
    [Serializable]
    public class Doc_Data
    {
        [XmlElement("DataItem_Customer")]
        public List<DataItem_Customer> DataItem_Customers { get; set; }
    }
}