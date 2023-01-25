using MareSynchronos.API.Dto.User;

namespace MareSynchronos.API.Dto.Group;

public record GroupPairFullInfoDto : GroupPairDto
{
    public GroupPairFullInfoDto(GroupData group, UserData user, GroupUserInfo groupPairStatusInfo, GroupUserPermissions groupUserPermissions) : base(group, user)
    {
        GroupPairStatusInfo = groupPairStatusInfo;
        GroupUserPermissions = groupUserPermissions;
    }

    public GroupUserInfo GroupPairStatusInfo { get; set; }
    public GroupUserPermissions GroupUserPermissions { get; set; }
}