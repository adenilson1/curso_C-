using System;

class Principal
{
    static void Main()
    {
        int[] vetor = new int[5] { 5, 7, 1, 3, 9 };
        InSort(vetor);

        foreach (var item in vetor)
        {
            Console.Write(item + " ");
        }

    }

    static void InSort(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }

            arr[j + 1] = key;
        }
    }
}

