using System;
using Automation.Utilities;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Training
{
   
        [TestFixture]
        public partial class Sessions_Tests
        {
            #region Declare Drivers

            //Declare Teacher Driver
            private Driver Teacher_driver = new Driver(false, Browser.Chrome, AppDomain.CurrentDomain.BaseDirectory.ToString());

            //Declare Student Driver
            private Driver Student_driver = new Driver(false, Browser.Chrome, AppDomain.CurrentDomain.BaseDirectory.ToString());
        

            #endregion

            #region Declare TestMessages
            private TestMessages Test_Messages = new TestMessages();
            #endregion

            #region Declare Methods Classes

            //Declare instances of needed methods classes
            private Login_Page Teacher_Login_Page;
            private Login_Page Student_Login_Page;

            private ViewSession_Page Teacher_ViewSession_Page;
            private ViewSession_Page Student_ViewSession_Page;

            private AddSession_Page Teacher_AddSession_Page;
            #endregion

            #region Cookies
            private List<System.Net.Cookie> TeacherDriver_cookies;

            private List<System.Net.Cookie> StudentDriver_cookies;

            int? studentId;

            #endregion
        
            #region Fixture SetUp
            [OneTimeSetUp]
            public async Task StartUp()
            {
                //Setup the driver
                Teacher_driver.FreshSetup(URLs.URL + "en/default/Account/Login");
                Student_driver.FreshSetup(URLs.URL + "en/default/Account/Login");

                //Initiate the Login Methods
                Teacher_Login_Page = new Login_Page(Teacher_driver, Test_Messages);
                Student_Login_Page = new Login_Page(Student_driver, Test_Messages);

                Teacher_AddSession_Page = new AddSession_Page(Teacher_driver, Test_Messages);

                Teacher_ViewSession_Page = new ViewSession_Page(Teacher_driver, Test_Messages);
                Student_ViewSession_Page = new ViewSession_Page(Student_driver, Test_Messages);

                //Login as Teacher
                Teacher_Login_Page.Local_Login("local.teachercorp@outlook.com", "Windows.2000");

                //Login as Student
                Student_Login_Page.Local_Login("local.studentcorp@outlook.com", "Windows.2000");

                //Retreive Session Cookies
                TeacherDriver_cookies = Teacher_driver.Retreive_SessionCookies();
                StudentDriver_cookies = Student_driver.Retreive_SessionCookies();

            #region Get Users Ids
                //Get Student id
                var getStudentinfoResponse = await Users_APIs.Get_UserInfo(StudentDriver_cookies);
                studentId = getStudentinfoResponse.BasicProfileInfo.Id;
            #endregion

        }
        #endregion

             #region Test SetUp
        [SetUp]
            public void Test_SetUp()
            {

            }
            #endregion

            #region Test TearDown
            [TearDown]
            public void TearDownTest()
            {
                Test_Messages.Clear_Messages();
            }
            #endregion

            #region Fixture TearDown

            //Tear Down the startup
            [OneTimeTearDown]
            public void TearDownFixture()
            {
                Teacher_driver.TeardownDriver();
                Student_driver.TeardownDriver();
            }
            #endregion
        }
    }
