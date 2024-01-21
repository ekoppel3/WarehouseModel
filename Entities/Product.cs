using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product 
    {
        public int ProductNumber { get; set; }
        public string ProductName { get; set; }
        public decimal CostPerUnit { get; set; }
        public int AmountInStock { get; set; }

        public Product(int number, string name, decimal cost, int amount)
        {
            ProductNumber = number;
            ProductName = name; 
            CostPerUnit = cost; 
            AmountInStock = amount;
        }
   

        public override string ToString()
        {
            return "Product Name: "  + ProductName + "\n Product Number: " + ProductNumber + "\n Cost per unit: " + CostPerUnit + "\n Amount in Stock: " + AmountInStock;
        }
    }
}
