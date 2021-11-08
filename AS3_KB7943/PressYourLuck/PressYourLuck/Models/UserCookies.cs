using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PressYourLuck.Models
{
    public class UserCookies
    {
        private IRequestCookieCollection requestCookies { get; set; }
        private IResponseCookies responseCookies { get; set; }

        CookieOptions options = new CookieOptions
        {
            Expires = DateTime.Now.AddDays(30)
        };

        public UserCookies(IRequestCookieCollection requestCookies)
        {
            this.requestCookies = requestCookies;
        }

        public UserCookies(IResponseCookies responseCookies)
        {
            this.responseCookies = responseCookies;
        }

        public void SetUser(string name)
        {
            responseCookies.Append("name", name, options);
        }

        public string GetUser()
        {
            return requestCookies["name"];
        }

        public void SetCoin(string coin)
        {
            responseCookies.Append("coins", coin, options);
        }

        public string GetCoin(string coin)
        {
            return requestCookies["coins"];
        }
    }
}
