using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//@Author Yunus Emre Ertürk ===> yemrerturk@gmail.com / www.muhendiserturk.com

namespace Interface_Abstract
{   
    public abstract class Araba
    {

        private int agirlik;
        private string model;
        private string marka;

        public int Agirlik { get => agirlik; set => agirlik = value; }
        public string Model { get => model; set => model = value; }
        public string Marka { get => marka; set => marka = value; }

        //abstract method bu methodu mercedes ve ford siniflarında ezerek agirliklarina gore yaktikları benzin miktarlarini farklı bulacagim.Cunku her arabanın agırlıgına gore yaktıgı yakıt miktari degisir.
        public abstract int saatteYaktigiBenzinLitresi();

    }

    //Interface sayesinde herhangi bir kalıtım almadan bu ozelligi baska ustu acılan araba olmayan seylerede verebilirim.
    //Fakat hiç ustu acılmayan bir araba icin bu özelliği eklememe gerek yok Abstract sınıfının ıcındeki Tüm özellikler ŞAHİN için yeterli :)
    public class Mercedes: Araba,IArabaOzelligi
    {
        public void open()
        {
            Console.WriteLine("Ben Mercedes-C180'im tavanim açılır ! Araba tavanini açiyorum !");
        }

        public override int saatteYaktigiBenzinLitresi()
        {
            return Agirlik * 3;
        }
    }

    public class Ford : Araba ,IArabaOzelligi
    {
        public void open()
        {
            Console.WriteLine("Ben Ford-Focusum Benim sanrufum var! Sanrufu açıyorum !");
        }

        public override int saatteYaktigiBenzinLitresi()
        {
            return Agirlik * 4;
        }

       
    }

    public class KullaniciEkrani //Polymorphizm kullanarak yaptigim bir sinif.
    {
        
        public void goster(Araba[] arabalar)
        {
            for (int i = 0; i < arabalar.Length; i++)
            {          
                Araba araba = arabalar[i];
                Console.WriteLine("Arabanin Agirliği ---> " + araba.Agirlik);
                Console.WriteLine("Arabanin Markasi ---> " + araba.Marka);
                Console.WriteLine("Arabanin Modeli ---> " + araba.Model);
                Console.WriteLine("Araba Saatte Şu kadar Benzin yakiyor ---> " + araba.saatteYaktigiBenzinLitresi());
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine("------------------------------------------------------------------");
            }

        }


    }
}
