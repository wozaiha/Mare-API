using MessagePack;

namespace MareSynchronos.API.Dto.Files;

[MessagePackObject(keyAsPropertyName: true)]
public record ForbiddenFileDto
{
    public string Hash { get; set; } = string.Empty;
    public string ForbiddenBy { get; set; } = string.Empty;
}