﻿using OpenQA.Selenium;
namespace UITestAutomation
{
    internal partial class BankHolidays
    {
        //UI Controls on Bank Holidays Page
        By AddNewBankHolidays = By.CssSelector("button[title='Add Holiday']");
        By DeleteBankHolidays = By.CssSelector("tr:nth-of-type(1)  button[title='Delete Holiday']");
        By EditBankHolidays = By.CssSelector("tr:nth-of-type(1)  button[title='Edit Holiday']");
        By Action= By.CssSelector("tr > th:nth-of-type(1)");   
        By RefreshIcon = By.CssSelector("button[title='Refresh']");

        //Add Brand Page (Field)
        By AddHoliday = By.XPath("/html//div[@id='addHoliday']//md-datepicker[@type='date']/div/button[@type='button']");
        By SaveButton = By.ClassName("btn btn-info");
        By CloseButton = By.ClassName("btn btn-default");
    }

}
