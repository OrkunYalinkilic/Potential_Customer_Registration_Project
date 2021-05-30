using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromosyonTakip.Core.Entities
{
    public class Cinsiyet
    {
        public int id { get; set; } // cinsiyet degeri tanımdan gelsin istiyorum.
        public string tanim { get; set; }

        public override string ToString()
        {
            return tanim;
        }
    }
}
