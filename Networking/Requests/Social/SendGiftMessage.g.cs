// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Requests/Social/SendGiftMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Requests.Social {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Social/SendGiftMessage.proto</summary>
  public static partial class SendGiftMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Requests/Social/SendGiftMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SendGiftMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjtQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvU29jaWFsL1NlbmRH",
            "aWZ0TWVzc2FnZS5wcm90bxIlUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJlcXVl",
            "c3RzLlNvY2lhbCI4Cg9TZW5kR2lmdE1lc3NhZ2USEgoKZ2lmdGJveF9pZBgB",
            "IAEoBhIRCglwbGF5ZXJfaWQYAiABKAliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Requests.Social.SendGiftMessage), global::POGOProtos.Networking.Requests.Social.SendGiftMessage.Parser, new[]{ "GiftboxId", "PlayerId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SendGiftMessage : pb::IMessage<SendGiftMessage> {
    private static readonly pb::MessageParser<SendGiftMessage> _parser = new pb::MessageParser<SendGiftMessage>(() => new SendGiftMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SendGiftMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Requests.Social.SendGiftMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SendGiftMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SendGiftMessage(SendGiftMessage other) : this() {
      giftboxId_ = other.giftboxId_;
      playerId_ = other.playerId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SendGiftMessage Clone() {
      return new SendGiftMessage(this);
    }

    /// <summary>Field number for the "giftbox_id" field.</summary>
    public const int GiftboxIdFieldNumber = 1;
    private ulong giftboxId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong GiftboxId {
      get { return giftboxId_; }
      set {
        giftboxId_ = value;
      }
    }

    /// <summary>Field number for the "player_id" field.</summary>
    public const int PlayerIdFieldNumber = 2;
    private string playerId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PlayerId {
      get { return playerId_; }
      set {
        playerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SendGiftMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SendGiftMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GiftboxId != other.GiftboxId) return false;
      if (PlayerId != other.PlayerId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (GiftboxId != 0UL) hash ^= GiftboxId.GetHashCode();
      if (PlayerId.Length != 0) hash ^= PlayerId.GetHashCode();
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
      if (GiftboxId != 0UL) {
        output.WriteRawTag(9);
        output.WriteFixed64(GiftboxId);
      }
      if (PlayerId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PlayerId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (GiftboxId != 0UL) {
        size += 1 + 8;
      }
      if (PlayerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PlayerId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SendGiftMessage other) {
      if (other == null) {
        return;
      }
      if (other.GiftboxId != 0UL) {
        GiftboxId = other.GiftboxId;
      }
      if (other.PlayerId.Length != 0) {
        PlayerId = other.PlayerId;
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
          case 9: {
            GiftboxId = input.ReadFixed64();
            break;
          }
          case 18: {
            PlayerId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
