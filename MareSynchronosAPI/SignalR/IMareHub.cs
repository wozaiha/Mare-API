using MareSynchronos.API.Data.Enum;
using MareSynchronos.API.Dto;
using MareSynchronos.API.Dto.Group;
using MareSynchronos.API.Dto.User;

namespace MareSynchronos.API.SignalR;

public interface IMareHub
{
    const int ApiVersion = 27;
    const string Path = "/mare";

    Task<bool> CheckClientHealth();

    Task Client_DownloadReady(Guid requestId);

    Task Client_GroupChangePermissions(GroupPermissionDto groupPermission);

    Task Client_GroupDelete(GroupDto groupDto);

    Task Client_GroupPairChangePermissions(GroupPairUserPermissionDto permissionDto);

    Task Client_GroupPairChangeUserInfo(GroupPairUserInfoDto userInfo);

    Task Client_GroupPairJoined(GroupPairFullInfoDto groupPairInfoDto);

    Task Client_GroupPairLeft(GroupPairDto groupPairDto);

    Task Client_GroupSendFullInfo(GroupFullInfoDto groupInfo);

    Task Client_GroupSendInfo(GroupInfoDto groupInfo);

    Task Client_ReceiveServerMessage(MessageSeverity messageSeverity, string message);

    Task Client_UpdateSystemInfo(SystemInfoDto systemInfo);

    Task Client_UserAddClientPair(UserPairDto dto);

    Task Client_UserReceiveCharacterData(OnlineUserCharaDataDto dataDto);

    Task Client_UserReceiveUploadStatus(UserDto dto);

    Task Client_UserRemoveClientPair(UserDto dto);

    Task Client_UserSendOffline(UserDto dto);

    Task Client_UserSendOnline(OnlineUserIdentDto dto);

    Task Client_UserUpdateOtherPairPermissions(UserPermissionsDto dto);

    Task Client_UserUpdateProfile(UserDto dto);

    Task Client_UserUpdateSelfPairPermissions(UserPermissionsDto dto);

    Task Client_UserUpdateDefaultPermissions(DefaultPermissionsDto dto);

    Task<ConnectionDto> GetConnectionDto();

    Task GroupBanUser(GroupPairDto dto, string reason);

    Task GroupChangeGroupPermissionState(GroupPermissionDto dto);

    Task GroupChangeIndividualPermissionState(GroupPairUserPermissionDto dto);

    Task GroupChangeOwnership(GroupPairDto groupPair);

    Task<bool> GroupChangePassword(GroupPasswordDto groupPassword);

    Task GroupClear(GroupDto group);

    Task<GroupPasswordDto> GroupCreate();

    Task<List<string>> GroupCreateTempInvite(GroupDto group, int amount);

    Task GroupDelete(GroupDto group);

    Task<List<BannedGroupUserDto>> GroupGetBannedUsers(GroupDto group);

    Task<bool> GroupJoin(GroupPasswordDto passwordedGroup);

    Task GroupLeave(GroupDto group);

    Task GroupRemoveUser(GroupPairDto groupPair);

    Task GroupSetUserInfo(GroupPairUserInfoDto groupPair);

    Task<List<GroupFullInfoDto>> GroupsGetAll();

    Task<List<GroupPairFullInfoDto>> GroupsGetUsersInGroup(GroupDto group);

    Task GroupUnbanUser(GroupPairDto groupPair);

    Task UserAddPair(UserDto user);

    Task UserDelete();

    Task<List<OnlineUserIdentDto>> UserGetOnlinePairs();

    Task<List<UserPairDto>> UserGetPairedClients();

    Task<UserProfileDto> UserGetProfile(UserDto dto);

    Task UserPushData(UserCharaDataMessageDto dto);

    Task UserRemovePair(UserDto userDto);

    Task UserReportProfile(UserProfileReportDto userDto);

    Task UserSetPairPermissions(UserPermissionsDto userPermissions);

    Task UserSetProfile(UserProfileDto userDescription);
    Task UserUpdateDefaultPermissions(DefaultPermissionsDto defaultPermissionsDto);
}