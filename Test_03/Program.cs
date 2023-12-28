using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        Console.WriteLine("Элементы массива, начиная с конца:");
        PrintArrayReversed(array, array.Length - 1);

        Console.ReadLine();
    }

    static void PrintArrayReversed(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.Write(arr[index] + " ");
            PrintArrayReversed(arr, index - 1);
        }
    }
}
