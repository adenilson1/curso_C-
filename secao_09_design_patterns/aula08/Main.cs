using System.Data;
using Internal;
using System;
using System.Collections.Generic; 



interface IComponente
{
    void Exibir(int prof);
}

class Folha : IComponente // OBJETOS SIMPLE
{
    private string nome;
    public Folha(string nome)
    {
        this.nome = nome;
    }

    public void Exibir(int prof)
    {
        Console.WriteLine(new string('-', prof) + nome);
    }

}

class Composto : IComponente
{
    public string nome;
    private List<IComponente> filhos = new List<IComponente>();
    public Composto(string nome)
    {
        this.nome = nome;
    }

    public void Adicionar(IComponente comp)
    {
        filhos.Add(comp);
    }

    public void Remover(IComponente comp)
    {
        filhos.Remove(comp);
    }

    public void Exibir(int prof)
    {
        Console.WriteLine(new string('-', prof) + nome);
        foreach (var filho in filhos)
        {
            filho.Exibir(prof + 2);
        }
    }
}
class Principal
{
    static void Main()
    {
        Composto raiz = new Composto("Raiz");
        raiz.Adicionar(new Folha("Folha1"));
        raiz.Adicionar(new Folha("Folha2"));

        Composto outro = new Composto("Outro");
        outro.Adicionar(new Folha("Outro1"));
        outro.Adicionar(new Folha("Outro2"));

        raiz.Adicionar(outro);
        raiz.Adicionar(new Folha("Folha3"));

        Folha folha = new Folha("Folha4");
        raiz.Adicionar(folha);
        raiz.Remover(folha);

        raiz.Exibir(1);
    }
}