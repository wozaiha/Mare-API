using MareSynchronos.API.Data;
using MessagePack;

namespace MareSynchronos.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record ApplyMoodlesByStatusDto(UserData User, List<MoodlesStatusInfo> Statuses, MoodlesIpcToggleType Type) : UserDto(User);