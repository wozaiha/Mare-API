using MareSynchronos.API.Data;
using MessagePack;

namespace MareSynchronos.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record PFinderDto(Guid Guid, DateTime StartTime, DateTime EndTime, DateTime LastUpdate, string Title, string Description, string Tags,
    bool IsNSFW, bool Open,
    GroupData Group, UserData User) : GroupDto(Group)
{

    public Guid Guid { get; set; } = Guid;

    public DateTime StartTime { get; set; } = StartTime;

    public DateTime EndTime { get; set; } = EndTime;

    public DateTime LastUpdate { get; set; } = LastUpdate;

    public string Title { get; set; } = Title;

    public string Description { get; set; } = Description;

    public string Tags { get; set; } = Tags;

    public bool IsNSFW { get; set; } = IsNSFW;

    public bool Open { get; set; } = Open;

    public GroupData Group { get; set; } = Group;

    public UserData User { get; set; } = User;

}

[MessagePackObject(keyAsPropertyName: true)]
public record PFinderListDto(List<PFinderDto> PFinderList);