namespace MareSynchronos.API
{
    public record GroupPairDto
    {
        public string GroupGID { get; set; }
        public string UserUID { get; set; }
        public string UserAlias { get; set; }
        public bool IsPaused { get; set; }
        public bool IsRemoved { get; set; }
    }
}