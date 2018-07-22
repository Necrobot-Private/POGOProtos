// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Responses/CompleteQuestResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/CompleteQuestResponse.proto</summary>
  public static partial class CompleteQuestResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Responses/CompleteQuestResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CompleteQuestResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjtQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0NvbXBsZXRlUXVl",
            "c3RSZXNwb25zZS5wcm90bxIfUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJlc3Bv",
            "bnNlcxooUE9HT1Byb3Rvcy9EYXRhL1F1ZXN0cy9DbGllbnRRdWVzdC5wcm90",
            "bxonUE9HT1Byb3Rvcy9EYXRhL1F1ZXN0cy9RdWVzdFN0YW1wLnByb3RvItYE",
            "ChVDb21wbGV0ZVF1ZXN0UmVzcG9uc2USTQoGc3RhdHVzGAEgASgOMj0uUE9H",
            "T1Byb3Rvcy5OZXR3b3JraW5nLlJlc3BvbnNlcy5Db21wbGV0ZVF1ZXN0UmVz",
            "cG9uc2UuU3RhdHVzEjIKBXF1ZXN0GAIgASgLMiMuUE9HT1Byb3Rvcy5EYXRh",
            "LlF1ZXN0cy5DbGllbnRRdWVzdBIxCgVzdGFtcBgDIAMoCzIiLlBPR09Qcm90",
            "b3MuRGF0YS5RdWVzdHMuUXVlc3RTdGFtcCKGAwoGU3RhdHVzEgkKBVVOU0VU",
            "EAASCwoHU1VDQ0VTUxABEhkKFUVSUk9SX1FVRVNUX05PVF9GT1VORBACEiEK",
            "HUVSUk9SX1FVRVNUX1NUSUxMX0lOX1BST0dSRVNTEAMSIQodRVJST1JfUVVF",
            "U1RfQUxSRUFEWV9DT01QTEVURUQQBBIcChhFUlJPUl9TVUJRVUVTVF9OT1Rf",
            "Rk9VTkQQBRIkCiBFUlJPUl9TVUJRVUVTVF9TVElMTF9JTl9QUk9HUkVTUxAG",
            "EiQKIEVSUk9SX1NVQlFVRVNUX0FMUkVBRFlfQ09NUExFVEVEEAcSJQohRVJS",
            "T1JfTVVMVElQQVJUX1NUSUxMX0lOX1BST0dSRVNTEAgSJQohRVJST1JfTVVM",
            "VElQQVJUX0FMUkVBRFlfQ09NUExFVEVEEAkSMQotRVJST1JfUkVERUVNX0NP",
            "TVBMRVRFRF9RVUVTVF9TVEFNUF9DQVJEX0ZJUlNUEAoSGAoURVJST1JfSU5W",
            "RU5UT1JZX0ZVTEwQC2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.Quests.ClientQuestReflection.Descriptor, global::POGOProtos.Data.Quests.QuestStampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.CompleteQuestResponse), global::POGOProtos.Networking.Responses.CompleteQuestResponse.Parser, new[]{ "Status", "Quest", "Stamp" }, null, new[]{ typeof(global::POGOProtos.Networking.Responses.CompleteQuestResponse.Types.Status) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CompleteQuestResponse : pb::IMessage<CompleteQuestResponse> {
    private static readonly pb::MessageParser<CompleteQuestResponse> _parser = new pb::MessageParser<CompleteQuestResponse>(() => new CompleteQuestResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CompleteQuestResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.CompleteQuestResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompleteQuestResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompleteQuestResponse(CompleteQuestResponse other) : this() {
      status_ = other.status_;
      quest_ = other.quest_ != null ? other.quest_.Clone() : null;
      stamp_ = other.stamp_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompleteQuestResponse Clone() {
      return new CompleteQuestResponse(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::POGOProtos.Networking.Responses.CompleteQuestResponse.Types.Status status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Responses.CompleteQuestResponse.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "quest" field.</summary>
    public const int QuestFieldNumber = 2;
    private global::POGOProtos.Data.Quests.ClientQuest quest_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Quests.ClientQuest Quest {
      get { return quest_; }
      set {
        quest_ = value;
      }
    }

    /// <summary>Field number for the "stamp" field.</summary>
    public const int StampFieldNumber = 3;
    private static readonly pb::FieldCodec<global::POGOProtos.Data.Quests.QuestStamp> _repeated_stamp_codec
        = pb::FieldCodec.ForMessage(26, global::POGOProtos.Data.Quests.QuestStamp.Parser);
    private readonly pbc::RepeatedField<global::POGOProtos.Data.Quests.QuestStamp> stamp_ = new pbc::RepeatedField<global::POGOProtos.Data.Quests.QuestStamp>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Data.Quests.QuestStamp> Stamp {
      get { return stamp_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CompleteQuestResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CompleteQuestResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      if (!object.Equals(Quest, other.Quest)) return false;
      if(!stamp_.Equals(other.stamp_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != 0) hash ^= Status.GetHashCode();
      if (quest_ != null) hash ^= Quest.GetHashCode();
      hash ^= stamp_.GetHashCode();
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
      if (quest_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Quest);
      }
      stamp_.WriteTo(output, _repeated_stamp_codec);
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
      if (quest_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Quest);
      }
      size += stamp_.CalculateSize(_repeated_stamp_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CompleteQuestResponse other) {
      if (other == null) {
        return;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      if (other.quest_ != null) {
        if (quest_ == null) {
          quest_ = new global::POGOProtos.Data.Quests.ClientQuest();
        }
        Quest.MergeFrom(other.Quest);
      }
      stamp_.Add(other.stamp_);
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
            status_ = (global::POGOProtos.Networking.Responses.CompleteQuestResponse.Types.Status) input.ReadEnum();
            break;
          }
          case 18: {
            if (quest_ == null) {
              quest_ = new global::POGOProtos.Data.Quests.ClientQuest();
            }
            input.ReadMessage(quest_);
            break;
          }
          case 26: {
            stamp_.AddEntriesFrom(input, _repeated_stamp_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the CompleteQuestResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Status {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("ERROR_QUEST_NOT_FOUND")] ErrorQuestNotFound = 2,
        [pbr::OriginalName("ERROR_QUEST_STILL_IN_PROGRESS")] ErrorQuestStillInProgress = 3,
        [pbr::OriginalName("ERROR_QUEST_ALREADY_COMPLETED")] ErrorQuestAlreadyCompleted = 4,
        [pbr::OriginalName("ERROR_SUBQUEST_NOT_FOUND")] ErrorSubquestNotFound = 5,
        [pbr::OriginalName("ERROR_SUBQUEST_STILL_IN_PROGRESS")] ErrorSubquestStillInProgress = 6,
        [pbr::OriginalName("ERROR_SUBQUEST_ALREADY_COMPLETED")] ErrorSubquestAlreadyCompleted = 7,
        [pbr::OriginalName("ERROR_MULTIPART_STILL_IN_PROGRESS")] ErrorMultipartStillInProgress = 8,
        [pbr::OriginalName("ERROR_MULTIPART_ALREADY_COMPLETED")] ErrorMultipartAlreadyCompleted = 9,
        [pbr::OriginalName("ERROR_REDEEM_COMPLETED_QUEST_STAMP_CARD_FIRST")] ErrorRedeemCompletedQuestStampCardFirst = 10,
        [pbr::OriginalName("ERROR_INVENTORY_FULL")] ErrorInventoryFull = 11,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
