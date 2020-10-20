using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericsDemo;

namespace GenricsMaxTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
       
        public void FindMax_GivenIntegers_MatchExpcted()
        {
            int[] intArray = { 10, 200, 200, 1500 };
            int expected = 1500;
            GenericMaxClass<int> intMax = new GenericMaxClass<int>(intArray);
            int actual = intMax.getMaximum();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindMax_Given3Float_MatchExpected()
        {
            double[] doubleArray = { 10.1, 20.2, 20.1, 50.45 };
            double expected = 50.45;
            GenericMaxClass<double> doubleMax = new GenericMaxClass<double>(doubleArray);
            double actual = doubleMax.getMaximum();
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void FindMax_Given3Strings_MatchExpected()
        {
            string[] stringArray = { "abcd", "143", "ABCD", "Apple" };
            string expected = "Apple";
            GenericMaxClass<string> stringMax = new GenericMaxClass<string>(stringArray);
            string actual = stringMax.getMaximum();
            Assert.AreEqual(expected, actual);
        }

    }
}
