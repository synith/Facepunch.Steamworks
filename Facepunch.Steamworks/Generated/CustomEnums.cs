using System;
using System.Runtime.InteropServices;
using System.Linq;
using Steamworks.Data;
using System.Threading.Tasks;

namespace Steamworks
{
	public enum CallbackType
	{
		SteamServersConnected = 101,
		SteamServerConnectFailure = 102,
		SteamServersDisconnected = 103,
		ClientGameServerDeny = 113,
		GSPolicyResponse = 115,
		IPCFailure = 117,
		LicensesUpdated = 125,
		ValidateAuthTicketResponse = 143,
		MicroTxnAuthorizationResponse = 152,
		EncryptedAppTicketResponse = 154,
		GetAuthSessionTicketResponse = 163,
		GameWebCallback = 164,
		StoreAuthURLResponse = 165,
		MarketEligibilityResponse = 166,
		DurationControl = 167,
		GetTicketForWebApiResponse = 168,
		GSClientApprove = 201,
		GSClientDeny = 202,
		GSClientKick = 203,
		GSClientAchievementStatus = 206,
		GSGameplayStats = 207,
		GSClientGroupStatus = 208,
		GSReputation = 209,
		AssociateWithClanResult = 210,
		ComputeNewPlayerCompatibilityResult = 211,
		PersonaStateChange = 304,
		GameOverlayActivated = 331,
		GameServerChangeRequested = 332,
		GameLobbyJoinRequested = 333,
		AvatarImageLoaded = 334,
		ClanOfficerListResponse = 335,
		FriendRichPresenceUpdate = 336,
		GameRichPresenceJoinRequested = 337,
		GameConnectedClanChatMsg = 338,
		GameConnectedChatJoin = 339,
		GameConnectedChatLeave = 340,
		DownloadClanActivityCountsResult = 341,
		JoinClanChatRoomCompletionResult = 342,
		GameConnectedFriendChatMsg = 343,
		FriendsGetFollowerCount = 344,
		FriendsIsFollowing = 345,
		FriendsEnumerateFollowingList = 346,
		SetPersonaNameResponse = 347,
		UnreadChatMessagesChanged = 348,
		OverlayBrowserProtocolNavigation = 349,
		EquippedProfileItemsChanged = 350,
		EquippedProfileItems = 351,
		FavoritesListChanged = 502,
		LobbyInvite = 503,
		LobbyEnter = 504,
		LobbyDataUpdate = 505,
		LobbyChatUpdate = 506,
		LobbyChatMsg = 507,
		LobbyGameCreated = 509,
		LobbyMatchList = 510,
		LobbyKicked = 512,
		LobbyCreated = 513,
		PSNGameBootInviteResult = 515,
		FavoritesListAccountsUpdated = 516,
		IPCountry = 701,
		LowBatteryPower = 702,
		SteamAPICallCompleted = 703,
		SteamShutdown = 704,
		CheckFileSignature = 705,
		GamepadTextInputDismissed = 714,
		AppResumingFromSuspend = 736,
		FloatingGamepadTextInputDismissed = 738,
		FilterTextDictionaryChanged = 739,
		DlcInstalled = 1005,
		NewUrlLaunchParameters = 1014,
		AppProofOfPurchaseKeyResponse = 1021,
		FileDetailsResult = 1023,
		TimedTrialStatus = 1030,
		UserStatsReceived = 1101,
		UserStatsStored = 1102,
		UserAchievementStored = 1103,
		LeaderboardFindResult = 1104,
		LeaderboardScoresDownloaded = 1105,
		LeaderboardScoreUploaded = 1106,
		NumberOfCurrentPlayers = 1107,
		UserStatsUnloaded = 1108,
		GSStatsUnloaded = 1108,
		UserAchievementIconFetched = 1109,
		GlobalAchievementPercentagesReady = 1110,
		LeaderboardUGCSet = 1111,
		// PS3TrophiesInstalled = 1112,
		GlobalStatsReceived = 1112,
		// SocketStatusCallback = 1201,
		P2PSessionRequest = 1202,
		P2PSessionConnectFail = 1203,
		SteamNetConnectionStatusChangedCallback = 1221,
		SteamNetAuthenticationStatus = 1222,
		SteamNetworkingFakeIPResult = 1223,
		SteamNetworkingMessagesSessionRequest = 1251,
		SteamNetworkingMessagesSessionFailed = 1252,
		SteamRelayNetworkStatus = 1281,
		RemoteStorageFileShareResult = 1307,
		RemoteStoragePublishFileResult = 1309,
		RemoteStorageDeletePublishedFileResult = 1311,
		RemoteStorageEnumerateUserPublishedFilesResult = 1312,
		RemoteStorageSubscribePublishedFileResult = 1313,
		RemoteStorageEnumerateUserSubscribedFilesResult = 1314,
		RemoteStorageUnsubscribePublishedFileResult = 1315,
		RemoteStorageUpdatePublishedFileResult = 1316,
		RemoteStorageDownloadUGCResult = 1317,
		RemoteStorageGetPublishedFileDetailsResult = 1318,
		RemoteStorageEnumerateWorkshopFilesResult = 1319,
		RemoteStorageGetPublishedItemVoteDetailsResult = 1320,
		RemoteStoragePublishedFileSubscribed = 1321,
		RemoteStoragePublishedFileUnsubscribed = 1322,
		RemoteStoragePublishedFileDeleted = 1323,
		RemoteStorageUpdateUserPublishedItemVoteResult = 1324,
		RemoteStorageUserVoteDetails = 1325,
		RemoteStorageEnumerateUserSharedWorkshopFilesResult = 1326,
		RemoteStorageSetUserPublishedFileActionResult = 1327,
		RemoteStorageEnumeratePublishedFilesByUserActionResult = 1328,
		RemoteStoragePublishFileProgress = 1329,
		RemoteStoragePublishedFileUpdated = 1330,
		RemoteStorageFileWriteAsyncComplete = 1331,
		RemoteStorageFileReadAsyncComplete = 1332,
		RemoteStorageLocalFileChange = 1333,
		GSStatsReceived = 1800,
		GSStatsStored = 1801,
		HTTPRequestCompleted = 2101,
		HTTPRequestHeadersReceived = 2102,
		HTTPRequestDataReceived = 2103,
		ScreenshotReady = 2301,
		ScreenshotRequested = 2302,
		SteamInputDeviceConnected = 2801,
		SteamInputDeviceDisconnected = 2802,
		SteamInputConfigurationLoaded = 2803,
		SteamInputGamepadSlotChange = 2804,
		SteamUGCQueryCompleted = 3401,
		SteamUGCRequestUGCDetailsResult = 3402,
		CreateItemResult = 3403,
		SubmitItemUpdateResult = 3404,
		ItemInstalled = 3405,
		DownloadItemResult = 3406,
		UserFavoriteItemsListChanged = 3407,
		SetUserItemVoteResult = 3408,
		GetUserItemVoteResult = 3409,
		StartPlaytimeTrackingResult = 3410,
		StopPlaytimeTrackingResult = 3411,
		AddUGCDependencyResult = 3412,
		RemoveUGCDependencyResult = 3413,
		AddAppDependencyResult = 3414,
		RemoveAppDependencyResult = 3415,
		GetAppDependenciesResult = 3416,
		DeleteItemResult = 3417,
		UserSubscribedItemsListChanged = 3418,
		WorkshopEULAStatus = 3420,
		PlaybackStatusHasChanged = 4001,
		VolumeHasChanged = 4002,
		MusicPlayerWantsVolume = 4011,
		MusicPlayerSelectsQueueEntry = 4012,
		MusicPlayerSelectsPlaylistEntry = 4013,
		MusicPlayerRemoteWillActivate = 4101,
		MusicPlayerRemoteWillDeactivate = 4102,
		MusicPlayerRemoteToFront = 4103,
		MusicPlayerWillQuit = 4104,
		MusicPlayerWantsPlay = 4105,
		MusicPlayerWantsPause = 4106,
		MusicPlayerWantsPlayPrevious = 4107,
		MusicPlayerWantsPlayNext = 4108,
		MusicPlayerWantsShuffled = 4109,
		MusicPlayerWantsLooped = 4110,
		MusicPlayerWantsPlayingRepeatStatus = 4114,
		HTML_BrowserReady = 4501,
		HTML_NeedsPaint = 4502,
		HTML_StartRequest = 4503,
		HTML_CloseBrowser = 4504,
		HTML_URLChanged = 4505,
		HTML_FinishedRequest = 4506,
		HTML_OpenLinkInNewTab = 4507,
		HTML_ChangedTitle = 4508,
		HTML_SearchResults = 4509,
		HTML_CanGoBackAndForward = 4510,
		HTML_HorizontalScroll = 4511,
		HTML_VerticalScroll = 4512,
		HTML_LinkAtPosition = 4513,
		HTML_JSAlert = 4514,
		HTML_JSConfirm = 4515,
		HTML_FileOpenDialog = 4516,
		HTML_NewWindow = 4521,
		HTML_SetCursor = 4522,
		HTML_StatusText = 4523,
		HTML_ShowToolTip = 4524,
		HTML_UpdateToolTip = 4525,
		HTML_HideToolTip = 4526,
		HTML_BrowserRestarted = 4527,
		GetVideoURLResult = 4611,
		GetOPFSettingsResult = 4624,
		SteamInventoryResultReady = 4700,
		SteamInventoryFullUpdate = 4701,
		SteamInventoryDefinitionUpdate = 4702,
		SteamInventoryEligiblePromoItemDefIDs = 4703,
		SteamInventoryStartPurchaseResult = 4704,
		SteamInventoryRequestPricesResult = 4705,
		SteamParentalSettingsChanged = 5001,
		SearchForGameProgressCallback = 5201,
		SearchForGameResultCallback = 5202,
		RequestPlayersForGameProgressCallback = 5211,
		RequestPlayersForGameResultCallback = 5212,
		RequestPlayersForGameFinalResultCallback = 5213,
		SubmitPlayerResultResultCallback = 5214,
		EndGameResultCallback = 5215,
		JoinPartyCallback = 5301,
		CreateBeaconCallback = 5302,
		ReservationNotificationCallback = 5303,
		ChangeNumOpenSlotsCallback = 5304,
		AvailableBeaconLocationsUpdated = 5305,
		ActiveBeaconsUpdated = 5306,
		SteamRemotePlaySessionConnected = 5701,
		SteamRemotePlaySessionDisconnected = 5702,
		SteamRemotePlayTogetherGuestInvite = 5703,
	}
	internal static partial class CallbackTypeFactory
	{
		internal static System.Collections.Generic.Dictionary<CallbackType, System.Type> All = new System.Collections.Generic.Dictionary<CallbackType, System.Type>
		{
			{ CallbackType.SteamServersConnected, typeof( SteamServersConnected_t )},
			{ CallbackType.SteamServerConnectFailure, typeof( SteamServerConnectFailure_t )},
			{ CallbackType.SteamServersDisconnected, typeof( SteamServersDisconnected_t )},
			{ CallbackType.ClientGameServerDeny, typeof( ClientGameServerDeny_t )},
			{ CallbackType.GSPolicyResponse, typeof( GSPolicyResponse_t )},
			{ CallbackType.IPCFailure, typeof( IPCFailure_t )},
			{ CallbackType.LicensesUpdated, typeof( LicensesUpdated_t )},
			{ CallbackType.ValidateAuthTicketResponse, typeof( ValidateAuthTicketResponse_t )},
			{ CallbackType.MicroTxnAuthorizationResponse, typeof( MicroTxnAuthorizationResponse_t )},
			{ CallbackType.EncryptedAppTicketResponse, typeof( EncryptedAppTicketResponse_t )},
			{ CallbackType.GetAuthSessionTicketResponse, typeof( GetAuthSessionTicketResponse_t )},
			{ CallbackType.GameWebCallback, typeof( GameWebCallback_t )},
			{ CallbackType.StoreAuthURLResponse, typeof( StoreAuthURLResponse_t )},
			{ CallbackType.MarketEligibilityResponse, typeof( MarketEligibilityResponse_t )},
			{ CallbackType.DurationControl, typeof( DurationControl_t )},
			{ CallbackType.GetTicketForWebApiResponse, typeof( GetTicketForWebApiResponse_t )},
			{ CallbackType.GSClientApprove, typeof( GSClientApprove_t )},
			{ CallbackType.GSClientDeny, typeof( GSClientDeny_t )},
			{ CallbackType.GSClientKick, typeof( GSClientKick_t )},
			{ CallbackType.GSClientAchievementStatus, typeof( GSClientAchievementStatus_t )},
			{ CallbackType.GSGameplayStats, typeof( GSGameplayStats_t )},
			{ CallbackType.GSClientGroupStatus, typeof( GSClientGroupStatus_t )},
			{ CallbackType.GSReputation, typeof( GSReputation_t )},
			{ CallbackType.AssociateWithClanResult, typeof( AssociateWithClanResult_t )},
			{ CallbackType.ComputeNewPlayerCompatibilityResult, typeof( ComputeNewPlayerCompatibilityResult_t )},
			{ CallbackType.PersonaStateChange, typeof( PersonaStateChange_t )},
			{ CallbackType.GameOverlayActivated, typeof( GameOverlayActivated_t )},
			{ CallbackType.GameServerChangeRequested, typeof( GameServerChangeRequested_t )},
			{ CallbackType.GameLobbyJoinRequested, typeof( GameLobbyJoinRequested_t )},
			{ CallbackType.AvatarImageLoaded, typeof( AvatarImageLoaded_t )},
			{ CallbackType.ClanOfficerListResponse, typeof( ClanOfficerListResponse_t )},
			{ CallbackType.FriendRichPresenceUpdate, typeof( FriendRichPresenceUpdate_t )},
			{ CallbackType.GameRichPresenceJoinRequested, typeof( GameRichPresenceJoinRequested_t )},
			{ CallbackType.GameConnectedClanChatMsg, typeof( GameConnectedClanChatMsg_t )},
			{ CallbackType.GameConnectedChatJoin, typeof( GameConnectedChatJoin_t )},
			{ CallbackType.GameConnectedChatLeave, typeof( GameConnectedChatLeave_t )},
			{ CallbackType.DownloadClanActivityCountsResult, typeof( DownloadClanActivityCountsResult_t )},
			{ CallbackType.JoinClanChatRoomCompletionResult, typeof( JoinClanChatRoomCompletionResult_t )},
			{ CallbackType.GameConnectedFriendChatMsg, typeof( GameConnectedFriendChatMsg_t )},
			{ CallbackType.FriendsGetFollowerCount, typeof( FriendsGetFollowerCount_t )},
			{ CallbackType.FriendsIsFollowing, typeof( FriendsIsFollowing_t )},
			{ CallbackType.FriendsEnumerateFollowingList, typeof( FriendsEnumerateFollowingList_t )},
			{ CallbackType.SetPersonaNameResponse, typeof( SetPersonaNameResponse_t )},
			{ CallbackType.UnreadChatMessagesChanged, typeof( UnreadChatMessagesChanged_t )},
			{ CallbackType.OverlayBrowserProtocolNavigation, typeof( OverlayBrowserProtocolNavigation_t )},
			{ CallbackType.EquippedProfileItemsChanged, typeof( EquippedProfileItemsChanged_t )},
			{ CallbackType.EquippedProfileItems, typeof( EquippedProfileItems_t )},
			{ CallbackType.FavoritesListChanged, typeof( FavoritesListChanged_t )},
			{ CallbackType.LobbyInvite, typeof( LobbyInvite_t )},
			{ CallbackType.LobbyEnter, typeof( LobbyEnter_t )},
			{ CallbackType.LobbyDataUpdate, typeof( LobbyDataUpdate_t )},
			{ CallbackType.LobbyChatUpdate, typeof( LobbyChatUpdate_t )},
			{ CallbackType.LobbyChatMsg, typeof( LobbyChatMsg_t )},
			{ CallbackType.LobbyGameCreated, typeof( LobbyGameCreated_t )},
			{ CallbackType.LobbyMatchList, typeof( LobbyMatchList_t )},
			{ CallbackType.LobbyKicked, typeof( LobbyKicked_t )},
			{ CallbackType.LobbyCreated, typeof( LobbyCreated_t )},
			{ CallbackType.PSNGameBootInviteResult, typeof( PSNGameBootInviteResult_t )},
			{ CallbackType.FavoritesListAccountsUpdated, typeof( FavoritesListAccountsUpdated_t )},
			{ CallbackType.IPCountry, typeof( IPCountry_t )},
			{ CallbackType.LowBatteryPower, typeof( LowBatteryPower_t )},
			{ CallbackType.SteamAPICallCompleted, typeof( SteamAPICallCompleted_t )},
			{ CallbackType.SteamShutdown, typeof( SteamShutdown_t )},
			{ CallbackType.CheckFileSignature, typeof( CheckFileSignature_t )},
			{ CallbackType.GamepadTextInputDismissed, typeof( GamepadTextInputDismissed_t )},
			{ CallbackType.AppResumingFromSuspend, typeof( AppResumingFromSuspend_t )},
			{ CallbackType.FloatingGamepadTextInputDismissed, typeof( FloatingGamepadTextInputDismissed_t )},
			{ CallbackType.FilterTextDictionaryChanged, typeof( FilterTextDictionaryChanged_t )},
			{ CallbackType.DlcInstalled, typeof( DlcInstalled_t )},
			{ CallbackType.NewUrlLaunchParameters, typeof( NewUrlLaunchParameters_t )},
			{ CallbackType.AppProofOfPurchaseKeyResponse, typeof( AppProofOfPurchaseKeyResponse_t )},
			{ CallbackType.FileDetailsResult, typeof( FileDetailsResult_t )},
			{ CallbackType.TimedTrialStatus, typeof( TimedTrialStatus_t )},
			{ CallbackType.UserStatsReceived, typeof( UserStatsReceived_t )},
			{ CallbackType.UserStatsStored, typeof( UserStatsStored_t )},
			{ CallbackType.UserAchievementStored, typeof( UserAchievementStored_t )},
			{ CallbackType.LeaderboardFindResult, typeof( LeaderboardFindResult_t )},
			{ CallbackType.LeaderboardScoresDownloaded, typeof( LeaderboardScoresDownloaded_t )},
			{ CallbackType.LeaderboardScoreUploaded, typeof( LeaderboardScoreUploaded_t )},
			{ CallbackType.NumberOfCurrentPlayers, typeof( NumberOfCurrentPlayers_t )},
			{ CallbackType.UserStatsUnloaded, typeof( UserStatsUnloaded_t )},
			// { CallbackType.GSStatsUnloaded, typeof( GSStatsUnloaded_t )},
			{ CallbackType.UserAchievementIconFetched, typeof( UserAchievementIconFetched_t )},
			{ CallbackType.GlobalAchievementPercentagesReady, typeof( GlobalAchievementPercentagesReady_t )},
			{ CallbackType.LeaderboardUGCSet, typeof( LeaderboardUGCSet_t )},
			{ CallbackType.GlobalStatsReceived, typeof( GlobalStatsReceived_t )},
			{ CallbackType.P2PSessionRequest, typeof( P2PSessionRequest_t )},
			{ CallbackType.P2PSessionConnectFail, typeof( P2PSessionConnectFail_t )},
			{ CallbackType.SteamNetConnectionStatusChangedCallback, typeof( SteamNetConnectionStatusChangedCallback_t )},
			{ CallbackType.SteamNetAuthenticationStatus, typeof( SteamNetAuthenticationStatus_t )},
			{ CallbackType.SteamNetworkingFakeIPResult, typeof( SteamNetworkingFakeIPResult_t )},
			{ CallbackType.SteamNetworkingMessagesSessionRequest, typeof( SteamNetworkingMessagesSessionRequest_t )},
			{ CallbackType.SteamNetworkingMessagesSessionFailed, typeof( SteamNetworkingMessagesSessionFailed_t )},
			{ CallbackType.SteamRelayNetworkStatus, typeof( SteamRelayNetworkStatus_t )},
			{ CallbackType.RemoteStorageFileShareResult, typeof( RemoteStorageFileShareResult_t )},
			{ CallbackType.RemoteStoragePublishFileResult, typeof( RemoteStoragePublishFileResult_t )},
			{ CallbackType.RemoteStorageDeletePublishedFileResult, typeof( RemoteStorageDeletePublishedFileResult_t )},
			{ CallbackType.RemoteStorageEnumerateUserPublishedFilesResult, typeof( RemoteStorageEnumerateUserPublishedFilesResult_t )},
			{ CallbackType.RemoteStorageSubscribePublishedFileResult, typeof( RemoteStorageSubscribePublishedFileResult_t )},
			{ CallbackType.RemoteStorageEnumerateUserSubscribedFilesResult, typeof( RemoteStorageEnumerateUserSubscribedFilesResult_t )},
			{ CallbackType.RemoteStorageUnsubscribePublishedFileResult, typeof( RemoteStorageUnsubscribePublishedFileResult_t )},
			{ CallbackType.RemoteStorageUpdatePublishedFileResult, typeof( RemoteStorageUpdatePublishedFileResult_t )},
			{ CallbackType.RemoteStorageDownloadUGCResult, typeof( RemoteStorageDownloadUGCResult_t )},
			{ CallbackType.RemoteStorageGetPublishedFileDetailsResult, typeof( RemoteStorageGetPublishedFileDetailsResult_t )},
			{ CallbackType.RemoteStorageEnumerateWorkshopFilesResult, typeof( RemoteStorageEnumerateWorkshopFilesResult_t )},
			{ CallbackType.RemoteStorageGetPublishedItemVoteDetailsResult, typeof( RemoteStorageGetPublishedItemVoteDetailsResult_t )},
			{ CallbackType.RemoteStoragePublishedFileSubscribed, typeof( RemoteStoragePublishedFileSubscribed_t )},
			{ CallbackType.RemoteStoragePublishedFileUnsubscribed, typeof( RemoteStoragePublishedFileUnsubscribed_t )},
			{ CallbackType.RemoteStoragePublishedFileDeleted, typeof( RemoteStoragePublishedFileDeleted_t )},
			{ CallbackType.RemoteStorageUpdateUserPublishedItemVoteResult, typeof( RemoteStorageUpdateUserPublishedItemVoteResult_t )},
			{ CallbackType.RemoteStorageUserVoteDetails, typeof( RemoteStorageUserVoteDetails_t )},
			{ CallbackType.RemoteStorageEnumerateUserSharedWorkshopFilesResult, typeof( RemoteStorageEnumerateUserSharedWorkshopFilesResult_t )},
			{ CallbackType.RemoteStorageSetUserPublishedFileActionResult, typeof( RemoteStorageSetUserPublishedFileActionResult_t )},
			{ CallbackType.RemoteStorageEnumeratePublishedFilesByUserActionResult, typeof( RemoteStorageEnumeratePublishedFilesByUserActionResult_t )},
			{ CallbackType.RemoteStoragePublishFileProgress, typeof( RemoteStoragePublishFileProgress_t )},
			{ CallbackType.RemoteStoragePublishedFileUpdated, typeof( RemoteStoragePublishedFileUpdated_t )},
			{ CallbackType.RemoteStorageFileWriteAsyncComplete, typeof( RemoteStorageFileWriteAsyncComplete_t )},
			{ CallbackType.RemoteStorageFileReadAsyncComplete, typeof( RemoteStorageFileReadAsyncComplete_t )},
			{ CallbackType.RemoteStorageLocalFileChange, typeof( RemoteStorageLocalFileChange_t )},
			{ CallbackType.GSStatsReceived, typeof( GSStatsReceived_t )},
			{ CallbackType.GSStatsStored, typeof( GSStatsStored_t )},
			{ CallbackType.HTTPRequestCompleted, typeof( HTTPRequestCompleted_t )},
			{ CallbackType.HTTPRequestHeadersReceived, typeof( HTTPRequestHeadersReceived_t )},
			{ CallbackType.HTTPRequestDataReceived, typeof( HTTPRequestDataReceived_t )},
			{ CallbackType.ScreenshotReady, typeof( ScreenshotReady_t )},
			{ CallbackType.ScreenshotRequested, typeof( ScreenshotRequested_t )},
			{ CallbackType.SteamInputDeviceConnected, typeof( SteamInputDeviceConnected_t )},
			{ CallbackType.SteamInputDeviceDisconnected, typeof( SteamInputDeviceDisconnected_t )},
			{ CallbackType.SteamInputConfigurationLoaded, typeof( SteamInputConfigurationLoaded_t )},
			{ CallbackType.SteamInputGamepadSlotChange, typeof( SteamInputGamepadSlotChange_t )},
			{ CallbackType.SteamUGCQueryCompleted, typeof( SteamUGCQueryCompleted_t )},
			{ CallbackType.SteamUGCRequestUGCDetailsResult, typeof( SteamUGCRequestUGCDetailsResult_t )},
			{ CallbackType.CreateItemResult, typeof( CreateItemResult_t )},
			{ CallbackType.SubmitItemUpdateResult, typeof( SubmitItemUpdateResult_t )},
			{ CallbackType.ItemInstalled, typeof( ItemInstalled_t )},
			{ CallbackType.DownloadItemResult, typeof( DownloadItemResult_t )},
			{ CallbackType.UserFavoriteItemsListChanged, typeof( UserFavoriteItemsListChanged_t )},
			{ CallbackType.SetUserItemVoteResult, typeof( SetUserItemVoteResult_t )},
			{ CallbackType.GetUserItemVoteResult, typeof( GetUserItemVoteResult_t )},
			{ CallbackType.StartPlaytimeTrackingResult, typeof( StartPlaytimeTrackingResult_t )},
			{ CallbackType.StopPlaytimeTrackingResult, typeof( StopPlaytimeTrackingResult_t )},
			{ CallbackType.AddUGCDependencyResult, typeof( AddUGCDependencyResult_t )},
			{ CallbackType.RemoveUGCDependencyResult, typeof( RemoveUGCDependencyResult_t )},
			{ CallbackType.AddAppDependencyResult, typeof( AddAppDependencyResult_t )},
			{ CallbackType.RemoveAppDependencyResult, typeof( RemoveAppDependencyResult_t )},
			{ CallbackType.GetAppDependenciesResult, typeof( GetAppDependenciesResult_t )},
			{ CallbackType.DeleteItemResult, typeof( DeleteItemResult_t )},
			{ CallbackType.UserSubscribedItemsListChanged, typeof( UserSubscribedItemsListChanged_t )},
			{ CallbackType.WorkshopEULAStatus, typeof( WorkshopEULAStatus_t )},
			{ CallbackType.PlaybackStatusHasChanged, typeof( PlaybackStatusHasChanged_t )},
			{ CallbackType.VolumeHasChanged, typeof( VolumeHasChanged_t )},
			{ CallbackType.MusicPlayerWantsVolume, typeof( MusicPlayerWantsVolume_t )},
			{ CallbackType.MusicPlayerSelectsQueueEntry, typeof( MusicPlayerSelectsQueueEntry_t )},
			{ CallbackType.MusicPlayerSelectsPlaylistEntry, typeof( MusicPlayerSelectsPlaylistEntry_t )},
			{ CallbackType.MusicPlayerRemoteWillActivate, typeof( MusicPlayerRemoteWillActivate_t )},
			{ CallbackType.MusicPlayerRemoteWillDeactivate, typeof( MusicPlayerRemoteWillDeactivate_t )},
			{ CallbackType.MusicPlayerRemoteToFront, typeof( MusicPlayerRemoteToFront_t )},
			{ CallbackType.MusicPlayerWillQuit, typeof( MusicPlayerWillQuit_t )},
			{ CallbackType.MusicPlayerWantsPlay, typeof( MusicPlayerWantsPlay_t )},
			{ CallbackType.MusicPlayerWantsPause, typeof( MusicPlayerWantsPause_t )},
			{ CallbackType.MusicPlayerWantsPlayPrevious, typeof( MusicPlayerWantsPlayPrevious_t )},
			{ CallbackType.MusicPlayerWantsPlayNext, typeof( MusicPlayerWantsPlayNext_t )},
			{ CallbackType.MusicPlayerWantsShuffled, typeof( MusicPlayerWantsShuffled_t )},
			{ CallbackType.MusicPlayerWantsLooped, typeof( MusicPlayerWantsLooped_t )},
			{ CallbackType.MusicPlayerWantsPlayingRepeatStatus, typeof( MusicPlayerWantsPlayingRepeatStatus_t )},
			{ CallbackType.HTML_BrowserReady, typeof( HTML_BrowserReady_t )},
			{ CallbackType.HTML_NeedsPaint, typeof( HTML_NeedsPaint_t )},
			{ CallbackType.HTML_StartRequest, typeof( HTML_StartRequest_t )},
			{ CallbackType.HTML_CloseBrowser, typeof( HTML_CloseBrowser_t )},
			{ CallbackType.HTML_URLChanged, typeof( HTML_URLChanged_t )},
			{ CallbackType.HTML_FinishedRequest, typeof( HTML_FinishedRequest_t )},
			{ CallbackType.HTML_OpenLinkInNewTab, typeof( HTML_OpenLinkInNewTab_t )},
			{ CallbackType.HTML_ChangedTitle, typeof( HTML_ChangedTitle_t )},
			{ CallbackType.HTML_SearchResults, typeof( HTML_SearchResults_t )},
			{ CallbackType.HTML_CanGoBackAndForward, typeof( HTML_CanGoBackAndForward_t )},
			{ CallbackType.HTML_HorizontalScroll, typeof( HTML_HorizontalScroll_t )},
			{ CallbackType.HTML_VerticalScroll, typeof( HTML_VerticalScroll_t )},
			{ CallbackType.HTML_LinkAtPosition, typeof( HTML_LinkAtPosition_t )},
			{ CallbackType.HTML_JSAlert, typeof( HTML_JSAlert_t )},
			{ CallbackType.HTML_JSConfirm, typeof( HTML_JSConfirm_t )},
			{ CallbackType.HTML_FileOpenDialog, typeof( HTML_FileOpenDialog_t )},
			{ CallbackType.HTML_NewWindow, typeof( HTML_NewWindow_t )},
			{ CallbackType.HTML_SetCursor, typeof( HTML_SetCursor_t )},
			{ CallbackType.HTML_StatusText, typeof( HTML_StatusText_t )},
			{ CallbackType.HTML_ShowToolTip, typeof( HTML_ShowToolTip_t )},
			{ CallbackType.HTML_UpdateToolTip, typeof( HTML_UpdateToolTip_t )},
			{ CallbackType.HTML_HideToolTip, typeof( HTML_HideToolTip_t )},
			{ CallbackType.HTML_BrowserRestarted, typeof( HTML_BrowserRestarted_t )},
			{ CallbackType.GetVideoURLResult, typeof( GetVideoURLResult_t )},
			{ CallbackType.GetOPFSettingsResult, typeof( GetOPFSettingsResult_t )},
			{ CallbackType.SteamInventoryResultReady, typeof( SteamInventoryResultReady_t )},
			{ CallbackType.SteamInventoryFullUpdate, typeof( SteamInventoryFullUpdate_t )},
			{ CallbackType.SteamInventoryDefinitionUpdate, typeof( SteamInventoryDefinitionUpdate_t )},
			{ CallbackType.SteamInventoryEligiblePromoItemDefIDs, typeof( SteamInventoryEligiblePromoItemDefIDs_t )},
			{ CallbackType.SteamInventoryStartPurchaseResult, typeof( SteamInventoryStartPurchaseResult_t )},
			{ CallbackType.SteamInventoryRequestPricesResult, typeof( SteamInventoryRequestPricesResult_t )},
			{ CallbackType.SteamParentalSettingsChanged, typeof( SteamParentalSettingsChanged_t )},
			{ CallbackType.SearchForGameProgressCallback, typeof( SearchForGameProgressCallback_t )},
			{ CallbackType.SearchForGameResultCallback, typeof( SearchForGameResultCallback_t )},
			{ CallbackType.RequestPlayersForGameProgressCallback, typeof( RequestPlayersForGameProgressCallback_t )},
			{ CallbackType.RequestPlayersForGameResultCallback, typeof( RequestPlayersForGameResultCallback_t )},
			{ CallbackType.RequestPlayersForGameFinalResultCallback, typeof( RequestPlayersForGameFinalResultCallback_t )},
			{ CallbackType.SubmitPlayerResultResultCallback, typeof( SubmitPlayerResultResultCallback_t )},
			{ CallbackType.EndGameResultCallback, typeof( EndGameResultCallback_t )},
			{ CallbackType.JoinPartyCallback, typeof( JoinPartyCallback_t )},
			{ CallbackType.CreateBeaconCallback, typeof( CreateBeaconCallback_t )},
			{ CallbackType.ReservationNotificationCallback, typeof( ReservationNotificationCallback_t )},
			{ CallbackType.ChangeNumOpenSlotsCallback, typeof( ChangeNumOpenSlotsCallback_t )},
			{ CallbackType.AvailableBeaconLocationsUpdated, typeof( AvailableBeaconLocationsUpdated_t )},
			{ CallbackType.ActiveBeaconsUpdated, typeof( ActiveBeaconsUpdated_t )},
			{ CallbackType.SteamRemotePlaySessionConnected, typeof( SteamRemotePlaySessionConnected_t )},
			{ CallbackType.SteamRemotePlaySessionDisconnected, typeof( SteamRemotePlaySessionDisconnected_t )},
			{ CallbackType.SteamRemotePlayTogetherGuestInvite, typeof( SteamRemotePlayTogetherGuestInvite_t )},
		};
	}
}
