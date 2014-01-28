using System;

using Finder.Web.Specs.Wrappers;

using TechTalk.SpecFlow;

namespace Finder.Web.Specs
{
		[Binding]
		public class NewUserRegistrationSteps
		{

			private RegisterPageWrapper _registerPageWrapper;


			public NewUserRegistrationSteps(RegisterPageWrapper registerPageWrapper)
			{
				_registerPageWrapper = registerPageWrapper;
			}

			[Given]
			public void Given_I_m_on_the_registration_page()
			{
				_registerPageWrapper.GoToRegisterPage();
			}

			[When]
			public void When_I_enter_a_password_of_pwd()
			{
				_registerPageWrapper.SetPassword("pwd");
			}

			[Then]
			public void Then_the_password_strength_indicator_should_read_Dålig()
			{
				_registerPageWrapper.AssertPasswordStrength("Dålig");
			}

		}
}
