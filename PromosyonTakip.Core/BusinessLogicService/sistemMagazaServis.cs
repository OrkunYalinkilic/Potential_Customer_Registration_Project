using PromosyonTakip.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PromosyonTakip.Core.BusinessLogicService
{
    public class sistemMagazaServis : BaseService<SistemMagaza>
    {
        Database.PromosyonSepeti db;

        public sistemMagazaServis()
        {
            db = new Database.PromosyonSepeti();
        }

        public int magazaKullaniciKontrol(string kullaniciAdi,string Sifre)
        {
            cmd = new SqlCommand("select id from sistemMagaza where kullaniciAdi=@kullaniciAdi and sifre=@sifre");
            cmd.Parameters.Add("@kullaniciAdi", SqlDbType.NVarChar).Value = kullaniciAdi;
            cmd.Parameters.Add("@sifre", SqlDbType.NVarChar).Value = Sifre;
            obj = db.kolonGetirHepsi(cmd); //dönen kullanıcıId degeri.
            return obj == null ? 0 : (int)obj; 
        }


    }
}
