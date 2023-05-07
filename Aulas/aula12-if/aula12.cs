using System;
class aula12
{
    static void Main()
    {
        // if() === SE() se uma expressão for verdadeira, irá executar, caso não irá passar para a proxima operação
        // >  <  >=  <=  ==  !=

        float n1, n2, n3, n4, res;
        res = n1 = n2 = n3 = n4 = 0;
        string resultado = "reprovado";

        Console.WriteLine("Digite a nota 1: ");
        n1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite a nota 2: ");
        n2 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite a nota 3: ");
        n3 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite a nota 4: ");
        n4 = float.Parse(Console.ReadLine());

        res = (n1 + n2 + n3 + n4) / 4;

        if (res >= 60.00)
        {
            resultado = "aprovado";
        }

        Console.WriteLine("Você foi {0} com a média de {1}", resultado, res);

    }
}