// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Data/Avatar/AvatarCustomization.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Avatar {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Avatar/AvatarCustomization.proto</summary>
  public static partial class AvatarCustomizationReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Avatar/AvatarCustomization.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AvatarCustomizationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBQT0dPUHJvdG9zL0RhdGEvQXZhdGFyL0F2YXRhckN1c3RvbWl6YXRpb24u",
            "cHJvdG8SFlBPR09Qcm90b3MuRGF0YS5BdmF0YXIijQIKE0F2YXRhckN1c3Rv",
            "bWl6YXRpb24SGgoSYXZhdGFyX3RlbXBsYXRlX2lkGAEgASgJEkEKBmxhYmVs",
            "cxgCIAMoDjIxLlBPR09Qcm90b3MuRGF0YS5BdmF0YXIuQXZhdGFyQ3VzdG9t",
            "aXphdGlvbi5MYWJlbCKWAQoFTGFiZWwSDwoLVU5TRVRfTEFCRUwQABILCgdE",
            "RUZBVUxUEAESCQoFT1dORUQQAhIMCghGRUFUVVJFRBADEgcKA05FVxAEEggK",
            "BFNBTEUQBRIPCgtQVVJDSEFTQUJMRRAGEg4KClVOTE9DS0FCTEUQBxIKCgZW",
            "SUVXRUQQCBIWChJMT0NLRURfUFVSQ0hBU0FCTEUQCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Avatar.AvatarCustomization), global::POGOProtos.Data.Avatar.AvatarCustomization.Parser, new[]{ "AvatarTemplateId", "Labels" }, null, new[]{ typeof(global::POGOProtos.Data.Avatar.AvatarCustomization.Types.Label) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AvatarCustomization : pb::IMessage<AvatarCustomization> {
    private static readonly pb::MessageParser<AvatarCustomization> _parser = new pb::MessageParser<AvatarCustomization>(() => new AvatarCustomization());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AvatarCustomization> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Avatar.AvatarCustomizationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AvatarCustomization() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AvatarCustomization(AvatarCustomization other) : this() {
      avatarTemplateId_ = other.avatarTemplateId_;
      labels_ = other.labels_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AvatarCustomization Clone() {
      return new AvatarCustomization(this);
    }

    /// <summary>Field number for the "avatar_template_id" field.</summary>
    public const int AvatarTemplateIdFieldNumber = 1;
    private string avatarTemplateId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AvatarTemplateId {
      get { return avatarTemplateId_; }
      set {
        avatarTemplateId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "labels" field.</summary>
    public const int LabelsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::POGOProtos.Data.Avatar.AvatarCustomization.Types.Label> _repeated_labels_codec
        = pb::FieldCodec.ForEnum(18, x => (int) x, x => (global::POGOProtos.Data.Avatar.AvatarCustomization.Types.Label) x);
    private readonly pbc::RepeatedField<global::POGOProtos.Data.Avatar.AvatarCustomization.Types.Label> labels_ = new pbc::RepeatedField<global::POGOProtos.Data.Avatar.AvatarCustomization.Types.Label>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Data.Avatar.AvatarCustomization.Types.Label> Labels {
      get { return labels_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AvatarCustomization);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AvatarCustomization other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AvatarTemplateId != other.AvatarTemplateId) return false;
      if(!labels_.Equals(other.labels_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (AvatarTemplateId.Length != 0) hash ^= AvatarTemplateId.GetHashCode();
      hash ^= labels_.GetHashCode();
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
      if (AvatarTemplateId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(AvatarTemplateId);
      }
      labels_.WriteTo(output, _repeated_labels_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (AvatarTemplateId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AvatarTemplateId);
      }
      size += labels_.CalculateSize(_repeated_labels_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AvatarCustomization other) {
      if (other == null) {
        return;
      }
      if (other.AvatarTemplateId.Length != 0) {
        AvatarTemplateId = other.AvatarTemplateId;
      }
      labels_.Add(other.labels_);
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
            AvatarTemplateId = input.ReadString();
            break;
          }
          case 18:
          case 16: {
            labels_.AddEntriesFrom(input, _repeated_labels_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the AvatarCustomization message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Label {
        [pbr::OriginalName("UNSET_LABEL")] UnsetLabel = 0,
        [pbr::OriginalName("DEFAULT")] Default = 1,
        [pbr::OriginalName("OWNED")] Owned = 2,
        [pbr::OriginalName("FEATURED")] Featured = 3,
        [pbr::OriginalName("NEW")] New = 4,
        [pbr::OriginalName("SALE")] Sale = 5,
        [pbr::OriginalName("PURCHASABLE")] Purchasable = 6,
        [pbr::OriginalName("UNLOCKABLE")] Unlockable = 7,
        [pbr::OriginalName("VIEWED")] Viewed = 8,
        [pbr::OriginalName("LOCKED_PURCHASABLE")] LockedPurchasable = 9,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
