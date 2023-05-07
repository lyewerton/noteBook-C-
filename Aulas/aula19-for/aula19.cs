using System;
class aula19
{
    static void Main()
    {
        int[] num = new int[10];

        for (int i = 0; i < 10; i++)
        {
            num[i] = 0;
            //Console.WriteLine(num[i]);
        }
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Valor de num na pos{0}: {1}", i, num[i]);
        }

        //  for (int num = 0; num < 10; num++)
        //  {
        //      Console.WriteLine("Valor de num: {0}", num);
        //  }
    }
}