// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Settings/Master/GymBattleSettings.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Settings.Master {

  /// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/GymBattleSettings.proto</summary>
  public static partial class GymBattleSettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Settings/Master/GymBattleSettings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GymBattleSettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9HeW1CYXR0bGVTZXR0aW5n",
            "cy5wcm90bxIaUE9HT1Byb3Rvcy5TZXR0aW5ncy5NYXN0ZXIikQQKEUd5bUJh",
            "dHRsZVNldHRpbmdzEhYKDmVuZXJneV9wZXJfc2VjGAEgASgCEhkKEWRvZGdl",
            "X2VuZXJneV9jb3N0GAIgASgCEhgKEHJldGFyZ2V0X3NlY29uZHMYAyABKAIS",
            "HQoVZW5lbXlfYXR0YWNrX2ludGVydmFsGAQgASgCEh4KFmF0dGFja19zZXJ2",
            "ZXJfaW50ZXJ2YWwYBSABKAISHgoWcm91bmRfZHVyYXRpb25fc2Vjb25kcxgG",
            "IAEoAhIjChtib251c190aW1lX3Blcl9hbGx5X3NlY29uZHMYByABKAISJAoc",
            "bWF4aW11bV9hdHRhY2tlcnNfcGVyX2JhdHRsZRgIIAEoBRIpCiFzYW1lX3R5",
            "cGVfYXR0YWNrX2JvbnVzX211bHRpcGxpZXIYCSABKAISFgoObWF4aW11bV9l",
            "bmVyZ3kYCiABKAUSJAocZW5lcmd5X2RlbHRhX3Blcl9oZWFsdGhfbG9zdBgL",
            "IAEoAhIZChFkb2RnZV9kdXJhdGlvbl9tcxgMIAEoBRIcChRtaW5pbXVtX3Bs",
            "YXllcl9sZXZlbBgNIAEoBRIYChBzd2FwX2R1cmF0aW9uX21zGA4gASgFEiYK",
            "HmRvZGdlX2RhbWFnZV9yZWR1Y3Rpb25fcGVyY2VudBgPIAEoAhIhChltaW5p",
            "bXVtX3JhaWRfcGxheWVyX2xldmVsGBAgASgFYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Settings.Master.GymBattleSettings), global::POGOProtos.Settings.Master.GymBattleSettings.Parser, new[]{ "EnergyPerSec", "DodgeEnergyCost", "RetargetSeconds", "EnemyAttackInterval", "AttackServerInterval", "RoundDurationSeconds", "BonusTimePerAllySeconds", "MaximumAttackersPerBattle", "SameTypeAttackBonusMultiplier", "MaximumEnergy", "EnergyDeltaPerHealthLost", "DodgeDurationMs", "MinimumPlayerLevel", "SwapDurationMs", "DodgeDamageReductionPercent", "MinimumRaidPlayerLevel" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GymBattleSettings : pb::IMessage<GymBattleSettings> {
    private static readonly pb::MessageParser<GymBattleSettings> _parser = new pb::MessageParser<GymBattleSettings>(() => new GymBattleSettings());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GymBattleSettings> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Settings.Master.GymBattleSettingsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GymBattleSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GymBattleSettings(GymBattleSettings other) : this() {
      energyPerSec_ = other.energyPerSec_;
      dodgeEnergyCost_ = other.dodgeEnergyCost_;
      retargetSeconds_ = other.retargetSeconds_;
      enemyAttackInterval_ = other.enemyAttackInterval_;
      attackServerInterval_ = other.attackServerInterval_;
      roundDurationSeconds_ = other.roundDurationSeconds_;
      bonusTimePerAllySeconds_ = other.bonusTimePerAllySeconds_;
      maximumAttackersPerBattle_ = other.maximumAttackersPerBattle_;
      sameTypeAttackBonusMultiplier_ = other.sameTypeAttackBonusMultiplier_;
      maximumEnergy_ = other.maximumEnergy_;
      energyDeltaPerHealthLost_ = other.energyDeltaPerHealthLost_;
      dodgeDurationMs_ = other.dodgeDurationMs_;
      minimumPlayerLevel_ = other.minimumPlayerLevel_;
      swapDurationMs_ = other.swapDurationMs_;
      dodgeDamageReductionPercent_ = other.dodgeDamageReductionPercent_;
      minimumRaidPlayerLevel_ = other.minimumRaidPlayerLevel_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GymBattleSettings Clone() {
      return new GymBattleSettings(this);
    }

    /// <summary>Field number for the "energy_per_sec" field.</summary>
    public const int EnergyPerSecFieldNumber = 1;
    private float energyPerSec_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float EnergyPerSec {
      get { return energyPerSec_; }
      set {
        energyPerSec_ = value;
      }
    }

    /// <summary>Field number for the "dodge_energy_cost" field.</summary>
    public const int DodgeEnergyCostFieldNumber = 2;
    private float dodgeEnergyCost_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float DodgeEnergyCost {
      get { return dodgeEnergyCost_; }
      set {
        dodgeEnergyCost_ = value;
      }
    }

    /// <summary>Field number for the "retarget_seconds" field.</summary>
    public const int RetargetSecondsFieldNumber = 3;
    private float retargetSeconds_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float RetargetSeconds {
      get { return retargetSeconds_; }
      set {
        retargetSeconds_ = value;
      }
    }

    /// <summary>Field number for the "enemy_attack_interval" field.</summary>
    public const int EnemyAttackIntervalFieldNumber = 4;
    private float enemyAttackInterval_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float EnemyAttackInterval {
      get { return enemyAttackInterval_; }
      set {
        enemyAttackInterval_ = value;
      }
    }

    /// <summary>Field number for the "attack_server_interval" field.</summary>
    public const int AttackServerIntervalFieldNumber = 5;
    private float attackServerInterval_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float AttackServerInterval {
      get { return attackServerInterval_; }
      set {
        attackServerInterval_ = value;
      }
    }

    /// <summary>Field number for the "round_duration_seconds" field.</summary>
    public const int RoundDurationSecondsFieldNumber = 6;
    private float roundDurationSeconds_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float RoundDurationSeconds {
      get { return roundDurationSeconds_; }
      set {
        roundDurationSeconds_ = value;
      }
    }

    /// <summary>Field number for the "bonus_time_per_ally_seconds" field.</summary>
    public const int BonusTimePerAllySecondsFieldNumber = 7;
    private float bonusTimePerAllySeconds_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float BonusTimePerAllySeconds {
      get { return bonusTimePerAllySeconds_; }
      set {
        bonusTimePerAllySeconds_ = value;
      }
    }

    /// <summary>Field number for the "maximum_attackers_per_battle" field.</summary>
    public const int MaximumAttackersPerBattleFieldNumber = 8;
    private int maximumAttackersPerBattle_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MaximumAttackersPerBattle {
      get { return maximumAttackersPerBattle_; }
      set {
        maximumAttackersPerBattle_ = value;
      }
    }

    /// <summary>Field number for the "same_type_attack_bonus_multiplier" field.</summary>
    public const int SameTypeAttackBonusMultiplierFieldNumber = 9;
    private float sameTypeAttackBonusMultiplier_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float SameTypeAttackBonusMultiplier {
      get { return sameTypeAttackBonusMultiplier_; }
      set {
        sameTypeAttackBonusMultiplier_ = value;
      }
    }

    /// <summary>Field number for the "maximum_energy" field.</summary>
    public const int MaximumEnergyFieldNumber = 10;
    private int maximumEnergy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MaximumEnergy {
      get { return maximumEnergy_; }
      set {
        maximumEnergy_ = value;
      }
    }

    /// <summary>Field number for the "energy_delta_per_health_lost" field.</summary>
    public const int EnergyDeltaPerHealthLostFieldNumber = 11;
    private float energyDeltaPerHealthLost_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float EnergyDeltaPerHealthLost {
      get { return energyDeltaPerHealthLost_; }
      set {
        energyDeltaPerHealthLost_ = value;
      }
    }

    /// <summary>Field number for the "dodge_duration_ms" field.</summary>
    public const int DodgeDurationMsFieldNumber = 12;
    private int dodgeDurationMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int DodgeDurationMs {
      get { return dodgeDurationMs_; }
      set {
        dodgeDurationMs_ = value;
      }
    }

    /// <summary>Field number for the "minimum_player_level" field.</summary>
    public const int MinimumPlayerLevelFieldNumber = 13;
    private int minimumPlayerLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MinimumPlayerLevel {
      get { return minimumPlayerLevel_; }
      set {
        minimumPlayerLevel_ = value;
      }
    }

    /// <summary>Field number for the "swap_duration_ms" field.</summary>
    public const int SwapDurationMsFieldNumber = 14;
    private int swapDurationMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int SwapDurationMs {
      get { return swapDurationMs_; }
      set {
        swapDurationMs_ = value;
      }
    }

    /// <summary>Field number for the "dodge_damage_reduction_percent" field.</summary>
    public const int DodgeDamageReductionPercentFieldNumber = 15;
    private float dodgeDamageReductionPercent_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float DodgeDamageReductionPercent {
      get { return dodgeDamageReductionPercent_; }
      set {
        dodgeDamageReductionPercent_ = value;
      }
    }

    /// <summary>Field number for the "minimum_raid_player_level" field.</summary>
    public const int MinimumRaidPlayerLevelFieldNumber = 16;
    private int minimumRaidPlayerLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MinimumRaidPlayerLevel {
      get { return minimumRaidPlayerLevel_; }
      set {
        minimumRaidPlayerLevel_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GymBattleSettings);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GymBattleSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EnergyPerSec != other.EnergyPerSec) return false;
      if (DodgeEnergyCost != other.DodgeEnergyCost) return false;
      if (RetargetSeconds != other.RetargetSeconds) return false;
      if (EnemyAttackInterval != other.EnemyAttackInterval) return false;
      if (AttackServerInterval != other.AttackServerInterval) return false;
      if (RoundDurationSeconds != other.RoundDurationSeconds) return false;
      if (BonusTimePerAllySeconds != other.BonusTimePerAllySeconds) return false;
      if (MaximumAttackersPerBattle != other.MaximumAttackersPerBattle) return false;
      if (SameTypeAttackBonusMultiplier != other.SameTypeAttackBonusMultiplier) return false;
      if (MaximumEnergy != other.MaximumEnergy) return false;
      if (EnergyDeltaPerHealthLost != other.EnergyDeltaPerHealthLost) return false;
      if (DodgeDurationMs != other.DodgeDurationMs) return false;
      if (MinimumPlayerLevel != other.MinimumPlayerLevel) return false;
      if (SwapDurationMs != other.SwapDurationMs) return false;
      if (DodgeDamageReductionPercent != other.DodgeDamageReductionPercent) return false;
      if (MinimumRaidPlayerLevel != other.MinimumRaidPlayerLevel) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (EnergyPerSec != 0F) hash ^= EnergyPerSec.GetHashCode();
      if (DodgeEnergyCost != 0F) hash ^= DodgeEnergyCost.GetHashCode();
      if (RetargetSeconds != 0F) hash ^= RetargetSeconds.GetHashCode();
      if (EnemyAttackInterval != 0F) hash ^= EnemyAttackInterval.GetHashCode();
      if (AttackServerInterval != 0F) hash ^= AttackServerInterval.GetHashCode();
      if (RoundDurationSeconds != 0F) hash ^= RoundDurationSeconds.GetHashCode();
      if (BonusTimePerAllySeconds != 0F) hash ^= BonusTimePerAllySeconds.GetHashCode();
      if (MaximumAttackersPerBattle != 0) hash ^= MaximumAttackersPerBattle.GetHashCode();
      if (SameTypeAttackBonusMultiplier != 0F) hash ^= SameTypeAttackBonusMultiplier.GetHashCode();
      if (MaximumEnergy != 0) hash ^= MaximumEnergy.GetHashCode();
      if (EnergyDeltaPerHealthLost != 0F) hash ^= EnergyDeltaPerHealthLost.GetHashCode();
      if (DodgeDurationMs != 0) hash ^= DodgeDurationMs.GetHashCode();
      if (MinimumPlayerLevel != 0) hash ^= MinimumPlayerLevel.GetHashCode();
      if (SwapDurationMs != 0) hash ^= SwapDurationMs.GetHashCode();
      if (DodgeDamageReductionPercent != 0F) hash ^= DodgeDamageReductionPercent.GetHashCode();
      if (MinimumRaidPlayerLevel != 0) hash ^= MinimumRaidPlayerLevel.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (EnergyPerSec != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(EnergyPerSec);
      }
      if (DodgeEnergyCost != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(DodgeEnergyCost);
      }
      if (RetargetSeconds != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(RetargetSeconds);
      }
      if (EnemyAttackInterval != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(EnemyAttackInterval);
      }
      if (AttackServerInterval != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(AttackServerInterval);
      }
      if (RoundDurationSeconds != 0F) {
        output.WriteRawTag(53);
        output.WriteFloat(RoundDurationSeconds);
      }
      if (BonusTimePerAllySeconds != 0F) {
        output.WriteRawTag(61);
        output.WriteFloat(BonusTimePerAllySeconds);
      }
      if (MaximumAttackersPerBattle != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(MaximumAttackersPerBattle);
      }
      if (SameTypeAttackBonusMultiplier != 0F) {
        output.WriteRawTag(77);
        output.WriteFloat(SameTypeAttackBonusMultiplier);
      }
      if (MaximumEnergy != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(MaximumEnergy);
      }
      if (EnergyDeltaPerHealthLost != 0F) {
        output.WriteRawTag(93);
        output.WriteFloat(EnergyDeltaPerHealthLost);
      }
      if (DodgeDurationMs != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(DodgeDurationMs);
      }
      if (MinimumPlayerLevel != 0) {
        output.WriteRawTag(104);
        output.WriteInt32(MinimumPlayerLevel);
      }
      if (SwapDurationMs != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(SwapDurationMs);
      }
      if (DodgeDamageReductionPercent != 0F) {
        output.WriteRawTag(125);
        output.WriteFloat(DodgeDamageReductionPercent);
      }
      if (MinimumRaidPlayerLevel != 0) {
        output.WriteRawTag(128, 1);
        output.WriteInt32(MinimumRaidPlayerLevel);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (EnergyPerSec != 0F) {
        size += 1 + 4;
      }
      if (DodgeEnergyCost != 0F) {
        size += 1 + 4;
      }
      if (RetargetSeconds != 0F) {
        size += 1 + 4;
      }
      if (EnemyAttackInterval != 0F) {
        size += 1 + 4;
      }
      if (AttackServerInterval != 0F) {
        size += 1 + 4;
      }
      if (RoundDurationSeconds != 0F) {
        size += 1 + 4;
      }
      if (BonusTimePerAllySeconds != 0F) {
        size += 1 + 4;
      }
      if (MaximumAttackersPerBattle != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaximumAttackersPerBattle);
      }
      if (SameTypeAttackBonusMultiplier != 0F) {
        size += 1 + 4;
      }
      if (MaximumEnergy != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaximumEnergy);
      }
      if (EnergyDeltaPerHealthLost != 0F) {
        size += 1 + 4;
      }
      if (DodgeDurationMs != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(DodgeDurationMs);
      }
      if (MinimumPlayerLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MinimumPlayerLevel);
      }
      if (SwapDurationMs != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SwapDurationMs);
      }
      if (DodgeDamageReductionPercent != 0F) {
        size += 1 + 4;
      }
      if (MinimumRaidPlayerLevel != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(MinimumRaidPlayerLevel);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GymBattleSettings other) {
      if (other == null) {
        return;
      }
      if (other.EnergyPerSec != 0F) {
        EnergyPerSec = other.EnergyPerSec;
      }
      if (other.DodgeEnergyCost != 0F) {
        DodgeEnergyCost = other.DodgeEnergyCost;
      }
      if (other.RetargetSeconds != 0F) {
        RetargetSeconds = other.RetargetSeconds;
      }
      if (other.EnemyAttackInterval != 0F) {
        EnemyAttackInterval = other.EnemyAttackInterval;
      }
      if (other.AttackServerInterval != 0F) {
        AttackServerInterval = other.AttackServerInterval;
      }
      if (other.RoundDurationSeconds != 0F) {
        RoundDurationSeconds = other.RoundDurationSeconds;
      }
      if (other.BonusTimePerAllySeconds != 0F) {
        BonusTimePerAllySeconds = other.BonusTimePerAllySeconds;
      }
      if (other.MaximumAttackersPerBattle != 0) {
        MaximumAttackersPerBattle = other.MaximumAttackersPerBattle;
      }
      if (other.SameTypeAttackBonusMultiplier != 0F) {
        SameTypeAttackBonusMultiplier = other.SameTypeAttackBonusMultiplier;
      }
      if (other.MaximumEnergy != 0) {
        MaximumEnergy = other.MaximumEnergy;
      }
      if (other.EnergyDeltaPerHealthLost != 0F) {
        EnergyDeltaPerHealthLost = other.EnergyDeltaPerHealthLost;
      }
      if (other.DodgeDurationMs != 0) {
        DodgeDurationMs = other.DodgeDurationMs;
      }
      if (other.MinimumPlayerLevel != 0) {
        MinimumPlayerLevel = other.MinimumPlayerLevel;
      }
      if (other.SwapDurationMs != 0) {
        SwapDurationMs = other.SwapDurationMs;
      }
      if (other.DodgeDamageReductionPercent != 0F) {
        DodgeDamageReductionPercent = other.DodgeDamageReductionPercent;
      }
      if (other.MinimumRaidPlayerLevel != 0) {
        MinimumRaidPlayerLevel = other.MinimumRaidPlayerLevel;
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
            EnergyPerSec = input.ReadFloat();
            break;
          }
          case 21: {
            DodgeEnergyCost = input.ReadFloat();
            break;
          }
          case 29: {
            RetargetSeconds = input.ReadFloat();
            break;
          }
          case 37: {
            EnemyAttackInterval = input.ReadFloat();
            break;
          }
          case 45: {
            AttackServerInterval = input.ReadFloat();
            break;
          }
          case 53: {
            RoundDurationSeconds = input.ReadFloat();
            break;
          }
          case 61: {
            BonusTimePerAllySeconds = input.ReadFloat();
            break;
          }
          case 64: {
            MaximumAttackersPerBattle = input.ReadInt32();
            break;
          }
          case 77: {
            SameTypeAttackBonusMultiplier = input.ReadFloat();
            break;
          }
          case 80: {
            MaximumEnergy = input.ReadInt32();
            break;
          }
          case 93: {
            EnergyDeltaPerHealthLost = input.ReadFloat();
            break;
          }
          case 96: {
            DodgeDurationMs = input.ReadInt32();
            break;
          }
          case 104: {
            MinimumPlayerLevel = input.ReadInt32();
            break;
          }
          case 112: {
            SwapDurationMs = input.ReadInt32();
            break;
          }
          case 125: {
            DodgeDamageReductionPercent = input.ReadFloat();
            break;
          }
          case 128: {
            MinimumRaidPlayerLevel = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
