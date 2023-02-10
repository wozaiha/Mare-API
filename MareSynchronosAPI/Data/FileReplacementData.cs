using MessagePack;

namespace MareSynchronos.API.Data;

[MessagePackObject(keyAsPropertyName: true)]
public class FileReplacementData : HashableDataBase
{
    public string[] GamePaths { get; set; } = Array.Empty<string>();
    public string Hash { get; set; } = string.Empty;
    public string FileSwapPath { get; set; } = string.Empty;
}