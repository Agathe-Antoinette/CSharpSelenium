using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorTests.Calculator;
using System.Collections.Generic;
using CalculatorTests.Models;
using System.Configuration;
using System.Data.OleDb;
using Dapper;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorTest
    {
        private CalculatorClient calculator;

        private string dataSourcePath = ConfigurationManager.AppSettings["DataSourcePath"];
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"";

        [TestInitialize]
        public void BeforeEachTest()
        {
            this.calculator = new CalculatorClient();
        }

        [TestMethod]
        public void TestAdd()
        {
            using (var connection = new OleDbConnection(string.Format(connectionString, dataSourcePath)))
            {
                var addData = connection.Query<RowData>("select * from [Add$]");

                foreach (var data in addData)
                {
                    var result = calculator.Add(data.A, data.B);
                    Assert.AreEqual(data.Expected, result);
                }
            }
        }

        [TestMethod]
        public void TestSubstract()
        {
            using (var connection = new OleDbConnection(string.Format(connectionString, dataSourcePath)))
            {
                var substractData = connection.Query<RowData>("select * from [Substract$]");

                foreach (var data in substractData)
                {
                var result = calculator.Substract(data.A, data.B);
                Assert.AreEqual(data.Expected, result);
                }
            }


        }
        ///TODO: next 2 tests
        [TestMethod]
        public void TestMultiply()
        {
            var result = calculator.Multiply(7m, 8m);
            Assert.AreEqual(56m, result);
        }

        [TestMethod]
        public void TestDivide()
        {
            var result = calculator.Divide(56m, 8m);
            Assert.AreEqual(7m, result);
        }
    }
}
