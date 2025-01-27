using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C_2
{
    class EmployeeComparerName : IComparer<Employee>
    {
        public int Compare( Employee? x, Employee? y)
        {
            Employee E = (Employee)x;
            Employee Y = (Employee)y;
            return x.Name.CompareTo(Y.Name);
        }
    }

    internal class Employee :IComparable
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public int CompareTo(object? other)
        {
            Employee E = (Employee) other;
            return this.Age.CompareTo(E.Age);
        }

        public override string ToString()
        {
            return $"Id:{Id},Name:{Name},Salary:{Salary},Age:{Age} ";
        }

    }
}
