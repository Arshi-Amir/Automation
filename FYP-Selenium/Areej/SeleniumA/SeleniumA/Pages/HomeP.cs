﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumA.Pages
{
    public class HomeP
    {
        public HomeP(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        private IWebDriver Driver { get; }

        public IWebElement lnkLogin => Driver.FindElement(By.LinkText("Login"));
        IWebElement lnkEmployeeDetails => Driver.FindElement(By.LinkText("Employee Details"));

        public void ClickLogin() => lnkLogin.Click();
        public bool IsEmployeeDetailsExist() => lnkEmployeeDetails.Displayed;
    }
}