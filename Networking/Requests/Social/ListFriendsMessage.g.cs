// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Requests/Social/ListFriendsMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Requests.Social {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Social/ListFriendsMessage.proto</summary>
  public static partial class ListFriendsMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Requests/Social/ListFriendsMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ListFriendsMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5QT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvU29jaWFsL0xpc3RG",
            "cmllbmRzTWVzc2FnZS5wcm90bxIlUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJl",
            "cXVlc3RzLlNvY2lhbCIUChJMaXN0RnJpZW5kc01lc3NhZ2ViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Requests.Social.ListFriendsMessage), global::POGOProtos.Networking.Requests.Social.ListFriendsMessage.Parser, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ListFriendsMessage : pb::IMessage<ListFriendsMessage> {
    private static readonly pb::MessageParser<ListFriendsMessage> _parser = new pb::MessageParser<ListFriendsMessage>(() => new ListFriendsMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListFriendsMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Requests.Social.ListFriendsMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListFriendsMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListFriendsMessage(ListFriendsMessage other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListFriendsMessage Clone() {
      return new ListFriendsMessage(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ListFriendsMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListFriendsMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ListFriendsMessage other) {
      if (other == null) {
        return;
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
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
