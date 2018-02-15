using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CsvToXml
{
    public class Naglowek
    {
        public Naglowek()
        {
        }

        public KodFormularza kodFormularza = new KodFormularza();
        [XmlElement] public string WariantFormularza;
        [XmlElement] public string CelZlozenia;
        [XmlElement] public string DataWytworzeniaJPK;
        [XmlElement] public string DataOd;
        [XmlElement] public string DataDo;
        [XmlElement] public string DomyslnyKodWaluty;
        [XmlElement] public string KodUrzedu;
    }
}
