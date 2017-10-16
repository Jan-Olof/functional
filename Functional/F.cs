using System;

using Unit = System.ValueTuple;

namespace Functional
{
    /// <summary>
    /// Contains widly reusable functions.
    /// </summary>
    public static class F
    {
        /// <summary>
        /// Convenience method that allows you to simply write "return Unit()" in functions that return Unit.
        /// </summary>
        public static Unit Unit() => default(Unit);

        /// <summary>
        /// Generic setup/teardown that performs the using ceremony.
        /// </summary>
        public static TR Using<TDisp, TR>(TDisp disposable, Func<TDisp, TR> f) where TDisp : IDisposable
        {
            using (disposable) return f(disposable);
        }

        /// <summary>
        /// Generic setup/teardown that performs the using ceremony.
        /// </summary>
        public static void Using<TDisp>(TDisp disposable, Action<TDisp> f) where TDisp : IDisposable
        {
            using (disposable) f(disposable);
        }
    }
}