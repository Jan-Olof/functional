using System;
using static Functional.F;
using Unit = System.ValueTuple;

namespace Functional.Extensions
{
    /// <summary>
    /// Extends Action.
    /// </summary>
    public static class ActionExtensions
    {
        /// <summary>
        /// Adapter function that convert an Action into a Unit-returning Func.
        /// </summary>
        public static Func<Unit> ToFunc(this Action action)
            => () => { action(); return Unit(); };

        /// <summary>
        /// Adapter function that convert an Action into a Unit-returning Func.
        /// </summary>
        public static Func<T, Unit> ToFunc<T>(this Action<T> action)
            => (t) => { action(t); return Unit(); };

        /// <summary>
        /// Adapter function that convert an Action into a Unit-returning Func.
        /// </summary>
        public static Func<T1, T2, Unit> ToFunc<T1, T2>(this Action<T1, T2> action)
            => (t1, t2) => { action(t1, t2); return Unit(); };

        /// <summary>
        /// Adapter function that convert an Action into a Unit-returning Func.
        /// </summary>
        public static Func<T1, T2, T3, Unit> ToFunc<T1, T2, T3>(this Action<T1, T2, T3> action)
            => (t1, t2, t3) => { action(t1, t2, t3); return Unit(); };

        /// <summary>
        /// Adapter function that convert an Action into a Unit-returning Func.
        /// </summary>
        public static Func<T1, T2, T3, T4, Unit> ToFunc<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action)
            => (t1, t2, t3, t4) => { action(t1, t2, t3, t4); return Unit(); };
    }
}