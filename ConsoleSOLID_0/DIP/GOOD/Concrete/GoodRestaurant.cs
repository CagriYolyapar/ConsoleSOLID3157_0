using ConsoleSOLID_0.DIP.GOOD.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSOLID_0.DIP.GOOD.Concrete
{
    public class GoodRestaurant
    {

        //Bu versiyonda Restaurant sınıfı alt seviye modüllerden daha bagımsız bir hale gelecektir...Kendisine geliyorsa ona göre bir işlem yapacaktır...

        List<IProduct> _products;

        public GoodRestaurant(List<IProduct> products)
        {
            //Tighyly Coupled(sıkı sıkıya bagımlı olan) bir yapıyı burada loosely coupled (gevsek bir şekilde baglı olan) yapıya cevirmek icin kullandıgımız bu constructor based injection ile bir Dependency Injection algoritması uyguladık...

            _products = products;
        }

        public string GenerateInstructions()
        {
            string instructions = null;

            foreach (IProduct item in _products)
            {
                instructions += item.GetCookingInstructions()+"\n";
            }
            return $"{instructions}";
        }

    }
}
