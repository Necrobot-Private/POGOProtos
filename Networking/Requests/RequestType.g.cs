// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Networking/Requests/RequestType.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Requests {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/RequestType.proto</summary>
  public static partial class RequestTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Requests/RequestType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RequestTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvUmVxdWVzdFR5cGUu",
            "cHJvdG8SHlBPR09Qcm90b3MuTmV0d29ya2luZy5SZXF1ZXN0cyrLEAoLUmVx",
            "dWVzdFR5cGUSEAoMTUVUSE9EX1VOU0VUEAASDgoKR0VUX1BMQVlFUhACEhYK",
            "EkdFVF9IT0xPX0lOVkVOVE9SWRAEEhUKEURPV05MT0FEX1NFVFRJTkdTEAUS",
            "GwoXRE9XTkxPQURfSVRFTV9URU1QTEFURVMQBhIiCh5ET1dOTE9BRF9SRU1P",
            "VEVfQ09ORklHX1ZFUlNJT04QBxIeChpSRUdJU1RFUl9CQUNLR1JPVU5EX0RF",
            "VklDRRAIEg8KC0ZPUlRfU0VBUkNIEGUSDQoJRU5DT1VOVEVSEGYSEQoNQ0FU",
            "Q0hfUE9LRU1PThBnEhAKDEZPUlRfREVUQUlMUxBoEhMKD0dFVF9NQVBfT0JK",
            "RUNUUxBqEhcKE0ZPUlRfREVQTE9ZX1BPS0VNT04QbhIXChNGT1JUX1JFQ0FM",
            "TF9QT0tFTU9OEG8SEwoPUkVMRUFTRV9QT0tFTU9OEHASEwoPVVNFX0lURU1f",
            "UE9USU9OEHESFAoQVVNFX0lURU1fQ0FQVFVSRRByEhEKDVVTRV9JVEVNX0ZM",
            "RUUQcxITCg9VU0VfSVRFTV9SRVZJVkUQdBIWChJHRVRfUExBWUVSX1BST0ZJ",
            "TEUQeRISCg5FVk9MVkVfUE9LRU1PThB9EhQKEEdFVF9IQVRDSEVEX0VHR1MQ",
            "fhIfChtFTkNPVU5URVJfVFVUT1JJQUxfQ09NUExFVEUQfxIVChBMRVZFTF9V",
            "UF9SRVdBUkRTEIABEhkKFENIRUNLX0FXQVJERURfQkFER0VTEIEBEhEKDFVT",
            "RV9JVEVNX0dZTRCFARIUCg9HRVRfR1lNX0RFVEFJTFMQhgESFQoQU1RBUlRf",
            "R1lNX0JBVFRMRRCHARIPCgpBVFRBQ0tfR1lNEIgBEhsKFlJFQ1lDTEVfSU5W",
            "RU5UT1JZX0lURU0QiQESGAoTQ09MTEVDVF9EQUlMWV9CT05VUxCKARIWChFV",
            "U0VfSVRFTV9YUF9CT09TVBCLARIbChZVU0VfSVRFTV9FR0dfSU5DVUJBVE9S",
            "EIwBEhAKC1VTRV9JTkNFTlNFEI0BEhgKE0dFVF9JTkNFTlNFX1BPS0VNT04Q",
            "jgESFgoRSU5DRU5TRV9FTkNPVU5URVIQjwESFgoRQUREX0ZPUlRfTU9ESUZJ",
            "RVIQkAESEwoORElTS19FTkNPVU5URVIQkQESIQocQ09MTEVDVF9EQUlMWV9E",
            "RUZFTkRFUl9CT05VUxCSARIUCg9VUEdSQURFX1BPS0VNT04QkwESGQoUU0VU",
            "X0ZBVk9SSVRFX1BPS0VNT04QlAESFQoQTklDS05BTUVfUE9LRU1PThCVARIQ",
            "CgtFUVVJUF9CQURHRRCWARIZChRTRVRfQ09OVEFDVF9TRVRUSU5HUxCXARIW",
            "ChFTRVRfQlVERFlfUE9LRU1PThCYARIVChBHRVRfQlVERFlfV0FMS0VEEJkB",
            "EhcKElVTRV9JVEVNX0VOQ09VTlRFUhCaARIPCgpHWU1fREVQTE9ZEJsBEhEK",
            "DEdZTV9HRVRfSU5GTxCcARIWChFHWU1fU1RBUlRfU0VTU0lPThCdARIWChFH",
            "WU1fQkFUVExFX0FUVEFDSxCeARIPCgpKT0lOX0xPQkJZEJ8BEhAKC0xFQVZF",
            "X0xPQkJZEKABEhkKFFNFVF9MT0JCWV9WSVNJQklMSVRZEKEBEhYKEVNFVF9M",
            "T0JCWV9QT0tFTU9OEKIBEhUKEEdFVF9SQUlEX0RFVEFJTFMQowESFQoQR1lN",
            "X0ZFRURfUE9LRU1PThCkARIWChFTVEFSVF9SQUlEX0JBVFRMRRClARIQCgtB",
            "VFRBQ0tfUkFJRBCmARIVChBHRVRfQVNTRVRfRElHRVNUEKwCEhYKEUdFVF9E",
            "T1dOTE9BRF9VUkxTEK0CEhMKDkNMQUlNX0NPREVOQU1FEJMDEg8KClNFVF9B",
            "VkFUQVIQlAMSFAoPU0VUX1BMQVlFUl9URUFNEJUDEhsKFk1BUktfVFVUT1JJ",
            "QUxfQ09NUExFVEUQlgMSFAoPQ0hFQ0tfQ0hBTExFTkdFENgEEhUKEFZFUklG",
            "WV9DSEFMTEVOR0UQ2QQSCQoERUNITxCaBRIXChJTRklEQV9SRUdJU1RSQVRJ",
            "T04QoAYSFQoQU0ZJREFfQUNUSU9OX0xPRxChBhIYChNTRklEQV9DRVJUSUZJ",
            "Q0FUSU9OEKIGEhEKDFNGSURBX1VQREFURRCjBhIRCgxTRklEQV9BQ1RJT04Q",
            "pAYSEQoMU0ZJREFfRE9XU0VSEKUGEhIKDVNGSURBX0NBUFRVUkUQpgYSHwoa",
            "TElTVF9BVkFUQVJfQ1VTVE9NSVpBVElPTlMQpwYSHgoZU0VUX0FWQVRBUl9J",
            "VEVNX0FTX1ZJRVdFRBCoBhIOCglHRVRfSU5CT1gQqQYSFAoPTElTVF9HWU1f",
            "QkFER0VTEKsGEhoKFUdFVF9HWU1fQkFER0VfREVUQUlMUxCsBhIZChRVU0Vf",
            "SVRFTV9NT1ZFX1JFUk9MTBCtBhIYChNVU0VfSVRFTV9SQVJFX0NBTkRZEK4G",
            "EhsKFkFXQVJEX0ZSRUVfUkFJRF9USUNLRVQQrwYSHwoaUkVHSVNURVJfUFVT",
            "SF9OT1RJRklDQVRJT04QiCcSIQocVU5SRUdJU1RFUl9QVVNIX05PVElGSUNB",
            "VElPThCJJxIfChpVUERBVEVfTk9USUZJQ0FUSU9OX1NUQVRVUxCKJxInCiJP",
            "UFRfT1VUX1BVU0hfTk9USUZJQ0FUSU9OX0NBVEVHT1JZEIsnEiMKHkRPV05M",
            "T0FEX0dBTUVfTUFTVEVSX1RFTVBMQVRFUxCMJxISCg1HRVRfSU5WRU5UT1JZ",
            "EI0nYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::POGOProtos.Networking.Requests.RequestType), }, null));
    }
    #endregion

  }
  #region Enums
  public enum RequestType {
    /// <summary>
    /// No implementation required
    /// </summary>
    [pbr::OriginalName("METHOD_UNSET")] MethodUnset = 0,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_PLAYER")] GetPlayer = 2,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_HOLO_INVENTORY")] GetHoloInventory = 4,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("DOWNLOAD_SETTINGS")] DownloadSettings = 5,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("DOWNLOAD_ITEM_TEMPLATES")] DownloadItemTemplates = 6,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("DOWNLOAD_REMOTE_CONFIG_VERSION")] DownloadRemoteConfigVersion = 7,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("REGISTER_BACKGROUND_DEVICE")] RegisterBackgroundDevice = 8,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("FORT_SEARCH")] FortSearch = 101,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("ENCOUNTER")] Encounter = 102,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("CATCH_POKEMON")] CatchPokemon = 103,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("FORT_DETAILS")] FortDetails = 104,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_MAP_OBJECTS")] GetMapObjects = 106,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("FORT_DEPLOY_POKEMON")] FortDeployPokemon = 110,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("FORT_RECALL_POKEMON")] FortRecallPokemon = 111,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("RELEASE_POKEMON")] ReleasePokemon = 112,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("USE_ITEM_POTION")] UseItemPotion = 113,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("USE_ITEM_CAPTURE")] UseItemCapture = 114,
    /// <summary>
    /// Can't find this one
    /// </summary>
    [pbr::OriginalName("USE_ITEM_FLEE")] UseItemFlee = 115,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("USE_ITEM_REVIVE")] UseItemRevive = 116,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_PLAYER_PROFILE")] GetPlayerProfile = 121,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("EVOLVE_POKEMON")] EvolvePokemon = 125,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_HATCHED_EGGS")] GetHatchedEggs = 126,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("ENCOUNTER_TUTORIAL_COMPLETE")] EncounterTutorialComplete = 127,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("LEVEL_UP_REWARDS")] LevelUpRewards = 128,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("CHECK_AWARDED_BADGES")] CheckAwardedBadges = 129,
    /// <summary>
    /// UnUsed - Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("USE_ITEM_GYM")] UseItemGym = 133,
    /// <summary>
    /// UnUsed - Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_GYM_DETAILS")] GetGymDetails = 134,
    /// <summary>
    /// UnUsed - Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("START_GYM_BATTLE")] StartGymBattle = 135,
    /// <summary>
    /// UnUsed - Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("ATTACK_GYM")] AttackGym = 136,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("RECYCLE_INVENTORY_ITEM")] RecycleInventoryItem = 137,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("COLLECT_DAILY_BONUS")] CollectDailyBonus = 138,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("USE_ITEM_XP_BOOST")] UseItemXpBoost = 139,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("USE_ITEM_EGG_INCUBATOR")] UseItemEggIncubator = 140,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("USE_INCENSE")] UseIncense = 141,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_INCENSE_POKEMON")] GetIncensePokemon = 142,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("INCENSE_ENCOUNTER")] IncenseEncounter = 143,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("ADD_FORT_MODIFIER")] AddFortModifier = 144,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("DISK_ENCOUNTER")] DiskEncounter = 145,
    /// <summary>
    /// UnUsed - Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("COLLECT_DAILY_DEFENDER_BONUS")] CollectDailyDefenderBonus = 146,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("UPGRADE_POKEMON")] UpgradePokemon = 147,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("SET_FAVORITE_POKEMON")] SetFavoritePokemon = 148,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("NICKNAME_POKEMON")] NicknamePokemon = 149,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("EQUIP_BADGE")] EquipBadge = 150,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("SET_CONTACT_SETTINGS")] SetContactSettings = 151,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("SET_BUDDY_POKEMON")] SetBuddyPokemon = 152,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_BUDDY_WALKED")] GetBuddyWalked = 153,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("USE_ITEM_ENCOUNTER")] UseItemEncounter = 154,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GYM_DEPLOY")] GymDeploy = 155,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GYM_GET_INFO")] GymGetInfo = 156,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GYM_START_SESSION")] GymStartSession = 157,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GYM_BATTLE_ATTACK")] GymBattleAttack = 158,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("JOIN_LOBBY")] JoinLobby = 159,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("LEAVE_LOBBY")] LeaveLobby = 160,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("SET_LOBBY_VISIBILITY")] SetLobbyVisibility = 161,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("SET_LOBBY_POKEMON")] SetLobbyPokemon = 162,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_RAID_DETAILS")] GetRaidDetails = 163,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GYM_FEED_POKEMON")] GymFeedPokemon = 164,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("START_RAID_BATTLE")] StartRaidBattle = 165,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("ATTACK_RAID")] AttackRaid = 166,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_ASSET_DIGEST")] GetAssetDigest = 300,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_DOWNLOAD_URLS")] GetDownloadUrls = 301,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("CLAIM_CODENAME")] ClaimCodename = 403,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("SET_AVATAR")] SetAvatar = 404,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("SET_PLAYER_TEAM")] SetPlayerTeam = 405,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("MARK_TUTORIAL_COMPLETE")] MarkTutorialComplete = 406,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("CHECK_CHALLENGE")] CheckChallenge = 600,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("VERIFY_CHALLENGE")] VerifyChallenge = 601,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("ECHO")] Echo = 666,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("SFIDA_REGISTRATION")] SfidaRegistration = 800,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("SFIDA_ACTION_LOG")] SfidaActionLog = 801,
    /// <summary>
    /// Not yet released.
    /// </summary>
    [pbr::OriginalName("SFIDA_CERTIFICATION")] SfidaCertification = 802,
    /// <summary>
    /// Not yet released.
    /// </summary>
    [pbr::OriginalName("SFIDA_UPDATE")] SfidaUpdate = 803,
    /// <summary>
    /// Not yet released.
    /// </summary>
    [pbr::OriginalName("SFIDA_ACTION")] SfidaAction = 804,
    /// <summary>
    /// Not yet released.
    /// </summary>
    [pbr::OriginalName("SFIDA_DOWSER")] SfidaDowser = 805,
    /// <summary>
    /// Not yet released.
    /// </summary>
    [pbr::OriginalName("SFIDA_CAPTURE")] SfidaCapture = 806,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("LIST_AVATAR_CUSTOMIZATIONS")] ListAvatarCustomizations = 807,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("SET_AVATAR_ITEM_AS_VIEWED")] SetAvatarItemAsViewed = 808,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_INBOX")] GetInbox = 809,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("LIST_GYM_BADGES")] ListGymBadges = 811,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_GYM_BADGE_DETAILS")] GetGymBadgeDetails = 812,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("USE_ITEM_MOVE_REROLL")] UseItemMoveReroll = 813,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("USE_ITEM_RARE_CANDY")] UseItemRareCandy = 814,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("AWARD_FREE_RAID_TICKET")] AwardFreeRaidTicket = 815,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("REGISTER_PUSH_NOTIFICATION")] RegisterPushNotification = 5000,
    /// <summary>
    /// Not yet released.
    /// </summary>
    [pbr::OriginalName("UNREGISTER_PUSH_NOTIFICATION")] UnregisterPushNotification = 5001,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("UPDATE_NOTIFICATION_STATUS")] UpdateNotificationStatus = 5002,
    /// <summary>
    /// Not yet released.
    /// </summary>
    [pbr::OriginalName("OPT_OUT_PUSH_NOTIFICATION_CATEGORY")] OptOutPushNotificationCategory = 5003,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("DOWNLOAD_GAME_MASTER_TEMPLATES")] DownloadGameMasterTemplates = 5004,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_INVENTORY")] GetInventory = 5005,
  }

  #endregion

}

#endregion Designer generated code
