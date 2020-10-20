using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Text;

namespace GenericsDemo
{
    public class NewProgram
    {

        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Demo Project!!");

            int[] intArray = { 10, 200, 200,1500 };
            GenericMaxClass<int> intMax = new GenericMaxClass<int>(intArray);
            intMax.getMaximum();


            double[] doubleArray = { 10.1, 20.2, 20.1, 50.45 };
            GenericMaxClass<double> doubleMax = new GenericMaxClass<double>(doubleArray);
            doubleMax.getMaximum();

            string[] stringArray = { "abcd", "143", "ABCD", "Apple" };
            GenericMaxClass<string> stringMax = new GenericMaxClass<string>(stringArray);
            stringMax.getMaximum();


        }

       
    }

    public class GenericMaxClass<T> where T : IComparable
    {
        public T[] inputArray;
        public GenericMaxClass(T[] inputArray)
        {
            this.inputArray = inputArray;
            
        }
        public T getMaximum()
        {
            Array.Sort(inputArray);

           var max = this.inputArray[this.inputArray.Length - 1];

            printMax(max);

            return max;
        }

        static void printMax(T max)
        {
            Console.WriteLine($"Max : {max}");
        }
    }

}
