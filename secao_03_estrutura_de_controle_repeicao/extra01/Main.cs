using System;

class Principal
{
    static void Main()
    {
        Console.WriteLine("Digite a palavra");
        string palavra = Console.ReadLine();


        int a = 0;
        int b = palavra.Length - 1;
        bool c = true;

        while (a < b && c != false)
        {

            if (palavra[a++] == palavra[b--])
            {
                c = true;
            }
            else
            {
                c = false;
            }

        }

        if (c == true)
        {
            Console.WriteLine("Palindromo");

        }
        else
        {
            Console.WriteLine("não palindromo");
        }

    }
}