// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Enums/PushNotificationTelemetryIds.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Enums {

  /// <summary>Holder for reflection information generated from POGOProtos/Enums/PushNotificationTelemetryIds.proto</summary>
  public static partial class PushNotificationTelemetryIdsReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Enums/PushNotificationTelemetryIds.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PushNotificationTelemetryIdsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNQT0dPUHJvdG9zL0VudW1zL1B1c2hOb3RpZmljYXRpb25UZWxlbWV0cnlJ",
            "ZHMucHJvdG8SEFBPR09Qcm90b3MuRW51bXMqUwocUHVzaE5vdGlmaWNhdGlv",
            "blRlbGVtZXRyeUlkcxIlCiFVTkRFRklORURfUFVTSF9OT1RJRklDQVRJT05f",
            "RVZFTlQQABIMCghPUEVOX0FQUBABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::POGOProtos.Enums.PushNotificationTelemetryIds), }, null));
    }
    #endregion

  }
  #region Enums
  public enum PushNotificationTelemetryIds {
    [pbr::OriginalName("UNDEFINED_PUSH_NOTIFICATION_EVENT")] UndefinedPushNotificationEvent = 0,
    [pbr::OriginalName("OPEN_APP")] OpenApp = 1,
  }

  #endregion

}

#endregion Designer generated code
