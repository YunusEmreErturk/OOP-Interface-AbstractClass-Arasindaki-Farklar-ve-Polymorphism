using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//@Author Yunus Emre Ertürk ===> yemrerturk@gmail.com / www.muhendiserturk.com

namespace Interface_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {

            Ford ford = new Ford();
            ford.Agirlik = 250;
            ford.Marka = "Ford";
            ford.Model = "Focus";

            Mercedes mercedes = new Mercedes();
            mercedes.Agirlik = 400;
            mercedes.Marka = "Mercedes";
            mercedes.Model = "C180";

            
            Console.WriteLine("Agirlik :" +ford.Agirlik);
            Console.WriteLine("Marka :" + ford.Marka);
            Console.WriteLine("Model :" + ford.Model);
            Console.WriteLine("100 Saatte Yaktigi Yakıt Miktari " + ford.saatteYaktigiBenzinLitresi() + " Litre");
            ford.open();

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------------");

            Console.WriteLine("Agirlik :" + mercedes.Agirlik);
            Console.WriteLine("Marka :" + mercedes.Marka);
            Console.WriteLine("Model :" + mercedes.Model);
            Console.WriteLine("10 Saatte Yaktigi Yakıt Miktari " + mercedes.saatteYaktigiBenzinLitresi()+ " Litre");
            mercedes.open();
            


            Console.ReadKey();


            //üst kısmı kapatarak bu blogu açip polymorphzm ile yaptigim gosterime de bakabilirsiniz.

            //Araba ford = new Ford();
            //ford.Agirlik = 250;
            //ford.Marka ="Ford";
            //ford.Model ="Focus";
            //ford.saatteYaktigiBenzinLitresi();

            //Araba mercedes = new Mercedes();
            //mercedes.Agirlik =400;
            //mercedes.Marka = "Mercedes";
            //mercedes.Model = "C180";
            //mercedes.saatteYaktigiBenzinLitresi();

            //Araba[] arabalar = new Araba[] { mercedes, ford };
            //KullaniciEkrani ekran = new KullaniciEkrani();
            //ekran.goster(arabalar);


            //Console.ReadKey();
        }
    }
}
