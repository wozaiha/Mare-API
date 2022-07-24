using System;
using System.Collections.Generic;

namespace MareSynchronos.API
{
    public record FileReplacementDto
    {
        public string[] GamePaths { get; set; } = Array.Empty<string>();
        public string Hash { get; set; }

        public override int GetHashCode()
        {
            return HashCode.Combine(GetOrderIndependentHashCode(GamePaths), Hash);
        }

        public static int GetOrderIndependentHashCode<T>(IEnumerable<T> source)
        {
            int hash = 0;
            foreach (T element in source)
            {
                hash = unchecked(hash +
                    EqualityComparer<T>.Default.GetHashCode(element));
            }
            return hash;
        }
    }
}