// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Enums/NotificationCategory.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Enums {

  /// <summary>Holder for reflection information generated from POGOProtos/Enums/NotificationCategory.proto</summary>
  public static partial class NotificationCategoryReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Enums/NotificationCategory.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NotificationCategoryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitQT0dPUHJvdG9zL0VudW1zL05vdGlmaWNhdGlvbkNhdGVnb3J5LnByb3Rv",
            "EhBQT0dPUHJvdG9zLkVudW1zKmwKFE5vdGlmaWNhdGlvbkNhdGVnb3J5Eh4K",
            "GlVOU0VUX05vdGlmaWNhdGlvbkNhdGVnb3J5EAASDwoLR1lNX1JFTU9WQUwQ",
            "ARISCg5QT0tFTU9OX0hVTkdSWRACEg8KC1BPS0VNT05fV09OEANiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::POGOProtos.Enums.NotificationCategory), }, null));
    }
    #endregion

  }
  #region Enums
  public enum NotificationCategory {
    [pbr::OriginalName("UNSET_NotificationCategory")] UnsetNotificationCategory = 0,
    [pbr::OriginalName("GYM_REMOVAL")] GymRemoval = 1,
    [pbr::OriginalName("POKEMON_HUNGRY")] PokemonHungry = 2,
    [pbr::OriginalName("POKEMON_WON")] PokemonWon = 3,
  }

  #endregion

}

#endregion Designer generated code
