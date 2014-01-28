using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentAutomation;

using OpenQA.Selenium;

namespace Finder.Web.Specs.Wrappers
{
	public class RegisterPageWrapper : FluentTest
	{

		private const string BaseUrl = "http://localhost:61215";
		
		public RegisterPageWrapper()
		{
			SeleniumWebDriver.Bootstrap();
			Settings.DefaultWaitUntilTimeout = new TimeSpan(0,0,0,5);
			Settings.ScreenshotPath = @"C:\temp\results";
		}


		public void GoToRegisterPage()
		{
			I.Open(BaseUrl + "/#/register");
		}

		public void SetPassword(string password)
		{
			I.Enter(password).In("input#password");
		}

		public void AssertPasswordStrength(string strength)
		{
			I.Expect.Text(strength).In("span#strength");
		}
	}
}
