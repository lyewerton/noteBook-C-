using System;
class aula22
{
    static void Main()
    {
        int[] num = new int[5] { 11, 22, 33, 44, 55 };

        // for (int i = 0; i < num.Length; i++)
        // {
        //     Console.WriteLine(num[i]);
        // };

        foreach (int n in num)
        {
            Console.WriteLine(n);
        }

        //FOREACH execute apenas leitura dos elementos de uma coleção.
    }
}