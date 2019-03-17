namespace Asistenti
{
    public class NenastavniRadnik : Zaposleni {
        public string radnoMesto;
        public int godineStaza;

        public NenastavniRadnik(string ime, string prezime, string radnoMesto, int godineStaza):
            base(ime, prezime)
        {
            this.radnoMesto = radnoMesto;
            this.godineStaza = godineStaza;
        }

        public string RadnoMesto { get => radnoMesto; set => radnoMesto = value; }
        public int GodineStaza { get => godineStaza; set => godineStaza = value; }

        public override double racunajPlatu()
        {
            return 30000 + (double)godineStaza * 500;
        }

        public override void predstaviSe()
        {
            System.Console.WriteLine("Ja sam {0} {1}, {2} sa godinama staza = {3}",
                ime, prezime, radnoMesto, godineStaza);
        }
    }
}
