// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Responses/Social/DeclineFriendInviteResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses.Social {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/Social/DeclineFriendInviteResponse.proto</summary>
  public static partial class DeclineFriendInviteResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Responses/Social/DeclineFriendInviteResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DeclineFriendInviteResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkhQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL1NvY2lhbC9EZWNs",
            "aW5lRnJpZW5kSW52aXRlUmVzcG9uc2UucHJvdG8SJlBPR09Qcm90b3MuTmV0",
            "d29ya2luZy5SZXNwb25zZXMuU29jaWFsIvIBChtEZWNsaW5lRnJpZW5kSW52",
            "aXRlUmVzcG9uc2USWgoGcmVzdWx0GAEgASgOMkouUE9HT1Byb3Rvcy5OZXR3",
            "b3JraW5nLlJlc3BvbnNlcy5Tb2NpYWwuRGVjbGluZUZyaWVuZEludml0ZVJl",
            "c3BvbnNlLlJlc3VsdCJ3CgZSZXN1bHQSCQoFVU5TRVQQABILCgdTVUNDRVNT",
            "EAESEQoNRVJST1JfVU5LTk9XThACEh8KG0VSUk9SX0lOVklURV9ET0VTX05P",
            "VF9FWElTVBADEiEKHUVSUk9SX0lOVklURV9BTFJFQURZX0RFQ0xJTkVEEARi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.Social.DeclineFriendInviteResponse), global::POGOProtos.Networking.Responses.Social.DeclineFriendInviteResponse.Parser, new[]{ "Result" }, null, new[]{ typeof(global::POGOProtos.Networking.Responses.Social.DeclineFriendInviteResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DeclineFriendInviteResponse : pb::IMessage<DeclineFriendInviteResponse> {
    private static readonly pb::MessageParser<DeclineFriendInviteResponse> _parser = new pb::MessageParser<DeclineFriendInviteResponse>(() => new DeclineFriendInviteResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DeclineFriendInviteResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.Social.DeclineFriendInviteResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeclineFriendInviteResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeclineFriendInviteResponse(DeclineFriendInviteResponse other) : this() {
      result_ = other.result_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeclineFriendInviteResponse Clone() {
      return new DeclineFriendInviteResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::POGOProtos.Networking.Responses.Social.DeclineFriendInviteResponse.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Responses.Social.DeclineFriendInviteResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DeclineFriendInviteResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DeclineFriendInviteResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
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
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DeclineFriendInviteResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
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
            result_ = (global::POGOProtos.Networking.Responses.Social.DeclineFriendInviteResponse.Types.Result) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the DeclineFriendInviteResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("ERROR_UNKNOWN")] ErrorUnknown = 2,
        [pbr::OriginalName("ERROR_INVITE_DOES_NOT_EXIST")] ErrorInviteDoesNotExist = 3,
        [pbr::OriginalName("ERROR_INVITE_ALREADY_DECLINED")] ErrorInviteAlreadyDeclined = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code