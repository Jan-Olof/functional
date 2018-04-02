// ReSharper disable InconsistentNaming

using System;
using System.Collections.Generic;
using System.Linq;

namespace Functional.Map
{
    public static class Maps
    {
        public static IEnumerable<R> Map<T, R>(this IEnumerable<T> ts, Func<T, R> f)
            => ts.Select(f);

        //public static Option<R> Map<T, R>(this Option<T> optT, Func<T, R> f)
        //    => optT.Match(() => None, (t) => Some(f(t)));
    }
}