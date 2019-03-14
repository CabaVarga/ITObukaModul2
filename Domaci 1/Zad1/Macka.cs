/* Napraviti klasu Macka , koja sadrži atribute: ime, majka i otac.
a. Ako majka i otac nisu prosleđeni, inicijalne vrednosti treba da budu stringovi “nepoznata” i “nepoznat” .
b. Napisati metod Mjau koji treba samo da ispiše “<ime> kaze mjau” .
c. Napisati konstruktor koji prima tri argumenta, ime, majku i oca. Ukoliko jedan ili oba roditelja nisu zadati, oni treba da budu nepoznati.
d. Napraviti objekat klase Macka, sa imenom Cvrle i nepoznatim roditeljima
*/
using System;

namespace Zad1
{
    class Macka
    {
        // atributi trazeni u uvodu
        string ime;
        string majka = "nepoznata";
        string otac = "nepoznat";

        // konstruktor koji prihvata samo ime, ostavlja inicijalne vrednosti roditelja, prema a)
        // nisam siguran da li u konstruktoru pristupati direktno poljima ili kroz svojstva
        public Macka(string ime)
        {
            Ime = ime;
        }
                   
        // sto tice dela c) nismo jos radili opcionalne i imenovane parametre
        // zadatak implicira da je moguce zadati jednog, nijednog ili oba roditelja, pri tome
        // onda verovatno jedan roditelj takodje moze biti ili majka ili otac
        // to bi moglo ovako
        // ZANIMLJIVOST: Kada se kod kreiranja zada samo ime, ovaj konstruktor nece biti pozvan
        // vec onaj gornji
        public Macka(string ime, string majka = "nepoznata", string otac = "nepoznat")
        {
            Ime = ime;
            Majka = majka;
            Otac = otac;
        }

        // metoda Mjao, prema c)
        public void Mjau()
        {
            Console.WriteLine($"{Ime} kaze mjau");
        }

        // svojstva (properties)
        public string Ime { get => ime; private set => ime = value; }
        public string Majka { get => majka; private set => majka = value; }
        public string Otac { get => otac; private set => otac = value; }
    }
}
