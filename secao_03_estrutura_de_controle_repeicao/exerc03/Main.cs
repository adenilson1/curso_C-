using System;

class Principal
{
    static void Main()
    {
        for (int i = 0; i < 50; i++)
        {
            if ((i + 1) % 2 != 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}