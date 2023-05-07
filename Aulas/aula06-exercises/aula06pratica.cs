using System;
class lucrosDoDia
{
    static void Main()
    {
        double valorTenis1;
        double valorTenis2;
        double valorTenis3;
        double valorTenis4;
        double valorTenis5;
        double valorTenis6;
        double valorTenis7;
        double valorTenis8;
        double valorTenis9;

        valorTenis1 = 40;
        valorTenis2 = 45;
        valorTenis3 = 60;
        valorTenis4 = 80;
        valorTenis5 = 240;
        valorTenis6 = 500;
        valorTenis7 = 150;
        valorTenis8 = 320;
        valorTenis9 = 77;


        double valorEntrega1;
        double valorEntrega2;
        double valorEntrega3;
        double valorEntrega4;

        valorEntrega1 = 7;
        valorEntrega2 = 12;
        valorEntrega3 = 18;
        valorEntrega4 = 27;


        double totalPedido1;
        double totalPedido2;
        double totalPedido3;
        double totalPedido4;
        double totalPedido5;
        double totalPedido6;
        double totalPedido7;
        double totalPedido8;
        double totalPedido9;

        totalPedido1 = valorTenis6 + valorEntrega4;
        totalPedido2 = valorTenis2 + valorEntrega2;
        totalPedido3 = valorTenis8 + valorEntrega1;
        totalPedido4 = valorTenis9 + valorEntrega3;
        totalPedido5 = valorTenis3 + valorEntrega4;
        totalPedido6 = valorTenis4 + valorEntrega1;
        totalPedido7 = valorTenis7 + valorEntrega4;
        totalPedido8 = valorTenis5 + valorEntrega3;
        totalPedido9 = valorTenis1 + valorEntrega3;

        double valorTotalPedidos;
        valorTotalPedidos = totalPedido1 + totalPedido2 + totalPedido3 + totalPedido4 + totalPedido5 + totalPedido6 + totalPedido7 + totalPedido8 + totalPedido9;

        double valorTotalEntrega;
        valorTotalEntrega = valorTotalPedidos - valorTenis6 - valorTenis2 - valorTenis8 - valorTenis9 - valorTenis3 - valorTenis4 - valorTenis7 - valorTenis5;

        double lucro;
        lucro = valorTotalPedidos - valorTotalEntrega;

        Console.WriteLine("Total dos pedidos diario.........:{0,15:c}", valorTotalPedidos);
        Console.WriteLine("Total das taxas..................:{0,15:c}", valorTotalEntrega);
        Console.WriteLine("Lucro............................:{0,15:c}", lucro);
    }
}

// :p = %
// :c = R$