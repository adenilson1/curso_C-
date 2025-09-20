using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite dois numeros");
        double numero1 = Convert.ToDouble(Console.ReadLine());
        double numero2 = Convert.ToDouble(Console.ReadLine());

        inicio:
        Console.WriteLine("Escolha a operação que deseja: +, -, *, /");
        Console.WriteLine("[1] - Soma");
        Console.WriteLine("[2] - Subtração");
        Console.WriteLine("[3] - Multiplicação");
        Console.WriteLine("[4] - Divisão");
        int opcao = Convert.ToInt32(Console.ReadLine());
  

        switch (opcao)
        {
            case 1: Console.WriteLine(numero1 + numero2); break;
            case 2: Console.WriteLine(numero1 - numero2); break;
            case 3: Console.WriteLine(numero1 * numero2); break;
            case 4: Math.Round(Console.WriteLine(numero1 / numero2)); break;
            default: Console.WriteLine("Opção inválida"); goto inicio; break;
        }

    }
}