using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using Finder.Host.Models;
using Nancy;
using Nancy.ModelBinding;

namespace Finder.Host.Modules
{
	public class HomeModule : NancyModule
	{

		private readonly List<User> _registeredUsers; 

		public HomeModule()
		{
			
			_registeredUsers = new List<User>();

			Get["/"] = p => View["Index"];

			Get["/users"] = p => Response.AsJson(GetAllUsers());

			Post["/register"] = p => RegisterUser(p);

		}

		private List<User> GetAllUsers()
		{
			return _registeredUsers;
		}

		private Response RegisterUser(dynamic user)
		{
			
			var newUser = this.Bind<User>();
			newUser.Id = Guid.NewGuid();
			newUser.RegisterDate = DateTime.Now;

			if (!IsSecure(newUser.Password))
			{
				return Response.AsJson("Password not secure", HttpStatusCode.BadRequest);
			}
			_registeredUsers.Add(newUser);

			return Response.AsJson(newUser, HttpStatusCode.Created);
		}

		private static bool IsSecure(string password)
		{
			var pattern = new Regex(@"^.*(?=.{7,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z0-9]).*$");
			return pattern.IsMatch(password);
		}
	}
}