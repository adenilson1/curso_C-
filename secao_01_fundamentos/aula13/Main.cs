using System;
class Program
{
    static void Main()
    {
        //tratamento de strings parte 2
        string text = "Ola mundo";
        // Console.WriteLine(text.Substring(3));// corte de string ate a posicao do 3 caracter, começo contando 0.
        Console.WriteLine(text.Substring(3, 4)); // comece de 3 ate 4.

        //replace
        string text1 = "Ola mundo";

        Console.WriteLine(text1.Replace("mundo", "coisa")); // substituir carcters por outros

        


    }
}