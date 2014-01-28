using System;

using Finder.Web.Specs.Wrappers;

using TechTalk.SpecFlow;

namespace Finder.Web.Specs
{
		[Binding]
		public class NewUserRegistrationSteps
		{
			private readonly RegisterPageWrapper _wrapper;

			public NewUserRegistrationSteps(RegisterPageWrapper wrapper)
			{
				_wrapper = wrapper;
			}


			[Given]
			public void Given_I_m_on_the_registration_page()
			{
				_wrapper.GoToRegisterPage();
			}

			[When]
			public void When_I_enter_a_password_of_PASSWORD(string password)
			{
				_wrapper.SetPassword(password);
			}

			[Then]
			public void Then_the_password_strength_indicator_should_read_STRENGTH(string strength)
			{
				_wrapper.AssertPasswordStrength(strength);
			}

		}
}
