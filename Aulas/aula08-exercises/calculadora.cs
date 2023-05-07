using System;
class lucroDiario
{
    static void Main()
    {
        int vT1, vE1, somaP1;

        Console.WriteLine("Valor do produto: ");
        vT1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Valor da taxa de entrega: ");
        vE1 = int.Parse(Console.ReadLine());

        somaP1 = vE1 + vT1;
        Console.WriteLine("\nValor total do pedido é de: {0,15:c}\n\n", somaP1);
// ----------------------------------------------------------------------------------

        int vT2, vE2, somaP2;

        Console.WriteLine("Valor do produto: ");
        vT2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Valor da taxa de entrega: ");
        vE2 = int.Parse(Console.ReadLine());

        somaP2 = vE2 + vT2;
        Console.WriteLine("\nValor total do pedido é de: {0,15:c}\n\n", somaP2);
// --------------------------------------------------------------------------------


        int somaDosPedidos, valorDasTaxas, lucro;
        somaDosPedidos = somaP1 + somaP2;
        Console.WriteLine("O valor total dos pedidos é:..........{0,15:c}", somaDosPedidos);

        valorDasTaxas = vE1 + vE2;
        Console.WriteLine("O valor total das entregas foi de:....{0,15:c}", valorDasTaxas);

        lucro = vT1 + vT2;
        Console.WriteLine("O lucro obtido nos pedidos foi de:....{0,15:c}", lucro);
    }
}