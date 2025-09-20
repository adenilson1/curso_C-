using System;

class Principal
{
    static void Main()
    {
        bool controle = false;
        while (controle != true)
        {
            Console.WriteLine("Entre com um número de 0 a 10");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 0 && numero <= 10)
            {
                Console.WriteLine("Valor válido");
                controle = true;
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }

        }

    }
}