using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace Zad1
{
    class Program
    {
        public static bool illustrateFlag = true;

        static void Main(string[] args)
        {
            // TestFunkcionalnosti();

            // TestSerijalizacijeJSON();               // OK! RADI!
            // TestSerijalizacijeNewtonsoftJSON();     // OK! RADI!
            TestSerijalizacijeBIN();

            Console.ReadKey();
        }

        static void TestFunkcionalnosti()
        {
            // TODO metod izbaciti, izdvojene su funkcionalnosti
            // Postoji nekoliko nacina, ovo je jedan od mogucih
            DirectoryInfo di = new DirectoryInfo(@"..\..\Orkestri");
            string path = Path.Combine(di.FullName, "GudackiKvartet.txt");

            try
            {
                Instrument[] gudacki = UcitajOrkestarTekst(path);
                Console.WriteLine("--- INSTRUMENTI SE STIMUJU ---");
                foreach (var i in gudacki)
                {
                    i.NastimujSe();
                }
                Console.WriteLine("--- ORKESTAR SVIRA ---");
                foreach (var i in gudacki)
                {
                    i.Sviraj();
                }
                Console.WriteLine("--- OSOBINE INSTRUMENATA U ORKESTRU ---");
                foreach (var i in gudacki)
                {
                    // Zbog virtualnih metoda je ovo suvisno
                    // Osobine(i);
                    i.Ispisi();
                    Console.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine("Neuspesno");
            }
        }

        /// <summary>
        /// Orkestar ce prvo nastimovati instrumente i zatim otpoceti sviranje.
        /// Predstavljanje osobina instrumenata je opcionalno.
        /// </summary>
        /// <param name="orkestar">Niz instrumenata.</param>
        /// <param name="predstavi">Ako je true svaki instrument ce se predstaviti.</param>
        static void StimajSvirajPredstavi(Instrument[] orkestar, bool predstavi)
        {
            try
            {
                Console.WriteLine("--- INSTRUMENTI SE STIMUJU ---");
                foreach (var i in orkestar)
                {
                    i.NastimujSe();
                }

                Console.WriteLine("--- ORKESTAR SVIRA ---");
                foreach (var i in orkestar)
                {
                    i.Sviraj();
                }
                
                if (predstavi)
                {
                    Console.WriteLine("--- OSOBINE INSTRUMENATA U ORKESTRU ---");
                    foreach (var i in orkestar)
                    {
                        // Zbog virtualnih metoda je ovo suvisno
                        // Osobine(i);
                        i.Ispisi();
                        Console.WriteLine();
                    }
                }
            }
            catch
            {
                Console.WriteLine("Neuspesno");
            }
        }

        #region Test brojaca
        static void TestBrojaca()
        {
            Instrument i1 = new Bubanj();
            Instrument i2 = new Viola();
            Console.WriteLine("Brojac: {0}", Instrument.brojac);
            TestBrojaca2();

            Console.WriteLine("Brojac posle metode: {0}", Instrument.brojac);
            // Evidentno je da ovaj nacin ne funkcionise kako je zamisljeno
            // Zbog sakupljanja smeca
        }

        static void TestBrojaca2()
        {
            Instrument i1 = new Bubanj();
            Instrument i2 = new Klavir();
            Console.WriteLine("Brojac unutar metode: {0}", Instrument.brojac);
            i1 = null;
            i2 = null;
            System.GC.Collect();
        }
        #endregion

        #region Testovi serijalizacije
        static void TestSerijalizacijeJSON()
        {
            // TODO try-catch klauzule
            DirectoryInfo di = new DirectoryInfo(@"..\..\Orkestri");
            string pathTXT = Path.Combine(di.FullName, "GudackiKvartet.txt");
            string pathJSON = Path.Combine(di.FullName, "GudackiKvartet.JSON");

            // TEST SNIMANJA
            Instrument[] gudacki = UcitajOrkestarTekst(pathTXT);
            SnimiOrkestarJSON(pathJSON, gudacki);

            // TEST UCITAVANJA
            Instrument[] kopija = UcitajOrkestarJSON(pathJSON);
            StimajSvirajPredstavi(kopija, true);

        }

        static void TestSerijalizacijeNewtonsoftJSON()
        {
            // TODO try-catch klauzule
            DirectoryInfo di = new DirectoryInfo(@"..\..\Orkestri");
            string pathTXT = Path.Combine(di.FullName, "GudackiKvartet.txt");
            string pathJSON = Path.Combine(di.FullName, "GudackiKvartet.JSON");

            // TEST SNIMANJA
            Instrument[] gudacki = UcitajOrkestarTekst(pathTXT);
            SnimiOrkestarNewtonsoftJSON(pathJSON, gudacki);

            // TEST UCITAVANJA
            Instrument[] kopija = UcitajOrkestarNewtonsoftJSON(pathJSON);
            StimajSvirajPredstavi(kopija, true);

        }

        static void TestSerijalizacijeBIN()
        {
            DirectoryInfo di = new DirectoryInfo(@"..\..\Orkestri");
            string pathTXT = Path.Combine(di.FullName, "GudackiKvartet.txt");
            string pathBIN = Path.Combine(di.FullName, "GudackiKvartet.DAT");

            // TEST SNIMANJA
            Instrument[] gudacki = UcitajOrkestarTekst(pathTXT);
            SnimiOrkestarBIN(pathBIN, gudacki);

            // TEST UCITAVANJA
            Instrument[] kopija = UcitajOrkestarBIN(pathBIN);
            StimajSvirajPredstavi(kopija, true);
        }
        #endregion

        #region Serijalizacija u i iz JSON, koriscenjem ugradjenih funkcija
        static void SnimiOrkestarJSON(string putanja, Instrument[] orkestar)
        {
            // morao sam dodati referencu na System.Web.Extensions.dll
            // na osnovu https://stackoverflow.com/questions/1156313/adding-system-web-script-reference-in-class-library
            // TODO try-catch klauzule
            var serializer = new JavaScriptSerializer();
            var rezultat = serializer.Serialize(orkestar);
            StreamWriter sw = new StreamWriter(putanja);
            sw.WriteLine(rezultat);
            sw.Close();
        }

        static Instrument[] UcitajOrkestarJSON(string putanja)
        {
            // TODO try-catch klauzula
            var serializer = new JavaScriptSerializer();

            StreamReader sr = new StreamReader(putanja);
            StringBuilder sb = new StringBuilder();
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                sb.AppendLine(line);
            }
            Console.WriteLine(sb.ToString());

            // AHA! GUBI SE POLIMORFIZAM, POKUSAVA PRAVITI INSTRUMENTE
            var deserializedResult = serializer.Deserialize<Instrument[]>(sb.ToString());
            return deserializedResult;
        }
        #endregion

        #region Serijalizacija u i iz JSON, koriscenjem biblioteke Json.NET
        static void SnimiOrkestarNewtonsoftJSON(string putanja, Instrument[] orkestar)
        {
            var jss = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            };

            var rezultat = JsonConvert.SerializeObject(orkestar, jss);
            StreamWriter sw = new StreamWriter(putanja);
            sw.WriteLine(rezultat);
            sw.Close();
        }

        static Instrument[] UcitajOrkestarNewtonsoftJSON(string putanja)
        {
            
            var jss = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            };
            
            StreamReader sr = new StreamReader(putanja);
            StringBuilder sb = new StringBuilder();
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                sb.AppendLine(line);
            }
            Console.WriteLine(sb.ToString());

            // AHA! GUBI SE POLIMORFIZAM, POKUSAVA PRAVITI INSTRUMENTE

            Instrument[] deserializedResult = JsonConvert.DeserializeObject<Instrument[]>(sb.ToString(), jss);
            return deserializedResult;
        }
        #endregion

        #region Serijalizacija u i iz BINarnog fajla
        static void SnimiOrkestarBIN(string putanja, Instrument[] orkestar)
        {
            FileStream fs = new FileStream(putanja, FileMode.Create);

            // odavde:
            // https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.formatters.binary.binaryformatter?view=netframework-4.7.2

            // Construct a BinaryFormatter and use it to serialize the data to the stream.
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, orkestar);
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

        static Instrument[] UcitajOrkestarBIN(string putanja)
        {
            // TODO Uradi za niz instrumenata
            // Declare the reference.
            Instrument[] orkestar = null;

            // Open the file containing the data that you want to deserialize.
            FileStream fs = new FileStream(putanja, FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                // Deserijalizuj bubanj iz fajla 
                // i dodeli referencu lokalnoj promenljivoj.
                orkestar = (Instrument[])formatter.Deserialize(fs);
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

            return orkestar;
        }
        #endregion

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
        static Instrument[] SimfonijskiOrkestar()
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

            return null;
        }

        static void TestA()
        {
            // TODO izbrisati
            Instrument bubanj = new Bubanj();
            // Koriscenjem virtuelne metode koja je implementirana u svim klasama
            bubanj.Ispisi();

            // Koriscenjem pomocne metode
            Osobine(bubanj);
            
        }

        #region Serijalizacija, tacnije snimanje u i iz TXT
        /// <summary>
        /// Snima orkestar u txt fajl. Prvi red sadrzi ime orkestra. Naredni redovi sadrze ime i funkciju svakog instrumenta.
        /// </summary>
        /// <param name="putanja">Putanja do fajla u koji se snima orkestar.</param>
        /// <param name="orkestar">Niz instrumenata.</param>
        /// <param name="imeOrkestra">Ime orkestra.</param>
        static void SnimiOrkestarTekst(string putanja, Instrument[] orkestar, string imeOrkestra)
        {
            // imeInstrumenta, tipInstrumenta, imaZice, imaDugmice, imaUdaraljke,
            // osnovaOdMetala, osnovaOdPlastike, osnovaOdDrveta,
            // mojaFunkcijaUOrkestru, NeophodanSamZaSimfonijksiOrkestar
            // pripadamOrkestruPoImenu...
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter(putanja);
                sw.WriteLine(imeOrkestra);

                foreach (var instr in orkestar)
                {
                    sw.Write(instr.ImeInstrumenta);
                    sw.Write(',');
                    sw.Write(((IFunkcijaUOrkestru)instr).MojaFunkcijaUOrkestru);
                    sw.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Snimanje neuspesno");

            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }

            // prednost prave serijalizacije je jednostavnost
            // sa druge strane na ovaj nacin mogu u txt fajlu
            // napraviti razne orkestre i ucitavanjem kreirati orkestar
            // pripadam orkestru po imenu moze biti prva linija
            // pa onda svi instrumenti imaju samo dva polja:
            // ime instrumenta i funkcija u orkestru           
        }

        static Instrument[] UcitajOrkestarTekst(string putanja)
        {
            // npr:
            StreamReader sr = null;
            string line;
            string[] data;
            Instrument instrument;
            Instrument[] nekiOrkestar;
            List<Instrument> lista = new List<Instrument>();

            try
            {
                sr = new StreamReader(putanja);

                // Ucitaj ime orkestra, prvi red...
                string ime = sr.ReadLine();

                while ((line = sr.ReadLine()) != null)
                {
                    data = line.Split(',');
                    // dovoljni su Ime instrumenta, MojaFunkcijaUOrkestru
                    switch (data[0])
                    {
                        // za svaki instrument poseban case
                        case "Bubanj":
                            {
                                instrument = new Bubanj();
                                IFunkcijaUOrkestru temp = instrument as IFunkcijaUOrkestru;
                                temp.MojaFunkcijaUOrkestru = data[1];
                                temp.PripadamOrkestruPoImenu = ime;
                                lista.Add(instrument);
                                break;
                            }
                        case "Flauta":
                            {
                                instrument = new Flauta();
                                IFunkcijaUOrkestru temp = instrument as IFunkcijaUOrkestru;
                                temp.MojaFunkcijaUOrkestru = data[1];
                                temp.PripadamOrkestruPoImenu = ime;
                                lista.Add(instrument);
                                break;
                            }
                        case "Harfa":
                            {
                                instrument = new Harfa();
                                IFunkcijaUOrkestru temp = instrument as IFunkcijaUOrkestru;
                                temp.MojaFunkcijaUOrkestru = data[1];
                                temp.PripadamOrkestruPoImenu = ime;
                                lista.Add(instrument);
                                break;
                            }
                        case "Horna":
                            {
                                instrument = new Horna();
                                IFunkcijaUOrkestru temp = instrument as IFunkcijaUOrkestru;
                                temp.MojaFunkcijaUOrkestru = data[1];
                                temp.PripadamOrkestruPoImenu = ime;
                                lista.Add(instrument);
                                break;
                            }
                        case "Klavir":
                            {
                                instrument = new Klavir();
                                IFunkcijaUOrkestru temp = instrument as IFunkcijaUOrkestru;
                                temp.MojaFunkcijaUOrkestru = data[1];
                                temp.PripadamOrkestruPoImenu = ime;
                                lista.Add(instrument);
                                break;
                            }
                        case "Kontrabas":
                            {
                                instrument = new Kontrabas();
                                IFunkcijaUOrkestru temp = instrument as IFunkcijaUOrkestru;
                                temp.MojaFunkcijaUOrkestru = data[1];
                                temp.PripadamOrkestruPoImenu = ime;
                                lista.Add(instrument);
                                break;
                            }
                        case "Ksilofon":
                            {
                                instrument = new Ksilofon();
                                IFunkcijaUOrkestru temp = instrument as IFunkcijaUOrkestru;
                                temp.MojaFunkcijaUOrkestru = data[1];
                                temp.PripadamOrkestruPoImenu = ime;
                                lista.Add(instrument);
                                break;
                            }
                        case "Saksofon":
                            {
                                instrument = new Saksofon();
                                IFunkcijaUOrkestru temp = instrument as IFunkcijaUOrkestru;
                                temp.MojaFunkcijaUOrkestru = data[1];
                                temp.PripadamOrkestruPoImenu = ime;
                                lista.Add(instrument);
                                break;
                            }
                        case "Timpani":
                            {
                                instrument = new Timpani();
                                IFunkcijaUOrkestru temp = instrument as IFunkcijaUOrkestru;
                                temp.MojaFunkcijaUOrkestru = data[1];
                                temp.PripadamOrkestruPoImenu = ime;
                                lista.Add(instrument);
                                break;
                            }
                        case "Trombon":
                            {
                                instrument = new Trombon();
                                IFunkcijaUOrkestru temp = instrument as IFunkcijaUOrkestru;
                                temp.MojaFunkcijaUOrkestru = data[1];
                                temp.PripadamOrkestruPoImenu = ime;
                                lista.Add(instrument);
                                break;
                            }
                        case "Truba":
                            {
                                instrument = new Truba();
                                IFunkcijaUOrkestru temp = instrument as IFunkcijaUOrkestru;
                                temp.MojaFunkcijaUOrkestru = data[1];
                                temp.PripadamOrkestruPoImenu = ime;
                                lista.Add(instrument);
                                break;
                            }
                        case "Tuba":
                            {
                                instrument = new Tuba();
                                IFunkcijaUOrkestru temp = instrument as IFunkcijaUOrkestru;
                                temp.MojaFunkcijaUOrkestru = data[1];
                                temp.PripadamOrkestruPoImenu = ime;
                                lista.Add(instrument);
                                break;
                            }
                        case "Viola":
                            {
                                instrument = new Viola();
                                IFunkcijaUOrkestru temp = instrument as IFunkcijaUOrkestru;
                                temp.MojaFunkcijaUOrkestru = data[1];
                                temp.PripadamOrkestruPoImenu = ime;
                                lista.Add(instrument);
                                break;
                            }
                        case "Violina":
                            {
                                instrument = new Violina();
                                IFunkcijaUOrkestru temp = instrument as IFunkcijaUOrkestru;
                                temp.MojaFunkcijaUOrkestru = data[1];
                                temp.PripadamOrkestruPoImenu = ime;
                                lista.Add(instrument);
                                break;
                            }
                        case "Violoncelo":
                            {
                                instrument = new Violoncelo();
                                IFunkcijaUOrkestru temp = instrument as IFunkcijaUOrkestru;
                                temp.MojaFunkcijaUOrkestru = data[1];
                                temp.PripadamOrkestruPoImenu = ime;
                                lista.Add(instrument);
                                break;
                            }
                        default:
                            {
                                throw new Exception();
                            }
                    }
                }
                nekiOrkestar = lista.ToArray();
            }
            catch
            {
                Console.WriteLine("Neuspesno ucitavanje");
                nekiOrkestar = null;
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }    
            }
           
            return nekiOrkestar;
        }
        #endregion

        /// <summary>
        ///  Ispisuje sve osobine instrumenta za proizvoljan instrument.
        /// </summary>
        /// <param name="instr">Proizvoljan instrument koji implementira interfejs 
        /// IFunkcijaUOrkestru</param>
        static void Osobine(Instrument instr)
        {
            // Da nisam ranije metodu Ispisi() proglasio virtuelnom i implementirao
            // dodatne funkcionalnosti u pojedinim konkretnim klasama
            // onda bih koristio ovu metodu. To je bila i originalna zamisao zadatka
            // ali sam ja pozurio i bespotrebno ubacio funkcionalnost u klase.
            instr.Ispisi();
            IFunkcijaUOrkestru inter = instr as IFunkcijaUOrkestru;
            Console.WriteLine("Moja funkcija u orkestru: " + inter.MojaFunkcijaUOrkestru);
            Console.WriteLine("Neophodan sam za simfonijski orkestar: " +
                ((inter.NeophodanSamZaSimfonijskiOrkestar) ? "DA" : "NE"));
            Console.WriteLine("Pripadam orkestru po imenu: " + inter.PripadamOrkestruPoImenu);
        }
    }
}