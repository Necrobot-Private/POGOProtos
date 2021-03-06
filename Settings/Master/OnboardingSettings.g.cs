// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Settings/Master/OnboardingSettings.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Settings.Master {

  /// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/OnboardingSettings.proto</summary>
  public static partial class OnboardingSettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Settings/Master/OnboardingSettings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OnboardingSettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9PbmJvYXJkaW5nU2V0dGlu",
            "Z3MucHJvdG8SGlBPR09Qcm90b3MuU2V0dGluZ3MuTWFzdGVyInoKEk9uYm9h",
            "cmRpbmdTZXR0aW5ncxIhChlza2lwX2F2YXRhcl9jdXN0b21pemF0aW9uGAEg",
            "ASgIEiEKGWRpc2FibGVfaW5pdGlhbF9hcl9wcm9tcHQYAiABKAgSHgoWYXJf",
            "cHJvbXB0X3BsYXllcl9sZXZlbBgDIAEoDWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Settings.Master.OnboardingSettings), global::POGOProtos.Settings.Master.OnboardingSettings.Parser, new[]{ "SkipAvatarCustomization", "DisableInitialArPrompt", "ArPromptPlayerLevel" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class OnboardingSettings : pb::IMessage<OnboardingSettings> {
    private static readonly pb::MessageParser<OnboardingSettings> _parser = new pb::MessageParser<OnboardingSettings>(() => new OnboardingSettings());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OnboardingSettings> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Settings.Master.OnboardingSettingsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OnboardingSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OnboardingSettings(OnboardingSettings other) : this() {
      skipAvatarCustomization_ = other.skipAvatarCustomization_;
      disableInitialArPrompt_ = other.disableInitialArPrompt_;
      arPromptPlayerLevel_ = other.arPromptPlayerLevel_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OnboardingSettings Clone() {
      return new OnboardingSettings(this);
    }

    /// <summary>Field number for the "skip_avatar_customization" field.</summary>
    public const int SkipAvatarCustomizationFieldNumber = 1;
    private bool skipAvatarCustomization_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool SkipAvatarCustomization {
      get { return skipAvatarCustomization_; }
      set {
        skipAvatarCustomization_ = value;
      }
    }

    /// <summary>Field number for the "disable_initial_ar_prompt" field.</summary>
    public const int DisableInitialArPromptFieldNumber = 2;
    private bool disableInitialArPrompt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool DisableInitialArPrompt {
      get { return disableInitialArPrompt_; }
      set {
        disableInitialArPrompt_ = value;
      }
    }

    /// <summary>Field number for the "ar_prompt_player_level" field.</summary>
    public const int ArPromptPlayerLevelFieldNumber = 3;
    private uint arPromptPlayerLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint ArPromptPlayerLevel {
      get { return arPromptPlayerLevel_; }
      set {
        arPromptPlayerLevel_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OnboardingSettings);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OnboardingSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SkipAvatarCustomization != other.SkipAvatarCustomization) return false;
      if (DisableInitialArPrompt != other.DisableInitialArPrompt) return false;
      if (ArPromptPlayerLevel != other.ArPromptPlayerLevel) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SkipAvatarCustomization != false) hash ^= SkipAvatarCustomization.GetHashCode();
      if (DisableInitialArPrompt != false) hash ^= DisableInitialArPrompt.GetHashCode();
      if (ArPromptPlayerLevel != 0) hash ^= ArPromptPlayerLevel.GetHashCode();
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
      if (SkipAvatarCustomization != false) {
        output.WriteRawTag(8);
        output.WriteBool(SkipAvatarCustomization);
      }
      if (DisableInitialArPrompt != false) {
        output.WriteRawTag(16);
        output.WriteBool(DisableInitialArPrompt);
      }
      if (ArPromptPlayerLevel != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ArPromptPlayerLevel);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SkipAvatarCustomization != false) {
        size += 1 + 1;
      }
      if (DisableInitialArPrompt != false) {
        size += 1 + 1;
      }
      if (ArPromptPlayerLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ArPromptPlayerLevel);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OnboardingSettings other) {
      if (other == null) {
        return;
      }
      if (other.SkipAvatarCustomization != false) {
        SkipAvatarCustomization = other.SkipAvatarCustomization;
      }
      if (other.DisableInitialArPrompt != false) {
        DisableInitialArPrompt = other.DisableInitialArPrompt;
      }
      if (other.ArPromptPlayerLevel != 0) {
        ArPromptPlayerLevel = other.ArPromptPlayerLevel;
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
            SkipAvatarCustomization = input.ReadBool();
            break;
          }
          case 16: {
            DisableInitialArPrompt = input.ReadBool();
            break;
          }
          case 24: {
            ArPromptPlayerLevel = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
