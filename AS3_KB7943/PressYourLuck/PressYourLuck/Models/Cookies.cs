using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PressYourLuck.Models
{
    public class Cookies
    {
        private const string USER_KEY = "user";

        private IRequestCookieCollection requestCookies { get; set; }
        private IResponseCookies responseCookies { get; set; }

        public Cookies(IResponseCookies responseCookies)
        {
            this.responseCookies = responseCookies;
        }
        
        public Cookies(IRequestCookieCollection requestCookies)
        {
            this.requestCookies = requestCookies;
        }

        public void SetMyTeamIds(string name)
        {
            string userName = name;
            CookieOptions options = new CookieOptions { Expires = DateTime.Now.AddDays(30) };
            RemovePreviousUser();     // delete old cookie first
            responseCookies.Append(USER_KEY, userName, options);
        }

        private void RemovePreviousUser()
        {
            responseCookies.Delete(USER_KEY);
        }
    }
}
