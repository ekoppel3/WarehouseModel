using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// To create a manager and be able to calculate things about him
// Manager inherits from employee which inherits from person and therefore has properties name, id, and salary, he also has 
// the additional property of vetek 
namespace Entities
{
    public class Manager: Employee
    {
        public int Vetek { get; set; }
        public Manager(string name, int id, decimal salary, int vetek): base(name,id, salary)
        {
            Vetek = vetek;
        }
        public override string ToString()
        {
            return base.ToString() + " " + Vetek;
        }
    }
}
