using System;
using System.Collections.Generic;

class Principal
{
    static void Main()
    {
        Dictionary<string, string> dcl1 = new Dictionary<string, string>()
        {
            {"Nome", "Pedro"},
            { "Pais", "Portugal"}
        };

        foreach (KeyValuePair<string, string> item in dcl1)
        {
            Console.WriteLine(item.Key);
            Console.WriteLine(item.Value);
            Console.WriteLine(item);
        }
        // //Nome -> Pedro
        // // País -> Portugal
        // dcl1.Add("Nome", "Pedro");
        // dcl1.Add("Pais", "Portugal");
        // Console.WriteLine(dcl1["Nome"]);

        // dcl1.COntainsValue();
    }
}