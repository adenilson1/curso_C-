using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

class Principal
{
    static void Main()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            Console.WriteLine("SO: Windows");
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            Console.WriteLine("SO: MacOS");
        }
        else if(RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            Console.WriteLine("SO: Linux");
        }
    }
}