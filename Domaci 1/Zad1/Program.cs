/* Napraviti klasu Macka , koja sadrži atribute: ime, majka i otac.
a. Ako majka i otac nisu prosleđeni, inicijalne vrednosti treba da budu stringovi “nepoznata” i “nepoznat” .
b. Napisati metod Mjau koji treba samo da ispiše “<ime> kaze mjau” .
c. Napisati konstruktor koji prima tri argumenta, ime, majku i oca. Ukoliko jedan ili oba roditelja nisu zadati, oni treba da budu nepoznati.
d. Napraviti objekat klase Macka, sa imenom Cvrle i nepoznatim roditeljima
*/
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            // d)
            Macka cvrle = new Macka("Cvrle");
        }
    }
}
