using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace sc
{
    [TestFixture]
    public class TestStringCalculator
    {
        [Test]
        public void TestStringCalculator_GivenInputOf_EmptyString_ShouldReturn_0()
        {
            // Arrange
            const string input = "";
            const int expected = 0;
            var TestStringCalculator = StringCalculator();
            // Act

            var result = StringCalculator.Add(input);

            // Assert
            Assert.AreEqual(expected, result);

        }


        [Test]
        public void TestStringCalculator_GivenInputOf_1_ShouldReturn_1()
        {
            // Arrange
            const string input = "1";
            const int expected = 1;
            var StringCalculator = CreateKataStringCounter();
            // Act

            var result = KataStringCalculator.Add(input);

            // Assert
            Assert.AreEqual(expected, result);

        }


        [Test]
        public void KataStringCalc_GivenInputOf_1_1_ShouldReturn_2()
        {
            // Arrange
            const string input = "1,1";
            const int expected = 2;
            var StringCalculator = CreateKataStringCounter();
            // Act

            var result = StringCalculator.Add(input);

            // Assert
            Assert.AreEqual(expected, result);

        }


        [Test]
        public void KataStringCalc_GivenInputOf_1_2_3_ShouldReturn_6()
        {
            // Arrange
            const string input = "1,2,3";
            const int expected = 6;
            var StringCalculator = CreateKataStringCounter();
            // Act

            var result = KataStringCalculator.Add(input);

            // Assert
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void KataStringCalc_GivenInputOf_NewLineDelimiter_ShouldReturn_6()
        {
            // Arrange
            const string input = "1\n2,3";
            const int expected = 6;
            var StringCalculator = CreateKataStringCounter();
            // Act

            var result = StringCalculator.Add(input);

            // Assert
            Assert.AreEqual(expected, result);

        }