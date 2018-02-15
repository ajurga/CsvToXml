using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CsvToXml
{
    public class KodFormularza
    {
        public KodFormularza() { }
        [XmlText] public string kodFormularza;
        [XmlAttribute] public string wersjaSchemy;
        [XmlAttribute] public string kodSystemowy;
    }
}
