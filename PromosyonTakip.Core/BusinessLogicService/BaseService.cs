using PromosyonTakip.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromosyonTakip.Core.BusinessLogicService
{
    public class BaseService<T>
    {
       public SqlCommand cmd;
       public SqlDataReader reader;
       public int sonuc;
       public object obj;
       public List<T> liste;
       public T data;

    }
}
