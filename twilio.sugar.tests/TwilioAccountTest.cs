using Microsoft.VisualStudio.TestTools.UnitTesting;
using twilio.sugar.Model;

namespace twilio.sugar.tests
{
    /// <summary>
    ///This is a test class for TwilioAccountTest and is intended
    ///to contain all TwilioAccountTest Unit Tests
    ///</summary>
    [TestClass]
    public class TwilioAccountTest
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

        [TestMethod]
        public void CreateSubAccountReturnsNewAccountResource()
        {
            var account = new TwilioAccountMock();
            var phoneAutomation = new PhoneAutomation(account);
            var twilioAccount = phoneAutomation.CreateSubAccount("My new account test");

            Assert.IsNotNull(twilioAccount);
        }

        [TestMethod]
        public void GetSubAccountsReturnsAccountListResource()
        {
            var account = new TwilioAccountMock();
            var phoneAutomation = new PhoneAutomation(account);
            var accounts = phoneAutomation.GetSubAccounts();

            Assert.IsNotNull(accounts);
        }

        [TestMethod]
        public void AvailableLocalPhoneNumbersByAreaCodeShouldReturnAvailablePhoneNumbersList()
        {
            var account = new TwilioAccountMock();
            var phoneAutomation = new PhoneAutomation(account);
            var availablePhoneNumbers = phoneAutomation.AvailableLocalPhoneNumbers(1);

            Assert.IsNotNull(availablePhoneNumbers);
        }

        [TestMethod]
        public void AvailableTollFreePhoneNumbersShouldReturnAvailablePhoneNumbersList()
        {
            var account = new TwilioAccountMock();
            var phoneAutomation = new PhoneAutomation(account);
            var availablePhoneNumbers = phoneAutomation.AvailableTollFreePhoneNumbers();

            Assert.IsNotNull(availablePhoneNumbers);
        }

        [TestMethod]
        public void AvailableTollFreePhoneNumbersByContainsShouldReturnAvailablePhoneNumbersList()
        {
            var account = new TwilioAccountMock();
            var phoneAutomation = new PhoneAutomation(account);
            var availablePhoneNumbers = phoneAutomation.AvailableTollFreePhoneNumbers("55");

            Assert.IsNotNull(availablePhoneNumbers);
        }

        [TestMethod]
        public void ProvisionNumberShouldReturnNewNumberResource()
        {
            var account = new TwilioAccountMock();
            var phoneAutomation = new PhoneAutomation(account);
            var number = phoneAutomation.ProvisionPhoneNumber("555-555-5555");

            Assert.IsNotNull(number);
        }

        [TestMethod]
        public void IncomingPhoneNumbersShouldReturnListOfPhoneNumbers()
        {
            var account = new TwilioAccountMock();
            var phoneAutomation = new PhoneAutomation(account);
            var numbers = phoneAutomation.IncomingPhoneNumbers(phoneNumber: "555-555-5555");

            Assert.IsNotNull(numbers);
        }

        [TestMethod]
        public void IncomingPhoneNumbersByFriendlyNameShouldReturnListOfPhoneNumbers()
        {
            var account = new TwilioAccountMock();
            var phoneAutomation = new PhoneAutomation(account);
            var numbers = phoneAutomation.IncomingPhoneNumbers(phoneNumber: "555-555-5555", friendlyName: "test");

            Assert.IsNotNull(numbers);
        }

        [TestMethod]
        public void IncomingPhoneNumbersWithNowParametersShouldThrowNullReferenceError()
        {
            try
            {
                var account = new TwilioAccountMock();
                var phoneAutomation = new PhoneAutomation(account);
                phoneAutomation.IncomingPhoneNumbers();
                Assert.Fail("Cannot call this method without params");
            }
            catch (System.Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(System.ArgumentNullException));
                Assert.IsTrue(ex.Message.Contains("missing phoneNumber"));
            }
        }

        [TestMethod]
        public void UpdateProvisionedPhoneNumberShouldReturnUpdatedPhoneResource()
        {
            throw new System.NotImplementedException();
        }

        [TestMethod]
        public void DeleteProvisionedPhoneNumberWithValidPhoneObjectShouldReturnNullBody()
        {
            var account = new TwilioAccountMock();
            var phoneAutomation = new PhoneAutomation(account);

            var phoneNumber = new PhoneNumber{
                sid = "1", phone_number = "1"
            };
            phoneAutomation.DeleteProvisionedPhoneNumber(phoneNumber);
        }

        [TestMethod]
        public void DeleteProvisionedPhoneNumberWithNullSidShouldReturnArgumentNullException()
        {
            try
            {
                var account = new TwilioAccountMock();
                var phoneAutomation = new PhoneAutomation(account);

                var phoneNumber = new PhoneNumber();

                phoneAutomation.DeleteProvisionedPhoneNumber(phoneNumber);
            }
            catch (System.Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(System.ArgumentNullException));
            }
            
        }

        [TestMethod]
        public void DeleteProvisionedPhoneNumberWithNullObjectShouldReturnArgumentNullException()
        {
            try
            {
                var account = new TwilioAccountMock();
                var phoneAutomation = new PhoneAutomation(account);

                phoneAutomation.DeleteProvisionedPhoneNumber(null);
            }
            catch (System.Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(System.ArgumentNullException));
            }
        }

        //send sms
        [TestMethod]
        public void SendSMSMessageShouldReturnSMSMessageResource()
        {
            var account = new TwilioAccountMock();
            var phoneAutomation = new PhoneAutomation(account);
            var message = phoneAutomation.SendSMSMessage("Test_From", "Test_To", "Test_body");

            Assert.IsNotNull(message);
        }

        [TestMethod]
        public void SMSListShouldReturnListOfSMSResources()
        {
            var account = new TwilioAccountMock();
            var phoneAutomation = new PhoneAutomation(account);
            var smsList = phoneAutomation.SMSMessageList();

            Assert.IsNotNull(smsList);
            Assert.IsNotNull(smsList.sms_messages);
        }

        [TestMethod]
        public void FetchingSMSResourceByIdShouldReturnSMSResource()
        {
            var account = new TwilioAccountMock();
            var phoneAutomation = new PhoneAutomation(account);
            var sms = phoneAutomation.GetSMSMessage("fake_guid"); //some random guid

            Assert.IsNotNull(sms);
        }

        [TestMethod]
        public void CallingInvalidJsonMethodShouldReturnNotImplementedException()
        {
            try
            {
                var account = new TwilioAccountMock();
                account.request("fake_url", "GET");
            }
            catch (System.Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(System.NotImplementedException));
                Assert.IsTrue(ex.Message.Contains("Method is not implemented"));
            }
            
        }

    }

}
