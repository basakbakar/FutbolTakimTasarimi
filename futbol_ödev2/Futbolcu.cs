using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace futbol_ödev2
{
    class Futbolcu
    {
        Random Rastgele_Futbolcu = new Random();//I created an object from random function here. 

        public string AdSoyad;//I defined my variables here.
        public int FormaNo;
        public double Hiz;
        public double Dayaniklilik;
        public int Pas;
        public int Sut;
        public double Yetenek;
        public double Kararlilik;
        public double DogalForm;
        public double Sans;
        
        public Futbolcu(string _AdSoyad,int _FormaNo)//I assigned random numbers to my variables in the constructor.
        {
            AdSoyad = _AdSoyad;
            FormaNo = _FormaNo;
            Hiz = Rastgele_Futbolcu.Next(50, 100);
            Dayaniklilik = Rastgele_Futbolcu.Next(50, 100);
            Pas = Rastgele_Futbolcu.Next(50, 100);
            Sut = Rastgele_Futbolcu.Next(50, 100);
            Yetenek = Rastgele_Futbolcu.Next(50, 100);
            Kararlilik = Rastgele_Futbolcu.Next(50, 100);
            DogalForm = Rastgele_Futbolcu.Next(50, 100);
            Sans = Rastgele_Futbolcu.Next(50, 100);
        }

        public virtual Boolean PasVer()//I created a PasVer method which returns true or false value.
        {
            double PasSkor = Pas * 0.3 + Yetenek * 0.3 + Dayaniklilik * 0.1 + DogalForm * 0.1 + Sans * 0.2;

            if (PasSkor > 60.00)
                return true;
            else
                return false;
        }

        public virtual Boolean GolVurusu()//I created a GolVurusu method which returnes a true or false value.
        {
            double GolSkor = Yetenek * 0.3 + Sut * 0.2 + Kararlilik * 0.1 + DogalForm * 0.1 + Hiz * 0.1 + Sans * 0.2;

            if (GolSkor > 70.00)
                return true;
            else
                return false;
        }
    }
}