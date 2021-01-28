using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bahisoyunu
{
    public class zar
    {
        public int Deger { get; set; }

        public void At()
        {
            Random random = new Random();
            Deger = random.Next(1, 7); //enfazla 6 gelir
        }
    }
}
