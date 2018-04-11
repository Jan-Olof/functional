using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Functional.Extensions
{
    public static class EnumerableExtensions
    {
        public static async Task<IEnumerable<T2>> BindTasks<T1, T2>(this IEnumerable<T1> collection, Func<T1, Task<IEnumerable<T2>>> func)
        {
            var tasks = collection.Select(func);
            var nestedresults = await Task.WhenAll(tasks);
            return nestedresults.SelectMany(n => n);
        }
    }
}