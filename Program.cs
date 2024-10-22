
using System;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        CheckForPositiveNegativeZero();
        FindMinimum();
        FindMaximum();
        IsDivisibleBy5();
        CheckVowelOrConsonant();
        DisplayDatOfWeek();
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

    public static void IsDivisibleBy5()
    {
        int num = 5;

        if (num % 5 == 0)
        {
            Console.WriteLine(num + " is divisible by 5");
        }
        else
        {
            Console.WriteLine(num + " is not divisible by 5");
        }
    }


    public static void CheckEvenOrOdd()
    {
        int num = 5;

        if (num % 2 == 0)
        {
            Console.WriteLine(num + "is even");
        }
        else
        {
            Console.WriteLine(num + "is odd");
        }
    }

    public static void CheckVowelOrConsonant()
    {
        string cha = "t";

        switch (cha)
        {
            case "a":
                Console.WriteLine(cha + " is a vowel.");
                break;
            case "e":
                Console.WriteLine(cha + " is a vowel.");
                break;
            case "i":
                Console.WriteLine(cha + " is a vowel.");
                break;
            case "o":
                Console.WriteLine(cha + " is a vowel.");
                break;
            case "u":
                Console.WriteLine(cha + " is a vowel.");
                break;
            default:
                Console.WriteLine(cha + " is a constant.");
                break;
        }
    }

    public static void DisplayDatOfWeek()
    {
        int day = 2;

        switch (day)
        {
            case 1:
                Console.WriteLine("Sunday");
                break;
            case 2:
                Console.WriteLine("Monday");
                break;
            case 3:
                Console.WriteLine("Tuesday");
                break;
            case 4:
                Console.WriteLine("Wednesday");
                break;
            case 5:
                Console.WriteLine("Thursday");
                break;
            case 6:
                Console.WriteLine("Friday");
                break;
            case 7:
                Console.WriteLine("Saturday");
                break;
            default:
                Console.WriteLine("Choose a number between 1-7.");
                break;
        }
    }
}