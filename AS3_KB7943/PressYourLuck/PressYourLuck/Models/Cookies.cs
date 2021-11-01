using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PressYourLuck.Models
{
    public class Cookies
    {
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
    }
}
