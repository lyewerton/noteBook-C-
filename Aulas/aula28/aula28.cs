using System;

public class Jofador
{
    public int energia = 100;
    public bool vivo = true;
}
class aula28
{
    static void Main()
    {
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador();
        Jogador j3 = new Jogador();

        j1.energia = 50;
        Console.WriteLine("Energia do jogadot 1: {0}", j1.energia);
        Console.WriteLine("Energia do jogadot 2: {0}", j2.energia);
        Console.WriteLine("Energia do jogadot 3: {0}", j3.energia);
    }
}