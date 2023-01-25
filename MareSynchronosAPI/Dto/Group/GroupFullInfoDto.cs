using MareSynchronos.API.Dto.User;

namespace MareSynchronos.API.Dto.Group;

public record GroupFullInfoDto : GroupInfoDto
{
    public GroupFullInfoDto(GroupData group, UserData owner, GroupPermissions groupPermissions, GroupUserPermissions groupUserPermissions, GroupUserInfo groupUserInfo) : base(group, owner, groupPermissions)
    {
        Owner = owner;
        GroupPermissions = groupPermissions;
        GroupUserPermissions = groupUserPermissions;
        GroupUserInfo = groupUserInfo;
    }

    public GroupUserPermissions GroupUserPermissions { get; set; }
    public GroupUserInfo GroupUserInfo { get; set; }
}