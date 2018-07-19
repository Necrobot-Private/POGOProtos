// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Map/Pokemon/MapPokemon.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Map.Pokemon {

  /// <summary>Holder for reflection information generated from POGOProtos/Map/Pokemon/MapPokemon.proto</summary>
  public static partial class MapPokemonReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Map/Pokemon/MapPokemon.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MapPokemonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidQT0dPUHJvdG9zL01hcC9Qb2tlbW9uL01hcFBva2Vtb24ucHJvdG8SFlBP",
            "R09Qcm90b3MuTWFwLlBva2Vtb24aJFBPR09Qcm90b3MvRGF0YS9Qb2tlbW9u",
            "RGlzcGxheS5wcm90bxogUE9HT1Byb3Rvcy9FbnVtcy9Qb2tlbW9uSWQucHJv",
            "dG8i6wEKCk1hcFBva2Vtb24SFgoOc3Bhd25fcG9pbnRfaWQYASABKAkSFAoM",
            "ZW5jb3VudGVyX2lkGAIgASgGEi8KCnBva2Vtb25faWQYAyABKA4yGy5QT0dP",
            "UHJvdG9zLkVudW1zLlBva2Vtb25JZBIfChdleHBpcmF0aW9uX3RpbWVzdGFt",
            "cF9tcxgEIAEoAxIQCghsYXRpdHVkZRgFIAEoARIRCglsb25naXR1ZGUYBiAB",
            "KAESOAoPcG9rZW1vbl9kaXNwbGF5GAcgASgLMh8uUE9HT1Byb3Rvcy5EYXRh",
            "LlBva2Vtb25EaXNwbGF5YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.PokemonDisplayReflection.Descriptor, global::POGOProtos.Enums.PokemonIdReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Map.Pokemon.MapPokemon), global::POGOProtos.Map.Pokemon.MapPokemon.Parser, new[]{ "SpawnPointId", "EncounterId", "PokemonId", "ExpirationTimestampMs", "Latitude", "Longitude", "PokemonDisplay" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MapPokemon : pb::IMessage<MapPokemon> {
    private static readonly pb::MessageParser<MapPokemon> _parser = new pb::MessageParser<MapPokemon>(() => new MapPokemon());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MapPokemon> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Map.Pokemon.MapPokemonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MapPokemon() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MapPokemon(MapPokemon other) : this() {
      spawnPointId_ = other.spawnPointId_;
      encounterId_ = other.encounterId_;
      pokemonId_ = other.pokemonId_;
      expirationTimestampMs_ = other.expirationTimestampMs_;
      latitude_ = other.latitude_;
      longitude_ = other.longitude_;
      pokemonDisplay_ = other.pokemonDisplay_ != null ? other.pokemonDisplay_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MapPokemon Clone() {
      return new MapPokemon(this);
    }

    /// <summary>Field number for the "spawn_point_id" field.</summary>
    public const int SpawnPointIdFieldNumber = 1;
    private string spawnPointId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SpawnPointId {
      get { return spawnPointId_; }
      set {
        spawnPointId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "encounter_id" field.</summary>
    public const int EncounterIdFieldNumber = 2;
    private ulong encounterId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong EncounterId {
      get { return encounterId_; }
      set {
        encounterId_ = value;
      }
    }

    /// <summary>Field number for the "pokemon_id" field.</summary>
    public const int PokemonIdFieldNumber = 3;
    private global::POGOProtos.Enums.PokemonId pokemonId_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.PokemonId PokemonId {
      get { return pokemonId_; }
      set {
        pokemonId_ = value;
      }
    }

    /// <summary>Field number for the "expiration_timestamp_ms" field.</summary>
    public const int ExpirationTimestampMsFieldNumber = 4;
    private long expirationTimestampMs_;
    /// <summary>
    /// After this timestamp, the pokemon will be gone.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ExpirationTimestampMs {
      get { return expirationTimestampMs_; }
      set {
        expirationTimestampMs_ = value;
      }
    }

    /// <summary>Field number for the "latitude" field.</summary>
    public const int LatitudeFieldNumber = 5;
    private double latitude_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Latitude {
      get { return latitude_; }
      set {
        latitude_ = value;
      }
    }

    /// <summary>Field number for the "longitude" field.</summary>
    public const int LongitudeFieldNumber = 6;
    private double longitude_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Longitude {
      get { return longitude_; }
      set {
        longitude_ = value;
      }
    }

    /// <summary>Field number for the "pokemon_display" field.</summary>
    public const int PokemonDisplayFieldNumber = 7;
    private global::POGOProtos.Data.PokemonDisplay pokemonDisplay_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.PokemonDisplay PokemonDisplay {
      get { return pokemonDisplay_; }
      set {
        pokemonDisplay_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MapPokemon);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MapPokemon other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SpawnPointId != other.SpawnPointId) return false;
      if (EncounterId != other.EncounterId) return false;
      if (PokemonId != other.PokemonId) return false;
      if (ExpirationTimestampMs != other.ExpirationTimestampMs) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Latitude, other.Latitude)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Longitude, other.Longitude)) return false;
      if (!object.Equals(PokemonDisplay, other.PokemonDisplay)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SpawnPointId.Length != 0) hash ^= SpawnPointId.GetHashCode();
      if (EncounterId != 0UL) hash ^= EncounterId.GetHashCode();
      if (PokemonId != 0) hash ^= PokemonId.GetHashCode();
      if (ExpirationTimestampMs != 0L) hash ^= ExpirationTimestampMs.GetHashCode();
      if (Latitude != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Latitude);
      if (Longitude != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Longitude);
      if (pokemonDisplay_ != null) hash ^= PokemonDisplay.GetHashCode();
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
      if (SpawnPointId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SpawnPointId);
      }
      if (EncounterId != 0UL) {
        output.WriteRawTag(17);
        output.WriteFixed64(EncounterId);
      }
      if (PokemonId != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) PokemonId);
      }
      if (ExpirationTimestampMs != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(ExpirationTimestampMs);
      }
      if (Latitude != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(Latitude);
      }
      if (Longitude != 0D) {
        output.WriteRawTag(49);
        output.WriteDouble(Longitude);
      }
      if (pokemonDisplay_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(PokemonDisplay);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SpawnPointId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SpawnPointId);
      }
      if (EncounterId != 0UL) {
        size += 1 + 8;
      }
      if (PokemonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PokemonId);
      }
      if (ExpirationTimestampMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ExpirationTimestampMs);
      }
      if (Latitude != 0D) {
        size += 1 + 8;
      }
      if (Longitude != 0D) {
        size += 1 + 8;
      }
      if (pokemonDisplay_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PokemonDisplay);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MapPokemon other) {
      if (other == null) {
        return;
      }
      if (other.SpawnPointId.Length != 0) {
        SpawnPointId = other.SpawnPointId;
      }
      if (other.EncounterId != 0UL) {
        EncounterId = other.EncounterId;
      }
      if (other.PokemonId != 0) {
        PokemonId = other.PokemonId;
      }
      if (other.ExpirationTimestampMs != 0L) {
        ExpirationTimestampMs = other.ExpirationTimestampMs;
      }
      if (other.Latitude != 0D) {
        Latitude = other.Latitude;
      }
      if (other.Longitude != 0D) {
        Longitude = other.Longitude;
      }
      if (other.pokemonDisplay_ != null) {
        if (pokemonDisplay_ == null) {
          pokemonDisplay_ = new global::POGOProtos.Data.PokemonDisplay();
        }
        PokemonDisplay.MergeFrom(other.PokemonDisplay);
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
            SpawnPointId = input.ReadString();
            break;
          }
          case 17: {
            EncounterId = input.ReadFixed64();
            break;
          }
          case 24: {
            pokemonId_ = (global::POGOProtos.Enums.PokemonId) input.ReadEnum();
            break;
          }
          case 32: {
            ExpirationTimestampMs = input.ReadInt64();
            break;
          }
          case 41: {
            Latitude = input.ReadDouble();
            break;
          }
          case 49: {
            Longitude = input.ReadDouble();
            break;
          }
          case 58: {
            if (pokemonDisplay_ == null) {
              pokemonDisplay_ = new global::POGOProtos.Data.PokemonDisplay();
            }
            input.ReadMessage(pokemonDisplay_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
