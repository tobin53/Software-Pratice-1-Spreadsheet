﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Formulas;
using System.Collections.Generic;

namespace TestCases
{
    /// <summary>
    /// These test cases are in no sense comprehensive!  They are intended primarily to show you
    /// how to create your own, which we strong recommend that you do!  To run them, pull down
    /// the Test menu and do Run > All Tests.
    /// </summary>
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        [ExpectedException(typeof(FormulaFormatException))]
        public void Construct1()
        {
            Formula f = new Formula("$xaedfe");
        }

        [TestMethod]
        [ExpectedException(typeof(FormulaFormatException))]
        public void Construct2()
        {
            Formula f = new Formula("2++3");
        }

        [TestMethod]
        [ExpectedException(typeof(FormulaFormatException))]
        public void Construct3()
        {
            Formula f = new Formula("2 3");
        }

        [TestMethod]
        [ExpectedException(typeof(FormulaFormatException))]
        public void Construct4()
        {
            Formula f = new Formula("");
        }

        [TestMethod]
        [ExpectedException(typeof(FormulaFormatException))]
        public void Construct5()
        {
            Formula f = new Formula("(x3)) + 2");
        }

        [TestMethod]
        [ExpectedException(typeof(FormulaFormatException))]
        public void Construct6()
        {
            Formula f = new Formula("((x3) + 2");
        }

        [TestMethod]
        [ExpectedException(typeof(FormulaFormatException))]
        public void Construct7()
        {
            Formula f = new Formula("2e10*");
        }

        [TestMethod]
        [ExpectedException(typeof(FormulaFormatException))]
        public void Construct8()
        {
            Formula f = new Formula("((x3) + 2)*");
        }

        [TestMethod]
        [ExpectedException(typeof(FormulaFormatException))]
        public void Construct9()
        {
            Formula f = new Formula("(*)");
        }

        [TestMethod]
        [ExpectedException(typeof(FormulaFormatException))]
        public void Construct10()
        {
            Formula f = new Formula("2.5e9 + x5 / 17*");
        }

        [TestMethod]
        public void Evaluate1()
        {
            Formula f = new Formula("2+3");
            Assert.AreEqual(f.Evaluate(s => 0), 5.0, 1e-6);
        }

        [TestMethod]
        public void Evaluate2()
        {
            Formula f = new Formula("x5");
            Assert.AreEqual(f.Evaluate(s => 22.5), 22.5, 1e-6);
        }

        [TestMethod]
        [ExpectedException(typeof(FormulaEvaluationException))]
        public void Evaluate3()
        {
            Formula f = new Formula("x5 + y6");
            f.Evaluate(s => { throw new ArgumentException(); });
        }

        [TestMethod]
        public void Evaluate4()
        {
            Formula f = new Formula("25/5");
            Assert.AreEqual(f.Evaluate(s => 0), 5.0, 1e-6);
        }

        [TestMethod]
        [ExpectedException(typeof(FormulaEvaluationException))]
        public void Evaluate5()
        {
            Formula f = new Formula("20/0");
            f.Evaluate(s => { throw new ArgumentException(); });
        }

        [TestMethod]
        public void Evaluate6()
        {
            Formula f = new Formula("25-5");
            Assert.AreEqual(f.Evaluate(s => 0), 20.0, 1e-6);
        }

        [TestMethod]
        public void Evaluate7()
        {
            Formula f = new Formula("2.5e2 + 15 / 17");
            Assert.AreEqual(f.Evaluate(s => 0), 250.882353, 1e-6);
        }

        [TestMethod]
        public void Evaluate8()
        {
            Formula f = new Formula("20 - 15 / 17");
            Assert.AreEqual(f.Evaluate(s => 0), 19.1176471, 1e-6);
        }

        [TestMethod]
        public void Evaluate9()
        {
            Formula f = new Formula("20 - (40/2)");
            Assert.AreEqual(f.Evaluate(s => 0), 0, 1e-6);
        }

        [TestMethod]
        public void Evaluate10()
        {
            Formula f = new Formula("20 - (x3 / 2)");
            Assert.AreEqual(f.Evaluate(s => 40), 0, 1e-6);
        }

        [TestMethod]
        [ExpectedException(typeof(FormulaEvaluationException))]
        public void Evaluate11()
        {
            Formula f = new Formula("6 / x");
            Assert.AreEqual(f.Evaluate(s => 0), 0, 1e-6);
        }

        [TestMethod]
        public void Evaluate12()
        {
            Formula f = new Formula("6 / 2 + 1");
            Assert.AreEqual(f.Evaluate(s => 0), 4, 1e-6);
        }

        [TestMethod()]
        public void Evaluate13()
        {
            Formula f = new Formula("(5 + X1) / (X1 - 3)");
            Assert.AreEqual(f.Evaluate(s => 1), -3, 1e-6);
        }
        
        [TestMethod]
        public void Normalize1()
        {
            Formula f = new Formula("20 - (x3 / 2)", x => x.ToUpper(), x => true);
            IEnumerable<String> test = f.GetVariables();
            List<String> variables = new List<String>();
            foreach (String temp in test)
            {
                variables.Add(temp);
            }
            Assert.AreEqual(variables.Contains("X3"), true);
        }

        [TestMethod]
        public void Normalize2()
        {
            Formula f = new Formula("20 - (x3 / 2)", x => x.ToUpper(), x => true);
            IEnumerable<String> test = f.GetVariables();
            List<String> variables = new List<String>();
            foreach (String temp in test)
            {
                variables.Add(temp);
            }
            Assert.AreEqual(variables.Contains("x3"), false);
        }

        [TestMethod]
        [ExpectedException(typeof(FormulaFormatException))]
        public void Normalize3()
        {
            Formula f = new Formula("20 - (x3 / 2)", x => x.Insert(0,"$"), x => true);
        }

        [TestMethod]
        [ExpectedException(typeof(FormulaFormatException))]
        public void Validate1()
        {
            Formula f = new Formula("20 - (x3 / 2)", x => x.Insert(0, "_"), x =>  x.Length > 10? true : false);
        }
    }
}