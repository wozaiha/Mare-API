using MareSynchronos.API.Data;
using MareSynchronos.API.Data.Enum;

namespace MareSynchronos.API.Dto.Group;

public record GroupPairUserPermissionDto(GroupData Group, UserData User, GroupUserPermissions GroupPairPermissions) : GroupPairDto(Group, User);
