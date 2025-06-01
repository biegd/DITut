public class GreetingService : IGreetingService
{
    public string GetGreeting(string name) => $"Hallo, {name}!";
}
