namespace MareSynchronos.API
{
    public record GroupDto
    {
        public string GID { get; set; }
        public string? OwnedBy { get; set; }
        public bool? InvitesEnabled { get; set; }
        public bool? IsPaused { get; set; }
        public bool? IsDeleted { get; set; }
        public string? Alias { get; set; }
        public bool? IsModerator { get; set; }
        public bool? DisableAnimations { get; set; }
        public bool? DisableSounds { get; set; }
    }
}
