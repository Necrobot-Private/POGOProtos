// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Requests/Messages/CompleteQuestMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/CompleteQuestMessage.proto</summary>
  public static partial class CompleteQuestMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/CompleteQuestMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CompleteQuestMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkJQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvQ29t",
            "cGxldGVRdWVzdE1lc3NhZ2UucHJvdG8SJ1BPR09Qcm90b3MuTmV0d29ya2lu",
            "Zy5SZXF1ZXN0cy5NZXNzYWdlcyI+ChRDb21wbGV0ZVF1ZXN0TWVzc2FnZRIQ",
            "CghxdWVzdF9pZBgBIAEoCRIUCgxzdWJfcXVlc3RfaWQYAiABKAliBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Requests.Messages.CompleteQuestMessage), global::POGOProtos.Networking.Requests.Messages.CompleteQuestMessage.Parser, new[]{ "QuestId", "SubQuestId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CompleteQuestMessage : pb::IMessage<CompleteQuestMessage> {
    private static readonly pb::MessageParser<CompleteQuestMessage> _parser = new pb::MessageParser<CompleteQuestMessage>(() => new CompleteQuestMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CompleteQuestMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Requests.Messages.CompleteQuestMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompleteQuestMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompleteQuestMessage(CompleteQuestMessage other) : this() {
      questId_ = other.questId_;
      subQuestId_ = other.subQuestId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompleteQuestMessage Clone() {
      return new CompleteQuestMessage(this);
    }

    /// <summary>Field number for the "quest_id" field.</summary>
    public const int QuestIdFieldNumber = 1;
    private string questId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string QuestId {
      get { return questId_; }
      set {
        questId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "sub_quest_id" field.</summary>
    public const int SubQuestIdFieldNumber = 2;
    private string subQuestId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SubQuestId {
      get { return subQuestId_; }
      set {
        subQuestId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CompleteQuestMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CompleteQuestMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (QuestId != other.QuestId) return false;
      if (SubQuestId != other.SubQuestId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (QuestId.Length != 0) hash ^= QuestId.GetHashCode();
      if (SubQuestId.Length != 0) hash ^= SubQuestId.GetHashCode();
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
      if (QuestId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(QuestId);
      }
      if (SubQuestId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(SubQuestId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (QuestId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(QuestId);
      }
      if (SubQuestId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SubQuestId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CompleteQuestMessage other) {
      if (other == null) {
        return;
      }
      if (other.QuestId.Length != 0) {
        QuestId = other.QuestId;
      }
      if (other.SubQuestId.Length != 0) {
        SubQuestId = other.SubQuestId;
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
            QuestId = input.ReadString();
            break;
          }
          case 18: {
            SubQuestId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
