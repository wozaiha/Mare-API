using MareSynchronos.API.Data;
using MareSynchronos.API.Data.Enum;

namespace MareSynchronos.API.Dto.User;

public record UserPermissionsDto(UserData User, UserPermissions Permissions) : UserDto(User);