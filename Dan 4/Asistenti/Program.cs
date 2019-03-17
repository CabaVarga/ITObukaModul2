using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asistenti
{
    class Program
    {
        static void Main(string[] args)
        {
            Zaposleni profa = new Nastavnik("Milos", "Mirkovic", "prof. dr", 32);
            Zaposleni docent = new Nastavnik("Dusica", "Smiljkovic", "doc. dr", 55);
            Zaposleni pomocnik1 = new Asistent("Dusko", "Vasiljevic", (Nastavnik)profa, 1);
            Zaposleni pomocnik2 = new Asistent("Milica", "Vuckovic", (Nastavnik)docent, 3);
            Zaposleni sekretar = new NenastavniRadnik("Slobodan", "Milic", "sekretar", 35);

            Console.WriteLine("Plata = {0:C2}, za zaposlenog : ", profa.racunajPlatu());
            profa.predstaviSe();
            Console.WriteLine("-----------");
            Console.WriteLine("Plata = {0:C2}, za zaposlenog : ", docent.racunajPlatu());
            docent.predstaviSe();
            Console.WriteLine("-----------");
            Console.WriteLine("Plata = {0:C2}, za zaposlenog : ", pomocnik1.racunajPlatu());
            pomocnik1.predstaviSe();
            Console.WriteLine("-----------");
            Console.WriteLine("Plata = {0:C2}, za zaposlenog : ", pomocnik2.racunajPlatu());
            pomocnik2.predstaviSe();
            Console.WriteLine("-----------");
            Console.WriteLine("Plata = {0:C2}, za zaposlenog : ", sekretar.racunajPlatu());
            sekretar.predstaviSe();
            

        }
    }
}
