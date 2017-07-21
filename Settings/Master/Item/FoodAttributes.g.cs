// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Settings/Master/Item/FoodAttributes.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Settings.Master.Item {

  /// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/Item/FoodAttributes.proto</summary>
  public static partial class FoodAttributesReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Settings/Master/Item/FoodAttributes.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FoodAttributesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9JdGVtL0Zvb2RBdHRyaWJ1",
            "dGVzLnByb3RvEh9QT0dPUHJvdG9zLlNldHRpbmdzLk1hc3Rlci5JdGVtGiFQ",
            "T0dPUHJvdG9zL0VudW1zL0l0ZW1FZmZlY3QucHJvdG8iswEKDkZvb2RBdHRy",
            "aWJ1dGVzEjEKC2l0ZW1fZWZmZWN0GAEgAygOMhwuUE9HT1Byb3Rvcy5FbnVt",
            "cy5JdGVtRWZmZWN0EhsKE2l0ZW1fZWZmZWN0X3BlcmNlbnQYAiADKAISFgoO",
            "Z3Jvd3RoX3BlcmNlbnQYAyABKAISGAoQYmVycnlfbXVsdGlwbGllchgEIAEo",
            "AhIfChdyZW1vdGVfYmVycnlfbXVsdGlwbGllchgFIAEoAmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Enums.ItemEffectReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Settings.Master.Item.FoodAttributes), global::POGOProtos.Settings.Master.Item.FoodAttributes.Parser, new[]{ "ItemEffect", "ItemEffectPercent", "GrowthPercent", "BerryMultiplier", "RemoteBerryMultiplier" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FoodAttributes : pb::IMessage<FoodAttributes> {
    private static readonly pb::MessageParser<FoodAttributes> _parser = new pb::MessageParser<FoodAttributes>(() => new FoodAttributes());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FoodAttributes> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Settings.Master.Item.FoodAttributesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FoodAttributes() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FoodAttributes(FoodAttributes other) : this() {
      itemEffect_ = other.itemEffect_.Clone();
      itemEffectPercent_ = other.itemEffectPercent_.Clone();
      growthPercent_ = other.growthPercent_;
      berryMultiplier_ = other.berryMultiplier_;
      remoteBerryMultiplier_ = other.remoteBerryMultiplier_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FoodAttributes Clone() {
      return new FoodAttributes(this);
    }

    /// <summary>Field number for the "item_effect" field.</summary>
    public const int ItemEffectFieldNumber = 1;
    private static readonly pb::FieldCodec<global::POGOProtos.Enums.ItemEffect> _repeated_itemEffect_codec
        = pb::FieldCodec.ForEnum(10, x => (int) x, x => (global::POGOProtos.Enums.ItemEffect) x);
    private readonly pbc::RepeatedField<global::POGOProtos.Enums.ItemEffect> itemEffect_ = new pbc::RepeatedField<global::POGOProtos.Enums.ItemEffect>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Enums.ItemEffect> ItemEffect {
      get { return itemEffect_; }
    }

    /// <summary>Field number for the "item_effect_percent" field.</summary>
    public const int ItemEffectPercentFieldNumber = 2;
    private static readonly pb::FieldCodec<float> _repeated_itemEffectPercent_codec
        = pb::FieldCodec.ForFloat(18);
    private readonly pbc::RepeatedField<float> itemEffectPercent_ = new pbc::RepeatedField<float>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<float> ItemEffectPercent {
      get { return itemEffectPercent_; }
    }

    /// <summary>Field number for the "growth_percent" field.</summary>
    public const int GrowthPercentFieldNumber = 3;
    private float growthPercent_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float GrowthPercent {
      get { return growthPercent_; }
      set {
        growthPercent_ = value;
      }
    }

    /// <summary>Field number for the "berry_multiplier" field.</summary>
    public const int BerryMultiplierFieldNumber = 4;
    private float berryMultiplier_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float BerryMultiplier {
      get { return berryMultiplier_; }
      set {
        berryMultiplier_ = value;
      }
    }

    /// <summary>Field number for the "remote_berry_multiplier" field.</summary>
    public const int RemoteBerryMultiplierFieldNumber = 5;
    private float remoteBerryMultiplier_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float RemoteBerryMultiplier {
      get { return remoteBerryMultiplier_; }
      set {
        remoteBerryMultiplier_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FoodAttributes);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FoodAttributes other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!itemEffect_.Equals(other.itemEffect_)) return false;
      if(!itemEffectPercent_.Equals(other.itemEffectPercent_)) return false;
      if (GrowthPercent != other.GrowthPercent) return false;
      if (BerryMultiplier != other.BerryMultiplier) return false;
      if (RemoteBerryMultiplier != other.RemoteBerryMultiplier) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= itemEffect_.GetHashCode();
      hash ^= itemEffectPercent_.GetHashCode();
      if (GrowthPercent != 0F) hash ^= GrowthPercent.GetHashCode();
      if (BerryMultiplier != 0F) hash ^= BerryMultiplier.GetHashCode();
      if (RemoteBerryMultiplier != 0F) hash ^= RemoteBerryMultiplier.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      itemEffect_.WriteTo(output, _repeated_itemEffect_codec);
      itemEffectPercent_.WriteTo(output, _repeated_itemEffectPercent_codec);
      if (GrowthPercent != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(GrowthPercent);
      }
      if (BerryMultiplier != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(BerryMultiplier);
      }
      if (RemoteBerryMultiplier != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(RemoteBerryMultiplier);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += itemEffect_.CalculateSize(_repeated_itemEffect_codec);
      size += itemEffectPercent_.CalculateSize(_repeated_itemEffectPercent_codec);
      if (GrowthPercent != 0F) {
        size += 1 + 4;
      }
      if (BerryMultiplier != 0F) {
        size += 1 + 4;
      }
      if (RemoteBerryMultiplier != 0F) {
        size += 1 + 4;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FoodAttributes other) {
      if (other == null) {
        return;
      }
      itemEffect_.Add(other.itemEffect_);
      itemEffectPercent_.Add(other.itemEffectPercent_);
      if (other.GrowthPercent != 0F) {
        GrowthPercent = other.GrowthPercent;
      }
      if (other.BerryMultiplier != 0F) {
        BerryMultiplier = other.BerryMultiplier;
      }
      if (other.RemoteBerryMultiplier != 0F) {
        RemoteBerryMultiplier = other.RemoteBerryMultiplier;
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
          case 10:
          case 8: {
            itemEffect_.AddEntriesFrom(input, _repeated_itemEffect_codec);
            break;
          }
          case 18:
          case 21: {
            itemEffectPercent_.AddEntriesFrom(input, _repeated_itemEffectPercent_codec);
            break;
          }
          case 29: {
            GrowthPercent = input.ReadFloat();
            break;
          }
          case 37: {
            BerryMultiplier = input.ReadFloat();
            break;
          }
          case 45: {
            RemoteBerryMultiplier = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
