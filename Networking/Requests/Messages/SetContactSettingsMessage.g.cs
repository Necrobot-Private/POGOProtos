// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Requests/Messages/SetContactSettingsMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/SetContactSettingsMessage.proto</summary>
  public static partial class SetContactSettingsMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/SetContactSettingsMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SetContactSettingsMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkdQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvU2V0",
            "Q29udGFjdFNldHRpbmdzTWVzc2FnZS5wcm90bxInUE9HT1Byb3Rvcy5OZXR3",
            "b3JraW5nLlJlcXVlc3RzLk1lc3NhZ2VzGixQT0dPUHJvdG9zL0RhdGEvUGxh",
            "eWVyL0NvbnRhY3RTZXR0aW5ncy5wcm90byJeChlTZXRDb250YWN0U2V0dGlu",
            "Z3NNZXNzYWdlEkEKEGNvbnRhY3Rfc2V0dGluZ3MYASABKAsyJy5QT0dPUHJv",
            "dG9zLkRhdGEuUGxheWVyLkNvbnRhY3RTZXR0aW5nc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.Player.ContactSettingsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Requests.Messages.SetContactSettingsMessage), global::POGOProtos.Networking.Requests.Messages.SetContactSettingsMessage.Parser, new[]{ "ContactSettings" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SetContactSettingsMessage : pb::IMessage<SetContactSettingsMessage> {
    private static readonly pb::MessageParser<SetContactSettingsMessage> _parser = new pb::MessageParser<SetContactSettingsMessage>(() => new SetContactSettingsMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SetContactSettingsMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Requests.Messages.SetContactSettingsMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetContactSettingsMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetContactSettingsMessage(SetContactSettingsMessage other) : this() {
      contactSettings_ = other.contactSettings_ != null ? other.contactSettings_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetContactSettingsMessage Clone() {
      return new SetContactSettingsMessage(this);
    }

    /// <summary>Field number for the "contact_settings" field.</summary>
    public const int ContactSettingsFieldNumber = 1;
    private global::POGOProtos.Data.Player.ContactSettings contactSettings_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Player.ContactSettings ContactSettings {
      get { return contactSettings_; }
      set {
        contactSettings_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SetContactSettingsMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SetContactSettingsMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ContactSettings, other.ContactSettings)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (contactSettings_ != null) hash ^= ContactSettings.GetHashCode();
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
      if (contactSettings_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ContactSettings);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (contactSettings_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ContactSettings);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SetContactSettingsMessage other) {
      if (other == null) {
        return;
      }
      if (other.contactSettings_ != null) {
        if (contactSettings_ == null) {
          contactSettings_ = new global::POGOProtos.Data.Player.ContactSettings();
        }
        ContactSettings.MergeFrom(other.ContactSettings);
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
            if (contactSettings_ == null) {
              contactSettings_ = new global::POGOProtos.Data.Player.ContactSettings();
            }
            input.ReadMessage(contactSettings_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
