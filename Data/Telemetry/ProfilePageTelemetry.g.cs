// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Data/Telemetry/ProfilePageTelemetry.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Telemetry {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Telemetry/ProfilePageTelemetry.proto</summary>
  public static partial class ProfilePageTelemetryReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Telemetry/ProfilePageTelemetry.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProfilePageTelemetryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRQT0dPUHJvdG9zL0RhdGEvVGVsZW1ldHJ5L1Byb2ZpbGVQYWdlVGVsZW1l",
            "dHJ5LnByb3RvEhlQT0dPUHJvdG9zLkRhdGEuVGVsZW1ldHJ5Gi5QT0dPUHJv",
            "dG9zL0VudW1zL1Byb2ZpbGVQYWdlVGVsZW1ldHJ5SWRzLnByb3RvImAKFFBy",
            "b2ZpbGVQYWdlVGVsZW1ldHJ5EkgKFXByb2ZpbGVfcGFnZV9jbGlja19pZBgB",
            "IAEoDjIpLlBPR09Qcm90b3MuRW51bXMuUHJvZmlsZVBhZ2VUZWxlbWV0cnlJ",
            "ZHNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Enums.ProfilePageTelemetryIdsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Telemetry.ProfilePageTelemetry), global::POGOProtos.Data.Telemetry.ProfilePageTelemetry.Parser, new[]{ "ProfilePageClickId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ProfilePageTelemetry : pb::IMessage<ProfilePageTelemetry> {
    private static readonly pb::MessageParser<ProfilePageTelemetry> _parser = new pb::MessageParser<ProfilePageTelemetry>(() => new ProfilePageTelemetry());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProfilePageTelemetry> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Telemetry.ProfilePageTelemetryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProfilePageTelemetry() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProfilePageTelemetry(ProfilePageTelemetry other) : this() {
      profilePageClickId_ = other.profilePageClickId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProfilePageTelemetry Clone() {
      return new ProfilePageTelemetry(this);
    }

    /// <summary>Field number for the "profile_page_click_id" field.</summary>
    public const int ProfilePageClickIdFieldNumber = 1;
    private global::POGOProtos.Enums.ProfilePageTelemetryIds profilePageClickId_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.ProfilePageTelemetryIds ProfilePageClickId {
      get { return profilePageClickId_; }
      set {
        profilePageClickId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProfilePageTelemetry);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProfilePageTelemetry other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ProfilePageClickId != other.ProfilePageClickId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ProfilePageClickId != 0) hash ^= ProfilePageClickId.GetHashCode();
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
      if (ProfilePageClickId != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ProfilePageClickId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ProfilePageClickId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ProfilePageClickId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ProfilePageTelemetry other) {
      if (other == null) {
        return;
      }
      if (other.ProfilePageClickId != 0) {
        ProfilePageClickId = other.ProfilePageClickId;
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
            profilePageClickId_ = (global::POGOProtos.Enums.ProfilePageTelemetryIds) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
