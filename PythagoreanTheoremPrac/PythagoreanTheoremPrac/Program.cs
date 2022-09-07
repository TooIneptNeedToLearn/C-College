using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
       //Pythagorean Theorem
        int a, b;
        double a1,b1,c,c1;
        a = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("You've selected: "+a);
        b = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("You've selected: " + b);

        a1 = Math.Sqrt(a);
        Console.WriteLine("The sqrt of a: "+a1);

        b1 = Math.Sqrt(b);
        Console.WriteLine("The sqrt of b: "+b1);

        c = a1 + b1;
        c1 = Math.Sqrt(c);
        Console.WriteLine("Your constant is "+c);
        Console.WriteLine("Your hypotenuse is "+c1);


    }
}