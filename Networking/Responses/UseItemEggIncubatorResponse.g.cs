// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Responses/UseItemEggIncubatorResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/UseItemEggIncubatorResponse.proto</summary>
  public static partial class UseItemEggIncubatorResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Responses/UseItemEggIncubatorResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UseItemEggIncubatorResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkFQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL1VzZUl0ZW1FZ2dJ",
            "bmN1YmF0b3JSZXNwb25zZS5wcm90bxIfUE9HT1Byb3Rvcy5OZXR3b3JraW5n",
            "LlJlc3BvbnNlcxonUE9HT1Byb3Rvcy9JbnZlbnRvcnkvRWdnSW5jdWJhdG9y",
            "LnByb3RvIp8DChtVc2VJdGVtRWdnSW5jdWJhdG9yUmVzcG9uc2USUwoGcmVz",
            "dWx0GAEgASgOMkMuUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJlc3BvbnNlcy5V",
            "c2VJdGVtRWdnSW5jdWJhdG9yUmVzcG9uc2UuUmVzdWx0EjkKDWVnZ19pbmN1",
            "YmF0b3IYAiABKAsyIi5QT0dPUHJvdG9zLkludmVudG9yeS5FZ2dJbmN1YmF0",
            "b3Ii7wEKBlJlc3VsdBIJCgVVTlNFVBAAEgsKB1NVQ0NFU1MQARIdChlFUlJP",
            "Ul9JTkNVQkFUT1JfTk9UX0ZPVU5EEAISHwobRVJST1JfUE9LRU1PTl9FR0df",
            "Tk9UX0ZPVU5EEAMSHAoYRVJST1JfUE9LRU1PTl9JRF9OT1RfRUdHEAQSIgoe",
            "RVJST1JfSU5DVUJBVE9SX0FMUkVBRFlfSU5fVVNFEAUSJAogRVJST1JfUE9L",
            "RU1PTl9BTFJFQURZX0lOQ1VCQVRJTkcQBhIlCiFFUlJPUl9JTkNVQkFUT1Jf",
            "Tk9fVVNFU19SRU1BSU5JTkcQB2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Inventory.EggIncubatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.UseItemEggIncubatorResponse), global::POGOProtos.Networking.Responses.UseItemEggIncubatorResponse.Parser, new[]{ "Result", "EggIncubator" }, null, new[]{ typeof(global::POGOProtos.Networking.Responses.UseItemEggIncubatorResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class UseItemEggIncubatorResponse : pb::IMessage<UseItemEggIncubatorResponse> {
    private static readonly pb::MessageParser<UseItemEggIncubatorResponse> _parser = new pb::MessageParser<UseItemEggIncubatorResponse>(() => new UseItemEggIncubatorResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UseItemEggIncubatorResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.UseItemEggIncubatorResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UseItemEggIncubatorResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UseItemEggIncubatorResponse(UseItemEggIncubatorResponse other) : this() {
      result_ = other.result_;
      eggIncubator_ = other.eggIncubator_ != null ? other.eggIncubator_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UseItemEggIncubatorResponse Clone() {
      return new UseItemEggIncubatorResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::POGOProtos.Networking.Responses.UseItemEggIncubatorResponse.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Responses.UseItemEggIncubatorResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "egg_incubator" field.</summary>
    public const int EggIncubatorFieldNumber = 2;
    private global::POGOProtos.Inventory.EggIncubator eggIncubator_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Inventory.EggIncubator EggIncubator {
      get { return eggIncubator_; }
      set {
        eggIncubator_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UseItemEggIncubatorResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UseItemEggIncubatorResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (!object.Equals(EggIncubator, other.EggIncubator)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (eggIncubator_ != null) hash ^= EggIncubator.GetHashCode();
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
      if (eggIncubator_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(EggIncubator);
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
      if (eggIncubator_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EggIncubator);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UseItemEggIncubatorResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.eggIncubator_ != null) {
        if (eggIncubator_ == null) {
          eggIncubator_ = new global::POGOProtos.Inventory.EggIncubator();
        }
        EggIncubator.MergeFrom(other.EggIncubator);
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
            result_ = (global::POGOProtos.Networking.Responses.UseItemEggIncubatorResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 18: {
            if (eggIncubator_ == null) {
              eggIncubator_ = new global::POGOProtos.Inventory.EggIncubator();
            }
            input.ReadMessage(eggIncubator_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the UseItemEggIncubatorResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("ERROR_INCUBATOR_NOT_FOUND")] ErrorIncubatorNotFound = 2,
        [pbr::OriginalName("ERROR_POKEMON_EGG_NOT_FOUND")] ErrorPokemonEggNotFound = 3,
        [pbr::OriginalName("ERROR_POKEMON_ID_NOT_EGG")] ErrorPokemonIdNotEgg = 4,
        [pbr::OriginalName("ERROR_INCUBATOR_ALREADY_IN_USE")] ErrorIncubatorAlreadyInUse = 5,
        [pbr::OriginalName("ERROR_POKEMON_ALREADY_INCUBATING")] ErrorPokemonAlreadyIncubating = 6,
        [pbr::OriginalName("ERROR_INCUBATOR_NO_USES_REMAINING")] ErrorIncubatorNoUsesRemaining = 7,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
