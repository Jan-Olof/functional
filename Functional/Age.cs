using LaYumba.Functional;
using System;

using static LaYumba.Functional.F;

namespace Functional
{
    public struct Age
    {
        private Age(int value)
        {
            if (!IsValid(value))
            {
                throw new ArgumentException($"{value} is not a valid age.");
            }

            Value = value;
        }

        public int Value { get; }

        public static Option<Age> Of(int age) => IsValid(age) ? Some(new Age(age)) : None;

        public static bool operator <(Age l, Age r)
            => l.Value < r.Value;

        public static bool operator <(Age l, int r)
            => l < new Age(r);

        public static bool operator >(Age l, Age r)
            => l.Value > r.Value;

        public static bool operator >(Age l, int r)
            => l > new Age(r);

        private static bool IsValid(int age)
            => 0 <= age && age < 120;
    }
}