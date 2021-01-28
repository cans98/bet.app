using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bahisoyunu
{
    public class oyun
    {
        public oyuncu BirinciOyuncu { get; set; }
        public oyuncu IkinciOyuncu { get; set; }

        public void IlkOyuncuZarAt()
        {
            BirinciOyuncu.Oyna();
        }
        public void IkinciOyuncuZarAt()

        {
            IkinciOyuncu.Oyna();

        }
        public oyuncu Karsilastir()
        {
            int ToplamBahis;
            ToplamBahis = BirinciOyuncu.Bahis + IkinciOyuncu.Bahis;

            if(BirinciOyuncu.OyuncununZari.Deger > IkinciOyuncu.OyuncununZari.Deger)
            {
                BirinciOyuncu.Bakiye = BirinciOyuncu.Bakiye + IkinciOyuncu.Bahis;//birinci oyuncu ikinci oyuncunun bahsini alır
                IkinciOyuncu.Bakiye = IkinciOyuncu.Bakiye - IkinciOyuncu.Bahis;//birinci oyuncunun bakiyesi bahsi kadar azalır
               
                return BirinciOyuncu;
            }
            else if (BirinciOyuncu.OyuncununZari.Deger < IkinciOyuncu.OyuncununZari.Deger)
            {
                IkinciOyuncu.Bakiye = IkinciOyuncu.Bakiye + BirinciOyuncu.Bahis;//ikinci oyuncu birinci oyuncunun bahsini alır
                BirinciOyuncu.Bakiye = BirinciOyuncu.Bakiye - BirinciOyuncu.Bahis;//ikinci oyuncunun bakiyesi bahsi kadar azalır
                
               
                return IkinciOyuncu;
            }
            else 
            {
                return null;
            }

        }
        

    }
}
