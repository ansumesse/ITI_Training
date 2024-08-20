using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSortUsingAnonymousMethod
{
    public class Human
    {
        private string name;
        private float salary;
        private readonly Gender gender;
        public Human()
        {
            
        }
        public Human(string name, float salary, Gender gender)
        {
            this.name = name;
            this.salary = salary;
            this.gender = gender;
        }

        public string Name { get { return name; } set { name = value; } }
        public float Salary { get { return salary; } set { salary = value; } }
        public Gender Gender
        {
            init
            {
                gender = value;
            }
            get
            {
                return gender;
            }
        }
        public override string ToString()
        {
            return $"Name: {Name} \nSalary = {Salary} \nGender: {Gender.ToString()}";
        }
    }
    public enum Gender
    {
        Male,
        Female
    }

}
