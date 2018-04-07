// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Responses/ListAvatarCustomizationsResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/ListAvatarCustomizationsResponse.proto</summary>
  public static partial class ListAvatarCustomizationsResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Responses/ListAvatarCustomizationsResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ListAvatarCustomizationsResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkZQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0xpc3RBdmF0YXJD",
            "dXN0b21pemF0aW9uc1Jlc3BvbnNlLnByb3RvEh9QT0dPUHJvdG9zLk5ldHdv",
            "cmtpbmcuUmVzcG9uc2VzGjBQT0dPUHJvdG9zL0RhdGEvQXZhdGFyL0F2YXRh",
            "ckN1c3RvbWl6YXRpb24ucHJvdG8i9wEKIExpc3RBdmF0YXJDdXN0b21pemF0",
            "aW9uc1Jlc3BvbnNlElgKBnJlc3VsdBgBIAEoDjJILlBPR09Qcm90b3MuTmV0",
            "d29ya2luZy5SZXNwb25zZXMuTGlzdEF2YXRhckN1c3RvbWl6YXRpb25zUmVz",
            "cG9uc2UuUmVzdWx0EkoKFWF2YXRhcl9jdXN0b21pemF0aW9ucxgCIAMoCzIr",
            "LlBPR09Qcm90b3MuRGF0YS5BdmF0YXIuQXZhdGFyQ3VzdG9taXphdGlvbiIt",
            "CgZSZXN1bHQSCQoFVU5TRVQQABILCgdTVUNDRVNTEAESCwoHRkFJTFVSRRAC",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.Avatar.AvatarCustomizationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.ListAvatarCustomizationsResponse), global::POGOProtos.Networking.Responses.ListAvatarCustomizationsResponse.Parser, new[]{ "Result", "AvatarCustomizations" }, null, new[]{ typeof(global::POGOProtos.Networking.Responses.ListAvatarCustomizationsResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ListAvatarCustomizationsResponse : pb::IMessage<ListAvatarCustomizationsResponse> {
    private static readonly pb::MessageParser<ListAvatarCustomizationsResponse> _parser = new pb::MessageParser<ListAvatarCustomizationsResponse>(() => new ListAvatarCustomizationsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListAvatarCustomizationsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.ListAvatarCustomizationsResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListAvatarCustomizationsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListAvatarCustomizationsResponse(ListAvatarCustomizationsResponse other) : this() {
      result_ = other.result_;
      avatarCustomizations_ = other.avatarCustomizations_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListAvatarCustomizationsResponse Clone() {
      return new ListAvatarCustomizationsResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::POGOProtos.Networking.Responses.ListAvatarCustomizationsResponse.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Responses.ListAvatarCustomizationsResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "avatar_customizations" field.</summary>
    public const int AvatarCustomizationsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::POGOProtos.Data.Avatar.AvatarCustomization> _repeated_avatarCustomizations_codec
        = pb::FieldCodec.ForMessage(18, global::POGOProtos.Data.Avatar.AvatarCustomization.Parser);
    private readonly pbc::RepeatedField<global::POGOProtos.Data.Avatar.AvatarCustomization> avatarCustomizations_ = new pbc::RepeatedField<global::POGOProtos.Data.Avatar.AvatarCustomization>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Data.Avatar.AvatarCustomization> AvatarCustomizations {
      get { return avatarCustomizations_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ListAvatarCustomizationsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListAvatarCustomizationsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if(!avatarCustomizations_.Equals(other.avatarCustomizations_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      hash ^= avatarCustomizations_.GetHashCode();
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
      avatarCustomizations_.WriteTo(output, _repeated_avatarCustomizations_codec);
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
      size += avatarCustomizations_.CalculateSize(_repeated_avatarCustomizations_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ListAvatarCustomizationsResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      avatarCustomizations_.Add(other.avatarCustomizations_);
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
            result_ = (global::POGOProtos.Networking.Responses.ListAvatarCustomizationsResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 18: {
            avatarCustomizations_.AddEntriesFrom(input, _repeated_avatarCustomizations_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the ListAvatarCustomizationsResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("FAILURE")] Failure = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
