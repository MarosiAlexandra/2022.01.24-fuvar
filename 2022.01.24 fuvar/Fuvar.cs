using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022._01._24_fuvar
{
    class Fuvar
    {
        public int TaxiID { get; set; }
        public string indulás  { get; set; }
        public int időtartam { get; set; }
        public double távolság { get; set; }
        public double viteldíj { get; set; }
        public double borravaló { get; set; }
        public string fizetésmód { get; set; }

        public Fuvar(string sor)
        {
            string[] t = sor.Split(';');
            TaxiID = int.Parse (t[0]);
            indulás =t[1];
            időtartam = int.Parse(t[2]);
            távolság = double.Parse(t[3]);
            viteldíj = double.Parse(t[4]);
            borravaló = double.Parse(t[5]);
            fizetésmód =t[6];


        }
    }
}
