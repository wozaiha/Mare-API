using System.Collections.Generic;

namespace MareSynchronos.API
{
    public record CharacterCacheDto
    {
        public Dictionary<ObjectKind, List<FileReplacementDto>> FileReplacements { get; set; } = new();
        public Dictionary<ObjectKind, string> GlamourerData { get; set; } = new();
        public string ManipulationData { get; set; } = string.Empty;
        public string Hash { get; set; } = string.Empty;
    }
}
