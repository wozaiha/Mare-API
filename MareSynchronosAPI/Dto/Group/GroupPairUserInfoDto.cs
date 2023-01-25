using MareSynchronos.API.Data;

namespace MareSynchronos.API.Dto.Group;

public record GroupPairUserInfoDto(GroupData Group, UserData User, GroupUserInfo GroupUserInfo) : GroupPairDto(Group, User);
