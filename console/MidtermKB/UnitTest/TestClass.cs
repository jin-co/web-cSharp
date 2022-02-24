using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidtermKB;
using NUnit.Framework;

namespace UnitTest
{
    public class TestClass
    {
        [Test]
        public void Analyze_DayValueLessThanMin_SysDateNotUpdated()
        {
            // Arrange
            int day = 0;


            // Act
            string result = DateSolver.Analyze(1, day, 1);

            // Assert
            Assert.AreNotEqual(result, "System date is updated 1. 0. 1. ");
        }

        [Test]
        public void Analyze_MonthValueLessThanMin_SysDateNotUpdated()
        {
            // Arrange
            int month = 0;


            // Act
            string result = DateSolver.Analyze(month, 1, 1);

            // Assert
            Assert.AreNotEqual(result, "System date is updated 0. 1. 1. ");
        }

        [Test]
        public void Analyze_YearValueLessThanMin_SysDateNotUpdated()
        {
            // Arrange
            int year = 0;


            // Act
            string result = DateSolver.Analyze(1, 1, year);

            // Assert
            Assert.AreNotEqual(result, "System date is updated 1. 1. 0. ");
        }

                [Test]
        public void Analyze_DayValueGreaterThanMax_SysDateNotUpdated()
        {
            // Arrange
            int day = 32;


            // Act
            string result = DateSolver.Analyze(1, day, 1);

            // Assert
            Assert.AreNotEqual(result, "System date is updated 1. 32. 1. ");
        }

        [Test]
        public void Analyze_MonthValueGreaterThanMax_SysDateNotUpdated()
        {
            // Arrange
            int month = 13;


            // Act
            string result = DateSolver.Analyze(month, 1, 1);

            // Assert
            Assert.AreNotEqual(result, "System date is updated 13. 1. 1. ");
        }

        [Test]
        public void Analyze_YearValueGreaterThanMax_SysDateNotUpdated()
        {
            // Arrange
            int year = 2023;


            // Act
            string result = DateSolver.Analyze(1, 1, year);

            // Assert
            Assert.AreNotEqual(result, "System date is updated 1. 1. 2023. ");
        }

        [Test]
        public void Analyze_WhenMonthValue12Entered_Return12()
        {
            // Arrange
            int month = 12;
            int day = 1;
            int year = 2020;

            // Act
            string result = DateSolver.Analyze(month, day, year);

            // Assert
            Assert.AreEqual(result, "System date is updated 12. 1. 2020. ");
        }

        [Test]
        public void Analyze_WhenDayValue12Entered_Return12()
        {
            // Arrange
            int month = 1;
            int day = 12;
            int year = 2020;

            // Act
            string result = DateSolver.Analyze(month, day, year);

            // Assert
            Assert.AreEqual(result, "System date is updated 1. 12. 2020. ");
        }

        [Test]
        public void Analyze_WhenYearValue2000Entered_Return2000()
        {
            // Arrange
            int month = 1;
            int day = 12;
            int year = 2000;

            // Act
            string result = DateSolver.Analyze(month, day, year);

            // Assert
            Assert.AreEqual(result, "System date is updated 1. 12. 2000. ");
        }

        [Test]
        public void Analyze_WhenValueEnterValid_UpdateSysDate()
        {
            // Arrange
            int month = 1;
            int day = 12;
            int year = 2000;

            // Act
            string result = DateSolver.Analyze(month, day, year);

            // Assert
            Assert.AreEqual(result, "System date is updated 1. 12. 2000. ");
        }

    }
}
