using EmployeeRegistration.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace EmployeeRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine()); // total numbers employee
            
            for(int i =1; i<=n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                String Name = Console.ReadLine();
                Console.Write("Hours: ");
                int Hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double ValueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutSourcedEmployee(Name, Hours, ValueHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(Name, Hours, ValueHour));
                }

                Console.WriteLine();
                Console.WriteLine("PAYMENTS:");
                
                foreach(Employee emp in list)
                {

                    Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
                }

            }


        }

    }
}
