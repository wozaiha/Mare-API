using MareSynchronos.API.Data;
using MareSynchronos.API.Data.Enum;
using MessagePack;

namespace MareSynchronos.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPairFullInfoDto(GroupData Group, UserData User, GroupUserInfo GroupPairStatusInfo, GroupUserPreferredPermissions GroupUserPermissions) : GroupPairDto(Group, User)
{
    public GroupUserInfo GroupPairStatusInfo { get; set; } = GroupPairStatusInfo;
    public GroupUserPreferredPermissions GroupUserPermissions { get; set; } = GroupUserPermissions;
}