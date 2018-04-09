// ReSharper disable InconsistentNaming

using System;
using System.Collections.Generic;
using System.Linq;

namespace Functional.Monad
{
    public static class Binds
    {
        public static IEnumerable<R> Bind<T, R>(this IEnumerable<T> ts, Func<T, IEnumerable<R>> f)
            => ts.SelectMany(f);
    }
}