internal class Program
{
    private static void Main(string[] args)
    {
        int iamt, k, hs, h, fif, ten, one,value;
        double amt, cent;

        Console.WriteLine("Denominator");
        amt = Convert.ToDouble(Console.ReadLine());
        iamt = (int)amt;
        cent = iamt - amt;
        Console.WriteLine("You've inputted " + amt);

        k = iamt / 1000;
        Console.WriteLine(k);

        hs = (iamt % 1000)/500;
        Console.WriteLine(hs);

        h = (iamt % 1000 % 500)/100;
        Console.WriteLine(h);

        fif = (iamt % 1000 % 500 % 100)/50;
        Console.WriteLine(hs);

        ten = (iamt % 1000 % 500 % 100 % 50)/10;
        Console.WriteLine(ten);

        one = (iamt % 1000 % 500 % 100 % 50 % 10)/1;
        Console.WriteLine(one);

        Console.WriteLine(cent);

        Console.WriteLine("-----------------");
        Random rng = new Random();
        int money = rng.Next(3000, 4000);
        Console.WriteLine("Money is "+money);
        int a = money / 1000;
        int b = (money % 1000     )/500;
        int c = (money % 1000    % 500 )/ 100;
        int d = (money % 1000   % 500 % 100 )/ 50;
        int e = (money % 1000  % 500  % 100 %50 )/10;
        int f = (money % 1000 % 500 % 100 % 50 % 10)/ 1; ;
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine(e);
        Console.WriteLine(f);
        






    }
}