using System;
class aula15
{
    static void Main()
    {
        int tempo = 0;
        char escolha;

        Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
        Console.WriteLine("Escolha o transporte: [A] Avião | [B] Carro | [C] Ônibus");

        escolha = char.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 'A':
            case 'a':
                tempo = 50;
                break;
            case 'B':
            case 'b':
                tempo = 480;
                break;
            case 'C':
            case 'c':
                tempo = 660;
                break;
            default:
                tempo = -1;
                break;
        }
        if (tempo < 0)
        {
            Console.WriteLine("Transporte indisponível!");
        }
        else
        {
            Console.WriteLine("Para o transporte escolhido, o tempo é: {0} minutos", tempo);
        }
    }
}