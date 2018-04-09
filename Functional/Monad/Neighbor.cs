using System;
using System.Collections.Generic;

namespace Functional.Monad
{
    public class Neighbor
    {
        public Neighbor(string name, List<string> pets)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Pets = pets ?? throw new ArgumentNullException(nameof(pets));
        }

        public string Name { get; }

        public List<string> Pets { get; }
    }
}