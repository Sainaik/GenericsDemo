using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Text;

namespace GenericsDemo
{
    public class NewProgram
    {

        public T FindMax<T>(T input1, T input2, T input3)
        {
            T[] inputArray = { input1, input2, input3 };

            Array.Sort(inputArray);

            var max = inputArray[inputArray.Length - 1];


            Console.WriteLine($"Max number is : { max}");
            return max;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Demo Project!!");

            NewProgram maxOfIntegers = new NewProgram();

            maxOfIntegers.FindMax<int>(10, 200, 23);

            NewProgram maxOfDoubles = new NewProgram();

            maxOfDoubles.FindMax<double>(10.1, 20.2, 20.1);

            NewProgram maxOfStrings = new NewProgram();

            maxOfStrings.FindMax<string>("abcd", "143", "ABCD");

        }

    }
}
