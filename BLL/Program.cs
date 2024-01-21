using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderBLL ob = new OrderBLL();
            Order o = new Order(3546, 6890, 7, 123);
            Order orderwrongp = new Order(123, 7909, 6, 7899);
            Order orderwrongc = new Order(5321, 123, 4, 3546);
            Order toUpdate = new Order(3546, 6890, 5, 123);
            Order toUpdateBad = new Order(354, 80, 8, 89);
            ob.CreateBLL(o);
            foreach(Order order in ob.ReadAll())
            {
                Console.WriteLine(order);
            }
            ob.CreateBLL(orderwrongp);
            ob.CreateBLL(orderwrongc);
            ob.UpdateOrderBLL(toUpdate);
            foreach (Order order in ob.ReadAll())
            {
                Console.WriteLine(order);
            }
            ob.UpdateOrderBLL(toUpdateBad);
            ob.DeleteOrderBLL(o);
            foreach (Order order in ob.ReadAll())
            {
                Console.WriteLine(order);
            }
            ob.DeleteOrderBLL(o);
            
        }
    }
}
