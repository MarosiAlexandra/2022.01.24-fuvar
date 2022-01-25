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
            foreach ( sor in File.ReadAllLines("fuvar.css").Skip(1))

            {
                fuvarok.Add(new Fuvar(sor));
            }


            Console.ReadKey();
        }
    }
}
