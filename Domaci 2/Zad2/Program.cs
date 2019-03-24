using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace Zad2
{
    class Program
    {
        // KAKO SE OVAJ PODATAK NIGDE NE CUVA PREMA ZADATKU
        // A NALAZI SE U PRVOM REDU DATOTEKE KOJA SE UCITAVA
        // KOD CITANJA NAREDNIH REDOVA (IZ KLASA) NIJE MOGUCE
        // NIKAKO DRUKCIJE PRISTUPITI NEGO OVAKO
        // (naravno, ne menjajuci strukturu klasa)
        public static double CenaRada { get; set; }
        // JOS JEDAN PROBLEM:
        // UpisiSpisakUDatoteku NE VIDI SPISAK RADNIKA!
        // JOS JEDNO STATICKO SVOJSTVO...
        public static Radnik[] SpisakRadnika { get; set; }

        /* JOS JEDAN VELIKI PROBLEM:
         * KARAKTER + ILI - SE POJAVLJUJE NA POCETKU LINIJE
         * KAKO CEMO ZNATI DA LI SE KORISTI ...
         * PRAKTICNO MORAMO NAPRAVITI OBJEKAT DA BISMO
         * PRISTUPILI METODU A JOS NE ZNAMO KOJI OBJEKAT...
         * OK, PEEK().
         */
         
             

        static void Main(string[] args)
        {
            // NAPOMENA:
            // UBACIVAO SAM TRY-CATCH LOGIKU
            // ONA JE NEKOMPATIBILNA SA VRACANJEM BOOL VREDNOSTI...
            
            // TODO 0.1: NAPRAVI FOLDER I FAJL NA PUTANJI
            string putanja = "";
            DirectoryInfo di = new DirectoryInfo(@"..\..\Radnici");
            string imeFajla = "spisak.txt";
            putanja = Path.Combine(di.FullName, imeFajla);

            // TODO 0.2: POPUNI FAJL PREMA UPUTSTVU ZADATKA:
            /*
            * U ulaznoj datoteci zapisana je najpre cena rada, 
            * zatim broj radnika u preduzeću, 
            * a zatim u sledećim redovima slede podaci o svim radnicima. 
            * 
            * Podaci o jednom radniku počinju linijom u kojoj je zapisan 
            * simbol + ili -. 
            * Simbol + označava da slede podaci o aktivnom radniku, 
            * a – da slede podaci o radniku koji se trenutno nalazi na bolovanju. 
            * 
            * Platni spisak ispisati u izlaznu datoteku plate.txt.
            */
     
            Radnik[] spisakRadnika = UcitajSpisakIzDatoteke(putanja);
            Program.SpisakRadnika = spisakRadnika;
            // TODO 4: Platni spisak ispisati u izlaznu datoteku plate.txt.
            imeFajla = "plate.txt";
            string putanja2 = Path.Combine(di.FullName, imeFajla);
            UpisiSpisakUDatoteku(putanja2);

            Console.ReadKey();
        }

        private static void UpisiSpisakUDatoteku(string putanja2)
        {

            // TODO 4.1: NAPRAVI NEKI STREAM ZA pisanje FAJLA
            // TODO 4.2: CITAJ OBJEKAT PO OBJEKAT IZ PRVOG SPISKA Radnik[] spisakRadnika
            //          I UPISUJ REDOM OBJEKAT PO OBJEKAT, U ODGOVARAJUCOJ STRUKUTRI
            //          OPISANOJ U 0.2
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(putanja2);
                foreach (var r in Program.SpisakRadnika)
                {
                    sw.WriteLine("{0} {1} {2} {3:C2}",
                        r.Ime.ToUpper(), r.Prezime.ToUpper(),
                        r.BrojTekucegRacuna, r.IzracunajPlatuRadnika());
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Greska prilikom upisa");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Niz je verovatno prazan");
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
            sw.Close();
        }

        private static Radnik[] UcitajSpisakIzDatoteke(string putanja)
        {

            // TODO 1: UCITAJ RADNIKE SA PUTANJE
            // TODO 1.1: NAPRAVI NEKI STREAM ZA CITANJE FAJLA
            // TODO 1.2: CITAJ RED PO RED I KREIRAJ OBJEKTE ODGOVARAJUCEG TIPA
            //              (MOZE BITI AKITVNI ILI RADNIK NA BOLOVANJU)
            // TODO 2: VRATI CEO NIZ KAO POVRATNU VREDNOST
            string line;
            string[] data;
            Radnik[] radnici = null;
            StreamReader sr = null;

            try
            {
                sr = new StreamReader(putanja);

                // procitaj prvi red i izvuci podatke
                line = sr.ReadLine();
                data = line.Split(',');
                Program.CenaRada = Double.Parse(data[0], CultureInfo.InvariantCulture);
                int brojRadnika = Int32.Parse(data[1]);
                Radnik radnik = null;

                // pripremi se za ucitavanje
                radnici = new Radnik[brojRadnika];
                int brojac = 0;

                // citaj ostale redove
                // jos jedan problem....
                while (true)
                {
                    if (sr.Peek() < 0) break;

                    char tipRadnika = (Char)sr.Peek();

                    switch (tipRadnika)
                    {
                        case '+':
                            {
                                radnik = new AktivanRadnik();
                                radnik.CitanjePodatakaORadniku(sr);
                                break;
                            }
                        case '-':
                            {
                                radnik = new RadnikNaBolovanju();
                                radnik.CitanjePodatakaORadniku(sr);
                                break;
                            }
                        default:
                            {
                                throw new InvalidDataException("Prvi znak nije + ili -");
                            }
                    }

                    // dodajemo radnika i povecavamo brojac
                    radnici[brojac] = radnik;
                    brojac++;
                }
            }
            catch (IOException e)
            {
                // TODO probaj prosiriti
                Console.WriteLine("Greska kod pokusaja citanja fajla");
            }
            catch (InvalidDataException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Greska prilikom obrade linije");
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }

            return radnici;
        }
    }

    abstract class Radnik
    {
        protected string ime;
        protected string prezime;
        protected string brojTekucegRacuna;
        protected double koeficijentStrucneSpreme;
        protected long jmbg;

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
        public string BrojTekucegRacuna
        {
            get { return brojTekucegRacuna; }
            set { brojTekucegRacuna = value; }
        }
        public double KoeficijentStrucneSpreme
        {
            get { return koeficijentStrucneSpreme; }
            set { koeficijentStrucneSpreme = value; }
        }
        public long JMBG
        {
            get { return jmbg; }
            set { jmbg = value; }
        }

        public virtual bool CitanjePodatakaORadniku(StreamReader rider)
        {
            bool retVal = false;
            try
            {
                string[] data = null;
                string line = rider.ReadLine();

                data = line.Split(',');
                // brisemo '-'
                data[0] = data[0].TrimStart('-');

                // punimo svojstva
                Ime = data[0];
                Prezime = data[1];
                BrojTekucegRacuna = data[2];
                KoeficijentStrucneSpreme = Double.Parse(data[3], CultureInfo.InvariantCulture);
                JMBG = Int64.Parse(data[4]);

                retVal = true;
            }
            catch (Exception e)
            {
                // izuzetak ce biti 'uhvacen' u pozivaocu, koji ce zatvoriti fajl
                retVal = false;
                throw;
            }
            return retVal;
        }

        public bool UpisUTekstualnuDatoteku(StreamWriter vrajter)
        {
            bool retVal = false;
            return retVal;
        }

        public abstract double IzracunajPlatuRadnika();
    }

    class AktivanRadnik : Radnik
    {
        private double varijabilniKoeficijent;
        public double VarijabilniKoeficijent
        {
            get => varijabilniKoeficijent;
            set => varijabilniKoeficijent = value;
        }

        public override double IzracunajPlatuRadnika()
        {
            // TODO 3.1: RACUNAJ PLATU PO OBRASCU
            return (KoeficijentStrucneSpreme + VarijabilniKoeficijent) * Program.CenaRada;
        }

        public override bool CitanjePodatakaORadniku(StreamReader rider)
        {
            bool retVal = false;

            try
            {
                string[] data = null;
                string line = rider.ReadLine();

                data = line.Split(',');
                // brisemo '+'
                data[0] = data[0].TrimStart('+');

                // punimo svojstva
                Ime = data[0];
                Prezime = data[1];
                BrojTekucegRacuna = data[2];
                KoeficijentStrucneSpreme = Double.Parse(data[3], CultureInfo.InvariantCulture);
                JMBG = Int64.Parse(data[4]);
                VarijabilniKoeficijent = Double.Parse(data[5], CultureInfo.InvariantCulture);

                retVal = true;
            }
            catch (Exception e)
            {
                // izuzetak ce biti 'uhvacen' u pozivaocu, koji ce zatvoriti fajl
                retVal = false;
                throw;
            }
            return retVal;
        }
    }

    class RadnikNaBolovanju : Radnik
    {
        public override double IzracunajPlatuRadnika()
        {
            // TODO 3.2: RACUNAJ PLATU PO OBRASCU
            return 0.8 * KoeficijentStrucneSpreme * Program.CenaRada;
        }
    }
}
