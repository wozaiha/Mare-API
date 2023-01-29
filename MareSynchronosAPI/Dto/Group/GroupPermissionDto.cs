using MareSynchronos.API.Data;
using MareSynchronos.API.Data.Enum;

namespace MareSynchronos.API.Dto.Group;

public record GroupPermissionDto(GroupData Group, GroupPermissions Permissions) : GroupDto(Group);
