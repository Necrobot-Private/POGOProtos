// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Requests/Messages/CatchPokemonMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/CatchPokemonMessage.proto</summary>
  public static partial class CatchPokemonMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/CatchPokemonMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CatchPokemonMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkFQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvQ2F0",
            "Y2hQb2tlbW9uTWVzc2FnZS5wcm90bxInUE9HT1Byb3Rvcy5OZXR3b3JraW5n",
            "LlJlcXVlc3RzLk1lc3NhZ2VzGiZQT0dPUHJvdG9zL0ludmVudG9yeS9JdGVt",
            "L0l0ZW1JZC5wcm90bxorUE9HT1Byb3Rvcy9EYXRhL0FSUGx1c0VuY291bnRl",
            "clZhbHVlcy5wcm90byKmAgoTQ2F0Y2hQb2tlbW9uTWVzc2FnZRIUCgxlbmNv",
            "dW50ZXJfaWQYASABKAYSMwoIcG9rZWJhbGwYAiABKA4yIS5QT0dPUHJvdG9z",
            "LkludmVudG9yeS5JdGVtLkl0ZW1JZBIfChdub3JtYWxpemVkX3JldGljbGVf",
            "c2l6ZRgDIAEoARIWCg5zcGF3bl9wb2ludF9pZBgEIAEoCRITCgtoaXRfcG9r",
            "ZW1vbhgFIAEoCBIVCg1zcGluX21vZGlmaWVyGAYgASgBEh8KF25vcm1hbGl6",
            "ZWRfaGl0X3Bvc2l0aW9uGAcgASgBEj4KDmFyX3BsdXNfdmFsdWVzGAggASgL",
            "MiYuUE9HT1Byb3Rvcy5EYXRhLkFSUGx1c0VuY291bnRlclZhbHVlc2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Inventory.Item.ItemIdReflection.Descriptor, global::POGOProtos.Data.ARPlusEncounterValuesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Requests.Messages.CatchPokemonMessage), global::POGOProtos.Networking.Requests.Messages.CatchPokemonMessage.Parser, new[]{ "EncounterId", "Pokeball", "NormalizedReticleSize", "SpawnPointId", "HitPokemon", "SpinModifier", "NormalizedHitPosition", "ArPlusValues" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CatchPokemonMessage : pb::IMessage<CatchPokemonMessage> {
    private static readonly pb::MessageParser<CatchPokemonMessage> _parser = new pb::MessageParser<CatchPokemonMessage>(() => new CatchPokemonMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CatchPokemonMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Requests.Messages.CatchPokemonMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CatchPokemonMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CatchPokemonMessage(CatchPokemonMessage other) : this() {
      encounterId_ = other.encounterId_;
      pokeball_ = other.pokeball_;
      normalizedReticleSize_ = other.normalizedReticleSize_;
      spawnPointId_ = other.spawnPointId_;
      hitPokemon_ = other.hitPokemon_;
      spinModifier_ = other.spinModifier_;
      normalizedHitPosition_ = other.normalizedHitPosition_;
      arPlusValues_ = other.arPlusValues_ != null ? other.arPlusValues_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CatchPokemonMessage Clone() {
      return new CatchPokemonMessage(this);
    }

    /// <summary>Field number for the "encounter_id" field.</summary>
    public const int EncounterIdFieldNumber = 1;
    private ulong encounterId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong EncounterId {
      get { return encounterId_; }
      set {
        encounterId_ = value;
      }
    }

    /// <summary>Field number for the "pokeball" field.</summary>
    public const int PokeballFieldNumber = 2;
    private global::POGOProtos.Inventory.Item.ItemId pokeball_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Inventory.Item.ItemId Pokeball {
      get { return pokeball_; }
      set {
        pokeball_ = value;
      }
    }

    /// <summary>Field number for the "normalized_reticle_size" field.</summary>
    public const int NormalizedReticleSizeFieldNumber = 3;
    private double normalizedReticleSize_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double NormalizedReticleSize {
      get { return normalizedReticleSize_; }
      set {
        normalizedReticleSize_ = value;
      }
    }

    /// <summary>Field number for the "spawn_point_id" field.</summary>
    public const int SpawnPointIdFieldNumber = 4;
    private string spawnPointId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SpawnPointId {
      get { return spawnPointId_; }
      set {
        spawnPointId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "hit_pokemon" field.</summary>
    public const int HitPokemonFieldNumber = 5;
    private bool hitPokemon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HitPokemon {
      get { return hitPokemon_; }
      set {
        hitPokemon_ = value;
      }
    }

    /// <summary>Field number for the "spin_modifier" field.</summary>
    public const int SpinModifierFieldNumber = 6;
    private double spinModifier_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double SpinModifier {
      get { return spinModifier_; }
      set {
        spinModifier_ = value;
      }
    }

    /// <summary>Field number for the "normalized_hit_position" field.</summary>
    public const int NormalizedHitPositionFieldNumber = 7;
    private double normalizedHitPosition_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double NormalizedHitPosition {
      get { return normalizedHitPosition_; }
      set {
        normalizedHitPosition_ = value;
      }
    }

    /// <summary>Field number for the "ar_plus_values" field.</summary>
    public const int ArPlusValuesFieldNumber = 8;
    private global::POGOProtos.Data.ARPlusEncounterValues arPlusValues_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.ARPlusEncounterValues ArPlusValues {
      get { return arPlusValues_; }
      set {
        arPlusValues_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CatchPokemonMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CatchPokemonMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EncounterId != other.EncounterId) return false;
      if (Pokeball != other.Pokeball) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(NormalizedReticleSize, other.NormalizedReticleSize)) return false;
      if (SpawnPointId != other.SpawnPointId) return false;
      if (HitPokemon != other.HitPokemon) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(SpinModifier, other.SpinModifier)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(NormalizedHitPosition, other.NormalizedHitPosition)) return false;
      if (!object.Equals(ArPlusValues, other.ArPlusValues)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (EncounterId != 0UL) hash ^= EncounterId.GetHashCode();
      if (Pokeball != 0) hash ^= Pokeball.GetHashCode();
      if (NormalizedReticleSize != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(NormalizedReticleSize);
      if (SpawnPointId.Length != 0) hash ^= SpawnPointId.GetHashCode();
      if (HitPokemon != false) hash ^= HitPokemon.GetHashCode();
      if (SpinModifier != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(SpinModifier);
      if (NormalizedHitPosition != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(NormalizedHitPosition);
      if (arPlusValues_ != null) hash ^= ArPlusValues.GetHashCode();
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
      if (EncounterId != 0UL) {
        output.WriteRawTag(9);
        output.WriteFixed64(EncounterId);
      }
      if (Pokeball != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Pokeball);
      }
      if (NormalizedReticleSize != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(NormalizedReticleSize);
      }
      if (SpawnPointId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(SpawnPointId);
      }
      if (HitPokemon != false) {
        output.WriteRawTag(40);
        output.WriteBool(HitPokemon);
      }
      if (SpinModifier != 0D) {
        output.WriteRawTag(49);
        output.WriteDouble(SpinModifier);
      }
      if (NormalizedHitPosition != 0D) {
        output.WriteRawTag(57);
        output.WriteDouble(NormalizedHitPosition);
      }
      if (arPlusValues_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(ArPlusValues);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (EncounterId != 0UL) {
        size += 1 + 8;
      }
      if (Pokeball != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Pokeball);
      }
      if (NormalizedReticleSize != 0D) {
        size += 1 + 8;
      }
      if (SpawnPointId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SpawnPointId);
      }
      if (HitPokemon != false) {
        size += 1 + 1;
      }
      if (SpinModifier != 0D) {
        size += 1 + 8;
      }
      if (NormalizedHitPosition != 0D) {
        size += 1 + 8;
      }
      if (arPlusValues_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ArPlusValues);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CatchPokemonMessage other) {
      if (other == null) {
        return;
      }
      if (other.EncounterId != 0UL) {
        EncounterId = other.EncounterId;
      }
      if (other.Pokeball != 0) {
        Pokeball = other.Pokeball;
      }
      if (other.NormalizedReticleSize != 0D) {
        NormalizedReticleSize = other.NormalizedReticleSize;
      }
      if (other.SpawnPointId.Length != 0) {
        SpawnPointId = other.SpawnPointId;
      }
      if (other.HitPokemon != false) {
        HitPokemon = other.HitPokemon;
      }
      if (other.SpinModifier != 0D) {
        SpinModifier = other.SpinModifier;
      }
      if (other.NormalizedHitPosition != 0D) {
        NormalizedHitPosition = other.NormalizedHitPosition;
      }
      if (other.arPlusValues_ != null) {
        if (arPlusValues_ == null) {
          arPlusValues_ = new global::POGOProtos.Data.ARPlusEncounterValues();
        }
        ArPlusValues.MergeFrom(other.ArPlusValues);
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
            EncounterId = input.ReadFixed64();
            break;
          }
          case 16: {
            pokeball_ = (global::POGOProtos.Inventory.Item.ItemId) input.ReadEnum();
            break;
          }
          case 25: {
            NormalizedReticleSize = input.ReadDouble();
            break;
          }
          case 34: {
            SpawnPointId = input.ReadString();
            break;
          }
          case 40: {
            HitPokemon = input.ReadBool();
            break;
          }
          case 49: {
            SpinModifier = input.ReadDouble();
            break;
          }
          case 57: {
            NormalizedHitPosition = input.ReadDouble();
            break;
          }
          case 66: {
            if (arPlusValues_ == null) {
              arPlusValues_ = new global::POGOProtos.Data.ARPlusEncounterValues();
            }
            input.ReadMessage(arPlusValues_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
