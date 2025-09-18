using System;

class Program
{
    static void Main()
    {
        //tratamento de strings
        //formatação de caracteres

        string frase = "Olá, Mundo!";
        string nome = "Pedro";
        int num1 = 10;


        string frase_minuscula = frase.ToUpper();
        string frase_maiscula = frase.ToLower();

        Console.WriteLine(frase_minuscula); //Maisculas
        Console.WriteLine(frase_maiscula); //Maisculas
        Console.WriteLine("-----------------------");

        string text = string.Format("Olá {0}, seja {1} bem vindo!", nome, num1);
        Console.WriteLine(text);
        Console.WriteLine("-----------------------");
        
        //outra forma
        Console.WriteLine(string.Format("Ola {0}, vc tirou a nota {1} no trabalho da escola!", nome, num1));

    }
}