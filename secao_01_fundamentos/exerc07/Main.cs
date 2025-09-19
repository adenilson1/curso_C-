using System;

class Program
{
    static void Main()
    {
        //calculo de salario
        Console.WriteLine("Quanto ganha por hora? ");
        double valor_hora = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Quantas horas trabalhadas? ");
        int horas = Convert.ToInt32(Console.ReadLine());

        double salario = valor_hora * horas;
        Console.WriteLine(
            string.Format(
                "Com {0} e com ganho por hora de {1}, seu salário é de R$ {2}", horas, valor_hora, salario
            )
        );
    }
}