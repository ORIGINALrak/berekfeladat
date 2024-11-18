using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241118
{
    internal class Dolgozok
    {


        public string nev { get; set; }
        public bool neme { get; set; }
        public string reszleg { get; set; }
        public int belepes { get; set; }
        public int ber { get; set; }

        public override string ToString() => $" \n\tNév: {nev} \n\tNem:{(neme ? "férfi" : "nő")} \n\tBelépés: {belepes} \n\tBér: {ber}";
        public Dolgozok(string sr)
        {
            string[] d = sr.Split(';');
            nev = d[0];
            neme = d[1] == "férfi";
            reszleg = d[2];
            belepes = int.Parse(d[3]);
            ber = int.Parse(d[4]);
        }
    }
}
