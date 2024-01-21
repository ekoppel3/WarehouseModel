using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NumberDoesNotExist: Exception
    {
        public NumberDoesNotExist(): base("This number does not exist")
        {

        }
        public NumberDoesNotExist(string messageValue): base(messageValue)
        {

        }
        public NumberDoesNotExist(string messageValue, Exception inner): base(messageValue, inner)
        {

        }
    }
}
 