(bool keepItUp, string answer, string serve_env) = (true, string.Empty, Environment.GetEnvironmentVariable("SERVE_STATUS"));
switch (serve_env)
{
    case "default":
        while (keepItUp)
        {
            Console.WriteLine("Hello from docker :))) <3");
            answer = Console.ReadLine();
            if (answer.Equals("hello", StringComparison.OrdinalIgnoreCase))
            {
                keepItUp = false;
                Thread.Sleep(1000);
                Console.WriteLine("Bye Bye !");
            }
        }
        break;
    case "loop":
        while (keepItUp)
        {
            Console.WriteLine("Hello from docker :))) <3");
            Thread.Sleep(1000);
        }
        break;
    default:
        throw new Exception("SERVE_ENV does not determined properly. right values mus be one of \"loop\" or \"default\"");
}
