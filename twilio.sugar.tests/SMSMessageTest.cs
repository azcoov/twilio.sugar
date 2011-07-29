using twilio.sugar.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace twilio.sugar.tests
{
    
    
    /// <summary>
    ///This is a test class for SMSMessageTest and is intended
    ///to contain all SMSMessageTest Unit Tests
    ///</summary>
    [TestClass]
    public class SMSMessageTest
    {
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

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
        [TestMethod]
        public void SMSMessageConstructorTest()
        {
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for account_sid
        ///</summary>
        [TestMethod]
        public void AccountSidTest()
        {
            var target = new SMSMessage(); // TODO: Initialize to an appropriate value
            var expected = string.Empty; // TODO: Initialize to an appropriate value
            target.account_sid = expected;
            var actual = target.account_sid;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for api_version
        ///</summary>
        [TestMethod]
        public void ApiVersionTest()
        {
            var target = new SMSMessage(); // TODO: Initialize to an appropriate value
            var expected = string.Empty; // TODO: Initialize to an appropriate value
            target.api_version = expected;
            var actual = target.api_version;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for body
        ///</summary>
        [TestMethod]
        public void BodyTest()
        {
            var target = new SMSMessage(); // TODO: Initialize to an appropriate value
            var expected = string.Empty; // TODO: Initialize to an appropriate value
            target.body = expected;
            var actual = target.body;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for date_created
        ///</summary>
        [TestMethod]
        public void DateCreatedTest()
        {
            var target = new SMSMessage {date_created = null}; // TODO: Initialize to an appropriate value
            var actual = target.date_created;
            Assert.AreEqual(null, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for date_sent
        ///</summary>
        [TestMethod]
        public void DateSentTest()
        {
            var target = new SMSMessage {date_sent = null}; // TODO: Initialize to an appropriate value
            var actual = target.date_sent;
            Assert.AreEqual(null, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for date_updated
        ///</summary>
        [TestMethod]
        public void DateUpdatedTest()
        {
            var target = new SMSMessage {date_updated = null}; // TODO: Initialize to an appropriate value
            DateTime? actual = target.date_updated;
            Assert.AreEqual(null, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for direction
        ///</summary>
        [TestMethod]
        public void DirectionTest()
        {
            var target = new SMSMessage(); // TODO: Initialize to an appropriate value
            var expected = string.Empty; // TODO: Initialize to an appropriate value
            target.direction = expected;
            var actual = target.direction;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for from
        ///</summary>
        [TestMethod]
        public void FromTest()
        {
            var target = new SMSMessage(); // TODO: Initialize to an appropriate value
            var expected = string.Empty; // TODO: Initialize to an appropriate value
            target.from = expected;
            var actual = target.from;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for price
        ///</summary>
        [TestMethod]
        public void PriceTest()
        {
            var target = new SMSMessage(); // TODO: Initialize to an appropriate value
            target.price = null;
            var actual = target.price;
            Assert.AreEqual(null, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for sid
        ///</summary>
        [TestMethod]
        public void SidTest()
        {
            var target = new SMSMessage(); // TODO: Initialize to an appropriate value
            var expected = string.Empty; // TODO: Initialize to an appropriate value
            target.sid = expected;
            var actual = target.sid;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for status
        ///</summary>
        [TestMethod]
        public void StatusTest()
        {
            var target = new SMSMessage(); // TODO: Initialize to an appropriate value
            var expected = string.Empty; // TODO: Initialize to an appropriate value
            target.status = expected;
            var actual = target.status;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for to
        ///</summary>
        [TestMethod]
        public void ToTest()
        {
            var target = new SMSMessage(); // TODO: Initialize to an appropriate value
            var expected = string.Empty; // TODO: Initialize to an appropriate value
            target.to = expected;
            var actual = target.to;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for uri
        ///</summary>
        [TestMethod]
        public void UriTest()
        {
            var target = new SMSMessage(); // TODO: Initialize to an appropriate value
            var expected = string.Empty; // TODO: Initialize to an appropriate value
            target.uri = expected;
            var actual = target.uri;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
