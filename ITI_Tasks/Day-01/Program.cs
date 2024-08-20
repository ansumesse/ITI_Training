namespace Day_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1st Number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter 2st Number: ");
            int num2 = int.Parse(Console.ReadLine());

            int total = num1 + num2;
            double average = total / 2.0;

            Console.WriteLine("Total = {0} and Average = {1}", total, average);
        }
    }
}
