// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Data/PlayerData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/PlayerData.proto</summary>
  public static partial class PlayerDataReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/PlayerData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBQT0dPUHJvdG9zL0RhdGEvUGxheWVyRGF0YS5wcm90bxIPUE9HT1Byb3Rv",
            "cy5EYXRhGiRQT0dPUHJvdG9zL0VudW1zL1R1dG9yaWFsU3RhdGUucHJvdG8a",
            "KVBPR09Qcm90b3MvRGF0YS9QbGF5ZXIvUGxheWVyQXZhdGFyLnByb3RvGidQ",
            "T0dPUHJvdG9zL0RhdGEvUGxheWVyL0RhaWx5Qm9udXMucHJvdG8aKlBPR09Q",
            "cm90b3MvRGF0YS9QbGF5ZXIvRXF1aXBwZWRCYWRnZS5wcm90bxosUE9HT1By",
            "b3Rvcy9EYXRhL1BsYXllci9Db250YWN0U2V0dGluZ3MucHJvdG8aJVBPR09Q",
            "cm90b3MvRGF0YS9QbGF5ZXIvQ3VycmVuY3kucHJvdG8aIlBPR09Qcm90b3Mv",
            "RGF0YS9CdWRkeVBva2Vtb24ucHJvdG8aIFBPR09Qcm90b3MvRW51bXMvVGVh",
            "bUNvbG9yLnByb3RvIt8FCgpQbGF5ZXJEYXRhEh0KFWNyZWF0aW9uX3RpbWVz",
            "dGFtcF9tcxgBIAEoAxIQCgh1c2VybmFtZRgCIAEoCRIpCgR0ZWFtGAUgASgO",
            "MhsuUE9HT1Byb3Rvcy5FbnVtcy5UZWFtQ29sb3ISOwoOdHV0b3JpYWxfc3Rh",
            "dGUYByADKA4yHy5QT0dPUHJvdG9zLkVudW1zLlR1dG9yaWFsU3RhdGVCAhAB",
            "EjQKBmF2YXRhchgIIAEoCzIkLlBPR09Qcm90b3MuRGF0YS5QbGF5ZXIuUGxh",
            "eWVyQXZhdGFyEhsKE21heF9wb2tlbW9uX3N0b3JhZ2UYCSABKAUSGAoQbWF4",
            "X2l0ZW1fc3RvcmFnZRgKIAEoBRI3CgtkYWlseV9ib251cxgLIAEoCzIiLlBP",
            "R09Qcm90b3MuRGF0YS5QbGF5ZXIuRGFpbHlCb251cxI9Cg5lcXVpcHBlZF9i",
            "YWRnZRgMIAEoCzIlLlBPR09Qcm90b3MuRGF0YS5QbGF5ZXIuRXF1aXBwZWRC",
            "YWRnZRJBChBjb250YWN0X3NldHRpbmdzGA0gASgLMicuUE9HT1Byb3Rvcy5E",
            "YXRhLlBsYXllci5Db250YWN0U2V0dGluZ3MSNAoKY3VycmVuY2llcxgOIAMo",
            "CzIgLlBPR09Qcm90b3MuRGF0YS5QbGF5ZXIuQ3VycmVuY3kSIQoZcmVtYWlu",
            "aW5nX2NvZGVuYW1lX2NsYWltcxgPIAEoBRI0Cg1idWRkeV9wb2tlbW9uGBAg",
            "ASgLMh0uUE9HT1Byb3Rvcy5EYXRhLkJ1ZGR5UG9rZW1vbhIdChViYXR0bGVf",
            "bG9ja291dF9lbmRfbXMYESABKAMSRQoXc2Vjb25kYXJ5X3BsYXllcl9hdmF0",
            "YXIYEiABKAsyJC5QT0dPUHJvdG9zLkRhdGEuUGxheWVyLlBsYXllckF2YXRh",
            "chIbChNuYW1lX2lzX2JsYWNrbGlzdGVkGBMgASgIYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Enums.TutorialStateReflection.Descriptor, global::POGOProtos.Data.Player.PlayerAvatarReflection.Descriptor, global::POGOProtos.Data.Player.DailyBonusReflection.Descriptor, global::POGOProtos.Data.Player.EquippedBadgeReflection.Descriptor, global::POGOProtos.Data.Player.ContactSettingsReflection.Descriptor, global::POGOProtos.Data.Player.CurrencyReflection.Descriptor, global::POGOProtos.Data.BuddyPokemonReflection.Descriptor, global::POGOProtos.Enums.TeamColorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.PlayerData), global::POGOProtos.Data.PlayerData.Parser, new[]{ "CreationTimestampMs", "Username", "Team", "TutorialState", "Avatar", "MaxPokemonStorage", "MaxItemStorage", "DailyBonus", "EquippedBadge", "ContactSettings", "Currencies", "RemainingCodenameClaims", "BuddyPokemon", "BattleLockoutEndMs", "SecondaryPlayerAvatar", "NameIsBlacklisted" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PlayerData : pb::IMessage<PlayerData> {
    private static readonly pb::MessageParser<PlayerData> _parser = new pb::MessageParser<PlayerData>(() => new PlayerData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PlayerData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.PlayerDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerData(PlayerData other) : this() {
      creationTimestampMs_ = other.creationTimestampMs_;
      username_ = other.username_;
      team_ = other.team_;
      tutorialState_ = other.tutorialState_.Clone();
      avatar_ = other.avatar_ != null ? other.avatar_.Clone() : null;
      maxPokemonStorage_ = other.maxPokemonStorage_;
      maxItemStorage_ = other.maxItemStorage_;
      dailyBonus_ = other.dailyBonus_ != null ? other.dailyBonus_.Clone() : null;
      equippedBadge_ = other.equippedBadge_ != null ? other.equippedBadge_.Clone() : null;
      contactSettings_ = other.contactSettings_ != null ? other.contactSettings_.Clone() : null;
      currencies_ = other.currencies_.Clone();
      remainingCodenameClaims_ = other.remainingCodenameClaims_;
      buddyPokemon_ = other.buddyPokemon_ != null ? other.buddyPokemon_.Clone() : null;
      battleLockoutEndMs_ = other.battleLockoutEndMs_;
      secondaryPlayerAvatar_ = other.secondaryPlayerAvatar_ != null ? other.secondaryPlayerAvatar_.Clone() : null;
      nameIsBlacklisted_ = other.nameIsBlacklisted_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerData Clone() {
      return new PlayerData(this);
    }

    /// <summary>Field number for the "creation_timestamp_ms" field.</summary>
    public const int CreationTimestampMsFieldNumber = 1;
    private long creationTimestampMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long CreationTimestampMs {
      get { return creationTimestampMs_; }
      set {
        creationTimestampMs_ = value;
      }
    }

    /// <summary>Field number for the "username" field.</summary>
    public const int UsernameFieldNumber = 2;
    private string username_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Username {
      get { return username_; }
      set {
        username_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "team" field.</summary>
    public const int TeamFieldNumber = 5;
    private global::POGOProtos.Enums.TeamColor team_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.TeamColor Team {
      get { return team_; }
      set {
        team_ = value;
      }
    }

    /// <summary>Field number for the "tutorial_state" field.</summary>
    public const int TutorialStateFieldNumber = 7;
    private static readonly pb::FieldCodec<global::POGOProtos.Enums.TutorialState> _repeated_tutorialState_codec
        = pb::FieldCodec.ForEnum(58, x => (int) x, x => (global::POGOProtos.Enums.TutorialState) x);
    private readonly pbc::RepeatedField<global::POGOProtos.Enums.TutorialState> tutorialState_ = new pbc::RepeatedField<global::POGOProtos.Enums.TutorialState>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Enums.TutorialState> TutorialState {
      get { return tutorialState_; }
    }

    /// <summary>Field number for the "avatar" field.</summary>
    public const int AvatarFieldNumber = 8;
    private global::POGOProtos.Data.Player.PlayerAvatar avatar_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Player.PlayerAvatar Avatar {
      get { return avatar_; }
      set {
        avatar_ = value;
      }
    }

    /// <summary>Field number for the "max_pokemon_storage" field.</summary>
    public const int MaxPokemonStorageFieldNumber = 9;
    private int maxPokemonStorage_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MaxPokemonStorage {
      get { return maxPokemonStorage_; }
      set {
        maxPokemonStorage_ = value;
      }
    }

    /// <summary>Field number for the "max_item_storage" field.</summary>
    public const int MaxItemStorageFieldNumber = 10;
    private int maxItemStorage_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MaxItemStorage {
      get { return maxItemStorage_; }
      set {
        maxItemStorage_ = value;
      }
    }

    /// <summary>Field number for the "daily_bonus" field.</summary>
    public const int DailyBonusFieldNumber = 11;
    private global::POGOProtos.Data.Player.DailyBonus dailyBonus_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Player.DailyBonus DailyBonus {
      get { return dailyBonus_; }
      set {
        dailyBonus_ = value;
      }
    }

    /// <summary>Field number for the "equipped_badge" field.</summary>
    public const int EquippedBadgeFieldNumber = 12;
    private global::POGOProtos.Data.Player.EquippedBadge equippedBadge_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Player.EquippedBadge EquippedBadge {
      get { return equippedBadge_; }
      set {
        equippedBadge_ = value;
      }
    }

    /// <summary>Field number for the "contact_settings" field.</summary>
    public const int ContactSettingsFieldNumber = 13;
    private global::POGOProtos.Data.Player.ContactSettings contactSettings_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Player.ContactSettings ContactSettings {
      get { return contactSettings_; }
      set {
        contactSettings_ = value;
      }
    }

    /// <summary>Field number for the "currencies" field.</summary>
    public const int CurrenciesFieldNumber = 14;
    private static readonly pb::FieldCodec<global::POGOProtos.Data.Player.Currency> _repeated_currencies_codec
        = pb::FieldCodec.ForMessage(114, global::POGOProtos.Data.Player.Currency.Parser);
    private readonly pbc::RepeatedField<global::POGOProtos.Data.Player.Currency> currencies_ = new pbc::RepeatedField<global::POGOProtos.Data.Player.Currency>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Data.Player.Currency> Currencies {
      get { return currencies_; }
    }

    /// <summary>Field number for the "remaining_codename_claims" field.</summary>
    public const int RemainingCodenameClaimsFieldNumber = 15;
    private int remainingCodenameClaims_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RemainingCodenameClaims {
      get { return remainingCodenameClaims_; }
      set {
        remainingCodenameClaims_ = value;
      }
    }

    /// <summary>Field number for the "buddy_pokemon" field.</summary>
    public const int BuddyPokemonFieldNumber = 16;
    private global::POGOProtos.Data.BuddyPokemon buddyPokemon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.BuddyPokemon BuddyPokemon {
      get { return buddyPokemon_; }
      set {
        buddyPokemon_ = value;
      }
    }

    /// <summary>Field number for the "battle_lockout_end_ms" field.</summary>
    public const int BattleLockoutEndMsFieldNumber = 17;
    private long battleLockoutEndMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long BattleLockoutEndMs {
      get { return battleLockoutEndMs_; }
      set {
        battleLockoutEndMs_ = value;
      }
    }

    /// <summary>Field number for the "secondary_player_avatar" field.</summary>
    public const int SecondaryPlayerAvatarFieldNumber = 18;
    private global::POGOProtos.Data.Player.PlayerAvatar secondaryPlayerAvatar_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Player.PlayerAvatar SecondaryPlayerAvatar {
      get { return secondaryPlayerAvatar_; }
      set {
        secondaryPlayerAvatar_ = value;
      }
    }

    /// <summary>Field number for the "name_is_blacklisted" field.</summary>
    public const int NameIsBlacklistedFieldNumber = 19;
    private bool nameIsBlacklisted_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool NameIsBlacklisted {
      get { return nameIsBlacklisted_; }
      set {
        nameIsBlacklisted_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PlayerData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PlayerData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CreationTimestampMs != other.CreationTimestampMs) return false;
      if (Username != other.Username) return false;
      if (Team != other.Team) return false;
      if(!tutorialState_.Equals(other.tutorialState_)) return false;
      if (!object.Equals(Avatar, other.Avatar)) return false;
      if (MaxPokemonStorage != other.MaxPokemonStorage) return false;
      if (MaxItemStorage != other.MaxItemStorage) return false;
      if (!object.Equals(DailyBonus, other.DailyBonus)) return false;
      if (!object.Equals(EquippedBadge, other.EquippedBadge)) return false;
      if (!object.Equals(ContactSettings, other.ContactSettings)) return false;
      if(!currencies_.Equals(other.currencies_)) return false;
      if (RemainingCodenameClaims != other.RemainingCodenameClaims) return false;
      if (!object.Equals(BuddyPokemon, other.BuddyPokemon)) return false;
      if (BattleLockoutEndMs != other.BattleLockoutEndMs) return false;
      if (!object.Equals(SecondaryPlayerAvatar, other.SecondaryPlayerAvatar)) return false;
      if (NameIsBlacklisted != other.NameIsBlacklisted) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CreationTimestampMs != 0L) hash ^= CreationTimestampMs.GetHashCode();
      if (Username.Length != 0) hash ^= Username.GetHashCode();
      if (Team != 0) hash ^= Team.GetHashCode();
      hash ^= tutorialState_.GetHashCode();
      if (avatar_ != null) hash ^= Avatar.GetHashCode();
      if (MaxPokemonStorage != 0) hash ^= MaxPokemonStorage.GetHashCode();
      if (MaxItemStorage != 0) hash ^= MaxItemStorage.GetHashCode();
      if (dailyBonus_ != null) hash ^= DailyBonus.GetHashCode();
      if (equippedBadge_ != null) hash ^= EquippedBadge.GetHashCode();
      if (contactSettings_ != null) hash ^= ContactSettings.GetHashCode();
      hash ^= currencies_.GetHashCode();
      if (RemainingCodenameClaims != 0) hash ^= RemainingCodenameClaims.GetHashCode();
      if (buddyPokemon_ != null) hash ^= BuddyPokemon.GetHashCode();
      if (BattleLockoutEndMs != 0L) hash ^= BattleLockoutEndMs.GetHashCode();
      if (secondaryPlayerAvatar_ != null) hash ^= SecondaryPlayerAvatar.GetHashCode();
      if (NameIsBlacklisted != false) hash ^= NameIsBlacklisted.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (CreationTimestampMs != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(CreationTimestampMs);
      }
      if (Username.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Username);
      }
      if (Team != 0) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Team);
      }
      tutorialState_.WriteTo(output, _repeated_tutorialState_codec);
      if (avatar_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Avatar);
      }
      if (MaxPokemonStorage != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(MaxPokemonStorage);
      }
      if (MaxItemStorage != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(MaxItemStorage);
      }
      if (dailyBonus_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(DailyBonus);
      }
      if (equippedBadge_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(EquippedBadge);
      }
      if (contactSettings_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(ContactSettings);
      }
      currencies_.WriteTo(output, _repeated_currencies_codec);
      if (RemainingCodenameClaims != 0) {
        output.WriteRawTag(120);
        output.WriteInt32(RemainingCodenameClaims);
      }
      if (buddyPokemon_ != null) {
        output.WriteRawTag(130, 1);
        output.WriteMessage(BuddyPokemon);
      }
      if (BattleLockoutEndMs != 0L) {
        output.WriteRawTag(136, 1);
        output.WriteInt64(BattleLockoutEndMs);
      }
      if (secondaryPlayerAvatar_ != null) {
        output.WriteRawTag(146, 1);
        output.WriteMessage(SecondaryPlayerAvatar);
      }
      if (NameIsBlacklisted != false) {
        output.WriteRawTag(152, 1);
        output.WriteBool(NameIsBlacklisted);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CreationTimestampMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CreationTimestampMs);
      }
      if (Username.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Username);
      }
      if (Team != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Team);
      }
      size += tutorialState_.CalculateSize(_repeated_tutorialState_codec);
      if (avatar_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Avatar);
      }
      if (MaxPokemonStorage != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxPokemonStorage);
      }
      if (MaxItemStorage != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxItemStorage);
      }
      if (dailyBonus_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DailyBonus);
      }
      if (equippedBadge_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EquippedBadge);
      }
      if (contactSettings_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ContactSettings);
      }
      size += currencies_.CalculateSize(_repeated_currencies_codec);
      if (RemainingCodenameClaims != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RemainingCodenameClaims);
      }
      if (buddyPokemon_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(BuddyPokemon);
      }
      if (BattleLockoutEndMs != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(BattleLockoutEndMs);
      }
      if (secondaryPlayerAvatar_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(SecondaryPlayerAvatar);
      }
      if (NameIsBlacklisted != false) {
        size += 2 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PlayerData other) {
      if (other == null) {
        return;
      }
      if (other.CreationTimestampMs != 0L) {
        CreationTimestampMs = other.CreationTimestampMs;
      }
      if (other.Username.Length != 0) {
        Username = other.Username;
      }
      if (other.Team != 0) {
        Team = other.Team;
      }
      tutorialState_.Add(other.tutorialState_);
      if (other.avatar_ != null) {
        if (avatar_ == null) {
          avatar_ = new global::POGOProtos.Data.Player.PlayerAvatar();
        }
        Avatar.MergeFrom(other.Avatar);
      }
      if (other.MaxPokemonStorage != 0) {
        MaxPokemonStorage = other.MaxPokemonStorage;
      }
      if (other.MaxItemStorage != 0) {
        MaxItemStorage = other.MaxItemStorage;
      }
      if (other.dailyBonus_ != null) {
        if (dailyBonus_ == null) {
          dailyBonus_ = new global::POGOProtos.Data.Player.DailyBonus();
        }
        DailyBonus.MergeFrom(other.DailyBonus);
      }
      if (other.equippedBadge_ != null) {
        if (equippedBadge_ == null) {
          equippedBadge_ = new global::POGOProtos.Data.Player.EquippedBadge();
        }
        EquippedBadge.MergeFrom(other.EquippedBadge);
      }
      if (other.contactSettings_ != null) {
        if (contactSettings_ == null) {
          contactSettings_ = new global::POGOProtos.Data.Player.ContactSettings();
        }
        ContactSettings.MergeFrom(other.ContactSettings);
      }
      currencies_.Add(other.currencies_);
      if (other.RemainingCodenameClaims != 0) {
        RemainingCodenameClaims = other.RemainingCodenameClaims;
      }
      if (other.buddyPokemon_ != null) {
        if (buddyPokemon_ == null) {
          buddyPokemon_ = new global::POGOProtos.Data.BuddyPokemon();
        }
        BuddyPokemon.MergeFrom(other.BuddyPokemon);
      }
      if (other.BattleLockoutEndMs != 0L) {
        BattleLockoutEndMs = other.BattleLockoutEndMs;
      }
      if (other.secondaryPlayerAvatar_ != null) {
        if (secondaryPlayerAvatar_ == null) {
          secondaryPlayerAvatar_ = new global::POGOProtos.Data.Player.PlayerAvatar();
        }
        SecondaryPlayerAvatar.MergeFrom(other.SecondaryPlayerAvatar);
      }
      if (other.NameIsBlacklisted != false) {
        NameIsBlacklisted = other.NameIsBlacklisted;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            CreationTimestampMs = input.ReadInt64();
            break;
          }
          case 18: {
            Username = input.ReadString();
            break;
          }
          case 40: {
            team_ = (global::POGOProtos.Enums.TeamColor) input.ReadEnum();
            break;
          }
          case 58:
          case 56: {
            tutorialState_.AddEntriesFrom(input, _repeated_tutorialState_codec);
            break;
          }
          case 66: {
            if (avatar_ == null) {
              avatar_ = new global::POGOProtos.Data.Player.PlayerAvatar();
            }
            input.ReadMessage(avatar_);
            break;
          }
          case 72: {
            MaxPokemonStorage = input.ReadInt32();
            break;
          }
          case 80: {
            MaxItemStorage = input.ReadInt32();
            break;
          }
          case 90: {
            if (dailyBonus_ == null) {
              dailyBonus_ = new global::POGOProtos.Data.Player.DailyBonus();
            }
            input.ReadMessage(dailyBonus_);
            break;
          }
          case 98: {
            if (equippedBadge_ == null) {
              equippedBadge_ = new global::POGOProtos.Data.Player.EquippedBadge();
            }
            input.ReadMessage(equippedBadge_);
            break;
          }
          case 106: {
            if (contactSettings_ == null) {
              contactSettings_ = new global::POGOProtos.Data.Player.ContactSettings();
            }
            input.ReadMessage(contactSettings_);
            break;
          }
          case 114: {
            currencies_.AddEntriesFrom(input, _repeated_currencies_codec);
            break;
          }
          case 120: {
            RemainingCodenameClaims = input.ReadInt32();
            break;
          }
          case 130: {
            if (buddyPokemon_ == null) {
              buddyPokemon_ = new global::POGOProtos.Data.BuddyPokemon();
            }
            input.ReadMessage(buddyPokemon_);
            break;
          }
          case 136: {
            BattleLockoutEndMs = input.ReadInt64();
            break;
          }
          case 146: {
            if (secondaryPlayerAvatar_ == null) {
              secondaryPlayerAvatar_ = new global::POGOProtos.Data.Player.PlayerAvatar();
            }
            input.ReadMessage(secondaryPlayerAvatar_);
            break;
          }
          case 152: {
            NameIsBlacklisted = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
