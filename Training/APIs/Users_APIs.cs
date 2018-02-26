using NUnit.Framework;
using OpenQA.Selenium;

using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Automation.Utilities;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;
using XWinji.Models;

namespace Training
{
    public class Users_APIs
    {
        public static async Task<XWinji.Models.LMSApplicationCoreViewModelUserViewModel> Get_UserInfo(List<System.Net.Cookie> cookies)
        {
            var baseAddress = new Uri(URLs.URL);
            var cookieContainer = new CookieContainer();
            cookies.ForEach(cookieContainer.Add);
            var handler = new HttpClientHandler() { CookieContainer = cookieContainer };
            using (XWinji.LMSWebCore client = new XWinji.LMSWebCore(baseAddress, handler))
            {
                var data = new XWinji.Models.LMSApplicationCoreViewModelUserBasicInfoViewModel
                {

                };

                var customHeaders = new Dictionary<string, List<string>>();
                customHeaders.Add("X-Requested-With", new List<string>() { "XMLHttpRequest" }); customHeaders.Add("x-language-header", new List<string>() { "" });
                var response = await client.UserApi.GetCurrentUserInfoWithHttpMessagesAsync(customHeaders);

                return response.Body;

            }

        }
    }
}
