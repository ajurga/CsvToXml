using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CsvToXml
{
    public class IdentyfikatorPodmiotu
    {
        public IdentyfikatorPodmiotu()
        {
        }

        [XmlElement] public string NIP;
        [XmlElement] public string PelnaNazwa;
        [XmlElement] public string REGON;
            

    }
}
