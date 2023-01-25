using MareSynchronos.API.Data;

namespace MareSynchronos.API
{
    public record ConnectionDto(UserData User)
    {
        public int ServerVersion { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsModerator { get; set; }
        public ServerInfo ServerInfo { get; set; }
    }

    public record ServerInfo
    {
        public string ShardName { get; set; }
        public int MaxGroupUserCount { get; set; }
        public int MaxGroupsCreatedByUser { get; set; }
        public int MaxGroupsJoinedByUser { get; set; }
    }
}
