using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Order
    {
        public int ProductNumber{ get; set; }
        public int CustomerID { get; set; }
        public int OrderQuantity { get; set; }
        public int OrderNumber { get; set; }


        public Order(int productNumber, int customerID, int orderQuantity, int orderNumber)
        {
            ProductNumber = productNumber;
            CustomerID = customerID;
            OrderQuantity = orderQuantity;
            OrderNumber = orderNumber;  
        }

        public override string ToString()
        {
            return "Order number: " + OrderNumber + " Product number: " + ProductNumber + " Customer Id: " + CustomerID + " Order quantity: " + OrderQuantity;
        }
    }
}
