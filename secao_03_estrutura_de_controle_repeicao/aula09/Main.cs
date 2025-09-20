using System;

class Principal
{
    static void Main()
    {
        int[] array = { 1, 2, 3 };

        // for (int i = 0; i < array.Length; i++) {
        //     Console.WriteLine(array[i]);
        // }

        foreach (int n in array)
        {
            Console.WriteLine(n + " Olá, Mundo!");
        }
    }
}