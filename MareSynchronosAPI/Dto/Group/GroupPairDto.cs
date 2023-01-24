using MareSynchronos.API.Dto.User;

namespace MareSynchronos.API.Dto.Group;

public record GroupPairDto(GroupData Group, UserData User) : GroupDto(Group);
