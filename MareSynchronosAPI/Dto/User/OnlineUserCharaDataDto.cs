using MareSynchronos.API.Data;

namespace MareSynchronos.API.Dto.User;

public record OnlineUserCharaDataDto(UserData User, CharacterData CharaData) : UserDto(User);