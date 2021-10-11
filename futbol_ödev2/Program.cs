/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2018-2019 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:2
**				ÖĞRENCİ ADI............:Başak Bakar
**				ÖĞRENCİ NUMARASI.......:B171210075
**              DERSİN ALINDIĞI GRUP...:D
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace futbol_ödev2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Futbolcu> takim = new List<Futbolcu>();//I defined my soccer team's list here.
            takim.Add(new Defans("Serdar Aziz", 1));
            takim.Add(new Defans("Merih Demiral", 2));
            takim.Add(new Defans("Kaan Ayhan", 3));
            takim.Add(new Defans("Gokhan Gonul", 4));
            takim.Add(new OrtaSaha("Hakan Calhanoglu", 5));
            takim.Add(new OrtaSaha("Cengiz Under", 6));
            takim.Add(new OrtaSaha("Emre Belozoglu", 7));
            takim.Add(new OrtaSaha("Emre Akbaba", 8));
            takim.Add(new Forvet("Burak Yilmaz", 9));
            takim.Add(new Forvet("Cenk Tosun", 10));
            takim.Add(new Futbolcu("Mert Gunok", 11));

            Random rastgele = new Random();//I created a random object here.
            int Rastgele_Oyuncu = 0;//I defined a variable here.
            int i = 1;//I defined a counter here.
            do
            {
                int ara = Rastgele_Oyuncu;//I assigned Rastgele_Oyuncu variable to ara variable.
                Rastgele_Oyuncu = rastgele.Next(0, takim.Count);//I assigned a random variable to the Rastgele_Oyuncu variable.
                
                if (ara != Rastgele_Oyuncu)//I do this if statement for the players to be changed.If if random function choose the same number there won't be passing.
                {
                    Console.WriteLine(takim[Rastgele_Oyuncu].AdSoyad +" pası aldı.");
                    takim[Rastgele_Oyuncu].PasVer();//I called the PasVer method.
                    if (takim[Rastgele_Oyuncu].PasVer() == true)
                        Console.WriteLine("Pas basarili.");
                    else
                    {
                        Console.WriteLine("Pas basarisiz.");
                        break;
                    }
                    if (i == 3)//When the passing is over,
                    {
                        Console.WriteLine(takim[Rastgele_Oyuncu].AdSoyad+" atış denemesi yapıyor");
                        takim[Rastgele_Oyuncu].GolVurusu();//the last player will make a goal trying.
                        if (takim[Rastgele_Oyuncu].GolVurusu() == false)
                            Console.WriteLine("Atis denemesi basarisiz.");
                        else//if the goal trying is successful,
                            Console.WriteLine("GOLLLL " + takim[Rastgele_Oyuncu].AdSoyad + " " + takim[Rastgele_Oyuncu].FormaNo);//player's name and form number will be printed on the screen.
                    }
                    i++;
                }
                else continue;
            } while (i <= 3);

            Console.ReadKey();
        }
    }
}