/* Napisati apstraktnu klasu Instrument i u njoj obezbediti:
● konstruktor bez argumenata
● metod ispisi koji ispisuje sve osobine instrumenta
● apstraktne metode:
○ ImeInstrumenta,
○ TipInstrumenta,
○ Sviraj,
○ NastimujSe,
○ ImaZice,
○ ImaDugmice,
○ ImaUdaraljke,
○ OsnovaOdMetala,
○ OsnovaOdPlastike,
○ OsnovaOdDrveta.
*/
using System;

namespace Zad1
{
    [Serializable()]
    abstract class Instrument
    {
        public static int brojac = 0;
        // TODO konstruktor bez argumenata
        protected Instrument() {
            brojac++;
        }

        ~Instrument()
        {
            brojac--;
        }
        
        // TODO metod ispisi koji ispisuje sve osobine instrumenta
        public virtual void Ispisi() {
            // TODO prepraviti da bude citljivije?
            Console.WriteLine(
                "Ime instrumenta: " + ImeInstrumenta + "\n" +
                "Tip instrumenta: " + TipInstrumenta + "\n" +
                "Ima zice: " + ((ImaZice) ? "DA" : "NE") + "\n" +
                "Ima dugmice: " + ((ImaDugmice) ? "DA" : "NE") + "\n" +
                "Ima udaraljke: " + ((ImaUdaraljke) ? "DA" : "NE") + "\n" +
                "Osnova od metala: " + ((OsnovaOdMetala) ? "DA" : "NE") + "\n" +
                "Osnova od plastike: " + ((OsnovaOdPlastike) ? "DA" : "NE") + "\n" +
                "Osnova od drveta: " + ((OsnovaOdDrveta) ? "DA" : "NE"));
        }

        #region ApstraktneMetode
        // TODO apstraktne metode

        /// ImeInstrumenta
        public abstract string ImeInstrumenta { get; }

        // TipInstrumenta
        public abstract string TipInstrumenta { get; }

        // Sviraj
        public abstract void Sviraj();

        // NastimujSe
        public abstract void NastimujSe();

        // ImaZice
        public abstract bool ImaZice { get; }

        // ImaDugmice
        public abstract bool ImaDugmice { get; }

        // ImaUdaraljke
        public abstract bool ImaUdaraljke { get; }

        // OsnovaOdMetala
        public abstract bool OsnovaOdMetala { get; }

        // OsnovaOdPlastike
        public abstract bool OsnovaOdPlastike { get; }

        // OsnovaOdDrveta
        public abstract bool OsnovaOdDrveta { get; }

        #endregion
    }
}
