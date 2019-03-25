using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class LinearnaFunkcija : IFunkcija
    {
        public double A { get; private set; }
        public double B { get; private set; }

        public double[] NuleFunkcije()
        {
            return (RealneNule()) ? new double[]{ 0 - B / A } : null;
        }

        public bool RealneNule()
        {
            return (A != 0) ? true : false;
        }

        public void UcitajParametre(string putanja)
        {
            StreamReader sr = null;
            string[] parametri = null;

            try
            {
                sr = new StreamReader(putanja);
                parametri = sr.ReadLine().Split(',');
                A = Double.Parse(parametri[0], CultureInfo.InvariantCulture);
                B = Double.Parse(parametri[1], CultureInfo.InvariantCulture);
            }
            catch (Exception e)
            {
                Console.WriteLine("Nastala je greska kod citanja parametara za linearnu funkciju");
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }

        public double VrednostFunkcije(double x)
        {
            return A * x + B;
        }
    }
}
