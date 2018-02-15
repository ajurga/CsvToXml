using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CsvToXml
{
    public class Podmiot1
    {
        public Podmiot1()
        {
        }
        [XmlElement("IdentyfikatorPodmiotu")] public IdentyfikatorPodmiotu Ip = new IdentyfikatorPodmiotu();
        [XmlElement("AdresPodmiotu")] public AdresPodmiotu Ap = new AdresPodmiotu();

    }
}
