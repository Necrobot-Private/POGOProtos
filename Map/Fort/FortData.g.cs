// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Map/Fort/FortData.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Map.Fort {

  /// <summary>Holder for reflection information generated from POGOProtos/Map/Fort/FortData.proto</summary>
  public static partial class FortDataReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Map/Fort/FortData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FortDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJQT0dPUHJvdG9zL01hcC9Gb3J0L0ZvcnREYXRhLnByb3RvEhNQT0dPUHJv",
            "dG9zLk1hcC5Gb3J0GiRQT0dPUHJvdG9zL0RhdGEvUG9rZW1vbkRpc3BsYXku",
            "cHJvdG8aI1BPR09Qcm90b3MvRGF0YS9SYWlkL1JhaWRJbmZvLnByb3RvGiBQ",
            "T0dPUHJvdG9zL0VudW1zL1Bva2Vtb25JZC5wcm90bxogUE9HT1Byb3Rvcy9F",
            "bnVtcy9UZWFtQ29sb3IucHJvdG8aJlBPR09Qcm90b3MvSW52ZW50b3J5L0l0",
            "ZW0vSXRlbUlkLnByb3RvGiRQT0dPUHJvdG9zL01hcC9Gb3J0L0d5bURpc3Bs",
            "YXkucHJvdG8aIlBPR09Qcm90b3MvTWFwL0ZvcnQvRm9ydFR5cGUucHJvdG8a",
            "JVBPR09Qcm90b3MvTWFwL0ZvcnQvRm9ydFNwb25zb3IucHJvdG8aK1BPR09Q",
            "cm90b3MvTWFwL0ZvcnQvRm9ydFJlbmRlcmluZ1R5cGUucHJvdG8aJlBPR09Q",
            "cm90b3MvTWFwL0ZvcnQvRm9ydEx1cmVJbmZvLnByb3RvIqwHCghGb3J0RGF0",
            "YRIKCgJpZBgBIAEoCRIiChpsYXN0X21vZGlmaWVkX3RpbWVzdGFtcF9tcxgC",
            "IAEoAxIQCghsYXRpdHVkZRgDIAEoARIRCglsb25naXR1ZGUYBCABKAESMgoN",
            "b3duZWRfYnlfdGVhbRgFIAEoDjIbLlBPR09Qcm90b3MuRW51bXMuVGVhbUNv",
            "bG9yEjUKEGd1YXJkX3Bva2Vtb25faWQYBiABKA4yGy5QT0dPUHJvdG9zLkVu",
            "dW1zLlBva2Vtb25JZBIYChBndWFyZF9wb2tlbW9uX2NwGAcgASgFEg8KB2Vu",
            "YWJsZWQYCCABKAgSKwoEdHlwZRgJIAEoDjIdLlBPR09Qcm90b3MuTWFwLkZv",
            "cnQuRm9ydFR5cGUSEgoKZ3ltX3BvaW50cxgKIAEoAxIUCgxpc19pbl9iYXR0",
            "bGUYCyABKAgSPwoUYWN0aXZlX2ZvcnRfbW9kaWZpZXIYDCADKA4yIS5QT0dP",
            "UHJvdG9zLkludmVudG9yeS5JdGVtLkl0ZW1JZBI0CglsdXJlX2luZm8YDSAB",
            "KAsyIS5QT0dPUHJvdG9zLk1hcC5Gb3J0LkZvcnRMdXJlSW5mbxImCh5jb29s",
            "ZG93bl9jb21wbGV0ZV90aW1lc3RhbXBfbXMYDiABKAMSMQoHc3BvbnNvchgP",
            "IAEoDjIgLlBPR09Qcm90b3MuTWFwLkZvcnQuRm9ydFNwb25zb3ISPgoOcmVu",
            "ZGVyaW5nX3R5cGUYECABKA4yJi5QT0dPUHJvdG9zLk1hcC5Gb3J0LkZvcnRS",
            "ZW5kZXJpbmdUeXBlEh0KFWRlcGxveV9sb2Nrb3V0X2VuZF9tcxgRIAEoAxI+",
            "ChVndWFyZF9wb2tlbW9uX2Rpc3BsYXkYEiABKAsyHy5QT0dPUHJvdG9zLkRh",
            "dGEuUG9rZW1vbkRpc3BsYXkSDgoGY2xvc2VkGBMgASgIEjEKCXJhaWRfaW5m",
            "bxgUIAEoCzIeLlBPR09Qcm90b3MuRGF0YS5SYWlkLlJhaWRJbmZvEjQKC2d5",
            "bV9kaXNwbGF5GBUgASgLMh8uUE9HT1Byb3Rvcy5NYXAuRm9ydC5HeW1EaXNw",
            "bGF5Eg8KB3Zpc2l0ZWQYFiABKAgSJwofc2FtZV90ZWFtX2RlcGxveV9sb2Nr",
            "b3V0X2VuZF9tcxgXIAEoAxIVCg1hbGxvd19jaGVja2luGBggASgIEhEKCWlt",
            "YWdlX3VybBgZIAEoCRIQCghpbl9ldmVudBgaIAEoCGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.PokemonDisplayReflection.Descriptor, global::POGOProtos.Data.Raid.RaidInfoReflection.Descriptor, global::POGOProtos.Enums.PokemonIdReflection.Descriptor, global::POGOProtos.Enums.TeamColorReflection.Descriptor, global::POGOProtos.Inventory.Item.ItemIdReflection.Descriptor, global::POGOProtos.Map.Fort.GymDisplayReflection.Descriptor, global::POGOProtos.Map.Fort.FortTypeReflection.Descriptor, global::POGOProtos.Map.Fort.FortSponsorReflection.Descriptor, global::POGOProtos.Map.Fort.FortRenderingTypeReflection.Descriptor, global::POGOProtos.Map.Fort.FortLureInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Map.Fort.FortData), global::POGOProtos.Map.Fort.FortData.Parser, new[]{ "Id", "LastModifiedTimestampMs", "Latitude", "Longitude", "OwnedByTeam", "GuardPokemonId", "GuardPokemonCp", "Enabled", "Type", "GymPoints", "IsInBattle", "ActiveFortModifier", "LureInfo", "CooldownCompleteTimestampMs", "Sponsor", "RenderingType", "DeployLockoutEndMs", "GuardPokemonDisplay", "Closed", "RaidInfo", "GymDisplay", "Visited", "SameTeamDeployLockoutEndMs", "AllowCheckin", "ImageUrl", "InEvent" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FortData : pb::IMessage<FortData> {
    private static readonly pb::MessageParser<FortData> _parser = new pb::MessageParser<FortData>(() => new FortData());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FortData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Map.Fort.FortDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FortData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FortData(FortData other) : this() {
      id_ = other.id_;
      lastModifiedTimestampMs_ = other.lastModifiedTimestampMs_;
      latitude_ = other.latitude_;
      longitude_ = other.longitude_;
      ownedByTeam_ = other.ownedByTeam_;
      guardPokemonId_ = other.guardPokemonId_;
      guardPokemonCp_ = other.guardPokemonCp_;
      enabled_ = other.enabled_;
      type_ = other.type_;
      gymPoints_ = other.gymPoints_;
      isInBattle_ = other.isInBattle_;
      activeFortModifier_ = other.activeFortModifier_.Clone();
      LureInfo = other.lureInfo_ != null ? other.LureInfo.Clone() : null;
      cooldownCompleteTimestampMs_ = other.cooldownCompleteTimestampMs_;
      sponsor_ = other.sponsor_;
      renderingType_ = other.renderingType_;
      deployLockoutEndMs_ = other.deployLockoutEndMs_;
      GuardPokemonDisplay = other.guardPokemonDisplay_ != null ? other.GuardPokemonDisplay.Clone() : null;
      closed_ = other.closed_;
      RaidInfo = other.raidInfo_ != null ? other.RaidInfo.Clone() : null;
      GymDisplay = other.gymDisplay_ != null ? other.GymDisplay.Clone() : null;
      visited_ = other.visited_;
      sameTeamDeployLockoutEndMs_ = other.sameTeamDeployLockoutEndMs_;
      allowCheckin_ = other.allowCheckin_;
      imageUrl_ = other.imageUrl_;
      inEvent_ = other.inEvent_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FortData Clone() {
      return new FortData(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "last_modified_timestamp_ms" field.</summary>
    public const int LastModifiedTimestampMsFieldNumber = 2;
    private long lastModifiedTimestampMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long LastModifiedTimestampMs {
      get { return lastModifiedTimestampMs_; }
      set {
        lastModifiedTimestampMs_ = value;
      }
    }

    /// <summary>Field number for the "latitude" field.</summary>
    public const int LatitudeFieldNumber = 3;
    private double latitude_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Latitude {
      get { return latitude_; }
      set {
        latitude_ = value;
      }
    }

    /// <summary>Field number for the "longitude" field.</summary>
    public const int LongitudeFieldNumber = 4;
    private double longitude_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Longitude {
      get { return longitude_; }
      set {
        longitude_ = value;
      }
    }

    /// <summary>Field number for the "owned_by_team" field.</summary>
    public const int OwnedByTeamFieldNumber = 5;
    private global::POGOProtos.Enums.TeamColor ownedByTeam_ = 0;
    /// <summary>
    /// (Gym only) Team that owns the gym.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.TeamColor OwnedByTeam {
      get { return ownedByTeam_; }
      set {
        ownedByTeam_ = value;
      }
    }

    /// <summary>Field number for the "guard_pokemon_id" field.</summary>
    public const int GuardPokemonIdFieldNumber = 6;
    private global::POGOProtos.Enums.PokemonId guardPokemonId_ = 0;
    /// <summary>
    /// (Gym only) Highest CP Pokemon ID at the gym.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.PokemonId GuardPokemonId {
      get { return guardPokemonId_; }
      set {
        guardPokemonId_ = value;
      }
    }

    /// <summary>Field number for the "guard_pokemon_cp" field.</summary>
    public const int GuardPokemonCpFieldNumber = 7;
    private int guardPokemonCp_;
    /// <summary>
    /// (Gym only) Highest CP Pokemon at the gym.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int GuardPokemonCp {
      get { return guardPokemonCp_; }
      set {
        guardPokemonCp_ = value;
      }
    }

    /// <summary>Field number for the "enabled" field.</summary>
    public const int EnabledFieldNumber = 8;
    private bool enabled_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Enabled {
      get { return enabled_; }
      set {
        enabled_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 9;
    private global::POGOProtos.Map.Fort.FortType type_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Map.Fort.FortType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "gym_points" field.</summary>
    public const int GymPointsFieldNumber = 10;
    private long gymPoints_;
    /// <summary>
    /// (Gym only) Prestigate / experience of the gym.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long GymPoints {
      get { return gymPoints_; }
      set {
        gymPoints_ = value;
      }
    }

    /// <summary>Field number for the "is_in_battle" field.</summary>
    public const int IsInBattleFieldNumber = 11;
    private bool isInBattle_;
    /// <summary>
    /// (Gym only) Whether someone is battling at the gym currently.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsInBattle {
      get { return isInBattle_; }
      set {
        isInBattle_ = value;
      }
    }

    /// <summary>Field number for the "active_fort_modifier" field.</summary>
    public const int ActiveFortModifierFieldNumber = 12;
    private static readonly pb::FieldCodec<global::POGOProtos.Inventory.Item.ItemId> _repeated_activeFortModifier_codec
        = pb::FieldCodec.ForEnum(98, x => (int) x, x => (global::POGOProtos.Inventory.Item.ItemId) x);
    private readonly pbc::RepeatedField<global::POGOProtos.Inventory.Item.ItemId> activeFortModifier_ = new pbc::RepeatedField<global::POGOProtos.Inventory.Item.ItemId>();
    /// <summary>
    /// (Pokestop only)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Inventory.Item.ItemId> ActiveFortModifier {
      get { return activeFortModifier_; }
    }

    /// <summary>Field number for the "lure_info" field.</summary>
    public const int LureInfoFieldNumber = 13;
    private global::POGOProtos.Map.Fort.FortLureInfo lureInfo_;
    /// <summary>
    /// (Pokestop only)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Map.Fort.FortLureInfo LureInfo {
      get { return lureInfo_; }
      set {
        lureInfo_ = value;
      }
    }

    /// <summary>Field number for the "cooldown_complete_timestamp_ms" field.</summary>
    public const int CooldownCompleteTimestampMsFieldNumber = 14;
    private long cooldownCompleteTimestampMs_;
    /// <summary>
    /// (Pokestop only) Timestamp when the pokestop can be activated again to get items / xp.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long CooldownCompleteTimestampMs {
      get { return cooldownCompleteTimestampMs_; }
      set {
        cooldownCompleteTimestampMs_ = value;
      }
    }

    /// <summary>Field number for the "sponsor" field.</summary>
    public const int SponsorFieldNumber = 15;
    private global::POGOProtos.Map.Fort.FortSponsor sponsor_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Map.Fort.FortSponsor Sponsor {
      get { return sponsor_; }
      set {
        sponsor_ = value;
      }
    }

    /// <summary>Field number for the "rendering_type" field.</summary>
    public const int RenderingTypeFieldNumber = 16;
    private global::POGOProtos.Map.Fort.FortRenderingType renderingType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Map.Fort.FortRenderingType RenderingType {
      get { return renderingType_; }
      set {
        renderingType_ = value;
      }
    }

    /// <summary>Field number for the "deploy_lockout_end_ms" field.</summary>
    public const int DeployLockoutEndMsFieldNumber = 17;
    private long deployLockoutEndMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long DeployLockoutEndMs {
      get { return deployLockoutEndMs_; }
      set {
        deployLockoutEndMs_ = value;
      }
    }

    /// <summary>Field number for the "guard_pokemon_display" field.</summary>
    public const int GuardPokemonDisplayFieldNumber = 18;
    private global::POGOProtos.Data.PokemonDisplay guardPokemonDisplay_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.PokemonDisplay GuardPokemonDisplay {
      get { return guardPokemonDisplay_; }
      set {
        guardPokemonDisplay_ = value;
      }
    }

    /// <summary>Field number for the "closed" field.</summary>
    public const int ClosedFieldNumber = 19;
    private bool closed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Closed {
      get { return closed_; }
      set {
        closed_ = value;
      }
    }

    /// <summary>Field number for the "raid_info" field.</summary>
    public const int RaidInfoFieldNumber = 20;
    private global::POGOProtos.Data.Raid.RaidInfo raidInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Raid.RaidInfo RaidInfo {
      get { return raidInfo_; }
      set {
        raidInfo_ = value;
      }
    }

    /// <summary>Field number for the "gym_display" field.</summary>
    public const int GymDisplayFieldNumber = 21;
    private global::POGOProtos.Map.Fort.GymDisplay gymDisplay_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Map.Fort.GymDisplay GymDisplay {
      get { return gymDisplay_; }
      set {
        gymDisplay_ = value;
      }
    }

    /// <summary>Field number for the "visited" field.</summary>
    public const int VisitedFieldNumber = 22;
    private bool visited_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Visited {
      get { return visited_; }
      set {
        visited_ = value;
      }
    }

    /// <summary>Field number for the "same_team_deploy_lockout_end_ms" field.</summary>
    public const int SameTeamDeployLockoutEndMsFieldNumber = 23;
    private long sameTeamDeployLockoutEndMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long SameTeamDeployLockoutEndMs {
      get { return sameTeamDeployLockoutEndMs_; }
      set {
        sameTeamDeployLockoutEndMs_ = value;
      }
    }

    /// <summary>Field number for the "allow_checkin" field.</summary>
    public const int AllowCheckinFieldNumber = 24;
    private bool allowCheckin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool AllowCheckin {
      get { return allowCheckin_; }
      set {
        allowCheckin_ = value;
      }
    }

    /// <summary>Field number for the "image_url" field.</summary>
    public const int ImageUrlFieldNumber = 25;
    private string imageUrl_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ImageUrl {
      get { return imageUrl_; }
      set {
        imageUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "in_event" field.</summary>
    public const int InEventFieldNumber = 26;
    private bool inEvent_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool InEvent {
      get { return inEvent_; }
      set {
        inEvent_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FortData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FortData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (LastModifiedTimestampMs != other.LastModifiedTimestampMs) return false;
      if (Latitude != other.Latitude) return false;
      if (Longitude != other.Longitude) return false;
      if (OwnedByTeam != other.OwnedByTeam) return false;
      if (GuardPokemonId != other.GuardPokemonId) return false;
      if (GuardPokemonCp != other.GuardPokemonCp) return false;
      if (Enabled != other.Enabled) return false;
      if (Type != other.Type) return false;
      if (GymPoints != other.GymPoints) return false;
      if (IsInBattle != other.IsInBattle) return false;
      if(!activeFortModifier_.Equals(other.activeFortModifier_)) return false;
      if (!object.Equals(LureInfo, other.LureInfo)) return false;
      if (CooldownCompleteTimestampMs != other.CooldownCompleteTimestampMs) return false;
      if (Sponsor != other.Sponsor) return false;
      if (RenderingType != other.RenderingType) return false;
      if (DeployLockoutEndMs != other.DeployLockoutEndMs) return false;
      if (!object.Equals(GuardPokemonDisplay, other.GuardPokemonDisplay)) return false;
      if (Closed != other.Closed) return false;
      if (!object.Equals(RaidInfo, other.RaidInfo)) return false;
      if (!object.Equals(GymDisplay, other.GymDisplay)) return false;
      if (Visited != other.Visited) return false;
      if (SameTeamDeployLockoutEndMs != other.SameTeamDeployLockoutEndMs) return false;
      if (AllowCheckin != other.AllowCheckin) return false;
      if (ImageUrl != other.ImageUrl) return false;
      if (InEvent != other.InEvent) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (LastModifiedTimestampMs != 0L) hash ^= LastModifiedTimestampMs.GetHashCode();
      if (Latitude != 0D) hash ^= Latitude.GetHashCode();
      if (Longitude != 0D) hash ^= Longitude.GetHashCode();
      if (OwnedByTeam != 0) hash ^= OwnedByTeam.GetHashCode();
      if (GuardPokemonId != 0) hash ^= GuardPokemonId.GetHashCode();
      if (GuardPokemonCp != 0) hash ^= GuardPokemonCp.GetHashCode();
      if (Enabled != false) hash ^= Enabled.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
      if (GymPoints != 0L) hash ^= GymPoints.GetHashCode();
      if (IsInBattle != false) hash ^= IsInBattle.GetHashCode();
      hash ^= activeFortModifier_.GetHashCode();
      if (lureInfo_ != null) hash ^= LureInfo.GetHashCode();
      if (CooldownCompleteTimestampMs != 0L) hash ^= CooldownCompleteTimestampMs.GetHashCode();
      if (Sponsor != 0) hash ^= Sponsor.GetHashCode();
      if (RenderingType != 0) hash ^= RenderingType.GetHashCode();
      if (DeployLockoutEndMs != 0L) hash ^= DeployLockoutEndMs.GetHashCode();
      if (guardPokemonDisplay_ != null) hash ^= GuardPokemonDisplay.GetHashCode();
      if (Closed != false) hash ^= Closed.GetHashCode();
      if (raidInfo_ != null) hash ^= RaidInfo.GetHashCode();
      if (gymDisplay_ != null) hash ^= GymDisplay.GetHashCode();
      if (Visited != false) hash ^= Visited.GetHashCode();
      if (SameTeamDeployLockoutEndMs != 0L) hash ^= SameTeamDeployLockoutEndMs.GetHashCode();
      if (AllowCheckin != false) hash ^= AllowCheckin.GetHashCode();
      if (ImageUrl.Length != 0) hash ^= ImageUrl.GetHashCode();
      if (InEvent != false) hash ^= InEvent.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (LastModifiedTimestampMs != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(LastModifiedTimestampMs);
      }
      if (Latitude != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(Latitude);
      }
      if (Longitude != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Longitude);
      }
      if (OwnedByTeam != 0) {
        output.WriteRawTag(40);
        output.WriteEnum((int) OwnedByTeam);
      }
      if (GuardPokemonId != 0) {
        output.WriteRawTag(48);
        output.WriteEnum((int) GuardPokemonId);
      }
      if (GuardPokemonCp != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(GuardPokemonCp);
      }
      if (Enabled != false) {
        output.WriteRawTag(64);
        output.WriteBool(Enabled);
      }
      if (Type != 0) {
        output.WriteRawTag(72);
        output.WriteEnum((int) Type);
      }
      if (GymPoints != 0L) {
        output.WriteRawTag(80);
        output.WriteInt64(GymPoints);
      }
      if (IsInBattle != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsInBattle);
      }
      activeFortModifier_.WriteTo(output, _repeated_activeFortModifier_codec);
      if (lureInfo_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(LureInfo);
      }
      if (CooldownCompleteTimestampMs != 0L) {
        output.WriteRawTag(112);
        output.WriteInt64(CooldownCompleteTimestampMs);
      }
      if (Sponsor != 0) {
        output.WriteRawTag(120);
        output.WriteEnum((int) Sponsor);
      }
      if (RenderingType != 0) {
        output.WriteRawTag(128, 1);
        output.WriteEnum((int) RenderingType);
      }
      if (DeployLockoutEndMs != 0L) {
        output.WriteRawTag(136, 1);
        output.WriteInt64(DeployLockoutEndMs);
      }
      if (guardPokemonDisplay_ != null) {
        output.WriteRawTag(146, 1);
        output.WriteMessage(GuardPokemonDisplay);
      }
      if (Closed != false) {
        output.WriteRawTag(152, 1);
        output.WriteBool(Closed);
      }
      if (raidInfo_ != null) {
        output.WriteRawTag(162, 1);
        output.WriteMessage(RaidInfo);
      }
      if (gymDisplay_ != null) {
        output.WriteRawTag(170, 1);
        output.WriteMessage(GymDisplay);
      }
      if (Visited != false) {
        output.WriteRawTag(176, 1);
        output.WriteBool(Visited);
      }
      if (SameTeamDeployLockoutEndMs != 0L) {
        output.WriteRawTag(184, 1);
        output.WriteInt64(SameTeamDeployLockoutEndMs);
      }
      if (AllowCheckin != false) {
        output.WriteRawTag(192, 1);
        output.WriteBool(AllowCheckin);
      }
      if (ImageUrl.Length != 0) {
        output.WriteRawTag(202, 1);
        output.WriteString(ImageUrl);
      }
      if (InEvent != false) {
        output.WriteRawTag(208, 1);
        output.WriteBool(InEvent);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (LastModifiedTimestampMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(LastModifiedTimestampMs);
      }
      if (Latitude != 0D) {
        size += 1 + 8;
      }
      if (Longitude != 0D) {
        size += 1 + 8;
      }
      if (OwnedByTeam != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OwnedByTeam);
      }
      if (GuardPokemonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) GuardPokemonId);
      }
      if (GuardPokemonCp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(GuardPokemonCp);
      }
      if (Enabled != false) {
        size += 1 + 1;
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (GymPoints != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(GymPoints);
      }
      if (IsInBattle != false) {
        size += 1 + 1;
      }
      size += activeFortModifier_.CalculateSize(_repeated_activeFortModifier_codec);
      if (lureInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LureInfo);
      }
      if (CooldownCompleteTimestampMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CooldownCompleteTimestampMs);
      }
      if (Sponsor != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Sponsor);
      }
      if (RenderingType != 0) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) RenderingType);
      }
      if (DeployLockoutEndMs != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(DeployLockoutEndMs);
      }
      if (guardPokemonDisplay_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(GuardPokemonDisplay);
      }
      if (Closed != false) {
        size += 2 + 1;
      }
      if (raidInfo_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(RaidInfo);
      }
      if (gymDisplay_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(GymDisplay);
      }
      if (Visited != false) {
        size += 2 + 1;
      }
      if (SameTeamDeployLockoutEndMs != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(SameTeamDeployLockoutEndMs);
      }
      if (AllowCheckin != false) {
        size += 2 + 1;
      }
      if (ImageUrl.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(ImageUrl);
      }
      if (InEvent != false) {
        size += 2 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FortData other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.LastModifiedTimestampMs != 0L) {
        LastModifiedTimestampMs = other.LastModifiedTimestampMs;
      }
      if (other.Latitude != 0D) {
        Latitude = other.Latitude;
      }
      if (other.Longitude != 0D) {
        Longitude = other.Longitude;
      }
      if (other.OwnedByTeam != 0) {
        OwnedByTeam = other.OwnedByTeam;
      }
      if (other.GuardPokemonId != 0) {
        GuardPokemonId = other.GuardPokemonId;
      }
      if (other.GuardPokemonCp != 0) {
        GuardPokemonCp = other.GuardPokemonCp;
      }
      if (other.Enabled != false) {
        Enabled = other.Enabled;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.GymPoints != 0L) {
        GymPoints = other.GymPoints;
      }
      if (other.IsInBattle != false) {
        IsInBattle = other.IsInBattle;
      }
      activeFortModifier_.Add(other.activeFortModifier_);
      if (other.lureInfo_ != null) {
        if (lureInfo_ == null) {
          lureInfo_ = new global::POGOProtos.Map.Fort.FortLureInfo();
        }
        LureInfo.MergeFrom(other.LureInfo);
      }
      if (other.CooldownCompleteTimestampMs != 0L) {
        CooldownCompleteTimestampMs = other.CooldownCompleteTimestampMs;
      }
      if (other.Sponsor != 0) {
        Sponsor = other.Sponsor;
      }
      if (other.RenderingType != 0) {
        RenderingType = other.RenderingType;
      }
      if (other.DeployLockoutEndMs != 0L) {
        DeployLockoutEndMs = other.DeployLockoutEndMs;
      }
      if (other.guardPokemonDisplay_ != null) {
        if (guardPokemonDisplay_ == null) {
          guardPokemonDisplay_ = new global::POGOProtos.Data.PokemonDisplay();
        }
        GuardPokemonDisplay.MergeFrom(other.GuardPokemonDisplay);
      }
      if (other.Closed != false) {
        Closed = other.Closed;
      }
      if (other.raidInfo_ != null) {
        if (raidInfo_ == null) {
          raidInfo_ = new global::POGOProtos.Data.Raid.RaidInfo();
        }
        RaidInfo.MergeFrom(other.RaidInfo);
      }
      if (other.gymDisplay_ != null) {
        if (gymDisplay_ == null) {
          gymDisplay_ = new global::POGOProtos.Map.Fort.GymDisplay();
        }
        GymDisplay.MergeFrom(other.GymDisplay);
      }
      if (other.Visited != false) {
        Visited = other.Visited;
      }
      if (other.SameTeamDeployLockoutEndMs != 0L) {
        SameTeamDeployLockoutEndMs = other.SameTeamDeployLockoutEndMs;
      }
      if (other.AllowCheckin != false) {
        AllowCheckin = other.AllowCheckin;
      }
      if (other.ImageUrl.Length != 0) {
        ImageUrl = other.ImageUrl;
      }
      if (other.InEvent != false) {
        InEvent = other.InEvent;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 16: {
            LastModifiedTimestampMs = input.ReadInt64();
            break;
          }
          case 25: {
            Latitude = input.ReadDouble();
            break;
          }
          case 33: {
            Longitude = input.ReadDouble();
            break;
          }
          case 40: {
            ownedByTeam_ = (global::POGOProtos.Enums.TeamColor) input.ReadEnum();
            break;
          }
          case 48: {
            guardPokemonId_ = (global::POGOProtos.Enums.PokemonId) input.ReadEnum();
            break;
          }
          case 56: {
            GuardPokemonCp = input.ReadInt32();
            break;
          }
          case 64: {
            Enabled = input.ReadBool();
            break;
          }
          case 72: {
            type_ = (global::POGOProtos.Map.Fort.FortType) input.ReadEnum();
            break;
          }
          case 80: {
            GymPoints = input.ReadInt64();
            break;
          }
          case 88: {
            IsInBattle = input.ReadBool();
            break;
          }
          case 98:
          case 96: {
            activeFortModifier_.AddEntriesFrom(input, _repeated_activeFortModifier_codec);
            break;
          }
          case 106: {
            if (lureInfo_ == null) {
              lureInfo_ = new global::POGOProtos.Map.Fort.FortLureInfo();
            }
            input.ReadMessage(lureInfo_);
            break;
          }
          case 112: {
            CooldownCompleteTimestampMs = input.ReadInt64();
            break;
          }
          case 120: {
            sponsor_ = (global::POGOProtos.Map.Fort.FortSponsor) input.ReadEnum();
            break;
          }
          case 128: {
            renderingType_ = (global::POGOProtos.Map.Fort.FortRenderingType) input.ReadEnum();
            break;
          }
          case 136: {
            DeployLockoutEndMs = input.ReadInt64();
            break;
          }
          case 146: {
            if (guardPokemonDisplay_ == null) {
              guardPokemonDisplay_ = new global::POGOProtos.Data.PokemonDisplay();
            }
            input.ReadMessage(guardPokemonDisplay_);
            break;
          }
          case 152: {
            Closed = input.ReadBool();
            break;
          }
          case 162: {
            if (raidInfo_ == null) {
              raidInfo_ = new global::POGOProtos.Data.Raid.RaidInfo();
            }
            input.ReadMessage(raidInfo_);
            break;
          }
          case 170: {
            if (gymDisplay_ == null) {
              gymDisplay_ = new global::POGOProtos.Map.Fort.GymDisplay();
            }
            input.ReadMessage(gymDisplay_);
            break;
          }
          case 176: {
            Visited = input.ReadBool();
            break;
          }
          case 184: {
            SameTeamDeployLockoutEndMs = input.ReadInt64();
            break;
          }
          case 192: {
            AllowCheckin = input.ReadBool();
            break;
          }
          case 202: {
            ImageUrl = input.ReadString();
            break;
          }
          case 208: {
            InEvent = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
