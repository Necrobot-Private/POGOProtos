// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Responses/SetPlayerTeamResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/SetPlayerTeamResponse.proto</summary>
  public static partial class SetPlayerTeamResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Responses/SetPlayerTeamResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SetPlayerTeamResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjtQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL1NldFBsYXllclRl",
            "YW1SZXNwb25zZS5wcm90bxIfUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJlc3Bv",
            "bnNlcxogUE9HT1Byb3Rvcy9EYXRhL1BsYXllckRhdGEucHJvdG8i3QEKFVNl",
            "dFBsYXllclRlYW1SZXNwb25zZRJNCgZzdGF0dXMYASABKA4yPS5QT0dPUHJv",
            "dG9zLk5ldHdvcmtpbmcuUmVzcG9uc2VzLlNldFBsYXllclRlYW1SZXNwb25z",
            "ZS5TdGF0dXMSMAoLcGxheWVyX2RhdGEYAiABKAsyGy5QT0dPUHJvdG9zLkRh",
            "dGEuUGxheWVyRGF0YSJDCgZTdGF0dXMSCQoFVU5TRVQQABILCgdTVUNDRVNT",
            "EAESFAoQVEVBTV9BTFJFQURZX1NFVBACEgsKB0ZBSUxVUkUQA2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.PlayerDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.SetPlayerTeamResponse), global::POGOProtos.Networking.Responses.SetPlayerTeamResponse.Parser, new[]{ "Status", "PlayerData" }, null, new[]{ typeof(global::POGOProtos.Networking.Responses.SetPlayerTeamResponse.Types.Status) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SetPlayerTeamResponse : pb::IMessage<SetPlayerTeamResponse> {
    private static readonly pb::MessageParser<SetPlayerTeamResponse> _parser = new pb::MessageParser<SetPlayerTeamResponse>(() => new SetPlayerTeamResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SetPlayerTeamResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.SetPlayerTeamResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetPlayerTeamResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetPlayerTeamResponse(SetPlayerTeamResponse other) : this() {
      status_ = other.status_;
      playerData_ = other.playerData_ != null ? other.playerData_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetPlayerTeamResponse Clone() {
      return new SetPlayerTeamResponse(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::POGOProtos.Networking.Responses.SetPlayerTeamResponse.Types.Status status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Responses.SetPlayerTeamResponse.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "player_data" field.</summary>
    public const int PlayerDataFieldNumber = 2;
    private global::POGOProtos.Data.PlayerData playerData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.PlayerData PlayerData {
      get { return playerData_; }
      set {
        playerData_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SetPlayerTeamResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SetPlayerTeamResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      if (!object.Equals(PlayerData, other.PlayerData)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != 0) hash ^= Status.GetHashCode();
      if (playerData_ != null) hash ^= PlayerData.GetHashCode();
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
        output.WriteEnum((int) Status);
      }
      if (playerData_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(PlayerData);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (playerData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerData);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SetPlayerTeamResponse other) {
      if (other == null) {
        return;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      if (other.playerData_ != null) {
        if (playerData_ == null) {
          playerData_ = new global::POGOProtos.Data.PlayerData();
        }
        PlayerData.MergeFrom(other.PlayerData);
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
            status_ = (global::POGOProtos.Networking.Responses.SetPlayerTeamResponse.Types.Status) input.ReadEnum();
            break;
          }
          case 18: {
            if (playerData_ == null) {
              playerData_ = new global::POGOProtos.Data.PlayerData();
            }
            input.ReadMessage(playerData_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the SetPlayerTeamResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Status {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("TEAM_ALREADY_SET")] TeamAlreadySet = 2,
        [pbr::OriginalName("FAILURE")] Failure = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
