// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Data/Friends/FriendshipData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Friends {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Friends/FriendshipData.proto</summary>
  public static partial class FriendshipDataReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Friends/FriendshipData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FriendshipDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CixQT0dPUHJvdG9zL0RhdGEvRnJpZW5kcy9GcmllbmRzaGlwRGF0YS5wcm90",
            "bxIXUE9HT1Byb3Rvcy5EYXRhLkZyaWVuZHMaMVBPR09Qcm90b3MvRGF0YS9G",
            "cmllbmRzL0ZyaWVuZHNoaXBMZXZlbERhdGEucHJvdG8aKVBPR09Qcm90b3Mv",
            "RGF0YS9HaWZ0L0dpZnRCb3hEZXRhaWxzLnByb3RvIsABCg5GcmllbmRzaGlw",
            "RGF0YRJLChVmcmllbmRzaGlwX2xldmVsX2RhdGEYASABKAsyLC5QT0dPUHJv",
            "dG9zLkRhdGEuRnJpZW5kcy5GcmllbmRzaGlwTGV2ZWxEYXRhEj0KD2dpZnRi",
            "b3hfZGV0YWlscxgCIAMoCzIkLlBPR09Qcm90b3MuRGF0YS5HaWZ0LkdpZnRC",
            "b3hEZXRhaWxzEhAKCGNvZGVuYW1lGAMgASgJEhAKCG5pY2tuYW1lGAQgASgJ",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.Friends.FriendshipLevelDataReflection.Descriptor, global::POGOProtos.Data.Gift.GiftBoxDetailsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Friends.FriendshipData), global::POGOProtos.Data.Friends.FriendshipData.Parser, new[]{ "FriendshipLevelData", "GiftboxDetails", "Codename", "Nickname" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FriendshipData : pb::IMessage<FriendshipData> {
    private static readonly pb::MessageParser<FriendshipData> _parser = new pb::MessageParser<FriendshipData>(() => new FriendshipData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FriendshipData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Friends.FriendshipDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FriendshipData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FriendshipData(FriendshipData other) : this() {
      friendshipLevelData_ = other.friendshipLevelData_ != null ? other.friendshipLevelData_.Clone() : null;
      giftboxDetails_ = other.giftboxDetails_.Clone();
      codename_ = other.codename_;
      nickname_ = other.nickname_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FriendshipData Clone() {
      return new FriendshipData(this);
    }

    /// <summary>Field number for the "friendship_level_data" field.</summary>
    public const int FriendshipLevelDataFieldNumber = 1;
    private global::POGOProtos.Data.Friends.FriendshipLevelData friendshipLevelData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Friends.FriendshipLevelData FriendshipLevelData {
      get { return friendshipLevelData_; }
      set {
        friendshipLevelData_ = value;
      }
    }

    /// <summary>Field number for the "giftbox_details" field.</summary>
    public const int GiftboxDetailsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::POGOProtos.Data.Gift.GiftBoxDetails> _repeated_giftboxDetails_codec
        = pb::FieldCodec.ForMessage(18, global::POGOProtos.Data.Gift.GiftBoxDetails.Parser);
    private readonly pbc::RepeatedField<global::POGOProtos.Data.Gift.GiftBoxDetails> giftboxDetails_ = new pbc::RepeatedField<global::POGOProtos.Data.Gift.GiftBoxDetails>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Data.Gift.GiftBoxDetails> GiftboxDetails {
      get { return giftboxDetails_; }
    }

    /// <summary>Field number for the "codename" field.</summary>
    public const int CodenameFieldNumber = 3;
    private string codename_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Codename {
      get { return codename_; }
      set {
        codename_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "nickname" field.</summary>
    public const int NicknameFieldNumber = 4;
    private string nickname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Nickname {
      get { return nickname_; }
      set {
        nickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FriendshipData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FriendshipData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(FriendshipLevelData, other.FriendshipLevelData)) return false;
      if(!giftboxDetails_.Equals(other.giftboxDetails_)) return false;
      if (Codename != other.Codename) return false;
      if (Nickname != other.Nickname) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (friendshipLevelData_ != null) hash ^= FriendshipLevelData.GetHashCode();
      hash ^= giftboxDetails_.GetHashCode();
      if (Codename.Length != 0) hash ^= Codename.GetHashCode();
      if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
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
      if (friendshipLevelData_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(FriendshipLevelData);
      }
      giftboxDetails_.WriteTo(output, _repeated_giftboxDetails_codec);
      if (Codename.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Codename);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Nickname);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (friendshipLevelData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FriendshipLevelData);
      }
      size += giftboxDetails_.CalculateSize(_repeated_giftboxDetails_codec);
      if (Codename.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Codename);
      }
      if (Nickname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nickname);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FriendshipData other) {
      if (other == null) {
        return;
      }
      if (other.friendshipLevelData_ != null) {
        if (friendshipLevelData_ == null) {
          friendshipLevelData_ = new global::POGOProtos.Data.Friends.FriendshipLevelData();
        }
        FriendshipLevelData.MergeFrom(other.FriendshipLevelData);
      }
      giftboxDetails_.Add(other.giftboxDetails_);
      if (other.Codename.Length != 0) {
        Codename = other.Codename;
      }
      if (other.Nickname.Length != 0) {
        Nickname = other.Nickname;
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
            if (friendshipLevelData_ == null) {
              friendshipLevelData_ = new global::POGOProtos.Data.Friends.FriendshipLevelData();
            }
            input.ReadMessage(friendshipLevelData_);
            break;
          }
          case 18: {
            giftboxDetails_.AddEntriesFrom(input, _repeated_giftboxDetails_codec);
            break;
          }
          case 26: {
            Codename = input.ReadString();
            break;
          }
          case 34: {
            Nickname = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
