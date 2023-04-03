﻿
namespace UITestAutomation.Pages.Users
{
    internal partial class Users :Selenium_Methods
    {
        public void ClickUsers()
        {
            ClickTheWebElement(Users_Dropdown);
            WaitForWebElementDisplayed(AddUser_Button);
        }

        public void ClickAddUsers()
        {
            ClickTheWebElement(AddUser_Button);
            WaitForWebElementDisplayed(Name_Textbox);
        }

        public void ClickCloseButtononAddUsers()
        {
            ClickTheWebElement(CloseAddUser_Button);
            WaitForWebElementDisplayed(Role_Field);
        }




    }
}
