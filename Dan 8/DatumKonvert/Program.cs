using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatumKonvert
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputstr = @"
10, 1, '05-feb-2017', '20:00', 950, 1, 'Ljuba Tadic'
10, 2, '03-mar-2017', '20:00', 753, 1, 'Ljuba Tadic'
10, 3, '27-mar-2017', '20:00', 820, 1, 'Ljuba Tadic'
10, 4, '01-may-2017', '20:00', 950, 1, 'Ljuba Tadic'
10, 5, '17-may-2017', '20:00', 320, 7, 'Veliki oder'
10, 6, '01-jul-2017', '20:30', 1005, 6, 'Ljetnja pozornica - Tivat'
10, 7, '01-oct-2017', '20:00', 929, 1, 'Ljuba Tadic'
10, 8, '26-oct-2017', '20:00', 652, 1, 'Ljuba Tadic'
10, 9, '08-apr-2017', '19:30', 240, 5, 'Scena Joakim Vujic'
10, 10, '19-nov-2017', '19:30', 235, 5, 'Scena Joakim Vujic'
10, 11, '11-feb-2018', '20:00', 950, 1, 'Ljuba Tadic'
10, 12, '05-mar-2018', '20:00', 753, 1, 'Ljuba Tadic'
10, 13, '12-may-2018', '20:00', 820, 1, 'Ljuba Tadic'
20, 1, '03-jan-2018', '20:00', 950, 1, 'Ljuba Tadic'
20, 2, '15-mar-2018', '20:00', 903, 1, 'Ljuba Tadic'
20, 3, '29-mar-2018', '20:00', 575, 1, 'Ljuba Tadic'
20, 4, '17-may-2018', '20:30', 512, 8, 'Scena Narodnog pozorista u Nisu'
20, 5, '25-jul-2018', '21:00', 210, 6, 'Scena Atrijum'
30, 1, '13-nov-2017', '20:00', 842, 1, 'Ljuba Tadic'
30, 2, '01-dec-2017', '20:00', 895, 1, 'Ljuba Tadic'
30, 3, '14-jan-2018', '20:00', 936, 1, 'Ljuba Tadic'
30, 4, '01-mar-2018', '20:00', 950, 1, 'Ljuba Tadic'
30, 5, '21-may-2018', '20:00', 947, 1, 'Ljuba Tadic'
30, 6, '02-jun-2018', '20:00', 937, 1, 'Ljuba Tadic'
40, 1, '14-feb-2018', '20:00', 948, 1, 'Ljuba Tadic'
40, 2, '17-apr-2018', '20:00', 950, 1, 'Ljuba Tadic'
40, 3, '18-may-2018', '20:00', 755, 1, 'Ljuba Tadic'
50, 1, '30-jan-2017', '20:00', 950, 1, 'Ljuba Tadic'
50, 2, '18-mar-2017', '20:00', 899, 1, 'Ljuba Tadic'
50, 3, '28-jan-2018', '20:00', 698, 1, 'Ljuba Tadic'
50, 4, '19-nov-2018', '19:30', 212, 5, 'Scena Joakim Vujic'";

            string[] delimiters = { System.Environment.NewLine };
            string[] lines = inputstr.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            foreach (var s in lines)
            {
                // Console.WriteLine(s);
            }

            int kol = 2;

            for (int i = 0; i < lines.Length; i++)
            {
                string[] delims = { ", " };
                string[] tokens = lines[i].Split(delims, StringSplitOptions.RemoveEmptyEntries);
                tokens[0] = tokens[0].Trim();
                tokens[kol] = tokens[kol].Trim('\'');
                DateTime dt = DateTime.Parse(tokens[kol]);
                tokens[kol] = String.Format("{0:D4}-{1:D2}-{2:D2}", dt.Year, dt.Month, dt.Day);
                lines[i] = String.Join(", ", tokens);
            }

            foreach (var s in lines)
            {
                Console.WriteLine(s);
            }
        }
    }
}
