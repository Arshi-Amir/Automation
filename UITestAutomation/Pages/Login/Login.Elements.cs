﻿using OpenQA.Selenium;

namespace UITestAutomation
{
    internal partial class Login
    {
        By Email = By.XPath("//input[@type='email']");
        By Password = By.CssSelector("input[type=password]");
        By Click_btn = By.Id("login");
    }
}
