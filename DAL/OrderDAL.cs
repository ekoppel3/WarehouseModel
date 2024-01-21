using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.IO;


namespace DAL
{
    public class OrderDAL
    {
        static bool filled = false;
        public OrderDAL()
        {
            InitializeList();
        }

        static List<Order> list = new List<Order>();
        public void InitializeList()
        {

            StreamReader orders = new StreamReader(@"..\..\..\DAL\bin\Debug\OrderList.txt");
            if (filled == false)
            {
                using (orders)
                {
                    int pnumber = int.Parse(orders.ReadLine());
                    int customerID = int.Parse(orders.ReadLine());
                    int quantity = int.Parse(orders.ReadLine());
                    int orderNumber = int.Parse(orders.ReadLine());

                    while (pnumber != 0)
                    {
                        Order order = new Order(pnumber, customerID, quantity, orderNumber);

                        list.Add(order);
                        pnumber = int.Parse(orders.ReadLine());
                        if (pnumber != 0)
                        {
                            customerID = int.Parse(orders.ReadLine());
                            quantity = int.Parse(orders.ReadLine());
                            orderNumber = int.Parse(orders.ReadLine());
                        }
                    }
                    filled = true;
                }

            }//end
        }
        public Order Create(Order order)
        {
            try
            {
                Order orderEx = new Order(order.ProductNumber, order.CustomerID, order.OrderQuantity, order.OrderNumber);

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].OrderNumber == order.OrderNumber)
                    {
                        throw new NumberAlreadyExists("Error: product number or order number already exists");
                    }

                }
                list.Add(order);
                return order;

            }
            catch (NumberAlreadyExists na)
            {
                throw;



            }

        }
        public Order Read(int orderNumberFind)
        {
            for (int j = 0; j < list.Count; j++)
            {
                if (list[j].OrderNumber == orderNumberFind)
                {
                    Order order = new Order(list[j].ProductNumber, list[j].CustomerID, list[j].OrderQuantity, list[j].OrderNumber);
                    return order;
                }

            }
            throw new NumberDoesNotExist("This product number does not exist");

        }

        public List<Order> ReadAll()
        {
            List<Order>
            newProductList = list.ConvertAll(order => new Order(order.ProductNumber, order.CustomerID, order.OrderQuantity, order.OrderNumber));
            return newProductList;
        }

        public List<Order> ReadByProduct(int productNumber)
        {
            List<Order> newOrderList = new List<Order>();
            bool check = false;
            try
            {
                foreach (Order order in list)
                {
                    if (order.ProductNumber == productNumber)
                    {
                        newOrderList.Add(new Order(order.ProductNumber, order.CustomerID, order.OrderQuantity, order.OrderNumber));
                        check = true;
                    }
                }
                if (!check)
                {
                    throw new NumberDoesNotExist ("Error: Product number is invalid.");
                }
                return newOrderList;
            }
            catch (NumberDoesNotExist nd)
            {
                throw nd;
            }
        }
        public List<Order> ReadByCustomer(int customerId)
        {
            List<Order> newList = new List<Order>();
            bool check = false;
            try
            {
                foreach (Order order in list)
                {
                    if (order.CustomerID == customerId)
                    {
                        newList.Add(new Order(order.ProductNumber, order.CustomerID, order.OrderQuantity, order.OrderNumber));
                        check = true;
                    }
                }
                if (!check)
                {
                    throw new NumberDoesNotExist("Error: the customer ID is not valid");
                }
                return newList;
            }
            catch (NumberDoesNotExist nd)
            {
                throw nd;
            }
        }
        public void Update(Order order)
        {

            bool check = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].OrderNumber == order.OrderNumber)
                {
                    list[i].OrderQuantity = order.OrderQuantity;
                    check = true;
                }
            }
            if (check == false)
            {
                throw new NumberDoesNotExist("Error: The order does not exist");
            }
        }
       

        public void Delete(Order order)
        {
            try
            {
                bool check = false;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].OrderNumber == order.OrderNumber)
                    {
                        list.RemoveAt(i);
                        check = true;
                        break;
                    }
                }
                if (check == false)
                {
                    throw new NumberDoesNotExist("requested order does not exist");
                }
            }
            catch (NumberDoesNotExist de)
            {
                throw de;
            }

        }



        public void PrintList()
        {
            foreach (Order o in list)
            {
                Console.WriteLine(o);
            }
        }


    }
}
