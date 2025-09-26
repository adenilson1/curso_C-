using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.IO;

class Principal
{
    static void Main()
    {
        // criar pasta
        // string pasta = @"C:\Users\adeni\Desktop\CodigosC#\secao_08_sistemas_operativo_arquivos_e_threading\aula05\Testes";
        // Directory.CreateDirectory(pasta);

        //cria arquivo
        // string file = @"C:\Users\adeni\Desktop\CodigosC#\secao_08_sistemas_operativo_arquivos_e_threading\aula05\Testes\Texto.txt";
        // File.Create(file);

        //copiar arquivo
        // string file1 = @"C:\Users\adeni\Desktop\CodigosC#\secao_08_sistemas_operativo_arquivos_e_threading\aula05\Testes\Texto.txt";
        // string file2 = @"C:\Users\adeni\Desktop\CodigosC#\secao_08_sistemas_operativo_arquivos_e_threading\aula05\Testes\Outro.txt";
        // File.Copy(file1, file2);

        //mover arquivos
        // string file1 = @"C:\Users\adeni\Desktop\CodigosC#\secao_08_sistemas_operativo_arquivos_e_threading\aula05\Testes\Texto.txt";
        // string file2 = @"C:\Users\adeni\Desktop\CodigosC#\secao_08_sistemas_operativo_arquivos_e_threading\aula05\Testes2\Movido.txt";
        // File.Move(file1, file2);

        //delete arquivo
        string file2 = @"C:\Users\adeni\Desktop\CodigosC#\secao_08_sistemas_operativo_arquivos_e_threading\aula05\Testes2\Movido.txt";
        File.Delete(file2);
        
  
    }
}