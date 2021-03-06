// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Responses/AttackGymResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/AttackGymResponse.proto</summary>
  public static partial class AttackGymResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Responses/AttackGymResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AttackGymResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjdQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0F0dGFja0d5bVJl",
            "c3BvbnNlLnByb3RvEh9QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9uc2Vz",
            "GiZQT0dPUHJvdG9zL0RhdGEvQmF0dGxlL0JhdHRsZUxvZy5wcm90bxouUE9H",
            "T1Byb3Rvcy9EYXRhL0JhdHRsZS9CYXR0bGVQb2tlbW9uSW5mby5wcm90bxop",
            "UE9HT1Byb3Rvcy9EYXRhL0JhdHRsZS9CYXR0bGVVcGRhdGUucHJvdG8iyQMK",
            "EUF0dGFja0d5bVJlc3BvbnNlEkkKBnJlc3VsdBgBIAEoDjI5LlBPR09Qcm90",
            "b3MuTmV0d29ya2luZy5SZXNwb25zZXMuQXR0YWNrR3ltUmVzcG9uc2UuUmVz",
            "dWx0EjUKCmJhdHRsZV9sb2cYAiABKAsyIS5QT0dPUHJvdG9zLkRhdGEuQmF0",
            "dGxlLkJhdHRsZUxvZxIRCgliYXR0bGVfaWQYAyABKAkSQgoPYWN0aXZlX2Rl",
            "ZmVuZGVyGAQgASgLMikuUE9HT1Byb3Rvcy5EYXRhLkJhdHRsZS5CYXR0bGVQ",
            "b2tlbW9uSW5mbxJCCg9hY3RpdmVfYXR0YWNrZXIYBSABKAsyKS5QT0dPUHJv",
            "dG9zLkRhdGEuQmF0dGxlLkJhdHRsZVBva2Vtb25JbmZvEjsKDWJhdHRsZV91",
            "cGRhdGUYBiABKAsyJC5QT0dPUHJvdG9zLkRhdGEuQmF0dGxlLkJhdHRsZVVw",
            "ZGF0ZSJaCgZSZXN1bHQSCQoFVU5TRVQQABILCgdTVUNDRVNTEAESIAocRVJS",
            "T1JfSU5WQUxJRF9BVFRBQ0tfQUNUSU9OUxACEhYKEkVSUk9SX05PVF9JTl9S",
            "QU5HRRADYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.Battle.BattleLogReflection.Descriptor, global::POGOProtos.Data.Battle.BattlePokemonInfoReflection.Descriptor, global::POGOProtos.Data.Battle.BattleUpdateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.AttackGymResponse), global::POGOProtos.Networking.Responses.AttackGymResponse.Parser, new[]{ "Result", "BattleLog", "BattleId", "ActiveDefender", "ActiveAttacker", "BattleUpdate" }, null, new[]{ typeof(global::POGOProtos.Networking.Responses.AttackGymResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AttackGymResponse : pb::IMessage<AttackGymResponse> {
    private static readonly pb::MessageParser<AttackGymResponse> _parser = new pb::MessageParser<AttackGymResponse>(() => new AttackGymResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AttackGymResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.AttackGymResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AttackGymResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AttackGymResponse(AttackGymResponse other) : this() {
      result_ = other.result_;
      BattleLog = other.battleLog_ != null ? other.BattleLog.Clone() : null;
      battleId_ = other.battleId_;
      ActiveDefender = other.activeDefender_ != null ? other.ActiveDefender.Clone() : null;
      ActiveAttacker = other.activeAttacker_ != null ? other.ActiveAttacker.Clone() : null;
      BattleUpdate = other.battleUpdate_ != null ? other.BattleUpdate.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AttackGymResponse Clone() {
      return new AttackGymResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::POGOProtos.Networking.Responses.AttackGymResponse.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Responses.AttackGymResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "battle_log" field.</summary>
    public const int BattleLogFieldNumber = 2;
    private global::POGOProtos.Data.Battle.BattleLog battleLog_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Battle.BattleLog BattleLog {
      get { return battleLog_; }
      set {
        battleLog_ = value;
      }
    }

    /// <summary>Field number for the "battle_id" field.</summary>
    public const int BattleIdFieldNumber = 3;
    private string battleId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BattleId {
      get { return battleId_; }
      set {
        battleId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "active_defender" field.</summary>
    public const int ActiveDefenderFieldNumber = 4;
    private global::POGOProtos.Data.Battle.BattlePokemonInfo activeDefender_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Battle.BattlePokemonInfo ActiveDefender {
      get { return activeDefender_; }
      set {
        activeDefender_ = value;
      }
    }

    /// <summary>Field number for the "active_attacker" field.</summary>
    public const int ActiveAttackerFieldNumber = 5;
    private global::POGOProtos.Data.Battle.BattlePokemonInfo activeAttacker_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Battle.BattlePokemonInfo ActiveAttacker {
      get { return activeAttacker_; }
      set {
        activeAttacker_ = value;
      }
    }

    /// <summary>Field number for the "battle_update" field.</summary>
    public const int BattleUpdateFieldNumber = 6;
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
      return Equals(other as AttackGymResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AttackGymResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (!object.Equals(BattleLog, other.BattleLog)) return false;
      if (BattleId != other.BattleId) return false;
      if (!object.Equals(ActiveDefender, other.ActiveDefender)) return false;
      if (!object.Equals(ActiveAttacker, other.ActiveAttacker)) return false;
      if (!object.Equals(BattleUpdate, other.BattleUpdate)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (battleLog_ != null) hash ^= BattleLog.GetHashCode();
      if (BattleId.Length != 0) hash ^= BattleId.GetHashCode();
      if (activeDefender_ != null) hash ^= ActiveDefender.GetHashCode();
      if (activeAttacker_ != null) hash ^= ActiveAttacker.GetHashCode();
      if (battleUpdate_ != null) hash ^= BattleUpdate.GetHashCode();
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
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
      if (battleLog_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(BattleLog);
      }
      if (BattleId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(BattleId);
      }
      if (activeDefender_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ActiveDefender);
      }
      if (activeAttacker_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(ActiveAttacker);
      }
      if (battleUpdate_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(BattleUpdate);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (battleLog_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BattleLog);
      }
      if (BattleId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BattleId);
      }
      if (activeDefender_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ActiveDefender);
      }
      if (activeAttacker_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ActiveAttacker);
      }
      if (battleUpdate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BattleUpdate);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AttackGymResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.battleLog_ != null) {
        if (battleLog_ == null) {
          battleLog_ = new global::POGOProtos.Data.Battle.BattleLog();
        }
        BattleLog.MergeFrom(other.BattleLog);
      }
      if (other.BattleId.Length != 0) {
        BattleId = other.BattleId;
      }
      if (other.activeDefender_ != null) {
        if (activeDefender_ == null) {
          activeDefender_ = new global::POGOProtos.Data.Battle.BattlePokemonInfo();
        }
        ActiveDefender.MergeFrom(other.ActiveDefender);
      }
      if (other.activeAttacker_ != null) {
        if (activeAttacker_ == null) {
          activeAttacker_ = new global::POGOProtos.Data.Battle.BattlePokemonInfo();
        }
        ActiveAttacker.MergeFrom(other.ActiveAttacker);
      }
      if (other.battleUpdate_ != null) {
        if (battleUpdate_ == null) {
          battleUpdate_ = new global::POGOProtos.Data.Battle.BattleUpdate();
        }
        BattleUpdate.MergeFrom(other.BattleUpdate);
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
            result_ = (global::POGOProtos.Networking.Responses.AttackGymResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 18: {
            if (battleLog_ == null) {
              battleLog_ = new global::POGOProtos.Data.Battle.BattleLog();
            }
            input.ReadMessage(battleLog_);
            break;
          }
          case 26: {
            BattleId = input.ReadString();
            break;
          }
          case 34: {
            if (activeDefender_ == null) {
              activeDefender_ = new global::POGOProtos.Data.Battle.BattlePokemonInfo();
            }
            input.ReadMessage(activeDefender_);
            break;
          }
          case 42: {
            if (activeAttacker_ == null) {
              activeAttacker_ = new global::POGOProtos.Data.Battle.BattlePokemonInfo();
            }
            input.ReadMessage(activeAttacker_);
            break;
          }
          case 50: {
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
    /// <summary>Container for nested types declared in the AttackGymResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("ERROR_INVALID_ATTACK_ACTIONS")] ErrorInvalidAttackActions = 2,
        [pbr::OriginalName("ERROR_NOT_IN_RANGE")] ErrorNotInRange = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
