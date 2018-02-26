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
    public class Sessions_APIs
    {
        public static async Task<XWinji.Models.LMSApplicationCoreViewModelSessionViewModel> Add_Session(List<System.Net.Cookie> cookies, string _Title, string _Objectives, string _Duration, int? _RoundID, string _Date)
        {
            var baseAddress = new Uri(URLs.URL);
            var cookieContainer = new CookieContainer();
            cookies.ForEach(cookieContainer.Add);
            var handler = new HttpClientHandler() { CookieContainer = cookieContainer };
            using (XWinji.LMSWebCore client = new XWinji.LMSWebCore(baseAddress, handler))
            {
                var data = new XWinji.Models.LMSApplicationCoreCommandsSessionAddCommand
                {
                    Title = _Title,
                    Objective = _Objectives,
                    Duration = int.Parse(_Duration),
                    CourseId = _RoundID,
                    Date = DateTime.Parse(_Date),
                    VoiceNotefileId = null

                };

                var customHeaders = new Dictionary<string, List<string>>();
                customHeaders.Add("X-Requested-With", new List<string>() { "XMLHttpRequest" }); customHeaders.Add("x-language-header", new List<string>() { "" });
                var response = await client.CourseApi.AddSessionWithHttpMessagesAsync(data, "en", customHeaders);

                return response.Body;

            }
        }

        public static async Task<XWinji.Models.LMSDomainCoreModelsSession> Activate_Session(List<System.Net.Cookie> cookies, string SessionId, string _Duration, string _Date)
        {
            var baseAddress = new Uri(URLs.URL);
            var cookieContainer = new CookieContainer();
            cookies.ForEach(cookieContainer.Add);
            var handler = new HttpClientHandler() { CookieContainer = cookieContainer };
            using (XWinji.LMSWebCore client = new XWinji.LMSWebCore(baseAddress, handler))
            {
                var data = new XWinji.Models.LMSApplicationCoreCommandsActivateSessionCommand
                {
                    Id = SessionId.ToString(),
                    Date = DateTime.Parse(_Date),
                    Duration = int.Parse(_Duration)
                };

                var customHeaders = new Dictionary<string, List<string>>();
                customHeaders.Add("X-Requested-With", new List<string>() { "XMLHttpRequest" }); customHeaders.Add("x-language-header", new List<string>() { "" });
                var response = await client.SessionApi.ActivateSessionWithHttpMessagesAsync(data, "en", customHeaders);

                return response.Body;
            }
        }
    }
}
