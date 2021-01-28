using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bahisoyunu
{
    public class oyuncu
    {
        public string Ad { get; set; }
        public zar OyuncununZari { get; set; }

        public int Bakiye { get; set; }

        public int Bahis { get; set; }


        public void Oyna()
        {
            OyuncununZari.At();
        }
        public oyuncu()
        {
          
        }
        public oyuncu(string ad, int bahis)
        {
            Ad = ad;
            Bahis = bahis;
            
        }
        public oyuncu(string ad)
        {
            Ad = ad;
            
        }
        public oyuncu(int bahis)
        {
            Bahis = bahis;

        }
        

    }
}
