using System;
using Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Program
    {
        static void Main(string[] args)
        {
            OrderDAL od = new OrderDAL();
            Order o = new Order(1234, 4354, 45, 4534);
            Console.WriteLine(od.Create(o));
            od.Update(o);
            od.PrintList();
            od.Delete(o);
            od.PrintList();

        }
    }
}
