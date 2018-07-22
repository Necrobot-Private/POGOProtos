// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Data/Battle/BattleParties.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Battle {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Battle/BattleParties.proto</summary>
  public static partial class BattlePartiesReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Battle/BattleParties.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BattlePartiesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CipQT0dPUHJvdG9zL0RhdGEvQmF0dGxlL0JhdHRsZVBhcnRpZXMucHJvdG8S",
            "FlBPR09Qcm90b3MuRGF0YS5CYXR0bGUaKFBPR09Qcm90b3MvRGF0YS9CYXR0",
            "bGUvQmF0dGxlUGFydHkucHJvdG8iTAoNQmF0dGxlUGFydGllcxI7Cg5iYXR0",
            "bGVfcGFydGllcxgBIAMoCzIjLlBPR09Qcm90b3MuRGF0YS5CYXR0bGUuQmF0",
            "dGxlUGFydHliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.Battle.BattlePartyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Battle.BattleParties), global::POGOProtos.Data.Battle.BattleParties.Parser, new[]{ "BattleParties_" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BattleParties : pb::IMessage<BattleParties> {
    private static readonly pb::MessageParser<BattleParties> _parser = new pb::MessageParser<BattleParties>(() => new BattleParties());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BattleParties> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Battle.BattlePartiesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BattleParties() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BattleParties(BattleParties other) : this() {
      battleParties_ = other.battleParties_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BattleParties Clone() {
      return new BattleParties(this);
    }

    /// <summary>Field number for the "battle_parties" field.</summary>
    public const int BattleParties_FieldNumber = 1;
    private static readonly pb::FieldCodec<global::POGOProtos.Data.Battle.BattleParty> _repeated_battleParties_codec
        = pb::FieldCodec.ForMessage(10, global::POGOProtos.Data.Battle.BattleParty.Parser);
    private readonly pbc::RepeatedField<global::POGOProtos.Data.Battle.BattleParty> battleParties_ = new pbc::RepeatedField<global::POGOProtos.Data.Battle.BattleParty>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Data.Battle.BattleParty> BattleParties_ {
      get { return battleParties_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BattleParties);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BattleParties other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!battleParties_.Equals(other.battleParties_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= battleParties_.GetHashCode();
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
      battleParties_.WriteTo(output, _repeated_battleParties_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += battleParties_.CalculateSize(_repeated_battleParties_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BattleParties other) {
      if (other == null) {
        return;
      }
      battleParties_.Add(other.battleParties_);
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
            battleParties_.AddEntriesFrom(input, _repeated_battleParties_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
