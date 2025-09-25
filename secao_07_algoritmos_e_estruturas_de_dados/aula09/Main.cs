using System;
using System.Collections.Generic;


class Principal
{
    static void Main()
    {
        Arvore<int> tree = new Arvore<int>(1);
        tree.AddFilho(tree.Raiz, 2);
        tree.AddFilho(tree.Raiz, 3);


        TreeNode<int> no2 = tree.Raiz.Filhos[0];
        tree.AddFilho(no2, 4);
        tree.AddFilho(no2, 5);

        tree.Percorrer(tree.Raiz);
    }
}

class TreeNode<T>
{
    public T Valor;
    public List<TreeNode<T>> Filhos;

    public TreeNode(T valor)
    {
        Valor = valor;
        Filhos = new List<TreeNode<T>>();
    }

}


class Arvore<T>
{
    public TreeNode<T> Raiz;
    public Arvore(T valorRaiz)
    {
        Raiz = new TreeNode<T>(valorRaiz);
    }

    //Adionar Filho
    public void AddFilho(TreeNode<T> pai, T valorFilho)
    {
        pai.Filhos.Add(new TreeNode<T>(valorFilho));
    }

    //Percorrer a estrutura
    public void Percorrer(TreeNode<T> no)
    {
        if (no != null)
        {
            Console.WriteLine(no.Valor);
            foreach (var filho in no.Filhos)
            {
                Percorrer(filho);
            }
        }
    }
}