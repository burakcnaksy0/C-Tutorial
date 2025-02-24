using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SqlConnection sınıfı, SQL Server ile bağlantı kurmak için kullanılır
            SqlConnection connection = new SqlConnection("Data Source = DESKTOP-BPR14S8\\SQLEXPRESS; initial Catalog = EgitimKampıDb; integrated security = true");

            // belirtilen SQL Server bağlantısını açar.
            connection.Open();

            // SQL sorgularını çalıştırmak için kullanılır.
            SqlCommand cmd = new SqlCommand("select * from TblProduct", connection);

            // Veritabanından veri çekmek ve DataTable'a aktarmak için bir köprü görevi görür
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            // Verileri geçici olarak tutacak bir tablo yapısı oluşturur
            DataTable dt = new DataTable();

            // SqlDataAdapter tarafından getirilen verileri dt adlı DataTable nesnesine doldurur.
            adapter.Fill(dt);

            connection.Close();

            foreach (DataRow dr in dt.Rows)
            {
                foreach (var item in dr.ItemArray)
                {
                    Console.Write(item.ToString());
                    Console.Write(' ');
                }
                Console.WriteLine();
            }

        }
    }
}
