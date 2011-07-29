/*
Copyright (c) 2008-2010 Twilio, Inc.

Permission is hereby granted, free of charge, to any person
obtaining a copy of this software and associated documentation
files (the "Software"), to deal in the Software without
restriction, including without limitation the rights to use,
copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the
Software is furnished to do so, subject to the following
conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
OTHER DEALINGS IN THE SOFTWARE.
*/

using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace twilio.sugar
{
    public class TwilioAccount : ITwilioAccount
    {
        const string TwilioApiUrl = "https://api.twilio.com";
        const string ApiVersion = "2010-04-01";

        public string id { get; private set; }
        public string token { get; private set; }

        public TwilioAccount(string id, string token)
        {
            this.id = id;
            this.token = token;
        }

        private string Download(string uri, Hashtable vars)
        {
            // 1. format query string
            if (vars != null)
            {
                string query = vars.Cast<DictionaryEntry>().Aggregate("", (current, d) => current + ("&" + d.Key.ToString() + "=" + HttpUtility.UrlEncode(d.Value.ToString())));
                if (query.Length > 0)
                    uri = uri + "?" + query.Substring(1);
            }
            
            // 2. setup basic authenication
            string authstring = Convert.ToBase64String(Encoding.ASCII.GetBytes(String.Format("{0}:{1}",id, token)));
            
            // 3. perform GET using WebClient
            var client = new WebClient();
            client.Headers.Add("Authorization",
                String.Format("Basic {0}", authstring));
            byte[] resp = client.DownloadData(uri);
            
            return Encoding.ASCII.GetString(resp);
        }
        
        private string Upload(string uri, string method, Hashtable vars)
        {
            // 1. format body data
            var data = "";
            if (vars != null)
            {
                data = vars.Cast<DictionaryEntry>().Aggregate(data, (current, d) => current + (d.Key.ToString() + "=" + HttpUtility.UrlEncode(d.Value.ToString()) + "&"));
            }
            
            // 2. setup basic authenication
            var authstring = Convert.ToBase64String(Encoding.ASCII.GetBytes(String.Format("{0}:{1}", id, token)));
            
            // 3. perform POST/PUT/DELETE using WebClient
            ServicePointManager.Expect100Continue = false;
            Byte[] postbytes = Encoding.ASCII.GetBytes(data);
            var client = new WebClient();
            
            client.Headers.Add("Authorization", String.Format("Basic {0}", authstring));
            client.Headers.Add("Content-Type",  "application/x-www-form-urlencoded");
            
            byte[] resp = client.UploadData(uri, method, postbytes);
            
            return Encoding.ASCII.GetString(resp);
        }
        
        private string _build_uri(string path)
        {
            path = String.Format("/{0}/", ApiVersion) + path;

            if (path[0] == '/')
                return TwilioApiUrl + path;
            return TwilioApiUrl + "/" + path;
        }
        
        public string request(string path, string method, Hashtable vars = null)
        {
            string response;
            
            if (path == null || path.Length <= 0)
                throw(new ArgumentException("Invalid path parameter"));
            
            method = method.ToUpper();
            if (method == null || (method != "GET" && method != "POST" && method != "PUT" && method != "DELETE"))
            {
                throw(new ArgumentException("Invalid method parameter"));
            }
            
            if (vars != null && (method != "GET" && vars.Count <= 0))
            {
                throw(new ArgumentException("No vars parameters"));
            }

            string url = _build_uri(path);
            try
            {
                response = method == "GET" ? Download(url, vars) : Upload(url, method, vars);
            }
            catch(WebException e)
            {
                string message = e.Message;

                switch(e.Status)
                {
                    case WebExceptionStatus.TrustFailure:
                        message = "You do not trust the people who issued the certificate being used by twiliorest.dll.";
                        break;
                }

                if (vars != null)
                {
                    var varList = vars.Cast<DictionaryEntry>().Aggregate("", (current, d) => current + ("&" + d.Key.ToString() + "=" + HttpUtility.UrlEncode(d.Value.ToString())));


                    var responseStr = "";
                    if (e.Response != null)
                    {
                        var responseStream = e.Response.GetResponseStream();
                        if (responseStream != null)
                        {
                            using (var sr = new StreamReader(responseStream))
                            {
                                string line;
                                while ((line = sr.ReadLine()) != null)
                                {
                                    responseStr += line;
                                }
                            }
                        }
                    }


                    message = String.Format("TwilioRestException occurred in the request you sent: \n{0}\n\tURLL: {1}\n\tMETHOD:{2}\n\tVARS:{3}\n\tRESPONSE:{4}",
                                            message,
                                            url,
                                            method,
                                            varList,
                                            responseStr);
                }

                throw new TwilioRestException(message, e);
            }

            return response;
        }
    }

    [Serializable]
    public class TwilioRestException : Exception {

        public TwilioRestException()
        {
        }
        
        public TwilioRestException(string message) : base(message)
        {
        }

        public TwilioRestException(string message, Exception innerException) : base(message, innerException)
        { 
        }

        protected TwilioRestException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }
        
    }
}
