using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CsvToXml
{
    public class SprzedazWiersz
    {
        
        public SprzedazWiersz()
        {
        }

        [XmlAttribute("typ")] public string typSprzedazy;
        [XmlElement] public string LpSprzedazy;
        [XmlElement] public string NrKontrahenta; 
        [XmlElement] public string NazwaKontrahenta;
        [XmlElement] public string AdresKontrahenta;
        [XmlElement] public string DowodSprzedazy;
        [XmlElement] public string DataWystawienia;
        [XmlElement] public string DataSprzedazy;
        [XmlElement] public string K_10;
        [XmlElement] public string K_11;
        [XmlElement] public string K_12;
        [XmlElement] public string K_13;
        [XmlElement] public string K_14;
        [XmlElement] public string K_15;
        [XmlElement] public string K_16;
        [XmlElement] public string K_17;
        [XmlElement] public string K_18;
        [XmlElement] public string K_19;
        [XmlElement] public string K_20;
        [XmlElement] public string K_21;
        [XmlElement] public string K_22;
        [XmlElement] public string K_23;
        [XmlElement] public string K_24;
        [XmlElement] public string K_25;
        [XmlElement] public string K_26;
        [XmlElement] public string K_27;
        [XmlElement] public string K_28;
        [XmlElement] public string K_29;
        [XmlElement] public string K_30;
        [XmlElement] public string K_31;
        [XmlElement] public string K_32;
        [XmlElement] public string K_33;
        [XmlElement] public string K_34;
        [XmlElement] public string K_35;
        [XmlElement] public string K_36;
        [XmlElement] public string K_37;
        [XmlElement] public string K_38;
        [XmlElement] public string K_39;

    }
}
