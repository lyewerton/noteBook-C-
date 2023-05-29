using System;
class calculadora27
{
    static void Main()
    {
        char res;
        char fim;

    inicio:


        Console.WriteLine("Selecione a operação: [A] Soma [B] Subtração [C] Divisão [D] Multiplicação");
        res = char.Parse(Console.ReadLine());

        if (res == 'a' || res == 'A') { soma(48, 75); }
        else if (res == 'b' || res == 'B') { subtracao(5, 25); }
        else if (res == 'c' || res == 'C') { divisao(125, 5); }
        else if (res == 'd' || res == 'D') { multiplicacao(); }
        else { Console.WriteLine("Operação Invalida. Tente Novamente!!"); }

        Console.WriteLine("Deseja fazer outra operação? [s/n]");
        fim = char.Parse(Console.ReadLine());

        if (fim == 's' || fim == 'S')
        {
            goto inicio;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Fim do programa!!");
        }
    }


    static void soma(params float[] n)
    {
        float res = 0;

        if (n.Length < 1)
        {
            Console.WriteLine("Valores insuficientes!!");
        }
        else if (n.Length < 2)
        {
            Console.WriteLine("Valores insuficientes para soma!! {0}", n[0]);
        }
        else
        {
            for (int i = 0; i < n.Length; i++)
            {
                res += n[i];
            }
            Console.WriteLine("A soma dos valores é: {}", res);
        }
    }


    static void subtracao(params float[] n)
    {
        float res = 0;

        if (n.Length < 1)
        {
            Console.WriteLine("Valores insuficientes!!");
        }
        else if (n.Length < 2)
        {
            Console.WriteLine("Valores insuficientes para subtração!!: {0}", n[0]);
        }
        else
        {
            for (int i = 0; i < n.Length; i++)
            {
                res -= n[i];
            }
        }
        Console.WriteLine("A subtração dos valores é: {0}", res);
    }


    static void divisao(params float[] n)
    {
        float res = 0;
        if (n.Length < 1)
        {
            Console.WriteLine("Valores insuficientes!!");
        }
        else if (n.Length < 2)
        {
            Console.WriteLine("Valores insuficientes para divisão: {0}", n[0]);
        }
        else
        {
            for (int i = 0; i < n.Length; i++)
            {
                res += n[i];
            }
        }
        Console.WriteLine("A divisão dos valores é: {0}", res);
    }



    static void multiplicacao(params float[] n)
    {
        float res = 0;

        if (n.Length < 1)
        {
            Console.WriteLine("Valores insuficientes");
        }
        else if (n.Length < 2)
        {
            Console.WriteLine("Valores insuficientes para multipolicação");
        }
        else
        {
            for (int i = 0; i < n.Length; i++)
            {
                res += n[i];
            }
        }
        Console.WriteLine("O resultado da multiplicação é: {0}", res);
    }
}