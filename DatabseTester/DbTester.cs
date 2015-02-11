using System;
using System.Runtime.Serialization;
using dataBaseinMemory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DatabseTester
{
    [TestClass]
    public class DbTester
    {
        [TestMethod]
        public void DatabaseTesterSimpleSet()
        {
            DataBaseSqlLite db = new DataBaseSqlLite();

            string result = db.Get("Empty");
            Assert.AreEqual("NULL", result);

            db.Set("EmpTY", "23");

            result = db.Get("EmpTY"); // case sensitive
            Assert.AreEqual("23", result);

            result = db.Get("Empty"); // case insentive
            Assert.AreEqual("23", result);

            int num = db.NumEqualTo("23");
            Assert.AreEqual(1, num);

            db.Set("ETY", "23");
            num = db.NumEqualTo("23");
            Assert.AreEqual(2, num);

            db.UnSet("ETY");
            num = db.NumEqualTo("23");
            Assert.AreEqual(1, num);


            db.UnSet("Empty"); // case insentive
            result = db.Get("Empty");
            Assert.AreEqual("NULL", result);
            db.End();
        }

        /// <summary>
        /// SET ex 10   ->
        /// GET ex      ->10 
        /// UNSET ex    ->
        /// GET ex      NULL
        /// END
        /// </summary>
        [TestMethod]
        public void TestSample()
        {
            DataBaseSqlLite db = new DataBaseSqlLite();

            db.Set("ex", "10");
            string result = db.Get("ex");
            Assert.AreEqual("10", result);
            db.UnSet("ex"); // case insentive
            result = db.Get("ex");
            Assert.AreEqual("NULL", result);
            db.End();
        }

        /// <summary>
        /// SET a 10        ->
        /// SET b 10        ->
        /// NUMEQUALTO 10   ->2
        /// NUMEQUALTO 20   ->0
        /// SET b 30        ->
        /// NUMEQUALTO 10   ->1
        /// END
        /// </summary>
        [TestMethod]
        public void TestMoreComplexSample()
        {
            DataBaseSqlLite db = new DataBaseSqlLite();
            db.Set("a", "10");
            db.Set("b", "10");
            int num = db.NumEqualTo("10");
            Assert.AreEqual(2, num);
            num = db.NumEqualTo("20");
            Assert.AreEqual(0, num);
            db.Set("b", "30");
            num = db.NumEqualTo("10");
            Assert.AreEqual(1, num);
            db.End();
        }
        /// <summary>
        /// BEGIN       ->
        /// SET a 10    -> 
        /// GET a       ->10
        /// BEGIN       ->
        /// SET a 20    ->
        /// GET a       ->20
        /// ROLLBACK    ->
        /// GET a       ->10
        /// ROLLBACK    ->
        /// GET a       ->NULL
        /// END
        /// </summary>
        [TestMethod]
        public void TestTransactionSimple()
        {
            DataBaseSqlLite db = new DataBaseSqlLite();
            db.Begin();
            db.Set("a", "10");
            string result = db.Get("a");
            Assert.AreEqual("10", result);
            db.Begin();
            db.Set("a", "20");
            result = db.Get("a");
            Assert.AreEqual("20", result);
            db.RollBack();
            result = db.Get("a");
            Assert.AreEqual("10", result);
            db.RollBack();
            result = db.Get("a");
            Assert.AreEqual("NULL", result);
            db.End();
        }
        /// <summary>
        /// BEGIN       ->
        /// SET a 30    ->
        /// BEGIN       ->
        /// SET a 40    ->
        /// COMMIT      ->
        /// GET a       ->40
        /// ROLLBACK    ->NO TRNASACTION
        /// END         ->
        /// </summary>
        [TestMethod]
        public void TestTransactionComplex()
        {
            DataBaseSqlLite db = new DataBaseSqlLite();
            db.Begin();
            db.Set("a", "30");
            db.Begin();
            db.Set("a", "40");
            db.Commit();
            string result = db.Get("a");
            Assert.AreEqual("40", result);
            result = db.RollBack();
            Assert.AreEqual("NO TRANSACTION", result);
            db.End();
        }

        /// <summary>
        /// SET a 50    ->
        /// BEGIN       ->
        /// GET a       ->50
        /// SET a 60    ->
        /// BEGIN       ->
        /// UNSET a     ->
        /// GET a       ->NULL
        /// ROLLBACK    ->
        /// GET a       ->60
        /// COMMIT      ->
        /// GET a       ->60
        /// END         ->
        /// </summary>
        [TestMethod]
        public void TestTransactionTranComplex()
        {
            DataBaseSqlLite db = new DataBaseSqlLite();
            db.Set("a", "50");
            db.Begin();
            string result = db.Get("a");
            Assert.AreEqual("50", result);
            db.Set("a", "60");
            db.Begin();
            db.UnSet("a");
            result = db.Get("a");
            Assert.AreEqual("NULL", result);
            db.RollBack();
            result = db.Get("a");
            Assert.AreEqual("60", result);
            db.Commit();
            result = db.Get("a");
            Assert.AreEqual("60", result);
            db.End();
        }
        /// <summary>
        /// SET a 10        ->
        /// BEGIN           ->
        /// NUMEQUALTO 10   ->1
        /// BEGIN           ->
        /// UNSET a         ->
        /// NUMEQUALTO 10   ->0
        /// ROLLBACK        ->
        /// NUMEQUALTO 10   ->1
        /// COMMIT          ->
        /// END             ->
        /// </summary>
        [TestMethod]
        public void TestTransactionFinalComplex()
        {
            DataBaseSqlLite db = new DataBaseSqlLite();
            db.Set("a", "10");
            db.Begin();
            int num = db.NumEqualTo("10");
            Assert.AreEqual(1, num);
            db.Begin();
            db.UnSet("a");
            num = db.NumEqualTo("10");
            Assert.AreEqual(0, num);
            db.RollBack();
            num = db.NumEqualTo("10");
            Assert.AreEqual(1, num);
            db.Commit();
            db.End();

        }



    }
}
