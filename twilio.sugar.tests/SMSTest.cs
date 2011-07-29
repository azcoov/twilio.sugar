using twilio.sugar.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace twilio.sugar.tests
{
    
    /// <summary>
    ///This is a test class for SMSTest and is intended
    ///to contain all SMSTest Unit Tests
    ///</summary>
    [TestClass]
    public class SMSTest
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
        ///A test for SMS Constructor
        ///</summary>
        [TestMethod]
        public void SMSConstructorTest()
        {
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for end
        ///</summary>
        [TestMethod]
        public void EndTest()
        {
            var target = new SMS {end = null}; // TODO: Initialize to an appropriate value
            var actual = target.end;
            Assert.AreEqual(null, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for first_page_uri
        ///</summary>
        [TestMethod]
        public void FirstPageUriTest()
        {
            var target = new SMS(); // TODO: Initialize to an appropriate value
            var expected = string.Empty; // TODO: Initialize to an appropriate value
            target.first_page_uri = expected;
            var actual = target.first_page_uri;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for last_page_uri
        ///</summary>
        [TestMethod]
        public void LastPageUriTest()
        {
            var target = new SMS(); // TODO: Initialize to an appropriate value
            var expected = string.Empty; // TODO: Initialize to an appropriate value
            target.last_page_uri = expected;
            var actual = target.last_page_uri;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for next_page_uri
        ///</summary>
        [TestMethod]
        public void NextPageUriTest()
        {
            var target = new SMS(); // TODO: Initialize to an appropriate value
            var expected = string.Empty; // TODO: Initialize to an appropriate value
            target.next_page_uri = expected;
            var actual = target.next_page_uri;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for num_pages
        ///</summary>
        [TestMethod]
        public void NumPagesTest()
        {
            var target = new SMS {num_pages = null}; // TODO: Initialize to an appropriate value
            var actual = target.num_pages;
            Assert.AreEqual(null, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for page
        ///</summary>
        [TestMethod]
        public void PageTest()
        {
            var target = new SMS {page = null}; // TODO: Initialize to an appropriate value
            var actual = target.page;
            Assert.AreEqual(null, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for page_size
        ///</summary>
        [TestMethod]
        public void PageSizeTest()
        {
            var target = new SMS {page_size = null}; // TODO: Initialize to an appropriate value
            var actual = target.page_size;
            Assert.AreEqual(null, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for previous_page_uri
        ///</summary>
        [TestMethod]
        public void PreviousPageUriTest()
        {
            var target = new SMS(); // TODO: Initialize to an appropriate value
            var expected = string.Empty; // TODO: Initialize to an appropriate value
            target.previous_page_uri = expected;
            var actual = target.previous_page_uri;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for sms_messages
        ///</summary>
        [TestMethod]
        public void SMSMessagesTest()
        {
            var target = new SMS {sms_messages = null}; // TODO: Initialize to an appropriate value
            var actual = target.sms_messages;
            Assert.AreEqual(null, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for start
        ///</summary>
        [TestMethod]
        public void StartTest()
        {
            var target = new SMS {start = null}; // TODO: Initialize to an appropriate value
            var actual = target.start;
            Assert.AreEqual(null, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for total
        ///</summary>
        [TestMethod]
        public void TotalTest()
        {
            var target = new SMS {total = null}; // TODO: Initialize to an appropriate value
            var actual = target.total;
            Assert.AreEqual(null, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for uri
        ///</summary>
        [TestMethod]
        public void UriTest()
        {
            var target = new SMS(); // TODO: Initialize to an appropriate value
            var expected = string.Empty; // TODO: Initialize to an appropriate value
            target.uri = expected;
            var actual = target.uri;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
