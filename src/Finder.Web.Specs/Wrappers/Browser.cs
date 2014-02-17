using System;

using FluentAutomation;

namespace Finder.Web.Specs.Wrappers
{
	public class Browser: FluentTest
	{

		public Browser()
		{
			SeleniumWebDriver.Bootstrap();
			Settings.DefaultWaitUntilTimeout = new TimeSpan(0, 0, 0, 5);
			Settings.ScreenshotPath = @"C:\temp\results";
		}
	}
}
