using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BLL
{
    public class OrderBLL
    {
        OrderDAL orderDal;
        ProductDAL productDAL;
        CustomerDAL customerDAL;    
        public OrderBLL()
        {
            orderDal = new OrderDAL();
            productDAL = new ProductDAL();
            customerDAL = new CustomerDAL();
        }

        public Order CreateBLL(Order o)
        {
            bool cexists = false;
            bool pexists = false;   
            try
            {
                foreach(Customer c in customerDAL.ReadAll())
                {
                    if(c.Id == o.CustomerID)
                    {
                        cexists = true;
                    }
                }
                if (!cexists)
                {
                    throw new NumberDoesNotExist("Error: the customer does not exist");
                }
                foreach (Product p in productDAL.ReadAll())
                {
                    if (p.ProductNumber == o.ProductNumber)
                    {
                        pexists = true;
                    }
                }
                if (!pexists)
                {
                    throw new NumberDoesNotExist("Error: the product does not exist");
                }
                productDAL.Read(o.ProductNumber).AmountInStock -= o.OrderQuantity;
                return orderDal.Create(o);
            }
            catch (NumberAlreadyExists nae)
            {
                throw nae;
            }
            catch(NumberDoesNotExist nde)
            {
                throw nde;
            }

        }

        public List<Order> ReadCustomerBLL(int numberToFind)
        {
            try
            {
                return orderDal.ReadByCustomer(numberToFind);
            }
            catch (NumberDoesNotExist ndne)
            {
               throw ndne;
            }

        }
        public List<Order> ReadByProductBLL (int numberToFind)
        {
            try
            {
                return orderDal.ReadByProduct(numberToFind);
            }
            catch (NumberDoesNotExist ndne)
            {
                throw ndne;
            }

        }//end

        public List<Order> ReadAll()
        {
            return orderDal.ReadAll();
        }

        public void UpdateOrderBLL(Order toUpdate)
        {
            try
            {
                orderDal.Update(toUpdate);
            }
            catch (NumberDoesNotExist nonExistent)
            {
                throw nonExistent;
            }
        }

        public void DeleteOrderBLL(Order o)
        {
            try
            {
                productDAL.Read(o.ProductNumber).AmountInStock += o.OrderQuantity;
                orderDal.Delete(o);
            }
            catch (NumberDoesNotExist nd)
            {
                throw nd;
            }

        }

        public Order ReadBLL(int orderToFind)
        {
            try
            {
                return orderDal.Read(orderToFind);
            }
            catch (NumberDoesNotExist ndne)
            {
                throw ndne;
            }

        }
    }
}
