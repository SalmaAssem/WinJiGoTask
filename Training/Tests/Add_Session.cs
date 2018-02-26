using System;
using NUnit.Framework;
using System.Threading.Tasks;
using System.Threading;

namespace Training
{
    [TestFixture]
    public partial class Sessions_Tests
    {
        [Test]
        public async Task Add_Session()
        {
            #region Preconditions

            //Add Course Online Collaboration
            string CourseNameToAddSessionTo = RandomString.GenerateRandomString(7);
            var courseToAddSession = await Courses_APIs.Add_Course_StaticGrade_Subject(TeacherDriver_cookies, CourseNameToAddSessionTo, CourseJoiningTypes.Request_to_join, true, CourseTypes.Online_Collaboration, true);

            //Publish it
            var publishCourse = await Courses_APIs.Publish_Round(TeacherDriver_cookies, courseToAddSession.Id);

            //Join it as student
            var joinCourse = await Courses_APIs.Join_Course(StudentDriver_cookies, courseToAddSession.AccessCode, false);

            #endregion

            //Access Course as a teacher with Plan Tab
            Teacher_ViewSession_Page.Access_Course_With_PlanTab(courseToAddSession.ParentId, courseToAddSession.Id);

            //Click Add Session
            Teacher_ViewSession_Page.Click_Add_Session();

            //Enter Session details
            string sessionTitle = RandomString.GenerateRandomString(7);
            Teacher_AddSession_Page.Enter_Session_Title(sessionTitle);

            //Enter Session Objectives
            string sessionObjectives = RandomString.GenerateRandomString(7);
            Teacher_AddSession_Page.Enter_Session_Objectives(sessionObjectives);

            //Enter Session Date
            string SessionDate = DateTime.Now.ToString("MMM dd, yyyy");
            Teacher_AddSession_Page.Enter_Session_Date(SessionDate);

            //Enter Session Time
            Teacher_AddSession_Page.Enter_Session_Time("09:00 AM");

            //Enter Session Duration
            Teacher_AddSession_Page.Enter_Session_Duration("50");

            //Click Save
            Teacher_AddSession_Page.Click_Save_Session();

            Thread.Sleep(2000);

            //Assert Session Title is correct
            Teacher_ViewSession_Page.Ensure_Session_IsDisplayed_CourseMap(sessionTitle, Automation.Utilities.ElementValidation.Non_Mandatory_Till_EOT);

            //Assert Session Title is correct
            Teacher_ViewSession_Page.Ensure_Session_Title_SessionView_IsCorrect(sessionTitle, Automation.Utilities.ElementValidation.Non_Mandatory_Till_EOT);

            //Assert Session Objectives is correct
            Teacher_ViewSession_Page.Ensure_Session_Objectives_SessionView_IsCorrect(sessionObjectives, Automation.Utilities.ElementValidation.Non_Mandatory_Till_EOT);

            //Assert Session Date is correct
            Teacher_ViewSession_Page.Ensure_Session_Date_SessionView_IsCorrect(SessionDate, Automation.Utilities.ElementValidation.Non_Mandatory_Till_EOT);

            //Assert Session Time is correct
            Teacher_ViewSession_Page.Ensure_Session_Time_SessionView_IsCorrect("09:00 AM", Automation.Utilities.ElementValidation.Non_Mandatory_Till_EOT);

            //Assert Session Duration is correct
            Teacher_ViewSession_Page.Ensure_Session_Duration_SessionView_IsCorrect("50", Automation.Utilities.ElementValidation.Non_Mandatory_Till_EOT);

            //As a student, access the course
            Student_ViewSession_Page.Access_Course_With_PlanTab(courseToAddSession.ParentId, courseToAddSession.Id);

            //Ensure the sessions isnt displayed for him
            Student_ViewSession_Page.Ensure_Session_IsNotDisplayed_CourseMap(sessionTitle, Automation.Utilities.ElementValidation.Non_Mandatory_Till_EOT);

            #region Delete Course
            //Remove Learner from the course
            await Courses_APIs.Delete_CourseMember(TeacherDriver_cookies, courseToAddSession.Id, studentId);

            //Delete the added course
            await Courses_APIs.Delete_CourseGroup(TeacherDriver_cookies, courseToAddSession.ParentId);

            #endregion
            
        }
    }
}
