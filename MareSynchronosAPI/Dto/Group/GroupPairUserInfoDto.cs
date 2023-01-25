using MareSynchronos.API.Data;
using MareSynchronos.API.Data.Enum;

namespace MareSynchronos.API.Dto.Group;

public record GroupPairUserInfoDto(GroupData Group, UserData User, GroupUserInfo GroupUserInfo) : GroupPairDto(Group, User);
