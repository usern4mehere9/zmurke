using System;

namespace zmurke
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, nt;

            n = int.Parse(Console.ReadLine());

            nt = (n * 5) % 100;

            Console.WriteLine(nt);
        }
    }
}
