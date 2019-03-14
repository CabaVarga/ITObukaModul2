namespace Zad2
{
    class SimKartica
    {
        string brojTelefona;
        MobilnaMreza mreza;

        // ovo je za a)
        public SimKartica(string broj)
        {
            this.brojTelefona = broj;
        }

        // c)
        public void PostaviMrezu(MobilnaMreza novaMreza)
        {
            this.mreza = novaMreza;
        }
    }
}
