using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region kategori ekleme
            //Console.WriteLine("eklemek istediğiniz kategoriyi seçiniz : ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source = DESKTOP-BPR14S8\\SQLEXPRESS; initial catalog = EgitimKampıDb; integrated security = true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();

            //SqlCommand cmd = new SqlCommand("insert into TblCategory(CategoryName) values (@p1)", connection);
            //cmd.Parameters.AddWithValue(())
            //connection.Close();


            //Console.WriteLine("kategori başarıyla eklendi.");
            //Console.Read();
            #endregion

            #region ürün ekleme 

            //string productName;
            //decimal productStock;
            //bool productStatus;

            //Console.WriteLine("ürünün adını giriniz : ");
            //productName = Console.ReadLine();

            //Console.WriteLine("ürünün fiyatını giriniz : ");
            //productStock = int.Parse(Console.ReadLine());

            //Console.WriteLine("ürünün durumunu giriniz : ");
            //productStatus = bool.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source = DESKTOP-BPR14S8\\SQLEXPRESS; initial catalog = EgitimKampıDb; integrated security = true");
            //connection.Open();

            //SqlCommand cmd = new SqlCommand("insert into TblProduct(ProductName,ProductStock,ProductStatus) values " +
            //    "(@ProductName,@ProductStock,@ProductStatus)", connection);
            //cmd.Parameters.AddWithValue("@ProductName", productName);
            //cmd.Parameters.AddWithValue("@ProductStock", productStock);
            //cmd.Parameters.AddWithValue("@ProductStatus", productStatus);
            //cmd.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("eklendii");  


            #endregion

            #region ürün listeleme
            //SqlConnection connection = new SqlConnection("Data source = DESKTOP-BPR14S8\\SQLEXPRESS; initial catalog = EgitimKampıDb; integrated security = true");
            //connection.Open();

            //SqlCommand cmd = new SqlCommand("select * from TblProduct", connection);

            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            //DataTable dt = new DataTable();

            //adapter.Fill(dt);

            //foreach (DataRow dr in dt.Rows) // Tablodaki her satır için döner
            //{
            //    foreach (var item in dr.ItemArray) // Satırdaki her sütun için döner
            //    {
            //        Console.Write(item.ToString() + "  ");
            //    }
            //    Console.WriteLine(); // Yeni satıra geç
            //}

            //connection.Close();






            #endregion

            #region ürün silme işlemi

            //Console.WriteLine("silinecek olan ürünün ıd değerinin giriniz : ");
            //int productId = int.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data source = DESKTOP-BPR14S8\\SQLEXPRESS; initial catalog = EgitimKampıDb; integrated security = true");
            //connection.Open();

            //SqlCommand cmd = new SqlCommand("delete from TblProduct where ProductId = @productId",connection);
            //cmd.Parameters.AddWithValue("@productId", productId);
            //cmd.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine(productId + " ıd değerine sahip ürün silindi..");


            #endregion

            #region ürün güncelleme işlemi

            Console.WriteLine("Değiştirmek istediğiniz ürünün ıd değerini giriniz : ");
            int productId = int.Parse(Console.ReadLine());

            Console.WriteLine("yeni ürün adını giriniz : ");
            string productName = Console.ReadLine();

            Console.WriteLine("yeni ürün sayısını giriniz : ");
            int productStock = int.Parse(Console.ReadLine());   

            Console.WriteLine("yeni yeni ürün durumunu giriniz : ");
            bool productStatus = bool.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data source = DESKTOP-BPR14S8\\SQLEXPRESS; initial catalog = EgitimKampıDb; integrated security = true");
            connection.Open();
            
            SqlCommand command = new SqlCommand("update TblProduct set ProductName = @productName , ProductStock = @productStock , ProductStatus = @productStatus  where ProductId = @productId ", connection);

            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productStock", productStock);
            command.Parameters.AddWithValue("@productStatus", productStatus);
            command.Parameters.AddWithValue("@productId", productId);

            command.ExecuteNonQuery();

            connection.Close();
            Console.WriteLine("güncellemeler başarıyla yapıldı.");
            #endregion
        }
    }
}
