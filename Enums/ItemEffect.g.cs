// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Enums/ItemEffect.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Enums {

  /// <summary>Holder for reflection information generated from POGOProtos/Enums/ItemEffect.proto</summary>
  public static partial class ItemEffectReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Enums/ItemEffect.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ItemEffectReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFQT0dPUHJvdG9zL0VudW1zL0l0ZW1FZmZlY3QucHJvdG8SEFBPR09Qcm90",
            "b3MuRW51bXMq2AQKCkl0ZW1FZmZlY3QSFAoQSVRFTV9FRkZFQ1RfTk9ORRAA",
            "EhwKF0lURU1fRUZGRUNUX0NBUF9OT19GTEVFEOgHEiAKG0lURU1fRUZGRUNU",
            "X0NBUF9OT19NT1ZFTUVOVBDqBxIeChlJVEVNX0VGRkVDVF9DQVBfTk9fVEhS",
            "RUFUEOsHEh8KGklURU1fRUZGRUNUX0NBUF9UQVJHRVRfTUFYEOwHEiAKG0lU",
            "RU1fRUZGRUNUX0NBUF9UQVJHRVRfU0xPVxDtBxIhChxJVEVNX0VGRkVDVF9D",
            "QVBfQ0hBTkNFX05JR0hUEO4HEiMKHklURU1fRUZGRUNUX0NBUF9DSEFOQ0Vf",
            "VFJBSU5FUhDvBxInCiJJVEVNX0VGRkVDVF9DQVBfQ0hBTkNFX0ZJUlNUX1RI",
            "Uk9XEPAHEiIKHUlURU1fRUZGRUNUX0NBUF9DSEFOQ0VfTEVHRU5EEPEHEiEK",
            "HElURU1fRUZGRUNUX0NBUF9DSEFOQ0VfSEVBVlkQ8gcSIgodSVRFTV9FRkZF",
            "Q1RfQ0FQX0NIQU5DRV9SRVBFQVQQ8wcSJwoiSVRFTV9FRkZFQ1RfQ0FQX0NI",
            "QU5DRV9NVUxUSV9USFJPVxD0BxIiCh1JVEVNX0VGRkVDVF9DQVBfQ0hBTkNF",
            "X0FMV0FZUxD1BxIoCiNJVEVNX0VGRkVDVF9DQVBfQ0hBTkNFX1NJTkdMRV9U",
            "SFJPVxD2BxIcChdJVEVNX0VGRkVDVF9DQU5EWV9BV0FSRBD3BxIgChtJVEVN",
            "X0VGRkVDVF9GVUxMX01PVElWQVRJT04Q+AdiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::POGOProtos.Enums.ItemEffect), }, null));
    }
    #endregion

  }
  #region Enums
  public enum ItemEffect {
    [pbr::OriginalName("ITEM_EFFECT_NONE")] None = 0,
    [pbr::OriginalName("ITEM_EFFECT_CAP_NO_FLEE")] CapNoFlee = 1000,
    [pbr::OriginalName("ITEM_EFFECT_CAP_NO_MOVEMENT")] CapNoMovement = 1002,
    [pbr::OriginalName("ITEM_EFFECT_CAP_NO_THREAT")] CapNoThreat = 1003,
    [pbr::OriginalName("ITEM_EFFECT_CAP_TARGET_MAX")] CapTargetMax = 1004,
    [pbr::OriginalName("ITEM_EFFECT_CAP_TARGET_SLOW")] CapTargetSlow = 1005,
    [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_NIGHT")] CapChanceNight = 1006,
    [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_TRAINER")] CapChanceTrainer = 1007,
    [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_FIRST_THROW")] CapChanceFirstThrow = 1008,
    [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_LEGEND")] CapChanceLegend = 1009,
    [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_HEAVY")] CapChanceHeavy = 1010,
    [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_REPEAT")] CapChanceRepeat = 1011,
    [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_MULTI_THROW")] CapChanceMultiThrow = 1012,
    [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_ALWAYS")] CapChanceAlways = 1013,
    [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_SINGLE_THROW")] CapChanceSingleThrow = 1014,
    [pbr::OriginalName("ITEM_EFFECT_CANDY_AWARD")] CandyAward = 1015,
    [pbr::OriginalName("ITEM_EFFECT_FULL_MOTIVATION")] FullMotivation = 1016,
  }

  #endregion

}

#endregion Designer generated code
