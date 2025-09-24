using System;
using System.Collections.Generic;

class Principal
{
    static void Main()
    {
        LinkedList<int> Lista1 = new LinkedList<int>();
        Lista1.AddFirst(10);
        Lista1.AddFirst(20);
        Lista1.AddFirst(30);

        // foreach (var item in Lista1)
        // {
        //     Console.WriteLine(item);
        // }

        LinkedListNode<int> no;
        no = Lista1.FindLast(20);
        Lista1.AddAfter(no, 50);

        foreach (var item in Lista1)
        {
            Console.WriteLine(item);
        }
    }
}