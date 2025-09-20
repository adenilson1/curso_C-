using System;

class Principal
{
    static void Main()
    {
        int n1 = 0;

        // while (n1 < 10)
        // {
        //     if (n1 % 2 == 1)
        //     {//N1 impar

        //         n1++;
        //         continue;
        //     }
        //     Console.WriteLine(n1);
        //     n1++;
        // }

        while (true)
        {
            n1++;
            if (n1 == 5)
            {
                break;
            }
            Console.WriteLine(n1);
        }
    }
}