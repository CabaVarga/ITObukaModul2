namespace Asistenti
{
    public class Asistent : Zaposleni {
        public Nastavnik mentor;
        public int godinaDoktorskihStudija;

        public Asistent(string ime, string prezime, Nastavnik mentor, int godinaDoktorskihStudija)
            : base (ime, prezime)
        {
            this.mentor = mentor;
            this.godinaDoktorskihStudija = godinaDoktorskihStudija;
        }

        public override double racunajPlatu()
        {
            return 40000 + (double)godinaDoktorskihStudija * 2000;
        }

        public override void predstaviSe()
        {
            System.Console.WriteLine("Ja sam {0} {1} i pohadjam {2}. godinu doktorskih studija. Mentor mi je " +
                "{3} {4} {5}", ime, prezime, godinaDoktorskihStudija, mentor.zvanje, mentor.ime, mentor.prezime );
        }
    }
}
