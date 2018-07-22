// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Data/Logs/BuddyPokemonLogEntry.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Logs {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Logs/BuddyPokemonLogEntry.proto</summary>
  public static partial class BuddyPokemonLogEntryReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Logs/BuddyPokemonLogEntry.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BuddyPokemonLogEntryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9QT0dPUHJvdG9zL0RhdGEvTG9ncy9CdWRkeVBva2Vtb25Mb2dFbnRyeS5w",
            "cm90bxIUUE9HT1Byb3Rvcy5EYXRhLkxvZ3MaIFBPR09Qcm90b3MvRW51bXMv",
            "UG9rZW1vbklkLnByb3RvGiRQT0dPUHJvdG9zL0RhdGEvUG9rZW1vbkRpc3Bs",
            "YXkucHJvdG8iiwIKFEJ1ZGR5UG9rZW1vbkxvZ0VudHJ5EkEKBnJlc3VsdBgB",
            "IAEoDjIxLlBPR09Qcm90b3MuRGF0YS5Mb2dzLkJ1ZGR5UG9rZW1vbkxvZ0Vu",
            "dHJ5LlJlc3VsdBIvCgpwb2tlbW9uX2lkGAIgASgOMhsuUE9HT1Byb3Rvcy5F",
            "bnVtcy5Qb2tlbW9uSWQSDgoGYW1vdW50GAMgASgFEjgKD3Bva2Vtb25fZGlz",
            "cGxheRgEIAEoCzIfLlBPR09Qcm90b3MuRGF0YS5Qb2tlbW9uRGlzcGxheRIP",
            "Cgdwb2tlbW9uGAUgASgGIiQKBlJlc3VsdBIJCgVVTlNFVBAAEg8KC0NBTkRZ",
            "X0ZPVU5EEAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Enums.PokemonIdReflection.Descriptor, global::POGOProtos.Data.PokemonDisplayReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Logs.BuddyPokemonLogEntry), global::POGOProtos.Data.Logs.BuddyPokemonLogEntry.Parser, new[]{ "Result", "PokemonId", "Amount", "PokemonDisplay", "Pokemon" }, null, new[]{ typeof(global::POGOProtos.Data.Logs.BuddyPokemonLogEntry.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BuddyPokemonLogEntry : pb::IMessage<BuddyPokemonLogEntry> {
    private static readonly pb::MessageParser<BuddyPokemonLogEntry> _parser = new pb::MessageParser<BuddyPokemonLogEntry>(() => new BuddyPokemonLogEntry());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BuddyPokemonLogEntry> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Logs.BuddyPokemonLogEntryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuddyPokemonLogEntry() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuddyPokemonLogEntry(BuddyPokemonLogEntry other) : this() {
      result_ = other.result_;
      pokemonId_ = other.pokemonId_;
      amount_ = other.amount_;
      pokemonDisplay_ = other.pokemonDisplay_ != null ? other.pokemonDisplay_.Clone() : null;
      pokemon_ = other.pokemon_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuddyPokemonLogEntry Clone() {
      return new BuddyPokemonLogEntry(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::POGOProtos.Data.Logs.BuddyPokemonLogEntry.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Logs.BuddyPokemonLogEntry.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "pokemon_id" field.</summary>
    public const int PokemonIdFieldNumber = 2;
    private global::POGOProtos.Enums.PokemonId pokemonId_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.PokemonId PokemonId {
      get { return pokemonId_; }
      set {
        pokemonId_ = value;
      }
    }

    /// <summary>Field number for the "amount" field.</summary>
    public const int AmountFieldNumber = 3;
    private int amount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Amount {
      get { return amount_; }
      set {
        amount_ = value;
      }
    }

    /// <summary>Field number for the "pokemon_display" field.</summary>
    public const int PokemonDisplayFieldNumber = 4;
    private global::POGOProtos.Data.PokemonDisplay pokemonDisplay_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.PokemonDisplay PokemonDisplay {
      get { return pokemonDisplay_; }
      set {
        pokemonDisplay_ = value;
      }
    }

    /// <summary>Field number for the "pokemon" field.</summary>
    public const int PokemonFieldNumber = 5;
    private ulong pokemon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Pokemon {
      get { return pokemon_; }
      set {
        pokemon_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BuddyPokemonLogEntry);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BuddyPokemonLogEntry other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (PokemonId != other.PokemonId) return false;
      if (Amount != other.Amount) return false;
      if (!object.Equals(PokemonDisplay, other.PokemonDisplay)) return false;
      if (Pokemon != other.Pokemon) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (PokemonId != 0) hash ^= PokemonId.GetHashCode();
      if (Amount != 0) hash ^= Amount.GetHashCode();
      if (pokemonDisplay_ != null) hash ^= PokemonDisplay.GetHashCode();
      if (Pokemon != 0UL) hash ^= Pokemon.GetHashCode();
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
      if (PokemonId != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) PokemonId);
      }
      if (Amount != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Amount);
      }
      if (pokemonDisplay_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(PokemonDisplay);
      }
      if (Pokemon != 0UL) {
        output.WriteRawTag(41);
        output.WriteFixed64(Pokemon);
      }
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
      if (PokemonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PokemonId);
      }
      if (Amount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Amount);
      }
      if (pokemonDisplay_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PokemonDisplay);
      }
      if (Pokemon != 0UL) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BuddyPokemonLogEntry other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.PokemonId != 0) {
        PokemonId = other.PokemonId;
      }
      if (other.Amount != 0) {
        Amount = other.Amount;
      }
      if (other.pokemonDisplay_ != null) {
        if (pokemonDisplay_ == null) {
          pokemonDisplay_ = new global::POGOProtos.Data.PokemonDisplay();
        }
        PokemonDisplay.MergeFrom(other.PokemonDisplay);
      }
      if (other.Pokemon != 0UL) {
        Pokemon = other.Pokemon;
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
            result_ = (global::POGOProtos.Data.Logs.BuddyPokemonLogEntry.Types.Result) input.ReadEnum();
            break;
          }
          case 16: {
            pokemonId_ = (global::POGOProtos.Enums.PokemonId) input.ReadEnum();
            break;
          }
          case 24: {
            Amount = input.ReadInt32();
            break;
          }
          case 34: {
            if (pokemonDisplay_ == null) {
              pokemonDisplay_ = new global::POGOProtos.Data.PokemonDisplay();
            }
            input.ReadMessage(pokemonDisplay_);
            break;
          }
          case 41: {
            Pokemon = input.ReadFixed64();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the BuddyPokemonLogEntry message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("CANDY_FOUND")] CandyFound = 1,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
