// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Data/Battle/BattleUpdate.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Battle {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Battle/BattleUpdate.proto</summary>
  public static partial class BattleUpdateReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Battle/BattleUpdate.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BattleUpdateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CilQT0dPUHJvdG9zL0RhdGEvQmF0dGxlL0JhdHRsZVVwZGF0ZS5wcm90bxIW",
            "UE9HT1Byb3Rvcy5EYXRhLkJhdHRsZRomUE9HT1Byb3Rvcy9EYXRhL0JhdHRs",
            "ZS9CYXR0bGVMb2cucHJvdG8aLlBPR09Qcm90b3MvRGF0YS9CYXR0bGUvQmF0",
            "dGxlUG9rZW1vbkluZm8ucHJvdG8i4AEKDEJhdHRsZVVwZGF0ZRI1CgpiYXR0",
            "bGVfbG9nGAEgASgLMiEuUE9HT1Byb3Rvcy5EYXRhLkJhdHRsZS5CYXR0bGVM",
            "b2cSEQoJYmF0dGxlX2lkGAIgASgJEkIKD2FjdGl2ZV9kZWZlbmRlchgDIAEo",
            "CzIpLlBPR09Qcm90b3MuRGF0YS5CYXR0bGUuQmF0dGxlUG9rZW1vbkluZm8S",
            "QgoPYWN0aXZlX2F0dGFja2VyGAQgASgLMikuUE9HT1Byb3Rvcy5EYXRhLkJh",
            "dHRsZS5CYXR0bGVQb2tlbW9uSW5mb2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.Battle.BattleLogReflection.Descriptor, global::POGOProtos.Data.Battle.BattlePokemonInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Battle.BattleUpdate), global::POGOProtos.Data.Battle.BattleUpdate.Parser, new[]{ "BattleLog", "BattleId", "ActiveDefender", "ActiveAttacker" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BattleUpdate : pb::IMessage<BattleUpdate> {
    private static readonly pb::MessageParser<BattleUpdate> _parser = new pb::MessageParser<BattleUpdate>(() => new BattleUpdate());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BattleUpdate> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Battle.BattleUpdateReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BattleUpdate() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BattleUpdate(BattleUpdate other) : this() {
      BattleLog = other.battleLog_ != null ? other.BattleLog.Clone() : null;
      battleId_ = other.battleId_;
      ActiveDefender = other.activeDefender_ != null ? other.ActiveDefender.Clone() : null;
      ActiveAttacker = other.activeAttacker_ != null ? other.ActiveAttacker.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BattleUpdate Clone() {
      return new BattleUpdate(this);
    }

    /// <summary>Field number for the "battle_log" field.</summary>
    public const int BattleLogFieldNumber = 1;
    private global::POGOProtos.Data.Battle.BattleLog battleLog_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Battle.BattleLog BattleLog {
      get { return battleLog_; }
      set {
        battleLog_ = value;
      }
    }

    /// <summary>Field number for the "battle_id" field.</summary>
    public const int BattleIdFieldNumber = 2;
    private string battleId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BattleId {
      get { return battleId_; }
      set {
        battleId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "active_defender" field.</summary>
    public const int ActiveDefenderFieldNumber = 3;
    private global::POGOProtos.Data.Battle.BattlePokemonInfo activeDefender_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Battle.BattlePokemonInfo ActiveDefender {
      get { return activeDefender_; }
      set {
        activeDefender_ = value;
      }
    }

    /// <summary>Field number for the "active_attacker" field.</summary>
    public const int ActiveAttackerFieldNumber = 4;
    private global::POGOProtos.Data.Battle.BattlePokemonInfo activeAttacker_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Battle.BattlePokemonInfo ActiveAttacker {
      get { return activeAttacker_; }
      set {
        activeAttacker_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BattleUpdate);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BattleUpdate other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(BattleLog, other.BattleLog)) return false;
      if (BattleId != other.BattleId) return false;
      if (!object.Equals(ActiveDefender, other.ActiveDefender)) return false;
      if (!object.Equals(ActiveAttacker, other.ActiveAttacker)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (battleLog_ != null) hash ^= BattleLog.GetHashCode();
      if (BattleId.Length != 0) hash ^= BattleId.GetHashCode();
      if (activeDefender_ != null) hash ^= ActiveDefender.GetHashCode();
      if (activeAttacker_ != null) hash ^= ActiveAttacker.GetHashCode();
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
      if (battleLog_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(BattleLog);
      }
      if (BattleId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(BattleId);
      }
      if (activeDefender_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ActiveDefender);
      }
      if (activeAttacker_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ActiveAttacker);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
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
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BattleUpdate other) {
      if (other == null) {
        return;
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
          case 10: {
            if (battleLog_ == null) {
              battleLog_ = new global::POGOProtos.Data.Battle.BattleLog();
            }
            input.ReadMessage(battleLog_);
            break;
          }
          case 18: {
            BattleId = input.ReadString();
            break;
          }
          case 26: {
            if (activeDefender_ == null) {
              activeDefender_ = new global::POGOProtos.Data.Battle.BattlePokemonInfo();
            }
            input.ReadMessage(activeDefender_);
            break;
          }
          case 34: {
            if (activeAttacker_ == null) {
              activeAttacker_ = new global::POGOProtos.Data.Battle.BattlePokemonInfo();
            }
            input.ReadMessage(activeAttacker_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
