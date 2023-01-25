using MareSynchronos.API.Dto.Files;

namespace MareSynchronos.API.Dto.Admin
{
    public record DownloadFileDto : ITransferFileDto
    {
        public bool FileExists { get; set; } = true;
        public string Hash { get; set; } = string.Empty;
        public string Url { get; set; }
        public long Size { get; set; } = 0;
        public bool IsForbidden { get; set; } = false;
        public string ForbiddenBy { get; set; } = string.Empty;
    }
}
