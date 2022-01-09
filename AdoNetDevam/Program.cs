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


            Console.WriteLine("Ürünlerinin Listelenmesini istediğiniz kategori numarasını yazınız");
            int katNo = Convert.ToInt32(Console.ReadLine());

            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6VC48K2; Initial Catalog = NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "SELECT ProductID,ProductName,UnitPrice FROM Products WHERE CategoryID = " + katNo;
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string isim = reader.GetString(1);
                decimal fiyat = reader.GetDecimal(2);
                Console.WriteLine($"{id}) {isim} {fiyat}");
            }
            con.Close();

            #endregion
        }
    }
}
