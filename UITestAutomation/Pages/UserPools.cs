﻿using OpenQA.Selenium;

namespace UITestAutomation.Pages
{
    public class UserPools : Selenium_Methods
    {
        //pool page
        By AddPool_Button = By.XPath("//button[@ng-click=\"addPool()\"]");
        By EditPool_Button = By.XPath("//button[@ng-click=\"editPool(p)\"]");
        By DeletePool_Button = By.CssSelector("tr:nth-of-type(1)  button[title='Delete Pool']");
        By Refresh_Button = By.XPath("//button[@ng-click=\"refreshPools()\"]");
        By ReferenceSearch_TextBox = By.XPath("//input[@placeholder=\"Reference Search\"]");
        By Action_Field = By.XPath("//div[@class='panel panel-primary']/table//th[.='Action']");
        By ID_Field = By.XPath("//div[@class='panel panel-primary']/table//th[.='ID']");
        By GroupName_Field = By.XPath("//div[@class='panel panel-primary']/table//th[.='Group Name']");
        By Rerefernce_Field = By.XPath("//div[@class='panel panel-primary']/table//th[.='Reference']");
        By User_Field = By.XPath("//div[@class='panel panel-primary']/table//th[.='Users']");
        By show_Button = By.XPath("//button[@ng-click=\"showUsersOfPool(p)\"]");
        By UserPools_Dropdown = By.XPath("//a[@href='#/userpools']");

        //addpage
        By PoolName_Field = By.CssSelector("input[name='groupName']");
        By PoolReference_Field = By.XPath("//form[@name='configform']/div[@class='modal-body']/div[2]/input[@type='text']");
        By PoolUserEmaillist_Field = By.CssSelector(".select2-selection__rendered");
        By Save_Button = By.CssSelector(".btn.btn-info > .ng-binding");
        By Close_Button = By.CssSelector("form[name='configform']  .btn.btn-default");

        ////edit
        //By Update_Button = By.XPath("//button[@ng-click=\"savePool()\"]");
        ////delete
        //By No_Button = By.XPath("//button[@ng-click=\"dialog.abort()\"]");
        //By Yes_Button = By.XPath("//button[@ng-click=\"dialog.hide()\"]");

        public void ClickUserPools()
        {
            ClickTheWebElement(UserPools_Dropdown);
            WaitForWebElementDisplayed(EditPool_Button);
        }
        public void AssertUIControlsonUserPoolsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Add":
                        FluentWaitForWebElement(AddPool_Button);
                        break;
                    case "Refresh":
                        FluentWaitForWebElement(Refresh_Button);
                        break;
                    case "Reference Search":
                        FluentWaitForWebElement(ReferenceSearch_TextBox);
                        break;
                    case "Edit":
                        FluentWaitForWebElement(EditPool_Button);
                        break;
                    case "Delete":
                        FluentWaitForWebElement(DeletePool_Button);
                        break;
                    case "Action":
                        FluentWaitForWebElement(Action_Field);
                        break;
                    case "ID":
                        FluentWaitForWebElement(ID_Field);
                        break;
                    case "Group Name":
                        FluentWaitForWebElement(GroupName_Field);
                        break;
                    case "Reference":
                        FluentWaitForWebElement(Rerefernce_Field);
                        break;
                    case "Users":
                        FluentWaitForWebElement(User_Field);
                        break;
                    case "Show":
                        FluentWaitForWebElement(show_Button);
                        break;
                }
            }
        }
        public void ClickAddPoolButton()
        {
            ClickOnWebElement(AddPool_Button);
            WaitForWebElementDisplayed(PoolName_Field);
        }
        public void AssertFieldsOnAddPoolDialog(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Pool Name":
                        FluentWaitForWebElement(PoolName_Field);
                        break;
                    case "Pool Reference":
                        FluentWaitForWebElement(PoolReference_Field);
                        break;
                    case "Pool Users Email List":
                        FluentWaitForWebElement(PoolUserEmaillist_Field);
                        break;
                    case "Close":
                        FluentWaitForWebElement(Close_Button);
                        break;
                    case "Save":
                        FluentWaitForWebElement(Save_Button);
                        break;
                }
            }
        }
    }
}
