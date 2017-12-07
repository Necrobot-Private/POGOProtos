// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Networking/Requests/Messages/UseItemStardustBoostMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/UseItemStardustBoostMessage.proto</summary>
  public static partial class UseItemStardustBoostMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/UseItemStardustBoostMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UseItemStardustBoostMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CklQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvVXNl",
            "SXRlbVN0YXJkdXN0Qm9vc3RNZXNzYWdlLnByb3RvEidQT0dPUHJvdG9zLk5l",
            "dHdvcmtpbmcuUmVxdWVzdHMuTWVzc2FnZXMaJlBPR09Qcm90b3MvSW52ZW50",
            "b3J5L0l0ZW0vSXRlbUlkLnByb3RvIk4KG1VzZUl0ZW1TdGFyZHVzdEJvb3N0",
            "TWVzc2FnZRIvCgRpdGVtGAEgASgOMiEuUE9HT1Byb3Rvcy5JbnZlbnRvcnku",
            "SXRlbS5JdGVtSWRiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Inventory.Item.ItemIdReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Requests.Messages.UseItemStardustBoostMessage), global::POGOProtos.Networking.Requests.Messages.UseItemStardustBoostMessage.Parser, new[]{ "Item" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class UseItemStardustBoostMessage : pb::IMessage<UseItemStardustBoostMessage> {
    private static readonly pb::MessageParser<UseItemStardustBoostMessage> _parser = new pb::MessageParser<UseItemStardustBoostMessage>(() => new UseItemStardustBoostMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UseItemStardustBoostMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Requests.Messages.UseItemStardustBoostMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UseItemStardustBoostMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UseItemStardustBoostMessage(UseItemStardustBoostMessage other) : this() {
      item_ = other.item_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UseItemStardustBoostMessage Clone() {
      return new UseItemStardustBoostMessage(this);
    }

    /// <summary>Field number for the "item" field.</summary>
    public const int ItemFieldNumber = 1;
    private global::POGOProtos.Inventory.Item.ItemId item_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Inventory.Item.ItemId Item {
      get { return item_; }
      set {
        item_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UseItemStardustBoostMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UseItemStardustBoostMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Item != other.Item) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Item != 0) hash ^= Item.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Item != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Item);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Item != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Item);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UseItemStardustBoostMessage other) {
      if (other == null) {
        return;
      }
      if (other.Item != 0) {
        Item = other.Item;
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
          case 8: {
            item_ = (global::POGOProtos.Inventory.Item.ItemId) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
