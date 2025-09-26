using System;
using System.Collections.Generic;

class Principal
{
    static void Main()
    {
        var os = Environment.OSVersion;
        Console.WriteLine(os.Platform);
        Console.WriteLine(os.Version.Major);
        Console.WriteLine(os.Version.Minor);
        Console.WriteLine(os.ServicePack);
        Console.WriteLine(os.VersionString);

    }
}