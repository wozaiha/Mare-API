using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using MessagePack;

namespace MareSynchronos.API.Data;

public abstract class HashableDataBase
{
    protected HashableDataBase()
    {
        DataHash = new(() =>
        {
            var json = JsonSerializer.Serialize(this);
            using SHA256CryptoServiceProvider cryptoProvider = new();
            return BitConverter.ToString(cryptoProvider.ComputeHash(Encoding.UTF8.GetBytes(json))).Replace("-", "", StringComparison.Ordinal);
        });
    }

    [JsonIgnore]
    public Lazy<string> DataHash { get; }
}