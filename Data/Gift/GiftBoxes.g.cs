// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Data/Gift/GiftBoxes.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Gift {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Gift/GiftBoxes.proto</summary>
  public static partial class GiftBoxesReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Gift/GiftBoxes.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GiftBoxesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRQT0dPUHJvdG9zL0RhdGEvR2lmdC9HaWZ0Qm94ZXMucHJvdG8SFFBPR09Q",
            "cm90b3MuRGF0YS5HaWZ0GiJQT0dPUHJvdG9zL0RhdGEvR2lmdC9HaWZ0Qm94",
            "LnByb3RvIjkKCUdpZnRCb3hlcxIsCgVnaWZ0cxgBIAMoCzIdLlBPR09Qcm90",
            "b3MuRGF0YS5HaWZ0LkdpZnRCb3hiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.Gift.GiftBoxReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Gift.GiftBoxes), global::POGOProtos.Data.Gift.GiftBoxes.Parser, new[]{ "Gifts" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GiftBoxes : pb::IMessage<GiftBoxes> {
    private static readonly pb::MessageParser<GiftBoxes> _parser = new pb::MessageParser<GiftBoxes>(() => new GiftBoxes());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GiftBoxes> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Gift.GiftBoxesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GiftBoxes() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GiftBoxes(GiftBoxes other) : this() {
      gifts_ = other.gifts_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GiftBoxes Clone() {
      return new GiftBoxes(this);
    }

    /// <summary>Field number for the "gifts" field.</summary>
    public const int GiftsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::POGOProtos.Data.Gift.GiftBox> _repeated_gifts_codec
        = pb::FieldCodec.ForMessage(10, global::POGOProtos.Data.Gift.GiftBox.Parser);
    private readonly pbc::RepeatedField<global::POGOProtos.Data.Gift.GiftBox> gifts_ = new pbc::RepeatedField<global::POGOProtos.Data.Gift.GiftBox>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Data.Gift.GiftBox> Gifts {
      get { return gifts_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GiftBoxes);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GiftBoxes other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!gifts_.Equals(other.gifts_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= gifts_.GetHashCode();
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
      gifts_.WriteTo(output, _repeated_gifts_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += gifts_.CalculateSize(_repeated_gifts_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GiftBoxes other) {
      if (other == null) {
        return;
      }
      gifts_.Add(other.gifts_);
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
            gifts_.AddEntriesFrom(input, _repeated_gifts_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
