// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Settings/LoginSettings.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Settings {

  /// <summary>Holder for reflection information generated from POGOProtos/Settings/LoginSettings.proto</summary>
  public static partial class LoginSettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Settings/LoginSettings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LoginSettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidQT0dPUHJvdG9zL1NldHRpbmdzL0xvZ2luU2V0dGluZ3MucHJvdG8SE1BP",
            "R09Qcm90b3MuU2V0dGluZ3MiMwoNTG9naW5TZXR0aW5ncxIiChplbmFibGVf",
            "bXVsdGlfbG9naW5fbGlua2luZxgBIAEoCGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Settings.LoginSettings), global::POGOProtos.Settings.LoginSettings.Parser, new[]{ "EnableMultiLoginLinking" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LoginSettings : pb::IMessage<LoginSettings> {
    private static readonly pb::MessageParser<LoginSettings> _parser = new pb::MessageParser<LoginSettings>(() => new LoginSettings());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LoginSettings> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Settings.LoginSettingsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LoginSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LoginSettings(LoginSettings other) : this() {
      enableMultiLoginLinking_ = other.enableMultiLoginLinking_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LoginSettings Clone() {
      return new LoginSettings(this);
    }

    /// <summary>Field number for the "enable_multi_login_linking" field.</summary>
    public const int EnableMultiLoginLinkingFieldNumber = 1;
    private bool enableMultiLoginLinking_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool EnableMultiLoginLinking {
      get { return enableMultiLoginLinking_; }
      set {
        enableMultiLoginLinking_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LoginSettings);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LoginSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EnableMultiLoginLinking != other.EnableMultiLoginLinking) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (EnableMultiLoginLinking != false) hash ^= EnableMultiLoginLinking.GetHashCode();
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
      if (EnableMultiLoginLinking != false) {
        output.WriteRawTag(8);
        output.WriteBool(EnableMultiLoginLinking);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (EnableMultiLoginLinking != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LoginSettings other) {
      if (other == null) {
        return;
      }
      if (other.EnableMultiLoginLinking != false) {
        EnableMultiLoginLinking = other.EnableMultiLoginLinking;
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
            EnableMultiLoginLinking = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
