namespace MareSynchronos.API.Dto.Files;

public record ForbiddenFileDto
{
    public string Hash { get; set; }
    public string ForbiddenBy { get; set; }
}