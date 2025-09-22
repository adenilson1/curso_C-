using System;

class Principal
{
    static void Main()
    {
        int n1 = 10;
        int n2 = 0;

        try // tenta
        {
            Console.WriteLine(n1 / n2);

        }
        catch (Exception erro)
        {
            Console.WriteLine("Ouve um erro " + erro.Message);
        }
        finally
        {
            Console.WriteLine("Fim do tratamento");
            throw new Exception("Erro");
        }



    }
}