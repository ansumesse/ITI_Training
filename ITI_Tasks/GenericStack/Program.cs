namespace GenericStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s1 = new Stack<int>(3);
            s1.Push(1);
            s1.Push(2);
            s1.Push(3);
            Stack<string> s2 = new Stack<string>(3);
            s2.Push("Ahmed");
            s2.Push("mohamed");
            s2.Push("ali");
            
            for (int i = 0; i < s1.size; i++)
            {
                Console.WriteLine(s1[i]);
            }
            for (int i = 0; i < s1.size; i++)
            {
                Console.WriteLine(s2.GetByIndex(i));
            }
        }
    }
}
