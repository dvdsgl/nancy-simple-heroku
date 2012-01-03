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
            var nancyHost = new NancyHost(new Uri("http://0.0.0.0:" + port));
            nancyHost.Start();

            Console.WriteLine("Nancy now listening - navigating to http://0.0.0.0:" + port +". Press enter to stop");
        }
    }
}
