using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromosyonTakip.Core.Entities
{
   public  class potansiyelMusteri
    {
        public int id { get; set; }
        public string tcKimlikNo { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime dogumTarih { get; set; }
        public int cinsiyet { get; set; }
        public string meslek { get; set; }
        public string EMailAdres { get; set; }
        public bool EMailBildirimOnay { get; set; }
        public string telefon { get; set; }
        public bool telefonBildirimOnay { get; set; }
        public DateTime olusturmaTarihi { get; set; }
        public int olusturmaMagaza { get; set; }


    }

}
