using System.Diagnostics;
using System.Threading;
using System.Reflection.Emit;
using System.Data;
using Internal;
using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.IO;


class Principal
{
    static void Main()
    {
        Thread t1 = new Thread(Metodo1);
        Thread t2 = new Thread(Metodo2);

        t1.Start();
        t2.Start();



        // Metodo1();
        // Metodo2();
    }

    public static void Metodo1()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Oá, Mundo");
            Thread.Sleep(1000);
        }

    }

    public static void Metodo2()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Oi de novo, Mundo");
            Thread.Sleep(1000);
        }
        
    }
}