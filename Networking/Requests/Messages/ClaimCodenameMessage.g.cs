// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Requests/Messages/ClaimCodenameMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/ClaimCodenameMessage.proto</summary>
  public static partial class ClaimCodenameMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/ClaimCodenameMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClaimCodenameMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkJQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvQ2xh",
            "aW1Db2RlbmFtZU1lc3NhZ2UucHJvdG8SJ1BPR09Qcm90b3MuTmV0d29ya2lu",
            "Zy5SZXF1ZXN0cy5NZXNzYWdlcyJdChRDbGFpbUNvZGVuYW1lTWVzc2FnZRIQ",
            "Cghjb2RlbmFtZRgBIAEoCRINCgVmb3JjZRgCIAEoCBIkChxnZW5lcmF0ZV9z",
            "dWdnZXN0ZWRfY29kZW5hbWVzGAMgASgIYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Requests.Messages.ClaimCodenameMessage), global::POGOProtos.Networking.Requests.Messages.ClaimCodenameMessage.Parser, new[]{ "Codename", "Force", "GenerateSuggestedCodenames" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClaimCodenameMessage : pb::IMessage<ClaimCodenameMessage> {
    private static readonly pb::MessageParser<ClaimCodenameMessage> _parser = new pb::MessageParser<ClaimCodenameMessage>(() => new ClaimCodenameMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClaimCodenameMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Requests.Messages.ClaimCodenameMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClaimCodenameMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClaimCodenameMessage(ClaimCodenameMessage other) : this() {
      codename_ = other.codename_;
      force_ = other.force_;
      generateSuggestedCodenames_ = other.generateSuggestedCodenames_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClaimCodenameMessage Clone() {
      return new ClaimCodenameMessage(this);
    }

    /// <summary>Field number for the "codename" field.</summary>
    public const int CodenameFieldNumber = 1;
    private string codename_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Codename {
      get { return codename_; }
      set {
        codename_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "force" field.</summary>
    public const int ForceFieldNumber = 2;
    private bool force_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Force {
      get { return force_; }
      set {
        force_ = value;
      }
    }

    /// <summary>Field number for the "generate_suggested_codenames" field.</summary>
    public const int GenerateSuggestedCodenamesFieldNumber = 3;
    private bool generateSuggestedCodenames_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool GenerateSuggestedCodenames {
      get { return generateSuggestedCodenames_; }
      set {
        generateSuggestedCodenames_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClaimCodenameMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClaimCodenameMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Codename != other.Codename) return false;
      if (Force != other.Force) return false;
      if (GenerateSuggestedCodenames != other.GenerateSuggestedCodenames) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Codename.Length != 0) hash ^= Codename.GetHashCode();
      if (Force != false) hash ^= Force.GetHashCode();
      if (GenerateSuggestedCodenames != false) hash ^= GenerateSuggestedCodenames.GetHashCode();
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
      if (Codename.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Codename);
      }
      if (Force != false) {
        output.WriteRawTag(16);
        output.WriteBool(Force);
      }
      if (GenerateSuggestedCodenames != false) {
        output.WriteRawTag(24);
        output.WriteBool(GenerateSuggestedCodenames);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Codename.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Codename);
      }
      if (Force != false) {
        size += 1 + 1;
      }
      if (GenerateSuggestedCodenames != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClaimCodenameMessage other) {
      if (other == null) {
        return;
      }
      if (other.Codename.Length != 0) {
        Codename = other.Codename;
      }
      if (other.Force != false) {
        Force = other.Force;
      }
      if (other.GenerateSuggestedCodenames != false) {
        GenerateSuggestedCodenames = other.GenerateSuggestedCodenames;
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
          case 10: {
            Codename = input.ReadString();
            break;
          }
          case 16: {
            Force = input.ReadBool();
            break;
          }
          case 24: {
            GenerateSuggestedCodenames = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
