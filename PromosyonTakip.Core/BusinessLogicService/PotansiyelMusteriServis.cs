using PromosyonTakip.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromosyonTakip.Core.BusinessLogicService
{
    class PotansiyelMusteriServis : BaseService<PotansiyelMusteriServis>
    {
        Database.PromosyonSepeti db;

        public PotansiyelMusteriServis()
        {
            db = new Database.PromosyonSepeti();
        }

        public int kayitYeni(potansiyelMusteri data)
        {
            cmd = new SqlCommand("insert into potansiyelMusteri values(@tcKimlikNumara,@isim,@soyisim,@dogumTarih,@cinsiyet,@meslek,@emailAdres,@emailBildirimOnay,@telefon,@telefonBildirimOnay,@olusturmaTarihi,@olusturmaMagaza)");
            cmd.Parameters.Add("@tcKimlikNumara", SqlDbType.NVarChar).Value = data.tcKimlikNo;
            cmd.Parameters.Add("@isim", SqlDbType.NVarChar).Value = data.isim;
            cmd.Parameters.Add("@soyisim", SqlDbType.NVarChar).Value = data.soyisim;
            cmd.Parameters.Add("@dogumTarih", SqlDbType.DateTime).Value = data.dogumTarih;
            cmd.Parameters.Add("@cinsiyet", SqlDbType.Int).Value = data.cinsiyet;
            cmd.Parameters.Add("@meslek", SqlDbType.NVarChar).Value = data.meslek;
            cmd.Parameters.Add("@emailAdres", SqlDbType.NVarChar).Value = data.EMailAdres;
            cmd.Parameters.Add("@emailBildirimOnay", SqlDbType.Bit).Value = data.EMailBildirimOnay;
            cmd.Parameters.Add("@telefon", SqlDbType.NVarChar).Value = data.telefon;
            cmd.Parameters.Add("@telefonBildirimOnay", SqlDbType.Bit).Value = data.telefonBildirimOnay;
            cmd.Parameters.Add("@olusturmaTarihi", SqlDbType.DateTime).Value = data.olusturmaTarihi;
            cmd.Parameters.Add("@olusturmaMagaza", SqlDbType.Int).Value = data.olusturmaMagaza;
            sonuc = db.ekleDuzenleSil(cmd);
            return sonuc;
        }

        public int TCSorgula(string tcKimlikNumara)
        {
            cmd = new SqlCommand("select id from potansiyelMusteri where tcKimlikNumara=@tcKimlikNo");
            cmd.Parameters.Add("@tcKimlikNo", SqlDbType.NVarChar).Value = tcKimlikNumara;
            obj = db.kolonGetirHepsi(cmd); // id null da olabilir o yüzden objeye atıyorum.
            return obj == null ? 0 : (int)obj;
        }
    }
}
