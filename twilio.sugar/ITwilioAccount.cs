namespace twilio.sugar
{
    public interface ITwilioAccount
    {
        string id { get; }
        string token { get; }
        string request(string path, string method, System.Collections.Hashtable vars = null);
    }
}
