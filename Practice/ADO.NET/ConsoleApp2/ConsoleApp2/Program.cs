using System;
using System.Data.SqlClient;
using System.Configuration;
namespace adoPractice {

    public class Product {
        string connectionString = ConfigurationManager.ConnectionStrings["ProductCat"].ConnectionString;


        public SqlConnection Con { get {return new SqlConnection(connectionString);} }

        public void DipsProducts() {
            using (SqlConnection conn = Con) {

                try {

                    SqlCommand cmd = new SqlCommand("Select * from product", conn);
                    conn.Open();
                    SqlDataReader sr = cmd.ExecuteReader();

                    while (sr.Read()) {
                        Console.WriteLine("{0} {1} {2} {3}",sr[1],sr[0],sr[2],sr[3]);
                    }
                }
                catch (Exception ee) { Console.WriteLine(ee.Message); }

            }
        }
    }

    public class Program {
        public static void Main() {

            Product p1 = new Product();
            p1.DipsProducts();
        }
        
    }
}
