using System;
using Finder.Host.Models;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nancy;
using Nancy.Testing;

namespace Finder.Web.Tests
{
	[TestClass]
	public class HomeModuleTests
	{

		[TestMethod]
		public void Post_Valid_Data_To_Register_Should_Register_New_User()
		{
			// Given
			var bootstrapper = new DefaultNancyBootstrapper();
			var browser = new Browser(bootstrapper);
			var newUser = new User
			              {
				              Email = "email@email.em",
				              Password = "ThePassword",
				              UserName = "TheUsername",
				              FullName = "Full Name"
			              };
 
			// When
			var response = browser.Post("/register", c => c.JsonBody(newUser));

			// Then
			response.StatusCode.Should().Be(HttpStatusCode.Created);
			var user = response.Body.DeserializeJson<User>();
			user.Email.Should().Be(newUser.Email);
			user.Password.Should().Be(newUser.Password);
			user.FullName.Should().Be(newUser.FullName);
			user.UserName.Should().Be(newUser.UserName);
			user.Id.Should().NotBeEmpty();
			user.RegisterDate.Should().BeAfter(DateTime.MinValue);

		}
		
	}

}