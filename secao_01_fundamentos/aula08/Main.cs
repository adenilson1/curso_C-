using System;

class Program
{
    static void Main()
    {
        // entradas  são textos -> strings
        Console.WriteLine("Digite aulguma coisa: ");
        string res = Console.ReadLine();
        // Console.ReadLine(); //ler linhas
        Console.WriteLine("Você digitou: " + res); //concatenação

    }
}