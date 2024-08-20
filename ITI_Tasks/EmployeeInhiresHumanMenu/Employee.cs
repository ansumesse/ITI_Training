using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInhiresHumanMenu
{
    public class Employee : Human
    {
        private int ID;
      
        static int counter = 0;
        public int Age { get; set; }

        public Employee(string name, float salary, Gender gender, int age) :base(name, salary, gender)
        {
            
            ID = ++counter;
            Age = age;
        }


        public override string ToString()
        {
            return base.ToString() + $"\nId = {ID}\nAge = {Age}";
        }

    }
    public static class Employeee
    {
        public static void PrintEmps(this Employee[] employees)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
    }
}
