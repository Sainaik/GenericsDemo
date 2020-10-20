﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo
{
    public class NewProgram
    {

        public int FindMax(int num1, int num2, int num3)
        {
            var max = (num1.CompareTo(num2) > 0 ? num1 : (num2.CompareTo(num3) > 0 ? num2 : num3));
            Console.WriteLine($"Max number is : { max}");
            return max;

        }

        public double FindMax(double num1, double num2, double num3)
        {
            var max = (num1.CompareTo(num2) > 0 ? num1 : (num2.CompareTo(num3) > 0 ? num2 : num3));
            Console.WriteLine($"Max number is : { max}");
            return max;

        }

        public string FindMax(string str1, string str2, string str3)
        {
            var max = (str1.CompareTo(str2) > 0 ? str1 : (str2.CompareTo(str3) > 0 ? str2 : str3));
            Console.WriteLine($"Max number is : { max}");
            return max;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Demo Project!!");

            NewProgram maxOfIntegers = new NewProgram();

            maxOfIntegers.FindMax(10, 200, 23);

            NewProgram maxOfDoubles = new NewProgram();

            maxOfDoubles.FindMax(10.1, 20.2, 20.1);

            NewProgram maxOfStrings = new NewProgram();

            maxOfStrings.FindMax("abcd", "143", "ABCD");




        }
    }
}
