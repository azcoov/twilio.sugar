using System;

namespace twilio.sugar
{
    public class Account
    {
        public String sid { get; set; }
        public String friendly_name { get; set; }
        public String auth_token { get; set; }
        public DateTime? date_created { get; set; }
        public DateTime? date_updated { get; set; }
        public String type { get; set; }
        public String uri { get; set; }
        public String status { get; set; }
        public SubresourceUri subresource_uris { get; set; }
    }
}
