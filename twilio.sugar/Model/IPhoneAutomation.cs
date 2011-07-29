using System;
using System.Collections.Generic;
namespace twilio.sugar.Model
{
    public interface IPhoneAutomation
    {
        Account CreateSubAccount(String friendlyName);
        IList<AvailablePhoneNumber> AvailableLocalPhoneNumbers(int? areaCode = null, string contains = null, string inRegion = null, int? inPostalCode = null);
        IList<AvailablePhoneNumber> AvailableTollFreePhoneNumbers(String contains = null);
        SMSMessage GetSMSMessage(String sid);
        SMS SMSMessageList(String to = null, String from = null, DateTime? dateSent = null);
        PhoneNumber ProvisionPhoneNumber(String phoneNumber = null, Int32? areaCode = null, PhoneNumber model = null, String voiceUrl = null, String voiceFallbackUrl = null, String smsUrl = null, String smsFallbackUrl = null);
        PhoneNumber ProvisionTollFreePhoneNumber(String phoneNumber, String voiceUrl = null, String voiceFallbackUrl = null);
        IList<PhoneNumber> IncomingPhoneNumbers(String phoneNumber = "", String friendlyName = "");
        SMSMessage SendSMSMessage(String from, String to, String body, String statusCallback = "");
        void DeleteProvisionedPhoneNumber(PhoneNumber model);
    }
}
