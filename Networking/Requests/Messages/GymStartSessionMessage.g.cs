// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Requests/Messages/GymStartSessionMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/GymStartSessionMessage.proto</summary>
  public static partial class GymStartSessionMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/GymStartSessionMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GymStartSessionMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkRQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvR3lt",
            "U3RhcnRTZXNzaW9uTWVzc2FnZS5wcm90bxInUE9HT1Byb3Rvcy5OZXR3b3Jr",
            "aW5nLlJlcXVlc3RzLk1lc3NhZ2VzIpwBChZHeW1TdGFydFNlc3Npb25NZXNz",
            "YWdlEg4KBmd5bV9pZBgBIAEoCRIcChRhdHRhY2tpbmdfcG9rZW1vbl9pZBgC",
            "IAMoBhIcChRkZWZlbmRpbmdfcG9rZW1vbl9pZBgDIAEoBhIaChJwbGF5ZXJf",
            "bGF0X2RlZ3JlZXMYBCABKAESGgoScGxheWVyX2xuZ19kZWdyZWVzGAUgASgB",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Requests.Messages.GymStartSessionMessage), global::POGOProtos.Networking.Requests.Messages.GymStartSessionMessage.Parser, new[]{ "GymId", "AttackingPokemonId", "DefendingPokemonId", "PlayerLatDegrees", "PlayerLngDegrees" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GymStartSessionMessage : pb::IMessage<GymStartSessionMessage> {
    private static readonly pb::MessageParser<GymStartSessionMessage> _parser = new pb::MessageParser<GymStartSessionMessage>(() => new GymStartSessionMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GymStartSessionMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Requests.Messages.GymStartSessionMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GymStartSessionMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GymStartSessionMessage(GymStartSessionMessage other) : this() {
      gymId_ = other.gymId_;
      attackingPokemonId_ = other.attackingPokemonId_.Clone();
      defendingPokemonId_ = other.defendingPokemonId_;
      playerLatDegrees_ = other.playerLatDegrees_;
      playerLngDegrees_ = other.playerLngDegrees_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GymStartSessionMessage Clone() {
      return new GymStartSessionMessage(this);
    }

    /// <summary>Field number for the "gym_id" field.</summary>
    public const int GymIdFieldNumber = 1;
    private string gymId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string GymId {
      get { return gymId_; }
      set {
        gymId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "attacking_pokemon_id" field.</summary>
    public const int AttackingPokemonIdFieldNumber = 2;
    private static readonly pb::FieldCodec<ulong> _repeated_attackingPokemonId_codec
        = pb::FieldCodec.ForFixed64(18);
    private readonly pbc::RepeatedField<ulong> attackingPokemonId_ = new pbc::RepeatedField<ulong>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<ulong> AttackingPokemonId {
      get { return attackingPokemonId_; }
    }

    /// <summary>Field number for the "defending_pokemon_id" field.</summary>
    public const int DefendingPokemonIdFieldNumber = 3;
    private ulong defendingPokemonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong DefendingPokemonId {
      get { return defendingPokemonId_; }
      set {
        defendingPokemonId_ = value;
      }
    }

    /// <summary>Field number for the "player_lat_degrees" field.</summary>
    public const int PlayerLatDegreesFieldNumber = 4;
    private double playerLatDegrees_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double PlayerLatDegrees {
      get { return playerLatDegrees_; }
      set {
        playerLatDegrees_ = value;
      }
    }

    /// <summary>Field number for the "player_lng_degrees" field.</summary>
    public const int PlayerLngDegreesFieldNumber = 5;
    private double playerLngDegrees_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double PlayerLngDegrees {
      get { return playerLngDegrees_; }
      set {
        playerLngDegrees_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GymStartSessionMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GymStartSessionMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GymId != other.GymId) return false;
      if(!attackingPokemonId_.Equals(other.attackingPokemonId_)) return false;
      if (DefendingPokemonId != other.DefendingPokemonId) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(PlayerLatDegrees, other.PlayerLatDegrees)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(PlayerLngDegrees, other.PlayerLngDegrees)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (GymId.Length != 0) hash ^= GymId.GetHashCode();
      hash ^= attackingPokemonId_.GetHashCode();
      if (DefendingPokemonId != 0UL) hash ^= DefendingPokemonId.GetHashCode();
      if (PlayerLatDegrees != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(PlayerLatDegrees);
      if (PlayerLngDegrees != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(PlayerLngDegrees);
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
      if (GymId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(GymId);
      }
      attackingPokemonId_.WriteTo(output, _repeated_attackingPokemonId_codec);
      if (DefendingPokemonId != 0UL) {
        output.WriteRawTag(25);
        output.WriteFixed64(DefendingPokemonId);
      }
      if (PlayerLatDegrees != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(PlayerLatDegrees);
      }
      if (PlayerLngDegrees != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(PlayerLngDegrees);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (GymId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GymId);
      }
      size += attackingPokemonId_.CalculateSize(_repeated_attackingPokemonId_codec);
      if (DefendingPokemonId != 0UL) {
        size += 1 + 8;
      }
      if (PlayerLatDegrees != 0D) {
        size += 1 + 8;
      }
      if (PlayerLngDegrees != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GymStartSessionMessage other) {
      if (other == null) {
        return;
      }
      if (other.GymId.Length != 0) {
        GymId = other.GymId;
      }
      attackingPokemonId_.Add(other.attackingPokemonId_);
      if (other.DefendingPokemonId != 0UL) {
        DefendingPokemonId = other.DefendingPokemonId;
      }
      if (other.PlayerLatDegrees != 0D) {
        PlayerLatDegrees = other.PlayerLatDegrees;
      }
      if (other.PlayerLngDegrees != 0D) {
        PlayerLngDegrees = other.PlayerLngDegrees;
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
            GymId = input.ReadString();
            break;
          }
          case 18:
          case 17: {
            attackingPokemonId_.AddEntriesFrom(input, _repeated_attackingPokemonId_codec);
            break;
          }
          case 25: {
            DefendingPokemonId = input.ReadFixed64();
            break;
          }
          case 33: {
            PlayerLatDegrees = input.ReadDouble();
            break;
          }
          case 41: {
            PlayerLngDegrees = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
