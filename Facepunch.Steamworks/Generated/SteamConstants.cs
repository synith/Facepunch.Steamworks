using System;
using System.Runtime.InteropServices;
using System.Linq;
using Steamworks.Data;
using System.Threading.Tasks;

namespace Steamworks.Data
{
	internal static class Defines
	{
		public const string STEAMAPPS_INTERFACE_VERSION = "STEAMAPPS_INTERFACE_VERSION008";
		public const string STEAMAPPTICKET_INTERFACE_VERSION = "STEAMAPPTICKET_INTERFACE_VERSION001";
		public const string STEAMCLIENT_INTERFACE_VERSION = "SteamClient021";
		public const string STEAMFRIENDS_INTERFACE_VERSION = "SteamFriends017";
		public const string STEAMGAMECOORDINATOR_INTERFACE_VERSION = "SteamGameCoordinator001";
		public const string STEAMGAMESERVER_INTERFACE_VERSION = "SteamGameServer015";
		public const string STEAMGAMESERVERSTATS_INTERFACE_VERSION = "SteamGameServerStats001";
		public const string STEAMHTMLSURFACE_INTERFACE_VERSION = "STEAMHTMLSURFACE_INTERFACE_VERSION_005";
		public const string STEAMHTTP_INTERFACE_VERSION = "STEAMHTTP_INTERFACE_VERSION003";
		public const string STEAMINPUT_INTERFACE_VERSION = "SteamInput006";
		public const string STEAMINVENTORY_INTERFACE_VERSION = "STEAMINVENTORY_INTERFACE_V003";
		public const string STEAMMATCHMAKING_INTERFACE_VERSION = "SteamMatchMaking009";
		public const string STEAMMATCHMAKINGSERVERS_INTERFACE_VERSION = "SteamMatchMakingServers002";
		public const string STEAMGAMESEARCH_INTERFACE_VERSION = "SteamMatchGameSearch001";
		public const string STEAMPARTIES_INTERFACE_VERSION = "SteamParties002";
		public const string STEAMMUSIC_INTERFACE_VERSION = "STEAMMUSIC_INTERFACE_VERSION001";
		public const string STEAMMUSICREMOTE_INTERFACE_VERSION = "STEAMMUSICREMOTE_INTERFACE_VERSION001";
		public const string STEAMNETWORKING_INTERFACE_VERSION = "SteamNetworking006";
		public const string STEAMNETWORKINGMESSAGES_INTERFACE_VERSION = "SteamNetworkingMessages002";
		// Silence some warnings
		public const string STEAMNETWORKINGSOCKETS_INTERFACE_VERSION = "SteamNetworkingSockets012";
		// Silence some warnings
		public const string STEAMNETWORKINGUTILS_INTERFACE_VERSION = "SteamNetworkingUtils004";
		public const string STEAMPARENTALSETTINGS_INTERFACE_VERSION = "STEAMPARENTALSETTINGS_INTERFACE_VERSION001";
		public const string STEAMREMOTEPLAY_INTERFACE_VERSION = "STEAMREMOTEPLAY_INTERFACE_VERSION002";
		public const string STEAMREMOTESTORAGE_INTERFACE_VERSION = "STEAMREMOTESTORAGE_INTERFACE_VERSION016";
		public const string STEAMSCREENSHOTS_INTERFACE_VERSION = "STEAMSCREENSHOTS_INTERFACE_VERSION003";
		public const string STEAMTIMELINE_INTERFACE_VERSION = "STEAMTIMELINE_INTERFACE_V001";
		public const string STEAMUGC_INTERFACE_VERSION = "STEAMUGC_INTERFACE_VERSION020";
		public const string STEAMUSER_INTERFACE_VERSION = "SteamUser023";
		public const string STEAMUSERSTATS_INTERFACE_VERSION = "STEAMUSERSTATS_INTERFACE_VERSION012";
		public const string STEAMUTILS_INTERFACE_VERSION = "SteamUtils010";
		public const string STEAMVIDEO_INTERFACE_VERSION = "STEAMVIDEO_INTERFACE_V007";
		internal static readonly AppId k_uAppIdInvalid = 0x0;
		internal static readonly DepotId_t k_uDepotIdInvalid = 0x0;
		internal static readonly SteamAPICall_t k_uAPICallInvalid = 0x0;
		internal static readonly AccountID_t k_uAccountIdInvalid = 0;
		internal static readonly PartyBeaconID_t k_ulPartyBeaconIdInvalid = 0;
		internal static readonly HAuthTicket k_HAuthTicketInvalid = 0;
		internal static readonly uint k_unSteamAccountIDMask = 0xFFFFFFFF;
		internal static readonly uint k_unSteamAccountInstanceMask = 0x000FFFFF;
		internal static readonly uint k_unSteamUserDefaultInstance = 1;
		internal static readonly int k_cchGameExtraInfoMax = 64;
		internal static readonly int k_cchMaxSteamErrMsg = 1024;
		internal static readonly int k_cchMaxFriendsGroupName = 64;
		internal static readonly int k_cFriendsGroupLimit = 100;
		internal static readonly FriendsGroupID_t k_FriendsGroupID_Invalid = - 1;
		internal static readonly int k_cEnumerateFollowersMax = 50;
		internal static readonly ushort k_usFriendGameInfoQueryPort_NotInitialized = 0xFFFF;
		internal static readonly ushort k_usFriendGameInfoQueryPort_Error = 0xFFFE;
		internal static readonly uint k_cubChatMetadataMax = 8192;
		internal static readonly int k_cbMaxGameServerGameDir = 32;
		internal static readonly int k_cbMaxGameServerMapName = 32;
		internal static readonly int k_cbMaxGameServerGameDescription = 64;
		internal static readonly int k_cbMaxGameServerName = 64;
		internal static readonly int k_cbMaxGameServerTags = 128;
		internal static readonly int k_cbMaxGameServerGameData = 2048;
		internal static readonly int HSERVERQUERY_INVALID = -1;
		internal static readonly uint k_unFavoriteFlagNone = 0x00;
		internal static readonly uint k_unFavoriteFlagFavorite = 0x01;
		internal static readonly uint k_unFavoriteFlagHistory = 0x02;
		internal static readonly uint k_unMaxCloudFileChunkSize = 100 * 1024 * 1024;
		internal static readonly PublishedFileId k_PublishedFileIdInvalid = 0;
		internal static readonly UGCHandle_t k_UGCHandleInvalid = 0xffffffffffffffff;
		internal static readonly PublishedFileUpdateHandle_t k_PublishedFileUpdateHandleInvalid = 0xffffffffffffffff;
		internal static readonly UGCFileWriteStreamHandle_t k_UGCFileStreamHandleInvalid = 0xffffffffffffffff;
		internal static readonly uint k_cchPublishedDocumentTitleMax = 128 + 1;
		internal static readonly uint k_cchPublishedDocumentDescriptionMax = 8000;
		internal static readonly uint k_cchPublishedDocumentChangeDescriptionMax = 8000;
		internal static readonly uint k_unEnumeratePublishedFilesMaxResults = 50;
		internal static readonly uint k_cchTagListMax = 1024 + 1;
		internal static readonly uint k_cchFilenameMax = 260;
		internal static readonly uint k_cchPublishedFileURLMax = 256;
		internal static readonly int k_cubAppProofOfPurchaseKeyMax = 240;
		internal static readonly uint k_nScreenshotMaxTaggedUsers = 32;
		internal static readonly uint k_nScreenshotMaxTaggedPublishedFiles = 32;
		internal static readonly int k_cubUFSTagTypeMax = 255;
		internal static readonly int k_cubUFSTagValueMax = 255;
		internal static readonly int k_ScreenshotThumbWidth = 200;
		internal static readonly UGCQueryHandle_t k_UGCQueryHandleInvalid = 0xffffffffffffffff;
		internal static readonly UGCUpdateHandle_t k_UGCUpdateHandleInvalid = 0xffffffffffffffff;
		internal static readonly uint kNumUGCResultsPerPage = 50;
		internal static readonly uint k_cchDeveloperMetadataMax = 5000;
		internal static readonly uint INVALID_HTMLBROWSER = 0;
		internal static readonly InventoryItemId k_SteamItemInstanceIDInvalid = ~default(ulong);
		internal static readonly SteamInventoryResult_t k_SteamInventoryResultInvalid = - 1;
		internal static readonly SteamInventoryUpdateHandle_t k_SteamInventoryUpdateHandleInvalid = 0xffffffffffffffff;
		internal static readonly uint k_unMaxTimelinePriority = 1000;
		internal static readonly float k_flMaxTimelineEventDuration = 600.0f;
		internal static readonly Connection k_HSteamNetConnection_Invalid = 0;
		internal static readonly Socket k_HSteamListenSocket_Invalid = 0;
		internal static readonly HSteamNetPollGroup k_HSteamNetPollGroup_Invalid = 0;
		internal static readonly int k_cchMaxSteamNetworkingErrMsg = 1024;
		internal static readonly int k_cchSteamNetworkingMaxConnectionCloseReason = 128;
		internal static readonly int k_cchSteamNetworkingMaxConnectionDescription = 128;
		internal static readonly int k_cchSteamNetworkingMaxConnectionAppName = 32;
		internal static readonly int k_nSteamNetworkConnectionInfoFlags_Unauthenticated = 1;
		internal static readonly int k_nSteamNetworkConnectionInfoFlags_Unencrypted = 2;
		internal static readonly int k_nSteamNetworkConnectionInfoFlags_LoopbackBuffers = 4;
		internal static readonly int k_nSteamNetworkConnectionInfoFlags_Fast = 8;
		internal static readonly int k_nSteamNetworkConnectionInfoFlags_Relayed = 16;
		internal static readonly int k_nSteamNetworkConnectionInfoFlags_DualWifi = 32;
		internal static readonly int k_cbMaxSteamNetworkingSocketsMessageSizeSend = 512 * 1024;
		internal static readonly int k_nSteamNetworkingSend_Unreliable = 0;
		internal static readonly int k_nSteamNetworkingSend_NoNagle = 1;
		internal static readonly int k_nSteamNetworkingSend_UnreliableNoNagle = k_nSteamNetworkingSend_Unreliable | k_nSteamNetworkingSend_NoNagle;
		internal static readonly int k_nSteamNetworkingSend_NoDelay = 4;
		internal static readonly int k_nSteamNetworkingSend_UnreliableNoDelay = k_nSteamNetworkingSend_Unreliable | k_nSteamNetworkingSend_NoDelay | k_nSteamNetworkingSend_NoNagle;
		internal static readonly int k_nSteamNetworkingSend_Reliable = 8;
		internal static readonly int k_nSteamNetworkingSend_ReliableNoNagle = k_nSteamNetworkingSend_Reliable | k_nSteamNetworkingSend_NoNagle;
		internal static readonly int k_nSteamNetworkingSend_UseCurrentThread = 16;
		internal static readonly int k_nSteamNetworkingSend_AutoRestartBrokenSession = 32;
		internal static readonly int k_cchMaxSteamNetworkingPingLocationString = 1024;
		internal static readonly int k_nSteamNetworkingPing_Failed = - 1;
		internal static readonly int k_nSteamNetworkingPing_Unknown = - 2;
		internal static readonly int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Default = - 1;
		internal static readonly int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Disable = 0;
		internal static readonly int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Relay = 1;
		internal static readonly int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Private = 2;
		internal static readonly int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Public = 4;
		internal static readonly int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_All = 0x7fffffff;
		internal static readonly SteamNetworkingPOPID k_SteamDatagramPOPID_dev = ( ( uint ) 'd' << 16 ) | ( ( uint ) 'e' << 8 ) | ( uint ) 'v';
		internal static readonly ushort STEAMGAMESERVER_QUERY_PORT_SHARED = 0xffff;
		internal static readonly ushort MASTERSERVERUPDATERPORT_USEGAMESOCKETSHARE = STEAMGAMESERVER_QUERY_PORT_SHARED;
		internal static readonly uint k_cbSteamDatagramMaxSerializedTicket = 512;
		internal static readonly uint k_cbMaxSteamDatagramGameCoordinatorServerLoginAppData = 2048;
		internal static readonly uint k_cbMaxSteamDatagramGameCoordinatorServerLoginSerialized = 4096;
		internal static readonly int k_cbSteamNetworkingSocketsFakeUDPPortRecommendedMTU = 1200;
		internal static readonly int k_cbSteamNetworkingSocketsFakeUDPPortMaxMessageSize = 4096;
	}
}
