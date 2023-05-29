using System;

public class Jogador
{
    public int energia;
    public bool vivo;
    public string nome;
    public Jogador(string n)
    {
        energia = 100;
        vivo = true;
        nome = n;
    }
    ~Jogador()
    {
        Console.WriteLine("Jogador foi deletado");
    }
}
class aula28
{
    static void Main()
    {
        string nome;
        Console.WriteLine("Digite o nome do jogador 1: ");
        nome = Console.ReadLine();
        Jogador j1 = new Jogador(nome);
        Jogador j2 = new Jogador("Théo");

        j1.energia = 50;
        Console.WriteLine("Nome do jogadot 1: {0}", j1.nome);
        Console.WriteLine("Nome do jogadot 2: {0}", j2.nome);
    }
}