using System.Security.Cryptography;
using Newtonsoft.Json;

namespace MareSynchronos.API.Data;

public abstract class HashableDataBase
{
    protected HashableDataBase()
    {
        DataHash = new(() =>
        {
            var json = JsonConvert.SerializeObject(this, Formatting.None);
            var hash = SHA256.HashData(System.Text.Encoding.UTF8.GetBytes(json));
            return BitConverter.ToString(hash).ToUpperInvariant().Replace("-", "", StringComparison.OrdinalIgnoreCase);
        });
    }

    [JsonIgnore]
    public Lazy<string> DataHash { get; }
}