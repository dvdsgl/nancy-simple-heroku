using System;

namespace Nancy.Demo.Hosting.Self
{
	public class TestModule : NancyModule
	{
		public TestModule()
		{
			Get["/"] = parameters => {
				Console.WriteLine ("Visit /");
				return View["staticview", Request.Url];
			};
			
			Get["/foo"] = parameters => {
				Console.WriteLine ("foo!");
				return "bar!";
			};
		}
	}
}
