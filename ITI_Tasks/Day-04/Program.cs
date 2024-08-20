namespace Day_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex number1 = new(5, 6);
            Complex number2 = new(54, 6);

            Complex.Display(Complex.Add(number1, number2));
            Complex.Display(Complex.Subtract(number1, number2));
        }
    }
    public struct Complex
    {
        public int real;
        public int imaginary;
        public Complex(int r, int i)
        {
            real = r;
            imaginary = i;
        }
        public static Complex Add(Complex complex1, Complex complex2)
        {
            return new Complex(complex1.real + complex2.real, complex1.imaginary + complex2.imaginary);
        }
        public static Complex Subtract(Complex complex1, Complex complex2)
        {
            return new Complex(complex1.real - complex2.real, complex1.imaginary - complex2.imaginary);
        }
        public static void Display(Complex complex)
        {
            Console.WriteLine($"Real = {complex.real} & Imaginary = {complex.imaginary}");
        }
    }
}
