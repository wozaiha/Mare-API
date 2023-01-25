using MareSynchronos.API.Data.Enum;
using MareSynchronos.API.Dto;
using MareSynchronos.API.Dto.Admin;
using MareSynchronos.API.Dto.Files;
using MareSynchronos.API.Dto.Group;
using MareSynchronos.API.Dto.User;

namespace MareSynchronos.API.SignalR;

public interface IMareHubClient : IMareHub
{
    void OnUpdateSystemInfo(Action<SystemInfoDto> act);
    void OnReceiveServerMessage(Action<MessageSeverity, string> act);
    void OnDownloadReady(Action<Guid> act);

    void OnAdminForcedReconnect(Action act);
    void OnAdminDeleteBannedUser(Action<BannedUserDto> act);
    void OnAdminDeleteForbiddenFile(Action<ForbiddenFileDto> act);
    void OnAdminUpdateOrAddBannedUser(Action<BannedUserDto> act);
    void OnAdminUpdateOrAddForbiddenFile(Action<ForbiddenFileDto> act);

    void OnUserSendOnline(Action<OnlineUserIdentDto> act);
    void OnUserSendOffline(Action<UserDto> act);
    void OnUserAddClientPair(Action<UserPairDto> act);
    void OnUserRemoveClientPair(Action<UserDto> act);
    void OnUserUpdateSelfPairPermissions(Action<UserPermissionsDto> act);
    void OnUserUpdateOtherPairPermissions(Action<UserPermissionsDto> act);
    void OnUserReceiveCharacterData(Action<OnlineUserCharaDataDto> act);

    void OnGroupSendFullInfo(Action<GroupFullInfoDto> act);
    void OnGroupSendInfo(Action<GroupInfoDto> act);
    void OnGroupDelete(Action<GroupDto> act);
    void OnGroupPairJoined(Action<GroupPairFullInfoDto> act);
    void OnGroupPairLeft(Action<GroupPairDto> act);
    void OnGroupChangePermissions(Action<GroupPermissionDto> act);
    void OnGroupPairChangePermissions(Action<GroupPairUserPermissionDto> act);
    void OnGroupPairChangeUserInfo(Action<GroupPairUserInfoDto> act);
}