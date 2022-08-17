using ConsoleSOLID_0.DIP.GOOD.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSOLID_0.DIP.BAD
{
    public class BadFish:IProduct
    {
        public string GetCookingInstructions()
        {
            return "Cook fish well";
        }

        public string GetFishCookingInstructions()
        {
            return "Cook fish badly";
        }
    }
}
