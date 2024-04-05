using MareSynchronos.API.Data;
using MessagePack;

namespace MareSynchronos.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record UserProfileDto(UserData User, bool Disabled, bool? IsNSFW, byte[]? ProfilePicture, string? Description) : UserDto(User);

[MessagePackObject(keyAsPropertyName: true)]
public record UserProfileMetaDto(UserData User, bool Disabled, bool? IsNSFW, Guid? ProfilePicture, string? Description) : UserDto(User);