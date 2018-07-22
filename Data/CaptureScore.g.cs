// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Data/CaptureScore.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/CaptureScore.proto</summary>
  public static partial class CaptureScoreReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/CaptureScore.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CaptureScoreReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJQT0dPUHJvdG9zL0RhdGEvQ2FwdHVyZVNjb3JlLnByb3RvEg9QT0dPUHJv",
            "dG9zLkRhdGEaI1BPR09Qcm90b3MvRW51bXMvQWN0aXZpdHlUeXBlLnByb3Rv",
            "InMKDENhcHR1cmVTY29yZRI1Cg1hY3Rpdml0eV90eXBlGAEgAygOMh4uUE9H",
            "T1Byb3Rvcy5FbnVtcy5BY3Rpdml0eVR5cGUSCwoDZXhwGAIgAygFEg0KBWNh",
            "bmR5GAMgAygFEhAKCHN0YXJkdXN0GAQgAygFYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Enums.ActivityTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.CaptureScore), global::POGOProtos.Data.CaptureScore.Parser, new[]{ "ActivityType", "Exp", "Candy", "Stardust" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CaptureScore : pb::IMessage<CaptureScore> {
    private static readonly pb::MessageParser<CaptureScore> _parser = new pb::MessageParser<CaptureScore>(() => new CaptureScore());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CaptureScore> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.CaptureScoreReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CaptureScore() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CaptureScore(CaptureScore other) : this() {
      activityType_ = other.activityType_.Clone();
      exp_ = other.exp_.Clone();
      candy_ = other.candy_.Clone();
      stardust_ = other.stardust_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CaptureScore Clone() {
      return new CaptureScore(this);
    }

    /// <summary>Field number for the "activity_type" field.</summary>
    public const int ActivityTypeFieldNumber = 1;
    private static readonly pb::FieldCodec<global::POGOProtos.Enums.ActivityType> _repeated_activityType_codec
        = pb::FieldCodec.ForEnum(10, x => (int) x, x => (global::POGOProtos.Enums.ActivityType) x);
    private readonly pbc::RepeatedField<global::POGOProtos.Enums.ActivityType> activityType_ = new pbc::RepeatedField<global::POGOProtos.Enums.ActivityType>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Enums.ActivityType> ActivityType {
      get { return activityType_; }
    }

    /// <summary>Field number for the "exp" field.</summary>
    public const int ExpFieldNumber = 2;
    private static readonly pb::FieldCodec<int> _repeated_exp_codec
        = pb::FieldCodec.ForInt32(18);
    private readonly pbc::RepeatedField<int> exp_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> Exp {
      get { return exp_; }
    }

    /// <summary>Field number for the "candy" field.</summary>
    public const int CandyFieldNumber = 3;
    private static readonly pb::FieldCodec<int> _repeated_candy_codec
        = pb::FieldCodec.ForInt32(26);
    private readonly pbc::RepeatedField<int> candy_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> Candy {
      get { return candy_; }
    }

    /// <summary>Field number for the "stardust" field.</summary>
    public const int StardustFieldNumber = 4;
    private static readonly pb::FieldCodec<int> _repeated_stardust_codec
        = pb::FieldCodec.ForInt32(34);
    private readonly pbc::RepeatedField<int> stardust_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> Stardust {
      get { return stardust_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CaptureScore);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CaptureScore other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!activityType_.Equals(other.activityType_)) return false;
      if(!exp_.Equals(other.exp_)) return false;
      if(!candy_.Equals(other.candy_)) return false;
      if(!stardust_.Equals(other.stardust_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= activityType_.GetHashCode();
      hash ^= exp_.GetHashCode();
      hash ^= candy_.GetHashCode();
      hash ^= stardust_.GetHashCode();
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
      activityType_.WriteTo(output, _repeated_activityType_codec);
      exp_.WriteTo(output, _repeated_exp_codec);
      candy_.WriteTo(output, _repeated_candy_codec);
      stardust_.WriteTo(output, _repeated_stardust_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += activityType_.CalculateSize(_repeated_activityType_codec);
      size += exp_.CalculateSize(_repeated_exp_codec);
      size += candy_.CalculateSize(_repeated_candy_codec);
      size += stardust_.CalculateSize(_repeated_stardust_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CaptureScore other) {
      if (other == null) {
        return;
      }
      activityType_.Add(other.activityType_);
      exp_.Add(other.exp_);
      candy_.Add(other.candy_);
      stardust_.Add(other.stardust_);
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
          case 10:
          case 8: {
            activityType_.AddEntriesFrom(input, _repeated_activityType_codec);
            break;
          }
          case 18:
          case 16: {
            exp_.AddEntriesFrom(input, _repeated_exp_codec);
            break;
          }
          case 26:
          case 24: {
            candy_.AddEntriesFrom(input, _repeated_candy_codec);
            break;
          }
          case 34:
          case 32: {
            stardust_.AddEntriesFrom(input, _repeated_stardust_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
