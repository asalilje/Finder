using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finder.Web.Specs.Wrappers;
using TechTalk.SpecFlow;

namespace Finder.Web.Specs
{
	[Binding]
	internal class Hooks
	{

		[BeforeScenario]
		public static void BeforeEveryScenario()
		{
			// Setup data source
		}

		[AfterScenario]
		public static void AfterScenario()
		{
			// Tear down data source
		}

	}
}
