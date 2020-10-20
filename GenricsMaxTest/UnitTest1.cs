using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericsDemo;

namespace GenricsMaxTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(45,3,19,45)]
        [DataRow(13,99,12,99)]
        [DataRow(100,1000,10000,10000)]
        public void FindMax_GivenIntegers_MatchExpcted(int num1, int num2, int num3,int expected)
        {        
            GenericMaxClass<int> intMax = new GenericMaxClass<int>(num1,num2,num3);
            int actual = intMax.getMaximum();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(45.1, 45.00, 19.7, 45.1)]
        [DataRow(13.88, 99.00, 12.56, 99.00)]
        [DataRow(10.0, 10.10, 100.00, 100.00)]
        public void FindMax_Given3Float_MatchExpected(double num1, double num2, double num3, double expected)
        {
            GenericMaxClass<double> doubleMax = new GenericMaxClass<double>(num1, num2, num3);
            double actual = doubleMax.getMaximum();
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [DataRow("ab","cd","ef","ef")]
        [DataRow("ABC","ABD","ABB","ABD")]
        [DataRow("xyz","XYZa","SAI","XYZa")]
        public void FindMax_Given3Strings_MatchExpected(string str1, string str2, string str3, string expected)
        {
            GenericMaxClass<string> stringMax = new GenericMaxClass<string>(str1, str2, str3);
            
            string actual = stringMax.getMaximum();

            Assert.AreEqual(expected, actual);
        }

    }
}
