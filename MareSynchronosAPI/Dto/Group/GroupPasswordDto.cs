using MareSynchronos.API.Data;

namespace MareSynchronos.API.Dto.Group;

public record GroupPasswordDto(GroupData Group, string Password) : GroupDto(Group);
