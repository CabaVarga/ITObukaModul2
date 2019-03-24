using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Zad1
{
    class Program
    {
        public static bool illustrateFlag = true;

        static void Main(string[] args)
        {
            //TestA();
            //ZicaniInstument zicani = new Klavir();
            //zicani.Ispisi();
            //SnimiOrkestar();

            TestSerijalizacije();
            TestDeserijalizacije();
            Console.ReadKey();
        }

        static void TestSerijalizacije()
        {
            Bubanj bubanj = new Bubanj();

            FileStream fs = new FileStream(@"D:\ITBrains\DataFile.dat", FileMode.Create);

            // odavde:
            // https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.formatters.binary.binaryformatter?view=netframework-4.7.2

            // Construct a BinaryFormatter and use it to serialize the data to the stream.
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, bubanj);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }

        static void TestDeserijalizacije()
        {
            // Declare the hashtable reference.
            Bubanj bubanj;

            // Open the file containing the data that you want to deserialize.
            FileStream fs = new FileStream(@"D:\ITBrains\DataFile.dat", FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                // Deserijalizuj bubanj iz fajla 
                // i dodeli referencu lokalnoj promenljivoj.
                bubanj = (Bubanj)formatter.Deserialize(fs);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }

            bubanj.Ispisi();
        }

        static void OrkestarSvira()
        {
            // https://en.wikipedia.org/wiki/Orchestra#Modern_orchestra
            // Oboa i Klarinet su navedeni na spisku ali nismo (za sada) napravili te klase

            // Deklarisem instrumente

            // Dodajem svojstva iz IFunkcijaUOrkestru

            // Deklarisem niz i dodajem clanove

            //foreach (var instr in Orkestar)
            //{
            //    Osobine(instr);
            //}
        }

        /// <summary>
        /// Sastavljam (mali) simfonijski orkestar.
        /// </summary>
        static void SimfonijskiOrkestar()
        {
            // Deklarisem instrumente

            // DUVACKI INSTRUMENTI
            // Drveni duvacki instrumenti
            Instrument flauta1 = new Flauta();
            Instrument flauta2 = new Flauta();
            Instrument saksofon = new Saksofon();
            // Limeni duvacki instrumenti
            Instrument horna1 = new Horna();
            Instrument horna2 = new Horna();
            Instrument truba1 = new Truba();
            Instrument truba2 = new Truba();
            Instrument trombon1 = new Trombon();
            Instrument trombon2 = new Trombon();
            Instrument tuba = new Tuba();

            // UDARACKI INSTRUMENTI
            Instrument timpan = new Timpani();
            Instrument bubanj1 = new Bubanj();
            Instrument bubanj2 = new Bubanj();
            Instrument ksilofon = new Ksilofon();

            // ZICANI INSTRUMENTI
            Instrument klavir = new Klavir();
            Instrument harfa = new Harfa();
            Instrument violina1 = new Violina();
            Instrument violina2 = new Violina();
            Instrument violina3 = new Violina();
            Instrument violina4 = new Violina();
            Instrument viola1 = new Viola();
            Instrument viola2 = new Viola();
            Instrument violoncelo1 = new Violoncelo();
            Instrument violoncelo2 = new Violoncelo();
            Instrument kontrabas = new Kontrabas();
            
            // Dodajem svojstva iz IFunkcijaUOrkestru

            // Deklarisem niz i dodajem clanove
        }

        static void TestA()
        {
            Instrument bubanj = new Bubanj();
            // Koriscenjem virtuelne metode koja je implementirana u svim klasama
            bubanj.Ispisi();

            // Koriscenjem pomocne metode
            Osobine(bubanj);
            
        }

        static void SnimiOrkestar()
        {
            Instrument[] orkestar = new Instrument[]
            {
                new Violoncelo(),
                new Violina()
            };

            IFunkcijaUOrkestru ifun = orkestar[0] as IFunkcijaUOrkestru;
            ifun.MojaFunkcijaUOrkestru = "Drveni duvaci";
            ifun.PripadamOrkestruPoImenu = "Simfonijski neki";

            // imeInstrumenta, tipInstrumenta, imaZice, imaDugmice, imaUdaraljke,
            // osnovaOdMetala, osnovaOdPlastike, osnovaOdDrveta,
            // mojaFunkcijaUOrkestru, NeophodanSamZaSimfonijksiOrkestar
            // pripadamOrkestruPoImenu...
            string path = @"D:\ITBrains\orkestar.txt";
            StreamWriter sw = new StreamWriter(path);
            foreach (var instr in orkestar)
            {
                sw.Write(instr.ImeInstrumenta);
                sw.Write(',');
                sw.Write(instr.TipInstrumenta);
                sw.Write(',');
                sw.Write(((IFunkcijaUOrkestru)instr).MojaFunkcijaUOrkestru);
                sw.WriteLine();
            }
            sw.Close();

            // prednost prave serijalizacije je jednostavnost
            // sa druge strane na ovaj nacin mogu u txt fajlu
            // napraviti razne orkestre i ucitavanjem kreirati orkestar
            // pripadam orkestru po imenu moze biti prva linija
            // pa onda svi instrumenti imaju samo dva polja:
            // ime instrumenta i funkcija u orkestru

            // npr:
            StreamReader sr = new StreamReader(path);
            string line;
            string[] data;
            Instrument instrument;
            Instrument[] nekiOrkestar;
            List<Instrument> lista = new List<Instrument>();

            // hmm... prvo treba procitati fajl jednom,
            // da bi smo znali broj linija(koliki niz treba da pravimo)
            // ili: napravimo listu i onda samo pozovemo ToArray() metodu...
            while ((line = sr.ReadLine()) != null)
            {
                data = line.Split(',');
                // dovoljni su Ime instrumenta, MojaFunkcijaUOrkestru i PripadamOrkestruPoImenu
                switch (data[0])
                {
                    // za svaki instrument poseban case
                    case "Bubanj":
                        {
                            instrument = new Bubanj();
                            IFunkcijaUOrkestru temp = instrument as IFunkcijaUOrkestru;
                            temp.MojaFunkcijaUOrkestru = data[1];
                            temp.PripadamOrkestruPoImenu = data[2];
                            lista.Add(instrument);
                            break;
                        }
                    case "Flauta":
                        {
                            break;
                        }
                    case "Harfa":
                        {
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
        }

        /// <summary>
        ///  Ispisuje sve osobine instrumenta za proizvoljan instrument.
        /// </summary>
        /// <param name="instr">Proizvoljan instrument koji implementira interfejs 
        /// IFunkcijaUOrkestru</param>
        static void Osobine(Instrument instr)
        {
            instr.Ispisi();
            IFunkcijaUOrkestru inter = instr as IFunkcijaUOrkestru;
            Console.WriteLine("Moja funkcija u orkestru: " + inter.MojaFunkcijaUOrkestru);
            Console.WriteLine("Neophodan sam za simfonijski orkestar: " +
                ((inter.NeophodanSamZaSimfonijskiOrkestar) ? "DA" : "NE"));
            Console.WriteLine("Pripadam orkestru po imenu: " + inter.PripadamOrkestruPoImenu);
        }
    }
}
