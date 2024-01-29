using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[100];

        
        Random random = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 1000);
        }

      
        int smallest = numbers[0];
        int largest = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < smallest)
            {
                smallest = numbers[i];
            }
            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
        }

        Console.WriteLine("small: " + smallest);
        Console.WriteLine("big: " + largest);
    }
}