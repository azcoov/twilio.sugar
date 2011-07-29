using System;

namespace twilio.sugar.Model
{
    public class AvailablePhoneNumber
    {
        public String friendly_name { get; set; }
        public String phone_number { get; set; }
        public String lata { get; set; }
        public String rate_center { get; set; }
        public Decimal? latitude { get; set; }
        public Decimal? longitude { get; set; }
        public String region { get; set; }
        public String postal_code { get; set; }
        public String iso_country { get; set; }
    }
}
