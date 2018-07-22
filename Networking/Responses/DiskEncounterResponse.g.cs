// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Responses/DiskEncounterResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/DiskEncounterResponse.proto</summary>
  public static partial class DiskEncounterResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Responses/DiskEncounterResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DiskEncounterResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjtQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0Rpc2tFbmNvdW50",
            "ZXJSZXNwb25zZS5wcm90bxIfUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJlc3Bv",
            "bnNlcxohUE9HT1Byb3Rvcy9EYXRhL1Bva2Vtb25EYXRhLnByb3RvGjBQT0dP",
            "UHJvdG9zL0RhdGEvQ2FwdHVyZS9DYXB0dXJlUHJvYmFiaWxpdHkucHJvdG8a",
            "JlBPR09Qcm90b3MvSW52ZW50b3J5L0l0ZW0vSXRlbUlkLnByb3RvIsYDChVE",
            "aXNrRW5jb3VudGVyUmVzcG9uc2USTQoGcmVzdWx0GAEgASgOMj0uUE9HT1By",
            "b3Rvcy5OZXR3b3JraW5nLlJlc3BvbnNlcy5EaXNrRW5jb3VudGVyUmVzcG9u",
            "c2UuUmVzdWx0EjIKDHBva2Vtb25fZGF0YRgCIAEoCzIcLlBPR09Qcm90b3Mu",
            "RGF0YS5Qb2tlbW9uRGF0YRJIChNjYXB0dXJlX3Byb2JhYmlsaXR5GAMgASgL",
            "MisuUE9HT1Byb3Rvcy5EYXRhLkNhcHR1cmUuQ2FwdHVyZVByb2JhYmlsaXR5",
            "EjYKC2FjdGl2ZV9pdGVtGAQgASgOMiEuUE9HT1Byb3Rvcy5JbnZlbnRvcnku",
            "SXRlbS5JdGVtSWQSIgoaYXJwbHVzX2F0dGVtcHRzX3VudGlsX2ZsZWUYBSAB",
            "KAUigwEKBlJlc3VsdBILCgdVTktOT1dOEAASCwoHU1VDQ0VTUxABEhEKDU5P",
            "VF9BVkFJTEFCTEUQAhIQCgxOT1RfSU5fUkFOR0UQAxIeChpFTkNPVU5URVJf",
            "QUxSRUFEWV9GSU5JU0hFRBAEEhoKFlBPS0VNT05fSU5WRU5UT1JZX0ZVTEwQ",
            "BWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.PokemonDataReflection.Descriptor, global::POGOProtos.Data.Capture.CaptureProbabilityReflection.Descriptor, global::POGOProtos.Inventory.Item.ItemIdReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.DiskEncounterResponse), global::POGOProtos.Networking.Responses.DiskEncounterResponse.Parser, new[]{ "Result", "PokemonData", "CaptureProbability", "ActiveItem", "ArplusAttemptsUntilFlee" }, null, new[]{ typeof(global::POGOProtos.Networking.Responses.DiskEncounterResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DiskEncounterResponse : pb::IMessage<DiskEncounterResponse> {
    private static readonly pb::MessageParser<DiskEncounterResponse> _parser = new pb::MessageParser<DiskEncounterResponse>(() => new DiskEncounterResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DiskEncounterResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.DiskEncounterResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DiskEncounterResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DiskEncounterResponse(DiskEncounterResponse other) : this() {
      result_ = other.result_;
      pokemonData_ = other.pokemonData_ != null ? other.pokemonData_.Clone() : null;
      captureProbability_ = other.captureProbability_ != null ? other.captureProbability_.Clone() : null;
      activeItem_ = other.activeItem_;
      arplusAttemptsUntilFlee_ = other.arplusAttemptsUntilFlee_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DiskEncounterResponse Clone() {
      return new DiskEncounterResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::POGOProtos.Networking.Responses.DiskEncounterResponse.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Responses.DiskEncounterResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "pokemon_data" field.</summary>
    public const int PokemonDataFieldNumber = 2;
    private global::POGOProtos.Data.PokemonData pokemonData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.PokemonData PokemonData {
      get { return pokemonData_; }
      set {
        pokemonData_ = value;
      }
    }

    /// <summary>Field number for the "capture_probability" field.</summary>
    public const int CaptureProbabilityFieldNumber = 3;
    private global::POGOProtos.Data.Capture.CaptureProbability captureProbability_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Capture.CaptureProbability CaptureProbability {
      get { return captureProbability_; }
      set {
        captureProbability_ = value;
      }
    }

    /// <summary>Field number for the "active_item" field.</summary>
    public const int ActiveItemFieldNumber = 4;
    private global::POGOProtos.Inventory.Item.ItemId activeItem_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Inventory.Item.ItemId ActiveItem {
      get { return activeItem_; }
      set {
        activeItem_ = value;
      }
    }

    /// <summary>Field number for the "arplus_attempts_until_flee" field.</summary>
    public const int ArplusAttemptsUntilFleeFieldNumber = 5;
    private int arplusAttemptsUntilFlee_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ArplusAttemptsUntilFlee {
      get { return arplusAttemptsUntilFlee_; }
      set {
        arplusAttemptsUntilFlee_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DiskEncounterResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DiskEncounterResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (!object.Equals(PokemonData, other.PokemonData)) return false;
      if (!object.Equals(CaptureProbability, other.CaptureProbability)) return false;
      if (ActiveItem != other.ActiveItem) return false;
      if (ArplusAttemptsUntilFlee != other.ArplusAttemptsUntilFlee) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (pokemonData_ != null) hash ^= PokemonData.GetHashCode();
      if (captureProbability_ != null) hash ^= CaptureProbability.GetHashCode();
      if (ActiveItem != 0) hash ^= ActiveItem.GetHashCode();
      if (ArplusAttemptsUntilFlee != 0) hash ^= ArplusAttemptsUntilFlee.GetHashCode();
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
      if (pokemonData_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(PokemonData);
      }
      if (captureProbability_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(CaptureProbability);
      }
      if (ActiveItem != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) ActiveItem);
      }
      if (ArplusAttemptsUntilFlee != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(ArplusAttemptsUntilFlee);
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
      if (pokemonData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PokemonData);
      }
      if (captureProbability_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CaptureProbability);
      }
      if (ActiveItem != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ActiveItem);
      }
      if (ArplusAttemptsUntilFlee != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ArplusAttemptsUntilFlee);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DiskEncounterResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.pokemonData_ != null) {
        if (pokemonData_ == null) {
          pokemonData_ = new global::POGOProtos.Data.PokemonData();
        }
        PokemonData.MergeFrom(other.PokemonData);
      }
      if (other.captureProbability_ != null) {
        if (captureProbability_ == null) {
          captureProbability_ = new global::POGOProtos.Data.Capture.CaptureProbability();
        }
        CaptureProbability.MergeFrom(other.CaptureProbability);
      }
      if (other.ActiveItem != 0) {
        ActiveItem = other.ActiveItem;
      }
      if (other.ArplusAttemptsUntilFlee != 0) {
        ArplusAttemptsUntilFlee = other.ArplusAttemptsUntilFlee;
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
            result_ = (global::POGOProtos.Networking.Responses.DiskEncounterResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 18: {
            if (pokemonData_ == null) {
              pokemonData_ = new global::POGOProtos.Data.PokemonData();
            }
            input.ReadMessage(pokemonData_);
            break;
          }
          case 26: {
            if (captureProbability_ == null) {
              captureProbability_ = new global::POGOProtos.Data.Capture.CaptureProbability();
            }
            input.ReadMessage(captureProbability_);
            break;
          }
          case 32: {
            activeItem_ = (global::POGOProtos.Inventory.Item.ItemId) input.ReadEnum();
            break;
          }
          case 40: {
            ArplusAttemptsUntilFlee = input.ReadInt32();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the DiskEncounterResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNKNOWN")] Unknown = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("NOT_AVAILABLE")] NotAvailable = 2,
        [pbr::OriginalName("NOT_IN_RANGE")] NotInRange = 3,
        [pbr::OriginalName("ENCOUNTER_ALREADY_FINISHED")] EncounterAlreadyFinished = 4,
        [pbr::OriginalName("POKEMON_INVENTORY_FULL")] PokemonInventoryFull = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
