using System;

class Principal
{
    static void Main()
    {
        // estrutura1 valores;
        // valores.n1 = 20;
        // Console.WriteLine(valores.n1);

        // estrutura1 obj = new estrutura1(20,30);
        // Console.WriteLine(obj.n1);

        estrutura1[] vetores = new estrutura1[2];
        vetores[0].n1 = 10;
        vetores[1].n1 = 20;

        Console.WriteLine(vetores[0].n1);

    }
}
struct estrutura1
{
    public int n1;
    public int n2;

    public estrutura1(int n1, int n2)
    {
        this.n1 = n1;
        this.n2 = n2;
    }
}