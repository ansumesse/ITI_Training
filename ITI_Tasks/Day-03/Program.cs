namespace Day_03
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
        }
       public static int Factorial(int number)
        {
            if (number == 1)
                return 1;
            return number * Factorial(number - 1);
        } 
    }
}
