namespace MareSynchronos.API
{
    public record ConnectionDto
    {
        public int ServerVersion { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsModerator { get; set; }
        public string UID { get; set; }
        public ServerInfoDto ServerInfo { get; set; }
    }

    public record ServerInfoDto
    {
        public string ShardName { get; set; }
        public int MaxGroupUserCount { get; set; }
        public int MaxGroupsCreatedByUser { get; set; }
        public int MaxGroupsJoinedByUser { get; set; }
    }
}
