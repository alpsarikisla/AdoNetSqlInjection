using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDevam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Kategori Numarası yazılan ürünleri listeleyin

            //Console.WriteLine("Ürünlerinin Listelenmesini istediğiniz kategori numarasını yazınız");
            //string katNo = Console.ReadLine();

            //SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6VC48K2; Initial Catalog = NORTHWND; Integrated Security=True");
            //SqlCommand cmd = con.CreateCommand();

            //cmd.CommandText = "SELECT ProductID,ProductName,UnitPrice FROM Products WHERE CategoryID = " + katNo;
            //con.Open();
            //SqlDataReader reader = cmd.ExecuteReader();

            //while (reader.Read())
            //{
            //    int id = reader.GetInt32(0);
            //    string isim = reader.GetString(1);
            //    decimal fiyat = reader.GetDecimal(2);
            //    Console.WriteLine($"{id}) {isim} {fiyat}");
            //}
            //con.Close();

            #endregion

            #region Kategori Seç Ürün Listele

            //SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6VC48K2; Initial Catalog = NORTHWND; Integrated Security=True");
            //SqlCommand cmd = con.CreateCommand();

            //cmd.CommandText = "SELECT CategoryID, CategoryName FROM Categories ORDER BY CategoryID";
            //con.Open();
            //SqlDataReader reader = cmd.ExecuteReader();

            //while (reader.Read())
            //{
            //    int ID = reader.GetInt32(0);
            //    string isim = reader.GetString(1);
            //    Console.WriteLine($"{ID} {isim}");
            //}
            ////reader.Close();
            //con.Close();

            //Console.WriteLine("Lütfen Yukarıdaki listeden kategori seçiniz");
            //string kategori = Console.ReadLine();

            //cmd.CommandText = "SELECT ProductID, ProductName, UnitPrice FROM Products WHERE CategoryID=" + kategori;
            //con.Open();
            //SqlDataReader reader2 = cmd.ExecuteReader();

            //while (reader2.Read())
            //{
            //    int ID = reader2.GetInt32(0);
            //    string isim = reader2.GetString(1);
            //    decimal fiyat = reader2.GetDecimal(2);
            //    Console.WriteLine($"{ID}) {isim} - {fiyat}");
            //}

            //con.Close();
            #endregion

            #region Parametreli Sorgular

            //Console.WriteLine("Lütfen ürünlerini listelemek istediğiniz kategori numarasını yazınız");
            //string katNo = Console.ReadLine();

            //SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6VC48K2; Initial Catalog = NORTHWND; Integrated Security=True");
            //SqlCommand cmd = con.CreateCommand();

            //cmd.CommandText = "SELECT ProductID, ProductName, UnitPrice FROM Products WHERE CategoryID=@id";
            //cmd.Parameters.AddWithValue("@id", katNo);
            //con.Open();
            //SqlDataReader reader = cmd.ExecuteReader();

            //while (reader.Read())
            //{
            //    int id = reader.GetInt32(0);
            //    string isim = reader.GetString(1);
            //    decimal fiyat = reader.GetDecimal(2);
            //    Console.WriteLine($"{id}) {isim} {fiyat}TL");
            //}
            //con.Close();

            #endregion

            #region Kategori Ekleme

            //Console.WriteLine("Lütfen kategori adını giriniz");
            //string isim = Console.ReadLine();

            //Console.WriteLine("Lütfen açıklama giriniz");
            //string aciklama = Console.ReadLine();

            //SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6VC48K2; Initial Catalog = NORTHWND; Integrated Security=True");
            //SqlCommand cmd = con.CreateCommand();

            //cmd.CommandText = "INSERT INTO Categories(CategoryName,Description) VALUES(@cn,@d)";
            //cmd.Parameters.AddWithValue("@cn", isim);
            //cmd.Parameters.AddWithValue("@d", aciklama);

            //con.Open();

            //cmd.ExecuteNonQuery();
            //Console.WriteLine("Ekeleme Başarılı");

            //con.Close();

            #endregion

            #region Kategori Silme

            Console.WriteLine("Lütfen kategori numarası giriniz");
            string no = Console.ReadLine();

            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6VC48K2; Initial Catalog = NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM Categories WHERE CategoryID =@id";
            cmd.Parameters.AddWithValue("@id", no);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


            #endregion
        }
    }
}
