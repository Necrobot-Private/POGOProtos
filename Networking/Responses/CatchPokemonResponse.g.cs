// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Responses/CatchPokemonResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/CatchPokemonResponse.proto</summary>
  public static partial class CatchPokemonResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Responses/CatchPokemonResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CatchPokemonResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjpQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0NhdGNoUG9rZW1v",
            "blJlc3BvbnNlLnByb3RvEh9QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9u",
            "c2VzGipQT0dPUHJvdG9zL0RhdGEvQ2FwdHVyZS9DYXB0dXJlQXdhcmQucHJv",
            "dG8aJFBPR09Qcm90b3MvRGF0YS9Qb2tlbW9uRGlzcGxheS5wcm90byLgBAoU",
            "Q2F0Y2hQb2tlbW9uUmVzcG9uc2USUQoGc3RhdHVzGAEgASgOMkEuUE9HT1By",
            "b3Rvcy5OZXR3b3JraW5nLlJlc3BvbnNlcy5DYXRjaFBva2Vtb25SZXNwb25z",
            "ZS5DYXRjaFN0YXR1cxIUCgxtaXNzX3BlcmNlbnQYAiABKAESGwoTY2FwdHVy",
            "ZWRfcG9rZW1vbl9pZBgDIAEoBhI8Cg1jYXB0dXJlX2F3YXJkGAQgASgLMiUu",
            "UE9HT1Byb3Rvcy5EYXRhLkNhcHR1cmUuQ2FwdHVyZUF3YXJkElsKDmNhcHR1",
            "cmVfcmVhc29uGAUgASgOMkMuUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJlc3Bv",
            "bnNlcy5DYXRjaFBva2Vtb25SZXNwb25zZS5DYXB0dXJlUmVhc29uEhoKEmRp",
            "c3BsYXlfcG9rZWRleF9pZBgGIAEoBRIYChB0aHJvd3NfcmVtYWluaW5nGAcg",
            "ASgFEjgKD3Bva2Vtb25fZGlzcGxheRgIIAEoCzIfLlBPR09Qcm90b3MuRGF0",
            "YS5Qb2tlbW9uRGlzcGxheSJlCgtDYXRjaFN0YXR1cxIPCgtDQVRDSF9FUlJP",
            "UhAAEhEKDUNBVENIX1NVQ0NFU1MQARIQCgxDQVRDSF9FU0NBUEUQAhIOCgpD",
            "QVRDSF9GTEVFEAMSEAoMQ0FUQ0hfTUlTU0VEEAQiUAoNQ2FwdHVyZVJlYXNv",
            "bhIJCgVVTlNFVBAAEgsKB0RFRkFVTFQQARITCg9FTEVNRU5UQUxfQkFER0UQ",
            "AhISCg5DUklUSUNBTF9DQVRDSBADYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.Capture.CaptureAwardReflection.Descriptor, global::POGOProtos.Data.PokemonDisplayReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.CatchPokemonResponse), global::POGOProtos.Networking.Responses.CatchPokemonResponse.Parser, new[]{ "Status", "MissPercent", "CapturedPokemonId", "CaptureAward", "CaptureReason", "DisplayPokedexId", "ThrowsRemaining", "PokemonDisplay" }, null, new[]{ typeof(global::POGOProtos.Networking.Responses.CatchPokemonResponse.Types.CatchStatus), typeof(global::POGOProtos.Networking.Responses.CatchPokemonResponse.Types.CaptureReason) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CatchPokemonResponse : pb::IMessage<CatchPokemonResponse> {
    private static readonly pb::MessageParser<CatchPokemonResponse> _parser = new pb::MessageParser<CatchPokemonResponse>(() => new CatchPokemonResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CatchPokemonResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.CatchPokemonResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CatchPokemonResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CatchPokemonResponse(CatchPokemonResponse other) : this() {
      status_ = other.status_;
      missPercent_ = other.missPercent_;
      capturedPokemonId_ = other.capturedPokemonId_;
      captureAward_ = other.captureAward_ != null ? other.captureAward_.Clone() : null;
      captureReason_ = other.captureReason_;
      displayPokedexId_ = other.displayPokedexId_;
      throwsRemaining_ = other.throwsRemaining_;
      pokemonDisplay_ = other.pokemonDisplay_ != null ? other.pokemonDisplay_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CatchPokemonResponse Clone() {
      return new CatchPokemonResponse(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::POGOProtos.Networking.Responses.CatchPokemonResponse.Types.CatchStatus status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Responses.CatchPokemonResponse.Types.CatchStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "miss_percent" field.</summary>
    public const int MissPercentFieldNumber = 2;
    private double missPercent_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double MissPercent {
      get { return missPercent_; }
      set {
        missPercent_ = value;
      }
    }

    /// <summary>Field number for the "captured_pokemon_id" field.</summary>
    public const int CapturedPokemonIdFieldNumber = 3;
    private ulong capturedPokemonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong CapturedPokemonId {
      get { return capturedPokemonId_; }
      set {
        capturedPokemonId_ = value;
      }
    }

    /// <summary>Field number for the "capture_award" field.</summary>
    public const int CaptureAwardFieldNumber = 4;
    private global::POGOProtos.Data.Capture.CaptureAward captureAward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Capture.CaptureAward CaptureAward {
      get { return captureAward_; }
      set {
        captureAward_ = value;
      }
    }

    /// <summary>Field number for the "capture_reason" field.</summary>
    public const int CaptureReasonFieldNumber = 5;
    private global::POGOProtos.Networking.Responses.CatchPokemonResponse.Types.CaptureReason captureReason_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Responses.CatchPokemonResponse.Types.CaptureReason CaptureReason {
      get { return captureReason_; }
      set {
        captureReason_ = value;
      }
    }

    /// <summary>Field number for the "display_pokedex_id" field.</summary>
    public const int DisplayPokedexIdFieldNumber = 6;
    private int displayPokedexId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int DisplayPokedexId {
      get { return displayPokedexId_; }
      set {
        displayPokedexId_ = value;
      }
    }

    /// <summary>Field number for the "throws_remaining" field.</summary>
    public const int ThrowsRemainingFieldNumber = 7;
    private int throwsRemaining_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ThrowsRemaining {
      get { return throwsRemaining_; }
      set {
        throwsRemaining_ = value;
      }
    }

    /// <summary>Field number for the "pokemon_display" field.</summary>
    public const int PokemonDisplayFieldNumber = 8;
    private global::POGOProtos.Data.PokemonDisplay pokemonDisplay_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.PokemonDisplay PokemonDisplay {
      get { return pokemonDisplay_; }
      set {
        pokemonDisplay_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CatchPokemonResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CatchPokemonResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(MissPercent, other.MissPercent)) return false;
      if (CapturedPokemonId != other.CapturedPokemonId) return false;
      if (!object.Equals(CaptureAward, other.CaptureAward)) return false;
      if (CaptureReason != other.CaptureReason) return false;
      if (DisplayPokedexId != other.DisplayPokedexId) return false;
      if (ThrowsRemaining != other.ThrowsRemaining) return false;
      if (!object.Equals(PokemonDisplay, other.PokemonDisplay)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != 0) hash ^= Status.GetHashCode();
      if (MissPercent != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(MissPercent);
      if (CapturedPokemonId != 0UL) hash ^= CapturedPokemonId.GetHashCode();
      if (captureAward_ != null) hash ^= CaptureAward.GetHashCode();
      if (CaptureReason != 0) hash ^= CaptureReason.GetHashCode();
      if (DisplayPokedexId != 0) hash ^= DisplayPokedexId.GetHashCode();
      if (ThrowsRemaining != 0) hash ^= ThrowsRemaining.GetHashCode();
      if (pokemonDisplay_ != null) hash ^= PokemonDisplay.GetHashCode();
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
      if (Status != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Status);
      }
      if (MissPercent != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(MissPercent);
      }
      if (CapturedPokemonId != 0UL) {
        output.WriteRawTag(25);
        output.WriteFixed64(CapturedPokemonId);
      }
      if (captureAward_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(CaptureAward);
      }
      if (CaptureReason != 0) {
        output.WriteRawTag(40);
        output.WriteEnum((int) CaptureReason);
      }
      if (DisplayPokedexId != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(DisplayPokedexId);
      }
      if (ThrowsRemaining != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(ThrowsRemaining);
      }
      if (pokemonDisplay_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(PokemonDisplay);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (MissPercent != 0D) {
        size += 1 + 8;
      }
      if (CapturedPokemonId != 0UL) {
        size += 1 + 8;
      }
      if (captureAward_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CaptureAward);
      }
      if (CaptureReason != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CaptureReason);
      }
      if (DisplayPokedexId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(DisplayPokedexId);
      }
      if (ThrowsRemaining != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ThrowsRemaining);
      }
      if (pokemonDisplay_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PokemonDisplay);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CatchPokemonResponse other) {
      if (other == null) {
        return;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      if (other.MissPercent != 0D) {
        MissPercent = other.MissPercent;
      }
      if (other.CapturedPokemonId != 0UL) {
        CapturedPokemonId = other.CapturedPokemonId;
      }
      if (other.captureAward_ != null) {
        if (captureAward_ == null) {
          captureAward_ = new global::POGOProtos.Data.Capture.CaptureAward();
        }
        CaptureAward.MergeFrom(other.CaptureAward);
      }
      if (other.CaptureReason != 0) {
        CaptureReason = other.CaptureReason;
      }
      if (other.DisplayPokedexId != 0) {
        DisplayPokedexId = other.DisplayPokedexId;
      }
      if (other.ThrowsRemaining != 0) {
        ThrowsRemaining = other.ThrowsRemaining;
      }
      if (other.pokemonDisplay_ != null) {
        if (pokemonDisplay_ == null) {
          pokemonDisplay_ = new global::POGOProtos.Data.PokemonDisplay();
        }
        PokemonDisplay.MergeFrom(other.PokemonDisplay);
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
            status_ = (global::POGOProtos.Networking.Responses.CatchPokemonResponse.Types.CatchStatus) input.ReadEnum();
            break;
          }
          case 17: {
            MissPercent = input.ReadDouble();
            break;
          }
          case 25: {
            CapturedPokemonId = input.ReadFixed64();
            break;
          }
          case 34: {
            if (captureAward_ == null) {
              captureAward_ = new global::POGOProtos.Data.Capture.CaptureAward();
            }
            input.ReadMessage(captureAward_);
            break;
          }
          case 40: {
            captureReason_ = (global::POGOProtos.Networking.Responses.CatchPokemonResponse.Types.CaptureReason) input.ReadEnum();
            break;
          }
          case 48: {
            DisplayPokedexId = input.ReadInt32();
            break;
          }
          case 56: {
            ThrowsRemaining = input.ReadInt32();
            break;
          }
          case 66: {
            if (pokemonDisplay_ == null) {
              pokemonDisplay_ = new global::POGOProtos.Data.PokemonDisplay();
            }
            input.ReadMessage(pokemonDisplay_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the CatchPokemonResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum CatchStatus {
        [pbr::OriginalName("CATCH_ERROR")] CatchError = 0,
        [pbr::OriginalName("CATCH_SUCCESS")] CatchSuccess = 1,
        [pbr::OriginalName("CATCH_ESCAPE")] CatchEscape = 2,
        [pbr::OriginalName("CATCH_FLEE")] CatchFlee = 3,
        [pbr::OriginalName("CATCH_MISSED")] CatchMissed = 4,
      }

      public enum CaptureReason {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("DEFAULT")] Default = 1,
        [pbr::OriginalName("ELEMENTAL_BADGE")] ElementalBadge = 2,
        [pbr::OriginalName("CRITICAL_CATCH")] CriticalCatch = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
