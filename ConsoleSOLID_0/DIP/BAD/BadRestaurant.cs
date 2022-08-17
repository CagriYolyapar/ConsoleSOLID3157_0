using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSOLID_0.DIP.BAD
{
    public class BadRestaurant
    {
        //Restaurant sınıfı High Level bir modüldür...Yalnız Low Level modüllerden olan baska sınıflara bagımlılıgı vardır...

        //Tightly Couples (sıkı sıkıya bagımlı)

        BadFish _tuna = new BadFish();

        BadChicken _tavuk = new BadChicken();


        public string TumTarifeler()
        {
            return $"{_tuna.GetFishCookingInstructions()} {_tavuk.GetChickenCookingInstructions()}";
        }
    }
}
