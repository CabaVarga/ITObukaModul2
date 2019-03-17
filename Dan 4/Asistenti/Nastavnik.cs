namespace Asistenti
{
    public class Nastavnik : Zaposleni {
        public string zvanje;
        public int brojSCIRadova;

        public Nastavnik(string ime, string prezime, string zvanje, int brojSCIRadova) 
            : base(ime, prezime)
        {
            this.zvanje = zvanje;
            this.brojSCIRadova = brojSCIRadova;
        }

        public string Zvanje { get => zvanje; private set => zvanje = value; }
        public int BrojSCIRadova { get => brojSCIRadova; private set => brojSCIRadova = value; }

        public override double racunajPlatu()
        {
            return 60000 + (double)brojSCIRadova * 3000;
        }

        public override void predstaviSe()
        {
            System.Console.WriteLine("Ja sam {0} {1} {2}, sa brojem objavljenih radova = {3}", 
                zvanje, ime, prezime, brojSCIRadova);
        }
    }
}
