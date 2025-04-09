using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]

        [DataRow("1 1", false)]
        [DataRow("1 2", true)]
        [DataRow("2 1", true)]
        [DataRow("8 8", false)]
        public void IsWhite_DataDrivenTests(string input, bool expected)
        {
            // Act
            bool result = Program.IsWhite(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        [DataRow("321", "123")]
        [DataRow("034", "430")]
        [DataRow("454", "454")]
        public void Reverse_Test(string digits, string expected)
        {
            Assert.AreEqual(expected, Program.Reverse(digits));
        }

        [TestMethod()]
        [DataRow(0, 32)]
        [DataRow(2, 35, 6)]
        [DataRow(-10, 14)]
        public void CelsiumToFarengheit_Test(double TempC, double expected)
        {
            Assert.AreEqual(expected, Program.ConvertToFarengheit(TempC));
        }



    }
}