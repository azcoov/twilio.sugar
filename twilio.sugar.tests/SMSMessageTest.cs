using twilio.sugar.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace twilio.sugar.tests
{
    
    
    /// <summary>
    ///This is a test class for SMSMessageTest and is intended
    ///to contain all SMSMessageTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SMSMessageTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for SMSMessage Constructor
        ///</summary>
        [TestMethod()]
        public void SMSMessageConstructorTest()
        {
            SMSMessage target = new SMSMessage();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for account_sid
        ///</summary>
        [TestMethod()]
        public void account_sidTest()
        {
            SMSMessage target = new SMSMessage(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.account_sid = expected;
            actual = target.account_sid;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for api_version
        ///</summary>
        [TestMethod()]
        public void api_versionTest()
        {
            SMSMessage target = new SMSMessage(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.api_version = expected;
            actual = target.api_version;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for body
        ///</summary>
        [TestMethod()]
        public void bodyTest()
        {
            SMSMessage target = new SMSMessage(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.body = expected;
            actual = target.body;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for date_created
        ///</summary>
        [TestMethod()]
        public void date_createdTest()
        {
            SMSMessage target = new SMSMessage(); // TODO: Initialize to an appropriate value
            Nullable<DateTime> expected = new Nullable<DateTime>(); // TODO: Initialize to an appropriate value
            Nullable<DateTime> actual;
            target.date_created = expected;
            actual = target.date_created;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for date_sent
        ///</summary>
        [TestMethod()]
        public void date_sentTest()
        {
            SMSMessage target = new SMSMessage(); // TODO: Initialize to an appropriate value
            Nullable<DateTime> expected = new Nullable<DateTime>(); // TODO: Initialize to an appropriate value
            Nullable<DateTime> actual;
            target.date_sent = expected;
            actual = target.date_sent;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for date_updated
        ///</summary>
        [TestMethod()]
        public void date_updatedTest()
        {
            SMSMessage target = new SMSMessage(); // TODO: Initialize to an appropriate value
            Nullable<DateTime> expected = new Nullable<DateTime>(); // TODO: Initialize to an appropriate value
            Nullable<DateTime> actual;
            target.date_updated = expected;
            actual = target.date_updated;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for direction
        ///</summary>
        [TestMethod()]
        public void directionTest()
        {
            SMSMessage target = new SMSMessage(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.direction = expected;
            actual = target.direction;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for from
        ///</summary>
        [TestMethod()]
        public void fromTest()
        {
            SMSMessage target = new SMSMessage(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.from = expected;
            actual = target.from;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for price
        ///</summary>
        [TestMethod()]
        public void priceTest()
        {
            SMSMessage target = new SMSMessage(); // TODO: Initialize to an appropriate value
            Nullable<Decimal> expected = new Nullable<Decimal>(); // TODO: Initialize to an appropriate value
            Nullable<Decimal> actual;
            target.price = expected;
            actual = target.price;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for sid
        ///</summary>
        [TestMethod()]
        public void sidTest()
        {
            SMSMessage target = new SMSMessage(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.sid = expected;
            actual = target.sid;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for status
        ///</summary>
        [TestMethod()]
        public void statusTest()
        {
            SMSMessage target = new SMSMessage(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.status = expected;
            actual = target.status;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for to
        ///</summary>
        [TestMethod()]
        public void toTest()
        {
            SMSMessage target = new SMSMessage(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.to = expected;
            actual = target.to;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for uri
        ///</summary>
        [TestMethod()]
        public void uriTest()
        {
            SMSMessage target = new SMSMessage(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.uri = expected;
            actual = target.uri;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
