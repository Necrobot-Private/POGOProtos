// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Enums/NotificationState.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Enums {

  /// <summary>Holder for reflection information generated from POGOProtos/Enums/NotificationState.proto</summary>
  public static partial class NotificationStateReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Enums/NotificationState.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NotificationStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihQT0dPUHJvdG9zL0VudW1zL05vdGlmaWNhdGlvblN0YXRlLnByb3RvEhBQ",
            "T0dPUHJvdG9zLkVudW1zKjAKEU5vdGlmaWNhdGlvblN0YXRlEg8KC1VOU0VU",
            "X1NUQVRFEAASCgoGVklFV0VEEAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::POGOProtos.Enums.NotificationState), }, null));
    }
    #endregion

  }
  #region Enums
  public enum NotificationState {
    [pbr::OriginalName("UNSET_STATE")] UnsetState = 0,
    [pbr::OriginalName("VIEWED")] Viewed = 1,
  }

  #endregion

}

#endregion Designer generated code
