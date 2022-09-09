internal class Program
{
    private static void Main(string[] args)
    {
        int[] number = {1,2,3,4,5,6,7,8,9,10};
        int sum, average;
        sum = 0;

        for (int i = 0; i < number.Length; i++)
        {
            Console.WriteLine(number[i]);
            sum+= number[i];
        }
        //Print the sum of the elements
        Console.WriteLine("------------------");
        Console.WriteLine("The sum is "+sum);
        average = sum/number.Length;
        Console.WriteLine("You're average is "+average);
    }    


}