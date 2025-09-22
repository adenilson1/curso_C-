using System;

class Principal
{
    static void Main()
    {
        Console.WriteLine("QUANTIDADE DE UMA PEÇA EM ESTOQUE");
        Console.Write("QUANTIDADE DE MINIMA: ");
        int qta_minima = Convert.ToInt32(Console.ReadLine());
        Console.Write("QUANTIDADE DE MAXIMA: ");
        int qta_maxima = Convert.ToInt32(Console.ReadLine());

        int media = (qta_maxima - qta_minima)/2;
        Console.WriteLine("MEDIA = " + media);
    }

}