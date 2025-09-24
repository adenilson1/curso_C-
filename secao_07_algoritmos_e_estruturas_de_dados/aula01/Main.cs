using System;

class Principal
{
    static void Main()
    {
        int[] vetor = new int[5] { 5, 7, 1, 3, 9 };
        BubbleSort(vetor);

        foreach (var item in vetor)
        {
            Console.Write(item + " ");
        }
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int t = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = t;

                }

            }

        }
    }
}