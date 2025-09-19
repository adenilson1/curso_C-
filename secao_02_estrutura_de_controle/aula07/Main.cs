using System;

class Program
{
    static void Main()
    {
        //Verificando tipos de variávies
        Console.WriteLine("Digite algo");
        int res =Convert.ToInt32(Console.ReadLine());


        if (res.GetType() == typeof(String))
        {
            Console.WriteLine("É uma string");
        }
        else
        {
            Console.WriteLine("Não uma string");
        }
        
    }
}