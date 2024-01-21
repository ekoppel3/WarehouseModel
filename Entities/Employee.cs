using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// to create a employee of type of person
//the employee inherits from person and therefore has a name and id, but he also has the additional property of a salary
namespace Entities
{
    public class Employee: Person
    {
        public decimal Salary { get; set; }
        public Employee(string name, int id, decimal salary): base(name, id)
        {
            Salary = salary;
        }

        public override string ToString()
        {
            return base.ToString() + "\n " + Salary;
        }
    }
}
