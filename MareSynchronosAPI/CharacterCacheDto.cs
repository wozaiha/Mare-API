using System;
using System.Collections.Generic;
using System.Linq;

namespace MareSynchronos.API
{
    public class CharacterCacheDto
    {
        public Dictionary<ObjectKind, List<FileReplacementDto>> FileReplacements { get; set; } = new();
        public Dictionary<ObjectKind, string> GlamourerData { get; set; } = new();
        public string ManipulationData { get; set; } = string.Empty;
        public override string ToString()
        {
            return GetHashCode() + Environment.NewLine + "Manip:" + ManipulationData + Environment.NewLine
                + string.Join(Environment.NewLine, GlamourerData.Select(g => g.Key + ":" + g.Value)) + Environment.NewLine
                + string.Join(Environment.NewLine, FileReplacements.Select(g => g.Key + Environment.NewLine + string.Join(Environment.NewLine, g.Value)));
        }

        public float HeelsOffset { get; set; } = 0.0f;

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

        public override int GetHashCode()
        {
            int fileReplacementsHash = 0;
            foreach (var item in FileReplacements)
            {
                foreach (var values in item.Value)
                {
                    fileReplacementsHash = unchecked(fileReplacementsHash + values.GetHashCode());
                }
            }

            int glamourerHash = 0;
            foreach (var item in GlamourerData)
            {
                glamourerHash = unchecked(glamourerHash + item.Value.GetHashCode());
            }

            return HashCode.Combine(fileReplacementsHash, glamourerHash, ManipulationData, HeelsOffset);
        }
    }
}
