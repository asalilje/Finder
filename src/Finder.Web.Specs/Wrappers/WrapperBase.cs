using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAutomation.Interfaces;

namespace Finder.Web.Specs.Wrappers
{
	public class WrapperBase
	{
		public WrapperBase()
		{
			
		}

		private static Browser _instance;
			
		public static INativeActionSyntaxProvider Browser
		{
			get
			{
				if (_instance == null)
				{
					_instance = new Browser();
				}
				return _instance.I;
			}
		}
	
	}
}
