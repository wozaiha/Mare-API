using MareSynchronos.API.Dto.User;

namespace MareSynchronos.API.Dto.Group;

public record GroupPairUserPermissionDto(GroupData Group, UserData User, GroupUserPermissions GroupPairPermissions) : GroupPairDto(Group, User);
