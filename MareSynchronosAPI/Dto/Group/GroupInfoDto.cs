using MareSynchronos.API.Dto.User;

namespace MareSynchronos.API.Dto.Group;

public record GroupInfoDto(GroupData group, UserData owner, GroupPermissions GroupPermissions) : GroupDto(group);
