using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace McShares.Models
{
    public class ShareEntityManager
    {
        public static RequestDoc DeserializeShareFile(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(RequestDoc));

            StreamReader reader = new StreamReader(path);
            var requestDoc = (RequestDoc)serializer.Deserialize(reader);
            reader.Close();

            return requestDoc;
        }
    }
}