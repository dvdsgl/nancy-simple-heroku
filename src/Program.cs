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
            var nancyHost = new NancyHost(new Uri("http://deep-moon-1452.herokuapp.com:" + port), new Uri("http://deep-moon-1452.herokuapp.com:" + port + "/"));
            nancyHost.Start();

            Console.WriteLine("Nancy now listening - navigating to http://deep-moon-1452.herokuapp.com:" + port +".");

            var line = Console.ReadLine();
            while(line != "quit") {
              line = Console.ReadLine();
            }
        }
    }
}
