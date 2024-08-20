using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Day_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Take two integer from user and get max of them
            //Console.Write("Enter 1st Number: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter 2st Number: ");
            //int num2 = int.Parse(Console.ReadLine());
            //int max;
            //int min;
            //if (num1 > num2)
            //{
            //    max = num1;
            //    min = num2;
            //}
            //else
            //{
            //    max = num2;
            //    min = num1;
            //}
            //Console.WriteLine("the max is {0}", max);

            //// Create simple menu and get user selection from it To calculate sum or get max or get min
            //Console.WriteLine("please enter [1] for sum or [2] for get max or [3] for git min or [4] for Exit");
            //int option = int.Parse(Console.ReadLine());
            //switch (option)
            //{
            //    case 1:
            //        Console.WriteLine("Sum = {0}", num1 + num2);
            //        break;
            //    case 2:
            //        Console.WriteLine("the max is {0}", max);
            //        break;
            //    case 3:
            //        Console.WriteLine("the min is {0}", min);
            //        break;
            //    case 4:
            //        break;
            //}

            //// Simple calculator
            //Console.Write("Enter 1st Number: ");
            //int num3 = int.Parse(Console.ReadLine());
            //Console.Write("Enter 2st Number: ");
            //int num4 = int.Parse(Console.ReadLine());

            //Console.Write("Please choose operator for Calculation [+] sum [-] subtract [*] multiplication [/] divide: ");
            //char op = Console.ReadLine()[0];
            //switch (op)
            //{
            //    case '+':
            //        Console.WriteLine($"{num3} + {num4} = {num3 + num4}");
            //        break;
            //    case '-':
            //        Console.WriteLine($"{num3} - {num4} = {num3 - num4}");
            //        break;
            //    case '*':
            //        Console.WriteLine($"{num3} * {num4} = {num3 * num4}");
            //        break;
            //    case '/':
            //        Console.WriteLine($"{num3} / {num4} = {num3 / num4}");
            //        break;
            //    default:
            //        break;
            //}
            //Console.ReadKey();
            //Console.Clear();
            //// Magic Box
            //int row, col;
            //Console.WriteLine("please enter size of magic box [odd number]: ");
            //int size = int.Parse(Console.ReadLine());

            //row = 1;
            //col = (size / 2) + 1;
            //int xDist = Console.WindowWidth / (size + 1);
            //int yDist = Console.WindowHeight / (size + 1);

            //for (int i = 1; i <= size * size; i++)
            //{
            //    Console.SetCursorPosition(col * xDist, row * yDist);
            //    Console.WriteLine(i);
            //    if (i % size == 0)
            //    {
            //        row++;
            //        if (row > size)
            //            row = 1;
            //    }
            //    else
            //    {
            //        row--;
            //        col--;
            //        if (row == 0)
            //            row = size;
            //        if (col == 0)
            //            col = size;
            //    }
            //}

            ////Get sum, average ,max ,min of integers given by the user
            //Console.Write("Please enter # of numbers: ");
            //int arrsize = int.Parse(Console.ReadLine());
            //int[] arr = new int[arrsize];
            //int sum = 0;
            //double average;
            //max = int.MinValue;
            //min = int.MaxValue;
            //Console.WriteLine("enter numbers");
            //for (int i = 0; i < arrsize; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //    sum += arr[i];
            //    max = arr[i] > max ? arr[i] : max;
            //    min = arr[i] < min ? arr[i] : min;
            //}
            //average = sum / (double)arrsize;

            //Console.WriteLine($"Sum = {sum}, average = {average}, max = {max}, min = {min}");

            //// Calculate the result of one operation Equation
            //Console.WriteLine("Enter the equation");
            //string equation = Console.ReadLine();

            //if (equation.Contains('+'))
            //{
            //    string[] num = equation.Split('+');
            //    Console.WriteLine($"{int.Parse(num[0])} + {int.Parse(num[1])} = {int.Parse(num[0]) + int.Parse(num[1])}");
            // }
            //else if (equation.Contains('*'))
            //{
            //    string[] num = equation.Split('*');
            //    Console.WriteLine($"{int.Parse(num[0])} * {int.Parse(num[1])} = {int.Parse(num[0]) * int.Parse(num[1])}");
            //}
            //else if (equation.Contains('-'))
            //{
            //    string[] num = equation.Split('-');
            //    Console.WriteLine($"{int.Parse(num[0])} - {int.Parse(num[1])} = {int.Parse(num[0]) - int.Parse(num[1])}");
            //}
            //else if (equation.Contains('/'))
            //{
            //    string[] num = equation.Split('/');
            //    Console.WriteLine($"{int.Parse(num[0])} / {int.Parse(num[1])} = {int.Parse(num[0]) / int.Parse(num[1])}");
            // }

            ////Design a program to Get the degree of 3 student with 4 subject from user input then calculate
            //int[,] student = new int[3, 4];
            //for (int i = 0; i < student.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter degrees of {i +1} student");
            //    for (int e = 0; e < student.GetLength(1); e++)
            //    {
            //        student[i, e] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < student.GetLength(0); i++)
            //{
            //    sum = 0;
            //    for (int s = 0; s < student.GetLength(1); s++)
            //    {
            //        sum += student[i, s];
            //    }
            //    Console.WriteLine($"Total degree for {i +1} student = {sum}");
            //}
            //for (int i = 0; i < student.GetLength(1); i++)
            //{
            //    sum = 0;
            //    for (int s = 0; s < student.GetLength(0); s++)
            //    {
            //        sum += student[s, i];
            //    }
            //    Console.WriteLine($"Average degree for {i + 1} subject = {sum / 3}");

            //}

            //Design a program that get from user input Number of class room Number of student in each class Mark for each student
            int numclassroom, numStu, markStu;
            Console.Write("Number of class room: ");
            numclassroom = int.Parse(Console.ReadLine());
            int sum = 0;
            //Console.Write("Mark for each student: ");
            //markStu = int.Parse(Console.ReadLine());

            int[][] classRoom = new int[numclassroom][];

            for (int i = 0; i < classRoom.GetLength(0); i++)
            {
                Console.Write($"Number of student in class {i + 1}: ");
                numStu = int.Parse(Console.ReadLine());

                classRoom[i] = new int[numStu];
                for (int j = 0; j < numStu; j++)
                {
                    Console.Write($"Mark for {j + 1} student in claass {i + 1}: ");
                    markStu = int.Parse(Console.ReadLine());
                    classRoom[i][j] = markStu;
                }
            }
            for (int i = 0; i < classRoom.Length; i++)
            {
                sum = 0;
                for (int j = 0; j < classRoom[i].Length; j++)
                {
                    sum += classRoom[i][j];
                }
                Console.WriteLine($"Average Mark for class romm {i + 1} = {sum / classRoom[i].Length}");
            }




        }
    }
}
