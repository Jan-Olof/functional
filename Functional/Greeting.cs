using System;

namespace Functional
{
    public class Greeting
    {
        public readonly Func<string, string> Greet = name => $"hello, {name}";
    }
}