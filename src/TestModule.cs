namespace Nancy.Demo.Hosting.Self
{
    public class TestModule : NancyModule
    {
        public TestModule()
        {
            Get["/"] = parameters => {
                System.Console.WriteLine("Visit /");
                return View["staticview", Request.Url];
            };

            Get["/testing"] = parameters =>
            {
                System.Console.WriteLine("Visit /testing");
                return View["staticview", Request.Url];
            };
        }
    }
}
