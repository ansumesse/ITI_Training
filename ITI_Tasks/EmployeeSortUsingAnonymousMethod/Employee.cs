using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSortUsingAnonymousMethod
{
    public class Employee : Human 
    {
        public int ID { get; set; }

        static int counter = 0;
        public int Age { get; set; }

        public Employee(int id, string name, float salary, Gender gender, int age) :base(name, salary, gender)
        {
            
            ID = id;
            Age = age;
        }
  
        public override string ToString()
        {
            return $"\nId = {ID}" + base.ToString() + $"\nAge = {Age}";
        }
      
        
    }
    public static class Employeee
    {
        public static void PrintEmps(this List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
    }
}
