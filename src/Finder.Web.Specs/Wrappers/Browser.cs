using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAutomation;

namespace Finder.Web.Specs.Wrappers
{
	public class Browser: FluentTest
	{

		public Browser()
		{
			SeleniumWebDriver.Bootstrap(SeleniumWebDriver.Browser.Chrome);
			Settings.DefaultWaitUntilTimeout = new TimeSpan(0, 0, 0, 5);
			Settings.ScreenshotPath = @"C:\temp\results";
		}
	}
}
