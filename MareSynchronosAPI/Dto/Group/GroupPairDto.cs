using MareSynchronos.API.Dto.User;

namespace MareSynchronos.API.Dto.Group;

public record GroupPairDto(GroupData Group, UserData User) : GroupDto(Group)
{
    public string UID => User.UID;
    public string? UserAlias => User.Alias;
    public string UserAliasOrUID => User.AliasOrUID;
}
