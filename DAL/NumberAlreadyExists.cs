using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NumberAlreadyExists: Exception
    {
        public NumberAlreadyExists(): base("Product number already used")
        {

        }
        public NumberAlreadyExists(string value): base(value)
        {

        }
        public NumberAlreadyExists(string value, Exception inner): base(value, inner)
        {

        }
    }
}
