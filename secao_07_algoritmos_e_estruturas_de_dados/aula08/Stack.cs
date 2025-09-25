using System;
using System.Collections.Generic;

class Principal
{
    static void Main()
    {
        Stack<int> pilha = new Stack<int>();
        pilha.Push(10);
        pilha.Push(20);
        pilha.Push(30);

        // pilha.Pop(); // retira o elemento que esta no topo

        foreach (var item in pilha)
        {
            Console.WriteLine(item);
        }
    }
}