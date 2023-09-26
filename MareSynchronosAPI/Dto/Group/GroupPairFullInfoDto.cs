using MareSynchronos.API.Data;
using MareSynchronos.API.Data.Enum;
using MessagePack;

namespace MareSynchronos.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPairFullInfoDto(GroupData Group, UserData User, GroupPairUserInfo GroupPairStatusInfo, UserPermissions GroupUserPermissions) : GroupPairDto(Group, User)
{
    public GroupPairUserInfo GroupPairStatusInfo { get; set; } = GroupPairStatusInfo;
    public UserPermissions GroupUserPermissions { get; set; } = GroupUserPermissions;
}