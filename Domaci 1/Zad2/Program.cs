/* Modelirati jednostavnu mobilnu mrežu:
a. Napraviti klasu SimKartica koja sadrži jedan atribut, brojTelefona (private), 
koji se setuje prilikom instanciranja objekta.
b. Napraviti klasu MobilnaMreza koja sadrzi ime (public, postavlja se prilikom kreiranja), 
i niz sim kartica sa nazivom sveSimKartice (private). 
Napisati metodu NovaSimKartica koja kreira objekat klase SimKartica i dodaje je u niz sveSimKartice.
c. U klasu SimKartica dodati novi private atribut mreza , 
i novu public metodu PostaviMrezu koja prima parametar novaMreza i postavlja ga u atribut mreza
d. Proširiti metodu NovaSimKartica da nakon kreiranja objekta 
postavlja i mrežu pozivom metode nad novokreiranim objektom.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zad2
{
    class Program
    {
        // ovo je samo test
        static void Main(string[] args)
        {
            MobilnaMreza nasaMreza = new MobilnaMreza("DekiTel");
            nasaMreza.NovaSimKartica("068456789");
            nasaMreza.NovaSimKartica("068123321");
        }
    }
}
