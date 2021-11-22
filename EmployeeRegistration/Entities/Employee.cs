using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegistration.Entities
{
    class Employee
    {
        private double hours;

        public string Name { get; private set; }
        public int Hours { get;  private set; }
        public double ValueHour{ get; private set; }

        public Employee() { }
        public Employee(string name, int hours, double valuehour)
        {
            Name = name;
            Hours = hours;
            ValueHour = valuehour;
            
        }



        public virtual double Payment()
        {
            return Hours * ValueHour;
        }
    }
}
