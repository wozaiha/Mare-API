using MareSynchronos.API.Data;
using MareSynchronos.API.Data.Enum;

namespace MareSynchronos.API.Dto.Group;

public record GroupFullInfoDto(GroupData Group, UserData Owner, GroupPermissions GroupPermissions, GroupUserPermissions GroupUserPermissions, GroupUserInfo GroupUserInfo) : GroupInfoDto(Group, Owner, GroupPermissions)
{
    public GroupUserPermissions GroupUserPermissions { get; set; } = GroupUserPermissions;
    public GroupUserInfo GroupUserInfo { get; set; } = GroupUserInfo;
}