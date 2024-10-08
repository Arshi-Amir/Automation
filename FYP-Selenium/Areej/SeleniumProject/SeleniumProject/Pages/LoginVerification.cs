﻿using SeleniumProject.Helper_Functions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject.Pages
{
    public class LoginVerification : Selenium_Methods.Selenium_Methods
    {
        string appUsername = "abdul@finboa.com";
        string emailPassword = "$Pak35tan$2025";
        string otpToken = string.Empty;
        By OTP_Textbox = By.Id("otp");
        By Authenticate_Button = By.ClassName("reply-button");

        public string GetOTP()
        {
            otpToken = Helper_Function.GetEmailAuthenticationCode2(appUsername, emailPassword);
            return otpToken;
        }

        public void EnterOTPOnLoginVerificationDialog(string otp)
        {
            WaitForWebElementDisplayed(OTP_Textbox);
            EnterValueinWebElement(OTP_Textbox, otp);
        }

        public void ClickAuthenticateButtonOnLoginVerificationDialog()
        {
            WaitForWebElementDisplayed(Authenticate_Button);
            ClickOnWebElement(Authenticate_Button);
        }
    }
}
