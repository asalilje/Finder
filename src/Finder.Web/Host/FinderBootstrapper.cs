using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using Nancy.Conventions;

namespace Finder.Host
{
	public class FinderBootstrapper : DefaultNancyBootstrapper 
	{

		protected override void ConfigureConventions(NancyConventions nancyConventions)
		{
			base.ConfigureConventions(nancyConventions);

			nancyConventions.StaticContentsConventions
											.Add(StaticContentConventionBuilder.AddDirectory("Scripts"));
			nancyConventions.StaticContentsConventions
											.Add(StaticContentConventionBuilder.AddDirectory("Templates"));

		}
	}
}