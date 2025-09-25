using System;
using System.Collections.Generic;

class Principal
{
    static void Main()
    {
        Queue<int> fila = new Queue<int>();
        fila.Enqueue(10);
        fila.Enqueue(20);
        fila.Enqueue(30);

        fila.Dequeue();


        foreach (var item in fila)
        {
            Console.WriteLine(item);
        }
    }
}