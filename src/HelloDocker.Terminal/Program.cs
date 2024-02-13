(bool keepItUp, string answer) = (true, string.Empty);
while (keepItUp)
{
	Console.WriteLine("Hello from docker :))) <3");
	answer = Console.ReadLine();
	if(answer.Equals("hello",StringComparison.OrdinalIgnoreCase))
    {
        keepItUp = false;
        Console.WriteLine("Bye Bye !");
        Thread.Sleep(3000);
    }
}
