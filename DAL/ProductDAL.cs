using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace DAL
{ 
    public class ProductDAL
    {
        static bool filled = false;
        public ProductDAL()
        {
            InitializeList();
        }

        static List<Product> list = new List<Product>();
        public void InitializeList()
        {
           
                StreamReader products = new StreamReader(@"..\..\..\DAL\bin\Debug\ProductList.txt");
            if (filled == false)
            {
                using (products)
                {
                    string pname = products.ReadLine();                                                                                                                                           
                    int pnumber = int.Parse(products.ReadLine());
                    decimal price = decimal.Parse(products.ReadLine());
                    int amount = int.Parse(products.ReadLine());
                    while (pname != null && pname !="")
                    {
                        Product p = new Product(pnumber, pname, price, amount);
                        list.Add(p);
                        pname = products.ReadLine();
                        if (pname!= "" && pname != null)
                        {
                            pnumber = int.Parse(products.ReadLine());
                            price = decimal.Parse(products.ReadLine());
                            amount = int.Parse(products.ReadLine());
                        }
                    }
                    filled = true;
                }
                
            }
          
        }

        public Product Create(Product pt)
        {
            try
            {
                Product product = new Product(pt.ProductNumber, pt.ProductName, pt.CostPerUnit, pt.AmountInStock);

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].ProductNumber == product.ProductNumber)
                    {
                        throw new NumberAlreadyExists("product number already exists");
                    }

                }
                list.Add(product);
                return product;

            }
            catch (NumberAlreadyExists na)
            {
                throw;
            }

        }
        public Product Read(int productNumberFind)
        {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j].ProductNumber == productNumberFind)
                    {
                        Product p = new Product(list[j].ProductNumber, list[j].ProductName, list[j].CostPerUnit, list[j].AmountInStock);
                        return p;
                    }
                   
                }
                throw new NumberDoesNotExist("This product number does not exist");
           
        }
        public void Update(Product prod)
        {

            bool check = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ProductNumber == prod.ProductNumber)
                {
                    list[i].ProductName = prod.ProductName;
                    list[i].CostPerUnit = prod.CostPerUnit;
                    list[i].AmountInStock = prod.AmountInStock;
                    check = true;
                }
            }
            if (check == false)
            {
                throw new NumberDoesNotExist("the product does not exist");
            }

        }
        public void Delete(int number)
        {
           
            try
            {
                bool check = false;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].ProductNumber == number)
                    {
                        list.RemoveAt(i);
                        check = true;
                        break;
                    }

                }
                if (check == false)
                {
                    throw new NumberDoesNotExist("requested product does not exist");
                }
                
            }
            catch(NumberDoesNotExist de)
            {
                throw;
            }
           
        }
        public void PrintList()
        {
            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        public List<Product> ReadAll()
        {
            List<Product>
            newProductList = list.ConvertAll(product => new Product(product.ProductNumber, product.ProductName, product.CostPerUnit, product.AmountInStock));
            return newProductList;
        }
    }
    
}
