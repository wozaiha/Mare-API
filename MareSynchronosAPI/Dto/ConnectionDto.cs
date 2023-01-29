using MareSynchronos.API.Data;

namespace MareSynchronos.API.Dto;

public record ConnectionDto(UserData User)
{
    public int ServerVersion { get; set; }
    public bool IsAdmin { get; set; }
    public bool IsModerator { get; set; }
    public ServerInfo ServerInfo { get; set; } = new();
}

public record ServerInfo
{
    public string ShardName { get; set; } = string.Empty;
    public int MaxGroupUserCount { get; set; }
    public int MaxGroupsCreatedByUser { get; set; }
    public int MaxGroupsJoinedByUser { get; set; }
}