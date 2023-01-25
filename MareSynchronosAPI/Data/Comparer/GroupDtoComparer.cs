using MareSynchronos.API.Dto.Group;

namespace MareSynchronos.API.Data.Comparer;

public class GroupDtoComparer : IEqualityComparer<GroupDto>
{
    public bool Equals(GroupDto? x, GroupDto? y)
    {
        if (x == null || y == null) return false;
        return x.GID.Equals(y.GID, StringComparison.Ordinal);
    }

    public int GetHashCode(GroupDto obj)
    {
        return obj.Group.GID.GetHashCode();
    }
}