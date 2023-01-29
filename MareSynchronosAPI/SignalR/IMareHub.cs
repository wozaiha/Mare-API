using MareSynchronos.API.Data.Enum;
using MareSynchronos.API.Dto;
using MareSynchronos.API.Dto.Group;
using MareSynchronos.API.Dto.User;
using MareSynchronos.API.Dto.Files;

namespace MareSynchronos.API.SignalR;

public interface IMareHub
{
    const int ApiVersion = 21;
    const string Path = "/mare";

    Task<ConnectionDto> GetConnectionDto();
    Task<bool> CheckClientHealth();

    Task<List<DownloadFileDto>> FilesGetSizes(List<string> hashes);
    Task FilesAbortUpload();
    Task FilesDeleteAll();
    Task<bool> FilesIsUploadFinished();
    Task<List<UploadFileDto>> FilesSend(List<string> fileListHashes);
    Task FilesUploadStreamAsync(string hash, IAsyncEnumerable<byte[]> fileContent);

    Task<List<UserPairDto>> UserGetPairedClients();
    Task UserAddPair(UserDto user);
    Task UserRemovePair(UserDto userDto);
    Task UserSetPairPermissions(UserPermissionsDto userPermissions);
    Task<List<OnlineUserIdentDto>> UserGetOnlinePairs();
    Task UserPushData(UserCharaDataMessageDto dto);

    Task UserDelete();

    Task<List<BannedGroupUserDto>> GroupGetBannedUsers(GroupDto group);
    Task GroupClear(GroupDto group);
    Task GroupChangeOwnership(GroupPairDto groupPair);
    Task<bool> GroupChangePassword(GroupPasswordDto groupPassword);
    Task<GroupPasswordDto> GroupCreate();
    Task<List<GroupFullInfoDto>> GroupsGetAll();
    Task<List<GroupPairFullInfoDto>> GroupsGetUsersInGroup(GroupDto group);
    Task GroupBanUser(GroupPairDto dto, string reason);
    Task GroupChangeGroupPermissionState(GroupPermissionDto dto);
    Task GroupChangeIndividualPermissionState(GroupPairUserPermissionDto dto);
    Task GroupDelete(GroupDto group);
    Task<bool> GroupJoin(GroupPasswordDto passwordedGroup);
    Task GroupLeave(GroupDto group);
    Task GroupRemoveUser(GroupPairDto groupPair);
    Task GroupUnbanUser(GroupPairDto groupPair);
    Task GroupSetUserInfo(GroupPairUserInfoDto groupPair);
    Task<List<string>> GroupCreateTempInvite(GroupDto group, int amount);

    Task Client_UpdateSystemInfo(SystemInfoDto systemInfo);
    Task Client_ReceiveServerMessage(MessageSeverity messageSeverity, string message);
    Task Client_DownloadReady(Guid requestId);

    Task Client_UserSendOnline(OnlineUserIdentDto dto);
    Task Client_UserSendOffline(UserDto dto);
    Task Client_UserAddClientPair(UserPairDto dto);
    Task Client_UserRemoveClientPair(UserDto dto);
    Task Client_UserUpdateSelfPairPermissions(UserPermissionsDto dto);
    Task Client_UserUpdateOtherPairPermissions(UserPermissionsDto dto);
    Task Client_UserReceiveCharacterData(OnlineUserCharaDataDto dataDto);

    Task Client_GroupSendFullInfo(GroupFullInfoDto groupInfo);
    Task Client_GroupSendInfo(GroupInfoDto groupInfo);
    Task Client_GroupDelete(GroupDto groupDto);
    Task Client_GroupPairJoined(GroupPairFullInfoDto groupPairInfoDto);
    Task Client_GroupPairLeft(GroupPairDto groupPairDto);
    Task Client_GroupChangePermissions(GroupPermissionDto groupPermission);
    Task Client_GroupPairChangePermissions(GroupPairUserPermissionDto permissionDto);
    Task Client_GroupPairChangeUserInfo(GroupPairUserInfoDto userInfo);
}