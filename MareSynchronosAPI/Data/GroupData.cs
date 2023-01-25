namespace MareSynchronos.API.Data;

public record GroupData(string GID, string? Alias = null)
{
    public string AliasOrGID => Alias ?? GID;
}
