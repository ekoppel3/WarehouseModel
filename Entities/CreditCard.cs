using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// to create a credit card object
namespace Entities
{
    public class CreditCard
    {
        public int CardNumber { get; set; }
        public CreditCard(int cardNumber)
        {
            CardNumber = cardNumber;
        }

        public override string ToString()
        {
            return "\nCredit card number: " + CardNumber;
        }
    }
}
