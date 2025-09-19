using System;

class Program
{
    static void Main()
    {
        // media de notas
        const int qt = 4;
        Console.WriteLine("Digite a nota 1: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a nota 2: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a nota 3: ");
        double nota3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a nota 4: ");
        double nota4 = Convert.ToDouble(Console.ReadLine());

        double media = (nota1 + nota2 + nota3 + nota4) / qt;
        Console.WriteLine("A media = " + media );
    }
}