using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Provide 1 number to perform the addition operation");
        int add1 = int.Parse(Console.ReadLine());
        Console.WriteLine("{0} ...got it. Provide a number to add to {0}.",add1);
        int add2 = int.Parse(Console.ReadLine());
        double add3 = add1 + add2;
        Console.WriteLine("{0}, alright! That's easy. {1} + {0} is {2}!",add2,add1,add3);

        Console.WriteLine("Provide 1 number to perform the subtraction operation");
        int sub1 = int.Parse(Console.ReadLine());
        Console.WriteLine("{0} ...got it. Provide a number to subtract from {0}.",sub1);
        int sub2 = int.Parse(Console.ReadLine());
        double sub3 = sub1 - sub2;
        Console.WriteLine("{0}, alright! That's easy. {1} - {0} is {2}!",sub2,sub1,sub3);

        Console.WriteLine("Provide 1 number to perform the multiplication operation");
        int mul1 = int.Parse(Console.ReadLine());
        Console.WriteLine("{0} ...got it. Provide a number to multiply by {0}.",mul1);
        int mul2 = int.Parse(Console.ReadLine());
        double mul3 = mul1 * mul2;
        Console.WriteLine("{0}, alright! That's easy. {1} * {0} is {2}!",mul2,mul1,mul3);

        Console.WriteLine("Provide 1 number to perform the division operation");
        int div1 = int.Parse(Console.ReadLine());
        Console.WriteLine("{0} ...got it. Provide a number to divide {0} by.",div1);
        int div2 = int.Parse(Console.ReadLine());
        double div3 = div1 / div2;
        Console.WriteLine("{0}, alright! That's easy. {1} / {0} is {2}!",div2,div1,div3);
        
        Console.WriteLine("Provide 1 number to perform the float division operation");
        float fdiv1 = float.Parse(Console.ReadLine());
        Console.WriteLine("{0} ...got it. Provide a number to divide {0} by.",fdiv1);
        float fdiv2 = float.Parse(Console.ReadLine());
        double fdiv3 = fdiv1 / fdiv2;
        Console.WriteLine("{0}, alright! That's easy. {1} / {0} is {2}!",fdiv2,fdiv1,fdiv3);

        Console.WriteLine("Provide 1 number to perform the modulus operation");
        int mod1 = int.Parse(Console.ReadLine());
        Console.WriteLine("{0} ...got it. Provide a number to moduli from {0}.",mod1);
        int mod2 = int.Parse(Console.ReadLine());
        double mod3 = mod1 % mod2;
        Console.WriteLine("{0}, alright! That's easy. {1} % {0} is {2}!",mod2,mod1,mod3);
    }
}