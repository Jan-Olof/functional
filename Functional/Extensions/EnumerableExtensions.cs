using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Functional.Extensions
{
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Bind a collection using an async function.
        /// </summary>
        public static async Task<IEnumerable<T2>> BindAsync<T1, T2>(this IEnumerable<T1> collection, Func<T1, Task<IEnumerable<T2>>> func)
            => (await Task.WhenAll(collection.Select(func)))
                .SelectMany(n => n);
    }
}