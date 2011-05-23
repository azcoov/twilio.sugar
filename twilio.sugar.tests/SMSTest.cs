using twilio.sugar.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace twilio.sugar.tests
{
    
    
    /// <summary>
    ///This is a test class for SMSTest and is intended
    ///to contain all SMSTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SMSTest
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
        ///A test for SMS Constructor
        ///</summary>
        [TestMethod()]
        public void SMSConstructorTest()
        {
            SMS target = new SMS();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for end
        ///</summary>
        [TestMethod()]
        public void endTest()
        {
            SMS target = new SMS(); // TODO: Initialize to an appropriate value
            Nullable<int> expected = new Nullable<int>(); // TODO: Initialize to an appropriate value
            Nullable<int> actual;
            target.end = expected;
            actual = target.end;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for first_page_uri
        ///</summary>
        [TestMethod()]
        public void first_page_uriTest()
        {
            SMS target = new SMS(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.first_page_uri = expected;
            actual = target.first_page_uri;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for last_page_uri
        ///</summary>
        [TestMethod()]
        public void last_page_uriTest()
        {
            SMS target = new SMS(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.last_page_uri = expected;
            actual = target.last_page_uri;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for next_page_uri
        ///</summary>
        [TestMethod()]
        public void next_page_uriTest()
        {
            SMS target = new SMS(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.next_page_uri = expected;
            actual = target.next_page_uri;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for num_pages
        ///</summary>
        [TestMethod()]
        public void num_pagesTest()
        {
            SMS target = new SMS(); // TODO: Initialize to an appropriate value
            Nullable<int> expected = new Nullable<int>(); // TODO: Initialize to an appropriate value
            Nullable<int> actual;
            target.num_pages = expected;
            actual = target.num_pages;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for page
        ///</summary>
        [TestMethod()]
        public void pageTest()
        {
            SMS target = new SMS(); // TODO: Initialize to an appropriate value
            Nullable<int> expected = new Nullable<int>(); // TODO: Initialize to an appropriate value
            Nullable<int> actual;
            target.page = expected;
            actual = target.page;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for page_size
        ///</summary>
        [TestMethod()]
        public void page_sizeTest()
        {
            SMS target = new SMS(); // TODO: Initialize to an appropriate value
            Nullable<int> expected = new Nullable<int>(); // TODO: Initialize to an appropriate value
            Nullable<int> actual;
            target.page_size = expected;
            actual = target.page_size;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for previous_page_uri
        ///</summary>
        [TestMethod()]
        public void previous_page_uriTest()
        {
            SMS target = new SMS(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.previous_page_uri = expected;
            actual = target.previous_page_uri;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for sms_messages
        ///</summary>
        [TestMethod()]
        public void sms_messagesTest()
        {
            SMS target = new SMS(); // TODO: Initialize to an appropriate value
            IList<SMSMessage> expected = null; // TODO: Initialize to an appropriate value
            IList<SMSMessage> actual;
            target.sms_messages = expected;
            actual = target.sms_messages;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for start
        ///</summary>
        [TestMethod()]
        public void startTest()
        {
            SMS target = new SMS(); // TODO: Initialize to an appropriate value
            Nullable<int> expected = new Nullable<int>(); // TODO: Initialize to an appropriate value
            Nullable<int> actual;
            target.start = expected;
            actual = target.start;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for total
        ///</summary>
        [TestMethod()]
        public void totalTest()
        {
            SMS target = new SMS(); // TODO: Initialize to an appropriate value
            Nullable<int> expected = new Nullable<int>(); // TODO: Initialize to an appropriate value
            Nullable<int> actual;
            target.total = expected;
            actual = target.total;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for uri
        ///</summary>
        [TestMethod()]
        public void uriTest()
        {
            SMS target = new SMS(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.uri = expected;
            actual = target.uri;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
