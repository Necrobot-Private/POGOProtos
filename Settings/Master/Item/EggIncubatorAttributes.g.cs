// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Settings/Master/Item/EggIncubatorAttributes.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Settings.Master.Item {

  /// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/Item/EggIncubatorAttributes.proto</summary>
  public static partial class EggIncubatorAttributesReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Settings/Master/Item/EggIncubatorAttributes.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EggIncubatorAttributesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjxQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9JdGVtL0VnZ0luY3ViYXRv",
            "ckF0dHJpYnV0ZXMucHJvdG8SH1BPR09Qcm90b3MuU2V0dGluZ3MuTWFzdGVy",
            "Lkl0ZW0aK1BPR09Qcm90b3MvSW52ZW50b3J5L0VnZ0luY3ViYXRvclR5cGUu",
            "cHJvdG8igwEKFkVnZ0luY3ViYXRvckF0dHJpYnV0ZXMSPgoOaW5jdWJhdG9y",
            "X3R5cGUYASABKA4yJi5QT0dPUHJvdG9zLkludmVudG9yeS5FZ2dJbmN1YmF0",
            "b3JUeXBlEgwKBHVzZXMYAiABKAUSGwoTZGlzdGFuY2VfbXVsdGlwbGllchgD",
            "IAEoAmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Inventory.EggIncubatorTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Settings.Master.Item.EggIncubatorAttributes), global::POGOProtos.Settings.Master.Item.EggIncubatorAttributes.Parser, new[]{ "IncubatorType", "Uses", "DistanceMultiplier" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EggIncubatorAttributes : pb::IMessage<EggIncubatorAttributes> {
    private static readonly pb::MessageParser<EggIncubatorAttributes> _parser = new pb::MessageParser<EggIncubatorAttributes>(() => new EggIncubatorAttributes());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EggIncubatorAttributes> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Settings.Master.Item.EggIncubatorAttributesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EggIncubatorAttributes() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EggIncubatorAttributes(EggIncubatorAttributes other) : this() {
      incubatorType_ = other.incubatorType_;
      uses_ = other.uses_;
      distanceMultiplier_ = other.distanceMultiplier_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EggIncubatorAttributes Clone() {
      return new EggIncubatorAttributes(this);
    }

    /// <summary>Field number for the "incubator_type" field.</summary>
    public const int IncubatorTypeFieldNumber = 1;
    private global::POGOProtos.Inventory.EggIncubatorType incubatorType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Inventory.EggIncubatorType IncubatorType {
      get { return incubatorType_; }
      set {
        incubatorType_ = value;
      }
    }

    /// <summary>Field number for the "uses" field.</summary>
    public const int UsesFieldNumber = 2;
    private int uses_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Uses {
      get { return uses_; }
      set {
        uses_ = value;
      }
    }

    /// <summary>Field number for the "distance_multiplier" field.</summary>
    public const int DistanceMultiplierFieldNumber = 3;
    private float distanceMultiplier_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float DistanceMultiplier {
      get { return distanceMultiplier_; }
      set {
        distanceMultiplier_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EggIncubatorAttributes);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EggIncubatorAttributes other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IncubatorType != other.IncubatorType) return false;
      if (Uses != other.Uses) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DistanceMultiplier, other.DistanceMultiplier)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (IncubatorType != 0) hash ^= IncubatorType.GetHashCode();
      if (Uses != 0) hash ^= Uses.GetHashCode();
      if (DistanceMultiplier != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DistanceMultiplier);
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
      if (IncubatorType != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) IncubatorType);
      }
      if (Uses != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Uses);
      }
      if (DistanceMultiplier != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(DistanceMultiplier);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (IncubatorType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) IncubatorType);
      }
      if (Uses != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Uses);
      }
      if (DistanceMultiplier != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EggIncubatorAttributes other) {
      if (other == null) {
        return;
      }
      if (other.IncubatorType != 0) {
        IncubatorType = other.IncubatorType;
      }
      if (other.Uses != 0) {
        Uses = other.Uses;
      }
      if (other.DistanceMultiplier != 0F) {
        DistanceMultiplier = other.DistanceMultiplier;
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
            incubatorType_ = (global::POGOProtos.Inventory.EggIncubatorType) input.ReadEnum();
            break;
          }
          case 16: {
            Uses = input.ReadInt32();
            break;
          }
          case 29: {
            DistanceMultiplier = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
