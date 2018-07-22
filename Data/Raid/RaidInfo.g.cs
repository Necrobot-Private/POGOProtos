// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Data/Raid/RaidInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Raid {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Raid/RaidInfo.proto</summary>
  public static partial class RaidInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Raid/RaidInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RaidInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNQT0dPUHJvdG9zL0RhdGEvUmFpZC9SYWlkSW5mby5wcm90bxIUUE9HT1By",
            "b3Rvcy5EYXRhLlJhaWQaIVBPR09Qcm90b3MvRGF0YS9Qb2tlbW9uRGF0YS5w",
            "cm90bxogUE9HT1Byb3Rvcy9FbnVtcy9SYWlkTGV2ZWwucHJvdG8ihgIKCFJh",
            "aWRJbmZvEhEKCXJhaWRfc2VlZBgBIAEoAxIVCg1yYWlkX3NwYXduX21zGAIg",
            "ASgDEhYKDnJhaWRfYmF0dGxlX21zGAMgASgDEhMKC3JhaWRfZW5kX21zGAQg",
            "ASgDEjIKDHJhaWRfcG9rZW1vbhgFIAEoCzIcLlBPR09Qcm90b3MuRGF0YS5Q",
            "b2tlbW9uRGF0YRIvCgpyYWlkX2xldmVsGAYgASgOMhsuUE9HT1Byb3Rvcy5F",
            "bnVtcy5SYWlkTGV2ZWwSEAoIY29tcGxldGUYByABKAgSFAoMaXNfZXhjbHVz",
            "aXZlGAggASgIEhYKDmlzX3JhaWRfaGlkZGVuGAkgASgIYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.PokemonDataReflection.Descriptor, global::POGOProtos.Enums.RaidLevelReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Raid.RaidInfo), global::POGOProtos.Data.Raid.RaidInfo.Parser, new[]{ "RaidSeed", "RaidSpawnMs", "RaidBattleMs", "RaidEndMs", "RaidPokemon", "RaidLevel", "Complete", "IsExclusive", "IsRaidHidden" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RaidInfo : pb::IMessage<RaidInfo> {
    private static readonly pb::MessageParser<RaidInfo> _parser = new pb::MessageParser<RaidInfo>(() => new RaidInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RaidInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Raid.RaidInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RaidInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RaidInfo(RaidInfo other) : this() {
      raidSeed_ = other.raidSeed_;
      raidSpawnMs_ = other.raidSpawnMs_;
      raidBattleMs_ = other.raidBattleMs_;
      raidEndMs_ = other.raidEndMs_;
      raidPokemon_ = other.raidPokemon_ != null ? other.raidPokemon_.Clone() : null;
      raidLevel_ = other.raidLevel_;
      complete_ = other.complete_;
      isExclusive_ = other.isExclusive_;
      isRaidHidden_ = other.isRaidHidden_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RaidInfo Clone() {
      return new RaidInfo(this);
    }

    /// <summary>Field number for the "raid_seed" field.</summary>
    public const int RaidSeedFieldNumber = 1;
    private long raidSeed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long RaidSeed {
      get { return raidSeed_; }
      set {
        raidSeed_ = value;
      }
    }

    /// <summary>Field number for the "raid_spawn_ms" field.</summary>
    public const int RaidSpawnMsFieldNumber = 2;
    private long raidSpawnMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long RaidSpawnMs {
      get { return raidSpawnMs_; }
      set {
        raidSpawnMs_ = value;
      }
    }

    /// <summary>Field number for the "raid_battle_ms" field.</summary>
    public const int RaidBattleMsFieldNumber = 3;
    private long raidBattleMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long RaidBattleMs {
      get { return raidBattleMs_; }
      set {
        raidBattleMs_ = value;
      }
    }

    /// <summary>Field number for the "raid_end_ms" field.</summary>
    public const int RaidEndMsFieldNumber = 4;
    private long raidEndMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long RaidEndMs {
      get { return raidEndMs_; }
      set {
        raidEndMs_ = value;
      }
    }

    /// <summary>Field number for the "raid_pokemon" field.</summary>
    public const int RaidPokemonFieldNumber = 5;
    private global::POGOProtos.Data.PokemonData raidPokemon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.PokemonData RaidPokemon {
      get { return raidPokemon_; }
      set {
        raidPokemon_ = value;
      }
    }

    /// <summary>Field number for the "raid_level" field.</summary>
    public const int RaidLevelFieldNumber = 6;
    private global::POGOProtos.Enums.RaidLevel raidLevel_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.RaidLevel RaidLevel {
      get { return raidLevel_; }
      set {
        raidLevel_ = value;
      }
    }

    /// <summary>Field number for the "complete" field.</summary>
    public const int CompleteFieldNumber = 7;
    private bool complete_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Complete {
      get { return complete_; }
      set {
        complete_ = value;
      }
    }

    /// <summary>Field number for the "is_exclusive" field.</summary>
    public const int IsExclusiveFieldNumber = 8;
    private bool isExclusive_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsExclusive {
      get { return isExclusive_; }
      set {
        isExclusive_ = value;
      }
    }

    /// <summary>Field number for the "is_raid_hidden" field.</summary>
    public const int IsRaidHiddenFieldNumber = 9;
    private bool isRaidHidden_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsRaidHidden {
      get { return isRaidHidden_; }
      set {
        isRaidHidden_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RaidInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RaidInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RaidSeed != other.RaidSeed) return false;
      if (RaidSpawnMs != other.RaidSpawnMs) return false;
      if (RaidBattleMs != other.RaidBattleMs) return false;
      if (RaidEndMs != other.RaidEndMs) return false;
      if (!object.Equals(RaidPokemon, other.RaidPokemon)) return false;
      if (RaidLevel != other.RaidLevel) return false;
      if (Complete != other.Complete) return false;
      if (IsExclusive != other.IsExclusive) return false;
      if (IsRaidHidden != other.IsRaidHidden) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RaidSeed != 0L) hash ^= RaidSeed.GetHashCode();
      if (RaidSpawnMs != 0L) hash ^= RaidSpawnMs.GetHashCode();
      if (RaidBattleMs != 0L) hash ^= RaidBattleMs.GetHashCode();
      if (RaidEndMs != 0L) hash ^= RaidEndMs.GetHashCode();
      if (raidPokemon_ != null) hash ^= RaidPokemon.GetHashCode();
      if (RaidLevel != 0) hash ^= RaidLevel.GetHashCode();
      if (Complete != false) hash ^= Complete.GetHashCode();
      if (IsExclusive != false) hash ^= IsExclusive.GetHashCode();
      if (IsRaidHidden != false) hash ^= IsRaidHidden.GetHashCode();
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
      if (RaidSeed != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(RaidSeed);
      }
      if (RaidSpawnMs != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(RaidSpawnMs);
      }
      if (RaidBattleMs != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(RaidBattleMs);
      }
      if (RaidEndMs != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(RaidEndMs);
      }
      if (raidPokemon_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(RaidPokemon);
      }
      if (RaidLevel != 0) {
        output.WriteRawTag(48);
        output.WriteEnum((int) RaidLevel);
      }
      if (Complete != false) {
        output.WriteRawTag(56);
        output.WriteBool(Complete);
      }
      if (IsExclusive != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsExclusive);
      }
      if (IsRaidHidden != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsRaidHidden);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RaidSeed != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RaidSeed);
      }
      if (RaidSpawnMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RaidSpawnMs);
      }
      if (RaidBattleMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RaidBattleMs);
      }
      if (RaidEndMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RaidEndMs);
      }
      if (raidPokemon_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RaidPokemon);
      }
      if (RaidLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) RaidLevel);
      }
      if (Complete != false) {
        size += 1 + 1;
      }
      if (IsExclusive != false) {
        size += 1 + 1;
      }
      if (IsRaidHidden != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RaidInfo other) {
      if (other == null) {
        return;
      }
      if (other.RaidSeed != 0L) {
        RaidSeed = other.RaidSeed;
      }
      if (other.RaidSpawnMs != 0L) {
        RaidSpawnMs = other.RaidSpawnMs;
      }
      if (other.RaidBattleMs != 0L) {
        RaidBattleMs = other.RaidBattleMs;
      }
      if (other.RaidEndMs != 0L) {
        RaidEndMs = other.RaidEndMs;
      }
      if (other.raidPokemon_ != null) {
        if (raidPokemon_ == null) {
          raidPokemon_ = new global::POGOProtos.Data.PokemonData();
        }
        RaidPokemon.MergeFrom(other.RaidPokemon);
      }
      if (other.RaidLevel != 0) {
        RaidLevel = other.RaidLevel;
      }
      if (other.Complete != false) {
        Complete = other.Complete;
      }
      if (other.IsExclusive != false) {
        IsExclusive = other.IsExclusive;
      }
      if (other.IsRaidHidden != false) {
        IsRaidHidden = other.IsRaidHidden;
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
            RaidSeed = input.ReadInt64();
            break;
          }
          case 16: {
            RaidSpawnMs = input.ReadInt64();
            break;
          }
          case 24: {
            RaidBattleMs = input.ReadInt64();
            break;
          }
          case 32: {
            RaidEndMs = input.ReadInt64();
            break;
          }
          case 42: {
            if (raidPokemon_ == null) {
              raidPokemon_ = new global::POGOProtos.Data.PokemonData();
            }
            input.ReadMessage(raidPokemon_);
            break;
          }
          case 48: {
            raidLevel_ = (global::POGOProtos.Enums.RaidLevel) input.ReadEnum();
            break;
          }
          case 56: {
            Complete = input.ReadBool();
            break;
          }
          case 64: {
            IsExclusive = input.ReadBool();
            break;
          }
          case 72: {
            IsRaidHidden = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
