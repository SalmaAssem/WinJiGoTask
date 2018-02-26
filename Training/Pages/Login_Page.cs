using System;
using Automation.Utilities;

namespace Training
{
    public class Login_Page : Helpers
    {
        public Login_Page(Driver driver, TestMessages testmesssages)  : base(driver,  testmesssages)
        {

        }

        #region Page Objects

        AutomatedElement txt_Email = new AutomatedElement(LocateBy.Id, LocatorValue: "Email");

        AutomatedElement txt_Password = new AutomatedElement(LocateBy.Id, LocatorValue: "Password");

        AutomatedElement btn_Login = new AutomatedElement(LocateBy.Id, LocatorValue: "btnLogin");

        #endregion

        public void Local_Login(string Email, string Password)
        {
            //Enter User Name
            Clear_And_SendKeys(20, txt_Email, Email, "Email text box", ElementValidation.Mandatory, false);

            //Enter Password
            Clear_And_SendKeys(20, txt_Password, Password, "Password text box", ElementValidation.Mandatory, false);

            //Click Submit button
            Locate_And_Click(20, btn_Login, "Login Button", ElementValidation.Mandatory, false);

        }
    }
}
