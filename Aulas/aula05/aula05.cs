using System;
class Aula05
{
    static void Main()
    {
        int res = (10 + 5) * 2;
        Console.WriteLine(res);

        bool res1 = 10 < 5;
        Console.WriteLine(res1);

        bool res3 = 10 != 2;
        Console.WriteLine(res3);

        int num = 10;
        //nuum += 1; //=== num = num+1; === num++
        num += 2; // num=num+2; +  -  /  *
        Console.WriteLine(num);

        // & = AND / E
        // | = OR / OU
        bool res4 = (5 > 3) & (10 < 5);
        Console.WriteLine(res4);
    }
}