using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.IO;

class Principal
{
    static void Main()
    {
        // string pasta = @"C:\Users\adeni\Desktop\CodigosC#\secao_08_sistemas_operativo_arquivos_e_threading\aula06\Testes";
        // Directory.CreateDirectory(pasta);

        // string file = @"C:\Users\adeni\Desktop\CodigosC#\secao_08_sistemas_operativo_arquivos_e_threading\aula06\Testes\Exemplo.txt";
        // File.Create(file);

        //leitura de arquivos
        // string file = @"C:\Users\adeni\Desktop\CodigosC#\secao_08_sistemas_operativo_arquivos_e_threading\aula06\Testes\Exemplo.txt";
        // // Console.WriteLine(File.ReadAllText(file));

        // string[] linhas = File.ReadAllLines(file);
        // // Console.WriteLine(linhas[0]);
        // // Console.WriteLine(linhas[1]);
        // foreach (string linha in linhas)
        // {
        //     Console.WriteLine(linha);
        // }
        string file = @"C:\Users\adeni\Desktop\CodigosC#\secao_08_sistemas_operativo_arquivos_e_threading\aula06\Testes\Exemplo.txt";
        StreamWriter escritor = new StreamWriter(file);
        escritor.WriteLine("ESTOU VIVO MUNDO :) ");
        escritor.Close();
        
        





    }
}