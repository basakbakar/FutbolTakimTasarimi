using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace futbol_ödev2
{
    class Forvet:Futbolcu
    {
        Random Rastgele_Forvet = new Random();//I created a randoom object.

        public double Bitiricilik;//I defined my variables which are only belong to Forvet class
        public double IlkDokunus;
        public double Kafa;
        public double OzelYetenek;
        public double Sogukkanlilik;

        public Forvet(string _AdSoyad, int _FormaNo):base(_AdSoyad,_FormaNo)//I assigned random numbers to my variables in the constructor.
        {
            Bitiricilik = Rastgele_Forvet.Next(70, 100);
            IlkDokunus = Rastgele_Forvet.Next(70, 100);
            Kafa = Rastgele_Forvet.Next(70, 100);
            OzelYetenek = Rastgele_Forvet.Next(70, 100);
            Sogukkanlilik = Rastgele_Forvet.Next(70, 100);
        }
        public override Boolean PasVer()//I created a PasVer method which returns true or false value.
        {
            double PasSkor = Pas * 0.3 + Yetenek * 0.2 + OzelYetenek * 0.2 + Dayaniklilik * 0.1 + DogalForm * 0.1 + Sans * 0.1;
            if (PasSkor > 60.00)
                return true;
            else
                return false;
        }

        public override Boolean GolVurusu()//I created a GolVurusu method which returnes a true or false value.
        {
            double GolSkor = Yetenek * 0.2 + OzelYetenek * 0.2 + Sut * 0.1 + Kafa * 0.1 + IlkDokunus * 0.1 + Bitiricilik * 0.1 + Sogukkanlilik * 0.1 + Kararlilik * 0.1 + DogalForm * 0.1 + Sans * 0.1;

            if (GolSkor > 70.00)
                return true;
            else
                return false;
        }
    }
}
