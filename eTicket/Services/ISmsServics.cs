using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twilio.Rest.Api.V2010.Account;

namespace Sendsms.Service
{
    public interface ISmsService
    {
        MessageResource Send(string mobileNumber, string body);
    }
}