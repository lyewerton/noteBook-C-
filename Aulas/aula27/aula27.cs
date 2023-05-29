using System;
class aula27
{
    static void Main()
    {
        soma(2);
    }

    static void soma(params int[] n)
    {
        int res = 0;

        if (n.Length < 1)
        {
            Console.WriteLine("Não existem valores a serem somados");
        }
        else if (n.Length < 2)
        {
            Console.WriteLine("Argumentos insuficientes para soma: {0}", n[0]);
        }
        else
        {
            for (int i = 0; i < n.Length; i++)
            {
                res += n[i];
            }
        }
        Console.WriteLine("A soma dos valores é: {0}", res);
    }

    // static void soma(int n1, int n2)
    // {
    //     int res = n1 + n2;
    //     Console.WriteLine("A soma de {0} com {1} é {3}", n1, n2, res);
    // }
}