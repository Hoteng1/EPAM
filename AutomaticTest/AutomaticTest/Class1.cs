using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AutomaticTest
{

    public class Class1
    {
        //TestSum
        [Test]
        public void SimpleTestSum()
        {
            Assert.AreEqual(Calculator.Calculator.Sum(3, 6), 9);
        }

        [Test]
        public void NigativeTestSum()
        {
            Assert.AreEqual(Calculator.Calculator.Sum(-1, -2), -3);
        }

        [Test]
        public void NotSameTestSum()
        {
            Assert.AreNotSame(Calculator.Calculator.Sum(2, 10), 28);
            
        }

        [Test]
        public void WithZeroTestSum()
        {
            Assert.AreEqual(Calculator.Calculator.Sum(4, 0), 4);
        }

        [Test]
        public void ZeroTestSum()
        {
            Assert.AreNotEqual(Calculator.Calculator.Sum(0, 1), 2);
        }

        //Difference
        [Test]
        public void SimpleTestDifference()
        {
            Assert.AreEqual(Calculator.Calculator.Difference(3, 6), -3);
        }

        [Test]
        public void NigativeTestDifference()
        {
            Assert.AreEqual(Calculator.Calculator.Difference(-2, -1), -1);
        }

        [Test]
        public void NotSameTestDifference()
        {
            Assert.AreNotSame(Calculator.Calculator.Difference(2, 10), 28);
        }

        [Test]
        public void WithZeroTestDifference()
        {
            Assert.AreEqual(Calculator.Calculator.Difference(4, 0), 4);
        }

        [Test]
        public void ZeroTestDifference()
        {
            Assert.AreNotEqual(Calculator.Calculator.Difference(0, 1), 2);
        }


        //TestDivision
        [Test]
        public void SimpleTestDivision()
        {
            Assert.AreEqual(Calculator.Calculator.Division(3, 6), 0);
        }

        [Test]
        public void NigativeTestDivision()
        {
            Assert.AreEqual(Calculator.Calculator.Division(-1, -2), 0);
        }

        [Test]
        public void NotSameTestDivision()
        {
            Assert.AreNotSame(Calculator.Calculator.Division(2, 10), 6);
        }

        [Test]
        public void WithZeroTestDivision()
        {
            Assert.AreEqual(Calculator.Calculator.Division(4, 0), 4);
        }

        [Test]
        public void ZeroTestDivision()
        {
            Assert.AreNotEqual(Calculator.Calculator.Division(0, 1), 0);
        }

        //TestMulti
        [Test]
        public void SimpleTestMulti()
        {
            Assert.AreEqual(Calculator.Calculator.Multi(3, 6), 18);
        }

        [Test]
        public void NigativeTestMulti()
        {
            Assert.AreEqual(Calculator.Calculator.Multi(-1, -2), 2);
        }

        [Test]
        public void NotSameTestMulti()
        {
            Assert.AreNotSame(Calculator.Calculator.Multi(2, 10), 22);
        }

        [Test]
        public void WithZeroTestMulti()
        {
            Assert.AreEqual(Calculator.Calculator.Multi(4, 0), 0);
        }

        [Test]
        public void ZeroTestMulti()
        {
            Assert.AreNotEqual(Calculator.Calculator.Multi(0, 1), 1);
        }

    }
}