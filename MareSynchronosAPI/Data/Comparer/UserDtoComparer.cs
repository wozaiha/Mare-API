using MareSynchronos.API.Dto.User;

namespace MareSynchronos.API.Data.Comparer;
public class UserDataComparer : IEqualityComparer<UserData>
{
    public bool Equals(UserData? x, UserData? y)
    {
        if (x == null || y == null) return false;
        return x.UID.Equals(y.UID, StringComparison.Ordinal);
    }

    public int GetHashCode(UserData obj)
    {
        return obj.UID.GetHashCode();
    }
}

public class UserDtoComparer : IEqualityComparer<UserDto>
{
    public bool Equals(UserDto? x, UserDto? y)
    {
        if (x == null || y == null) return false;
        return x.User.UID.Equals(y.User.UID, StringComparison.Ordinal);
    }

    public int GetHashCode(UserDto obj)
    {
        return obj.User.UID.GetHashCode();
    }
}