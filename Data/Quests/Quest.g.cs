// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Data/Quests/Quest.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Quests {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Quests/Quest.proto</summary>
  public static partial class QuestReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Quests/Quest.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QuestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJQT0dPUHJvdG9zL0RhdGEvUXVlc3RzL1F1ZXN0LnByb3RvEhZQT0dPUHJv",
            "dG9zLkRhdGEuUXVlc3RzGiBQT0dPUHJvdG9zL0VudW1zL1F1ZXN0VHlwZS5w",
            "cm90bxonUE9HT1Byb3Rvcy9EYXRhL1F1ZXN0cy9EYWlseVF1ZXN0LnByb3Rv",
            "Gi5QT0dPUHJvdG9zL0RhdGEvUXVlc3RzL0NhdGNoUG9rZW1vblF1ZXN0LnBy",
            "b3RvGihQT0dPUHJvdG9zL0RhdGEvUXVlc3RzL1F1ZXN0UmV3YXJkLnByb3Rv",
            "GiZQT0dPUHJvdG9zL0RhdGEvUXVlc3RzL1F1ZXN0R29hbC5wcm90bxorUE9H",
            "T1Byb3Rvcy9EYXRhL1F1ZXN0cy9BZGRGcmllbmRRdWVzdC5wcm90bxouUE9H",
            "T1Byb3Rvcy9EYXRhL1F1ZXN0cy9UcmFkZVBva2Vtb25RdWVzdC5wcm90byL2",
            "CAoFUXVlc3QSLwoKcXVlc3RfdHlwZRgBIAEoDjIbLlBPR09Qcm90b3MuRW51",
            "bXMuUXVlc3RUeXBlEjcKC2RhaWx5X3F1ZXN0GAIgASgLMiIuUE9HT1Byb3Rv",
            "cy5EYXRhLlF1ZXN0cy5EYWlseVF1ZXN0EkAKCm11bHRpX3BhcnQYAyABKAsy",
            "LC5QT0dPUHJvdG9zLkRhdGEuUXVlc3RzLlF1ZXN0Lk11bHRpUGFydFF1ZXN0",
            "EkAKDWNhdGNoX3Bva2Vtb24YBCABKAsyKS5QT0dPUHJvdG9zLkRhdGEuUXVl",
            "c3RzLkNhdGNoUG9rZW1vblF1ZXN0EjoKCmFkZF9mcmllbmQYBSABKAsyJi5Q",
            "T0dPUHJvdG9zLkRhdGEuUXVlc3RzLkFkZEZyaWVuZFF1ZXN0EkAKDXRyYWRl",
            "X3Bva2Vtb24YBiABKAsyKS5QT0dPUHJvdG9zLkRhdGEuUXVlc3RzLlRyYWRl",
            "UG9rZW1vblF1ZXN0EhAKCHF1ZXN0X2lkGGQgASgJEhIKCnF1ZXN0X3NlZWQY",
            "ZSABKAMSPAoNcXVlc3RfY29udGV4dBhmIAEoDjIlLlBPR09Qcm90b3MuRGF0",
            "YS5RdWVzdHMuUXVlc3QuQ29udGV4dBITCgt0ZW1wbGF0ZV9pZBhnIAEoCRIQ",
            "Cghwcm9ncmVzcxhoIAEoBRIvCgRnb2FsGGkgASgLMiEuUE9HT1Byb3Rvcy5E",
            "YXRhLlF1ZXN0cy5RdWVzdEdvYWwSNAoGc3RhdHVzGGogASgOMiQuUE9HT1By",
            "b3Rvcy5EYXRhLlF1ZXN0cy5RdWVzdC5TdGF0dXMSOgoNcXVlc3RfcmV3YXJk",
            "cxhrIAMoCzIjLlBPR09Qcm90b3MuRGF0YS5RdWVzdHMuUXVlc3RSZXdhcmQS",
            "HQoVY3JlYXRpb25fdGltZXN0YW1wX21zGGwgASgDEiAKGGxhc3RfdXBkYXRl",
            "X3RpbWVzdGFtcF9tcxhtIAEoAxIgChhjb21wZWxldGlvbl90aW1lc3RhbXBf",
            "bXMYbiABKAMSDwoHZm9ydF9pZBhvIAEoCRIXCg9hZG1pbl9nZW5lcmF0ZWQY",
            "cCABKAgSJAocc3RhbXBfY291bnRfb3ZlcnJpZGVfZW5hYmxlZBhxIAEoCBIc",
            "ChRzdGFtcF9jb3VudF9vdmVycmlkZRhyIAEoBRISCgpzMl9jZWxsX2lkGHMg",
            "ASgDEiQKHHN0b3J5X3F1ZXN0X3RlbXBsYXRlX3ZlcnNpb24YdCABKAUaQwoO",
            "TXVsdGlQYXJ0UXVlc3QSMQoKc3ViX3F1ZXN0cxgBIAMoCzIdLlBPR09Qcm90",
            "b3MuRGF0YS5RdWVzdHMuUXVlc3QiOgoHQ29udGV4dBIJCgVVTlNFVBAAEg8K",
            "C1NUT1JZX1FVRVNUEAESEwoPQ0hBTExFTkdFX1FVRVNUEAIiRwoGU3RhdHVz",
            "EhQKEFNUQVRVU19VTkRFRklORUQQABIRCg1TVEFUVVNfQUNUSVZFEAESFAoQ",
            "U1RBVFVTX0NPTVBMRVRFRBACYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Enums.QuestTypeReflection.Descriptor, global::POGOProtos.Data.Quests.DailyQuestReflection.Descriptor, global::POGOProtos.Data.Quests.CatchPokemonQuestReflection.Descriptor, global::POGOProtos.Data.Quests.QuestRewardReflection.Descriptor, global::POGOProtos.Data.Quests.QuestGoalReflection.Descriptor, global::POGOProtos.Data.Quests.AddFriendQuestReflection.Descriptor, global::POGOProtos.Data.Quests.TradePokemonQuestReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Quests.Quest), global::POGOProtos.Data.Quests.Quest.Parser, new[]{ "QuestType", "DailyQuest", "MultiPart", "CatchPokemon", "AddFriend", "TradePokemon", "QuestId", "QuestSeed", "QuestContext", "TemplateId", "Progress", "Goal", "Status", "QuestRewards", "CreationTimestampMs", "LastUpdateTimestampMs", "CompeletionTimestampMs", "FortId", "AdminGenerated", "StampCountOverrideEnabled", "StampCountOverride", "S2CellId", "StoryQuestTemplateVersion" }, null, new[]{ typeof(global::POGOProtos.Data.Quests.Quest.Types.Context), typeof(global::POGOProtos.Data.Quests.Quest.Types.Status) }, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Quests.Quest.Types.MultiPartQuest), global::POGOProtos.Data.Quests.Quest.Types.MultiPartQuest.Parser, new[]{ "SubQuests" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Quest : pb::IMessage<Quest> {
    private static readonly pb::MessageParser<Quest> _parser = new pb::MessageParser<Quest>(() => new Quest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Quest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Quests.QuestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Quest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Quest(Quest other) : this() {
      questType_ = other.questType_;
      dailyQuest_ = other.dailyQuest_ != null ? other.dailyQuest_.Clone() : null;
      multiPart_ = other.multiPart_ != null ? other.multiPart_.Clone() : null;
      catchPokemon_ = other.catchPokemon_ != null ? other.catchPokemon_.Clone() : null;
      addFriend_ = other.addFriend_ != null ? other.addFriend_.Clone() : null;
      tradePokemon_ = other.tradePokemon_ != null ? other.tradePokemon_.Clone() : null;
      questId_ = other.questId_;
      questSeed_ = other.questSeed_;
      questContext_ = other.questContext_;
      templateId_ = other.templateId_;
      progress_ = other.progress_;
      goal_ = other.goal_ != null ? other.goal_.Clone() : null;
      status_ = other.status_;
      questRewards_ = other.questRewards_.Clone();
      creationTimestampMs_ = other.creationTimestampMs_;
      lastUpdateTimestampMs_ = other.lastUpdateTimestampMs_;
      compeletionTimestampMs_ = other.compeletionTimestampMs_;
      fortId_ = other.fortId_;
      adminGenerated_ = other.adminGenerated_;
      stampCountOverrideEnabled_ = other.stampCountOverrideEnabled_;
      stampCountOverride_ = other.stampCountOverride_;
      s2CellId_ = other.s2CellId_;
      storyQuestTemplateVersion_ = other.storyQuestTemplateVersion_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Quest Clone() {
      return new Quest(this);
    }

    /// <summary>Field number for the "quest_type" field.</summary>
    public const int QuestTypeFieldNumber = 1;
    private global::POGOProtos.Enums.QuestType questType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.QuestType QuestType {
      get { return questType_; }
      set {
        questType_ = value;
      }
    }

    /// <summary>Field number for the "daily_quest" field.</summary>
    public const int DailyQuestFieldNumber = 2;
    private global::POGOProtos.Data.Quests.DailyQuest dailyQuest_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Quests.DailyQuest DailyQuest {
      get { return dailyQuest_; }
      set {
        dailyQuest_ = value;
      }
    }

    /// <summary>Field number for the "multi_part" field.</summary>
    public const int MultiPartFieldNumber = 3;
    private global::POGOProtos.Data.Quests.Quest.Types.MultiPartQuest multiPart_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Quests.Quest.Types.MultiPartQuest MultiPart {
      get { return multiPart_; }
      set {
        multiPart_ = value;
      }
    }

    /// <summary>Field number for the "catch_pokemon" field.</summary>
    public const int CatchPokemonFieldNumber = 4;
    private global::POGOProtos.Data.Quests.CatchPokemonQuest catchPokemon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Quests.CatchPokemonQuest CatchPokemon {
      get { return catchPokemon_; }
      set {
        catchPokemon_ = value;
      }
    }

    /// <summary>Field number for the "add_friend" field.</summary>
    public const int AddFriendFieldNumber = 5;
    private global::POGOProtos.Data.Quests.AddFriendQuest addFriend_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Quests.AddFriendQuest AddFriend {
      get { return addFriend_; }
      set {
        addFriend_ = value;
      }
    }

    /// <summary>Field number for the "trade_pokemon" field.</summary>
    public const int TradePokemonFieldNumber = 6;
    private global::POGOProtos.Data.Quests.TradePokemonQuest tradePokemon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Quests.TradePokemonQuest TradePokemon {
      get { return tradePokemon_; }
      set {
        tradePokemon_ = value;
      }
    }

    /// <summary>Field number for the "quest_id" field.</summary>
    public const int QuestIdFieldNumber = 100;
    private string questId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string QuestId {
      get { return questId_; }
      set {
        questId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "quest_seed" field.</summary>
    public const int QuestSeedFieldNumber = 101;
    private long questSeed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long QuestSeed {
      get { return questSeed_; }
      set {
        questSeed_ = value;
      }
    }

    /// <summary>Field number for the "quest_context" field.</summary>
    public const int QuestContextFieldNumber = 102;
    private global::POGOProtos.Data.Quests.Quest.Types.Context questContext_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Quests.Quest.Types.Context QuestContext {
      get { return questContext_; }
      set {
        questContext_ = value;
      }
    }

    /// <summary>Field number for the "template_id" field.</summary>
    public const int TemplateIdFieldNumber = 103;
    private string templateId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TemplateId {
      get { return templateId_; }
      set {
        templateId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "progress" field.</summary>
    public const int ProgressFieldNumber = 104;
    private int progress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Progress {
      get { return progress_; }
      set {
        progress_ = value;
      }
    }

    /// <summary>Field number for the "goal" field.</summary>
    public const int GoalFieldNumber = 105;
    private global::POGOProtos.Data.Quests.QuestGoal goal_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Quests.QuestGoal Goal {
      get { return goal_; }
      set {
        goal_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 106;
    private global::POGOProtos.Data.Quests.Quest.Types.Status status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Quests.Quest.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "quest_rewards" field.</summary>
    public const int QuestRewardsFieldNumber = 107;
    private static readonly pb::FieldCodec<global::POGOProtos.Data.Quests.QuestReward> _repeated_questRewards_codec
        = pb::FieldCodec.ForMessage(858, global::POGOProtos.Data.Quests.QuestReward.Parser);
    private readonly pbc::RepeatedField<global::POGOProtos.Data.Quests.QuestReward> questRewards_ = new pbc::RepeatedField<global::POGOProtos.Data.Quests.QuestReward>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Data.Quests.QuestReward> QuestRewards {
      get { return questRewards_; }
    }

    /// <summary>Field number for the "creation_timestamp_ms" field.</summary>
    public const int CreationTimestampMsFieldNumber = 108;
    private long creationTimestampMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long CreationTimestampMs {
      get { return creationTimestampMs_; }
      set {
        creationTimestampMs_ = value;
      }
    }

    /// <summary>Field number for the "last_update_timestamp_ms" field.</summary>
    public const int LastUpdateTimestampMsFieldNumber = 109;
    private long lastUpdateTimestampMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long LastUpdateTimestampMs {
      get { return lastUpdateTimestampMs_; }
      set {
        lastUpdateTimestampMs_ = value;
      }
    }

    /// <summary>Field number for the "compeletion_timestamp_ms" field.</summary>
    public const int CompeletionTimestampMsFieldNumber = 110;
    private long compeletionTimestampMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long CompeletionTimestampMs {
      get { return compeletionTimestampMs_; }
      set {
        compeletionTimestampMs_ = value;
      }
    }

    /// <summary>Field number for the "fort_id" field.</summary>
    public const int FortIdFieldNumber = 111;
    private string fortId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FortId {
      get { return fortId_; }
      set {
        fortId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "admin_generated" field.</summary>
    public const int AdminGeneratedFieldNumber = 112;
    private bool adminGenerated_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool AdminGenerated {
      get { return adminGenerated_; }
      set {
        adminGenerated_ = value;
      }
    }

    /// <summary>Field number for the "stamp_count_override_enabled" field.</summary>
    public const int StampCountOverrideEnabledFieldNumber = 113;
    private bool stampCountOverrideEnabled_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool StampCountOverrideEnabled {
      get { return stampCountOverrideEnabled_; }
      set {
        stampCountOverrideEnabled_ = value;
      }
    }

    /// <summary>Field number for the "stamp_count_override" field.</summary>
    public const int StampCountOverrideFieldNumber = 114;
    private int stampCountOverride_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int StampCountOverride {
      get { return stampCountOverride_; }
      set {
        stampCountOverride_ = value;
      }
    }

    /// <summary>Field number for the "s2_cell_id" field.</summary>
    public const int S2CellIdFieldNumber = 115;
    private long s2CellId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long S2CellId {
      get { return s2CellId_; }
      set {
        s2CellId_ = value;
      }
    }

    /// <summary>Field number for the "story_quest_template_version" field.</summary>
    public const int StoryQuestTemplateVersionFieldNumber = 116;
    private int storyQuestTemplateVersion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int StoryQuestTemplateVersion {
      get { return storyQuestTemplateVersion_; }
      set {
        storyQuestTemplateVersion_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Quest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Quest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (QuestType != other.QuestType) return false;
      if (!object.Equals(DailyQuest, other.DailyQuest)) return false;
      if (!object.Equals(MultiPart, other.MultiPart)) return false;
      if (!object.Equals(CatchPokemon, other.CatchPokemon)) return false;
      if (!object.Equals(AddFriend, other.AddFriend)) return false;
      if (!object.Equals(TradePokemon, other.TradePokemon)) return false;
      if (QuestId != other.QuestId) return false;
      if (QuestSeed != other.QuestSeed) return false;
      if (QuestContext != other.QuestContext) return false;
      if (TemplateId != other.TemplateId) return false;
      if (Progress != other.Progress) return false;
      if (!object.Equals(Goal, other.Goal)) return false;
      if (Status != other.Status) return false;
      if(!questRewards_.Equals(other.questRewards_)) return false;
      if (CreationTimestampMs != other.CreationTimestampMs) return false;
      if (LastUpdateTimestampMs != other.LastUpdateTimestampMs) return false;
      if (CompeletionTimestampMs != other.CompeletionTimestampMs) return false;
      if (FortId != other.FortId) return false;
      if (AdminGenerated != other.AdminGenerated) return false;
      if (StampCountOverrideEnabled != other.StampCountOverrideEnabled) return false;
      if (StampCountOverride != other.StampCountOverride) return false;
      if (S2CellId != other.S2CellId) return false;
      if (StoryQuestTemplateVersion != other.StoryQuestTemplateVersion) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (QuestType != 0) hash ^= QuestType.GetHashCode();
      if (dailyQuest_ != null) hash ^= DailyQuest.GetHashCode();
      if (multiPart_ != null) hash ^= MultiPart.GetHashCode();
      if (catchPokemon_ != null) hash ^= CatchPokemon.GetHashCode();
      if (addFriend_ != null) hash ^= AddFriend.GetHashCode();
      if (tradePokemon_ != null) hash ^= TradePokemon.GetHashCode();
      if (QuestId.Length != 0) hash ^= QuestId.GetHashCode();
      if (QuestSeed != 0L) hash ^= QuestSeed.GetHashCode();
      if (QuestContext != 0) hash ^= QuestContext.GetHashCode();
      if (TemplateId.Length != 0) hash ^= TemplateId.GetHashCode();
      if (Progress != 0) hash ^= Progress.GetHashCode();
      if (goal_ != null) hash ^= Goal.GetHashCode();
      if (Status != 0) hash ^= Status.GetHashCode();
      hash ^= questRewards_.GetHashCode();
      if (CreationTimestampMs != 0L) hash ^= CreationTimestampMs.GetHashCode();
      if (LastUpdateTimestampMs != 0L) hash ^= LastUpdateTimestampMs.GetHashCode();
      if (CompeletionTimestampMs != 0L) hash ^= CompeletionTimestampMs.GetHashCode();
      if (FortId.Length != 0) hash ^= FortId.GetHashCode();
      if (AdminGenerated != false) hash ^= AdminGenerated.GetHashCode();
      if (StampCountOverrideEnabled != false) hash ^= StampCountOverrideEnabled.GetHashCode();
      if (StampCountOverride != 0) hash ^= StampCountOverride.GetHashCode();
      if (S2CellId != 0L) hash ^= S2CellId.GetHashCode();
      if (StoryQuestTemplateVersion != 0) hash ^= StoryQuestTemplateVersion.GetHashCode();
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
      if (QuestType != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) QuestType);
      }
      if (dailyQuest_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(DailyQuest);
      }
      if (multiPart_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(MultiPart);
      }
      if (catchPokemon_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(CatchPokemon);
      }
      if (addFriend_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(AddFriend);
      }
      if (tradePokemon_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(TradePokemon);
      }
      if (QuestId.Length != 0) {
        output.WriteRawTag(162, 6);
        output.WriteString(QuestId);
      }
      if (QuestSeed != 0L) {
        output.WriteRawTag(168, 6);
        output.WriteInt64(QuestSeed);
      }
      if (QuestContext != 0) {
        output.WriteRawTag(176, 6);
        output.WriteEnum((int) QuestContext);
      }
      if (TemplateId.Length != 0) {
        output.WriteRawTag(186, 6);
        output.WriteString(TemplateId);
      }
      if (Progress != 0) {
        output.WriteRawTag(192, 6);
        output.WriteInt32(Progress);
      }
      if (goal_ != null) {
        output.WriteRawTag(202, 6);
        output.WriteMessage(Goal);
      }
      if (Status != 0) {
        output.WriteRawTag(208, 6);
        output.WriteEnum((int) Status);
      }
      questRewards_.WriteTo(output, _repeated_questRewards_codec);
      if (CreationTimestampMs != 0L) {
        output.WriteRawTag(224, 6);
        output.WriteInt64(CreationTimestampMs);
      }
      if (LastUpdateTimestampMs != 0L) {
        output.WriteRawTag(232, 6);
        output.WriteInt64(LastUpdateTimestampMs);
      }
      if (CompeletionTimestampMs != 0L) {
        output.WriteRawTag(240, 6);
        output.WriteInt64(CompeletionTimestampMs);
      }
      if (FortId.Length != 0) {
        output.WriteRawTag(250, 6);
        output.WriteString(FortId);
      }
      if (AdminGenerated != false) {
        output.WriteRawTag(128, 7);
        output.WriteBool(AdminGenerated);
      }
      if (StampCountOverrideEnabled != false) {
        output.WriteRawTag(136, 7);
        output.WriteBool(StampCountOverrideEnabled);
      }
      if (StampCountOverride != 0) {
        output.WriteRawTag(144, 7);
        output.WriteInt32(StampCountOverride);
      }
      if (S2CellId != 0L) {
        output.WriteRawTag(152, 7);
        output.WriteInt64(S2CellId);
      }
      if (StoryQuestTemplateVersion != 0) {
        output.WriteRawTag(160, 7);
        output.WriteInt32(StoryQuestTemplateVersion);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (QuestType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) QuestType);
      }
      if (dailyQuest_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DailyQuest);
      }
      if (multiPart_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MultiPart);
      }
      if (catchPokemon_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CatchPokemon);
      }
      if (addFriend_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AddFriend);
      }
      if (tradePokemon_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TradePokemon);
      }
      if (QuestId.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(QuestId);
      }
      if (QuestSeed != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(QuestSeed);
      }
      if (QuestContext != 0) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) QuestContext);
      }
      if (TemplateId.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(TemplateId);
      }
      if (Progress != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(Progress);
      }
      if (goal_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(Goal);
      }
      if (Status != 0) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      size += questRewards_.CalculateSize(_repeated_questRewards_codec);
      if (CreationTimestampMs != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(CreationTimestampMs);
      }
      if (LastUpdateTimestampMs != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(LastUpdateTimestampMs);
      }
      if (CompeletionTimestampMs != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(CompeletionTimestampMs);
      }
      if (FortId.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(FortId);
      }
      if (AdminGenerated != false) {
        size += 2 + 1;
      }
      if (StampCountOverrideEnabled != false) {
        size += 2 + 1;
      }
      if (StampCountOverride != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(StampCountOverride);
      }
      if (S2CellId != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(S2CellId);
      }
      if (StoryQuestTemplateVersion != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(StoryQuestTemplateVersion);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Quest other) {
      if (other == null) {
        return;
      }
      if (other.QuestType != 0) {
        QuestType = other.QuestType;
      }
      if (other.dailyQuest_ != null) {
        if (dailyQuest_ == null) {
          dailyQuest_ = new global::POGOProtos.Data.Quests.DailyQuest();
        }
        DailyQuest.MergeFrom(other.DailyQuest);
      }
      if (other.multiPart_ != null) {
        if (multiPart_ == null) {
          multiPart_ = new global::POGOProtos.Data.Quests.Quest.Types.MultiPartQuest();
        }
        MultiPart.MergeFrom(other.MultiPart);
      }
      if (other.catchPokemon_ != null) {
        if (catchPokemon_ == null) {
          catchPokemon_ = new global::POGOProtos.Data.Quests.CatchPokemonQuest();
        }
        CatchPokemon.MergeFrom(other.CatchPokemon);
      }
      if (other.addFriend_ != null) {
        if (addFriend_ == null) {
          addFriend_ = new global::POGOProtos.Data.Quests.AddFriendQuest();
        }
        AddFriend.MergeFrom(other.AddFriend);
      }
      if (other.tradePokemon_ != null) {
        if (tradePokemon_ == null) {
          tradePokemon_ = new global::POGOProtos.Data.Quests.TradePokemonQuest();
        }
        TradePokemon.MergeFrom(other.TradePokemon);
      }
      if (other.QuestId.Length != 0) {
        QuestId = other.QuestId;
      }
      if (other.QuestSeed != 0L) {
        QuestSeed = other.QuestSeed;
      }
      if (other.QuestContext != 0) {
        QuestContext = other.QuestContext;
      }
      if (other.TemplateId.Length != 0) {
        TemplateId = other.TemplateId;
      }
      if (other.Progress != 0) {
        Progress = other.Progress;
      }
      if (other.goal_ != null) {
        if (goal_ == null) {
          goal_ = new global::POGOProtos.Data.Quests.QuestGoal();
        }
        Goal.MergeFrom(other.Goal);
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      questRewards_.Add(other.questRewards_);
      if (other.CreationTimestampMs != 0L) {
        CreationTimestampMs = other.CreationTimestampMs;
      }
      if (other.LastUpdateTimestampMs != 0L) {
        LastUpdateTimestampMs = other.LastUpdateTimestampMs;
      }
      if (other.CompeletionTimestampMs != 0L) {
        CompeletionTimestampMs = other.CompeletionTimestampMs;
      }
      if (other.FortId.Length != 0) {
        FortId = other.FortId;
      }
      if (other.AdminGenerated != false) {
        AdminGenerated = other.AdminGenerated;
      }
      if (other.StampCountOverrideEnabled != false) {
        StampCountOverrideEnabled = other.StampCountOverrideEnabled;
      }
      if (other.StampCountOverride != 0) {
        StampCountOverride = other.StampCountOverride;
      }
      if (other.S2CellId != 0L) {
        S2CellId = other.S2CellId;
      }
      if (other.StoryQuestTemplateVersion != 0) {
        StoryQuestTemplateVersion = other.StoryQuestTemplateVersion;
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
            questType_ = (global::POGOProtos.Enums.QuestType) input.ReadEnum();
            break;
          }
          case 18: {
            if (dailyQuest_ == null) {
              dailyQuest_ = new global::POGOProtos.Data.Quests.DailyQuest();
            }
            input.ReadMessage(dailyQuest_);
            break;
          }
          case 26: {
            if (multiPart_ == null) {
              multiPart_ = new global::POGOProtos.Data.Quests.Quest.Types.MultiPartQuest();
            }
            input.ReadMessage(multiPart_);
            break;
          }
          case 34: {
            if (catchPokemon_ == null) {
              catchPokemon_ = new global::POGOProtos.Data.Quests.CatchPokemonQuest();
            }
            input.ReadMessage(catchPokemon_);
            break;
          }
          case 42: {
            if (addFriend_ == null) {
              addFriend_ = new global::POGOProtos.Data.Quests.AddFriendQuest();
            }
            input.ReadMessage(addFriend_);
            break;
          }
          case 50: {
            if (tradePokemon_ == null) {
              tradePokemon_ = new global::POGOProtos.Data.Quests.TradePokemonQuest();
            }
            input.ReadMessage(tradePokemon_);
            break;
          }
          case 802: {
            QuestId = input.ReadString();
            break;
          }
          case 808: {
            QuestSeed = input.ReadInt64();
            break;
          }
          case 816: {
            questContext_ = (global::POGOProtos.Data.Quests.Quest.Types.Context) input.ReadEnum();
            break;
          }
          case 826: {
            TemplateId = input.ReadString();
            break;
          }
          case 832: {
            Progress = input.ReadInt32();
            break;
          }
          case 842: {
            if (goal_ == null) {
              goal_ = new global::POGOProtos.Data.Quests.QuestGoal();
            }
            input.ReadMessage(goal_);
            break;
          }
          case 848: {
            status_ = (global::POGOProtos.Data.Quests.Quest.Types.Status) input.ReadEnum();
            break;
          }
          case 858: {
            questRewards_.AddEntriesFrom(input, _repeated_questRewards_codec);
            break;
          }
          case 864: {
            CreationTimestampMs = input.ReadInt64();
            break;
          }
          case 872: {
            LastUpdateTimestampMs = input.ReadInt64();
            break;
          }
          case 880: {
            CompeletionTimestampMs = input.ReadInt64();
            break;
          }
          case 890: {
            FortId = input.ReadString();
            break;
          }
          case 896: {
            AdminGenerated = input.ReadBool();
            break;
          }
          case 904: {
            StampCountOverrideEnabled = input.ReadBool();
            break;
          }
          case 912: {
            StampCountOverride = input.ReadInt32();
            break;
          }
          case 920: {
            S2CellId = input.ReadInt64();
            break;
          }
          case 928: {
            StoryQuestTemplateVersion = input.ReadInt32();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Quest message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Context {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("STORY_QUEST")] StoryQuest = 1,
        [pbr::OriginalName("CHALLENGE_QUEST")] ChallengeQuest = 2,
      }

      public enum Status {
        [pbr::OriginalName("STATUS_UNDEFINED")] Undefined = 0,
        [pbr::OriginalName("STATUS_ACTIVE")] Active = 1,
        [pbr::OriginalName("STATUS_COMPLETED")] Completed = 2,
      }

      public sealed partial class MultiPartQuest : pb::IMessage<MultiPartQuest> {
        private static readonly pb::MessageParser<MultiPartQuest> _parser = new pb::MessageParser<MultiPartQuest>(() => new MultiPartQuest());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<MultiPartQuest> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::POGOProtos.Data.Quests.Quest.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public MultiPartQuest() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public MultiPartQuest(MultiPartQuest other) : this() {
          subQuests_ = other.subQuests_.Clone();
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public MultiPartQuest Clone() {
          return new MultiPartQuest(this);
        }

        /// <summary>Field number for the "sub_quests" field.</summary>
        public const int SubQuestsFieldNumber = 1;
        private static readonly pb::FieldCodec<global::POGOProtos.Data.Quests.Quest> _repeated_subQuests_codec
            = pb::FieldCodec.ForMessage(10, global::POGOProtos.Data.Quests.Quest.Parser);
        private readonly pbc::RepeatedField<global::POGOProtos.Data.Quests.Quest> subQuests_ = new pbc::RepeatedField<global::POGOProtos.Data.Quests.Quest>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<global::POGOProtos.Data.Quests.Quest> SubQuests {
          get { return subQuests_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as MultiPartQuest);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(MultiPartQuest other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if(!subQuests_.Equals(other.subQuests_)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          hash ^= subQuests_.GetHashCode();
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
          subQuests_.WriteTo(output, _repeated_subQuests_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          size += subQuests_.CalculateSize(_repeated_subQuests_codec);
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(MultiPartQuest other) {
          if (other == null) {
            return;
          }
          subQuests_.Add(other.subQuests_);
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
                subQuests_.AddEntriesFrom(input, _repeated_subQuests_codec);
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
