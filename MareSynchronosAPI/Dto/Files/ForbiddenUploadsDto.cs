namespace MareSynchronos.API.Dto.Files;

public record ForbiddenFileDto
{
    public string Hash { get; set; } = string.Empty;
    public string ForbiddenBy { get; set; } = string.Empty;
}