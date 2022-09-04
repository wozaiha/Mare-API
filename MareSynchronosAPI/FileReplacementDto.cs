using System;
using System.Collections.Generic;
using System.Linq;

namespace MareSynchronos.API
{
    public class FileReplacementDto
    {
        public string[] GamePaths { get; set; } = Array.Empty<string>();
        public string Hash { get; set; }

        public string FileSwapPath { get; set; } = string.Empty;

        public override bool Equals(object? otherObj)
        {
            if (otherObj == null || otherObj is not FileReplacementDto other) return false;
            return Hash == other.Hash && Enumerable.SequenceEqual(GamePaths, other.GamePaths);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(GetOrderIndependentHashCode(GamePaths), Hash, FileSwapPath);
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

        public override string ToString()
        {
            return Hash + ":" + string.Join(",", GamePaths) + "(" + FileSwapPath + ")";
        }
    }
}