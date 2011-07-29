using System;

namespace twilio.sugar.Model
{
    //create a test for uri's vs string
    public class PhoneNumber
    {
        public String sid { get; set; }
        public String account_sid { get; set; }
        public String friendly_name { get; set; }
        public String phone_number { get; set; }
        public Int32? areaCode { get; set; }
        public String voice_url { get; set; }
        public String voice_method { get; set; }
        public String voice_fallback_url { get; set; }
        public String voice_fallback_method { get; set; }
        public Boolean voice_caller_id_lookup { get; set; }
        public DateTime? date_created { get; set; }
        public DateTime? date_updated { get; set; }
        public String sms_url { get; set; }
        public String sms_method { get; set; }
        public String sms_fallback_url { get; set; }
        public String sms_fallback_method { get; set; }
        public Capabilities capabilities { get; set; }
        public String status_callback { get; set; }
        public String status_callback_method { get; set; }
        public String api_version { get; set; }
        public String uri { get; set; }
    }
}
