using System;

class Program
{
    static void Main()
    {
    inicio:
        Console.WriteLine("Escolha a letra F ou M");
        string sexo = Console.ReadLine();

        if (sexo == "M" || sexo == "m")
        {
            Console.WriteLine("M - Masculino");

        }
        else if (sexo == "F" || sexo == "f")
        {
            Console.WriteLine("F - Feminino");
        }
        else
        {
            Console.WriteLine("Sexo inválido");
            goto inicio;
        }

    }
}