using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2022._01._24_fuvar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fuvar> fuvarok = new List<Fuvar>();
            foreach (var sor in File.ReadAllLines("fuvar.csv").Skip(1))
            {
                fuvarok.Add(new Fuvar(sor));
            }

            Console.WriteLine($"3.feladat : {fuvarok.Count}");

            //4. 
            int db = 0;
            double bevétel = 0;
            foreach (var f in fuvarok)
            {
                if (f.TaxiID == 6185)
                {
                    db++;
                    bevétel += f.viteldíj + f.borravaló;

                }

            }

            Console.WriteLine($"4.feladat:{db} fuvar alatt {bevétel}$");

            Console.ReadKey();
        }
    }
}
