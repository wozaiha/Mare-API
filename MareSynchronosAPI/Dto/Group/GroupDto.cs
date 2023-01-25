namespace MareSynchronos.API.Dto.Group;

public record GroupDto
{
    public GroupDto(GroupData group)
    {
        Group = group;
    }

    public GroupData Group { get; set; }
    public string GID => Group.GID;
    public string? GroupAlias => Group.Alias;
    public string GroupAliasOrGID => GroupAlias ?? GID;
}

