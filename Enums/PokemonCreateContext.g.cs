// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Enums/PokemonCreateContext.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Enums {

  /// <summary>Holder for reflection information generated from POGOProtos/Enums/PokemonCreateContext.proto</summary>
  public static partial class PokemonCreateContextReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Enums/PokemonCreateContext.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PokemonCreateContextReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitQT0dPUHJvdG9zL0VudW1zL1Bva2Vtb25DcmVhdGVDb250ZXh0LnByb3Rv",
            "EhBQT0dPUHJvdG9zLkVudW1zKmIKFFBva2Vtb25DcmVhdGVDb250ZXh0EhcK",
            "E0NSRUFURV9DT05URVhUX1dJTEQQABIWChJDUkVBVEVfQ09OVEVYVF9FR0cQ",
            "ARIZChVDUkVBVEVfQ09OVEVYVF9FVk9MVkUQAmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::POGOProtos.Enums.PokemonCreateContext), }, null));
    }
    #endregion

  }
  #region Enums
  public enum PokemonCreateContext {
    [pbr::OriginalName("CREATE_CONTEXT_WILD")] CreateContextWild = 0,
    [pbr::OriginalName("CREATE_CONTEXT_EGG")] CreateContextEgg = 1,
    [pbr::OriginalName("CREATE_CONTEXT_EVOLVE")] CreateContextEvolve = 2,
  }

  #endregion

}

#endregion Designer generated code