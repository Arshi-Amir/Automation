﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumA.Pages
{
  class LoginP
    {
        public LoginP(IWebDriver driver)
        {
            Driver = driver;
        }
        public IWebDriver Driver { get; }

        IWebElement txtUserName => Driver.FindElement(By.Name("UserName"));

        IWebElement txtPassword => Driver.FindElement(By.Name("Password"));

        IWebElement btnLogin => Driver.FindElement(By.XPath("//input[@value= 'Log in']"));

        public void Login(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
            btnLogin.SendKeys(userName);

        }
    }
}
