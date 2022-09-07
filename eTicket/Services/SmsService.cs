using Microsoft.Extensions.Options;
using Sendsms.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace Sendsms.Service
{
    public class SmsService : ISmsService
    {
        private readonly TwilioSetting _twilio;

        public SmsService(IOptions<TwilioSetting> twilio)
        {
            _twilio = twilio.Value;
        }

        public MessageResource Send(string MobileNumber, string body)
        {
            TwilioClient.Init("AC6838fca627b55ea3003c54f0409cd857", "7861ed59a6b26bdf13ea8adfecbedbc5");

            var result = MessageResource.Create(
                    body: body,
                    from: new Twilio.Types.PhoneNumber("+17432007180"),
                    to: MobileNumber
                );

            return result;
        }

        internal static void Send(string v1, PhoneNumber phoneNumber, string v2, object userName)
        {
            throw new NotImplementedException();
        }
    }
}