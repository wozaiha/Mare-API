using System.Collections.Generic;

namespace MareSynchronos.API
{
    public record CharacterCacheDto
    {
        public Dictionary<ObjectKind, List<FileReplacementDto>> FileReplacements { get; set; } = new();
        public Dictionary<ObjectKind, string> GlamourerData { get; set; }
        public string ManipulationData { get; set; }
        public string Hash { get; set; }
    }
}
