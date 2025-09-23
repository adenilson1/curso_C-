using System;

class Principal
{
    static void Main()
    {
        Console.WriteLine("COMISSÃO DE VENDEDORES");
        Console.Write("Nome do vedendor: ");
        string nome = Console.ReadLine();
        Console.Write("Código da peça: ");
        int codigo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Preço unitário: ");
        double preco_unitario = Convert.ToDouble(Console.ReadLine());
        Console.Write("Quantidade vendida: ");
        int quantidade = Convert.ToInt32(Console.ReadLine());

        double comissao = preco_unitario * quantidade +  (preco_unitario * quantidade) * 5 / 100;
        Console.WriteLine(
            string.Format(
                "\nNome: {0}\nCódigo: {1}\nPreço unitário: {2}\nQunatidade vendidas: {3}\nPagamento de comissão: R${4}",
                nome,codigo,preco_unitario,quantidade, comissao
            )
        );
    }
}