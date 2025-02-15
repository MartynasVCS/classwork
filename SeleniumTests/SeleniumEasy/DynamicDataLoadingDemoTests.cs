﻿using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.SeleniumEasy;

namespace SeleniumTests.SeleniumEasy
{
    internal class DynamicDataLoadingDemoTests
    {
        [SetUp]
        public void Setup()
        {
            Driver.SetupDriver();
            DynamicDataLoadingDemo.Open();
        }

        [Test]
        public void WaitForUserInformationToBePresent()
        {
            DynamicDataLoadingDemo.ClickGetNewUserButton();
            string userInformation = DynamicDataLoadingDemo.GetUserInformation();

            Assert.IsTrue(userInformation.Contains("First Name : "));
            Assert.IsTrue(userInformation.Contains("Last Name : "));
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
