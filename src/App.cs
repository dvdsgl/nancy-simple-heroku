using System;
using System.Diagnostics;
using Nancy.Hosting.Self;

namespace Nancy.Simple
{
	class App
	{
		const string StagingPort = "8080";

		static readonly string HOST = Environment.GetEnvironmentVariable ("HOST");
		static readonly string PORT = Environment.GetEnvironmentVariable ("PORT");

		static NancyHost Host;

		enum Env { Staging, Deployment }

		static Env CurrentEnv {
			get {
				return HOST == null ? Env.Staging : Env.Deployment;
			}
		}

		static Uri CurrentAddress {
			get {
				switch (CurrentEnv) {
				case Env.Staging:
					return new Uri ("http://localhost:" + StagingPort);
				case Env.Deployment:
					return new Uri (HOST + ":" + PORT);
				default:
					throw new Exception ("Unexpected environment");
				}
			}
		}

		static void Main (string[] args)
		{
			Host = new NancyHost (CurrentAddress);
			Host.Start ();
			Console.WriteLine ("Nancy is started and listening on {0}...", CurrentAddress);

			KeepAlive ();

			Host.Stop ();
		}

		static void KeepAlive ()
		{
			for (var line = Console.ReadLine (); line != "quit";);
		}
	}
}
