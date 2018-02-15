using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CsvToXml
{
    public class ZakupWiersz
    {
        public ZakupWiersz()
        {
        }

        [XmlAttribute ("typ")] public string typZakupu;
        [XmlElement] public string LpZakupu;
        [XmlElement] public string NrDostawcy;
        [XmlElement] public string NazwaDostawcy;
        [XmlElement] public string AdresDostawcy;
        [XmlElement] public string DowodZakupu;
        [XmlElement] public string DataZakupu;
        [XmlElement] public string DataWplywu;
        [XmlElement] public string K_43;
        [XmlElement] public string K_44;
        [XmlElement] public string K_45;
        [XmlElement] public string K_46;
        [XmlElement] public string K_47;
        [XmlElement] public string K_48;
        [XmlElement] public string K_49;
        [XmlElement] public string K_50;

    }
}
