// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Platform/Responses/GetStoreItemsResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Platform.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Platform/Responses/GetStoreItemsResponse.proto</summary>
  public static partial class GetStoreItemsResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Platform/Responses/GetStoreItemsResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetStoreItemsResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkRQT0dPUHJvdG9zL05ldHdvcmtpbmcvUGxhdGZvcm0vUmVzcG9uc2VzL0dl",
            "dFN0b3JlSXRlbXNSZXNwb25zZS5wcm90bxIoUE9HT1Byb3Rvcy5OZXR3b3Jr",
            "aW5nLlBsYXRmb3JtLlJlc3BvbnNlcxolUE9HT1Byb3Rvcy9EYXRhL1BsYXll",
            "ci9DdXJyZW5jeS5wcm90byKFBgoVR2V0U3RvcmVJdGVtc1Jlc3BvbnNlElYK",
            "BnN0YXR1cxgBIAEoDjJGLlBPR09Qcm90b3MuTmV0d29ya2luZy5QbGF0Zm9y",
            "bS5SZXNwb25zZXMuR2V0U3RvcmVJdGVtc1Jlc3BvbnNlLlN0YXR1cxJYCgVp",
            "dGVtcxgCIAMoCzJJLlBPR09Qcm90b3MuTmV0d29ya2luZy5QbGF0Zm9ybS5S",
            "ZXNwb25zZXMuR2V0U3RvcmVJdGVtc1Jlc3BvbnNlLlN0b3JlSXRlbRI7ChFw",
            "bGF5ZXJfY3VycmVuY2llcxgDIAMoCzIgLlBPR09Qcm90b3MuRGF0YS5QbGF5",
            "ZXIuQ3VycmVuY3kSDAoEaGFzaBgEIAEoCRrxAgoJU3RvcmVJdGVtEg8KB2l0",
            "ZW1faWQYASABKAkSDgoGaXNfaWFwGAIgASgIEjkKD2N1cnJlbmN5X3RvX2J1",
            "eRgDIAEoCzIgLlBPR09Qcm90b3MuRGF0YS5QbGF5ZXIuQ3VycmVuY3kSOQoP",
            "eWllbGRzX2N1cnJlbmN5GAQgASgLMiAuUE9HT1Byb3Rvcy5EYXRhLlBsYXll",
            "ci5DdXJyZW5jeRJiCgt5aWVsZHNfaXRlbRgFIAEoCzJNLlBPR09Qcm90b3Mu",
            "TmV0d29ya2luZy5QbGF0Zm9ybS5SZXNwb25zZXMuR2V0U3RvcmVJdGVtc1Jl",
            "c3BvbnNlLlN0b3JlSXRlbUluZm8SVwoEdGFncxgGIAMoCzJJLlBPR09Qcm90",
            "b3MuTmV0d29ya2luZy5QbGF0Zm9ybS5SZXNwb25zZXMuR2V0U3RvcmVJdGVt",
            "c1Jlc3BvbnNlLlN0b3JlVGFncxIQCgh1bmtub3duNxgHIAEoBRonCglTdG9y",
            "ZVRhZ3MSCwoDdGFnGAEgASgJEg0KBXZhbHVlGAIgASgJGi8KDVN0b3JlSXRl",
            "bUluZm8SDwoHaXRlbV9pZBgBIAEoCRINCgVjb3VudBgCIAEoBSIhCgZTdGF0",
            "dXMSDQoJVU5ERUZJTkVEEAASCAoET0tBWRABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.Player.CurrencyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse), global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Parser, new[]{ "Status", "Items", "PlayerCurrencies", "Hash" }, null, new[]{ typeof(global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.Status) }, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.StoreItem), global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.StoreItem.Parser, new[]{ "ItemId", "IsIap", "CurrencyToBuy", "YieldsCurrency", "YieldsItem", "Tags", "Unknown7" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.StoreTags), global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.StoreTags.Parser, new[]{ "Tag", "Value" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.StoreItemInfo), global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.StoreItemInfo.Parser, new[]{ "ItemId", "Count" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetStoreItemsResponse : pb::IMessage<GetStoreItemsResponse> {
    private static readonly pb::MessageParser<GetStoreItemsResponse> _parser = new pb::MessageParser<GetStoreItemsResponse>(() => new GetStoreItemsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetStoreItemsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetStoreItemsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetStoreItemsResponse(GetStoreItemsResponse other) : this() {
      status_ = other.status_;
      items_ = other.items_.Clone();
      playerCurrencies_ = other.playerCurrencies_.Clone();
      hash_ = other.hash_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetStoreItemsResponse Clone() {
      return new GetStoreItemsResponse(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.Status status_ = 0;
    /// <summary>
    /// Unconfirmed
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "items" field.</summary>
    public const int ItemsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.StoreItem> _repeated_items_codec
        = pb::FieldCodec.ForMessage(18, global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.StoreItem.Parser);
    private readonly pbc::RepeatedField<global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.StoreItem> items_ = new pbc::RepeatedField<global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.StoreItem>();
    /// <summary>
    /// Items to show in the shop
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.StoreItem> Items {
      get { return items_; }
    }

    /// <summary>Field number for the "player_currencies" field.</summary>
    public const int PlayerCurrenciesFieldNumber = 3;
    private static readonly pb::FieldCodec<global::POGOProtos.Data.Player.Currency> _repeated_playerCurrencies_codec
        = pb::FieldCodec.ForMessage(26, global::POGOProtos.Data.Player.Currency.Parser);
    private readonly pbc::RepeatedField<global::POGOProtos.Data.Player.Currency> playerCurrencies_ = new pbc::RepeatedField<global::POGOProtos.Data.Player.Currency>();
    /// <summary>
    /// currencies that player has at the moment
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Data.Player.Currency> PlayerCurrencies {
      get { return playerCurrencies_; }
    }

    /// <summary>Field number for the "hash" field.</summary>
    public const int HashFieldNumber = 4;
    private string hash_ = "";
    /// <summary>
    /// hash?
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Hash {
      get { return hash_; }
      set {
        hash_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetStoreItemsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetStoreItemsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      if(!items_.Equals(other.items_)) return false;
      if(!playerCurrencies_.Equals(other.playerCurrencies_)) return false;
      if (Hash != other.Hash) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != 0) hash ^= Status.GetHashCode();
      hash ^= items_.GetHashCode();
      hash ^= playerCurrencies_.GetHashCode();
      if (Hash.Length != 0) hash ^= Hash.GetHashCode();
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
      items_.WriteTo(output, _repeated_items_codec);
      playerCurrencies_.WriteTo(output, _repeated_playerCurrencies_codec);
      if (Hash.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Hash);
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
      size += items_.CalculateSize(_repeated_items_codec);
      size += playerCurrencies_.CalculateSize(_repeated_playerCurrencies_codec);
      if (Hash.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Hash);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetStoreItemsResponse other) {
      if (other == null) {
        return;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      items_.Add(other.items_);
      playerCurrencies_.Add(other.playerCurrencies_);
      if (other.Hash.Length != 0) {
        Hash = other.Hash;
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
            status_ = (global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.Status) input.ReadEnum();
            break;
          }
          case 18: {
            items_.AddEntriesFrom(input, _repeated_items_codec);
            break;
          }
          case 26: {
            playerCurrencies_.AddEntriesFrom(input, _repeated_playerCurrencies_codec);
            break;
          }
          case 34: {
            Hash = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the GetStoreItemsResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Status {
        [pbr::OriginalName("UNDEFINED")] Undefined = 0,
        [pbr::OriginalName("OKAY")] Okay = 1,
      }

      public sealed partial class StoreItem : pb::IMessage<StoreItem> {
        private static readonly pb::MessageParser<StoreItem> _parser = new pb::MessageParser<StoreItem>(() => new StoreItem());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<StoreItem> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public StoreItem() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public StoreItem(StoreItem other) : this() {
          itemId_ = other.itemId_;
          isIap_ = other.isIap_;
          CurrencyToBuy = other.currencyToBuy_ != null ? other.CurrencyToBuy.Clone() : null;
          YieldsCurrency = other.yieldsCurrency_ != null ? other.YieldsCurrency.Clone() : null;
          YieldsItem = other.yieldsItem_ != null ? other.YieldsItem.Clone() : null;
          tags_ = other.tags_.Clone();
          unknown7_ = other.unknown7_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public StoreItem Clone() {
          return new StoreItem(this);
        }

        /// <summary>Field number for the "item_id" field.</summary>
        public const int ItemIdFieldNumber = 1;
        private string itemId_ = "";
        /// <summary>
        /// Internal ID (probably for Google Play/App Store) example: "pgorelease.incenseordinary.1"
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string ItemId {
          get { return itemId_; }
          set {
            itemId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "is_iap" field.</summary>
        public const int IsIapFieldNumber = 2;
        private bool isIap_;
        /// <summary>
        /// If true, this item is bought with real currency (USD, etc.) through the Play/App Store instead of Pokecoins
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool IsIap {
          get { return isIap_; }
          set {
            isIap_ = value;
          }
        }

        /// <summary>Field number for the "currency_to_buy" field.</summary>
        public const int CurrencyToBuyFieldNumber = 3;
        private global::POGOProtos.Data.Player.Currency currencyToBuy_;
        /// <summary>
        /// This defines how much the item costs (with the exception of items that cost real money like Pokecoins, that's defined in the respective store)
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::POGOProtos.Data.Player.Currency CurrencyToBuy {
          get { return currencyToBuy_; }
          set {
            currencyToBuy_ = value;
          }
        }

        /// <summary>Field number for the "yields_currency" field.</summary>
        public const int YieldsCurrencyFieldNumber = 4;
        private global::POGOProtos.Data.Player.Currency yieldsCurrency_;
        /// <summary>
        /// When bought, this IAP will yield this much currency
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::POGOProtos.Data.Player.Currency YieldsCurrency {
          get { return yieldsCurrency_; }
          set {
            yieldsCurrency_ = value;
          }
        }

        /// <summary>Field number for the "yields_item" field.</summary>
        public const int YieldsItemFieldNumber = 5;
        private global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.StoreItemInfo yieldsItem_;
        /// <summary>
        /// The item and count of such item that this IAP will yield
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.StoreItemInfo YieldsItem {
          get { return yieldsItem_; }
          set {
            yieldsItem_ = value;
          }
        }

        /// <summary>Field number for the "tags" field.</summary>
        public const int TagsFieldNumber = 6;
        private static readonly pb::FieldCodec<global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.StoreTags> _repeated_tags_codec
            = pb::FieldCodec.ForMessage(50, global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.StoreTags.Parser);
        private readonly pbc::RepeatedField<global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.StoreTags> tags_ = new pbc::RepeatedField<global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.StoreTags>();
        /// <summary>
        /// Stuff like SORT:12, CATEGORY:ITEMS
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.StoreTags> Tags {
          get { return tags_; }
        }

        /// <summary>Field number for the "unknown7" field.</summary>
        public const int Unknown7FieldNumber = 7;
        private int unknown7_;
        /// <summary>
        /// Possibly something to toggle visibility in the store/purchasibility?
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int Unknown7 {
          get { return unknown7_; }
          set {
            unknown7_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as StoreItem);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(StoreItem other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (ItemId != other.ItemId) return false;
          if (IsIap != other.IsIap) return false;
          if (!object.Equals(CurrencyToBuy, other.CurrencyToBuy)) return false;
          if (!object.Equals(YieldsCurrency, other.YieldsCurrency)) return false;
          if (!object.Equals(YieldsItem, other.YieldsItem)) return false;
          if(!tags_.Equals(other.tags_)) return false;
          if (Unknown7 != other.Unknown7) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (ItemId.Length != 0) hash ^= ItemId.GetHashCode();
          if (IsIap != false) hash ^= IsIap.GetHashCode();
          if (currencyToBuy_ != null) hash ^= CurrencyToBuy.GetHashCode();
          if (yieldsCurrency_ != null) hash ^= YieldsCurrency.GetHashCode();
          if (yieldsItem_ != null) hash ^= YieldsItem.GetHashCode();
          hash ^= tags_.GetHashCode();
          if (Unknown7 != 0) hash ^= Unknown7.GetHashCode();
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
          if (ItemId.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(ItemId);
          }
          if (IsIap != false) {
            output.WriteRawTag(16);
            output.WriteBool(IsIap);
          }
          if (currencyToBuy_ != null) {
            output.WriteRawTag(26);
            output.WriteMessage(CurrencyToBuy);
          }
          if (yieldsCurrency_ != null) {
            output.WriteRawTag(34);
            output.WriteMessage(YieldsCurrency);
          }
          if (yieldsItem_ != null) {
            output.WriteRawTag(42);
            output.WriteMessage(YieldsItem);
          }
          tags_.WriteTo(output, _repeated_tags_codec);
          if (Unknown7 != 0) {
            output.WriteRawTag(56);
            output.WriteInt32(Unknown7);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (ItemId.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(ItemId);
          }
          if (IsIap != false) {
            size += 1 + 1;
          }
          if (currencyToBuy_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(CurrencyToBuy);
          }
          if (yieldsCurrency_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(YieldsCurrency);
          }
          if (yieldsItem_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(YieldsItem);
          }
          size += tags_.CalculateSize(_repeated_tags_codec);
          if (Unknown7 != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(Unknown7);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(StoreItem other) {
          if (other == null) {
            return;
          }
          if (other.ItemId.Length != 0) {
            ItemId = other.ItemId;
          }
          if (other.IsIap != false) {
            IsIap = other.IsIap;
          }
          if (other.currencyToBuy_ != null) {
            if (currencyToBuy_ == null) {
              currencyToBuy_ = new global::POGOProtos.Data.Player.Currency();
            }
            CurrencyToBuy.MergeFrom(other.CurrencyToBuy);
          }
          if (other.yieldsCurrency_ != null) {
            if (yieldsCurrency_ == null) {
              yieldsCurrency_ = new global::POGOProtos.Data.Player.Currency();
            }
            YieldsCurrency.MergeFrom(other.YieldsCurrency);
          }
          if (other.yieldsItem_ != null) {
            if (yieldsItem_ == null) {
              yieldsItem_ = new global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.StoreItemInfo();
            }
            YieldsItem.MergeFrom(other.YieldsItem);
          }
          tags_.Add(other.tags_);
          if (other.Unknown7 != 0) {
            Unknown7 = other.Unknown7;
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
                ItemId = input.ReadString();
                break;
              }
              case 16: {
                IsIap = input.ReadBool();
                break;
              }
              case 26: {
                if (currencyToBuy_ == null) {
                  currencyToBuy_ = new global::POGOProtos.Data.Player.Currency();
                }
                input.ReadMessage(currencyToBuy_);
                break;
              }
              case 34: {
                if (yieldsCurrency_ == null) {
                  yieldsCurrency_ = new global::POGOProtos.Data.Player.Currency();
                }
                input.ReadMessage(yieldsCurrency_);
                break;
              }
              case 42: {
                if (yieldsItem_ == null) {
                  yieldsItem_ = new global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.StoreItemInfo();
                }
                input.ReadMessage(yieldsItem_);
                break;
              }
              case 50: {
                tags_.AddEntriesFrom(input, _repeated_tags_codec);
                break;
              }
              case 56: {
                Unknown7 = input.ReadInt32();
                break;
              }
            }
          }
        }

      }

      public sealed partial class StoreTags : pb::IMessage<StoreTags> {
        private static readonly pb::MessageParser<StoreTags> _parser = new pb::MessageParser<StoreTags>(() => new StoreTags());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<StoreTags> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Descriptor.NestedTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public StoreTags() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public StoreTags(StoreTags other) : this() {
          tag_ = other.tag_;
          value_ = other.value_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public StoreTags Clone() {
          return new StoreTags(this);
        }

        /// <summary>Field number for the "tag" field.</summary>
        public const int TagFieldNumber = 1;
        private string tag_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Tag {
          get { return tag_; }
          set {
            tag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "value" field.</summary>
        public const int ValueFieldNumber = 2;
        private string value_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Value {
          get { return value_; }
          set {
            value_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as StoreTags);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(StoreTags other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Tag != other.Tag) return false;
          if (Value != other.Value) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Tag.Length != 0) hash ^= Tag.GetHashCode();
          if (Value.Length != 0) hash ^= Value.GetHashCode();
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
          if (Tag.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Tag);
          }
          if (Value.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(Value);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Tag.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Tag);
          }
          if (Value.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Value);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(StoreTags other) {
          if (other == null) {
            return;
          }
          if (other.Tag.Length != 0) {
            Tag = other.Tag;
          }
          if (other.Value.Length != 0) {
            Value = other.Value;
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
                Tag = input.ReadString();
                break;
              }
              case 18: {
                Value = input.ReadString();
                break;
              }
            }
          }
        }

      }

      public sealed partial class StoreItemInfo : pb::IMessage<StoreItemInfo> {
        private static readonly pb::MessageParser<StoreItemInfo> _parser = new pb::MessageParser<StoreItemInfo>(() => new StoreItemInfo());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<StoreItemInfo> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Descriptor.NestedTypes[2]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public StoreItemInfo() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public StoreItemInfo(StoreItemInfo other) : this() {
          itemId_ = other.itemId_;
          count_ = other.count_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public StoreItemInfo Clone() {
          return new StoreItemInfo(this);
        }

        /// <summary>Field number for the "item_id" field.</summary>
        public const int ItemIdFieldNumber = 1;
        private string itemId_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string ItemId {
          get { return itemId_; }
          set {
            itemId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "count" field.</summary>
        public const int CountFieldNumber = 2;
        private int count_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int Count {
          get { return count_; }
          set {
            count_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as StoreItemInfo);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(StoreItemInfo other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (ItemId != other.ItemId) return false;
          if (Count != other.Count) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (ItemId.Length != 0) hash ^= ItemId.GetHashCode();
          if (Count != 0) hash ^= Count.GetHashCode();
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
          if (ItemId.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(ItemId);
          }
          if (Count != 0) {
            output.WriteRawTag(16);
            output.WriteInt32(Count);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (ItemId.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(ItemId);
          }
          if (Count != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(Count);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(StoreItemInfo other) {
          if (other == null) {
            return;
          }
          if (other.ItemId.Length != 0) {
            ItemId = other.ItemId;
          }
          if (other.Count != 0) {
            Count = other.Count;
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
                ItemId = input.ReadString();
                break;
              }
              case 16: {
                Count = input.ReadInt32();
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
