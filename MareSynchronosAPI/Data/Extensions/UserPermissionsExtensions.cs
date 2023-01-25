using MareSynchronos.API.Data.Enum;

namespace MareSynchronos.API.Data.Extensions;

public static class UserPermissionsExtensions
{
    public static bool IsPaired(this UserPermissions perm)
    {
        return perm.HasFlag(UserPermissions.Paired);
    }

    public static bool IsPaused(this UserPermissions perm)
    {
        return perm.HasFlag(UserPermissions.Paused);
    }

    public static void SetPaired(this ref UserPermissions perm, bool paired)
    {
        if (paired) perm |= UserPermissions.Paired;
        perm &= ~UserPermissions.Paired;
    }

    public static void SetPaused(this ref UserPermissions perm, bool paused)
    {
        if (paused) perm |= UserPermissions.Paused;
        perm &= ~UserPermissions.Paused;
    }
}