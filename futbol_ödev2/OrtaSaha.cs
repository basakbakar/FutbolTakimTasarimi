using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace futbol_ödev2
{
    class OrtaSaha:Futbolcu
    {
        Random Rastgele_OrtaSaha = new Random();//I created a randoom object.

        public double UzunTop;//I defined my variables which are only belong to OrtaSaha class.
        public double IlkDokunus;
        public double TopSurme;
        public double OzelYetenek;

        public OrtaSaha(string _AdSoyad, int _FormaNo):base(_AdSoyad, _FormaNo)//I assigned random numbers to my variables in the constructor.
        {
            UzunTop = Rastgele_OrtaSaha.Next(60, 100);
            IlkDokunus = Rastgele_OrtaSaha.Next(60, 100);
            TopSurme = Rastgele_OrtaSaha.Next(60, 100);
            OzelYetenek = Rastgele_OrtaSaha.Next(60, 100);
        }
        public override Boolean PasVer()//I created a PasVer method which returns true or false value.
        {
            double PasSkor = Pas * 0.3 + Yetenek * 0.2 + OzelYetenek * 0.2 + Dayaniklilik * 0.1 + DogalForm * 0.1 + UzunTop * 0.1 + TopSurme * 0.1 + Sans * 0.1;
            if (PasSkor > 60.00)
                return true;
            else
                return false;
        }

        public override Boolean GolVurusu()//I created a GolVurusu method which returnes a true or false value.
        {
            double GolSkor = Yetenek * 0.3 + OzelYetenek * 0.2 + Sut * 0.2 + IlkDokunus * 0.1 + Kararlilik * 0.1 + DogalForm * 0.1 + Sans * 0.1;

            if (GolSkor > 70.00)
                return true;
            else
                return false;
        }
    }
}