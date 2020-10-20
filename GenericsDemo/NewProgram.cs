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

            
            GenericMaxClass<int> intMax = new GenericMaxClass<int>(10, 200, 200);
            intMax.getMaximum();



            GenericMaxClass<double> doubleMax = new GenericMaxClass<double>(10.1, 20.2, 20.1);
            doubleMax.getMaximum();

            
            GenericMaxClass<string> stringMax = new GenericMaxClass<string>("abcd", "143", "ABCD");
            stringMax.getMaximum();


        }

       
    }

    public class GenericMaxClass<T> where T : IComparable
    {
        public T input1,  input2,  input3;
        public GenericMaxClass(T input1, T input2, T input3 )
        {
            this.input1 = input1;
            this.input2 = input2;
            this.input3 = input3;
        }
        public T getMaximum()
        {


            var max = this.input1.CompareTo(input2) > 0 ? input1 : (this.input2.CompareTo(input3) > 0 ? input2:input3) ;

            //this.array[this.array.Length - 1];

            Console.WriteLine("Max is :" + max);

            return max;
        }
    }

}
