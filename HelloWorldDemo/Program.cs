<<<<<<< HEAD
﻿using HelloWorldDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Hello World Demo");
        Console.WriteLine("Choose the program");
        Console.WriteLine("1:Eleginility\n2:WeekDays\n3:Reverse Program\n4:Even or Odd\n5:Two inreger is equal or not\n6:Larger number\n7:Arithmatic Operation" +
            "\n8:Power of 2\n9:Pattren\n10:Sumation\n11:Factorial\n12:Coin Flip\n13:Admission");
        int option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1:
                VotingElegible();
                break;
            case 2:
                WeekDays.Weekday();
                break;
            case 3:
                ReverseProgram arr = new ReverseProgram();
                arr.ReverseString();
                break;
            case 4:
                EvenOrOdd.EvenOrOddNumbers();
                break;
            case 5:
                EvenOrOdd.TwoIntegerEqual();
                break;
            case 6:
                int a = 30, b = 56, c = 78;
                Largernumber.FindLargerNumber(a, b, c);
                break;
            case 7:
                ArithmaticOperations.ArithmathicOperation();
                break;
            case 8:
                PowerOfTwo.PowerTwo();
                break;
            case 9:
                Pattren.Pattrens();
                Pattren.ReversePattrens();
                Pattren.Charector();
                break;
            case 10:
                Console.WriteLine("Enter the number");
                int n = Convert.ToInt32(Console.ReadLine());
                Sumation.summation(n);
                //Console.WriteLine(Sumation.summation(n));
                break;
            case 11:
                Factorial.FindFactorial();
                break;
            case 12:
                CoinFlip.FindCoinFlip();
                break;
            case 13:
                Addmission.EligibleForAdmission();
                break;
        }
        Console.ReadLine();
    }

    public static void VotingElegible()
    {
        Console.WriteLine("Enter the person age");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 18 && age <= 60)
        {
            Console.WriteLine("You are eligible for voting");
        }
        else if (age > 60)
        {
            Console.WriteLine("You are above 60 you can rest at home");
        }
        else
        {
            Console.WriteLine("You are not eligible for voting");
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hello World Program");
            Console.WriteLine("Making changes");
            Console.WriteLine("Creating conflict for local changes");
            Console.WriteLine("Creating confilct for remote changes");
            Console.ReadLine();
        }
    }
}
>>>>>>> 2e7d91d3fae01e77665862c34e2bd2c6e0589f1e
