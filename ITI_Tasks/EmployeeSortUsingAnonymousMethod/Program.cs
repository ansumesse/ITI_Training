namespace EmployeeSortUsingAnonymousMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Menu = { "Add Employee", "Display Employee", "Find Employee", "Sort Employee", "Exit" };
            int xDist = Console.WindowWidth / 2;
            int yDist = Console.WindowHeight / (Menu.Length + 1);
            int highlight = 0;
            bool isLooping = true;
            List<Employee> employees = new List<Employee>();

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
                        if (highlight > 4)
                            highlight = 0;
                        break;
                    case ConsoleKey.UpArrow:
                        highlight--;
                        if (highlight < 0)
                            highlight = 4;
                        break;
                    case ConsoleKey.Home:
                        highlight = 0;
                        break;
                    case ConsoleKey.End:
                        highlight = 4;
                        break;
                    case ConsoleKey.Escape:
                        isLooping = false;
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        switch (highlight)
                        {
                            case 0:
                                //
                                Console.Write("Enter Employee Name: ");
                                string name = Console.ReadLine();
                                Console.Write("Enter Employee Id: ");
                                int id = int.Parse(Console.ReadLine());
                                Console.Write("Enter Employee Salary: ");
                                float salary = float.Parse(Console.ReadLine());
                                Console.Write("Enter Employee Gender: ");
                                Gender g = Console.ReadLine()[0] == 'm' ? Gender.Male : Gender.Female;
                                Console.Write("Enter Employee Age: ");
                                int age = int.Parse(Console.ReadLine());
                                employees.Add(new Employee(id, name, salary, g, age));
                                Console.ReadLine();

                                break;
                            case 1:
                                employees.PrintEmps();
                                Console.ReadLine();
                                break;
                            case 2:
                                Console.Write("Find by Id or Name Enter Id/Name: ");
                                string option = Console.ReadLine();
                                switch (option)
                                {
                                    case "Id":
                                        Console.Write("Enter Id Number: ");
                                        int idWnated = int.Parse(Console.ReadLine());
                                        foreach (var emp in employees)
                                        {
                                            if (emp.ID == idWnated)
                                            {
                                                Console.WriteLine(emp);
                                                Console.ReadKey();
                                            }
                                        }
                                        break;
                                    case "Name":
                                        Console.Write("Enter Employee Name: ");
                                        string nameWnated = Console.ReadLine();
                                        foreach (var emp in employees)
                                        {
                                            if (emp.Name == nameWnated)
                                            {
                                                Console.WriteLine(emp);
                                                Console.ReadKey();
                                            }
                                        }
                                        break;
                                }
                                break;
                            case 3:
                                Console.Write("Sort by Name/Id/Salary:");
                                string sortOption = Console.ReadLine();
                                Console.Write("Ascending or Descending: ");
                                string ascDesc = Console.ReadLine();
                                switch (sortOption)
                                {
                                    case "Name":
                                        employees.Sort((Employee emp1, Employee emp2) => string.Compare(emp1.Name, emp2.Name));
                                        if (ascDesc == "Descending")
                                            employees.Reverse();
                                        break;
                                    case "Id":
                                        employees.Sort((Employee emp1, Employee emp2) =>
                                        {
                                            if (emp1.ID < emp2.ID)
                                                return -1;
                                            else if (emp1.ID > emp2.ID)
                                                return 1;
                                            else
                                                return 0;
                                        });
                                        if (ascDesc == "Descending")
                                            employees.Reverse();
                                        break;
                                    case "Salary":
                                        employees.Sort((Employee emp1, Employee emp2) =>
                                        {
                                            if (emp1.Salary < emp2.Salary)
                                                return -1;
                                            else if (emp1.Salary > emp2.Salary)
                                                return 1;
                                            else
                                                return 0;
                                        });
                                        if (ascDesc == "Descending")
                                            employees.Reverse();
                                        break;
                                    default:
                                        break;
                                }
                                employees.PrintEmps();
                                Console.ReadLine();
                                break;
                            case 4:
                                isLooping = false;
                                break;
                        }
                        break;
                }
            } while (isLooping);
        }
    }
}
