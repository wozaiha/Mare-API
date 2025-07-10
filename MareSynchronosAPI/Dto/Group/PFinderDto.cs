using MareSynchronos.API.Data;
using MessagePack;

namespace MareSynchronos.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record PFinderDto
{
    public Guid Guid { get; set; }
    public DateTimeOffset StartTime { get; set; }
    public DateTimeOffset EndTime { get; set; }
    public DateTimeOffset LastUpdate { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Tags { get; set; }
    public bool IsNSFW { get; set; }
    public bool Open { get; set; }
    public GroupData Group { get; set; }
    public UserData User { get; set; }

    public PFinderDto(Guid guid, DateTimeOffset startTime, DateTimeOffset endTime, DateTimeOffset lastUpdate, string title, string description, string tags,
        bool isNSFW, bool open, GroupData group, UserData user)
    {
        Guid = guid;
        StartTime = startTime;
        EndTime = endTime;
        LastUpdate = lastUpdate;
        Title = title;
        Description = description;
        Tags = tags;
        IsNSFW = isNSFW;
        Open = open;
        Group = group;
        User = user;
    }

    public PFinderDto()
    {
        Guid = Guid.NewGuid();
        StartTime = DateTime.Now;
        EndTime = DateTime.Now;
        LastUpdate = DateTime.Now;
        Title = string.Empty;
        Description = string.Empty;
        Tags = string.Empty;
        IsNSFW = false;
        Open = false;
        Group = new GroupData(string.Empty);
        User = new UserData(string.Empty);
    }

    public bool IsVaild()
    {
        if (Guid == Guid.Empty) return false;
        if (StartTime > DateTime.Now + TimeSpan.FromDays(3)) return false;
        if (EndTime < DateTime.Now) return false;
        if (StartTime + TimeSpan.FromDays(1) < EndTime || StartTime > EndTime) return false;
        if (string.IsNullOrEmpty(Title)) return false;
        if (string.IsNullOrEmpty(Description)) return false;
        if (string.IsNullOrEmpty(Group.GID)) return false;
        if (string.IsNullOrEmpty(User.UID)) return false;
        return true;
    }
}