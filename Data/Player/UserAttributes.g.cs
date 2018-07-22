// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Data/Player/UserAttributes.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Player {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Player/UserAttributes.proto</summary>
  public static partial class UserAttributesReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Player/UserAttributes.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserAttributesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitQT0dPUHJvdG9zL0RhdGEvUGxheWVyL1VzZXJBdHRyaWJ1dGVzLnByb3Rv",
            "EhZQT0dPUHJvdG9zLkRhdGEuUGxheWVyIrcBCg5Vc2VyQXR0cmlidXRlcxIN",
            "CgVsZXZlbBgBIAEoBRIKCgJ4cBgCIAEoAxIOCgZhdmF0YXIYAyABKAUSEgoK",
            "aXRlbV9jb3VudBgEIAEoAxIVCg1wb2tlbW9uX2NvdW50GAUgASgDEhYKDnBv",
            "a2Vjb2luX2NvdW50GAYgASgDEgwKBHRlYW0YByABKAUSFAoMY2F0Y2hfc3Ry",
            "ZWFrGAggASgFEhMKC3NwaW5fc3RyZWFrGAkgASgFYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Player.UserAttributes), global::POGOProtos.Data.Player.UserAttributes.Parser, new[]{ "Level", "Xp", "Avatar", "ItemCount", "PokemonCount", "PokecoinCount", "Team", "CatchStreak", "SpinStreak" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class UserAttributes : pb::IMessage<UserAttributes> {
    private static readonly pb::MessageParser<UserAttributes> _parser = new pb::MessageParser<UserAttributes>(() => new UserAttributes());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserAttributes> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Player.UserAttributesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserAttributes() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserAttributes(UserAttributes other) : this() {
      level_ = other.level_;
      xp_ = other.xp_;
      avatar_ = other.avatar_;
      itemCount_ = other.itemCount_;
      pokemonCount_ = other.pokemonCount_;
      pokecoinCount_ = other.pokecoinCount_;
      team_ = other.team_;
      catchStreak_ = other.catchStreak_;
      spinStreak_ = other.spinStreak_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserAttributes Clone() {
      return new UserAttributes(this);
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 1;
    private int level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "xp" field.</summary>
    public const int XpFieldNumber = 2;
    private long xp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Xp {
      get { return xp_; }
      set {
        xp_ = value;
      }
    }

    /// <summary>Field number for the "avatar" field.</summary>
    public const int AvatarFieldNumber = 3;
    private int avatar_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Avatar {
      get { return avatar_; }
      set {
        avatar_ = value;
      }
    }

    /// <summary>Field number for the "item_count" field.</summary>
    public const int ItemCountFieldNumber = 4;
    private long itemCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ItemCount {
      get { return itemCount_; }
      set {
        itemCount_ = value;
      }
    }

    /// <summary>Field number for the "pokemon_count" field.</summary>
    public const int PokemonCountFieldNumber = 5;
    private long pokemonCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long PokemonCount {
      get { return pokemonCount_; }
      set {
        pokemonCount_ = value;
      }
    }

    /// <summary>Field number for the "pokecoin_count" field.</summary>
    public const int PokecoinCountFieldNumber = 6;
    private long pokecoinCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long PokecoinCount {
      get { return pokecoinCount_; }
      set {
        pokecoinCount_ = value;
      }
    }

    /// <summary>Field number for the "team" field.</summary>
    public const int TeamFieldNumber = 7;
    private int team_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Team {
      get { return team_; }
      set {
        team_ = value;
      }
    }

    /// <summary>Field number for the "catch_streak" field.</summary>
    public const int CatchStreakFieldNumber = 8;
    private int catchStreak_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CatchStreak {
      get { return catchStreak_; }
      set {
        catchStreak_ = value;
      }
    }

    /// <summary>Field number for the "spin_streak" field.</summary>
    public const int SpinStreakFieldNumber = 9;
    private int spinStreak_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int SpinStreak {
      get { return spinStreak_; }
      set {
        spinStreak_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserAttributes);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserAttributes other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Level != other.Level) return false;
      if (Xp != other.Xp) return false;
      if (Avatar != other.Avatar) return false;
      if (ItemCount != other.ItemCount) return false;
      if (PokemonCount != other.PokemonCount) return false;
      if (PokecoinCount != other.PokecoinCount) return false;
      if (Team != other.Team) return false;
      if (CatchStreak != other.CatchStreak) return false;
      if (SpinStreak != other.SpinStreak) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Level != 0) hash ^= Level.GetHashCode();
      if (Xp != 0L) hash ^= Xp.GetHashCode();
      if (Avatar != 0) hash ^= Avatar.GetHashCode();
      if (ItemCount != 0L) hash ^= ItemCount.GetHashCode();
      if (PokemonCount != 0L) hash ^= PokemonCount.GetHashCode();
      if (PokecoinCount != 0L) hash ^= PokecoinCount.GetHashCode();
      if (Team != 0) hash ^= Team.GetHashCode();
      if (CatchStreak != 0) hash ^= CatchStreak.GetHashCode();
      if (SpinStreak != 0) hash ^= SpinStreak.GetHashCode();
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
      if (Level != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Level);
      }
      if (Xp != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Xp);
      }
      if (Avatar != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Avatar);
      }
      if (ItemCount != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(ItemCount);
      }
      if (PokemonCount != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(PokemonCount);
      }
      if (PokecoinCount != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(PokecoinCount);
      }
      if (Team != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Team);
      }
      if (CatchStreak != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(CatchStreak);
      }
      if (SpinStreak != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(SpinStreak);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Level);
      }
      if (Xp != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Xp);
      }
      if (Avatar != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Avatar);
      }
      if (ItemCount != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ItemCount);
      }
      if (PokemonCount != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(PokemonCount);
      }
      if (PokecoinCount != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(PokecoinCount);
      }
      if (Team != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Team);
      }
      if (CatchStreak != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CatchStreak);
      }
      if (SpinStreak != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SpinStreak);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UserAttributes other) {
      if (other == null) {
        return;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.Xp != 0L) {
        Xp = other.Xp;
      }
      if (other.Avatar != 0) {
        Avatar = other.Avatar;
      }
      if (other.ItemCount != 0L) {
        ItemCount = other.ItemCount;
      }
      if (other.PokemonCount != 0L) {
        PokemonCount = other.PokemonCount;
      }
      if (other.PokecoinCount != 0L) {
        PokecoinCount = other.PokecoinCount;
      }
      if (other.Team != 0) {
        Team = other.Team;
      }
      if (other.CatchStreak != 0) {
        CatchStreak = other.CatchStreak;
      }
      if (other.SpinStreak != 0) {
        SpinStreak = other.SpinStreak;
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
            Level = input.ReadInt32();
            break;
          }
          case 16: {
            Xp = input.ReadInt64();
            break;
          }
          case 24: {
            Avatar = input.ReadInt32();
            break;
          }
          case 32: {
            ItemCount = input.ReadInt64();
            break;
          }
          case 40: {
            PokemonCount = input.ReadInt64();
            break;
          }
          case 48: {
            PokecoinCount = input.ReadInt64();
            break;
          }
          case 56: {
            Team = input.ReadInt32();
            break;
          }
          case 64: {
            CatchStreak = input.ReadInt32();
            break;
          }
          case 72: {
            SpinStreak = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
