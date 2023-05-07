using System;
class calculadora
{
    static void Main()
    {
        float valor1 = 0;
        float valor2 = 0;
        char escolha;
        float res = 0;

    inicio:
        Console.Clear();

        Console.WriteLine("Primeiro Valor: ");
        valor1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Segundo Valor: ");
        valor2 = float.Parse(Console.ReadLine());

        Console.WriteLine("Escolha a Operação:\n[A] Soma [B] Diminuir [C] Dividir [D] Multiplicar");
        escolha = char.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 'A':
            case 'a':
                res = valor1 + valor2;
                Console.WriteLine("O resultado da soma é: {0}", res);
                break;
            case 'B':
            case 'b':
                res = valor1 - valor2;
                Console.WriteLine("O resultado da diminuição é: {0}", res);
                break;
            case 'C':
            case 'c':
                res = valor1 / valor2;
                Console.WriteLine("O resultado da divisão é: {0}", res);
                break;
            case 'D':
            case 'd':
                res = valor1 * valor2;
                Console.WriteLine("O resultado da multiplocação é: {0}", res);
                break;
            default:
                Console.WriteLine("Escolha uma operação aceita");
                break;
        }


        Console.WriteLine("\n ------------------------------------------ \n");
        Console.WriteLine("Deseja fazer outra operação?\n[S/N]: ");
        escolha = char.Parse(Console.ReadLine());

        if (escolha == 's' || escolha == 'S')
        {
            goto inicio;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Fim do Programa");
        }

    }
}