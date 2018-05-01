using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Order_Management
{
  public  class Product

    {  // declare the variables
        private string code;
        private string name;
        private decimal orderPrice;
        private decimal salesPrice;
        private int quantityOrdered;
        private int quantitySold;
        private decimal totalCost;
        private decimal netEarning;
        private decimal profit;
        private int currentQuantity;
        private DateTime orderDate;


       




        //constructor without parametr
        public Product() { }
       
        //constructor with parameter
        public Product(string code, string name, decimal orderPrice,decimal salesPrice,int quantityOrdered,int quantitySold,DateTime orderDate)
        {
            this.Code = code;
            this.Name = name;
            this.OrderPrice = orderPrice;
            this.SalesPrice = salesPrice;
            this.QuantityOrdered = quantityOrdered;
            this.QuantitySold = quantitySold;
            this.OrderDate = orderDate;
            calcTotal();
            calcNetEarnings();
            calcProfit();
            calcCurrentQuantity();
           

        }
        

        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public decimal OrderPrice
        {
            get
            {
                return orderPrice;
            }
            set
            {
                orderPrice = value;
            }
        }

        public decimal SalesPrice
        {
            get
            {
                return salesPrice;
            }
            set
            {
                salesPrice = value;
            }
        }
        public int QuantityOrdered
        {
            get
            {
                return quantityOrdered;
            }
            set
            {
                quantityOrdered = value;
            }
        }

        public int QuantitySold
        {
            get
            {
                return quantitySold;
            }
            set
            {
                quantitySold = value;
            }
        }
        public int CurrentQuantity
        {
            get
            {
                return currentQuantity;
            }
            set
            {
                currentQuantity = value;
            }
        }


        public DateTime OrderDate
        {
            get
            {
                return orderDate;
            }
            set
            {
                orderDate = value;
            }
        }




        


        public decimal TotalCost
        {
            get 
            {
                
                return totalCost;
            }
            set
            {


                totalCost = value;
            }
           
        }




        public decimal NetEarning
        {
            get
            {
               

                return netEarning;
            }
            set
            {
                netEarning = value;
               
            }

        }

        public decimal Profit
        {
            get
            {
              

                return profit;
            }
            set
            {
                profit = value;

            }


        }
        public int calcCurrentQuantity()
        {
            currentQuantity = quantityOrdered - quantitySold;
            return currentQuantity;
        }

        public decimal calcNetEarnings()
        {
            netEarning = QuantitySold * salesPrice;
            return netEarning;
        }
        public decimal calcTotal()
        {
            totalCost = quantityOrdered * OrderPrice;
            return totalCost;

        }
        public decimal calcProfit()
        {
            profit = (netEarning - totalCost);
            return profit;
        }

       public string DisplayText()
        {
            return "Name :" + name + "  " + "Code: " + code + "Quantity Ordere: " + quantityOrdered + "\n"
                    + "Quantity Sold" + quantitySold + "Profit Earned " + profit;
            
        }






    }
}
