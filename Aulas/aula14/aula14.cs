// IF ANINHADO

using System;
class aula14
{
    static void Main()
    {
        float n1, n2, n3, n4, res;
        res = n1 = n2 = n3 = n4 = 0;
        string resultado;

        Console.WriteLine("Digite a nota 1: ");
        n1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite a nota 2: ");
        n2 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite a nota 3: ");
        n3 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite a nota 4: ");
        n4 = float.Parse(Console.ReadLine());

        res = (n1 + n2 + n3 + n4) / 4;

        if (res > 60.00)
        {
            if (res >= 99)
            {
                resultado = "Pegue meu emprego meu filho";
            }
            else if (res >= 90)
            {
                resultado = "Aprovado com louvor";
            }
            else
            {
                resultado = "Aprovado";
            }
        }
        else
        {
            if (res >= 40)
            {
                resultado = "Recuperação";
            }
            else
            {
                resultado = "Reprovado";
            }
        }

        Console.WriteLine("\nResultado: {0,15}\nMédia: {1,15}\n", resultado, res);
    }
}