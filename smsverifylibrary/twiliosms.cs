using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using dotenv;
using System.Threading.Tasks;

namespace smsverifylibrary
{

     interface ISmSVerify
        {
            string NumberToText(string PhoneNumber);
        }

    //Add :ISmSVerify eventually
    
}
