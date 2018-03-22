// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Settings/NewsGlobalSettings.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Settings {

  /// <summary>Holder for reflection information generated from POGOProtos/Settings/NewsGlobalSettings.proto</summary>
  public static partial class NewsGlobalSettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Settings/NewsGlobalSettings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NewsGlobalSettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CixQT0dPUHJvdG9zL1NldHRpbmdzL05ld3NHbG9iYWxTZXR0aW5ncy5wcm90",
            "bxITUE9HT1Byb3Rvcy5TZXR0aW5ncyIpChJOZXdzR2xvYmFsU2V0dGluZ3MS",
            "EwoLZW5hYmxlX25ld3MYASABKAhiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Settings.NewsGlobalSettings), global::POGOProtos.Settings.NewsGlobalSettings.Parser, new[]{ "EnableNews" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class NewsGlobalSettings : pb::IMessage<NewsGlobalSettings> {
    private static readonly pb::MessageParser<NewsGlobalSettings> _parser = new pb::MessageParser<NewsGlobalSettings>(() => new NewsGlobalSettings());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<NewsGlobalSettings> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Settings.NewsGlobalSettingsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NewsGlobalSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NewsGlobalSettings(NewsGlobalSettings other) : this() {
      enableNews_ = other.enableNews_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NewsGlobalSettings Clone() {
      return new NewsGlobalSettings(this);
    }

    /// <summary>Field number for the "enable_news" field.</summary>
    public const int EnableNewsFieldNumber = 1;
    private bool enableNews_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool EnableNews {
      get { return enableNews_; }
      set {
        enableNews_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as NewsGlobalSettings);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(NewsGlobalSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EnableNews != other.EnableNews) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (EnableNews != false) hash ^= EnableNews.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (EnableNews != false) {
        output.WriteRawTag(8);
        output.WriteBool(EnableNews);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (EnableNews != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(NewsGlobalSettings other) {
      if (other == null) {
        return;
      }
      if (other.EnableNews != false) {
        EnableNews = other.EnableNews;
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
          case 8: {
            EnableNews = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
