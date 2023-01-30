﻿namespace MareSynchronos.API.Data;

public class FileReplacementData : HashableDataBase
{
    public string[] GamePaths { get; set; } = Array.Empty<string>();
    public string Hash { get; set; } = string.Empty;
    public string FileSwapPath { get; set; } = string.Empty;
}