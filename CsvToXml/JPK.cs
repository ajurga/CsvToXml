using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CsvToXml
{

   
    public class JPK
    {
        public JPK()
        {
        }
        [XmlElement("Naglowek")] public Naglowek N = new Naglowek();
        [XmlElement("Podmiot1")] public Podmiot1 P1 = new Podmiot1();
        [XmlElement("SprzedazWiersz")] public List<SprzedazWiersz> Sw = new List<SprzedazWiersz>();
        [XmlElement("SprzedazCtrl")] public SprzedazCtrl Sc = new SprzedazCtrl();
        [XmlElement("ZakupWiersz")] public List<ZakupWiersz> Zw = new List<ZakupWiersz>();
        [XmlElement("ZakupCtrl")] public ZakupCtrl Zc = new ZakupCtrl();

    }
}
