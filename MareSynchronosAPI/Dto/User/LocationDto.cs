using System.Numerics;
using MareSynchronos.API.Data;
using MareSynchronos.API.Dto.CharaData;
using MessagePack;

namespace MareSynchronos.API.Dto.User;


[MessagePackObject(keyAsPropertyName: true)]
public record LocationDto(UserData user, LocationInfo location);