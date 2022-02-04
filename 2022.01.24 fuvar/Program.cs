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
            //5.
            int bankkártya = 0;
            int készpénz = 0;
            foreach (var f in fuvarok)
            {
                if (f.fizetésmód == "bankkártya")
                {
                    bankkártya++;

                }
                if (f.fizetésmód == "készpénz")
                {
                    készpénz++;

                }
                Console.WriteLine($"3.feladat: {fuvarok.Count} fuvar");
            }
            //6.
            double ÖsszMérföld = 0;
            foreach (var f in fuvarok)
            {
                ÖsszMérföld += f.távolság;
            }
            Console.WriteLine($"6.feladat: {ÖsszMérföld * 1.6:0.00}km");


            Console.ReadKey();
        }
    }
}
