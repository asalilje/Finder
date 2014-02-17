using FluentAutomation.Interfaces;

namespace Finder.Web.Specs.Wrappers
{
	public class WrapperBase
	{
		
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
