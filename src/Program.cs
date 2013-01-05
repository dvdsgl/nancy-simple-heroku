using System;
using System.Diagnostics;
using Nancy.Hosting.Self;

namespace Nancy.Demo.Hosting.Self
{
	class Program
	{
		static NancyHost Host;

		static void Main (string[] args)
		{
			Host = new NancyHost (new Uri ("http://0.0.0.0:8080"));
			Host.Start ();
			Console.ReadLine ();
		}
	}
}
