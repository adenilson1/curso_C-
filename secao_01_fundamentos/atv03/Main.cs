using System;

class Program
{
    static void Main()
    {
        //calculo de comissão
        const double comissão = 5 / 100;
        Console.WriteLine("Nome do vendedor");
        string nome = Console.ReadLine();
        Console.WriteLine("Codigo da peça:");
        int codigo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Preço unitário da peça:");
        double preco_unitario = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Quantidade vendida:");
        int quantidade_vendida = Convert.ToInt32(Console.ReadLine());

        double venda = quantidade_vendida * preco_unitario;
        double pagamento_comissao = venda + venda * comissão;
        Console.WriteLine(
            string.Format(
                "\n\nVendedor: {0}\nCodigo: {1}\nPreço unitário: R${2}\nQuatidade vendida: {3}\nPagamento de comissão de R${4}",
                nome,codigo,preco_unitario,quantidade_vendida,pagamento_comissao
            )
        );

    }
}