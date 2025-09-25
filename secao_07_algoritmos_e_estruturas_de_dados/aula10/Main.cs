using System;
using System.Collections.Generic;

class Principal
{
    static void Main()
    {
        ArvoreBinaria tree = new ArvoreBinaria();
        tree.inserir(50);
        tree.inserir(30);
        tree.inserir(20);
        tree.inserir(40);
        tree.inserir(70);
        tree.inserir(60);
        tree.inserir(80);

        tree.iniciar();
    }
}

class Node
{
    public int valor;
    public Node esq, dir;

    public Node(int v)
    {
        valor = v;
        esq = dir = null;

    }
}

class ArvoreBinaria
{
    public Node raiz;
    public ArvoreBinaria()
    {
        raiz = null;
    }
    public void inserir(int val)
    {
        raiz = Adicionar(raiz, val);
    }

    //inserir elementos
    public Node Adicionar(Node raiz, int valor)
    {
        if (raiz == null)
        {
            raiz = new Node(valor);
            return raiz;
        }
        if (valor < raiz.valor)
        {
            raiz.esq = Adicionar(raiz.esq, valor);
        }
        else if (valor > raiz.valor)
        {
            raiz.dir = Adicionar(raiz.dir, valor);
        }

        return raiz;
    }
    //Percorrer a estrutura
    public void Percorrer(Node raiz)
    {
        if (raiz != null)
        {
            Percorrer(raiz.esq);
            Console.Write(raiz.valor + " ");
            Percorrer(raiz.dir);
            // esq - raiz - dir 
        }
    }

    public void iniciar()
    {
        Percorrer(raiz);
    }
}

/*
        50
       /  \
    30     70
   /  \   /  \
20    40 60   80





*/