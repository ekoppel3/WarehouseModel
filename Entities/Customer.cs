using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// To create a customer who is a person but has the added property of credit card in addition to his name and id number
namespace Entities
{
    public class Customer: Person
    {
        public CreditCard creditCard { get; set; }
        /*CreditCard creditCard = new CreditCard();*/
        public Customer(string name, int id, CreditCard credit): base(name, id)
        {
            creditCard = credit;
        }
        public override string ToString()
        {
            return base.ToString() + " \n" + creditCard;
        }

    }
}
