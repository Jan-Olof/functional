namespace Functional.Subcribers
{
    public static class SubcribeLogic
    {
        public static string GreetingFor(Subscriber subscriber)
            => subscriber.Name.Match(
                () => "Dear Subscriber, ",
                (name) => $"Dear {name.ToUpper()},");
    }
}