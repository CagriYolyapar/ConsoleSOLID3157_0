using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSOLID_0.LSP.BAD
{
    public abstract class Araba
    {
        public string Calistir()
        {
            return "Araba calısıyor";
        }

        public virtual string KlimaCalistir()
        {
            return "Klima temizleniyor";
        }
    }
}
