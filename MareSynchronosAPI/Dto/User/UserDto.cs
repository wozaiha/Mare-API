namespace MareSynchronos.API.Dto.User;

public record UserDto(UserData User);
public record UserData(string UID, string? Alias = null);