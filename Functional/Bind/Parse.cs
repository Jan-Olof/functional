using LaYumba.Functional;
using System;

namespace Functional.Bind
{
    public static class Parse
    {
        public static readonly Func<string, Option<Age>> ParseAge = s => Int.Parse(s).Bind(Age.Of);
    }
}