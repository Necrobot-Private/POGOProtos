// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Data/BuddyPokemon.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/BuddyPokemon.proto</summary>
  public static partial class BuddyPokemonReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/BuddyPokemon.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BuddyPokemonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJQT0dPUHJvdG9zL0RhdGEvQnVkZHlQb2tlbW9uLnByb3RvEg9QT0dPUHJv",
            "dG9zLkRhdGEiTAoMQnVkZHlQb2tlbW9uEgoKAmlkGAEgASgGEhcKD3N0YXJ0",
            "X2ttX3dhbGtlZBgCIAEoARIXCg9sYXN0X2ttX2F3YXJkZWQYAyABKAFiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.BuddyPokemon), global::POGOProtos.Data.BuddyPokemon.Parser, new[]{ "Id", "StartKmWalked", "LastKmAwarded" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BuddyPokemon : pb::IMessage<BuddyPokemon> {
    private static readonly pb::MessageParser<BuddyPokemon> _parser = new pb::MessageParser<BuddyPokemon>(() => new BuddyPokemon());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BuddyPokemon> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.BuddyPokemonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuddyPokemon() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuddyPokemon(BuddyPokemon other) : this() {
      id_ = other.id_;
      startKmWalked_ = other.startKmWalked_;
      lastKmAwarded_ = other.lastKmAwarded_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuddyPokemon Clone() {
      return new BuddyPokemon(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private ulong id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "start_km_walked" field.</summary>
    public const int StartKmWalkedFieldNumber = 2;
    private double startKmWalked_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double StartKmWalked {
      get { return startKmWalked_; }
      set {
        startKmWalked_ = value;
      }
    }

    /// <summary>Field number for the "last_km_awarded" field.</summary>
    public const int LastKmAwardedFieldNumber = 3;
    private double lastKmAwarded_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double LastKmAwarded {
      get { return lastKmAwarded_; }
      set {
        lastKmAwarded_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BuddyPokemon);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BuddyPokemon other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(StartKmWalked, other.StartKmWalked)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(LastKmAwarded, other.LastKmAwarded)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0UL) hash ^= Id.GetHashCode();
      if (StartKmWalked != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(StartKmWalked);
      if (LastKmAwarded != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(LastKmAwarded);
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
      if (Id != 0UL) {
        output.WriteRawTag(9);
        output.WriteFixed64(Id);
      }
      if (StartKmWalked != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(StartKmWalked);
      }
      if (LastKmAwarded != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(LastKmAwarded);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0UL) {
        size += 1 + 8;
      }
      if (StartKmWalked != 0D) {
        size += 1 + 8;
      }
      if (LastKmAwarded != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BuddyPokemon other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0UL) {
        Id = other.Id;
      }
      if (other.StartKmWalked != 0D) {
        StartKmWalked = other.StartKmWalked;
      }
      if (other.LastKmAwarded != 0D) {
        LastKmAwarded = other.LastKmAwarded;
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
          case 9: {
            Id = input.ReadFixed64();
            break;
          }
          case 17: {
            StartKmWalked = input.ReadDouble();
            break;
          }
          case 25: {
            LastKmAwarded = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
