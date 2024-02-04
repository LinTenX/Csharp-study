namespace 运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            a = a + b;
            Console.WriteLine(a);

            b = a + b;
            Console.WriteLine(b);

            b = a - b;
            Console.WriteLine(b);

            a = a * b;
            Console.WriteLine(a);

            b = a + b / 3;
            Console.WriteLine(b);
        }
    }
}
