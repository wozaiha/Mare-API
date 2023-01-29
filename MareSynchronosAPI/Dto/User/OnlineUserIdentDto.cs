using MareSynchronos.API.Data;

namespace MareSynchronos.API.Dto.User;

public record OnlineUserIdentDto(UserData User, string Ident) : UserDto(User);