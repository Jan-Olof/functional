using System.Collections.Generic;
using System.Collections.Immutable;

namespace Functional.Monad
{
    public static class Return
    {
        public static IEnumerable<T> List<T>(params T[] items)
            => items.ToImmutableList();
    }
}