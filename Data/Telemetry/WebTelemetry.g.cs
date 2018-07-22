// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Data/Telemetry/WebTelemetry.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Telemetry {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Telemetry/WebTelemetry.proto</summary>
  public static partial class WebTelemetryReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Telemetry/WebTelemetry.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WebTelemetryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CixQT0dPUHJvdG9zL0RhdGEvVGVsZW1ldHJ5L1dlYlRlbGVtZXRyeS5wcm90",
            "bxIZUE9HT1Byb3Rvcy5EYXRhLlRlbGVtZXRyeRomUE9HT1Byb3Rvcy9FbnVt",
            "cy9XZWJUZWxlbWV0cnlJZHMucHJvdG8iVQoMV2ViVGVsZW1ldHJ5EjgKDXdl",
            "Yl9jbGlja19pZHMYASABKA4yIS5QT0dPUHJvdG9zLkVudW1zLldlYlRlbGVt",
            "ZXRyeUlkcxILCgN1cmwYAiABKAliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Enums.WebTelemetryIdsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Telemetry.WebTelemetry), global::POGOProtos.Data.Telemetry.WebTelemetry.Parser, new[]{ "WebClickIds", "Url" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class WebTelemetry : pb::IMessage<WebTelemetry> {
    private static readonly pb::MessageParser<WebTelemetry> _parser = new pb::MessageParser<WebTelemetry>(() => new WebTelemetry());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<WebTelemetry> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Telemetry.WebTelemetryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WebTelemetry() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WebTelemetry(WebTelemetry other) : this() {
      webClickIds_ = other.webClickIds_;
      url_ = other.url_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WebTelemetry Clone() {
      return new WebTelemetry(this);
    }

    /// <summary>Field number for the "web_click_ids" field.</summary>
    public const int WebClickIdsFieldNumber = 1;
    private global::POGOProtos.Enums.WebTelemetryIds webClickIds_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.WebTelemetryIds WebClickIds {
      get { return webClickIds_; }
      set {
        webClickIds_ = value;
      }
    }

    /// <summary>Field number for the "url" field.</summary>
    public const int UrlFieldNumber = 2;
    private string url_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Url {
      get { return url_; }
      set {
        url_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as WebTelemetry);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(WebTelemetry other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (WebClickIds != other.WebClickIds) return false;
      if (Url != other.Url) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (WebClickIds != 0) hash ^= WebClickIds.GetHashCode();
      if (Url.Length != 0) hash ^= Url.GetHashCode();
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
      if (WebClickIds != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) WebClickIds);
      }
      if (Url.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Url);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (WebClickIds != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) WebClickIds);
      }
      if (Url.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Url);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(WebTelemetry other) {
      if (other == null) {
        return;
      }
      if (other.WebClickIds != 0) {
        WebClickIds = other.WebClickIds;
      }
      if (other.Url.Length != 0) {
        Url = other.Url;
      }
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
          case 8: {
            webClickIds_ = (global::POGOProtos.Enums.WebTelemetryIds) input.ReadEnum();
            break;
          }
          case 18: {
            Url = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
