using PromosyonTakip.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromosyonTakip.Core.BusinessLogicService
{
    public class PromosyonUrunService : BaseService<promosyonUrun>
    {
        Database.PromosyonSepeti db;
        public PromosyonUrunService()
        {
            db = new Database.PromosyonSepeti();
        }

        public List<promosyonUrun> UrunListeGetir()
        {
            liste = new List<promosyonUrun>();
            cmd = new System.Data.SqlClient.SqlCommand("select top 42 *from promosyonUrun where kullanimDurum = 0 order by newid()");
            reader = db.Liste(cmd);
            while (reader.Read())
            {
                liste.Add(new promosyonUrun()
                {
                    id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                    tanim = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    aciklama = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                    gecerlilikTarihi = reader.IsDBNull(3) ? DateTime.MinValue : reader.GetDateTime(3),
                    kullanimDurum = reader.IsDBNull(4) ? false : reader.GetBoolean(4)
                });
            }
            reader.Close();
            db.BaglantiDurumuAyarla();
            return liste;
        }

        public promosyonUrun tekUrunGetir(int id)
        {
            data = new promosyonUrun();
            cmd = new System.Data.SqlClient.SqlCommand("select *from promosyonUrun where id=@id");
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            reader = db.Liste(cmd);
            while (reader.Read())
            {
                data.id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                data.tanim = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                data.aciklama = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                data.gecerlilikTarihi = reader.IsDBNull(3) ? DateTime.MinValue : reader.GetDateTime(3);
                data.kullanimDurum = reader.IsDBNull(4) ? false : reader.GetBoolean(4);
            }
            reader.Close();
            db.BaglantiDurumuAyarla();
            return data;
        }
    }
}
