//Calculadora Simples

using System;
class calculadora
{
    static void Main()
    {
        int v1, v2;
        int soma;

        Console.WriteLine("Digite um valor: ");
        v1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro valor: ");
        v2 = int.Parse(Console.ReadLine());


        soma = v1 + v2;
        Console.WriteLine("A soma de {0} + {1} é igual a {2}", v1, v2, soma);
    }
}