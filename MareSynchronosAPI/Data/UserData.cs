namespace MareSynchronos.API.Data;

public record UserData(string UID, string? Alias = null)
{
    public string AliasOrUID => Alias ?? UID;
}