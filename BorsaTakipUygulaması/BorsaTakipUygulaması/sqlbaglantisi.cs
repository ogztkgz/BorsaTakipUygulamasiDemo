using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace BorsaTakipUygulaması
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-3IFB2RS\SQLEXPRESS;Initial Catalog=TTdatabase;Integrated Security=True");
            baglan.Open();
            return baglan;
        }

    }
}
