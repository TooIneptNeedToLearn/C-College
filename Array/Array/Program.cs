using System.Diagnostics.CodeAnalysis;

internal class ArrayPrac
{
    private static void ArrayFlip(string[] args)
    {
        //creating an array of int abd printing each line
        int[] arr = { 1, 2, 3, 4, 5 };
        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }
        //Using .Reverse operator to reverse the array content then printing it
        Array.Reverse(arr);
        Console.WriteLine("Reversing the array");
        foreach (int element in arr)
        {
            Console.WriteLine(element);
        }
    }
    private static void RandomAveSum(string[] args)
    {
        int sum;
        float ave;
        Random random = new Random();
        //setting array of int
        int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        sum = 0;
        //indexing each index with random number ranging from 1-100
        number[0] = random.Next(1, 100);
        number[1] = random.Next(1, 100);
        number[2] = random.Next(1, 100);
        number[3] = random.Next(1, 100);
        number[4] = random.Next(1, 100);
        number[5] = random.Next(1, 100);
        number[6] = random.Next(1, 100);
        number[7] = random.Next(1, 100);
        number[8] = random.Next(1, 100);
        number[9] = random.Next(1, 100);
        //for loop that prints out each index and storing the value added indexes in sum
        for (int i = 0; i < number.Length; i++)
        {
            Console.WriteLine(number[i]);
            sum += number[i];

        }
        //computing for average 
        ave = sum / number.Length;
        //showing the output
        Console.WriteLine("The minimum element in this array is " + number.Min());
        Console.WriteLine("The sum of all element is " + sum);
        Console.WriteLine("The avarage of all element is " + ave);

    }
    private static void Main(string[] args)
    {
        RandomAveSum(args);
        Console.WriteLine("---------------------------");
        ArrayFlip(args);
    }
}