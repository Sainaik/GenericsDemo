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
            NewProgram maxOfIntegers = new NewProgram();

            int actual = maxOfIntegers.FindMax(num1,num2,num3);

            Assert.AreEqual(expected, actual);
        }
    }
}
