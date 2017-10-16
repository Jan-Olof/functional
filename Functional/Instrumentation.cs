using Functional.Extensions;
using System;
using System.Diagnostics;

namespace Functional
{
    public static class Instrumentation
    {
        /// <summary>
        /// Time a function.
        /// </summary>
        public static void Time(string op, Action act)
            => Time(op, act.ToFunc());

        /// <summary>
        /// Time a function.
        /// </summary>
        public static T Time<T>(string op, Func<T> f)
        {
            var sw = new Stopwatch();
            sw.Start();

            T t = f();

            sw.Stop();
            Console.WriteLine($"{op} took {sw.ElapsedMilliseconds}ms.");
            return t;
        }
    }
}