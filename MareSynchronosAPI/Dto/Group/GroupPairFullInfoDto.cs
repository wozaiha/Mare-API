using MareSynchronos.API.Dto.User;

namespace MareSynchronos.API.Dto.Group;

public record GroupPairFullInfoDto(GroupData Group, UserData User, GroupUserInfo GroupPairStatusInfo, GroupUserPermissions GroupUserPermissions) : GroupPairDto(Group, User);
