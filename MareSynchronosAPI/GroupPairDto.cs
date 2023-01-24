namespace MareSynchronos.API
{
    public record GroupPairDto
    {
        public string GroupGID { get; set; }
        public string UserUID { get; set; }
        public string? UserAlias { get; set; }
        public bool? IsPaused { get; set; }
        public bool? IsRemoved { get; set; }
        public bool? IsPinned { get; set; }
        public bool? IsModerator { get; set; }
        public bool? DisableAnimations { get; set; }
        public bool? DisableSounds { get; set; }
    }
}