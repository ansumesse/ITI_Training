namespace MyStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s1 = new Stack(3);
            s1.Push(1);
            s1.Push(2);
            s1.Push(3);
            Stack s2 = new Stack(3);
            s2.Push(4);
            s2.Push(5);
            s2.Push(6);
            Stack s3 = s1 + s2;
            for (int i = 0; i < s3.size; i++)
            {
                Console.WriteLine(s3[i]);
            }

        }
    }
}
