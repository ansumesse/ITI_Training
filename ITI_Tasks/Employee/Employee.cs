namespace Employee_
{
    public class Employee
    {
        private string Name;
        private int ID;
        private float Salary;
        private readonly Gender gender;
        static int counter = 0;
        public int Age { get; set; }

        public Employee(string name, float salary, Gender gender, int age)
        {
            Name = name;
            ID = ++counter;
            Salary = salary;
            this.gender = gender;
            Age = age;
        }

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
        public void DisplayData()
        {
            Console.WriteLine($"Name: {Name} \nId = {ID} \nSalary = {Salary} \nGender: {Gender.ToString()} \nAge = {Age}");
        }

    }
    public static class Employeee
    {
        public static void PrintEmps(this Employee[] employees)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].DisplayData();
            }
        }
    }
    public enum Gender
    {
        Male,
        Female
    }

}
