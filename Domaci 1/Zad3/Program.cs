/*
 * Modelirati navedene klase, vodeći računa o pravilnom nasleđivanju. 
 * Nije neophodno pisati metode klasa. 
 * Implementirati konstruktore koji postavljaju inicijalne vrednosti atributa (ako ima smisla), 
 * i pozivati konstruktore superklase tamo gde ima smisla.

a. Fajl, Folder, Disk, Video, Slika, TekstualniFajl
b. GeometrijskiObjekat, Objekat2D, Objekat3D, pravougaonik, kvadrat, krug, lopta, kocka, kvadar

Za svaku tacku napraviti poseban fajl. Koristiti C# Propertije.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            TestFajlSistem();
            TestGeometrija();
        }

        // a)
        public static void TestFajlSistem()
        {
            Disk noviDisk = new Disk("C", new Folder("root"), 1024 * 256);
            Folder programi = new Folder("Programi", noviDisk.Root);
            Folder dokumenti = new Folder("Dokumenti", noviDisk.Root);
            Fajl os = new Fajl("win.exe", 1024, programi);
            Slika pozadina = new Slika("Bliss.jpg", 1024, 768, 4, dokumenti);
            Video daruda = new Video("Sandstorm.avi", new TimeSpan(0, 3, 52), 32, dokumenti);
            TekstualniFajl domaci = new TekstualniFajl("Program.cs", "UTF-8", 1, dokumenti);
        }

        public static void TestGeometrija()
        {
            kvadrat kvadrat = new kvadrat(10);
            krug krug = new krug(5);
            pravougaonik pravougaonik = new pravougaonik(10, 5);

            kocka kocka = new kocka(10);
            lopta lopta = new lopta(5);
            kvadar kvadar = new kvadar(10, 5, 20);

            Podaci2DObjekta(kvadrat);
            Podaci2DObjekta(krug);
            Podaci2DObjekta(pravougaonik);

            Podaci3DObjekta(kocka);
            Podaci3DObjekta(lopta);
            Podaci3DObjekta(kvadar);
        }

        public static void Podaci2DObjekta(Objekat2D obj)
        {
            Console.WriteLine("Obim {0}a: {1}", obj.Naziv, obj.Obim);
            Console.WriteLine("Povrsina {0}a: {1}", obj.Naziv, obj.Povrsina);
            Console.WriteLine("---");
        }

        public static void Podaci3DObjekta(Objekat3D obj)
        {
            Console.WriteLine("Povrsina {0}: {1}", obj.Naziv, obj.Povrsina);
            Console.WriteLine("Zapremina {0}: {1}", obj.Naziv, obj.Zapremina);
            Console.WriteLine("---");
        }
    }
}