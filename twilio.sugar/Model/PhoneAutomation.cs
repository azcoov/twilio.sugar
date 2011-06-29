using System;
using System.Collections;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace twilio.sugar.Model
{
    public class PhoneAutomation : twilio.sugar.Model.IPhoneAutomation
    {
        const string IsoCountryCode = "US";

        private ITwilioAccount account;
        private Hashtable parameters = new Hashtable();
        private String twilioResponse;

        public PhoneAutomation(ITwilioAccount account)
        {
            this.account = account;
        }

        private static dynamic ParseResponseData(string response)
        {
            var jss = new JavaScriptSerializer();
            jss.RegisterConverters(new JavaScriptConverter[] { new DynamicJsonConverter() });
            dynamic data = jss.Deserialize(response, typeof(object)) as dynamic;
            return data;
        }

        public Account CreateSubAccount(String friendlyName)
        {
            parameters.Clear();
            parameters.Add("FriendlyName", friendlyName);

            twilioResponse = account.request("Accounts.json", "POST", parameters);
            dynamic data = ParseResponseData(twilioResponse);

            var twilioAccount = new Account {
                sid = data.sid,
                friendly_name = data.friendly_name,
                status = data.status,
                auth_token = data.auth_token,
                date_created = Convert.ToDateTime(data.date_created),
                date_updated = Convert.ToDateTime(data.date_updated),
                type = data.type,
                uri = data.uri
            };

            var subresourceUri = new SubresourceUri {
                available_phone_numbers = data.subresource_uris.available_phone_numbers,
                calls = data.subresource_uris.calls,
                conferences = data.subresource_uris.conferences,
                incoming_phone_numbers = data.subresource_uris.incoming_phone_numbers,
                notifications = data.subresource_uris.notifications,
                outgoing_caller_ids = data.subresource_uris.outgoing_caller_ids,
                recordings = data.subresource_uris.recordings,
                sandbox = data.subresource_uris.sandbox,
                sms_messages = data.subresource_uris.sms_messages,
                transcriptions = data.subresource_uris.transcriptions
            };

            twilioAccount.subresource_uris = subresourceUri;

            return twilioAccount;
        }

        public IList<Account> GetSubAccounts()
        {
            parameters.Clear();

            twilioResponse = account.request("Accounts.json", "GET", parameters);
            dynamic data = ParseResponseData(twilioResponse);

            IList<Account> accounts = new List<Account>();

            foreach (dynamic item in data.accounts)
            {
                var acct = new Account
                {
                    sid = item.sid,
                    friendly_name = item.friendly_name,
                    status = item.status,
                    auth_token = item.auth_token,
                    date_created = Convert.ToDateTime(item.date_created),
                    date_updated = Convert.ToDateTime(item.date_updated),
                    type = item.type,
                    uri = item.uri
                };
                var subresourceUri = new SubresourceUri
                {
                    available_phone_numbers = item.subresource_uris.available_phone_numbers,
                    calls = item.subresource_uris.calls,
                    conferences = item.subresource_uris.conferences,
                    incoming_phone_numbers = item.subresource_uris.incoming_phone_numbers,
                    notifications = item.subresource_uris.notifications,
                    outgoing_caller_ids = item.subresource_uris.outgoing_caller_ids,
                    recordings = item.subresource_uris.recordings,
                    sandbox = item.subresource_uris.sandbox,
                    sms_messages = item.subresource_uris.sms_messages,
                    transcriptions = item.subresource_uris.transcriptions
                };

                acct.subresource_uris = subresourceUri;

                accounts.Add(acct);
            }

            return accounts;
        }

        public Account GetSubAccount(String friendlyName)
        {
            parameters.Clear();
            if (String.IsNullOrEmpty(friendlyName))
            {
                throw new ArgumentNullException("Friendly name is required");
            }
            parameters.Add("FriendlyName", friendlyName);

            twilioResponse = account.request("Accounts.json", "GET", parameters);
            dynamic data = ParseResponseData(twilioResponse);

            var acct = new Account
            {
                sid = data.sid,
                friendly_name = data.friendly_name,
                status = data.status,
                auth_token = data.auth_token,
                date_created = Convert.ToDateTime(data.date_created),
                date_updated = Convert.ToDateTime(data.date_updated),
                type = data.type,
                uri = data.uri
            };
            var subresourceUri = new SubresourceUri
            {
                available_phone_numbers = data.subresource_uris.available_phone_numbers,
                calls = data.subresource_uris.calls,
                conferences = data.subresource_uris.conferences,
                incoming_phone_numbers = data.subresource_uris.incoming_phone_numbers,
                notifications = data.subresource_uris.notifications,
                outgoing_caller_ids = data.subresource_uris.outgoing_caller_ids,
                recordings = data.subresource_uris.recordings,
                sandbox = data.subresource_uris.sandbox,
                sms_messages = data.subresource_uris.sms_messages,
                transcriptions = data.subresource_uris.transcriptions
            };

            acct.subresource_uris = subresourceUri;

            return acct;
        }

        public IList<AvailablePhoneNumber> AvailableLocalPhoneNumbers(Int32? areaCode = null, String contains = null, String inRegion = null, Int32? inPostalCode = null)
        {
            parameters.Clear();
            if (areaCode.HasValue) {
                parameters.Add("AreaCode", areaCode);
            }
            if (!String.IsNullOrEmpty(contains)) {
                parameters.Add("Contains", contains);
            }
            if (!String.IsNullOrEmpty(inRegion)) {
                parameters.Add("InRegion", inRegion);
            }
            if (inPostalCode.HasValue) {
                parameters.Add("InPostalCode", inPostalCode);
            }

            twilioResponse = account.request(String.Format("Accounts/{0}/AvailablePhoneNumbers/{1}/Local.json", account.id, IsoCountryCode), "GET", parameters);
            dynamic data = ParseResponseData(twilioResponse);

            IList<AvailablePhoneNumber> phoneNumbers = new List<AvailablePhoneNumber>();

            foreach (dynamic item in data.available_phone_numbers) {
                phoneNumbers.Add(new AvailablePhoneNumber {
                    friendly_name = item.friendly_name,
                    iso_country = item.iso_country,
                    lata = item.lata,
                    latitude = !String.IsNullOrEmpty(item.latitude) ? Convert.ToDecimal(item.latitude) : null,
                    longitude = !String.IsNullOrEmpty(item.longitude) ? Convert.ToDecimal(item.longitude) : null,
                    phone_number = item.phone_number,
                    postal_code = item.postal_code,
                    rate_center = item.rate_center,
                    region = item.region
                });
            }

            return phoneNumbers;
        }

        public IList<AvailablePhoneNumber> AvailableTollFreePhoneNumbers(String contains = null)
        {
            parameters.Clear();
            if (!String.IsNullOrEmpty(contains)) {
                parameters.Add("Contains", contains);
            }

            twilioResponse = account.request(String.Format("Accounts/{0}/AvailablePhoneNumbers/{1}/TollFree.json", account.id, IsoCountryCode), "GET", parameters);
            dynamic data = ParseResponseData(twilioResponse);

            IList<AvailablePhoneNumber> phoneNumbers = new List<AvailablePhoneNumber>();

            foreach (dynamic item in data.available_phone_numbers) {
                phoneNumbers.Add(new AvailablePhoneNumber {
                    friendly_name = item.friendly_name,
                    iso_country = item.iso_country,
                    lata = item.lata,
                    latitude = !String.IsNullOrEmpty(item.latitude) ? Convert.ToDecimal(item.latitude) : null,
                    longitude = !String.IsNullOrEmpty(item.longitude) ? Convert.ToDecimal(item.longitude) : null,
                    phone_number = item.phone_number,
                    postal_code = item.postal_code,
                    rate_center = item.rate_center,
                    region = item.region
                });
            }

            return phoneNumbers;
        }

        public PhoneNumber ProvisionPhoneNumber(String phoneNumber = null, Int32? areaCode = null, PhoneNumber model = null, String voiceUrl = null, String voiceFallbackUrl = null, String smsUrl = null, String smsFallbackUrl = null)
        {
            if ((String.IsNullOrEmpty(phoneNumber) && !areaCode.HasValue) && model == null) {
                throw new ArgumentNullException("phone or area code");
            }

            parameters.Clear();
            if (model != null) {
                AddParametersFromPhoneNumberModel(model);
            } else if (!String.IsNullOrEmpty(phoneNumber)) {
                parameters.Add("PhoneNumber", phoneNumber);
            } else {
                parameters.Add("AreaCode", areaCode);
            }

            if (!String.IsNullOrEmpty(voiceUrl)) {
                parameters.Add("VoiceUrl", voiceUrl);
                parameters.Add("VoiceMethod", "GET");
            }
            if (!String.IsNullOrEmpty(voiceFallbackUrl)) {
                parameters.Add("VoiceFallbackUrl", voiceFallbackUrl);
            }
            if (!String.IsNullOrEmpty(smsUrl)) {
                parameters.Add("smsUrl", smsUrl);
                parameters.Add("smsMethod", "GET");
            }
            if (!String.IsNullOrEmpty(smsFallbackUrl)) {
                parameters.Add("smsFallbackUrl", smsFallbackUrl);
            }

            twilioResponse = account.request(String.Format("Accounts/{0}/IncomingPhoneNumbers.json", account.id), "POST", parameters);
            dynamic data = ParseResponseData(twilioResponse);

            var phone = new PhoneNumber
            {
                sid = data.sid,
                account_sid = data.account_sid,
                friendly_name = data.friendly_name,
                phone_number = data.phone_number,
                voice_url = data.voice_url,
                voice_method = data.voice_method,
                voice_fallback_url = data.voice_fallback_url,
                voice_fallback_method = data.voice_fallback_method,
                voice_caller_id_lookup = Convert.ToBoolean(data.voice_caller_id_lookup),
                date_created = Convert.ToDateTime(data.date_created),
                date_updated = Convert.ToDateTime(data.date_updated),
                sms_url = data.sms_url,
                sms_method = data.sms_method,
                sms_fallback_url = data.sms_fallback_url,
                sms_fallback_method = data.sms_fallback_method,
                capabilities = new Capabilities {
                    sms = Convert.ToBoolean(data.capabilities.sms),
                    voice = Convert.ToBoolean(data.capabilities.voice)
                },
                status_callback = data.status_callback,
                status_callback_method = data.status_callback_method,
                api_version = data.api_version,
                uri = data.uri
            };

            return phone;
        }

        public PhoneNumber ProvisionTollFreePhoneNumber(String phoneNumber, String voiceUrl = null, String voiceFallbackUrl = null)
        {
            if ((String.IsNullOrEmpty(phoneNumber)))
            {
                throw new ArgumentNullException("phone");
            }

            parameters.Clear();
            parameters.Add("PhoneNumber", phoneNumber);
            if (!String.IsNullOrEmpty(voiceUrl))
            {
                parameters.Add("VoiceUrl", voiceUrl);
                parameters.Add("VoiceMethod", "GET");
            }
            if (!String.IsNullOrEmpty(voiceFallbackUrl))
            {
                parameters.Add("VoiceFallbackUrl", voiceFallbackUrl);
            }

            twilioResponse = account.request(String.Format("Accounts/{0}/IncomingPhoneNumbers.json", account.id), "POST", parameters);
            dynamic data = ParseResponseData(twilioResponse);

            var phone = new PhoneNumber
            {
                sid = data.sid,
                account_sid = data.account_sid,
                friendly_name = data.friendly_name,
                phone_number = data.phone_number,
                voice_url = data.voice_url,
                voice_method = data.voice_method,
                voice_fallback_url = data.voice_fallback_url,
                voice_fallback_method = data.voice_fallback_method,
                voice_caller_id_lookup = data.voice_caller_id_lookup,
                date_created = !String.IsNullOrEmpty(data.date_created) ? Convert.ToDateTime(data.date_created) : null,
                date_updated = !String.IsNullOrEmpty(data.date_updated) ? Convert.ToDateTime(data.date_updated) : null,
                sms_url = data.sms_url,
                sms_method = data.sms_method,
                sms_fallback_url = data.sms_fallback_url,
                sms_fallback_method = data.sms_fallback_method,
                capabilities = new Capabilities
                {
                    sms = !String.IsNullOrEmpty(data.capabilities.sms) ? Convert.ToBoolean(data.capabilities.sms) : null,
                    voice = !String.IsNullOrEmpty(data.capabilities.voice) ? Convert.ToBoolean(data.capabilities.voice) : null
                },
                status_callback = data.status_callback,
                status_callback_method = data.status_callback_method,
                api_version = data.api_version,
                uri = data.uri
            };

            return phone;
        }

        public PhoneNumber UpdateProvisionedPhoneNumber(PhoneNumber model)
        {
            if (model == null || String.IsNullOrEmpty(model.sid))
            {
                throw new ArgumentNullException("missing phoneNumber");
            }

            parameters.Clear();
            AddParametersFromPhoneNumberModel(model);

            twilioResponse = account.request(String.Format("Accounts/{0}/IncomingPhoneNumbers/{1}.json", account.id, model.sid), "POST", parameters);
            dynamic data = ParseResponseData(twilioResponse);

            var phone = new PhoneNumber
            {
                sid = data.sid,
                account_sid = data.account_sid,
                friendly_name = data.friendly_name,
                phone_number = data.phone_number,
                voice_url = data.voice_url,
                voice_method = data.voice_method,
                voice_fallback_url = data.voice_fallback_url,
                voice_fallback_method = data.voice_fallback_method,
                voice_caller_id_lookup = data.voice_caller_id_lookup,
                date_created = data.date_created,
                date_updated = data.date_updated,
                sms_url = data.sms_url,
                sms_method = data.sms_method,
                sms_fallback_url = data.sms_fallback_url,
                sms_fallback_method = data.sms_fallback_method,
                capabilities = new Capabilities
                {
                    sms = data.capabilities.sms,
                    voice = data.capabilities.voice
                },
                status_callback = data.status_callback,
                status_callback_method = data.status_callback_method,
                api_version = data.api_version,
                uri = data.uri
            };

            return phone;
        }

        public void DeleteProvisionedPhoneNumber(PhoneNumber model)
        {
            if (model == null || String.IsNullOrEmpty(model.sid))
            {
                throw new ArgumentNullException("missing phoneNumber");
            }

            parameters.Clear();
            AddParametersFromPhoneNumberModel(model);

            account.request(String.Format("Accounts/{0}/IncomingPhoneNumbers/{1}.json", account.id, model.sid), "DELETE", parameters);
        }

        private void AddParametersFromPhoneNumberModel(PhoneNumber model)
        {
            if (String.IsNullOrEmpty(model.phone_number) && !model.areaCode.HasValue)
            {
                throw new ArgumentNullException("phone or area code");
            }
            if (!String.IsNullOrEmpty(model.phone_number))
            {
                parameters.Add("PhoneNumber", model.phone_number);
            }
            else
            {
                parameters.Add("AreaCode", model.areaCode);
            }
            if (!String.IsNullOrEmpty(model.friendly_name))
            {
                parameters.Add("FriendlyName", model.friendly_name);
            }
            if (model.voice_url != null)
            {
                parameters.Add("VoiceUrl", model.voice_url.ToString());
            }
            if (!String.IsNullOrEmpty(model.voice_method))
            {
                parameters.Add("VoiceMethod", model.voice_method);
            }
            if (model.voice_fallback_url != null)
            {
                parameters.Add("VoiceFallbackUrl", model.voice_fallback_url.ToString());
            }
            if (!String.IsNullOrEmpty(model.voice_fallback_method))
            {
                parameters.Add("VoiceFallbackMethod", model.voice_fallback_method);
            }
            if (!String.IsNullOrEmpty(model.status_callback))
            {
                parameters.Add("StatusCallback", model.status_callback);
            }
            if (!String.IsNullOrEmpty(model.status_callback_method))
            {
                parameters.Add("StatusCallbackMethod", model.status_callback_method);
            }
            if (model.sms_url != null)
            {
                parameters.Add("SmsUrl", model.sms_url.ToString());
            }
            if (!String.IsNullOrEmpty(model.sms_method))
            {
                parameters.Add("SmsMethod", model.sms_method);
            }
            if (model.sms_fallback_url != null)
            {
                parameters.Add("SmsFallbackUrl", model.sms_fallback_url.ToString());
            }
            if (!String.IsNullOrEmpty(model.sms_fallback_method))
            {
                parameters.Add("SmsFallbackMethod", model.sms_fallback_method);
            }
            if (!String.IsNullOrEmpty(model.voice_caller_id_lookup))
            {
                parameters.Add("VoiceCallerIdLookup", model.voice_caller_id_lookup);
            }
        }

        public IList<PhoneNumber> IncomingPhoneNumbers(String phoneNumber = "", String friendlyName = "")
        {
            if (String.IsNullOrEmpty(phoneNumber) && String.IsNullOrEmpty(friendlyName))
            {
                throw new ArgumentNullException("missing phoneNumber");
            }

            parameters.Clear();
            if (!String.IsNullOrEmpty(phoneNumber))
            {
                parameters.Add("PhoneNumber", phoneNumber);
            }
            if (!String.IsNullOrEmpty(friendlyName))
            {
                parameters.Add("FriendlyName", friendlyName);
            }

            twilioResponse = account.request(String.Format("Accounts/{0}/IncomingPhoneNumbers.json", account.id), "GET", parameters);
            dynamic data = ParseResponseData(twilioResponse);

            IList<PhoneNumber> incomingPhoneNumbers = new List<PhoneNumber>();

            foreach (dynamic item in data.incoming_phone_numbers)
            {
                incomingPhoneNumbers.Add(new PhoneNumber
                {
                    sid = item.sid,
                    account_sid = item.account_sid,
                    friendly_name = item.friendly_name,
                    phone_number = item.phone_number,
                    voice_url = item.voice_url,
                    voice_method = item.voice_method,
                    voice_fallback_url = item.voice_fallback_url,
                    voice_fallback_method = item.voice_fallback_method,
                    voice_caller_id_lookup = item.voice_caller_id_lookup,
                    date_created = !String.IsNullOrEmpty(item.date_created) ? Convert.ToDateTime(item.date_created) : null,
                    date_updated = !String.IsNullOrEmpty(item.date_updated) ? Convert.ToDateTime(item.date_updated) : null,
                    sms_url = item.sms_url,
                    sms_method = item.sms_method,
                    sms_fallback_url = item.sms_fallback_url,
                    sms_fallback_method = item.sms_fallback_method,
                    capabilities = new Capabilities
                    {
                        sms = item.capabilities.sms,
                        voice = item.capabilities.voice
                    },
                    status_callback = item.status_callback,
                    status_callback_method = item.status_callback_method,
                    api_version = item.api_version,
                    uri = item.uri
                });
            }

            return incomingPhoneNumbers;
        }

        public SMS SMSMessageList(String to = "", String from = "", DateTime? dateSent = null)
        {
            parameters.Clear();
            if (!String.IsNullOrEmpty(to))
            {
                parameters.Add("To", to);
            }
            if (!String.IsNullOrEmpty(from))
            {
                parameters.Add("From", from);
            }
            if (dateSent.HasValue)
            {
                parameters.Add("DateSent", dateSent.Value);
            }

            twilioResponse = account.request(String.Format("Accounts/{0}/sms/messages.json", account.id), "GET", parameters);
            dynamic data = ParseResponseData(twilioResponse);

            SMS smsMessages = new SMS();

            var sms = new SMS
            {
                start = data.start,
                total = data.total,
                num_pages = data.num_pages,
                page = data.page,
                page_size = data.page_size,
                end = data.end,
                uri = data.uri,
                first_page_uri = data.first_page_uri,
                last_page_uri = data.last_page_uri,
                next_page_uri = data.next_page_uri,
                previous_page_uri = data.previous_page_uri
            };

            IList<SMSMessage> messages = new List<SMSMessage>();

            foreach (dynamic item in data.sms_messages)
            {
                messages.Add(new SMSMessage {
                    account_sid = item.account_sid,
                    api_version = item.api_version,
                    body = item.body,
                    date_created = !String.IsNullOrEmpty(item.date_created) ? Convert.ToDateTime(item.date_created) : null,
                    date_sent = !String.IsNullOrEmpty(item.date_sent) ? Convert.ToDateTime(item.date_sent) : null,
                    date_updated = !String.IsNullOrEmpty(item.date_updated) ? Convert.ToDateTime(item.date_updated) : null,
                    direction = item.direction,
                    from = item.from,
                    price = !String.IsNullOrEmpty(item.price) ? Convert.ToDecimal(item.price) : null, 
                    sid = item.sid, 
                    status = item.status, 
                    to = item.to, 
                    uri = item.uri
                });
            }

            sms.sms_messages = messages;

            return sms;
        }

        public SMSMessage GetSMSMessage(String sid)
        {
            parameters.Clear();

            twilioResponse = account.request(String.Format("Accounts/{0}/sms/messages/{1}.json", account.id, sid), "GET", parameters);
            dynamic data = ParseResponseData(twilioResponse);

            SMSMessage smsMessages = new SMSMessage {
                account_sid = data.account_sid,
                api_version = data.api_version,
                body = data.body,
                date_created = !String.IsNullOrEmpty(data.date_created) ? Convert.ToDateTime(data.date_created) : null,
                date_sent = !String.IsNullOrEmpty(data.date_sent) ? Convert.ToDateTime(data.date_sent) : null,
                date_updated = !String.IsNullOrEmpty(data.date_updated) ? Convert.ToDateTime(data.date_updated) : null,
                direction = data.direction,
                from = data.from,
                price = !String.IsNullOrEmpty(data.price) ? Convert.ToDecimal(data.price) : null,
                sid = data.sid,
                status = data.status,
                to = data.to,
                uri = data.uri
            };

            return smsMessages;
        }

        public SMSMessage SendSMSMessage(String from, String to, String body, String statusCallback = "")
        {
            parameters.Clear();
            parameters.Add("From", from);
            parameters.Add("To", to);
            parameters.Add("Body", body);
            if (!String.IsNullOrEmpty(statusCallback))
            {
                parameters.Add("StatusCallback", statusCallback);
            }

            twilioResponse = account.request(String.Format("Accounts/{0}/sms/messages.json", account.id), "POST", parameters);
            dynamic data = ParseResponseData(twilioResponse);

            var sms = new SMSMessage
            {
                account_sid = data.account_sid,
                api_version = data.api_version,
                body = data.body,
                date_created = !String.IsNullOrEmpty(data.date_created) ? Convert.ToDateTime(data.date_created) : null,
                date_sent = !String.IsNullOrEmpty(data.date_sent) ? Convert.ToDateTime(data.date_sent) : null,
                date_updated = !String.IsNullOrEmpty(data.date_updated) ? Convert.ToDateTime(data.date_updated) : null,
                direction = data.direction,
                from = data.from,
                price = !String.IsNullOrEmpty(data.price) ? Convert.ToDecimal(data.price) : null,
                sid = data.sid,
                status = data.status,
                to = data.to,
                uri = data.uri
            };

            return sms;
        }
    }
}
