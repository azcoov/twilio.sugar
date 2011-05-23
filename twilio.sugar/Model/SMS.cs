using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace twilio.sugar.Model
{
    public class SMS
    {
        public Int32? start { get; set; }
        public Int32? total { get; set; }
        public Int32? num_pages { get; set; }
        public Int32? page { get; set; }
        public Int32? page_size { get; set; }
        public Int32? end { get; set; }
        public String uri { get; set; }
        public String first_page_uri { get; set; }
        public String last_page_uri { get; set; }
        public String next_page_uri { get; set; }
        public String previous_page_uri { get; set; }
        public IList<SMSMessage> sms_messages { get; set; }
    }

    public class SMSMessage
    {
        public String sid { get; set; }
        public DateTime? date_created { get; set; }
        public DateTime? date_updated { get; set; }
        public DateTime? date_sent { get; set; }
        public String account_sid { get; set; }
        public String from { get; set; }
        public String to { get; set; }
        public String body { get; set; }
        public String status { get; set; }
        public String direction { get; set; }
        public Decimal? price { get; set; }
        public String api_version { get; set; }
        public String uri { get; set; }
    }
}
