using System;
using NUnit.Framework;
using Automation.Utilities;

namespace Training
{
    public class ViewSession_Page : Helpers
    {
        public ViewSession_Page(Driver driver, TestMessages testmesssages)  : base(driver,  testmesssages)
        {

        }


        #region Page Objects

        AutomatedElement btn_AddSession = new AutomatedElement(LocateBy.Id, LocatorValue: "btnAddNewSession");

        AutomatedElement lbl_SessionTitle = new AutomatedElement(LocateBy.Id, LocatorValue: "txtSessionTitleView");

        AutomatedElement lbl_sessionObjectives = new AutomatedElement(LocateBy.Id, LocatorValue: "txtsessionobjectivesview");

        AutomatedElement lbl_sessionTime = new AutomatedElement(LocateBy.Id, LocatorValue: "txtSessionTimeView");

        AutomatedElement lbl_sessionDuration = new AutomatedElement(LocateBy.Id, LocatorValue: "txtSessionDurationView");

        AutomatedElement lbl_sessionDatte = new AutomatedElement(LocateBy.Id, LocatorValue: "txtSessionDateView");

        #endregion

        public void Access_Course_With_PlanTab(int? CourseId, int? RoundId)
        {
            NavigateToURL("https://xwinji.azurewebsites.net/en/default/Course#/view/" + CourseId + "/false/" + RoundId + "/CourseMap");
        }

        public void Click_Add_Session()
        {
            Locate_And_Click(20, btn_AddSession, "Add session button", ElementValidation.Mandatory, false);
        }

        public void Ensure_Session_IsNotDisplayed_CourseMap(string SessionTitle, ElementValidation validation)
        {
            AutomatedElement lbl_SessionInMap = new AutomatedElement(LocateBy.XPath, LocatorValue: "//*[@title='" + SessionTitle + "']");

            ExplicitlyConfirm_ElementNotFound(2, lbl_SessionInMap, "Session with Title " + SessionTitle, validation, validation);
        }

        public void Ensure_Session_IsDisplayed_CourseMap(string SessionTitle, ElementValidation validation)
        {
            AutomatedElement lbl_SessionInMap = new AutomatedElement(LocateBy.XPath, LocatorValue: "//*[@title='" + SessionTitle + "']");

            ExplicitlyConfirm_ElementFound(20, lbl_SessionInMap, "Session with Title " + SessionTitle, validation);
        }


        public void Ensure_Session_Title_SessionView_IsCorrect(string SessionTitle, ElementValidation validation)
        {
            Ensure_ElementTxt_IsCorrect(lbl_SessionTitle, SessionTitle, "Session Title", validation);
        }

        public void Ensure_Session_Objectives_SessionView_IsCorrect(string SessionObjectives, ElementValidation validation)
        {
            Ensure_ElementTxt_IsCorrect(lbl_sessionObjectives, SessionObjectives, "Session Objectives", validation);
        }

        public void Ensure_Session_Duration_SessionView_IsCorrect(string SessionDuration, ElementValidation validation)
        {
            Ensure_Element_Contains_Text(lbl_sessionDuration, SessionDuration, "Session Duration", validation);
        }

        public void Ensure_Session_Date_SessionView_IsCorrect(string SessionDate, ElementValidation validation)
        {

            Ensure_Element_Contains_Text(lbl_sessionDatte, SessionDate, "Session Date", validation);
        }

        public void Ensure_Session_Time_SessionView_IsCorrect(string SessionTime, ElementValidation validation)
        {
            Ensure_Element_Contains_Text(lbl_sessionTime, SessionTime, "Session Time", validation);
        }
    }
}
