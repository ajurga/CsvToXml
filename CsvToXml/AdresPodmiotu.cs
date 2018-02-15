using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CsvToXml
{
    public class AdresPodmiotu
    {
        public AdresPodmiotu()
        {
        }

        [XmlElement] public string KodKraju;
        [XmlElement] public string Wojewodztwo;
        [XmlElement] public string Powiat;
        [XmlElement] public string Gmina;
        [XmlElement] public string Ulica;
        [XmlElement] public string NrDomu;
        [XmlElement] public string NrLokalu;
        [XmlElement] public string Miejscowosc;
        [XmlElement] public string KodPocztowy;
        [XmlElement] public string Poczta;

    }
}
