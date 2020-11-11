using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

namespace adoPractice {

    public class ProductDetail
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Qty { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}", ID, Name, Price, Qty);
        }

    }
    public class ProductLayer {
        string connectionString = ConfigurationManager.ConnectionStrings["ProductCat"].ConnectionString;
       


        /*getter to get Connection*/
        public SqlConnection Con { get {return new SqlConnection(connectionString);} }

        /*method to display all records using SqlCommand*/
        public void DipsProductsUsingCommand() {
            using (SqlConnection conn = Con) {

                try {

                    SqlCommand cmd = new SqlCommand("Select * from product", conn);
                    conn.Open();
                    SqlDataReader sr = cmd.ExecuteReader();
                    Console.WriteLine("--------------------------------");
                    CountOfRecords();
                    while (sr.Read()) {
                        Console.WriteLine("{0} {1} {2} {3}",sr[1],sr[0],sr[2],sr[3]);
                    }
                }
                catch (Exception ee) { Console.WriteLine(ee.Message); }

            }
        }

        /*gettter property to get List of records using system.collection.generic.list*/
        public List<ProductDetail> ProductsList {
            get {

                List<ProductDetail> products = new List<ProductDetail>();
                using (SqlConnection conn = Con) {

                    SqlCommand cmd = new SqlCommand("select * from product", conn);
                    conn.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    
                    while (sdr.Read()) {
                        ProductDetail pd = new ProductDetail();
                        pd.ID = Convert.ToInt32(sdr["ID"]);
                        pd.Name = Convert.ToString(sdr["Name"]);
                        pd.Price = Convert.ToSingle(sdr["price"]);
                        pd.Qty = Convert.ToInt32(sdr["quantity"]);

                        products.Add(pd);
                    }
                }
                    return products;
            }
        }

        /*Method to display records using List*/
        public void DispProductsUsingList(List<ProductDetail> products) {
            Console.WriteLine("--------------------------------");
            CountOfRecords();
            foreach (ProductDetail p in products) {
                Console.WriteLine(p);
            }
            
        }

        /*method to get no of records*/
        public void CountOfRecords() {
            using (SqlConnection conn = Con) {
                SqlCommand cmd = new SqlCommand("select count(id) from product", conn);
                conn.Open();
                int NoOfRecords = Convert.ToInt32(cmd.ExecuteScalar());
                Console.WriteLine("No of records : {0}",NoOfRecords);
            }
        }

        /*Method to insert record into the database*/
        public void InsertNewRecord() {
            ProductDetail p = new ProductDetail();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            Console.Write("Enter the details of product : \nName : ");
            p.Name = Console.ReadLine();
            Console.Write("Enter price : ");
            p.Price = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter Quantity : ");
            p.Qty = Convert.ToInt32(Console.ReadLine());
            try
            {
                using (SqlConnection connection = Con)
                {
                    string command = "Insert into product values (@pname,@pprice,@pquantity)";
                    SqlCommand cmd = new SqlCommand(command, connection);
                    cmd.Parameters.AddWithValue("@pname", p.Name);
                    cmd.Parameters.AddWithValue("@pprice", p.Price);
                    cmd.Parameters.AddWithValue("@pquantity", p.Qty);
                    connection.Open();
                    int rowAdded = Convert.ToInt32(cmd.ExecuteNonQuery());
                    Console.WriteLine("{0} rows added ",rowAdded);
                }
                DipsProductsUsingCommand();

            }
            catch (Exception ee) { Console.WriteLine(ee.Message); }

        }

        /*Method to update record in database*/
        public void UpdateRecord() {
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.Write("Enter Id of the record to be updated : ");
            int id = Convert.ToInt32(Console.ReadLine());
            ProductDetail p = new ProductDetail();
            try
            {
                using (SqlConnection connection = Con)
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("update product set quantity = 100 where id = @id", connection);
                    cmd.Parameters.AddWithValue("@id", id);
                    int rowAffected = Convert.ToInt32(cmd.ExecuteNonQuery());

                }
                DipsProductsUsingCommand();
            }
            catch (Exception ee) { Console.WriteLine(ee.Message); }
                Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
        }

        /*Method to delete record*/
        public void DeleteRecord() {
            Console.Write("Enter id to delte : ");
            int id = Convert.ToInt32(Console.ReadLine());
            try {

                using (SqlConnection connection = Con) {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("delete from product where id = @id", connection);
                    cmd.Parameters.AddWithValue("@id", id);
                    int rowsDeleted = Convert.ToInt32(cmd.ExecuteNonQuery());
                    Console.WriteLine("{0} rows deleted ",rowsDeleted);
                }
                DipsProductsUsingCommand();
                
            }
            catch (Exception ee) { Console.WriteLine(ee.Message); }
        }
    }

    public class Program {
        public static void Main() {

            ProductLayer p1 = new ProductLayer();
            p1.DipsProductsUsingCommand();
            Console.WriteLine("display using List : ");
            p1.DispProductsUsingList(p1.ProductsList);
            p1.InsertNewRecord();
            p1.UpdateRecord();
            p1.DeleteRecord();
        }
        
    }
}
