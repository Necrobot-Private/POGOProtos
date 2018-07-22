// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Data/Telemetry/MapEventsTelemetry.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Telemetry {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Telemetry/MapEventsTelemetry.proto</summary>
  public static partial class MapEventsTelemetryReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Telemetry/MapEventsTelemetry.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MapEventsTelemetryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJQT0dPUHJvdG9zL0RhdGEvVGVsZW1ldHJ5L01hcEV2ZW50c1RlbGVtZXRy",
            "eS5wcm90bxIZUE9HT1Byb3Rvcy5EYXRhLlRlbGVtZXRyeRosUE9HT1Byb3Rv",
            "cy9FbnVtcy9NYXBFdmVudHNUZWxlbWV0cnlJZHMucHJvdG8isQEKEk1hcEV2",
            "ZW50c1RlbGVtZXRyeRJDChJtYXBfZXZlbnRfY2xpY2tfaWQYASABKA4yJy5Q",
            "T0dPUHJvdG9zLkVudW1zLk1hcEV2ZW50c1RlbGVtZXRyeUlkcxIPCgdmb3J0",
            "X2lkGAIgASgJEhsKE2d1YXJkX3Bva2Vtb25fbGV2ZWwYAyADKAUSDAoEdGVh",
            "bRgEIAEoBRIaChJpc19wbGF5ZXJfaW5fcmFuZ2UYBSABKAhiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Enums.MapEventsTelemetryIdsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Telemetry.MapEventsTelemetry), global::POGOProtos.Data.Telemetry.MapEventsTelemetry.Parser, new[]{ "MapEventClickId", "FortId", "GuardPokemonLevel", "Team", "IsPlayerInRange" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MapEventsTelemetry : pb::IMessage<MapEventsTelemetry> {
    private static readonly pb::MessageParser<MapEventsTelemetry> _parser = new pb::MessageParser<MapEventsTelemetry>(() => new MapEventsTelemetry());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MapEventsTelemetry> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Telemetry.MapEventsTelemetryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MapEventsTelemetry() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MapEventsTelemetry(MapEventsTelemetry other) : this() {
      mapEventClickId_ = other.mapEventClickId_;
      fortId_ = other.fortId_;
      guardPokemonLevel_ = other.guardPokemonLevel_.Clone();
      team_ = other.team_;
      isPlayerInRange_ = other.isPlayerInRange_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MapEventsTelemetry Clone() {
      return new MapEventsTelemetry(this);
    }

    /// <summary>Field number for the "map_event_click_id" field.</summary>
    public const int MapEventClickIdFieldNumber = 1;
    private global::POGOProtos.Enums.MapEventsTelemetryIds mapEventClickId_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.MapEventsTelemetryIds MapEventClickId {
      get { return mapEventClickId_; }
      set {
        mapEventClickId_ = value;
      }
    }

    /// <summary>Field number for the "fort_id" field.</summary>
    public const int FortIdFieldNumber = 2;
    private string fortId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FortId {
      get { return fortId_; }
      set {
        fortId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "guard_pokemon_level" field.</summary>
    public const int GuardPokemonLevelFieldNumber = 3;
    private static readonly pb::FieldCodec<int> _repeated_guardPokemonLevel_codec
        = pb::FieldCodec.ForInt32(26);
    private readonly pbc::RepeatedField<int> guardPokemonLevel_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> GuardPokemonLevel {
      get { return guardPokemonLevel_; }
    }

    /// <summary>Field number for the "team" field.</summary>
    public const int TeamFieldNumber = 4;
    private int team_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Team {
      get { return team_; }
      set {
        team_ = value;
      }
    }

    /// <summary>Field number for the "is_player_in_range" field.</summary>
    public const int IsPlayerInRangeFieldNumber = 5;
    private bool isPlayerInRange_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsPlayerInRange {
      get { return isPlayerInRange_; }
      set {
        isPlayerInRange_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MapEventsTelemetry);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MapEventsTelemetry other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MapEventClickId != other.MapEventClickId) return false;
      if (FortId != other.FortId) return false;
      if(!guardPokemonLevel_.Equals(other.guardPokemonLevel_)) return false;
      if (Team != other.Team) return false;
      if (IsPlayerInRange != other.IsPlayerInRange) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (MapEventClickId != 0) hash ^= MapEventClickId.GetHashCode();
      if (FortId.Length != 0) hash ^= FortId.GetHashCode();
      hash ^= guardPokemonLevel_.GetHashCode();
      if (Team != 0) hash ^= Team.GetHashCode();
      if (IsPlayerInRange != false) hash ^= IsPlayerInRange.GetHashCode();
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
      if (MapEventClickId != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) MapEventClickId);
      }
      if (FortId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(FortId);
      }
      guardPokemonLevel_.WriteTo(output, _repeated_guardPokemonLevel_codec);
      if (Team != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Team);
      }
      if (IsPlayerInRange != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsPlayerInRange);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (MapEventClickId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MapEventClickId);
      }
      if (FortId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FortId);
      }
      size += guardPokemonLevel_.CalculateSize(_repeated_guardPokemonLevel_codec);
      if (Team != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Team);
      }
      if (IsPlayerInRange != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MapEventsTelemetry other) {
      if (other == null) {
        return;
      }
      if (other.MapEventClickId != 0) {
        MapEventClickId = other.MapEventClickId;
      }
      if (other.FortId.Length != 0) {
        FortId = other.FortId;
      }
      guardPokemonLevel_.Add(other.guardPokemonLevel_);
      if (other.Team != 0) {
        Team = other.Team;
      }
      if (other.IsPlayerInRange != false) {
        IsPlayerInRange = other.IsPlayerInRange;
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
            mapEventClickId_ = (global::POGOProtos.Enums.MapEventsTelemetryIds) input.ReadEnum();
            break;
          }
          case 18: {
            FortId = input.ReadString();
            break;
          }
          case 26:
          case 24: {
            guardPokemonLevel_.AddEntriesFrom(input, _repeated_guardPokemonLevel_codec);
            break;
          }
          case 32: {
            Team = input.ReadInt32();
            break;
          }
          case 40: {
            IsPlayerInRange = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code