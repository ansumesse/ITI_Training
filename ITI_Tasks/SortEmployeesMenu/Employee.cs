using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortEmployeesMenu
{
    public class Employee : Human //, IComparable
    {
        private int ID;
      
        static int counter = 0;
        public int Age { get; set; }

        public Employee(string name, float salary, Gender gender, int age) :base(name, salary, gender)
        {
            
            ID = ++counter;
            Age = age;
        }
        // Icomparable
        //public int CompareTo(object obj)
        //{
        //    Employee employee = (Employee)obj;
        //    if (this.ID > employee.ID)
        //        return 1;
        //    else if (this.ID < employee.ID)
        //        return -1;
        //    else
        //        return 0;
        //}
        public override string ToString()
        {
            return base.ToString() + $"\nId = {ID}\nAge = {Age}";
        }
        // IComparer
        
    }
    public class EmpComparer : IComparer<Employee>
    {
        public int Compare(Employee employee1, Employee employee2)
        {

            if (employee1.Salary < employee2.Salary)
                return -1;
            else if (employee1.Salary > employee2.Salary)
                return 1;
            else
                return 0;

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
