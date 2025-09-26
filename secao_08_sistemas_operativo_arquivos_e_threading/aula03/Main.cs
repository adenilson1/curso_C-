using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.IO;

class Principal
{
    static void Main()
    {
        // string pastas = @"C:\Users\adeni\Desktop\CodigosC#\";
        // string[] dirs = Directory.GetDirectories(pastas, "*", SearchOption.AllDirectories); // pega todas as pastas
        // foreach (string dir in dirs)
        // {
        //     Console.WriteLine(dir);
        // }

        // string pastas = @"C:\Users\adeni\Desktop\CodigosC#\secao_01_fundamentos\aula01";
        // var files = Directory.GetFiles(pastas, "*.*", SearchOption.TopDirectoryOnly);
        // foreach (string file in files)
        // {
        //     Console.WriteLine(file);
        // }

        string pastas = @"C:\Users\adeni\Desktop\CodigosC#\secao_01_fundamentos\";
        var files = Directory.GetFiles(pastas, "*.*", SearchOption.AllDirectories);
        foreach (string file in files)
        {
            Console.WriteLine(file);
        }

    }
}