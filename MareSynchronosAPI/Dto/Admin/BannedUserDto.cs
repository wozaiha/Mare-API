namespace MareSynchronos.API.Dto.Admin;

public record BannedUserDto
{
    public string CharacterHash { get; set; }
    public string Reason { get; set; }
}