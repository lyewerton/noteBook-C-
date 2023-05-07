using System;
class aula21
{
    static void Main()
    {
        string senha = "123";
        string senhaUser;
        int tentativas = 0;


        do
        {
            Console.Clear();
            Console.WriteLine("Digite a senha: ");
            senhaUser = Console.ReadLine();
            tentativas++;
        } while (senha != senhaUser);

        Console.Clear();
        Console.WriteLine("Senha Correta!\n{0} tentativas.", tentativas);


        //WHILE Teste e depois executa. já o DO WHILE execute primeiro e faz o teste depois.

    }
}