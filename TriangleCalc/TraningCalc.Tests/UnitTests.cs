using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleCalc;
using System.Threading.Tasks;

namespace TriangleCalc.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckZero_for_Zero_Number()
        {
            double a = 0;
            double b = 10;
            double c = 4;
            bool expected = false;


            TriangleClass obj = new TriangleClass();
             bool actual = obj.checkZero(a, b, c);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CheckZero_for_Negative_Number()
        {
            double a = -2;
            double b = 2;
            double c = 4;
            bool expected = false;


            TriangleClass obj = new TriangleClass();
            bool actual = obj.checkZero(a, b, c);

            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void CheckSides_for_Zero_Number()
        {
            double a = 0;
            double b = 10;
            double c = 4;
            bool expected = false;


            TriangleClass obj = new TriangleClass();
            bool actual = obj.checkSides(a,b,c);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CheckSides_for_Negative_and_Zero()
        {
            double a = 0;
            double b = -3;
            double c = 4;
            bool expected = false;


            TriangleClass obj = new TriangleClass();
            bool actual = obj.checkSides(a, b, c);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CheckSides_for_Correct_Numbers()
        {
            double a = 3;
            double b = 5;
            double c = 7;
            bool expected = true;

            TriangleClass obj = new TriangleClass();
            bool actual = obj.checkSides(a, b, c);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void CheckSides_for_Not_Correct_Numbers()
        {
            double a = 1;
            double b = 2;
            double c = 3;
            bool expected = false;

            TriangleClass obj = new TriangleClass();
            bool actual = obj.checkSides(a, b, c);

             Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CheckSides_for_Not_int_Number()
        {
            double a = 1.4;
            double b = 2;
            double c = 3;
            bool expected = true;

            TriangleClass obj = new TriangleClass();
            bool actual = obj.checkSides(a, b, c);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CheckSides_for_Not_int_Numbers()
        {
            double a = 1.4;
            double b = 2.7;
            double c = 3.1;
            bool expected = true;

            TriangleClass obj = new TriangleClass();
            bool actual = obj.checkSides(a, b, c);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CheckSides_for_Not_int_Number_and_Zero()
        {
            double a = 0;
            double b = 2.7;
            double c = 3.1;
            bool expected = false;

            TriangleClass obj = new TriangleClass();
            bool actual = obj.checkSides(a, b, c);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CheckSides_for_Not_int_Number_and_Negative()
        {
            double a = 4;
            double b = 2.7;
            double c = -3.1;
            bool expected = false;

            TriangleClass obj = new TriangleClass();
            bool actual = obj.checkSides(a, b, c);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CheckSides_for_Not_int_Number_and_Negative_and_Zero()
        {
            double a = 0;
            double b = 2.7;
            double c = -3.1;
            bool expected = false;

            TriangleClass obj = new TriangleClass();
            bool actual = obj.checkSides(a, b, c);

            Assert.AreEqual(expected, actual);

        }

    }
}
