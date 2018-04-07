// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Data/Raid/Participation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Raid {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Raid/Participation.proto</summary>
  public static partial class ParticipationReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Raid/Participation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ParticipationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihQT0dPUHJvdG9zL0RhdGEvUmFpZC9QYXJ0aWNpcGF0aW9uLnByb3RvEhRQ",
            "T0dPUHJvdG9zLkRhdGEuUmFpZCL3AQoNUGFydGljaXBhdGlvbhIjChtpbmRp",
            "dmlkdWFsX2RhbWFnZV9wb2tlYmFsbHMYASABKAUSHQoVdGVhbV9kYW1hZ2Vf",
            "cG9rZWJhbGxzGAIgASgFEh8KF2d5bV9vd25lcnNoaXBfcG9rZWJhbGxzGAMg",
            "ASgFEhYKDmJhc2VfcG9rZWJhbGxzGAQgASgFEhcKD2JsdWVfcGVyY2VudGFn",
            "ZRgFIAEoARIWCg5yZWRfcGVyY2VudGFnZRgGIAEoARIZChF5ZWxsb3dfcGVy",
            "Y2VudGFnZRgHIAEoARIdChVib251c19pdGVtX211bHRpcGxpZXIYCCABKAJi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Raid.Participation), global::POGOProtos.Data.Raid.Participation.Parser, new[]{ "IndividualDamagePokeballs", "TeamDamagePokeballs", "GymOwnershipPokeballs", "BasePokeballs", "BluePercentage", "RedPercentage", "YellowPercentage", "BonusItemMultiplier" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Participation : pb::IMessage<Participation> {
    private static readonly pb::MessageParser<Participation> _parser = new pb::MessageParser<Participation>(() => new Participation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Participation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Raid.ParticipationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Participation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Participation(Participation other) : this() {
      individualDamagePokeballs_ = other.individualDamagePokeballs_;
      teamDamagePokeballs_ = other.teamDamagePokeballs_;
      gymOwnershipPokeballs_ = other.gymOwnershipPokeballs_;
      basePokeballs_ = other.basePokeballs_;
      bluePercentage_ = other.bluePercentage_;
      redPercentage_ = other.redPercentage_;
      yellowPercentage_ = other.yellowPercentage_;
      bonusItemMultiplier_ = other.bonusItemMultiplier_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Participation Clone() {
      return new Participation(this);
    }

    /// <summary>Field number for the "individual_damage_pokeballs" field.</summary>
    public const int IndividualDamagePokeballsFieldNumber = 1;
    private int individualDamagePokeballs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int IndividualDamagePokeballs {
      get { return individualDamagePokeballs_; }
      set {
        individualDamagePokeballs_ = value;
      }
    }

    /// <summary>Field number for the "team_damage_pokeballs" field.</summary>
    public const int TeamDamagePokeballsFieldNumber = 2;
    private int teamDamagePokeballs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int TeamDamagePokeballs {
      get { return teamDamagePokeballs_; }
      set {
        teamDamagePokeballs_ = value;
      }
    }

    /// <summary>Field number for the "gym_ownership_pokeballs" field.</summary>
    public const int GymOwnershipPokeballsFieldNumber = 3;
    private int gymOwnershipPokeballs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int GymOwnershipPokeballs {
      get { return gymOwnershipPokeballs_; }
      set {
        gymOwnershipPokeballs_ = value;
      }
    }

    /// <summary>Field number for the "base_pokeballs" field.</summary>
    public const int BasePokeballsFieldNumber = 4;
    private int basePokeballs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int BasePokeballs {
      get { return basePokeballs_; }
      set {
        basePokeballs_ = value;
      }
    }

    /// <summary>Field number for the "blue_percentage" field.</summary>
    public const int BluePercentageFieldNumber = 5;
    private double bluePercentage_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double BluePercentage {
      get { return bluePercentage_; }
      set {
        bluePercentage_ = value;
      }
    }

    /// <summary>Field number for the "red_percentage" field.</summary>
    public const int RedPercentageFieldNumber = 6;
    private double redPercentage_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double RedPercentage {
      get { return redPercentage_; }
      set {
        redPercentage_ = value;
      }
    }

    /// <summary>Field number for the "yellow_percentage" field.</summary>
    public const int YellowPercentageFieldNumber = 7;
    private double yellowPercentage_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double YellowPercentage {
      get { return yellowPercentage_; }
      set {
        yellowPercentage_ = value;
      }
    }

    /// <summary>Field number for the "bonus_item_multiplier" field.</summary>
    public const int BonusItemMultiplierFieldNumber = 8;
    private float bonusItemMultiplier_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float BonusItemMultiplier {
      get { return bonusItemMultiplier_; }
      set {
        bonusItemMultiplier_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Participation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Participation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IndividualDamagePokeballs != other.IndividualDamagePokeballs) return false;
      if (TeamDamagePokeballs != other.TeamDamagePokeballs) return false;
      if (GymOwnershipPokeballs != other.GymOwnershipPokeballs) return false;
      if (BasePokeballs != other.BasePokeballs) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(BluePercentage, other.BluePercentage)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(RedPercentage, other.RedPercentage)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(YellowPercentage, other.YellowPercentage)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BonusItemMultiplier, other.BonusItemMultiplier)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (IndividualDamagePokeballs != 0) hash ^= IndividualDamagePokeballs.GetHashCode();
      if (TeamDamagePokeballs != 0) hash ^= TeamDamagePokeballs.GetHashCode();
      if (GymOwnershipPokeballs != 0) hash ^= GymOwnershipPokeballs.GetHashCode();
      if (BasePokeballs != 0) hash ^= BasePokeballs.GetHashCode();
      if (BluePercentage != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(BluePercentage);
      if (RedPercentage != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(RedPercentage);
      if (YellowPercentage != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(YellowPercentage);
      if (BonusItemMultiplier != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BonusItemMultiplier);
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
      if (IndividualDamagePokeballs != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(IndividualDamagePokeballs);
      }
      if (TeamDamagePokeballs != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(TeamDamagePokeballs);
      }
      if (GymOwnershipPokeballs != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(GymOwnershipPokeballs);
      }
      if (BasePokeballs != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(BasePokeballs);
      }
      if (BluePercentage != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(BluePercentage);
      }
      if (RedPercentage != 0D) {
        output.WriteRawTag(49);
        output.WriteDouble(RedPercentage);
      }
      if (YellowPercentage != 0D) {
        output.WriteRawTag(57);
        output.WriteDouble(YellowPercentage);
      }
      if (BonusItemMultiplier != 0F) {
        output.WriteRawTag(69);
        output.WriteFloat(BonusItemMultiplier);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (IndividualDamagePokeballs != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(IndividualDamagePokeballs);
      }
      if (TeamDamagePokeballs != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TeamDamagePokeballs);
      }
      if (GymOwnershipPokeballs != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(GymOwnershipPokeballs);
      }
      if (BasePokeballs != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BasePokeballs);
      }
      if (BluePercentage != 0D) {
        size += 1 + 8;
      }
      if (RedPercentage != 0D) {
        size += 1 + 8;
      }
      if (YellowPercentage != 0D) {
        size += 1 + 8;
      }
      if (BonusItemMultiplier != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Participation other) {
      if (other == null) {
        return;
      }
      if (other.IndividualDamagePokeballs != 0) {
        IndividualDamagePokeballs = other.IndividualDamagePokeballs;
      }
      if (other.TeamDamagePokeballs != 0) {
        TeamDamagePokeballs = other.TeamDamagePokeballs;
      }
      if (other.GymOwnershipPokeballs != 0) {
        GymOwnershipPokeballs = other.GymOwnershipPokeballs;
      }
      if (other.BasePokeballs != 0) {
        BasePokeballs = other.BasePokeballs;
      }
      if (other.BluePercentage != 0D) {
        BluePercentage = other.BluePercentage;
      }
      if (other.RedPercentage != 0D) {
        RedPercentage = other.RedPercentage;
      }
      if (other.YellowPercentage != 0D) {
        YellowPercentage = other.YellowPercentage;
      }
      if (other.BonusItemMultiplier != 0F) {
        BonusItemMultiplier = other.BonusItemMultiplier;
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
            IndividualDamagePokeballs = input.ReadInt32();
            break;
          }
          case 16: {
            TeamDamagePokeballs = input.ReadInt32();
            break;
          }
          case 24: {
            GymOwnershipPokeballs = input.ReadInt32();
            break;
          }
          case 32: {
            BasePokeballs = input.ReadInt32();
            break;
          }
          case 41: {
            BluePercentage = input.ReadDouble();
            break;
          }
          case 49: {
            RedPercentage = input.ReadDouble();
            break;
          }
          case 57: {
            YellowPercentage = input.ReadDouble();
            break;
          }
          case 69: {
            BonusItemMultiplier = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
