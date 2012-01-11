namespace Nancy.Demo.Hosting.Self
{
    using System;
    using System.Diagnostics;

    using Nancy.Hosting.Self;

    class Program
    {
        static void Main()
        {
            var hostname = "deep-moon-1452";

            var port = System.Environment.GetEnvironmentVariable("PORT");
            var nancyHost = new NancyHost(new Uri("http://" + hostname + ".herokuapp.com:" + port), new Uri("http://0.0.0.0:" + port));
            nancyHost.Start();

            Console.WriteLine("Nancy now listening - navigating to http://" + hostname +".herokuapp.com:" + port +".");

            var line = Console.ReadLine();
            while(line != "quit") {
              line = Console.ReadLine();
            }
        }
    }
}
