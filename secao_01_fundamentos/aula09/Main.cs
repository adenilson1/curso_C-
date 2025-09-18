using System;

class Program
{
    static void Main()
    {
        // Conversão de tipos de dados:double > float > long > int > char
        // implicita: menor para o maior
        int num1 = 20;
        float num2 = num1;
        Console.WriteLine(num2);


        //explicita: maior para o menor typecast
        float num3 = 20.5f;
        int num4 = (int)num3; //typecast
        Console.WriteLine(num4);


    }
}