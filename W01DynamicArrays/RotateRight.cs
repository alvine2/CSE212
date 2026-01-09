using System;

public static class RotateRight
{
    /*
     PLAN: ROTATE RIGHT
     1. Create an array with sample values.
     2. Save the last element.
     3. Shift all elements one position to the right.
     4. Place the last element at the first index.
     5. Display the rotated array.
    */

    public static void Run()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        Console.Write("Original: ");
        PrintArray(numbers);

        int last = numbers[numbers.Length - 1];

        for (int i = numbers.Length - 1; i > 0; i--)
        {
            numbers[i] = numbers[i - 1];
        }

        numbers[0] = last;

        Console.Write("Rotated: ");
        PrintArray(numbers);
    }

    private static void PrintArray(int[] arr)
    {
        foreach (int n in arr)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();
    }
}
