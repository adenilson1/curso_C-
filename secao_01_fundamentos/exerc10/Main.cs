using System;

class Program
{
    static void Main()
    {
        //Calculo de Download
        Console.WriteLine("Qual o tamanho do arquivo em MB?");
        double tamanho_arquivo = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Qual é a velocidade da internet em Mbps? ");
        double velocidade_internet = Convert.ToDouble(Console.ReadLine());

        double tempo_download = Math.Floor(tamanho_arquivo * 8 / velocidade_internet);
        Console.WriteLine(
            string.Format(
                "O arquivo de {0}MB e com velocidade de {1}Mbps, o tempo de Download é {2}s",
                 tamanho_arquivo, velocidade_internet, tempo_download
            )
        );
    }
}