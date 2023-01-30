﻿using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;

namespace MareSynchronos.API.Data;

public abstract class HashableDataBase
{
    protected HashableDataBase()
    {
        DataHash = new(() =>
        {
            var json = JsonConvert.SerializeObject(this, Formatting.None);
            using SHA256CryptoServiceProvider cryptoProvider = new();
            return BitConverter.ToString(cryptoProvider.ComputeHash(Encoding.UTF8.GetBytes(json))).Replace("-", "", StringComparison.Ordinal);
        });
    }

    [JsonIgnore]
    public Lazy<string> DataHash { get; }
}