using MareSynchronos.API.Dto.Group;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MareSynchronos.API.Routes
{
    public enum MessageSeverity
    {
        Information,
        Warning,
        Error
    }
    public interface IMareHub
    {
        const int ApiVersion = 21;
        const string Path = "/mare";

        Task FilesAbortUpload();
        Task<List<OnlineUserDto>> AdminGetOnlineUsers();
        Task AdminChangeModeratorStatus(string uid, bool isModerator);
        Task<bool> CheckClientHealth();
        Task UserDelete();
        Task FilesDeleteAll();
        Task AdminDeleteBannedUser(BannedUserDto dto);
        Task AdminDeleteForbiddenFile(ForbiddenFileDto dto);
        Task<List<BannedUserDto>> AdminGetBannedUsers();
        Task<List<DownloadFileDto>> FilesGetSizes(List<string> hashes);
        Task<List<ForbiddenFileDto>> AdminGetForbiddenFiles();
        Task<List<string>> UserGetOnlineCharacters();
        Task<List<ClientPairDto>> UserGetPairedClients();
        Task<ConnectionDto> GetConnectionDto();
        Task<bool> FilesIsUploadFinished();
        Task UserPushData(CharacterCacheDto characterCache, List<string> visibleCharacterIds);
        Task<List<UploadFileDto>> FilesSend(List<string> fileListHashes);
        Task UserAddPair(string uid);
        Task UserChangePairPauseStatus(string otherUserUid, bool isPaused);
        Task UserRemovePair(string otherUserUid);
        Task AdminUpdateOrAddBannedUser(BannedUserDto dto);
        Task AdminUpdateOrAddForbiddenFile(ForbiddenFileDto dto);
        Task FilesUploadStreamAsync(string hash, IAsyncEnumerable<byte[]> fileContent);

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

        Task Client_UserUpdateClientPairs(ClientPairDto clientPairDto);
        Task Client_UpdateSystemInfo(SystemInfoDto systemInfo);
        Task Client_UserReceiveCharacterData(CharacterCacheDto clientPairDto, string uid);
        Task Client_UserChangePairedPlayer(CharacterDto dto);
        Task Client_AdminForcedReconnect();
        Task Client_AdminDeleteBannedUser(BannedUserDto dto);
        Task Client_AdminDeleteForbiddenFile(ForbiddenFileDto dto);
        Task Client_AdminUpdateOrAddBannedUser(BannedUserDto dto);
        Task Client_AdminUpdateOrAddForbiddenFile(ForbiddenFileDto dto);
        Task Client_ReceiveServerMessage(MessageSeverity messageSeverity, string message);
        Task Client_DownloadReady(Guid requestId);

        Task Client_GroupSendFullInfo(GroupFullInfoDto groupInfo);
        Task Client_GroupSendInfo(GroupInfoDto groupInfo);
        Task Client_GroupDelete(GroupDto groupDto);
        Task Client_GroupPairJoined(GroupPairFullInfoDto groupPairInfoDto);
        Task Client_GroupPairLeft(GroupPairDto groupPairDto);
        Task Client_GroupChangePermissions(GroupPermissionDto groupPermission);
        Task Client_GroupPairChangePermissions(GroupPairUserPermissionDto permissionDto);
        Task Client_GroupPairChangeUserInfo(GroupPairUserInfoDto userInfo);
    }

    public interface IMareHubClient : IMareHub
    {
        void OnUserUpdateClientPairs(Action<ClientPairDto> act);
        void OnUpdateSystemInfo(Action<SystemInfoDto> act);
        void OnUserReceiveCharacterData(Action<CharacterCacheDto, string> act);
        void OnUserChangePairedPlayer(Action<string, bool> act);
        void OnGroupChange(Action<GroupFullInfoDto> act);
        void OnGroupUserChange(Action<GroupPairDto> act);
        void OnAdminForcedReconnect(Action act);
        void OnAdminDeleteBannedUser(Action<BannedUserDto> dto);
        void OnAdminDeleteForbiddenFile(Action<ForbiddenFileDto> act);
        void OnAdminUpdateOrAddBannedUser(Action<BannedUserDto> dto);
        void OnAdminUpdateOrAddForbiddenFile(Action<ForbiddenFileDto> dto);
        void OnReceiveServerMessage(Action<MessageSeverity, string> act);
        void OnDownloadReady(Action<Guid> act);
    }
}