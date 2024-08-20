namespace Picturetask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Picture pic = new Picture(new(10), new(4, 6), new(5, 7));
            Console.WriteLine(pic.TotalAreas());
            Console.ReadKey();
        }
    }
}
