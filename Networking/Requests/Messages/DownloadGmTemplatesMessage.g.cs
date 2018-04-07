// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Requests/Messages/DownloadGmTemplatesMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/DownloadGmTemplatesMessage.proto</summary>
  public static partial class DownloadGmTemplatesMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/DownloadGmTemplatesMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DownloadGmTemplatesMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkhQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvRG93",
            "bmxvYWRHbVRlbXBsYXRlc01lc3NhZ2UucHJvdG8SJ1BPR09Qcm90b3MuTmV0",
            "d29ya2luZy5SZXF1ZXN0cy5NZXNzYWdlcyJbChpEb3dubG9hZEdtVGVtcGxh",
            "dGVzTWVzc2FnZRIWCg5iYXNpc19iYXRjaF9pZBgBIAEoAxIQCghiYXRjaF9p",
            "ZBgCIAEoAxITCgtwYWdlX29mZnNldBgDIAEoBWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Requests.Messages.DownloadGmTemplatesMessage), global::POGOProtos.Networking.Requests.Messages.DownloadGmTemplatesMessage.Parser, new[]{ "BasisBatchId", "BatchId", "PageOffset" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DownloadGmTemplatesMessage : pb::IMessage<DownloadGmTemplatesMessage> {
    private static readonly pb::MessageParser<DownloadGmTemplatesMessage> _parser = new pb::MessageParser<DownloadGmTemplatesMessage>(() => new DownloadGmTemplatesMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DownloadGmTemplatesMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Requests.Messages.DownloadGmTemplatesMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DownloadGmTemplatesMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DownloadGmTemplatesMessage(DownloadGmTemplatesMessage other) : this() {
      basisBatchId_ = other.basisBatchId_;
      batchId_ = other.batchId_;
      pageOffset_ = other.pageOffset_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DownloadGmTemplatesMessage Clone() {
      return new DownloadGmTemplatesMessage(this);
    }

    /// <summary>Field number for the "basis_batch_id" field.</summary>
    public const int BasisBatchIdFieldNumber = 1;
    private long basisBatchId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long BasisBatchId {
      get { return basisBatchId_; }
      set {
        basisBatchId_ = value;
      }
    }

    /// <summary>Field number for the "batch_id" field.</summary>
    public const int BatchIdFieldNumber = 2;
    private long batchId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long BatchId {
      get { return batchId_; }
      set {
        batchId_ = value;
      }
    }

    /// <summary>Field number for the "page_offset" field.</summary>
    public const int PageOffsetFieldNumber = 3;
    private int pageOffset_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PageOffset {
      get { return pageOffset_; }
      set {
        pageOffset_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DownloadGmTemplatesMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DownloadGmTemplatesMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BasisBatchId != other.BasisBatchId) return false;
      if (BatchId != other.BatchId) return false;
      if (PageOffset != other.PageOffset) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (BasisBatchId != 0L) hash ^= BasisBatchId.GetHashCode();
      if (BatchId != 0L) hash ^= BatchId.GetHashCode();
      if (PageOffset != 0) hash ^= PageOffset.GetHashCode();
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
      if (BasisBatchId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(BasisBatchId);
      }
      if (BatchId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(BatchId);
      }
      if (PageOffset != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(PageOffset);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (BasisBatchId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(BasisBatchId);
      }
      if (BatchId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(BatchId);
      }
      if (PageOffset != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PageOffset);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DownloadGmTemplatesMessage other) {
      if (other == null) {
        return;
      }
      if (other.BasisBatchId != 0L) {
        BasisBatchId = other.BasisBatchId;
      }
      if (other.BatchId != 0L) {
        BatchId = other.BatchId;
      }
      if (other.PageOffset != 0) {
        PageOffset = other.PageOffset;
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
            BasisBatchId = input.ReadInt64();
            break;
          }
          case 16: {
            BatchId = input.ReadInt64();
            break;
          }
          case 24: {
            PageOffset = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
