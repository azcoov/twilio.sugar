using System;

namespace twilio.sugar.tests
{
    /// <summary>
    /// Use the Twilio API example for test data
    /// </summary>
    public class TwilioAccountMock : ITwilioAccount
    {
        public string request(string path, string method, System.Collections.Hashtable vars = null)
        {
            if (path.Contains("AvailablePhoneNumbers") && method == "GET")
            {
                return "{\"uri\":\"\\/2010-04-01\\/Accounts\\/ACba8bc05eacf94afdae398e642c9cc32d\\/AvailablePhoneNumbers\\/US\\/Local.json?Contains=9119\",\"available_phone_numbers\":[{\"friendly_name\":\"(586) 991-1988\",\"phone_number\":\"+15869911988\",\"lata\":\"340\",\"rate_center\":\"UTICA\",\"latitude\":\"42.630000\",\"longitude\":\"-83.030000\",\"region\":\"MI\",\"postal_code\":\"48316\",\"iso_country\":\"US\"},{\"friendly_name\":\"(586) 991-1949\",\"phone_number\":\"+15869911949\",\"lata\":\"340\",\"rate_center\":\"UTICA\",\"latitude\":\"42.630000\",\"longitude\":\"-83.030000\",\"region\":\"MI\",\"postal_code\":\"48316\",\"iso_country\":\"US\"}]}";
            }
            if (path.Contains("sms/messages") && method == "GET")
            {
                return "{\"start\":0,\"total\":261,\"num_pages\":6,\"page\":0,\"page_size\":50,\"end\":49,\"uri\":\"/2010-04-01/Accounts/AC5ef872f6da5a21de157d80997a64bd33/SMS/Messages.json\",\"first_page_uri\":\"/2010-04-01/Accounts/AC5ef872f6da5a21de157d80997a64bd33/SMS/Messages.json?Page=0&PageSize=50\",\"last_page_uri\":\"/2010-04-01/Accounts/AC5ef872f6da5a21de157d80997a64bd33/SMS/Messages.json?Page=5&PageSize=50\",\"next_page_uri\":\"/2010-04-01/Accounts/AC5ef872f6da5a21de157d80997a64bd33/SMS/Messages.json?Page=1&PageSize=50\",\"previous_page_uri\":null,\"sms_messages\":[{\"account_sid\":\"AC5ef872f6da5a21de157d80997a64bd33\",\"api_version\":\"2008-08-01\",\"body\":\"Hey Jenny why aren't you returning my calls?\",\"date_created\":\"Mon, 16 Aug 2010 03:45:01 +0000\",\"date_sent\":\"Mon, 16 Aug 2010 03:45:03 +0000\",\"date_updated\":\"Mon, 16 Aug 2010 03:45:03 +0000\",\"direction\":\"outbound-api\",\"from\":\"+14158141829\",\"price\":\"-0.02000\",\"sid\":\"SM800f449d0399ed014aae2bcc0cc2f2ec\",\"status\":\"sent\",\"to\":\"+14159978453\",\"uri\":\"/2010-04-01/Accounts/AC5ef872f6da5a21de157d80997a64bd33/SMS/Messages/SM800f449d0399ed014aae2bcc0cc2f2ec.json\"}]}";
            }
            if (path.Contains("sms") && method == "POST")
            {
                return "{\"account_sid\":\"ACba8bc05eacf94afdae398e642c9cc32d\",\"api_version\":\"2010-04-01\",\"body\":\"Jenny please?! I love you <3\",\"date_created\":\"Wed, 18 Aug 2010 20:01:40 +0000\",\"date_sent\":null,\"date_updated\":\"Wed, 18 Aug 2010 20:01:40 +0000\",\"direction\":\"outbound-api\",\"from\":\"+14158141829\",\"price\":null,\"sid\":\"SM90c6fc909d8504d45ecdb3a3d5b3556e\",\"status\":\"queued\",\"to\":\"+14159352345\",\"uri\":\"/2010-04-01/Accounts/AC5ef872f6da5a21de157d80997a64bd33/SMS/Messages/SM90c6fc909d8504d45ecdb3a3d5b3556e.json\"}";
            }
            /*if (path.Contains("Accounts.json") && method == "GET")
            {
                return "{\"sid\":\"ACba8bc05eacf94afdae398e642c9cc32d\",\"friendly_name\":\"Submarine\",\"auth_token\":\"redacted\",\"date_created\":\"Tue, 25 Jan 2011 19:24:40 +0000\",\"date_updated\":\"Tue, 25 Jan 2011 19:25:02 +0000\",\"status\":\"active\",\"subresource_uris\":{\"available_phone_numbers\":\"/2010-04-01/Accounts/AC1365ff479ef6502d85c27be6467a310c/AvailablePhoneNumbers.json\",\"calls\":\"/2010-04-01/Accounts/AC1365ff479ef6502d85c27be6467a310c/Calls.json\",\"conferences\":\"/2010-04-01/Accounts/AC1365ff479ef6502d85c27be6467a310c/Conferences.json\",\"incoming_phone_numbers\":\"/2010-04-01/Accounts/AC1365ff479ef6502d85c27be6467a310c/IncomingPhoneNumbers.json\",\"notifications\":\"/2010-04-01/Accounts/AC1365ff479ef6502d85c27be6467a310c/Notifications.json\",\"outgoing_caller_ids\":\"/2010-04-01/Accounts/AC1365ff479ef6502d85c27be6467a310c/OutgoingCallerIds.json\",\"recordings\":\"/2010-04-01/Accounts/AC1365ff479ef6502d85c27be6467a310c/Recordings.json\",\"sandbox\":\"/2010-04-01/Accounts/AC1365ff479ef6502d85c27be6467a310c/Sandbox.json\",\"sms_messages\":\"/2010-04-01/Accounts/AC1365ff479ef6502d85c27be6467a310c/SMS/Messages.json\",\"transcriptions\":\"/2010-04-01/Accounts/AC1365ff479ef6502d85c27be6467a310c/Transcriptions.json\"},\"type\":\"Full\",\"uri\":\"/2010-04-01/Accounts/AC1365ff479ef6502d85c27be6467a310c.json\"}";
            }*/
            if (path.Contains("Accounts.json") && method == "POST")
            {
                return "{\"sid\":\"ACba8bc05eacf94afdae398e642c9cc32d\",\"friendly_name\":\"Submarine\",\"auth_token\":\"redacted\",\"date_created\":\"Tue, 25 Jan 2011 19:24:40 +0000\",\"date_updated\":\"Tue, 25 Jan 2011 19:25:02 +0000\",\"status\":\"active\",\"subresource_uris\":{\"available_phone_numbers\":\"/2010-04-01/Accounts/AC1365ff479ef6502d85c27be6467a310c/AvailablePhoneNumbers.json\",\"calls\":\"/2010-04-01/Accounts/AC1365ff479ef6502d85c27be6467a310c/Calls.json\",\"conferences\":\"/2010-04-01/Accounts/AC1365ff479ef6502d85c27be6467a310c/Conferences.json\",\"incoming_phone_numbers\":\"/2010-04-01/Accounts/AC1365ff479ef6502d85c27be6467a310c/IncomingPhoneNumbers.json\",\"notifications\":\"/2010-04-01/Accounts/AC1365ff479ef6502d85c27be6467a310c/Notifications.json\",\"outgoing_caller_ids\":\"/2010-04-01/Accounts/AC1365ff479ef6502d85c27be6467a310c/OutgoingCallerIds.json\",\"recordings\":\"/2010-04-01/Accounts/AC1365ff479ef6502d85c27be6467a310c/Recordings.json\",\"sandbox\":\"/2010-04-01/Accounts/AC1365ff479ef6502d85c27be6467a310c/Sandbox.json\",\"sms_messages\":\"/2010-04-01/Accounts/AC1365ff479ef6502d85c27be6467a310c/SMS/Messages.json\",\"transcriptions\":\"/2010-04-01/Accounts/AC1365ff479ef6502d85c27be6467a310c/Transcriptions.json\"},\"type\":\"Full\",\"uri\":\"/2010-04-01/Accounts/AC1365ff479ef6502d85c27be6467a310c.json\"}";
            }
            if (path.Contains("IncomingPhoneNumbers") && method == "POST")
            {
                return "{\"sid\":\"PN2a0747eba6abf96b7e3c3ff0b4530f6e\",\"account_sid\":\"ACba8bc05eacf94afdae398e642c9cc32d\",\"friendly_name\":\"My Company Line\",\"phone_number\":\"+15105647903\",\"voice_url\":\"http://myapp.com/awesome\",\"voice_method\":\"POST\",\"voice_fallback_url\":null,\"voice_fallback_method\":\"POST\",\"voice_caller_id_lookup\":null,\"date_created\":\"Mon, 16 Aug 2010 23:00:23 +0000\",\"date_updated\":\"Mon, 16 Aug 2010 23:00:23 +0000\",\"sms_url\":\"http://myapp.com/awesome\",\"sms_method\":\"POST\",\"sms_fallback_url\":null,\"sms_fallback_method\":\"GET\",\"capabilities\":{\"voice\":\"true\",\"sms\":\"true\"},\"status_callback\":null,\"status_callback_method\":null,\"api_version\":\"2010-04-01\",\"uri\":\"\\/2010-04-01\\/Accounts\\/AC755325d45d80675a4727a7a54e1b4ce4\\/IncomingPhoneNumbers\\/PN2a0747eba6abf96b7e3c3ff0b4530f6e.json\"}";
            }
            if (path.Contains("IncomingPhoneNumbers") && method == "GET")
            {
                return "{\"page\":0,\"num_pages\":1,\"page_size\":50,\"total\":6,\"start\":0,\"end\":5,\"uri\":\"\\/2010-04-01\\/Accounts\\/ACba8bc05eacf94afdae398e642c9cc32d\\/IncomingPhoneNumbers.json\",\"first_page_uri\":\"\\/2010-04-01\\/Accounts\\/ACdc5f1e11047ebd6fe7a55f120be3a900\\/IncomingPhoneNumbers.json?Page=0&PageSize=50\",\"previous_page_uri\":null,\"next_page_uri\":null,\"last_page_uri\":\"\\/2010-04-01\\/Accounts\\/ACdc5f1e11047ebd6fe7a55f120be3a900\\/IncomingPhoneNumbers.json?Page=0&PageSize=50\",\"incoming_phone_numbers\":[{\"sid\":\"PN3f94c94562ac88dccf16f8859a1a8b25\",\"account_sid\":\"ACdc5f1e11047ebd6fe7a55f120be3a900\",\"friendly_name\":\"Long Play\",\"phone_number\":\"+14152374451\",\"voice_url\":\"http:\\/\\/demo.twilio.com\\/long\",\"voice_method\":\"GET\",\"voice_fallback_url\":null,\"voice_fallback_method\":null,\"voice_caller_id_lookup\":null,\"date_created\":\"Thu, 13 Nov 2008 07:56:24 +0000\",\"date_updated\":\"Thu, 13 Nov 2008 08:45:58 +0000\",\"sms_url\":null,\"sms_method\":null,\"sms_fallback_url\":null,\"sms_fallback_method\":null,\"capabilities\":{\"voice\":true,\"sms\":false},\"status_callback\":null,\"status_callback_method\":null,\"api_version\":\"2010-04-01\",\"uri\":\"\\/2010-04-01\\/Accounts\\/ACdc5f1e11047ebd6fe7a55f120be3a900\\/IncomingPhoneNumbers\\/PN3f94c94562ac88dccf16f8859a1a8b25.json\"}]}";
            }
            if (path.Contains("IncomingPhoneNumbers") && method == "DELETE")
            {
                return null;
            }
            throw new NotImplementedException("Method is not implemented");
        }

        public string id
        {
            get { return "fake_id"; }
        }

        public string token
        {
            get { return "fake_token"; }
        }
    }
}
