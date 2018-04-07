// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Requests/Messages/DiskEncounterMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/DiskEncounterMessage.proto</summary>
  public static partial class DiskEncounterMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/DiskEncounterMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DiskEncounterMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkJQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvRGlz",
            "a0VuY291bnRlck1lc3NhZ2UucHJvdG8SJ1BPR09Qcm90b3MuTmV0d29ya2lu",
            "Zy5SZXF1ZXN0cy5NZXNzYWdlcyKiAQoURGlza0VuY291bnRlck1lc3NhZ2US",
            "FAoMZW5jb3VudGVyX2lkGAEgASgEEg8KB2ZvcnRfaWQYAiABKAkSFwoPcGxh",
            "eWVyX2xhdGl0dWRlGAMgASgBEhgKEHBsYXllcl9sb25naXR1ZGUYBCABKAES",
            "FwoPZ3ltX2xhdF9kZWdyZWVzGAUgASgBEhcKD2d5bV9sbmdfZGVncmVlcxgG",
            "IAEoAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Requests.Messages.DiskEncounterMessage), global::POGOProtos.Networking.Requests.Messages.DiskEncounterMessage.Parser, new[]{ "EncounterId", "FortId", "PlayerLatitude", "PlayerLongitude", "GymLatDegrees", "GymLngDegrees" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DiskEncounterMessage : pb::IMessage<DiskEncounterMessage> {
    private static readonly pb::MessageParser<DiskEncounterMessage> _parser = new pb::MessageParser<DiskEncounterMessage>(() => new DiskEncounterMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DiskEncounterMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Requests.Messages.DiskEncounterMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DiskEncounterMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DiskEncounterMessage(DiskEncounterMessage other) : this() {
      encounterId_ = other.encounterId_;
      fortId_ = other.fortId_;
      playerLatitude_ = other.playerLatitude_;
      playerLongitude_ = other.playerLongitude_;
      gymLatDegrees_ = other.gymLatDegrees_;
      gymLngDegrees_ = other.gymLngDegrees_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DiskEncounterMessage Clone() {
      return new DiskEncounterMessage(this);
    }

    /// <summary>Field number for the "encounter_id" field.</summary>
    public const int EncounterIdFieldNumber = 1;
    private ulong encounterId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong EncounterId {
      get { return encounterId_; }
      set {
        encounterId_ = value;
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

    /// <summary>Field number for the "player_latitude" field.</summary>
    public const int PlayerLatitudeFieldNumber = 3;
    private double playerLatitude_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double PlayerLatitude {
      get { return playerLatitude_; }
      set {
        playerLatitude_ = value;
      }
    }

    /// <summary>Field number for the "player_longitude" field.</summary>
    public const int PlayerLongitudeFieldNumber = 4;
    private double playerLongitude_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double PlayerLongitude {
      get { return playerLongitude_; }
      set {
        playerLongitude_ = value;
      }
    }

    /// <summary>Field number for the "gym_lat_degrees" field.</summary>
    public const int GymLatDegreesFieldNumber = 5;
    private double gymLatDegrees_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double GymLatDegrees {
      get { return gymLatDegrees_; }
      set {
        gymLatDegrees_ = value;
      }
    }

    /// <summary>Field number for the "gym_lng_degrees" field.</summary>
    public const int GymLngDegreesFieldNumber = 6;
    private double gymLngDegrees_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double GymLngDegrees {
      get { return gymLngDegrees_; }
      set {
        gymLngDegrees_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DiskEncounterMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DiskEncounterMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EncounterId != other.EncounterId) return false;
      if (FortId != other.FortId) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(PlayerLatitude, other.PlayerLatitude)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(PlayerLongitude, other.PlayerLongitude)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(GymLatDegrees, other.GymLatDegrees)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(GymLngDegrees, other.GymLngDegrees)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (EncounterId != 0UL) hash ^= EncounterId.GetHashCode();
      if (FortId.Length != 0) hash ^= FortId.GetHashCode();
      if (PlayerLatitude != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(PlayerLatitude);
      if (PlayerLongitude != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(PlayerLongitude);
      if (GymLatDegrees != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(GymLatDegrees);
      if (GymLngDegrees != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(GymLngDegrees);
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
      if (EncounterId != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(EncounterId);
      }
      if (FortId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(FortId);
      }
      if (PlayerLatitude != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(PlayerLatitude);
      }
      if (PlayerLongitude != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(PlayerLongitude);
      }
      if (GymLatDegrees != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(GymLatDegrees);
      }
      if (GymLngDegrees != 0D) {
        output.WriteRawTag(49);
        output.WriteDouble(GymLngDegrees);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (EncounterId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(EncounterId);
      }
      if (FortId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FortId);
      }
      if (PlayerLatitude != 0D) {
        size += 1 + 8;
      }
      if (PlayerLongitude != 0D) {
        size += 1 + 8;
      }
      if (GymLatDegrees != 0D) {
        size += 1 + 8;
      }
      if (GymLngDegrees != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DiskEncounterMessage other) {
      if (other == null) {
        return;
      }
      if (other.EncounterId != 0UL) {
        EncounterId = other.EncounterId;
      }
      if (other.FortId.Length != 0) {
        FortId = other.FortId;
      }
      if (other.PlayerLatitude != 0D) {
        PlayerLatitude = other.PlayerLatitude;
      }
      if (other.PlayerLongitude != 0D) {
        PlayerLongitude = other.PlayerLongitude;
      }
      if (other.GymLatDegrees != 0D) {
        GymLatDegrees = other.GymLatDegrees;
      }
      if (other.GymLngDegrees != 0D) {
        GymLngDegrees = other.GymLngDegrees;
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
            EncounterId = input.ReadUInt64();
            break;
          }
          case 18: {
            FortId = input.ReadString();
            break;
          }
          case 25: {
            PlayerLatitude = input.ReadDouble();
            break;
          }
          case 33: {
            PlayerLongitude = input.ReadDouble();
            break;
          }
          case 41: {
            GymLatDegrees = input.ReadDouble();
            break;
          }
          case 49: {
            GymLngDegrees = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
