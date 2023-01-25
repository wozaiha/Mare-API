using MareSynchronos.API.Dto.User;

namespace MareSynchronos.API.Dto.Group;

public record GroupInfoDto : GroupDto
{
    public GroupInfoDto(GroupData group, UserData owner, GroupPermissions groupPermissions) : base(group)
    {
        Owner = owner;
        GroupPermissions = groupPermissions;
    }

    public string OwnerUID => Owner.UID;
    public string? OwnerAlias => Owner.Alias;
    public string OwnerAliasOrUID => OwnerAlias ?? OwnerUID;

    public GroupPermissions GroupPermissions { get; set; }
    public UserData Owner { get; set; }
}
