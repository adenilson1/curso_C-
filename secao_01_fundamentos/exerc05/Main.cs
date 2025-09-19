using System;

class Program
{
    static void Main()
    {
        // area de um quadrilatero
        Console.WriteLine("Entre com a altura: ");
        double altura = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Entre com o comprimento: ");
        double comprimento = Convert.ToDouble(Console.ReadLine());

        double area = altura * comprimento;
        Console.WriteLine("Área do quadrilatero = " + area);
    }
}