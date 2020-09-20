using System;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            string[] a = "teste de split".Split(' ');

            for (int i = 0; i < a.Length; i++) {
                Console.WriteLine(a[i]);
            }
        }
    }
}
