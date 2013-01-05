using System;

namespace Nancy.Simple
{
	public class MainModule : NancyModule
	{
		public MainModule()
		{
			Get["/"] = args => {
				return View ["index", Request.Url];
			};
		}
	}
}
