// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Settings/Master/EncounterSettings.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Settings.Master {

  /// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/EncounterSettings.proto</summary>
  public static partial class EncounterSettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Settings/Master/EncounterSettings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EncounterSettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9FbmNvdW50ZXJTZXR0aW5n",
            "cy5wcm90bxIaUE9HT1Byb3Rvcy5TZXR0aW5ncy5NYXN0ZXIi0wUKEUVuY291",
            "bnRlclNldHRpbmdzEhwKFHNwaW5fYm9udXNfdGhyZXNob2xkGAEgASgCEiEK",
            "GWV4Y2VsbGVudF90aHJvd190aHJlc2hvbGQYAiABKAISHQoVZ3JlYXRfdGhy",
            "b3dfdGhyZXNob2xkGAMgASgCEhwKFG5pY2VfdGhyb3dfdGhyZXNob2xkGAQg",
            "ASgCEhsKE21pbGVzdG9uZV90aHJlc2hvbGQYBSABKAUSHAoUYXJfcGx1c19t",
            "b2RlX2VuYWJsZWQYBiABKAgSJAocYXJfY2xvc2VfcHJveGltaXR5X3RocmVz",
            "aG9sZBgHIAEoAhIiChphcl9sb3dfYXdhcmVuZXNzX3RocmVzaG9sZBgIIAEo",
            "AhIlCh1hcl9jbG9zZV9wcm94aW1pdHlfbXVsdGlwbGllchgJIAEoAhImCh5h",
            "cl9hd2FyZW5lc3NfcGVuYWx0eV90aHJlc2hvbGQYCiABKAISJwofYXJfbG93",
            "X2F3YXJlbmVzc19tYXhfbXVsdGlwbGllchgLIAEoAhIwCihhcl9oaWdoX2F3",
            "YXJlbmVzc19taW5fcGVuYWx0eV9tdWx0aXBsaWVyGAwgASgCEicKH2FyX3Bs",
            "dXNfYXR0ZW1wdHNfdW50aWxfZmxlZV9tYXgYDSABKAUSLAokYXJfcGx1c19h",
            "dHRlbXB0c191bnRpbF9mbGVlX2luZmluaXRlGA4gASgFEiQKHGVzY2FwZWRf",
            "Ym9udXNfbXVsdGlwbGllcl9tYXgYDyABKAISMworZXNjYXBlZF9ib251c19t",
            "dWx0aXBsaWVyX2J5X2V4Y2VsbGVudF90aHJvdxgQIAEoAhIvCidlc2NhcGVk",
            "X2JvbnVzX211bHRpcGxpZXJfYnlfZ3JlYXRfdGhyb3cYESABKAISLgomZXNj",
            "YXBlZF9ib251c19tdWx0aXBsaWVyX2J5X25pY2VfdGhyb3cYEiABKAJiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Settings.Master.EncounterSettings), global::POGOProtos.Settings.Master.EncounterSettings.Parser, new[]{ "SpinBonusThreshold", "ExcellentThrowThreshold", "GreatThrowThreshold", "NiceThrowThreshold", "MilestoneThreshold", "ArPlusModeEnabled", "ArCloseProximityThreshold", "ArLowAwarenessThreshold", "ArCloseProximityMultiplier", "ArAwarenessPenaltyThreshold", "ArLowAwarenessMaxMultiplier", "ArHighAwarenessMinPenaltyMultiplier", "ArPlusAttemptsUntilFleeMax", "ArPlusAttemptsUntilFleeInfinite", "EscapedBonusMultiplierMax", "EscapedBonusMultiplierByExcellentThrow", "EscapedBonusMultiplierByGreatThrow", "EscapedBonusMultiplierByNiceThrow" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EncounterSettings : pb::IMessage<EncounterSettings> {
    private static readonly pb::MessageParser<EncounterSettings> _parser = new pb::MessageParser<EncounterSettings>(() => new EncounterSettings());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EncounterSettings> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Settings.Master.EncounterSettingsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncounterSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncounterSettings(EncounterSettings other) : this() {
      spinBonusThreshold_ = other.spinBonusThreshold_;
      excellentThrowThreshold_ = other.excellentThrowThreshold_;
      greatThrowThreshold_ = other.greatThrowThreshold_;
      niceThrowThreshold_ = other.niceThrowThreshold_;
      milestoneThreshold_ = other.milestoneThreshold_;
      arPlusModeEnabled_ = other.arPlusModeEnabled_;
      arCloseProximityThreshold_ = other.arCloseProximityThreshold_;
      arLowAwarenessThreshold_ = other.arLowAwarenessThreshold_;
      arCloseProximityMultiplier_ = other.arCloseProximityMultiplier_;
      arAwarenessPenaltyThreshold_ = other.arAwarenessPenaltyThreshold_;
      arLowAwarenessMaxMultiplier_ = other.arLowAwarenessMaxMultiplier_;
      arHighAwarenessMinPenaltyMultiplier_ = other.arHighAwarenessMinPenaltyMultiplier_;
      arPlusAttemptsUntilFleeMax_ = other.arPlusAttemptsUntilFleeMax_;
      arPlusAttemptsUntilFleeInfinite_ = other.arPlusAttemptsUntilFleeInfinite_;
      escapedBonusMultiplierMax_ = other.escapedBonusMultiplierMax_;
      escapedBonusMultiplierByExcellentThrow_ = other.escapedBonusMultiplierByExcellentThrow_;
      escapedBonusMultiplierByGreatThrow_ = other.escapedBonusMultiplierByGreatThrow_;
      escapedBonusMultiplierByNiceThrow_ = other.escapedBonusMultiplierByNiceThrow_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncounterSettings Clone() {
      return new EncounterSettings(this);
    }

    /// <summary>Field number for the "spin_bonus_threshold" field.</summary>
    public const int SpinBonusThresholdFieldNumber = 1;
    private float spinBonusThreshold_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float SpinBonusThreshold {
      get { return spinBonusThreshold_; }
      set {
        spinBonusThreshold_ = value;
      }
    }

    /// <summary>Field number for the "excellent_throw_threshold" field.</summary>
    public const int ExcellentThrowThresholdFieldNumber = 2;
    private float excellentThrowThreshold_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float ExcellentThrowThreshold {
      get { return excellentThrowThreshold_; }
      set {
        excellentThrowThreshold_ = value;
      }
    }

    /// <summary>Field number for the "great_throw_threshold" field.</summary>
    public const int GreatThrowThresholdFieldNumber = 3;
    private float greatThrowThreshold_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float GreatThrowThreshold {
      get { return greatThrowThreshold_; }
      set {
        greatThrowThreshold_ = value;
      }
    }

    /// <summary>Field number for the "nice_throw_threshold" field.</summary>
    public const int NiceThrowThresholdFieldNumber = 4;
    private float niceThrowThreshold_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float NiceThrowThreshold {
      get { return niceThrowThreshold_; }
      set {
        niceThrowThreshold_ = value;
      }
    }

    /// <summary>Field number for the "milestone_threshold" field.</summary>
    public const int MilestoneThresholdFieldNumber = 5;
    private int milestoneThreshold_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MilestoneThreshold {
      get { return milestoneThreshold_; }
      set {
        milestoneThreshold_ = value;
      }
    }

    /// <summary>Field number for the "ar_plus_mode_enabled" field.</summary>
    public const int ArPlusModeEnabledFieldNumber = 6;
    private bool arPlusModeEnabled_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ArPlusModeEnabled {
      get { return arPlusModeEnabled_; }
      set {
        arPlusModeEnabled_ = value;
      }
    }

    /// <summary>Field number for the "ar_close_proximity_threshold" field.</summary>
    public const int ArCloseProximityThresholdFieldNumber = 7;
    private float arCloseProximityThreshold_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float ArCloseProximityThreshold {
      get { return arCloseProximityThreshold_; }
      set {
        arCloseProximityThreshold_ = value;
      }
    }

    /// <summary>Field number for the "ar_low_awareness_threshold" field.</summary>
    public const int ArLowAwarenessThresholdFieldNumber = 8;
    private float arLowAwarenessThreshold_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float ArLowAwarenessThreshold {
      get { return arLowAwarenessThreshold_; }
      set {
        arLowAwarenessThreshold_ = value;
      }
    }

    /// <summary>Field number for the "ar_close_proximity_multiplier" field.</summary>
    public const int ArCloseProximityMultiplierFieldNumber = 9;
    private float arCloseProximityMultiplier_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float ArCloseProximityMultiplier {
      get { return arCloseProximityMultiplier_; }
      set {
        arCloseProximityMultiplier_ = value;
      }
    }

    /// <summary>Field number for the "ar_awareness_penalty_threshold" field.</summary>
    public const int ArAwarenessPenaltyThresholdFieldNumber = 10;
    private float arAwarenessPenaltyThreshold_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float ArAwarenessPenaltyThreshold {
      get { return arAwarenessPenaltyThreshold_; }
      set {
        arAwarenessPenaltyThreshold_ = value;
      }
    }

    /// <summary>Field number for the "ar_low_awareness_max_multiplier" field.</summary>
    public const int ArLowAwarenessMaxMultiplierFieldNumber = 11;
    private float arLowAwarenessMaxMultiplier_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float ArLowAwarenessMaxMultiplier {
      get { return arLowAwarenessMaxMultiplier_; }
      set {
        arLowAwarenessMaxMultiplier_ = value;
      }
    }

    /// <summary>Field number for the "ar_high_awareness_min_penalty_multiplier" field.</summary>
    public const int ArHighAwarenessMinPenaltyMultiplierFieldNumber = 12;
    private float arHighAwarenessMinPenaltyMultiplier_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float ArHighAwarenessMinPenaltyMultiplier {
      get { return arHighAwarenessMinPenaltyMultiplier_; }
      set {
        arHighAwarenessMinPenaltyMultiplier_ = value;
      }
    }

    /// <summary>Field number for the "ar_plus_attempts_until_flee_max" field.</summary>
    public const int ArPlusAttemptsUntilFleeMaxFieldNumber = 13;
    private int arPlusAttemptsUntilFleeMax_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ArPlusAttemptsUntilFleeMax {
      get { return arPlusAttemptsUntilFleeMax_; }
      set {
        arPlusAttemptsUntilFleeMax_ = value;
      }
    }

    /// <summary>Field number for the "ar_plus_attempts_until_flee_infinite" field.</summary>
    public const int ArPlusAttemptsUntilFleeInfiniteFieldNumber = 14;
    private int arPlusAttemptsUntilFleeInfinite_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ArPlusAttemptsUntilFleeInfinite {
      get { return arPlusAttemptsUntilFleeInfinite_; }
      set {
        arPlusAttemptsUntilFleeInfinite_ = value;
      }
    }

    /// <summary>Field number for the "escaped_bonus_multiplier_max" field.</summary>
    public const int EscapedBonusMultiplierMaxFieldNumber = 15;
    private float escapedBonusMultiplierMax_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float EscapedBonusMultiplierMax {
      get { return escapedBonusMultiplierMax_; }
      set {
        escapedBonusMultiplierMax_ = value;
      }
    }

    /// <summary>Field number for the "escaped_bonus_multiplier_by_excellent_throw" field.</summary>
    public const int EscapedBonusMultiplierByExcellentThrowFieldNumber = 16;
    private float escapedBonusMultiplierByExcellentThrow_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float EscapedBonusMultiplierByExcellentThrow {
      get { return escapedBonusMultiplierByExcellentThrow_; }
      set {
        escapedBonusMultiplierByExcellentThrow_ = value;
      }
    }

    /// <summary>Field number for the "escaped_bonus_multiplier_by_great_throw" field.</summary>
    public const int EscapedBonusMultiplierByGreatThrowFieldNumber = 17;
    private float escapedBonusMultiplierByGreatThrow_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float EscapedBonusMultiplierByGreatThrow {
      get { return escapedBonusMultiplierByGreatThrow_; }
      set {
        escapedBonusMultiplierByGreatThrow_ = value;
      }
    }

    /// <summary>Field number for the "escaped_bonus_multiplier_by_nice_throw" field.</summary>
    public const int EscapedBonusMultiplierByNiceThrowFieldNumber = 18;
    private float escapedBonusMultiplierByNiceThrow_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float EscapedBonusMultiplierByNiceThrow {
      get { return escapedBonusMultiplierByNiceThrow_; }
      set {
        escapedBonusMultiplierByNiceThrow_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EncounterSettings);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EncounterSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SpinBonusThreshold != other.SpinBonusThreshold) return false;
      if (ExcellentThrowThreshold != other.ExcellentThrowThreshold) return false;
      if (GreatThrowThreshold != other.GreatThrowThreshold) return false;
      if (NiceThrowThreshold != other.NiceThrowThreshold) return false;
      if (MilestoneThreshold != other.MilestoneThreshold) return false;
      if (ArPlusModeEnabled != other.ArPlusModeEnabled) return false;
      if (ArCloseProximityThreshold != other.ArCloseProximityThreshold) return false;
      if (ArLowAwarenessThreshold != other.ArLowAwarenessThreshold) return false;
      if (ArCloseProximityMultiplier != other.ArCloseProximityMultiplier) return false;
      if (ArAwarenessPenaltyThreshold != other.ArAwarenessPenaltyThreshold) return false;
      if (ArLowAwarenessMaxMultiplier != other.ArLowAwarenessMaxMultiplier) return false;
      if (ArHighAwarenessMinPenaltyMultiplier != other.ArHighAwarenessMinPenaltyMultiplier) return false;
      if (ArPlusAttemptsUntilFleeMax != other.ArPlusAttemptsUntilFleeMax) return false;
      if (ArPlusAttemptsUntilFleeInfinite != other.ArPlusAttemptsUntilFleeInfinite) return false;
      if (EscapedBonusMultiplierMax != other.EscapedBonusMultiplierMax) return false;
      if (EscapedBonusMultiplierByExcellentThrow != other.EscapedBonusMultiplierByExcellentThrow) return false;
      if (EscapedBonusMultiplierByGreatThrow != other.EscapedBonusMultiplierByGreatThrow) return false;
      if (EscapedBonusMultiplierByNiceThrow != other.EscapedBonusMultiplierByNiceThrow) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SpinBonusThreshold != 0F) hash ^= SpinBonusThreshold.GetHashCode();
      if (ExcellentThrowThreshold != 0F) hash ^= ExcellentThrowThreshold.GetHashCode();
      if (GreatThrowThreshold != 0F) hash ^= GreatThrowThreshold.GetHashCode();
      if (NiceThrowThreshold != 0F) hash ^= NiceThrowThreshold.GetHashCode();
      if (MilestoneThreshold != 0) hash ^= MilestoneThreshold.GetHashCode();
      if (ArPlusModeEnabled != false) hash ^= ArPlusModeEnabled.GetHashCode();
      if (ArCloseProximityThreshold != 0F) hash ^= ArCloseProximityThreshold.GetHashCode();
      if (ArLowAwarenessThreshold != 0F) hash ^= ArLowAwarenessThreshold.GetHashCode();
      if (ArCloseProximityMultiplier != 0F) hash ^= ArCloseProximityMultiplier.GetHashCode();
      if (ArAwarenessPenaltyThreshold != 0F) hash ^= ArAwarenessPenaltyThreshold.GetHashCode();
      if (ArLowAwarenessMaxMultiplier != 0F) hash ^= ArLowAwarenessMaxMultiplier.GetHashCode();
      if (ArHighAwarenessMinPenaltyMultiplier != 0F) hash ^= ArHighAwarenessMinPenaltyMultiplier.GetHashCode();
      if (ArPlusAttemptsUntilFleeMax != 0) hash ^= ArPlusAttemptsUntilFleeMax.GetHashCode();
      if (ArPlusAttemptsUntilFleeInfinite != 0) hash ^= ArPlusAttemptsUntilFleeInfinite.GetHashCode();
      if (EscapedBonusMultiplierMax != 0F) hash ^= EscapedBonusMultiplierMax.GetHashCode();
      if (EscapedBonusMultiplierByExcellentThrow != 0F) hash ^= EscapedBonusMultiplierByExcellentThrow.GetHashCode();
      if (EscapedBonusMultiplierByGreatThrow != 0F) hash ^= EscapedBonusMultiplierByGreatThrow.GetHashCode();
      if (EscapedBonusMultiplierByNiceThrow != 0F) hash ^= EscapedBonusMultiplierByNiceThrow.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (SpinBonusThreshold != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(SpinBonusThreshold);
      }
      if (ExcellentThrowThreshold != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(ExcellentThrowThreshold);
      }
      if (GreatThrowThreshold != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(GreatThrowThreshold);
      }
      if (NiceThrowThreshold != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(NiceThrowThreshold);
      }
      if (MilestoneThreshold != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(MilestoneThreshold);
      }
      if (ArPlusModeEnabled != false) {
        output.WriteRawTag(48);
        output.WriteBool(ArPlusModeEnabled);
      }
      if (ArCloseProximityThreshold != 0F) {
        output.WriteRawTag(61);
        output.WriteFloat(ArCloseProximityThreshold);
      }
      if (ArLowAwarenessThreshold != 0F) {
        output.WriteRawTag(69);
        output.WriteFloat(ArLowAwarenessThreshold);
      }
      if (ArCloseProximityMultiplier != 0F) {
        output.WriteRawTag(77);
        output.WriteFloat(ArCloseProximityMultiplier);
      }
      if (ArAwarenessPenaltyThreshold != 0F) {
        output.WriteRawTag(85);
        output.WriteFloat(ArAwarenessPenaltyThreshold);
      }
      if (ArLowAwarenessMaxMultiplier != 0F) {
        output.WriteRawTag(93);
        output.WriteFloat(ArLowAwarenessMaxMultiplier);
      }
      if (ArHighAwarenessMinPenaltyMultiplier != 0F) {
        output.WriteRawTag(101);
        output.WriteFloat(ArHighAwarenessMinPenaltyMultiplier);
      }
      if (ArPlusAttemptsUntilFleeMax != 0) {
        output.WriteRawTag(104);
        output.WriteInt32(ArPlusAttemptsUntilFleeMax);
      }
      if (ArPlusAttemptsUntilFleeInfinite != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(ArPlusAttemptsUntilFleeInfinite);
      }
      if (EscapedBonusMultiplierMax != 0F) {
        output.WriteRawTag(125);
        output.WriteFloat(EscapedBonusMultiplierMax);
      }
      if (EscapedBonusMultiplierByExcellentThrow != 0F) {
        output.WriteRawTag(133, 1);
        output.WriteFloat(EscapedBonusMultiplierByExcellentThrow);
      }
      if (EscapedBonusMultiplierByGreatThrow != 0F) {
        output.WriteRawTag(141, 1);
        output.WriteFloat(EscapedBonusMultiplierByGreatThrow);
      }
      if (EscapedBonusMultiplierByNiceThrow != 0F) {
        output.WriteRawTag(149, 1);
        output.WriteFloat(EscapedBonusMultiplierByNiceThrow);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SpinBonusThreshold != 0F) {
        size += 1 + 4;
      }
      if (ExcellentThrowThreshold != 0F) {
        size += 1 + 4;
      }
      if (GreatThrowThreshold != 0F) {
        size += 1 + 4;
      }
      if (NiceThrowThreshold != 0F) {
        size += 1 + 4;
      }
      if (MilestoneThreshold != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MilestoneThreshold);
      }
      if (ArPlusModeEnabled != false) {
        size += 1 + 1;
      }
      if (ArCloseProximityThreshold != 0F) {
        size += 1 + 4;
      }
      if (ArLowAwarenessThreshold != 0F) {
        size += 1 + 4;
      }
      if (ArCloseProximityMultiplier != 0F) {
        size += 1 + 4;
      }
      if (ArAwarenessPenaltyThreshold != 0F) {
        size += 1 + 4;
      }
      if (ArLowAwarenessMaxMultiplier != 0F) {
        size += 1 + 4;
      }
      if (ArHighAwarenessMinPenaltyMultiplier != 0F) {
        size += 1 + 4;
      }
      if (ArPlusAttemptsUntilFleeMax != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ArPlusAttemptsUntilFleeMax);
      }
      if (ArPlusAttemptsUntilFleeInfinite != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ArPlusAttemptsUntilFleeInfinite);
      }
      if (EscapedBonusMultiplierMax != 0F) {
        size += 1 + 4;
      }
      if (EscapedBonusMultiplierByExcellentThrow != 0F) {
        size += 2 + 4;
      }
      if (EscapedBonusMultiplierByGreatThrow != 0F) {
        size += 2 + 4;
      }
      if (EscapedBonusMultiplierByNiceThrow != 0F) {
        size += 2 + 4;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EncounterSettings other) {
      if (other == null) {
        return;
      }
      if (other.SpinBonusThreshold != 0F) {
        SpinBonusThreshold = other.SpinBonusThreshold;
      }
      if (other.ExcellentThrowThreshold != 0F) {
        ExcellentThrowThreshold = other.ExcellentThrowThreshold;
      }
      if (other.GreatThrowThreshold != 0F) {
        GreatThrowThreshold = other.GreatThrowThreshold;
      }
      if (other.NiceThrowThreshold != 0F) {
        NiceThrowThreshold = other.NiceThrowThreshold;
      }
      if (other.MilestoneThreshold != 0) {
        MilestoneThreshold = other.MilestoneThreshold;
      }
      if (other.ArPlusModeEnabled != false) {
        ArPlusModeEnabled = other.ArPlusModeEnabled;
      }
      if (other.ArCloseProximityThreshold != 0F) {
        ArCloseProximityThreshold = other.ArCloseProximityThreshold;
      }
      if (other.ArLowAwarenessThreshold != 0F) {
        ArLowAwarenessThreshold = other.ArLowAwarenessThreshold;
      }
      if (other.ArCloseProximityMultiplier != 0F) {
        ArCloseProximityMultiplier = other.ArCloseProximityMultiplier;
      }
      if (other.ArAwarenessPenaltyThreshold != 0F) {
        ArAwarenessPenaltyThreshold = other.ArAwarenessPenaltyThreshold;
      }
      if (other.ArLowAwarenessMaxMultiplier != 0F) {
        ArLowAwarenessMaxMultiplier = other.ArLowAwarenessMaxMultiplier;
      }
      if (other.ArHighAwarenessMinPenaltyMultiplier != 0F) {
        ArHighAwarenessMinPenaltyMultiplier = other.ArHighAwarenessMinPenaltyMultiplier;
      }
      if (other.ArPlusAttemptsUntilFleeMax != 0) {
        ArPlusAttemptsUntilFleeMax = other.ArPlusAttemptsUntilFleeMax;
      }
      if (other.ArPlusAttemptsUntilFleeInfinite != 0) {
        ArPlusAttemptsUntilFleeInfinite = other.ArPlusAttemptsUntilFleeInfinite;
      }
      if (other.EscapedBonusMultiplierMax != 0F) {
        EscapedBonusMultiplierMax = other.EscapedBonusMultiplierMax;
      }
      if (other.EscapedBonusMultiplierByExcellentThrow != 0F) {
        EscapedBonusMultiplierByExcellentThrow = other.EscapedBonusMultiplierByExcellentThrow;
      }
      if (other.EscapedBonusMultiplierByGreatThrow != 0F) {
        EscapedBonusMultiplierByGreatThrow = other.EscapedBonusMultiplierByGreatThrow;
      }
      if (other.EscapedBonusMultiplierByNiceThrow != 0F) {
        EscapedBonusMultiplierByNiceThrow = other.EscapedBonusMultiplierByNiceThrow;
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
            SpinBonusThreshold = input.ReadFloat();
            break;
          }
          case 21: {
            ExcellentThrowThreshold = input.ReadFloat();
            break;
          }
          case 29: {
            GreatThrowThreshold = input.ReadFloat();
            break;
          }
          case 37: {
            NiceThrowThreshold = input.ReadFloat();
            break;
          }
          case 40: {
            MilestoneThreshold = input.ReadInt32();
            break;
          }
          case 48: {
            ArPlusModeEnabled = input.ReadBool();
            break;
          }
          case 61: {
            ArCloseProximityThreshold = input.ReadFloat();
            break;
          }
          case 69: {
            ArLowAwarenessThreshold = input.ReadFloat();
            break;
          }
          case 77: {
            ArCloseProximityMultiplier = input.ReadFloat();
            break;
          }
          case 85: {
            ArAwarenessPenaltyThreshold = input.ReadFloat();
            break;
          }
          case 93: {
            ArLowAwarenessMaxMultiplier = input.ReadFloat();
            break;
          }
          case 101: {
            ArHighAwarenessMinPenaltyMultiplier = input.ReadFloat();
            break;
          }
          case 104: {
            ArPlusAttemptsUntilFleeMax = input.ReadInt32();
            break;
          }
          case 112: {
            ArPlusAttemptsUntilFleeInfinite = input.ReadInt32();
            break;
          }
          case 125: {
            EscapedBonusMultiplierMax = input.ReadFloat();
            break;
          }
          case 133: {
            EscapedBonusMultiplierByExcellentThrow = input.ReadFloat();
            break;
          }
          case 141: {
            EscapedBonusMultiplierByGreatThrow = input.ReadFloat();
            break;
          }
          case 149: {
            EscapedBonusMultiplierByNiceThrow = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
