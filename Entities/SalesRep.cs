using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// to create employee salesrep and then one can calculate his salary with his commission rate
// Sales rep has the additional prop of commision rate in addition to the properties of employee - salary, and person - name, id
namespace Entities
{
    public class SalesRep: Employee
    {
        public decimal CommisionRate { get; set; }
        public SalesRep(string name, int id, decimal salary, decimal commisionRate): base(name, id, salary)
        {
            CommisionRate = commisionRate;
        }
        public override string ToString()
        {
            return base.ToString() + " "+ CommisionRate;
        }
    }
}
