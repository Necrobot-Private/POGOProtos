// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Platform/Requests/ClientTelemetryRequest.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Platform.Requests {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Platform/Requests/ClientTelemetryRequest.proto</summary>
  public static partial class ClientTelemetryRequestReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Platform/Requests/ClientTelemetryRequest.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientTelemetryRequestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkRQT0dPUHJvdG9zL05ldHdvcmtpbmcvUGxhdGZvcm0vUmVxdWVzdHMvQ2xp",
            "ZW50VGVsZW1ldHJ5UmVxdWVzdC5wcm90bxInUE9HT1Byb3Rvcy5OZXR3b3Jr",
            "aW5nLlBsYXRmb3JtLlJlcXVlc3RzGj1QT0dPUHJvdG9zL05ldHdvcmtpbmcv",
            "UGxhdGZvcm0vVGVsZW1ldHJ5L1BsYXRmb3JtRGF0YUlkLnByb3RvInYKD0Ns",
            "aWVudFRlbGVtZXRyeRJJCgdkYXRhX2lkGAEgAygLMjguUE9HT1Byb3Rvcy5O",
            "ZXR3b3JraW5nLlBsYXRmb3JtLlRlbGVtZXRyeS5QbGF0Zm9ybURhdGFJZBIY",
            "ChBhcHBsaWNhdGlvbl9kYXRhGAIgAygMYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Networking.Platform.Telemetry.PlatformDataIdReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Platform.Requests.ClientTelemetry), global::POGOProtos.Networking.Platform.Requests.ClientTelemetry.Parser, new[]{ "DataId", "ApplicationData" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientTelemetry : pb::IMessage<ClientTelemetry> {
    private static readonly pb::MessageParser<ClientTelemetry> _parser = new pb::MessageParser<ClientTelemetry>(() => new ClientTelemetry());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientTelemetry> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Platform.Requests.ClientTelemetryRequestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetry() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetry(ClientTelemetry other) : this() {
      dataId_ = other.dataId_.Clone();
      applicationData_ = other.applicationData_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetry Clone() {
      return new ClientTelemetry(this);
    }

    /// <summary>Field number for the "data_id" field.</summary>
    public const int DataIdFieldNumber = 1;
    private static readonly pb::FieldCodec<global::POGOProtos.Networking.Platform.Telemetry.PlatformDataId> _repeated_dataId_codec
        = pb::FieldCodec.ForMessage(10, global::POGOProtos.Networking.Platform.Telemetry.PlatformDataId.Parser);
    private readonly pbc::RepeatedField<global::POGOProtos.Networking.Platform.Telemetry.PlatformDataId> dataId_ = new pbc::RepeatedField<global::POGOProtos.Networking.Platform.Telemetry.PlatformDataId>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Networking.Platform.Telemetry.PlatformDataId> DataId {
      get { return dataId_; }
    }

    /// <summary>Field number for the "application_data" field.</summary>
    public const int ApplicationDataFieldNumber = 2;
    private static readonly pb::FieldCodec<pb::ByteString> _repeated_applicationData_codec
        = pb::FieldCodec.ForBytes(18);
    private readonly pbc::RepeatedField<pb::ByteString> applicationData_ = new pbc::RepeatedField<pb::ByteString>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<pb::ByteString> ApplicationData {
      get { return applicationData_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientTelemetry);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientTelemetry other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!dataId_.Equals(other.dataId_)) return false;
      if(!applicationData_.Equals(other.applicationData_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= dataId_.GetHashCode();
      hash ^= applicationData_.GetHashCode();
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
      dataId_.WriteTo(output, _repeated_dataId_codec);
      applicationData_.WriteTo(output, _repeated_applicationData_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += dataId_.CalculateSize(_repeated_dataId_codec);
      size += applicationData_.CalculateSize(_repeated_applicationData_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientTelemetry other) {
      if (other == null) {
        return;
      }
      dataId_.Add(other.dataId_);
      applicationData_.Add(other.applicationData_);
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
          case 10: {
            dataId_.AddEntriesFrom(input, _repeated_dataId_codec);
            break;
          }
          case 18: {
            applicationData_.AddEntriesFrom(input, _repeated_applicationData_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
