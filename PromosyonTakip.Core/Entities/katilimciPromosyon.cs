using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromosyonTakip.Core.Entities
{
   public  class katilimciPromosyon
    {
        public int id { get; set; }
        public int potansiyelMusteriID { get; set; }
        public int promosyonUrunID { get; set; }
        public int magazaID { get; set; }
        public DateTime olusturmaTarihi { get; set; }

    }
}
