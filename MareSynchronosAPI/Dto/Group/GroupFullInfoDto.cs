using MareSynchronos.API.Dto.User;

namespace MareSynchronos.API.Dto.Group;

public record GroupFullInfoDto(GroupData Group, UserData Owner, GroupPermissions GroupPermissions,
    GroupUserPermissions OwnPermissions, GroupUserInfo GroupUserInfo) : GroupDto(Group);
