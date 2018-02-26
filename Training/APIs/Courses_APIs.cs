
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
    public class Courses_APIs
    {

        public static async Task<XWinji.Models.LMSDomainCoreModelsCourse> Add_Course_StaticGrade_Subject(List<System.Net.Cookie> cookies, string _CourseName, int _JoiningType, bool _IsAutoAccept, int _CourseType,
                           bool _LearningPathEnabled)
        {

            //Retreive available Grades
            var availableGrades = await Grades_APIs.Get_Grades(cookies);

            //Retreive available subjects
            var availableSubjects = await Subjects_APIs.Get_Subjects(cookies);

            var baseAddress = new Uri(URLs.URL);
            var cookieContainer = new CookieContainer();
            cookies.ForEach(cookieContainer.Add);
            var handler = new HttpClientHandler() { CookieContainer = cookieContainer };
            using (XWinji.LMSWebCore client = new XWinji.LMSWebCore(baseAddress, handler))
            {
                var data = new XWinji.Models.LMSApplicationCoreCommandsAddCourseGroupCommand
                {
                    Name = _CourseName,
                    GroupAlias = "regyhg",
                    CourseImageId = "1",
                    GradeId = int.Parse(availableGrades[1].Id.ToString()),
                    MinGrade = 0,
                    MaxGrade = 0,
                    SubjectId = availableSubjects[3].Id.ToString(),
                    Description = "string",

                    JoiningType = _JoiningType,
                    IsAutoAccept = _IsAutoAccept,
                    Type = _CourseType,
                    IsLearningPathsEnabled = _LearningPathEnabled,
                    LearningPathTheme = "",
                    IsShowLearnersProgress = false,
                    OnBehalfTeacherId = 0,
                    Status = 0,
                    IsCourseGamificationEnabled = true,
                    MaxCapacity = 5,
                    Location = "Location",
                    IsVideoBased = false,
                    CompletionCriteria = 1,
                    IsCertificateEnabled = true

                };

                var customHeaders = new Dictionary<string, List<string>>();
                customHeaders.Add("X-Requested-With", new List<string>() { "XMLHttpRequest" }); customHeaders.Add("x-language-header", new List<string>() { "" });
                var response = await client.CourseApi.AddCourseGroupWithHttpMessagesAsync(data, "en", customHeaders);

                return response.Body;
            }
        }


        public static async Task<string> Publish_Round(List<System.Net.Cookie> cookies, int? Id)
        {
            var baseAddress = new Uri(URLs.URL);
            var cookieContainer = new CookieContainer();
            using (var handler = new HttpClientHandler() { CookieContainer = cookieContainer })
            using (var client = new HttpClient(handler) { BaseAddress = baseAddress })
            {
                client.DefaultRequestHeaders.Add("X-Requested-With", "XMLHttpRequest"); client.DefaultRequestHeaders.Add("x-language-header", new List<string>() { "" });

                var content = new StringContent("{courseId:" + Id.ToString() + "}", Encoding.UTF8, "application/json");

                cookies.ForEach(handler.CookieContainer.Add);

                var result = client.PostAsync("/en/api/courseapi/PublishCourse", content).Result;
                result.EnsureSuccessStatusCode();
                var response = await result.Content.ReadAsStringAsync();
                return response;
            }
        }

        public static async Task<XWinji.Models.LMSApplicationCoreViewModelJoinCourseViewModel> Join_Course(List<System.Net.Cookie> cookies, string _AccessCode, bool _IsInvited)
        {
            var baseAddress = new Uri(URLs.URL);
            var cookieContainer = new CookieContainer();
            cookies.ForEach(cookieContainer.Add);
            var handler = new HttpClientHandler() { CookieContainer = cookieContainer };
            using (XWinji.LMSWebCore client = new XWinji.LMSWebCore(baseAddress, handler))
            {
                var data = new XWinji.Models.LMSApplicationCoreCommandsJoinCourseCommand
                {
                    AccessCode = _AccessCode,
                    IsInvited = _IsInvited
                };

                var customHeaders = new Dictionary<string, List<string>>();
                customHeaders.Add("X-Requested-With", new List<string>() { "XMLHttpRequest" }); customHeaders.Add("x-language-header", new List<string>() { "" });
                var response = await client.CourseApi.JoinCourseWithHttpMessagesAsync(data, "en", customHeaders);

                return response.Body;

            }
        }

        public static async Task Delete_CourseMember(List<System.Net.Cookie> cookies, int? courseId, int? StudentId)
        {
            var baseAddress = new Uri(URLs.URL);
            var cookieContainer = new CookieContainer();
            cookies.ForEach(cookieContainer.Add);
            var handler = new HttpClientHandler() { CookieContainer = cookieContainer };
            using (XWinji.LMSWebCore client = new XWinji.LMSWebCore(baseAddress, handler))
            {
                var customHeaders = new Dictionary<string, List<string>>();
                customHeaders.Add("X-Requested-With", new List<string>() { "XMLHttpRequest" }); customHeaders.Add("x-language-header", new List<string>() { "" });
                var response = await client.CourseApi.RemoveMemberFromCourseByIdWithHttpMessagesAsync(int.Parse(StudentId.ToString()), int.Parse(courseId.ToString()), "en", null, customHeaders);

            }
        }

        public static async Task Delete_CourseGroup(List<System.Net.Cookie> cookies, int? CourseGroupId)
        {
            var baseAddress = new Uri(URLs.URL);
            var cookieContainer = new CookieContainer();
            cookies.ForEach(cookieContainer.Add);
            var handler = new HttpClientHandler() { CookieContainer = cookieContainer };
            using (XWinji.LMSWebCore client = new XWinji.LMSWebCore(baseAddress, handler))
            {
                var data = new XWinji.Models.LMSApplicationCoreCommandsDeleteCourseGroupCommand
                {
                    CourseGroupId = CourseGroupId
                };

                var customHeaders = new Dictionary<string, List<string>>();
                customHeaders.Add("X-Requested-With", new List<string>() { "XMLHttpRequest" }); customHeaders.Add("x-language-header", new List<string>() { "" });
                var response = await client.CourseApi.DeleteCourseGroupWithHttpMessagesAsync(data, "en", customHeaders);

            }
        }
    }
}
