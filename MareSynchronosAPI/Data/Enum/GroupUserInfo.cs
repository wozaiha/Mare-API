using System;

namespace MareSynchronos.API.Data;

[Flags]
public enum GroupUserInfo
{
    None = 0x0,
    IsModerator = 0x2,
    IsPinned = 0x4
}