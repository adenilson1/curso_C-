using System;

class Program
{
    static void Main()
    {
        //produto e soma
        Console.WriteLine("Digite 4 valores inteiros POSITIVOS");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());
        int num4 = Convert.ToInt32(Console.ReadLine());

        int soma_1_2 = num1 + num2;
        int soma_1_3 = num1 + num3;
        int soma_1_4 = num1 + num4;

        int soma_2_3 = num2 + num3;
        int soma_2_4 = num2 + num4;

        int soma_3_4 = num3 + num4;

        int produto_1_2 = num1 * num2;
        int produto_1_3 = num1 * num3;
        int produto_1_4 = num1 * num4;

        int produto_2_3 = num2 * num3;
        int produto_2_4 = num2 * num4;

        int produto_3_4 = num3 * num4;

        Console.WriteLine(
            string.Format(
                "\n\nSOMA:\n{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n\nPRODUTO:\n{6}\n{7}\n{8}\n{9}\n{10}\n{11}",
                soma_1_2,soma_1_3,soma_1_4,soma_2_3,soma_2_4,soma_3_4,
                produto_1_2,produto_1_3,produto_1_4,produto_2_3,produto_2_4,produto_3_4
            )
        );


    }
}