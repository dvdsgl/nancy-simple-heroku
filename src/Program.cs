namespace Nancy.Demo.Hosting.Self
{
    using System;
    using System.Diagnostics;

    using Nancy.Hosting.Self;

    class Program
    {
        static void Main()
        {
            var port = System.Environment.GetEnvironmentVariable("PORT");
            var nancyHost = new NancyHost(new Uri("http://127.0.0.1:" + port), new Uri("http://127.0.0.1:" + port + "/"));
            nancyHost.Start();

            Console.WriteLine("Nancy now listening - navigating to http://127.0.0.1:" + port +".");

            var line = Console.ReadLine();
            while(line != "quit") {
              line = Console.ReadLine();
            }
        }
    }
}
