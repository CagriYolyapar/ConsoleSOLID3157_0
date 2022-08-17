using ConsoleSOLID_0.DIP.GOOD.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSOLID_0.DIP.GOOD.Concrete
{
    public class GoodMeat : IProduct
    {
        public string GetCookingInstructions()
        {
            return "İyi pişsin";
        }
    }
}
