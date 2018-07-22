// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Data/Telemetry/DeployPokemonTelemetry.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Telemetry {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Telemetry/DeployPokemonTelemetry.proto</summary>
  public static partial class DeployPokemonTelemetryReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Telemetry/DeployPokemonTelemetry.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DeployPokemonTelemetryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZQT0dPUHJvdG9zL0RhdGEvVGVsZW1ldHJ5L0RlcGxveVBva2Vtb25UZWxl",
            "bWV0cnkucHJvdG8SGVBPR09Qcm90b3MuRGF0YS5UZWxlbWV0cnkaMFBPR09Q",
            "cm90b3MvRGF0YS9UZWxlbWV0cnkvUG9rZW1vblRlbGVtZXRyeS5wcm90byKc",
            "AQoWRGVwbG95UG9rZW1vblRlbGVtZXRyeRIOCgZzdGF0dXMYASABKAUSPAoH",
            "cG9rZW1vbhgCIAEoCzIrLlBPR09Qcm90b3MuRGF0YS5UZWxlbWV0cnkuUG9r",
            "ZW1vblRlbGVtZXRyeRIOCgZneW1faWQYAyABKAkSDAoEdGVhbRgEIAEoBRIW",
            "Cg5kZWZlbmRlcl9jb3VudBgFIAEoBWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.Telemetry.PokemonTelemetryReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Telemetry.DeployPokemonTelemetry), global::POGOProtos.Data.Telemetry.DeployPokemonTelemetry.Parser, new[]{ "Status", "Pokemon", "GymId", "Team", "DefenderCount" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DeployPokemonTelemetry : pb::IMessage<DeployPokemonTelemetry> {
    private static readonly pb::MessageParser<DeployPokemonTelemetry> _parser = new pb::MessageParser<DeployPokemonTelemetry>(() => new DeployPokemonTelemetry());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DeployPokemonTelemetry> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Telemetry.DeployPokemonTelemetryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeployPokemonTelemetry() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeployPokemonTelemetry(DeployPokemonTelemetry other) : this() {
      status_ = other.status_;
      pokemon_ = other.pokemon_ != null ? other.pokemon_.Clone() : null;
      gymId_ = other.gymId_;
      team_ = other.team_;
      defenderCount_ = other.defenderCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeployPokemonTelemetry Clone() {
      return new DeployPokemonTelemetry(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private int status_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "pokemon" field.</summary>
    public const int PokemonFieldNumber = 2;
    private global::POGOProtos.Data.Telemetry.PokemonTelemetry pokemon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Telemetry.PokemonTelemetry Pokemon {
      get { return pokemon_; }
      set {
        pokemon_ = value;
      }
    }

    /// <summary>Field number for the "gym_id" field.</summary>
    public const int GymIdFieldNumber = 3;
    private string gymId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string GymId {
      get { return gymId_; }
      set {
        gymId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
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

    /// <summary>Field number for the "defender_count" field.</summary>
    public const int DefenderCountFieldNumber = 5;
    private int defenderCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int DefenderCount {
      get { return defenderCount_; }
      set {
        defenderCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DeployPokemonTelemetry);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DeployPokemonTelemetry other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      if (!object.Equals(Pokemon, other.Pokemon)) return false;
      if (GymId != other.GymId) return false;
      if (Team != other.Team) return false;
      if (DefenderCount != other.DefenderCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != 0) hash ^= Status.GetHashCode();
      if (pokemon_ != null) hash ^= Pokemon.GetHashCode();
      if (GymId.Length != 0) hash ^= GymId.GetHashCode();
      if (Team != 0) hash ^= Team.GetHashCode();
      if (DefenderCount != 0) hash ^= DefenderCount.GetHashCode();
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
      if (Status != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Status);
      }
      if (pokemon_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Pokemon);
      }
      if (GymId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(GymId);
      }
      if (Team != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Team);
      }
      if (DefenderCount != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(DefenderCount);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Status);
      }
      if (pokemon_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pokemon);
      }
      if (GymId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GymId);
      }
      if (Team != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Team);
      }
      if (DefenderCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(DefenderCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DeployPokemonTelemetry other) {
      if (other == null) {
        return;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      if (other.pokemon_ != null) {
        if (pokemon_ == null) {
          pokemon_ = new global::POGOProtos.Data.Telemetry.PokemonTelemetry();
        }
        Pokemon.MergeFrom(other.Pokemon);
      }
      if (other.GymId.Length != 0) {
        GymId = other.GymId;
      }
      if (other.Team != 0) {
        Team = other.Team;
      }
      if (other.DefenderCount != 0) {
        DefenderCount = other.DefenderCount;
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
            Status = input.ReadInt32();
            break;
          }
          case 18: {
            if (pokemon_ == null) {
              pokemon_ = new global::POGOProtos.Data.Telemetry.PokemonTelemetry();
            }
            input.ReadMessage(pokemon_);
            break;
          }
          case 26: {
            GymId = input.ReadString();
            break;
          }
          case 32: {
            Team = input.ReadInt32();
            break;
          }
          case 40: {
            DefenderCount = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code