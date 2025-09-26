using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.IO;

class Principal
{
    static void Main()
    {
        string pastas = @"C:\Users\adeni\Desktop\CodigosC#\secao_01_fundamentos\erro";
        // var files = Directory.GetFiles(pastas, "*.*", SearchOption.TopDirectoryOnly);

        // foreach (string file in files)
        // {
        //     var info  = new FileInfo(file);
        //     Console.WriteLine(file.Length);
        // }

        bool existencia = Directory.Exists(pastas);
        Console.WriteLine(existencia);
    }
}