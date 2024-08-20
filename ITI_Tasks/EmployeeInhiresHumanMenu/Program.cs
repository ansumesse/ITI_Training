namespace EmployeeInhiresHumanMenu
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
                                //
                                for (int i = 0; i < employees.Length; i++)
                                {
                                    Console.Write("Enter Employee Name: ");
                                    string name = Console.ReadLine();
                                    Console.Write("Enter Employee Salary: ");
                                    float salary = float.Parse(Console.ReadLine());
                                    Console.Write("Enter Employee Gender: ");
                                    Gender g = Console.ReadLine()[0] == 'm' ? Gender.Male : Gender.Female;
                                    Console.Write("Enter Employee Age: ");
                                    int age = int.Parse(Console.ReadLine());
                                    employees[i] = new Employee(name, salary, g, age);
                                    Console.ReadLine();
                                }

                                break;
                            case 1:
                                //
                                //for (int i = 0; i < employees.Length; i++)
                                //{
                                //    employees[i].DisplayData();
                                //    Console.WriteLine();
                                //}
                                employees.PrintEmps();
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
    }
}
