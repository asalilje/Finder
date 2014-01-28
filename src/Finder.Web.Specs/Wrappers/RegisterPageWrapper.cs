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
	public class RegisterPageWrapper : WrapperBase
	{

		private const string BaseUrl = "http://localhost:61215";

		
		public void GoToRegisterPage()
		{
			Browser.Open(BaseUrl + "/#/register");
		}

		public void SetPassword(string password)
		{
			Browser.Enter(password).In("input#password");
		}

		public void AssertPasswordStrength(string strength)
		{
			Browser.Expect.Text(strength).In("span#strength");
		}
	}
}
