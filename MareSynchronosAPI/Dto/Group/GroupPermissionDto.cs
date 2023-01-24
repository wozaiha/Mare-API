namespace MareSynchronos.API.Dto.Group;

public record GroupPermissionDto(GroupData Group, GroupPermissions Permissions) : GroupDto(Group);
