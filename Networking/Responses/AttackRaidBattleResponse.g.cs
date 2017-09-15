// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Networking/Responses/AttackRaidBattleResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/AttackRaidBattleResponse.proto</summary>
  public static partial class AttackRaidBattleResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Responses/AttackRaidBattleResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AttackRaidBattleResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5QT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0F0dGFja1JhaWRC",
            "YXR0bGVSZXNwb25zZS5wcm90bxIfUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJl",
            "c3BvbnNlcxopUE9HT1Byb3Rvcy9EYXRhL0JhdHRsZS9CYXR0bGVVcGRhdGUu",
            "cHJvdG8i3wIKGEF0dGFja1JhaWRCYXR0bGVSZXNwb25zZRJQCgZyZXN1bHQY",
            "ASABKA4yQC5QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9uc2VzLkF0dGFj",
            "a1JhaWRCYXR0bGVSZXNwb25zZS5SZXN1bHQSOwoNYmF0dGxlX3VwZGF0ZRgC",
            "IAEoCzIkLlBPR09Qcm90b3MuRGF0YS5CYXR0bGUuQmF0dGxlVXBkYXRlIrMB",
            "CgZSZXN1bHQSCQoFVU5TRVQQABILCgdTVUNDRVNTEAESFwoTRVJST1JfR1lN",
            "X05PVF9GT1VORBACEhoKFkVSUk9SX0JBVFRMRV9OT1RfRk9VTkQQAxIgChxF",
            "UlJPUl9JTlZBTElEX0FUVEFDS19BQ1RJT05TEAQSHAoYRVJST1JfTk9UX1BB",
            "UlRfT0ZfQkFUVExFEAUSHAoYRVJST1JfQkFUVExFX0lEX05PVF9SQUlEEAZi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.Battle.BattleUpdateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.AttackRaidBattleResponse), global::POGOProtos.Networking.Responses.AttackRaidBattleResponse.Parser, new[]{ "Result", "BattleUpdate" }, null, new[]{ typeof(global::POGOProtos.Networking.Responses.AttackRaidBattleResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AttackRaidBattleResponse : pb::IMessage<AttackRaidBattleResponse> {
    private static readonly pb::MessageParser<AttackRaidBattleResponse> _parser = new pb::MessageParser<AttackRaidBattleResponse>(() => new AttackRaidBattleResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AttackRaidBattleResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.AttackRaidBattleResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AttackRaidBattleResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AttackRaidBattleResponse(AttackRaidBattleResponse other) : this() {
      result_ = other.result_;
      BattleUpdate = other.battleUpdate_ != null ? other.BattleUpdate.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AttackRaidBattleResponse Clone() {
      return new AttackRaidBattleResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::POGOProtos.Networking.Responses.AttackRaidBattleResponse.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Responses.AttackRaidBattleResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "battle_update" field.</summary>
    public const int BattleUpdateFieldNumber = 2;
    private global::POGOProtos.Data.Battle.BattleUpdate battleUpdate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Battle.BattleUpdate BattleUpdate {
      get { return battleUpdate_; }
      set {
        battleUpdate_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AttackRaidBattleResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AttackRaidBattleResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (!object.Equals(BattleUpdate, other.BattleUpdate)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (battleUpdate_ != null) hash ^= BattleUpdate.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
      if (battleUpdate_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(BattleUpdate);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (battleUpdate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BattleUpdate);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AttackRaidBattleResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.battleUpdate_ != null) {
        if (battleUpdate_ == null) {
          battleUpdate_ = new global::POGOProtos.Data.Battle.BattleUpdate();
        }
        BattleUpdate.MergeFrom(other.BattleUpdate);
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
          case 8: {
            result_ = (global::POGOProtos.Networking.Responses.AttackRaidBattleResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 18: {
            if (battleUpdate_ == null) {
              battleUpdate_ = new global::POGOProtos.Data.Battle.BattleUpdate();
            }
            input.ReadMessage(battleUpdate_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the AttackRaidBattleResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("ERROR_GYM_NOT_FOUND")] ErrorGymNotFound = 2,
        [pbr::OriginalName("ERROR_BATTLE_NOT_FOUND")] ErrorBattleNotFound = 3,
        [pbr::OriginalName("ERROR_INVALID_ATTACK_ACTIONS")] ErrorInvalidAttackActions = 4,
        [pbr::OriginalName("ERROR_NOT_PART_OF_BATTLE")] ErrorNotPartOfBattle = 5,
        [pbr::OriginalName("ERROR_BATTLE_ID_NOT_RAID")] ErrorBattleIdNotRaid = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
