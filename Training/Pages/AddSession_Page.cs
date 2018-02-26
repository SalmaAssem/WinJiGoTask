using System;
using NUnit.Framework;
using Automation.Utilities;

namespace Training
{
    public class AddSession_Page : Helpers
    {
        public AddSession_Page(Driver driver, TestMessages testmesssages)  : base(driver,  testmesssages)
        {

        }
        
        #region Page Objects

        AutomatedElement txt_SessionTitle = new AutomatedElement(LocateBy.Id, LocatorValue: "txtSessionTitle");

        AutomatedElement txt_Objectives = new AutomatedElement(LocateBy.XPath, LocatorValue: "/html/body");

        AutomatedElement iframe_ObjectivesFrame = new AutomatedElement(LocateBy.XPath, LocatorValue: "//*[@title='Rich Text Editor, txtSessionObjectives']");

        AutomatedElement input_SessionDate = new AutomatedElement(LocateBy.Id, LocatorValue: "inputSessionDateAdd");

        AutomatedElement input_SessionTime = new AutomatedElement(LocateBy.Id, LocatorValue: "inputSessionTimeAdd");

        AutomatedElement input_SessionDuration = new AutomatedElement(LocateBy.Id, LocatorValue: "txtSessionDuration");

        AutomatedElement btn_SaveSession = new AutomatedElement(LocateBy.Id, LocatorValue: "btnSaveSession");

        
        #endregion

        public void Enter_Session_Title(string Title)
        {
            Clear_And_SendKeys(20, txt_SessionTitle, Title, "Session Title text area", ElementValidation.Mandatory, false);
        }

        public void Enter_Session_Objectives(string Objectives)
        {
            //switch to objectives frame
            ExplicitlyConfirm_ElementFound(30, iframe_ObjectivesFrame, "Session Objectives frame", ElementValidation.Mandatory);

           SwitchToFrame(iframe_ObjectivesFrame, ElementValidation.Mandatory);

            //Enter Objectives
            Clear_And_SendKeys(20, txt_Objectives, Objectives, "session Objectives text area", ElementValidation.Mandatory, false);

            GetOutofFrame();
        }

        public void Enter_Session_Date(string Date)
        {
            Clear_And_SendKeys(20, input_SessionDate, Date, "session Date text area", ElementValidation.Mandatory, false);
        }
        
        public void Enter_Session_Time(string Time)
        {
            Clear_And_SendKeys(20, input_SessionTime, Time, "session Time text area", ElementValidation.Mandatory, false);
        }

        public void Enter_Session_Duration(string Duration)
        {
            Clear_And_SendKeys(20, input_SessionDuration, Duration, "session Duration text area", ElementValidation.Mandatory, false);
        }
        
        public void Click_Save_Session()
        {
            Locate_And_Click(20, btn_SaveSession, "Save session button", ElementValidation.Mandatory, false);
        }


    }
}
