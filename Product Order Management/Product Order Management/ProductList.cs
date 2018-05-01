using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Windows.Forms;

namespace Product_Order_Management
{
    public class ProductList
    {//creating the list 
        private List<Product> Products = new List<Product>();
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Documents\\CS 391\\C# Projects\\Product Order Management\\Product Order Management\\Producs.mdf;Integrated Security = True";
       // private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectry|\\Producs.mdf;Integrated Security=True;Connect Timeout=30";
        //private string connectionString;// = String.Format("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={0}
        private SqlConnection databaseConnection = new SqlConnection();
        private SqlCommand commandDatabase;
        public int IdHolder = 0;
        public ProductList()
        {
            //string pth = Application.StartupPath;
           // pth.Replace("\\bin\\Debug", "");
          //  Console.WriteLine(pth + "     TTTTTTTTTT");
       // connectionString = String.Format("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={0}\\Producs.mdf;Integrated Security=True;Connect Timeout=30", pth);
        databaseConnection = new SqlConnection(connectionString);
        }
        // a function get ordered products

        public List<Product> GetProducts(string orderBy)
        {   //make a list 
            Products = new List<Product>();
            string query = "SELECT *"
                                   + "FROM Products "
                                   + "ORDER BY " + orderBy + " DESC";

            commandDatabase = new SqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            SqlDataReader reader;
            try
            {
                // Open the database
                databaseConnection.Open();

                // Execute the query
                reader = commandDatabase.ExecuteReader();

                // All succesfully executed, now do something
                while (reader.Read())
                {
                    
                    Product p = new Product();
                    p.Code = reader["Code"].ToString();
                    p.Name = reader["Name"].ToString();
                    p.OrderPrice = Convert.ToDecimal(reader["OrderPrice"]);
                    p.SalesPrice = Convert.ToDecimal(reader["SalesPrice"].ToString());
                    
                    p.OrderDate = Convert.ToDateTime(reader["OrderDate"]);
                    
                   

                    p.QuantityOrdered = Convert.ToInt32(reader["QuantityOrdered"]);
                    p.QuantitySold = Convert.ToInt32(reader["QuantitySold"]);
                    p.CurrentQuantity= Convert.ToInt32(reader["CurrentQuantity"]);
                    p.TotalCost = Convert.ToDecimal(reader["TotalCost"]);
                    p.NetEarning = Convert.ToDecimal(reader["NetEarning"]);
                    p.Profit= Convert.ToDecimal(reader["Profit"]);

                    Console.WriteLine(p.Name + "    " + p.QuantitySold);

                    Products.Add(p);
                    if (IdHolder < Convert.ToInt32(reader["Id"]))
                    {
                        IdHolder = Convert.ToInt32(reader["Id"]);
                        
                    }
                }
                IdHolder++;
               
        
                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
            return Products;
        }


    

// constructor for the list

  public List<Product> products
        {
            get
            {
                return Products;
            }
            set
            {
                Products = value;
            }
        }

        //function for deleting product

        public void deleteProduct(string pc)
        {
            try
            {
                string query = "delete from Products where Code=@code;";

                commandDatabase = new SqlCommand(query, databaseConnection);
                databaseConnection.Open();

                commandDatabase.Parameters.AddWithValue("@code", pc);
                commandDatabase.CommandTimeout = 60;
                commandDatabase.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }
        //function to find a product
        public Product findProduct(string pc)
        {
            Console.WriteLine(pc);
           
            foreach (var item in Products)
            {
                Console.WriteLine("HI");
                Console.WriteLine(item.Code);
                if (item.Code.Replace(" ","").Equals(pc))
                {
                    Console.WriteLine("Found Item");
                    return item;
                }
            }
            
            return new Product();
        }








        // a function to add product
        public void AddProduct(Product p)
        {
            Products.Add(p);
            try
            {
                
                string query = "INSERT INTO "
                                       + "Products (Id,Code,Name,QuantityOrdered,QuantitySold,OrderPrice,SalesPrice,TotalCost,NetEarning,Profit,CurrentQuantity,OrderDate)"
                                       + String.Format("VALUES({0},'{1}','{2}',{3},{4},{5},{6},{7},{8},{9},{10},@value); ", IdHolder, p.Code, p.Name, p.QuantityOrdered, p.QuantitySold, p.OrderPrice, p.SalesPrice, p.calcTotal(), p.calcNetEarnings(), p.calcProfit(),p.calcCurrentQuantity());


                commandDatabase = new SqlCommand(query, databaseConnection);
                commandDatabase.Parameters.AddWithValue("@value", p.OrderDate);
                commandDatabase.CommandTimeout = 60;
                databaseConnection.Open();
                commandDatabase.ExecuteNonQuery();
                IdHolder++;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);

            }
            finally
            {
                databaseConnection.Close();
            }



        }

        //this is another required method for this project, to add a product given its properties - do not change its signature
        public void AddProduct(string code, string name, decimal salesPrice, decimal orderPrice, int quantityOrdered, int quantitySold, DateTime orderdate)
        {
            Product p = new Product(code, name, salesPrice, orderPrice, quantityOrdered, quantitySold, orderdate);
            Products.Add(p);
            try { 
               
                string query = "INSERT INTO "
                                       + "Products (Id,Code,Name,QuantityOrdered,QuantitySold,OrderPrice,SalesPrice,TotalCost,NetEarning,Profit,OrderDate)"
                                       + String.Format("VALUES({0},'{1}','{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}); ", IdHolder, code, name, quantityOrdered, quantitySold, orderPrice, salesPrice, p.calcTotal(), p.calcNetEarnings(), p.calcProfit(), orderdate);

                commandDatabase = new SqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                databaseConnection.Open();
                commandDatabase.ExecuteNonQuery();
                IdHolder++;
                }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);

            }
            finally
            {
                databaseConnection.Close();
            }


        }
















    }
}
