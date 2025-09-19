using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um numero (0-9)");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("O numero é maior que 5? (s/n)");
        string res1 = Console.ReadLine();

        if (res1 == "s")
        {
            Console.WriteLine("O numero é par?(s/n)");
            string res2 = Console.ReadLine();

            if (res2 == "s")
            {
                Console.WriteLine("O numero é 6?(s/n)");
                string res3 = Console.ReadLine();

                if (res3 == "s")
                {
                    Console.WriteLine("Aceitei");
                }
                else
                {
                    Console.WriteLine("O numero é 8");
                }
            }
            else
            {
                Console.WriteLine("O numero é 7?(s/n)");
                string res4 = Console.ReadLine();

                if (res4 == "s")
                {
                    Console.WriteLine("Aceitei");
                }
                else
                {
                    Console.WriteLine("O numero é 9");
                }
            }

        }
        else if (res1 == "n")
        {
            Console.WriteLine("O numero é menor que 5? (s/n)");
            string res5 = Console.ReadLine();
            if (res5 == "s")
            {
                Console.WriteLine("O numero é impar?(s/n)");
                string res6 = Console.ReadLine();

                if (res6 == "s")
                {
                    Console.WriteLine("O numero é 3?(s/n)");
                    string res7 = Console.ReadLine();
                    if (res7 == "s")
                    {
                        Console.WriteLine("Aceitei");
                    }
                    else
                    {
                        Console.WriteLine("O numero é 1");
                    }

                }
                else
                {
                    Console.WriteLine("O numero é 4?(s/n)");
                    string res8 = Console.ReadLine();

                    if (res8 == "s")
                    {
                        Console.WriteLine("Aceitei");
                    }
                    else
                    {
                        Console.WriteLine("O numero é 2");
                    }
                }

            }


        }
        else
        {
            Console.WriteLine("Não conheço essa resposta");
        }
    }
}