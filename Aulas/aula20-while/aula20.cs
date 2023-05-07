using System;
class aula20
{
    static void Main()
    {
        int[] num = new int[10];

        int i = 0;
        while (i < num.Length)
        {
            num[i] = 0;
            Console.WriteLine(num[i]);
            i++;
        }
        Console.WriteLine("Fim do Loop");

        // for (int i = 0; i < 10; i++)
        // {
        //     num[i] = 0;
        //     //Console.WriteLine(num[i]);
        // }
        // for (int i = 0; i < 10; i++)
        // {
        //     Console.WriteLine("Valor de num na pos{0}: {1}", i, num[i]);
        // }
    }
}