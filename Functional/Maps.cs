//using LaYumba.Functional;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using static LaYumba.Functional.F;

//namespace Functional
//{
//    public static class Maps
//    {
//        public static IEnumerable<R> Map<T, R>(this IEnumerable<T> ts, Func<T, R> f)
//            => ts.Select(f);

//        public static Option<R> Map<T, R>(this Option<T> optT, Func<T, R> f)
//            => optT.Match(() => None, (t) => Some(f(t)));
//    }
//}