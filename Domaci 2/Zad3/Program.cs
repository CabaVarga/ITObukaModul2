using System;
using System.IO;

namespace Zad3
{
    // PROJEKAT JE ZAD3, NE matematika, zbog preglednosti
    class Program
    {
        static void Main(string[] args)
        {
            IFunkcija linfun = new LinearnaFunkcija();
            IFunkcija kvadfun = new KvadratnaFunkcija();

            string putanjaLin = "";
            string putanjaKvad = "";
            DirectoryInfo di = new DirectoryInfo(@"..\..\Obrada");
            putanjaLin = Path.Combine(di.FullName, "funkcija1.txt");
            putanjaKvad = Path.Combine(di.FullName, "funkcija2.txt");

            linfun.UcitajParametre(putanjaLin);
            kvadfun.UcitajParametre(putanjaKvad);

            StreamWriter sr = null;

            // UPIS ZA LINEARNU FUNKCIJU
            try
            {
                putanjaLin = Path.Combine(di.FullName, "nule1.txt");
                sr = new StreamWriter(putanjaLin);
                if (!linfun.RealneNule())
                {
                    sr.WriteLine("Ne postoji realna nula funkcije");
                }
                else
                {
                    sr.WriteLine("Nula funkcije: {0:F4}", linfun.NuleFunkcije()[0]);
                }
            }
            catch
            {
                Console.WriteLine("Greska prilikom upisa nula funkcije");
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }

            // UPIS ZA KVADRATNU FUNKCIJU
            try
            {
                putanjaKvad = Path.Combine(di.FullName, "nule2.txt");
                sr = new StreamWriter(putanjaKvad);

                if (!kvadfun.RealneNule())
                {
                    sr.WriteLine("Ne postoji realna nula funkcije");
                }

                double[] nule = kvadfun.NuleFunkcije();

                if (nule == null)
                {
                    sr.WriteLine("Funkcija nema resenje za date parametre.");
                }
                else
                {
                    switch (nule.Length)
                    {
                        case 1:
                            {
                                sr.WriteLine("Nula funkcije: {0:F4}", kvadfun.NuleFunkcije()[0]);
                                break;
                            }
                        case 2:
                            {
                                sr.WriteLine("Prva  nula funkcije: {0:F4}", kvadfun.NuleFunkcije()[0]);
                                sr.WriteLine("Druga nula funkcije: {0:F4}", kvadfun.NuleFunkcije()[1]);
                                break;
                            }
                        case 4:
                            {
                                sr.Write("Prva nula funkcije:{0}\tRealni deo: {1:F4}{2}",
                                    Environment.NewLine,
                                    kvadfun.NuleFunkcije()[0],
                                    Environment.NewLine);
                                sr.WriteLine("\tImaginarni deo: {0:F4}i", kvadfun.NuleFunkcije()[1]);
                                sr.Write("Druga nula funkcije:{0}\tRealni deo: {1:F4}{2}",
                                    Environment.NewLine,
                                    kvadfun.NuleFunkcije()[2],
                                    Environment.NewLine);
                                sr.WriteLine("\tImaginarni deo: {0:F4}i", kvadfun.NuleFunkcije()[3]);
                                break;
                            }
                        default:
                            {
                                throw new InvalidDataException("Obrada niza nije uspela");
                            }
                    }
                }
            }
            catch (InvalidDataException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska prilikom upisa nula funkcije");
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }

            Console.ReadKey();
        }
    }
}
