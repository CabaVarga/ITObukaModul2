using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace Zad3
{
    class KvadratnaFunkcija : IFunkcija
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
        private double Diskriminanta { get; set; }

        public double[] NuleFunkcije()
        {
            double[] nule = null;

            if (A == 0)
            {
                // Linearna funkcija
                nule = (B != 0) ? new double[] { 0 - C / B } : null;
                return nule;
            }
            else if (Diskriminanta == 0)
            {
                nule = new double[] { -B / (2 * A) };
                return nule;
            }
            else if (Diskriminanta > 0)
            {
                nule = new double[2];
                nule[0] = (-B + Math.Sqrt(Math.Pow(B, 2) - (4 * A * C))) / 2 * A;
                nule[1] = (-B - Math.Sqrt(Math.Pow(B, 2) - (4 * A * C))) / 2 * A; ;
                return nule;
            }
            else if (Diskriminanta < 0)
            {
                nule = new double[4];
                nule[0] = (-B / (2 * A));
                nule[1] = (Math.Sqrt(4 * A * C) - Math.Pow(B, 2)) / (2 * A);
                nule[2] = nule[0];
                nule[3] = -nule[1];
                return nule;
            }
            return nule;
        }

        public bool RealneNule()
        {
            if (Diskriminanta >= 0)
            {
                if (A != 0)
                {
                    return true;
                }
                else
                {
                    if (B != 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }

            // return (Diskriminanta >= 0) ? (A != 0) ? true : (B != 0) ? true : false : false;
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
                C = Double.Parse(parametri[1], CultureInfo.InvariantCulture);
            }
            catch (Exception e)
            {
                Console.WriteLine("Nastala je greska kod citanja parametara za kvadratnu funkciju");
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }

            Diskriminanta = Math.Pow(B, 2) - (4 * A * C);
        }

        public double VrednostFunkcije(double x)
        {
            return A * Math.Pow(x, 2) + B * x + C;
        }
    }
}
