using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CsvToXml
{
    public class ZakupCtrl
    {
        public ZakupCtrl()
        {
        }

        [XmlElement] public string LiczbaWierszyZakupow;
        [XmlElement] public string PodatekNaliczony;

    }
}
