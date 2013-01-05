using System;
using System.Diagnostics;
using Nancy.Hosting.Self;

namespace Nancy.Simple
{
	class App
	{
		static NancyHost Host;

		static void Main (string[] args)
		{
			Host = new NancyHost (new Uri ("http://localhost:8080"));
			Host.Start ();
			Console.ReadKey ();
			Host.Stop ();
		}
	}
}
