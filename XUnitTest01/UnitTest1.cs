using Newtonsoft.Json;
using System;
using System.Runtime.InteropServices;
using Uppgift2;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            double expected = 10;

            double actual = CTest.Add(6, 4);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            double excpected = 2;

            double actual = CTest.Subtract(3, 1);

            Assert.Equal(excpected, actual);
        }
        [Fact]
        public void Test3()
        {
            double excpected = 30;

            double actual = CTest.Multiply(6, 5);

            Assert.Equal(excpected, actual);
        }

    }
}
