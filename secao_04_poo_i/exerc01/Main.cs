using System;

class Principal
{
    static void Main()
    {
        Console.Write("Escreva uma palavra: ");
        string palavra = Console.ReadLine();

        bool verficacao = VerificaPalavraPalindromo(palavra);

        if (verficacao == true)
        {
            Console.WriteLine("PALÍNDROMO");
        }
        else
        {
            Console.WriteLine("NÃO É PALÍNDROMO");
        }
    }

    static bool VerificaPalavraPalindromo(string palavra)
    {
        int a = 0;
        int b = palavra.Length - 1;
        bool teste = true;

        while (a < b && teste != false)
        {
            if (palavra[a++] != palavra[b--])
            {
                teste = false;
            }

        }
        return teste;


    }
}