namespace MareSynchronos.API.Dto.Files;

public record UploadFileDto : ITransferFileDto
{
    public string Hash { get; set; } = string.Empty;
    public bool IsForbidden { get; set; } = false;
    public string ForbiddenBy { get; set; } = string.Empty;
}