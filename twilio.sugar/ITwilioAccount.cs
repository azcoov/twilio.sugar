using System;

namespace twilio.sugar
{
    public interface ITwilioAccount
    {
        string request(string path, string method, System.Collections.Hashtable vars = null);
    }
}
