using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;
using System.IO;
using System.Xml.Serialization;

namespace CsvToXml
{
    class Program
    {
        static void Main(string[] args)
        {
            //odczyt pliku CSV
            Console.Write("Podaj ścieżkę do pliku typu CSV: ");
            string filepath = Console.ReadLine().Trim();

            if (filepath=="")
            {
                Console.WriteLine("Nie podano ściezki do pliku.");
                Environment.Exit(0);
            }

            var records = File.ReadAllLines(filepath);
            JPK ObiektJpk = new JPK();
            
            //Tworzenie list sprzedaży i zakupu
            List<SprzedazWiersz> ListaSprzedazWiersz = new List<SprzedazWiersz>();
            List<ZakupWiersz> ListaZakupWiersz = new List<ZakupWiersz>();
            
            ObiektJpk.Sw = ListaSprzedazWiersz;
            ObiektJpk.Zw = ListaZakupWiersz;

            //tworzenie elementów obiektu JPK
            for (int i = 1; i < records.Length; i++)
            {
                var line = records[i];
                string[] fields = line.Split(';');

                if ((fields[0] != ""))
                {
                    KodFormularza kodformularza = new KodFormularza()
                    {
                        kodFormularza = fields[0],
                        wersjaSchemy = fields[1],
                        kodSystemowy = fields[2]
                    };
                    ObiektJpk.N.kodFormularza = kodformularza;
                    ObiektJpk.N.WariantFormularza = fields[3];
                    ObiektJpk.N.CelZlozenia = fields[4];
                    ObiektJpk.N.DataWytworzeniaJPK = fields[5];
                    ObiektJpk.N.DataOd = fields[6];
                    ObiektJpk.N.DataDo = fields[7];
                    ObiektJpk.N.DomyslnyKodWaluty = fields[8];
                    ObiektJpk.N.KodUrzedu = fields[9];
                    continue;
                }
                if ((fields[10] != ""))
                {
                    IdentyfikatorPodmiotu danePodmiot1 = new IdentyfikatorPodmiotu()
                    {
                        NIP = fields[10],
                        PelnaNazwa = fields[11],
                        REGON = fields[12]
                    };
                    ObiektJpk.P1.Ip = danePodmiot1;
                    continue;
                }
                if ((fields[13] != ""))
                {
                    AdresPodmiotu daneAdresPodmiotu = new AdresPodmiotu()
                    {
                        KodKraju = fields[13],
                        Wojewodztwo = fields[14],
                        Powiat = fields[15],
                        Gmina = fields[16],
                        Ulica = fields[17],
                        NrDomu = fields[18],
                        NrLokalu = fields[19],
                        Miejscowosc = fields[20],
                        KodPocztowy = fields[21],
                        Poczta = fields[22]
                    };
                    ObiektJpk.P1.Ap = daneAdresPodmiotu;
                    continue;
                }
                if ((fields[23] != ""))
                {
                    ListaSprzedazWiersz.Add(new SprzedazWiersz() {
                        typSprzedazy = fields[23],
                        LpSprzedazy = fields[24],
                        NrKontrahenta = fields[25],
                        NazwaKontrahenta = fields[26],
                        AdresKontrahenta = fields[27],
                        DowodSprzedazy = fields[28],
                        DataWystawienia = fields[29],
                        DataSprzedazy = fields[30],
                        K_10 = fields[31],
                        K_11 = fields[32],
                        K_12 = fields[33],
                        K_13 = fields[34],
                        K_14 = fields[35],
                        K_15 = fields[36],
                        K_16 = fields[37],
                        K_17 = fields[38],
                        K_18 = fields[39],
                        K_19 = fields[40],
                        K_20 = fields[41],
                        K_21 = fields[42],
                        K_22 = fields[43],
                        K_23 = fields[44],
                        K_24 = fields[45],
                        K_25 = fields[46],
                        K_26 = fields[47],
                        K_27 = fields[48],
                        K_28 = fields[49],
                        K_29 = fields[50],
                        K_30 = fields[51],
                        K_31 = fields[52],
                        K_32 = fields[53],
                        K_33 = fields[54],
                        K_34 = fields[55],
                        K_35 = fields[56],
                        K_36 = fields[57],
                        K_37 = fields[58],
                        K_38 = fields[59],
                        K_39 = fields[60]
                    });
                }
                if ((fields[61] != ""))
                    {
                        ObiektJpk.Sc.LiczbaWierszySprzedazy = fields[61];
                        ObiektJpk.Sc.PodatekNalezny = fields[62];
   
                    }

                if ((fields[63] != ""))
                {
                    ListaZakupWiersz.Add(new ZakupWiersz()
                    {
                        typZakupu = fields[63],
                        LpZakupu = fields[64],
                        NrDostawcy = fields[65],
                        NazwaDostawcy = fields[66],
                        AdresDostawcy = fields[67],
                        DowodZakupu = fields[68],
                        DataZakupu = fields[69],
                        DataWplywu = fields[70],
                        K_43 = fields[71],
                        K_44 = fields[72],
                        K_45 = fields[73],
                        K_46 = fields[74],
                        K_47 = fields[75],
                        K_48 = fields[76],
                        K_49 = fields[77],
                        K_50 = fields[78]
                    });
                }
                if ((fields[79] != ""))
                    {
                        ObiektJpk.Zc.LiczbaWierszyZakupow = fields[79];
                        ObiektJpk.Zc.PodatekNaliczony = fields[80];
                    }
            }

           //przestrzenie nazw
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            
            ns.Add("tns", "http://jpk.mf.gov.pl/wzor/2016/10/26/10261/");
            ns.Add("kck", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2013/05/23/eD/KodyCECHKRAJOW/");
            ns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
            ns.Add("etd", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2016/01/25/eD/DefinicjeTypy/");
            XmlSerializer xs = new XmlSerializer(typeof(JPK));

            // zapisywanie do pliku XML
            string pathToFileXML = Path.GetDirectoryName(filepath) + "\\" + Path.GetFileNameWithoutExtension(filepath) + ".xml";
            TextWriter s = new StreamWriter(pathToFileXML);
            xs.Serialize(s, ObiektJpk, ns);

            //komunikat o zakończeniu przetwarzania pliku
            Console.WriteLine("Plik CSV został zapisany do formatu XML.");
        }
    }
}
