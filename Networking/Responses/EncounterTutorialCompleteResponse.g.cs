// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Responses/EncounterTutorialCompleteResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/EncounterTutorialCompleteResponse.proto</summary>
  public static partial class EncounterTutorialCompleteResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Responses/EncounterTutorialCompleteResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EncounterTutorialCompleteResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkdQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0VuY291bnRlclR1",
            "dG9yaWFsQ29tcGxldGVSZXNwb25zZS5wcm90bxIfUE9HT1Byb3Rvcy5OZXR3",
            "b3JraW5nLlJlc3BvbnNlcxohUE9HT1Byb3Rvcy9EYXRhL1Bva2Vtb25EYXRh",
            "LnByb3RvGipQT0dPUHJvdG9zL0RhdGEvQ2FwdHVyZS9DYXB0dXJlQXdhcmQu",
            "cHJvdG8irQIKIUVuY291bnRlclR1dG9yaWFsQ29tcGxldGVSZXNwb25zZRJZ",
            "CgZyZXN1bHQYASABKA4ySS5QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9u",
            "c2VzLkVuY291bnRlclR1dG9yaWFsQ29tcGxldGVSZXNwb25zZS5SZXN1bHQS",
            "MgoMcG9rZW1vbl9kYXRhGAIgASgLMhwuUE9HT1Byb3Rvcy5EYXRhLlBva2Vt",
            "b25EYXRhEjwKDWNhcHR1cmVfYXdhcmQYAyABKAsyJS5QT0dPUHJvdG9zLkRh",
            "dGEuQ2FwdHVyZS5DYXB0dXJlQXdhcmQiOwoGUmVzdWx0EgkKBVVOU0VUEAAS",
            "CwoHU1VDQ0VTUxABEhkKFUVSUk9SX0lOVkFMSURfUE9LRU1PThACYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.PokemonDataReflection.Descriptor, global::POGOProtos.Data.Capture.CaptureAwardReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.EncounterTutorialCompleteResponse), global::POGOProtos.Networking.Responses.EncounterTutorialCompleteResponse.Parser, new[]{ "Result", "PokemonData", "CaptureAward" }, null, new[]{ typeof(global::POGOProtos.Networking.Responses.EncounterTutorialCompleteResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EncounterTutorialCompleteResponse : pb::IMessage<EncounterTutorialCompleteResponse> {
    private static readonly pb::MessageParser<EncounterTutorialCompleteResponse> _parser = new pb::MessageParser<EncounterTutorialCompleteResponse>(() => new EncounterTutorialCompleteResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EncounterTutorialCompleteResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.EncounterTutorialCompleteResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncounterTutorialCompleteResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncounterTutorialCompleteResponse(EncounterTutorialCompleteResponse other) : this() {
      result_ = other.result_;
      PokemonData = other.pokemonData_ != null ? other.PokemonData.Clone() : null;
      CaptureAward = other.captureAward_ != null ? other.CaptureAward.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncounterTutorialCompleteResponse Clone() {
      return new EncounterTutorialCompleteResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::POGOProtos.Networking.Responses.EncounterTutorialCompleteResponse.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Responses.EncounterTutorialCompleteResponse.Types.Result Result {
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

    /// <summary>Field number for the "capture_award" field.</summary>
    public const int CaptureAwardFieldNumber = 3;
    private global::POGOProtos.Data.Capture.CaptureAward captureAward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Capture.CaptureAward CaptureAward {
      get { return captureAward_; }
      set {
        captureAward_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EncounterTutorialCompleteResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EncounterTutorialCompleteResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (!object.Equals(PokemonData, other.PokemonData)) return false;
      if (!object.Equals(CaptureAward, other.CaptureAward)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (pokemonData_ != null) hash ^= PokemonData.GetHashCode();
      if (captureAward_ != null) hash ^= CaptureAward.GetHashCode();
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
      if (captureAward_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(CaptureAward);
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
      if (captureAward_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CaptureAward);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EncounterTutorialCompleteResponse other) {
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
      if (other.captureAward_ != null) {
        if (captureAward_ == null) {
          captureAward_ = new global::POGOProtos.Data.Capture.CaptureAward();
        }
        CaptureAward.MergeFrom(other.CaptureAward);
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
            result_ = (global::POGOProtos.Networking.Responses.EncounterTutorialCompleteResponse.Types.Result) input.ReadEnum();
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
            if (captureAward_ == null) {
              captureAward_ = new global::POGOProtos.Data.Capture.CaptureAward();
            }
            input.ReadMessage(captureAward_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the EncounterTutorialCompleteResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("ERROR_INVALID_POKEMON")] ErrorInvalidPokemon = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
