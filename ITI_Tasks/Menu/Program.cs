using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Menu = { "Add Employee", "Display Employee", "Exit" };
            int xDist = Console.WindowWidth / 2;
            int yDist = Console.WindowHeight / (Menu.Length + 1);
            int highlight = 0;
            bool isLooping = true;
            Employee[] employees = new Employee[3];

            do
            {
                Console.ResetColor();
                Console.Clear();
                for (int i = 0; i < Menu.Length; i++)
                {
                    if (i == highlight)
                    {
                        Console.BackgroundColor = ConsoleColor.Magenta;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.SetCursorPosition(xDist, (i + 1) * yDist);
                    Console.WriteLine(Menu[i]);
                }
                var keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.DownArrow:
                        highlight++;
                        if (highlight > 2)
                            highlight = 0;
                        break;
                    case ConsoleKey.UpArrow:
                        highlight--;
                        if (highlight < 0)
                            highlight = 2;
                        break;
                    case ConsoleKey.Home:
                        highlight = 0;
                        break;
                    case ConsoleKey.End:
                        highlight = 2;
                        break;
                    case ConsoleKey.Escape:
                        isLooping = false;
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        switch (highlight)
                        {
                            case 0:
                                for (int i = 0; i < employees.Length; i++)
                                {
                                    employees[i] = AddEmployee();
                                    Console.WriteLine();
                                }
                                Console.ReadLine();
                                break;
                            case 1:
                                for (int i = 0; i < employees.Length; i++)
                                {
                                    DisplayEmployee(employees[i]);
                                    Console.WriteLine();
                                }
                                
                                Console.ReadLine();
                                break;
                            case 2:
                                isLooping = false;
                                break;
                        }
                        break;
                }
            } while (isLooping);
        }
        public static Employee AddEmployee()
        {
            Employee employee = new Employee();
            Console.Write("Enter Employee Name: ");
            employee.Name = Console.ReadLine();
            Console.Write("Enter Employee Id: ");
            employee.Id = int.Parse(Console.ReadLine());
            Console.Write("Enter Employee Salary: ");
            employee.Salary = float.Parse(Console.ReadLine());
            Console.Write("Enter Employee's gender: ");
            employee.g = Console.ReadLine()[0] == 'm' ? Gender.Male : Gender.Female;
            return employee;
        }
        public static void DisplayEmployee(Employee employee)
        {
            Console.WriteLine($"Employee Name: {employee.Name}");
            Console.WriteLine($"Employee Id: {employee.Id}");
            Console.WriteLine($"Employee Salary: {employee.Salary}");
            Console.WriteLine($"Employee's Gender: {employee.g.ToString()}");
        }
    }
    public struct Employee
    {
        public int Id;
        public string Name;
        public float Salary;
        public Gender g;
    }
    public enum Gender
    {
        Male,
        Female
    }
}
