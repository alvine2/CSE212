using System;

public static class MultiplesOf
{
    /*
     PLAN: MULTIPLES OF
     1. Ask for a number (n).
     2. Ask for a maximum value (max).
     3. Create a dynamic array (int[]).
     4. Loop from n to max.
     5. If the number is divisible by n, add it to the array.
     6. Resize the array each time a new value is added.
     7. Display all multiples.
    */

    public static void Run()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter the maximum value: ");
        int max = int.Parse(Console.ReadLine());

        int[] multiples = new int[0];
        int count = 0;

        for (int i = n; i <= max; i++)
        {
            if (i % n == 0)
            {
                Array.Resize(ref multiples, count + 1);
                multiples[count] = i;
                count++;
            }
        }

        Console.Write("Multiples: ");
        foreach (int value in multiples)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }
}
