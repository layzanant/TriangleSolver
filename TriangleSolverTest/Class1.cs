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
        [Test]
        public static void CalculateEquilateralTriangleInput3and3and3OutputValidTriangle()
        {
            int sideA = 3;
            int sideB = 3;
            int sideC = 3;

            String output = Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            Assert.AreEqual("The triangle is valid and is an EQUILATERAL", output);
        }

        [Test]
        public static void VerifySideAToNotAcceptZeroInput0and3and3OutputInvalidTriangle()
        {
            int sideA = 0;
            int sideB = 3;
            int sideC = 3;

            String output = Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", output);
        }

        [Test]
        public static void VerifySideBToNotAcceptZeroInput3and0and3OutputInvalidTriangle()
        {
            int sideA = 3;
            int sideB = 0;
            int sideC = 3;

            String output = Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", output);
        }

        [Test]
        public static void VerifySideCToNotAcceptZeroInput3and3and0OutputInvalidTriangle()
        {
            int sideA = 3;
            int sideB = 3;
            int sideC = 0;

            String output = Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", output);
        }

        [Test]
        public static void VerifySideAForInvalidResponseInputNegative1and3and3OutputInvalidTriangle()
        {
            int sideA = -1;
            int sideB = 3;
            int sideC = 3;

            String output = Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            Assert.AreEqual("A triangle cannot be formed with those numbers", output);
        }

        [Test]
        public static void VerifySideAForInvalidResponseInput3andNegative1and3OutputInvalidTriangle()
        {
            int sideA = 3;
            int sideB = -1;
            int sideC = 3;

            String output = Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            Assert.AreEqual("A triangle cannot be formed with those numbers", output);
        }

        [Test]
        public static void VerifySideAForInvalidResponseInput3and3andNegative1OutputInvalidTriangle()
        {
            int sideA = 3;
            int sideB = 3;
            int sideC = -1;

            String output = Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            Assert.AreEqual("A triangle cannot be formed with those numbers", output);
        }
    }
}
