// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Settings/Master/IapItemDisplay.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Settings.Master {

  /// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/IapItemDisplay.proto</summary>
  public static partial class IapItemDisplayReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Settings/Master/IapItemDisplay.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IapItemDisplayReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9QT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9JYXBJdGVtRGlzcGxheS5w",
            "cm90bxIaUE9HT1Byb3Rvcy5TZXR0aW5ncy5NYXN0ZXIaJlBPR09Qcm90b3Mv",
            "RW51bXMvSWFwSXRlbUNhdGVnb3J5LnByb3RvGiZQT0dPUHJvdG9zL0ludmVu",
            "dG9yeS9JdGVtL0l0ZW1JZC5wcm90byK/AQoOSWFwSXRlbURpc3BsYXkSCwoD",
            "c2t1GAEgASgJEjcKCGNhdGVnb3J5GAIgASgOMiUuUE9HT1Byb3Rvcy5FbnVt",
            "cy5Ib2xvSWFwSXRlbUNhdGVnb3J5EhIKCnNvcnRfb3JkZXIYAyABKAUSDgoG",
            "aGlkZGVuGAYgASgIEgwKBHNhbGUYByABKAgSEQoJc3ByaXRlX2lkGAggASgJ",
            "Eg0KBXRpdGxlGAkgASgJEhMKC2Rlc2NyaXB0aW9uGAogASgJYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Enums.IapItemCategoryReflection.Descriptor, global::POGOProtos.Inventory.Item.ItemIdReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Settings.Master.IapItemDisplay), global::POGOProtos.Settings.Master.IapItemDisplay.Parser, new[]{ "Sku", "Category", "SortOrder", "Hidden", "Sale", "SpriteId", "Title", "Description" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class IapItemDisplay : pb::IMessage<IapItemDisplay> {
    private static readonly pb::MessageParser<IapItemDisplay> _parser = new pb::MessageParser<IapItemDisplay>(() => new IapItemDisplay());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<IapItemDisplay> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Settings.Master.IapItemDisplayReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IapItemDisplay() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IapItemDisplay(IapItemDisplay other) : this() {
      sku_ = other.sku_;
      category_ = other.category_;
      sortOrder_ = other.sortOrder_;
      hidden_ = other.hidden_;
      sale_ = other.sale_;
      spriteId_ = other.spriteId_;
      title_ = other.title_;
      description_ = other.description_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IapItemDisplay Clone() {
      return new IapItemDisplay(this);
    }

    /// <summary>Field number for the "sku" field.</summary>
    public const int SkuFieldNumber = 1;
    private string sku_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Sku {
      get { return sku_; }
      set {
        sku_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "category" field.</summary>
    public const int CategoryFieldNumber = 2;
    private global::POGOProtos.Enums.HoloIapItemCategory category_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.HoloIapItemCategory Category {
      get { return category_; }
      set {
        category_ = value;
      }
    }

    /// <summary>Field number for the "sort_order" field.</summary>
    public const int SortOrderFieldNumber = 3;
    private int sortOrder_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int SortOrder {
      get { return sortOrder_; }
      set {
        sortOrder_ = value;
      }
    }

    /// <summary>Field number for the "hidden" field.</summary>
    public const int HiddenFieldNumber = 6;
    private bool hidden_;
    /// <summary>
    /// repeated POGOProtos.Inventory.Item.ItemId item_ids = 4;
    /// repeated int32 counts = 5;
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Hidden {
      get { return hidden_; }
      set {
        hidden_ = value;
      }
    }

    /// <summary>Field number for the "sale" field.</summary>
    public const int SaleFieldNumber = 7;
    private bool sale_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Sale {
      get { return sale_; }
      set {
        sale_ = value;
      }
    }

    /// <summary>Field number for the "sprite_id" field.</summary>
    public const int SpriteIdFieldNumber = 8;
    private string spriteId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SpriteId {
      get { return spriteId_; }
      set {
        spriteId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "title" field.</summary>
    public const int TitleFieldNumber = 9;
    private string title_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Title {
      get { return title_; }
      set {
        title_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 10;
    private string description_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as IapItemDisplay);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(IapItemDisplay other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Sku != other.Sku) return false;
      if (Category != other.Category) return false;
      if (SortOrder != other.SortOrder) return false;
      if (Hidden != other.Hidden) return false;
      if (Sale != other.Sale) return false;
      if (SpriteId != other.SpriteId) return false;
      if (Title != other.Title) return false;
      if (Description != other.Description) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Sku.Length != 0) hash ^= Sku.GetHashCode();
      if (Category != 0) hash ^= Category.GetHashCode();
      if (SortOrder != 0) hash ^= SortOrder.GetHashCode();
      if (Hidden != false) hash ^= Hidden.GetHashCode();
      if (Sale != false) hash ^= Sale.GetHashCode();
      if (SpriteId.Length != 0) hash ^= SpriteId.GetHashCode();
      if (Title.Length != 0) hash ^= Title.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Sku.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Sku);
      }
      if (Category != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Category);
      }
      if (SortOrder != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(SortOrder);
      }
      if (Hidden != false) {
        output.WriteRawTag(48);
        output.WriteBool(Hidden);
      }
      if (Sale != false) {
        output.WriteRawTag(56);
        output.WriteBool(Sale);
      }
      if (SpriteId.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(SpriteId);
      }
      if (Title.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Title);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(Description);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Sku.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Sku);
      }
      if (Category != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Category);
      }
      if (SortOrder != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SortOrder);
      }
      if (Hidden != false) {
        size += 1 + 1;
      }
      if (Sale != false) {
        size += 1 + 1;
      }
      if (SpriteId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SpriteId);
      }
      if (Title.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Title);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(IapItemDisplay other) {
      if (other == null) {
        return;
      }
      if (other.Sku.Length != 0) {
        Sku = other.Sku;
      }
      if (other.Category != 0) {
        Category = other.Category;
      }
      if (other.SortOrder != 0) {
        SortOrder = other.SortOrder;
      }
      if (other.Hidden != false) {
        Hidden = other.Hidden;
      }
      if (other.Sale != false) {
        Sale = other.Sale;
      }
      if (other.SpriteId.Length != 0) {
        SpriteId = other.SpriteId;
      }
      if (other.Title.Length != 0) {
        Title = other.Title;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
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
          case 10: {
            Sku = input.ReadString();
            break;
          }
          case 16: {
            category_ = (global::POGOProtos.Enums.HoloIapItemCategory) input.ReadEnum();
            break;
          }
          case 24: {
            SortOrder = input.ReadInt32();
            break;
          }
          case 48: {
            Hidden = input.ReadBool();
            break;
          }
          case 56: {
            Sale = input.ReadBool();
            break;
          }
          case 66: {
            SpriteId = input.ReadString();
            break;
          }
          case 74: {
            Title = input.ReadString();
            break;
          }
          case 82: {
            Description = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
