using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using Entities;



namespace UseEntities
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Person adam = new Person("Sara", 43422);
            
            Product motzar = new Product(12590, "washing machine", 50000m, 500);
           *//* motzar.ProductNumber = 78980;
            motzar.ProductName = "washing machine";
            motzar.CostPerUnit = 1200;*//*

            Console.WriteLine(adam);
            Console.WriteLine(motzar);

            *//*Person[] people = { new Person(), new Person(), new Person() };*/

          /*  people[0].Name = "Avigail";
            people[0].Id = 2134;
            people[1].Name = "Esther";
            people[1].Id = 7329;
            people[2].Name = "Nechama";
            people[2].Id = 5802;*/
            
         /*   foreach(Person person in people)
            {
                Console.WriteLine(person);
            }*//*

            StreamReader info = new StreamReader("peoplelist.txt");
            Person[] people = new Person[50];
            var index = 0;
            using(info)
            {
                string name = info.ReadLine();
                int idNumber = int.Parse(info.ReadLine());

                while (name != null && idNumber != 0)
                {
                    Person person1 = new Person(name, idNumber);
                   
                    people[index] = person1;
                    name = info.ReadLine();
                    if (name != null)
                    {
                        idNumber = int.Parse(info.ReadLine());
                    }
                    Console.WriteLine(people[index]);
                    index++;
                    
                }
               
            }

            CreditCard creditCard = new CreditCard(); // tests credit card
            creditCard.CardNumber = 454765;
            Console.WriteLine(creditCard);
            Customer c1 = new Customer("Rina", 7900, creditCard);
            Console.WriteLine(c1);
            Employee e1 = new Employee("Charles", 790765, 60m);
            Console.WriteLine(e1);
            Manager m = new Manager("Eddie", 97646, 790m, 38);
            Console.WriteLine(m);
            SalesRep s = new SalesRep("Sam", 690076, 790m, 45m);
            Console.WriteLine(s);

            Product productTest = new Product(23434, "juice", 15m, 253);
            ProductDAL test = new ProductDAL();
            Console.WriteLine("testing create");
            Console.WriteLine(test.Create(productTest));
            Console.WriteLine("testing read");
            Console.WriteLine(test.Read(3245));
            Product productUpdate = new Product(23434, "frogs", 13.34m, 6);
            Console.WriteLine("testing update");
            test.Update(productUpdate);
            test.PrintList();
            Console.WriteLine("testing delete");
            test.Delete(3245);
            test.PrintList();
            Console.WriteLine("testing create exception");
            Product newProduct = new Product(698, "turtles", 08m, 79);
           *//* Console.WriteLine(test.Create(productTest));*//*
            // testing read exception
           *//* Console.WriteLine(test.Read(5332));*//*
            Console.WriteLine("Testing update exception");
            Product except = new Product(00099, "potatoes", 100m, 4);
           *//* test.Update(except);
            test.Delete(7689);
            test.ReadAll();*//*
            Console.WriteLine("printlist");
            test.PrintList();

            ProductBLL productBLL = new ProductBLL();
            Product toCreate = new Product(90866, "frog", 798m, 567);
            Console.WriteLine("Testing CreateBLL");
            Console.WriteLine(productBLL.CreateBLL(productTest));
            Console.WriteLine(productBLL.CreateBLL(toCreate));

            Console.WriteLine("Testing ReadBLL");
            Console.WriteLine(productBLL.ReadBLL(90866));
            Console.WriteLine(productBLL.ReadBLL(8908932));

            Console.WriteLine("Testing UpdateBLL");
            Product toUpdate = new Product(23434, "bananas", 89m, 68);
            productBLL.UpdateBLL(toUpdate);
            Console.WriteLine("print list");
            test.PrintList();
            Console.WriteLine("update BLL exception");
            productBLL.UpdateBLL(except);

            Console.WriteLine("testing delete BLL");
            productBLL.DeleteBLL(23434);
            test.PrintList();
            productBLL.DeleteBLL(10000);*/

        }
    }
}
