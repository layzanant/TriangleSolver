using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;

namespace TriangleSolverTest
{
    [TestFixture]
    public class Class1
    {
        //-	Only one(1) test for a valid equilateral triangle
        [Test]
        public static void CalculateEquilateralTriangleInput3and3and3OutputValidTriangle()
        {
            //Arrange
            int sideA = 3;
            int sideB = 3;
            int sideC = 3;

            //Act
            String output = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            //Assert
            Assert.AreEqual("The triangle is valid and is an EQUILATERAL", output);
        }

        // Three (3) tests for a valid isosceles triangle
        [Test]
        public static void VerifyIsoscelesTriangleInput60and60and90OutputIsIsosceles()
        {
            // Arrange
            int sideA = 60;
            int sideB = 60;
            int sideC = 90;
            // Act
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            //Assert
            Assert.AreEqual("The triangle is valid and is an ISOSCELES", result);
        }

        [Test]
        public static void VerifyIsoscelesTriangleInput60and80and80OutputIsIsosceles()
        {
            // Arrange
            int firstAngle = 60;
            int secondAngle = 80;
            int thirdAngle = 80;

            // Act
            string result = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual("The triangle is valid and is an ISOSCELES", result);
        }
        [Test]
        public static void VerifyIsoscelesTriangleInput50and140and50OutputIsNotIsosceles()
        {
            // Arrange
            int sideA = 50;
            int sideB = 140;
            int sideC = 50;

            // Act
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreNotEqual("The triangle is valid and is an ISOSCELES", result);
        }
        //-	Five (5) tests for a valid scalene triangle
        [Test]
        public static void DetermineScaleneTriangle1Input110and50and60OutputIsNotScalene()
        {
            // Arrange
            int sideA = 110;
            int sideB = 50;
            int sideC = 60;

            // Act
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreNotEqual("The triangle is valid and is a SCALENE", result);
        }
        [Test]
        public static void DetermineScaleneTriangle2Input5500and2200and4200OutputIsScalene()
        {
            // Arrange
            int sideA = 5500;
            int sideB = 2200;
            int sideC = 4200;

            // Act
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("The triangle is valid and is a SCALENE", result);
        }
        [Test]
        public static void DetermineScaleneTriangle3Input2and3and4OutputIsNotScalene()
        {
            // Arrange
            int sideA = 10;
            int sideB = 5;
            int sideC = 4;

            // Act
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreNotEqual("The triangle is valid and is a SCALENE", result);
        }
        [Test]
        public static void VerifyScaleneTriangle4Input101and71and11OutputIsNotScalene()
        {
            // Arrange
            int sideA = 101;
            int sideB = 71;
            int sideC = 11;

            // Act
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreNotEqual("The triangle is valid and is a SCALENE", result);
        }

        [Test]
        public static void VerifyScaleneTriangle5Input101and13and3OutputIsScalene()
        {
            // Arrange
            int sideA = 101;
            int sideB = 13;
            int sideC = 3;

            // Act
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreNotEqual("The triangle is valid and is a SCALENE", result);
        }

        //-	Three (3) tests for verifying a zero length for one or more sides
        [Test]
        public static void VerifySideAToNotAcceptZeroInput0and3and3OutputInvalidTriangle()
        {
            //Arrange
            int sideA = 0;
            int sideB = 3;
            int sideC = 3;

            //Act
            String output = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            //Assert
            Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", output);
        }

        [Test]
        public static void VerifySideBToNotAcceptZeroInput3and0and3OutputInvalidTriangle()
        {
            //Arrange
            int sideA = 3;
            int sideB = 0;
            int sideC = 3;

            //Act
            String output = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            //Assert
            Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", output);
        }

        [Test]
        public static void VerifySideCToNotAcceptZeroInput3and3and0OutputInvalidTriangle()
        {
            //Arrange
            int sideA = 3;
            int sideB = 3;
            int sideC = 0;

            //Act
            String output = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            //Assert
            Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", output);
        }

        //-	Three (3) tests for verifying an invalid response (other than a zero length)
        [Test]
        public static void VerifySideAForInvalidResponseInputNegative1and3and3OutputInvalidTriangle()
        {
            //Arrange
            int sideA = -1;
            int sideB = 3;
            int sideC = 3;

            //Act
            String output = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            //Assert
            Assert.AreEqual("A triangle cannot be formed with those numbers", output);
        }

        [Test]
        public static void VerifySideAForInvalidResponseInput3andNegative1and3OutputInvalidTriangle()
        {
            //Arrange
            int sideA = 3;
            int sideB = -1;
            int sideC = 3;

            //Act
            String output = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            //Assert
            Assert.AreEqual("A triangle cannot be formed with those numbers", output);
        }

        [Test]
        public static void VerifySideAForInvalidResponseInput3and3andNegative1OutputInvalidTriangle()
        {
            //Arrange
            int sideA = 3;
            int sideB = 3;
            int sideC = -1;

            //Act
            String output = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            //Assert
            Assert.AreEqual("A triangle cannot be formed with those numbers", output);
        }
    }
}
