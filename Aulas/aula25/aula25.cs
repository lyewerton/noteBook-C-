using System;
class aula25
{
    static void Main()
    {
        int num = 10;
        dobrar(ref num);
        Console.WriteLine(num);
    }

    static void dobrar(ref int valor)
    {
        valor *= 2;
    }

    static void dobrar2(int valor)
    {
        valor *= 2;
    }
}