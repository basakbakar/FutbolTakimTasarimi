using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace futbol_ödev2
{
    class Defans:Futbolcu
    {
        Random Rastgele_Defans = new Random();//I created a randoom object.

        public double PozisyonAlma;//I defined my variables which are only belong to Defans class.
        public double Kafa;
        public double Sicrama;

        public Defans(string _AdSoyad, int _FormaNo): base(_AdSoyad, _FormaNo)//I assigned random numbers to my variables in the constructor.
        {
            PozisyonAlma = Rastgele_Defans.Next(50, 90);
            Kafa = Rastgele_Defans.Next(50, 90);
            Sicrama = Rastgele_Defans.Next(50, 90);
        }
        public override Boolean PasVer()//I created a PasVer method which returns true or false value.
        {
            double PasSkor = Pas * 0.3 + Yetenek * 0.3 + Dayaniklilik * 0.1 + DogalForm * 0.1 + PozisyonAlma * 0.1 + Sans * 0.2;

            if (PasSkor > 60.00)
                return true;
            else
                return false;
        }

        public override Boolean GolVurusu()//I created a GolVurusu method which returnes a true or false value.
        {
            double GolSkor = Yetenek * 0.3 + Sut * 0.2 + Kararlilik * 0.1 + DogalForm * 0.1 + Kafa * 0.1 + Sicrama * 0.1 + Sans * 0.1;

            if (GolSkor > 70.00)
                return true;
            else
                return false;
        }
    }
}