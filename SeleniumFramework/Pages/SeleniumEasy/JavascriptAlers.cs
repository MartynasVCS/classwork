﻿using System;

namespace SeleniumFramework.Pages.SeleniumEasy
{
    public class JavascriptAlerts
    {
        public static string GetAlertText()
        {
            return Common.GetAlertText();
        }

        public static void Open()
        {
            Driver.OpenUrl("https://demo.seleniumeasy.com/javascript-alert-box-demo.html");
        }

        public static void OpenSimpleAlert()
        {
            Common.ClickElement("(//*[contains(@class,'panel-primary')])[1]//button");
        }
    }
}
