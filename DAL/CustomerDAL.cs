using Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class CustomerDAL
    {
        static bool filled = false;
        public CustomerDAL()
        {
            InitializeList();
        }

        static List<Customer> listOfCustomers = new List<Customer>();
        public void InitializeList()
        {

            StreamReader customer = new StreamReader(@"..\..\..\DAL\bin\Debug\CustomerList.txt");
            if (filled == false)
            {
                using (customer)
                {
                    string name = customer.ReadLine();
                    int id = int.Parse(customer.ReadLine());
                    CreditCard creditCard = new CreditCard(int.Parse(customer.ReadLine()));
                    
                    while (name != null)
                    {
                        Customer c = new Customer(name, id, creditCard);
                        listOfCustomers.Add(c);
                        name = customer.ReadLine();
                        if (name != null)
                        {
                            id = int.Parse(customer.ReadLine());
                            creditCard.CardNumber = int.Parse(customer.ReadLine());
                        }
                    }
                    filled = true;
                }
            }
        }
        public void PrintList()
        {
            foreach (Customer c in listOfCustomers)
            {
                Console.WriteLine(c);
            }
        }

        public Customer Create(Customer customer)
        {
            try
            {
                /*CreditCard credit = new CreditCard();*/
                Customer c = new Customer(customer.Name, customer.Id, customer.creditCard);

                for (int i = 0; i < listOfCustomers.Count; i++) // going through list to make sure doesn't already exist
                {
                    if (listOfCustomers[i].Id == c.Id)
                    {
                        throw new NumberAlreadyExists("Error: customer already in system");
                    }

                }
                listOfCustomers.Add(c);
                return c;

            }
            catch (NumberAlreadyExists nae)
            {
                throw nae;
            }
        }

        public Customer Read(int requestedId)
        {
            try
            {
                for (int j = 0; j < listOfCustomers.Count; j++)
            {
                if (listOfCustomers[j].Id == requestedId)
                {
                    Customer c = new Customer(listOfCustomers[j].Name, listOfCustomers[j].Id, listOfCustomers[j].creditCard);
                   
                    return c;
                }

            }
            throw new NumberDoesNotExist("Error: The requested id number is not in the system");
            }
            catch (NumberDoesNotExist ndne)
            {
                throw ndne;
            }

        }

        public List<Customer> ReadAll()
        {
            List<Customer> 
            newCustomerList = listOfCustomers.ConvertAll(customer => new Customer(customer.Name,customer.Id,customer.creditCard));
            return newCustomerList;
        }

        public void Update(Customer customer)
        {
            try
            {
                bool check = false;
            for (int i = 0; i < listOfCustomers.Count; i++)
            {
                if (listOfCustomers[i].Id == customer.Id)
                {
                    listOfCustomers[i].Name =customer.Name;
                    listOfCustomers[i].creditCard = customer.creditCard;
                    listOfCustomers[i].Id = customer.Id;
                    check = true;
                }
            }
            if (check == false)
            {
                throw new NumberDoesNotExist("Error: the customer is not existent in the system");
            }

            }
            catch (NumberDoesNotExist nd)
            {
                throw nd;
            }
        }

        public void Delete(int idNumber)
        {

            try
            {
                bool check = false;
                for (int i = 0; i < listOfCustomers.Count; i++)
                {
                    if (listOfCustomers[i].Id == idNumber)
                    {
                        listOfCustomers.RemoveAt(i);
                        check = true;
                        break;
                    }

                }
                if (check == false)
                {
                    throw new NumberDoesNotExist("Error: the account you wanted to delete does not exist");
                }

            }
            catch (NumberDoesNotExist de)
            {
                throw de;
            }

        }
    }
}
