// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Data/Battle/BattleState.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Battle {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Battle/BattleState.proto</summary>
  public static partial class BattleStateReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Battle/BattleState.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BattleStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihQT0dPUHJvdG9zL0RhdGEvQmF0dGxlL0JhdHRsZVN0YXRlLnByb3RvEhZQ",
            "T0dPUHJvdG9zLkRhdGEuQmF0dGxlKlQKC0JhdHRsZVN0YXRlEg8KC1NUQVRF",
            "X1VOU0VUEAASCgoGQUNUSVZFEAESCwoHVklDVE9SWRACEgwKCERFRkVBVEVE",
            "EAMSDQoJVElNRURfT1VUEARiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::POGOProtos.Data.Battle.BattleState), }, null));
    }
    #endregion

  }
  #region Enums
  public enum BattleState {
    [pbr::OriginalName("STATE_UNSET")] StateUnset = 0,
    [pbr::OriginalName("ACTIVE")] Active = 1,
    [pbr::OriginalName("VICTORY")] Victory = 2,
    [pbr::OriginalName("DEFEATED")] Defeated = 3,
    [pbr::OriginalName("TIMED_OUT")] TimedOut = 4,
  }

  #endregion

}

#endregion Designer generated code
