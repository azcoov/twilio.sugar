using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using twilio.sugar.Model;

namespace twilio.sugar.tests
{
    /// <summary>
    ///This is a test class for TwilioAccountTest and is intended
    ///to contain all TwilioAccountTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TwilioAccountTest
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

        /*
        /// <summary>
        ///A test for TwilioAccount Constructor
        ///</summary>
        [TestMethod()]
        public void TwilioAccountConstructorTest()
        {
            TwilioAccount target = new TwilioAccount();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
         * */

        /*[TestMethod()]
        [ExpectedException(typeof(Microsoft.CSharp.RuntimeBinder.RuntimeBinderException), "Cannot implicitly convert type 'string' to 'System.Uri'")]
        public void UriThrowsExceptionIfInvalidData()
        {
            TwilioAccount target = new TwilioAccount(); // TODO: Initialize to an appropriate value
            dynamic data = "http://www.google.com";
            var expected = data; // TODO: Initialize to an appropriate value
            Uri actual;

            target.uri = expected;
            actual = target.uri;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void UriDynamicTestWorksWithCorrectDataType()
        {
            TwilioAccount target = new TwilioAccount(); // TODO: Initialize to an appropriate value
            dynamic uri = new Uri("http://www.google.com");
            var expected = uri; // TODO: Initialize to an appropriate value
            Uri actual;

            target.uri = expected;
            actual = target.uri;

            Assert.AreEqual(expected, actual);
        }*/

        [TestMethod()]
        public void CreateSubAccountReturnsNewAccountResource()
        {
            TwilioAccount_Mock account = new TwilioAccount_Mock();
            PhoneAutomation PhoneAutomation = new PhoneAutomation(account);
            TwilioAccount twilioAccount = PhoneAutomation.CreateSubAccount("My new account test");

            Assert.IsNotNull(twilioAccount);
        }

        [TestMethod()]
        public void AvailableLocalPhoneNumbersByAreaCodeShouldReturnAvailablePhoneNumbersList()
        {
            TwilioAccount_Mock account = new TwilioAccount_Mock();
            PhoneAutomation PhoneAutomation = new PhoneAutomation(account);
            IList<AvailablePhoneNumber> AvailablePhoneNumbers = PhoneAutomation.AvailableLocalPhoneNumbers(1);

            Assert.IsNotNull(AvailablePhoneNumbers);
        }

        [TestMethod()]
        public void AvailableTollFreePhoneNumbersShouldReturnAvailablePhoneNumbersList()
        {
            TwilioAccount_Mock account = new TwilioAccount_Mock();
            PhoneAutomation PhoneAutomation = new PhoneAutomation(account);
            IList<AvailablePhoneNumber> AvailablePhoneNumbers = PhoneAutomation.AvailableTollFreePhoneNumbers();

            Assert.IsNotNull(AvailablePhoneNumbers);
        }

        [TestMethod()]
        public void AvailableTollFreePhoneNumbersByContainsShouldReturnAvailablePhoneNumbersList()
        {
            TwilioAccount_Mock account = new TwilioAccount_Mock();
            PhoneAutomation PhoneAutomation = new PhoneAutomation(account);
            IList<AvailablePhoneNumber> AvailablePhoneNumbers = PhoneAutomation.AvailableTollFreePhoneNumbers("55");

            Assert.IsNotNull(AvailablePhoneNumbers);
        }

        [TestMethod()]
        public void ProvisionNumberShouldReturnNewNumberResource()
        {
            TwilioAccount_Mock account = new TwilioAccount_Mock();
            PhoneAutomation PhoneAutomation = new PhoneAutomation(account);
            PhoneNumber number = PhoneAutomation.ProvisionPhoneNumber("555-555-5555");

            Assert.IsNotNull(number);
        }

        [TestMethod()]
        public void IncomingPhoneNumbersShouldReturnListOfPhoneNumbers()
        {
            TwilioAccount_Mock account = new TwilioAccount_Mock();
            PhoneAutomation PhoneAutomation = new PhoneAutomation(account);
            IList<PhoneNumber> numbers = PhoneAutomation.IncomingPhoneNumbers(phoneNumber: "555-555-5555");

            Assert.IsNotNull(numbers);
        }

        [TestMethod()]
        public void UpdateProvisionedPhoneNumberShouldReturnUpdatedPhoneResource()
        {
            throw new System.NotImplementedException();
        }

        [TestMethod()]
        public void DeleteProvisionedPhoneNumberWithValidPhoneObjectShouldReturnNullBody()
        {
            TwilioAccount_Mock account = new TwilioAccount_Mock();
            PhoneAutomation PhoneAutomation = new PhoneAutomation(account);

            PhoneNumber phoneNumber = new PhoneNumber{
                sid = "1", phone_number = "1"
            };
            PhoneAutomation.DeleteProvisionedPhoneNumber(phoneNumber);
        }

        [TestMethod()]
        public void DeleteProvisionedPhoneNumberWithNullSidShouldReturnArgumentNullException()
        {
            try
            {
                TwilioAccount_Mock account = new TwilioAccount_Mock();
                PhoneAutomation PhoneAutomation = new PhoneAutomation(account);

                PhoneNumber phoneNumber = new PhoneNumber();

                PhoneAutomation.DeleteProvisionedPhoneNumber(phoneNumber);
            }
            catch (System.Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(System.ArgumentNullException));
            }
            
        }

        [TestMethod()]
        public void DeleteProvisionedPhoneNumberWithNullObjectShouldReturnArgumentNullException()
        {
            try
            {
                TwilioAccount_Mock account = new TwilioAccount_Mock();
                PhoneAutomation PhoneAutomation = new PhoneAutomation(account);

                PhoneAutomation.DeleteProvisionedPhoneNumber(null);
            }
            catch (System.Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(System.ArgumentNullException));
            }
        }

        //send sms
        [TestMethod()]
        public void SendSMSMessageShouldReturnSMSMessageResource()
        {
            TwilioAccount_Mock account = new TwilioAccount_Mock();
            PhoneAutomation PhoneAutomation = new PhoneAutomation(account);
            SMSMessage message = PhoneAutomation.SendSMSMessage("Test_From", "Test_To", "Test_body");

            Assert.IsNotNull(message);
        }

        [TestMethod()]
        public void SMSListShouldReturnListOfSMSResources()
        {
            TwilioAccount_Mock account = new TwilioAccount_Mock();
            PhoneAutomation PhoneAutomation = new PhoneAutomation(account);
            SMS smsList = PhoneAutomation.SMSMessageList();

            Assert.IsNotNull(smsList);
            Assert.IsNotNull(smsList.sms_messages);
        }

        [TestMethod()]
        public void FetchingSMSResourceByIdShouldReturnSMSResource()
        {
            TwilioAccount_Mock account = new TwilioAccount_Mock();
            PhoneAutomation PhoneAutomation = new PhoneAutomation(account);
            SMSMessage sms = PhoneAutomation.GetSMSMessage("fake_guid"); //some random guid

            Assert.IsNotNull(sms);
        }

        [TestMethod()]
        public void CallingInvalidJsonMethodShouldReturnNotImplementedException()
        {
            try
            {
                TwilioAccount_Mock account = new TwilioAccount_Mock();
                account.request("fake_url", "GET", null);
            }
            catch (System.Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(System.NotImplementedException));
                Assert.IsTrue(ex.Message.Contains("Method is not implemented"));
            }
            
        }

    }

}
