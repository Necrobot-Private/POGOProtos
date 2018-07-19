// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Responses/GetInventoryResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/GetInventoryResponse.proto</summary>
  public static partial class GetInventoryResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Responses/GetInventoryResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetInventoryResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjpQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0dldEludmVudG9y",
            "eVJlc3BvbnNlLnByb3RvEh9QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9u",
            "c2VzGilQT0dPUHJvdG9zL0ludmVudG9yeS9JbnZlbnRvcnlEZWx0YS5wcm90",
            "byJmChRHZXRJbnZlbnRvcnlSZXNwb25zZRIPCgdzdWNjZXNzGAEgASgIEj0K",
            "D2ludmVudG9yeV9kZWx0YRgCIAEoCzIkLlBPR09Qcm90b3MuSW52ZW50b3J5",
            "LkludmVudG9yeURlbHRhYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Inventory.InventoryDeltaReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.GetInventoryResponse), global::POGOProtos.Networking.Responses.GetInventoryResponse.Parser, new[]{ "Success", "InventoryDelta" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetInventoryResponse : pb::IMessage<GetInventoryResponse> {
    private static readonly pb::MessageParser<GetInventoryResponse> _parser = new pb::MessageParser<GetInventoryResponse>(() => new GetInventoryResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetInventoryResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.GetInventoryResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetInventoryResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetInventoryResponse(GetInventoryResponse other) : this() {
      success_ = other.success_;
      inventoryDelta_ = other.inventoryDelta_ != null ? other.inventoryDelta_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetInventoryResponse Clone() {
      return new GetInventoryResponse(this);
    }

    /// <summary>Field number for the "success" field.</summary>
    public const int SuccessFieldNumber = 1;
    private bool success_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Success {
      get { return success_; }
      set {
        success_ = value;
      }
    }

    /// <summary>Field number for the "inventory_delta" field.</summary>
    public const int InventoryDeltaFieldNumber = 2;
    private global::POGOProtos.Inventory.InventoryDelta inventoryDelta_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Inventory.InventoryDelta InventoryDelta {
      get { return inventoryDelta_; }
      set {
        inventoryDelta_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetInventoryResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetInventoryResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Success != other.Success) return false;
      if (!object.Equals(InventoryDelta, other.InventoryDelta)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Success != false) hash ^= Success.GetHashCode();
      if (inventoryDelta_ != null) hash ^= InventoryDelta.GetHashCode();
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
      if (Success != false) {
        output.WriteRawTag(8);
        output.WriteBool(Success);
      }
      if (inventoryDelta_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(InventoryDelta);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Success != false) {
        size += 1 + 1;
      }
      if (inventoryDelta_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(InventoryDelta);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetInventoryResponse other) {
      if (other == null) {
        return;
      }
      if (other.Success != false) {
        Success = other.Success;
      }
      if (other.inventoryDelta_ != null) {
        if (inventoryDelta_ == null) {
          inventoryDelta_ = new global::POGOProtos.Inventory.InventoryDelta();
        }
        InventoryDelta.MergeFrom(other.InventoryDelta);
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
            Success = input.ReadBool();
            break;
          }
          case 18: {
            if (inventoryDelta_ == null) {
              inventoryDelta_ = new global::POGOProtos.Inventory.InventoryDelta();
            }
            input.ReadMessage(inventoryDelta_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
