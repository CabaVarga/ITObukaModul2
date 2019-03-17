namespace Asistenti
{
    public class Zaposleni {
        public string ime;
        public string prezime;

        public Zaposleni(string ime, string prezime)
        {
            this.ime = ime;
            this.prezime = prezime;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }

        public virtual void predstaviSe() {
            System.Console.WriteLine("Moje ime je {0} {1}", ime, prezime);
        }

        public virtual double racunajPlatu() { return 3; }
    }

}
