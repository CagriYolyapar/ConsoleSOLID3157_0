using ConsoleSOLID_0.DIP.BAD;
using ConsoleSOLID_0.DIP.GOOD.Concrete;
using ConsoleSOLID_0.DIP.GOOD.Interfaces;
using ConsoleSOLID_0.LSP.BAD;
using ConsoleSOLID_0.LSP.GOOD.Abstract;
using ConsoleSOLID_0.LSP.GOOD.Concrete;
using ConsoleSOLID_0.LSP.GOOD.Interfaces;
using ConsoleSOLID_0.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSOLID_0
{
    class Program
    {
        /*
         
        S => Single Responsibility => Bir yapının tekil bir sorumluluga sahip olmasıdır(DantexCrypt, ImageUploader,MailService class'larınızın hepsinin görevi tektir...Baska bir sorumluluk almamıslardır...N-Tier paterninin katmanlarına bakabilirsiniz...Kullandıgımız metotlar hep tekil sorumluluktadır)
        
        O => Open Closed => Bir projenin gelişmeye açık değişime kapalı olmasıdır... Degişimden kastımız projenin normalde hicbir hata cıkarmayan ve güzel bir şekilde calısan kaynak kodlarının kökten modifiye edilmesidir... Bu sekilde proje degişiyorsa proje Open Closed prensibine aykırıdır. Proje eger gercekten gelişecek ise güzel bir şekilde calısan kodlar bozulmadan üzerine zarif eklemeler yapılarak gelişmesi gerekir...

        L => Liskov's Substitution => Bir yapılar kümesinin tek bir catı altında toplanması halinde bu catı icerisinde bulunan her nesnenin Base'teki tipinden kullanıldıgı zaman Base'deki her türlü davranısa sadık kalmasıdır...Yani BaseClass tipimizde bir koleksiyon yaratıyorsak ve bu koleksiyon icerisine farklı nesneler alıyorsak BaseClass tipinin her davranısı bu nesnelerin herbiri icin anlamlı eylemler olmak zorundadır...

        I => Interface Segregation => Yarattıgımız Interface'ler icerisinde implement edilmeyecek veya kullanılmayacak metotların yazılmaması gerektigini savunan bir prensiptir... Cünkü böyle yapmak Interface'in gereksiz kodlarla bogulmasına neden olacaktır...

        D => Dependency Inversion => Yüksek seviyeli bir modülün / yapının / class'ın alt seviyedeki bir modüle tightly coupled bir şekilde baglanmaması gerektigini savunan bir prensiptir... BU prensibe göre Interface destegi ile modülü loosely coupled bir hale getirmiş oluruz...Böylece bu modül baska yerlere gittiginde de rahatca adapte olabilecektir...
         
         
         
         
         
         
         
         
         
         */










        static void Main(string[] args)
        {

            #region LSPIhlali

            //List<Araba> arabalar = new List<Araba>
            //{
            //    new Tofas(), new Ferrari(), new Mercedes()
            //};


            //foreach (Araba item in arabalar)
            //{
            //    if(item is Tofas)
            //    {
            //        item.KlimaCalistir();
            //        continue;
            //    }
            //    item.KlimaCalistir();
            //}


            #endregion


            #region LSPUygun
            //List<ICleaner> klimaliArabalar = new List<ICleaner>
            // {
            //     new GoodFerrari()
            // };

            //List<GoodAraba> arabalar = new List<GoodAraba>
            //{
            //    new GoodFerrari(),new GoodTofas()
            //};


            //foreach (GoodAraba item in arabalar)
            //{
            //    item.Calistir();
            //}
            #endregion

            //List<ITelliSpec> telliCalgilar = new List<ITelliSpec>
            //{
            //    new Gitar()
            //};


            List<IProduct> urunler = new List<IProduct>
            {
                new GoodFastFood(),new GoodMeat(),new BadFish()
            };

            GoodRestaurant gr = new GoodRestaurant(urunler);


            Console.WriteLine(gr.GenerateInstructions());
            Console.ReadLine();

        }
    }
}
