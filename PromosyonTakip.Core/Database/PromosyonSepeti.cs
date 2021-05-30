using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromosyonTakip.Core.Database
{
    public class PromosyonSepeti // Bu classın işi database gönderip-almak
    { 
        SqlConnection con;
        SqlDataReader reader;
        SqlCommand cmd;

        int returnInt;
        object returnObje;

        public PromosyonSepeti()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-O9HL0H1\SQLEXPRESS;Initial Catalog=PromosyonSepeti;Integrated Security=True");
        }

        public void BaglantiDurumuAyarla()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            else
                con.Close();
        }

        public int ekleDuzenleSil(SqlCommand cmd)
        {
            cmd.Connection = con;
            BaglantiDurumuAyarla();
            returnInt = cmd.ExecuteNonQuery();
            BaglantiDurumuAyarla();
            return returnInt;
        }

        public SqlDataReader Liste(SqlCommand cmd)
        {
            cmd.Connection = con;
            BaglantiDurumuAyarla();
            return cmd.ExecuteReader();
        }

        public object kolonGetirHepsi(SqlCommand cmd)
        {
            cmd.Connection =  con;
            BaglantiDurumuAyarla();
            returnObje = cmd.ExecuteScalar(); // null da gelebilir. O yüzden objeye atıyorum.
            BaglantiDurumuAyarla();
            return returnObje;
        }

    }
}
