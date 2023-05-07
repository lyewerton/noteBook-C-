using System;

namespace aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meu Primeiro curso C#");
            if (args.GetLength(0) > 0)
            {
                Console.WriteLine(args.GetValue(0));
            }
        }
    }
}