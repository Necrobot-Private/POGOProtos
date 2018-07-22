// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Responses/Social/ListFriendsResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses.Social {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/Social/ListFriendsResponse.proto</summary>
  public static partial class ListFriendsResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Responses/Social/ListFriendsResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ListFriendsResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL1NvY2lhbC9MaXN0",
            "RnJpZW5kc1Jlc3BvbnNlLnByb3RvEiZQT0dPUHJvdG9zLk5ldHdvcmtpbmcu",
            "UmVzcG9uc2VzLlNvY2lhbBokUE9HT1Byb3Rvcy9EYXRhL0ZyaWVuZHMvRnJp",
            "ZW5kLnByb3RvIs8BChNMaXN0RnJpZW5kc1Jlc3BvbnNlElIKBnJlc3VsdBgB",
            "IAEoDjJCLlBPR09Qcm90b3MuTmV0d29ya2luZy5SZXNwb25zZXMuU29jaWFs",
            "Lkxpc3RGcmllbmRzUmVzcG9uc2UuUmVzdWx0Ei8KBmZyaWVuZBgCIAMoCzIf",
            "LlBPR09Qcm90b3MuRGF0YS5GcmllbmRzLkZyaWVuZCIzCgZSZXN1bHQSCQoF",
            "VU5TRVQQABILCgdTVUNDRVNTEAESEQoNRVJST1JfVU5LTk9XThACYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.Friends.FriendReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.Social.ListFriendsResponse), global::POGOProtos.Networking.Responses.Social.ListFriendsResponse.Parser, new[]{ "Result", "Friend" }, null, new[]{ typeof(global::POGOProtos.Networking.Responses.Social.ListFriendsResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ListFriendsResponse : pb::IMessage<ListFriendsResponse> {
    private static readonly pb::MessageParser<ListFriendsResponse> _parser = new pb::MessageParser<ListFriendsResponse>(() => new ListFriendsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListFriendsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.Social.ListFriendsResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListFriendsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListFriendsResponse(ListFriendsResponse other) : this() {
      result_ = other.result_;
      friend_ = other.friend_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListFriendsResponse Clone() {
      return new ListFriendsResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::POGOProtos.Networking.Responses.Social.ListFriendsResponse.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Responses.Social.ListFriendsResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "friend" field.</summary>
    public const int FriendFieldNumber = 2;
    private static readonly pb::FieldCodec<global::POGOProtos.Data.Friends.Friend> _repeated_friend_codec
        = pb::FieldCodec.ForMessage(18, global::POGOProtos.Data.Friends.Friend.Parser);
    private readonly pbc::RepeatedField<global::POGOProtos.Data.Friends.Friend> friend_ = new pbc::RepeatedField<global::POGOProtos.Data.Friends.Friend>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Data.Friends.Friend> Friend {
      get { return friend_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ListFriendsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListFriendsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if(!friend_.Equals(other.friend_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      hash ^= friend_.GetHashCode();
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
      friend_.WriteTo(output, _repeated_friend_codec);
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
      size += friend_.CalculateSize(_repeated_friend_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ListFriendsResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      friend_.Add(other.friend_);
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
            result_ = (global::POGOProtos.Networking.Responses.Social.ListFriendsResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 18: {
            friend_.AddEntriesFrom(input, _repeated_friend_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the ListFriendsResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("ERROR_UNKNOWN")] ErrorUnknown = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
