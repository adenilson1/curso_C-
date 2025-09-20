using System;

class Program
{
    static void Main()
    {
        inicio:
        Console.WriteLine("QUE HORAS SÃO?");
        double hora = Convert.ToDouble(Console.ReadLine());

        if (hora >= 6 && hora < 12)
        {
            Console.WriteLine("Bom dia");
        }
        else if (hora >= 12 && hora < 18)
        {
            Console.WriteLine("Boa tarde");
        }
        else if (hora < 6)
        {
            Console.WriteLine("Boa noite");
        }
        else if (hora == 00 || hora < 24)
        {
            Console.WriteLine("Boa noite");
        }
        else
        {
            Console.WriteLine("HORA NAO EXISTE");
            goto inicio;
        }
    }
}