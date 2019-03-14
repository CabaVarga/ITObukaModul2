namespace Zad2
{
    class MobilnaMreza
    {
        public string ime;
        SimKartica[] sveSimKartice;
        int brojacKartica;

        public MobilnaMreza(string ime)
        {
            this.sveSimKartice = new SimKartica[100];
            this.ime = ime;
            this.brojacKartica = 0;
        }

        // b) i dodaci kod d)
        public void NovaSimKartica(string broj)
        {
            SimKartica kartica = new SimKartica(broj);
            kartica.PostaviMrezu(this);
            sveSimKartice[brojacKartica] = kartica;
            brojacKartica++;
        }
    }
}
