using System.Collections.Generic;
using MareSynchronos.API.Data;

namespace MareSynchronos.API.Dto.User;

public record UserCharaDataMessageDto(List<UserData> Recipients, CharacterData CharaData);