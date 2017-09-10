// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Settings/Master/Item/BattleAttributes.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Settings.Master.Item {

  /// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/Item/BattleAttributes.proto</summary>
  public static partial class BattleAttributesReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Settings/Master/Item/BattleAttributes.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BattleAttributesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9JdGVtL0JhdHRsZUF0dHJp",
            "YnV0ZXMucHJvdG8SH1BPR09Qcm90b3MuU2V0dGluZ3MuTWFzdGVyLkl0ZW0i",
            "ZQoQQmF0dGxlQXR0cmlidXRlcxITCgtzdGFfcGVyY2VudBgBIAEoAhITCgth",
            "dGtfcGVyY2VudBgCIAEoAhITCgtkZWZfcGVyY2VudBgDIAEoAhISCgpkdXJh",
            "dGlvbl9zGAQgASgCYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Settings.Master.Item.BattleAttributes), global::POGOProtos.Settings.Master.Item.BattleAttributes.Parser, new[]{ "StaPercent", "AtkPercent", "DefPercent", "DurationS" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BattleAttributes : pb::IMessage<BattleAttributes> {
    private static readonly pb::MessageParser<BattleAttributes> _parser = new pb::MessageParser<BattleAttributes>(() => new BattleAttributes());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BattleAttributes> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Settings.Master.Item.BattleAttributesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BattleAttributes() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BattleAttributes(BattleAttributes other) : this() {
      staPercent_ = other.staPercent_;
      atkPercent_ = other.atkPercent_;
      defPercent_ = other.defPercent_;
      durationS_ = other.durationS_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BattleAttributes Clone() {
      return new BattleAttributes(this);
    }

    /// <summary>Field number for the "sta_percent" field.</summary>
    public const int StaPercentFieldNumber = 1;
    private float staPercent_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float StaPercent {
      get { return staPercent_; }
      set {
        staPercent_ = value;
      }
    }

    /// <summary>Field number for the "atk_percent" field.</summary>
    public const int AtkPercentFieldNumber = 2;
    private float atkPercent_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float AtkPercent {
      get { return atkPercent_; }
      set {
        atkPercent_ = value;
      }
    }

    /// <summary>Field number for the "def_percent" field.</summary>
    public const int DefPercentFieldNumber = 3;
    private float defPercent_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float DefPercent {
      get { return defPercent_; }
      set {
        defPercent_ = value;
      }
    }

    /// <summary>Field number for the "duration_s" field.</summary>
    public const int DurationSFieldNumber = 4;
    private float durationS_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float DurationS {
      get { return durationS_; }
      set {
        durationS_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BattleAttributes);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BattleAttributes other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StaPercent != other.StaPercent) return false;
      if (AtkPercent != other.AtkPercent) return false;
      if (DefPercent != other.DefPercent) return false;
      if (DurationS != other.DurationS) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (StaPercent != 0F) hash ^= StaPercent.GetHashCode();
      if (AtkPercent != 0F) hash ^= AtkPercent.GetHashCode();
      if (DefPercent != 0F) hash ^= DefPercent.GetHashCode();
      if (DurationS != 0F) hash ^= DurationS.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (StaPercent != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(StaPercent);
      }
      if (AtkPercent != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(AtkPercent);
      }
      if (DefPercent != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(DefPercent);
      }
      if (DurationS != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(DurationS);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (StaPercent != 0F) {
        size += 1 + 4;
      }
      if (AtkPercent != 0F) {
        size += 1 + 4;
      }
      if (DefPercent != 0F) {
        size += 1 + 4;
      }
      if (DurationS != 0F) {
        size += 1 + 4;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BattleAttributes other) {
      if (other == null) {
        return;
      }
      if (other.StaPercent != 0F) {
        StaPercent = other.StaPercent;
      }
      if (other.AtkPercent != 0F) {
        AtkPercent = other.AtkPercent;
      }
      if (other.DefPercent != 0F) {
        DefPercent = other.DefPercent;
      }
      if (other.DurationS != 0F) {
        DurationS = other.DurationS;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 13: {
            StaPercent = input.ReadFloat();
            break;
          }
          case 21: {
            AtkPercent = input.ReadFloat();
            break;
          }
          case 29: {
            DefPercent = input.ReadFloat();
            break;
          }
          case 37: {
            DurationS = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
