using System;

class Principal
{
    static void Main()
    {
        Classe1 obj = new Classe1();
        obj[1] = 30;
        Console.WriteLine(obj[1]);
    }
}

class Classe1
{
    private int[] nums = new int[3] { 10, 20, 30 };
    public int this[int i] // indexador (i - indice)
    {
        get { return nums[i]; }
        set { nums[i] = value; }
    }
}