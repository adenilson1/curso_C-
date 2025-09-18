using System;

class Program
{
    static void Main()
    {
        //tipos numerico decimais

        //flot 4bytees, decimal 8 bytes e double 16 bytes, diferença entre eles é a presicao.
        float num1 = 20.1f; // 6-9
        Console.WriteLine(num1);

        //double
        double num2 = 20.123; // 15-17
        Console.WriteLine(num2);

        //decimal
        decimal num3 = 20.1239m; // 28-29
        Console.WriteLine(num3);

    }
}