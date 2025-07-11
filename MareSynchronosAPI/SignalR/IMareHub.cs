﻿using MareSynchronos.API.Data;
using MareSynchronos.API.Data.Enum;
using MareSynchronos.API.Dto;
using MareSynchronos.API.Dto.CharaData;
using MareSynchronos.API.Dto.Group;
using MareSynchronos.API.Dto.User;

namespace MareSynchronos.API.SignalR;

public interface IMareHub
{
    const int ApiVersion = 33;
    const string Path = "/mare";

    Task<bool> CheckClientHealth();

    Task Client_DownloadReady(Guid requestId);
    Task Client_GroupChangePermissions(GroupPermissionDto groupPermission);
    Task Client_GroupDelete(GroupDto groupDto);
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
    Task Client_UpdateUserIndividualPairStatusDto(UserIndividualPairStatusDto dto);
    Task Client_UserUpdateProfile(UserDto dto);
    Task Client_UserUpdateSelfPairPermissions(UserPermissionsDto dto);
    Task Client_UserUpdateDefaultPermissions(DefaultPermissionsDto dto);
    Task Client_GroupChangeUserPairPermissions(GroupPairUserPermissionDto dto);
    Task Client_GposeLobbyJoin(UserData userData);
    Task Client_GposeLobbyLeave(UserData userData);
    Task Client_GposeLobbyPushCharacterData(CharaDataDownloadDto charaDownloadDto);
    Task Client_GposeLobbyPushPoseData(UserData userData, PoseData poseData);
    Task Client_GposeLobbyPushWorldData(UserData userData, WorldData worldData);

    Task Client_UpdateSupporterList(SupporterDto supporterDto);
    Task Client_GroupChat(GroupChatDto groupChatDto);

    Task<ConnectionDto> GetConnectionDto();

    Task GroupBanUser(GroupPairDto dto, string reason);
    Task GroupChangeGroupPermissionState(GroupPermissionDto dto);
    Task GroupChangeOwnership(GroupPairDto groupPair);
    Task<bool> GroupChangePassword(GroupPasswordDto groupPassword);
    Task GroupClear(GroupDto group);
    Task<GroupJoinDto> GroupCreate();
    Task<List<string>> GroupCreateTempInvite(GroupDto group, int amount);
    Task GroupDelete(GroupDto group);
    Task<List<BannedGroupUserDto>> GroupGetBannedUsers(GroupDto group);
    Task<GroupJoinInfoDto> GroupJoin(GroupPasswordDto passwordedGroup);
    Task<bool> GroupJoinFinalize(GroupJoinDto passwordedGroup);
    Task GroupLeave(GroupDto group);
    Task GroupRemoveUser(GroupPairDto groupPair);
    Task GroupSetUserInfo(GroupPairUserInfoDto groupPair);
    Task<List<GroupFullInfoDto>> GroupsGetAll();
    Task GroupUnbanUser(GroupPairDto groupPair);
    Task<int> GroupPrune(GroupDto group, int days, bool execute);

    Task UserAddPair(UserDto user);
    Task UserDelete();
    Task<List<OnlineUserIdentDto>> UserGetOnlinePairs(CensusDataDto? censusDataDto);
    Task<List<UserFullPairDto>> UserGetPairedClients();
    Task<UserProfileDto> UserGetProfile(UserDto dto);
    Task UserPushData(UserCharaDataMessageDto dto);
    Task UserRemovePair(UserDto userDto);
    Task UserReportProfile(UserProfileReportDto userDto);
    Task UserSetProfile(UserProfileDto userDescription);
    Task UserUpdateDefaultPermissions(DefaultPermissionsDto defaultPermissionsDto);
    Task SetBulkPermissions(BulkPermissionsDto dto);

    Task<CharaDataFullDto?> CharaDataCreate();
    Task<CharaDataFullDto?> CharaDataUpdate(CharaDataUpdateDto updateDto);
    Task<bool> CharaDataDelete(string id);
    Task<CharaDataMetaInfoDto?> CharaDataGetMetainfo(string id);
    Task<CharaDataDownloadDto?> CharaDataDownload(string id);
    Task<List<CharaDataFullDto>> CharaDataGetOwn();
    Task<List<CharaDataMetaInfoDto>> CharaDataGetShared();
    Task Client_UserApplyMoodlesByStatus(ApplyMoodlesByStatusDto dto);
    Task<CharaDataFullDto?> CharaDataAttemptRestore(string id);

    Task<string> GposeLobbyCreate();
    Task<List<UserData>> GposeLobbyJoin(string lobbyId);
    Task<bool> GposeLobbyLeave();
    Task GposeLobbyPushCharacterData(CharaDataDownloadDto charaDownloadDto);
    Task GposeLobbyPushPoseData(PoseData poseData);
    Task GposeLobbyPushWorldData(WorldData worldData);

    Task GroupChatServer(GroupChatDto groupChatDto);

    Task Client_MoodlesShare(MoodlesDto moodlesDto);
    Task MoodlesShare(MoodlesDto moodlesDto);

    Task<bool> UpdatePFinder(PFinderDto pFinderDto);
    Task<List<PFinderDto>> RefreshPFinderList(UserDto userDto);
}