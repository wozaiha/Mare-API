using MareSynchronos.API.Data.Enum;

namespace MareSynchronos.API.Data.Extensions;

public static class GroupUserPermissionsExtensions
{
    public static bool IsDisableAnimations(this GroupUserPermissions perm)
    {
        return perm.HasFlag(GroupUserPermissions.DisableAnimations);
    }

    public static bool IsDisableSounds(this GroupUserPermissions perm)
    {
        return perm.HasFlag(GroupUserPermissions.DisableSounds);
    }

    public static bool IsPaused(this GroupUserPermissions perm)
    {
        return perm.HasFlag(GroupUserPermissions.Paused);
    }

    public static void SetDisableAnimations(this ref GroupUserPermissions perm, bool disable)
    {
        if (disable) perm &= ~GroupUserPermissions.DisableAnimations;
        else perm |= GroupUserPermissions.DisableAnimations;
    }

    public static void SetDisableSounds(this ref GroupUserPermissions perm, bool disable)
    {
        if (disable) perm &= ~GroupUserPermissions.DisableSounds;
        else perm |= GroupUserPermissions.DisableSounds;
    }

    public static void SetPaused(this ref GroupUserPermissions perm, bool disable)
    {
        if (disable) perm &= ~GroupUserPermissions.Paused;
        else perm |= GroupUserPermissions.Paused;
    }
}