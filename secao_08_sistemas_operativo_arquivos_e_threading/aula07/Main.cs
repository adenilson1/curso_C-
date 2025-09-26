using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;
using Internal;



class Principal
{
    static void Main()
    {
        Console.WriteLine("Olá, Mundo");
        Thread.Sleep(3000); // milissegundos
        Console.WriteLine("Oi de novo Mundo");

        //outro caso
        int n = 0;
        while(n < 10){
            Console.WriteLine("Obrigado Mundo");
            Thread.Sleep(1000);
            n++;
        }
    }
}