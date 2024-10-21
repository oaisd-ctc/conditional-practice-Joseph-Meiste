
using System;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        CheckForPositiveNegativeZero();
        FindMinimum();
        FindMaximum();
    }

    public static void CheckForPositiveNegativeZero()
    {
        int num = 0;

        if (num > 0)
        {
            Console.WriteLine("Your Number is Positive");
        }
        else if (num < 0)
        {
            Console.WriteLine("Your Number is Negative");
        }
        else
        {
            Console.WriteLine("Your Number is zero");
        }

    }

    public static void FindMinimum()
    {
        int num1 = 2;
        int num2 = 3;
        int num3 = 1;

        if (num1 < num2 && num1 < num3)
        {
            Console.WriteLine("The Minimum value is " + num1);
        }
        else if (num2 < num3 && num2 < num1)
        {
            Console.WriteLine("The Minimum value is " + num2);
        }
        else
        {
            Console.WriteLine("The Minimum value is " + num3);
        }
    }

    public static void FindMaximum()
    {
        int num1 = 2;
        int num2 = 3;
        int num3 = 1;

        if (num1 > num2 && num1 > num3)
        {
            Console.WriteLine("The Maximum value is " + num1);
        }
        else if (num2 > num3 && num2 > num1)
        {
            Console.WriteLine("The Maximum value is " + num2);
        }
        else
        {
            Console.WriteLine("The Maximum value is " + num3);
        }
    }

    public static void IsDivisibleBy5();
{

}
}