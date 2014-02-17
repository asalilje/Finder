using System;

using Finder.Web.Specs.Wrappers;

using TechTalk.SpecFlow;

namespace Finder.Web.Specs
{
    [Binding]
    public class UserRegistrationSteps
    {
				private readonly RegisterPageWrapper wrapper;

				public UserRegistrationSteps(RegisterPageWrapper wrapper)
				{
					this.wrapper = wrapper;
				}

	    [Given]
				public void Given_I_am_on_the_registration_page()
				{
						wrapper.GoToRegisterPage();
				}

        [When]
				public void When_I_enter_a_password_of_PASSWORD(string password)
				{
						wrapper.SetPassword(password);
				}

        [Then]
				public void Then_the_strength_indicator_should_read_STRENGTH(string strength)
				{
						wrapper.AssertPasswordStrength(strength);
				}
    }
}
