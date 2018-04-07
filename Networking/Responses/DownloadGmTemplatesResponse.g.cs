// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Responses/DownloadGmTemplatesResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/DownloadGmTemplatesResponse.proto</summary>
  public static partial class DownloadGmTemplatesResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Responses/DownloadGmTemplatesResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DownloadGmTemplatesResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkFQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0Rvd25sb2FkR21U",
            "ZW1wbGF0ZXNSZXNwb25zZS5wcm90bxIfUE9HT1Byb3Rvcy5OZXR3b3JraW5n",
            "LlJlc3BvbnNlcyLDAwobRG93bmxvYWRHbVRlbXBsYXRlc1Jlc3BvbnNlElMK",
            "BnJlc3VsdBgBIAEoDjJDLlBPR09Qcm90b3MuTmV0d29ya2luZy5SZXNwb25z",
            "ZXMuRG93bmxvYWRHbVRlbXBsYXRlc1Jlc3BvbnNlLlJlc3VsdBJnCgh0ZW1w",
            "bGF0ZRgCIAMoCzJVLlBPR09Qcm90b3MuTmV0d29ya2luZy5SZXNwb25zZXMu",
            "RG93bmxvYWRHbVRlbXBsYXRlc1Jlc3BvbnNlLkNsaWVudEdhbWVNYXN0ZXJU",
            "ZW1wbGF0ZRIYChBkZWxldGVkX3RlbXBsYXRlGAMgAygJEhAKCGJhdGNoX2lk",
            "GAQgASgGEhMKC3BhZ2Vfb2Zmc2V0GAUgASgFGj0KGENsaWVudEdhbWVNYXN0",
            "ZXJUZW1wbGF0ZRITCgt0ZW1wbGF0ZV9pZBgBIAEoCRIMCgRkYXRhGAIgASgM",
            "ImYKBlJlc3VsdBIJCgVVTlNFVBAAEgwKCENPTVBMRVRFEAESEAoMTU9SRV9S",
            "RVNVTFRTEAISFQoRQkFUQ0hfSURfTk9UX0xJVkUQAxIaChZJTlZBTElEX0JB",
            "U0lTX0JBVENIX0lEEARiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.DownloadGmTemplatesResponse), global::POGOProtos.Networking.Responses.DownloadGmTemplatesResponse.Parser, new[]{ "Result", "Template", "DeletedTemplate", "BatchId", "PageOffset" }, null, new[]{ typeof(global::POGOProtos.Networking.Responses.DownloadGmTemplatesResponse.Types.Result) }, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.DownloadGmTemplatesResponse.Types.ClientGameMasterTemplate), global::POGOProtos.Networking.Responses.DownloadGmTemplatesResponse.Types.ClientGameMasterTemplate.Parser, new[]{ "TemplateId", "Data" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DownloadGmTemplatesResponse : pb::IMessage<DownloadGmTemplatesResponse> {
    private static readonly pb::MessageParser<DownloadGmTemplatesResponse> _parser = new pb::MessageParser<DownloadGmTemplatesResponse>(() => new DownloadGmTemplatesResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DownloadGmTemplatesResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.DownloadGmTemplatesResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DownloadGmTemplatesResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DownloadGmTemplatesResponse(DownloadGmTemplatesResponse other) : this() {
      result_ = other.result_;
      template_ = other.template_.Clone();
      deletedTemplate_ = other.deletedTemplate_.Clone();
      batchId_ = other.batchId_;
      pageOffset_ = other.pageOffset_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DownloadGmTemplatesResponse Clone() {
      return new DownloadGmTemplatesResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::POGOProtos.Networking.Responses.DownloadGmTemplatesResponse.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Responses.DownloadGmTemplatesResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "template" field.</summary>
    public const int TemplateFieldNumber = 2;
    private static readonly pb::FieldCodec<global::POGOProtos.Networking.Responses.DownloadGmTemplatesResponse.Types.ClientGameMasterTemplate> _repeated_template_codec
        = pb::FieldCodec.ForMessage(18, global::POGOProtos.Networking.Responses.DownloadGmTemplatesResponse.Types.ClientGameMasterTemplate.Parser);
    private readonly pbc::RepeatedField<global::POGOProtos.Networking.Responses.DownloadGmTemplatesResponse.Types.ClientGameMasterTemplate> template_ = new pbc::RepeatedField<global::POGOProtos.Networking.Responses.DownloadGmTemplatesResponse.Types.ClientGameMasterTemplate>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Networking.Responses.DownloadGmTemplatesResponse.Types.ClientGameMasterTemplate> Template {
      get { return template_; }
    }

    /// <summary>Field number for the "deleted_template" field.</summary>
    public const int DeletedTemplateFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_deletedTemplate_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> deletedTemplate_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> DeletedTemplate {
      get { return deletedTemplate_; }
    }

    /// <summary>Field number for the "batch_id" field.</summary>
    public const int BatchIdFieldNumber = 4;
    private ulong batchId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong BatchId {
      get { return batchId_; }
      set {
        batchId_ = value;
      }
    }

    /// <summary>Field number for the "page_offset" field.</summary>
    public const int PageOffsetFieldNumber = 5;
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
      return Equals(other as DownloadGmTemplatesResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DownloadGmTemplatesResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if(!template_.Equals(other.template_)) return false;
      if(!deletedTemplate_.Equals(other.deletedTemplate_)) return false;
      if (BatchId != other.BatchId) return false;
      if (PageOffset != other.PageOffset) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      hash ^= template_.GetHashCode();
      hash ^= deletedTemplate_.GetHashCode();
      if (BatchId != 0UL) hash ^= BatchId.GetHashCode();
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
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
      template_.WriteTo(output, _repeated_template_codec);
      deletedTemplate_.WriteTo(output, _repeated_deletedTemplate_codec);
      if (BatchId != 0UL) {
        output.WriteRawTag(33);
        output.WriteFixed64(BatchId);
      }
      if (PageOffset != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(PageOffset);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      size += template_.CalculateSize(_repeated_template_codec);
      size += deletedTemplate_.CalculateSize(_repeated_deletedTemplate_codec);
      if (BatchId != 0UL) {
        size += 1 + 8;
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
    public void MergeFrom(DownloadGmTemplatesResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      template_.Add(other.template_);
      deletedTemplate_.Add(other.deletedTemplate_);
      if (other.BatchId != 0UL) {
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
            result_ = (global::POGOProtos.Networking.Responses.DownloadGmTemplatesResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 18: {
            template_.AddEntriesFrom(input, _repeated_template_codec);
            break;
          }
          case 26: {
            deletedTemplate_.AddEntriesFrom(input, _repeated_deletedTemplate_codec);
            break;
          }
          case 33: {
            BatchId = input.ReadFixed64();
            break;
          }
          case 40: {
            PageOffset = input.ReadInt32();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the DownloadGmTemplatesResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("COMPLETE")] Complete = 1,
        [pbr::OriginalName("MORE_RESULTS")] MoreResults = 2,
        [pbr::OriginalName("BATCH_ID_NOT_LIVE")] BatchIdNotLive = 3,
        [pbr::OriginalName("INVALID_BASIS_BATCH_ID")] InvalidBasisBatchId = 4,
      }

      public sealed partial class ClientGameMasterTemplate : pb::IMessage<ClientGameMasterTemplate> {
        private static readonly pb::MessageParser<ClientGameMasterTemplate> _parser = new pb::MessageParser<ClientGameMasterTemplate>(() => new ClientGameMasterTemplate());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<ClientGameMasterTemplate> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::POGOProtos.Networking.Responses.DownloadGmTemplatesResponse.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ClientGameMasterTemplate() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ClientGameMasterTemplate(ClientGameMasterTemplate other) : this() {
          templateId_ = other.templateId_;
          data_ = other.data_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ClientGameMasterTemplate Clone() {
          return new ClientGameMasterTemplate(this);
        }

        /// <summary>Field number for the "template_id" field.</summary>
        public const int TemplateIdFieldNumber = 1;
        private string templateId_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string TemplateId {
          get { return templateId_; }
          set {
            templateId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "data" field.</summary>
        public const int DataFieldNumber = 2;
        private pb::ByteString data_ = pb::ByteString.Empty;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pb::ByteString Data {
          get { return data_; }
          set {
            data_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as ClientGameMasterTemplate);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(ClientGameMasterTemplate other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (TemplateId != other.TemplateId) return false;
          if (Data != other.Data) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (TemplateId.Length != 0) hash ^= TemplateId.GetHashCode();
          if (Data.Length != 0) hash ^= Data.GetHashCode();
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
          if (TemplateId.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(TemplateId);
          }
          if (Data.Length != 0) {
            output.WriteRawTag(18);
            output.WriteBytes(Data);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (TemplateId.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(TemplateId);
          }
          if (Data.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeBytesSize(Data);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(ClientGameMasterTemplate other) {
          if (other == null) {
            return;
          }
          if (other.TemplateId.Length != 0) {
            TemplateId = other.TemplateId;
          }
          if (other.Data.Length != 0) {
            Data = other.Data;
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
                TemplateId = input.ReadString();
                break;
              }
              case 18: {
                Data = input.ReadBytes();
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
