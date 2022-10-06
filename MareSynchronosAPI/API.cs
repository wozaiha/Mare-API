namespace MareSynchronos.API
{
    public class Api
    {
        public const int Version = 15;
        public const string Path = "/mare";

        public const string SendFileAbortUpload = "AbortUpload";
        public const string InvokeFileSendFiles = "SendFiles";
        public const string InvokeFileIsUploadFinished = "IsUploadFinished";
        public const string SendFileUploadFileStreamAsync = "UploadFileStreamAsync";
        public const string InvokeGetFilesSizes = "GetFilesSizes";
        public const string SendFileDeleteAllFiles = "DeleteAllFiles";
        public const string InvokeCheckClientHealth = "CheckClientHealth";

        public const string InvokeHeartbeat = "Heartbeat";
        public const string OnUpdateSystemInfo = "OnUpdateSystemInfo";

        public const string InvokeAdminGetOnlineUsers = "AdminGetOnlineUsers";
        public const string InvokeAdminGetBannedUsers = "GetBannedUsers";
        public const string SendAdminUpdateOrAddBannedUser = "UpdateOrAddBannedUser";
        public const string SendAdminDeleteBannedUser = "DeleteBannedUser";
        public const string InvokeAdminGetForbiddenFiles = "GetForbiddenFiles";
        public const string SendAdminUpdateOrAddForbiddenFile = "UpdateOrAddForbiddenFile";
        public const string SendAdminDeleteForbiddenFile = "DeleteForbiddenFile";
        public const string SendAdminChangeModeratorStatus = "ChangeModeratorStatus";

        public const string OnAdminForcedReconnect = "OnForcedReconnect";
        public const string OnAdminUpdateOrAddBannedUser = "OnUpdateOrAddBannedUser";
        public const string OnAdminDeleteBannedUser = "OnDeleteBannedUser";
        public const string OnAdminUpdateOrAddForbiddenFile = "OnUpdateOrAddForbiddenFile";
        public const string OnAdminDeleteForbiddenFile = "OnDeleteForbiddenFile";

        public const string InvokeUserPushCharacterDataToVisibleClients = "PushCharacterDataToVisibleClients";
        public const string InvokeUserGetOnlineCharacters = "GetOnlineCharacters";
        public const string SendUserPairedClientAddition = "SendPairedClientAddition";
        public const string SendUserPairedClientRemoval = "SendPairedClientRemoval";
        public const string SendUserPairedClientPauseChange = "SendPairedClientPauseChange";
        public const string InvokeUserGetPairedClients = "GetPairedClients";
        public const string SendUserDeleteAccount = "DeleteAccount";

        public const string OnUserUpdateClientPairs = "UpdateClientPairs";
        public const string OnUserReceiveCharacterData = "ReceiveCharacterData";
        public const string OnUserRemoveOnlinePairedPlayer = "RemoveOnlinePairedPlayer";
        public const string OnUserAddOnlinePairedPlayer = "AddOnlinePairedPlayer";

        public const string InvokeGroupChangePassword = "GroupChangePassword";
        public const string InvokeGroupCreate = "CreateGroup";
        public const string InvokeGroupGetGroups = "GetGroups";
        public const string InvokeGroupGetUsersInGroup = "GetUsersInGroup";
        public const string SendGroupChangeInviteState = "GroupChangeInviteState";
        public const string SendGroupDelete = "DeleteGroup";
        public const string InvokeGroupJoin = "JoinGroup";
        public const string SendGroupLeave = "LeaveGroup";
        public const string SendGroupPause = "PauseGroup";
        public const string SendGroupRemoveUser = "RemoveUserFromGroup";
        public const string SendGroupChangeOwner = "ChangeOwnerOfGroup";
        public const string SendGroupChangePinned = "ChangedPinnedUserInGroup";
        public const string SendGroupClear = "ClearGroup";
        public const string SendBanUserFromGroup = "BanUserFromGroup";
        public const string InvokeGetBannedUsersForGroup = "GetBannedUsersForGroup";
        public const string SendUnbanUserFromGroup = "UnbanUserFromGroup";
        public const string SendGroupSetModerator = "InvokeGroupSetModerator";

        public const string OnGroupChange = "OnGroupPushChange";
        public const string OnGroupUserChange = "OnGroupUserChange";
    }
}
