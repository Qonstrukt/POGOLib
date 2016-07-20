// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Map/Fort/FortData.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Map.Fort {

  /// <summary>Holder for reflection information generated from Map/Fort/FortData.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class FortDataReflection {

    #region Descriptor
    /// <summary>File descriptor for Map/Fort/FortData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FortDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdNYXAvRm9ydC9Gb3J0RGF0YS5wcm90bxITUE9HT1Byb3Rvcy5NYXAuRm9y",
            "dBoXRW51bXMvUG9rZW1vblR5cGUucHJvdG8aFUVudW1zL1RlYW1Db2xvci5w",
            "cm90bxoXTWFwL0ZvcnQvRm9ydFR5cGUucHJvdG8aGk1hcC9Gb3J0L0ZvcnRT",
            "cG9uc29yLnByb3RvGiBNYXAvRm9ydC9Gb3J0UmVuZGVyaW5nVHlwZS5wcm90",
            "bxobTWFwL0ZvcnQvRm9ydEx1cmVJbmZvLnByb3RvIsIECghGb3J0RGF0YRIK",
            "CgJpZBgBIAEoCRIiChpsYXN0X21vZGlmaWVkX3RpbWVzdGFtcF9tcxgCIAEo",
            "AxIQCghsYXRpdHVkZRgDIAEoARIRCglsb25naXR1ZGUYBCABKAESDwoHZW5h",
            "YmxlZBgIIAEoCBIrCgR0eXBlGAkgASgOMh0uUE9HT1Byb3Rvcy5NYXAuRm9y",
            "dC5Gb3J0VHlwZRIyCg1vd25lZF9ieV90ZWFtGAUgASgOMhsuUE9HT1Byb3Rv",
            "cy5FbnVtcy5UZWFtQ29sb3ISOQoSZ3VhcmRfcG9rZW1vbl90eXBlGAYgASgO",
            "Mh0uUE9HT1Byb3Rvcy5FbnVtcy5Qb2tlbW9uVHlwZRIbChNndWFyZF9wb2tl",
            "bW9uX2xldmVsGAcgASgFEhIKCmd5bV9wb2ludHMYCiABKAMSFAoMaXNfaW5f",
            "YmF0dGxlGAsgASgIEiYKHmNvb2xkb3duX2NvbXBsZXRlX3RpbWVzdGFtcF9t",
            "cxgOIAEoAxIxCgdzcG9uc29yGA8gASgOMiAuUE9HT1Byb3Rvcy5NYXAuRm9y",
            "dC5Gb3J0U3BvbnNvchI+Cg5yZW5kZXJpbmdfdHlwZRgQIAEoDjImLlBPR09Q",
            "cm90b3MuTWFwLkZvcnQuRm9ydFJlbmRlcmluZ1R5cGUSHAoUYWN0aXZlX2Zv",
            "cnRfbW9kaWZpZXIYDCABKAwSNAoJbHVyZV9pbmZvGA0gASgLMiEuUE9HT1By",
            "b3Rvcy5NYXAuRm9ydC5Gb3J0THVyZUluZm9QAFABUAJQA1AEUAViBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Enums.PokemonTypeReflection.Descriptor, global::POGOProtos.Enums.TeamColorReflection.Descriptor, global::POGOProtos.Map.Fort.FortTypeReflection.Descriptor, global::POGOProtos.Map.Fort.FortSponsorReflection.Descriptor, global::POGOProtos.Map.Fort.FortRenderingTypeReflection.Descriptor, global::POGOProtos.Map.Fort.FortLureInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Map.Fort.FortData), global::POGOProtos.Map.Fort.FortData.Parser, new[]{ "Id", "LastModifiedTimestampMs", "Latitude", "Longitude", "Enabled", "Type", "OwnedByTeam", "GuardPokemonType", "GuardPokemonLevel", "GymPoints", "IsInBattle", "CooldownCompleteTimestampMs", "Sponsor", "RenderingType", "ActiveFortModifier", "LureInfo" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class FortData : pb::IMessage<FortData> {
    private static readonly pb::MessageParser<FortData> _parser = new pb::MessageParser<FortData>(() => new FortData());
    public static pb::MessageParser<FortData> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Map.Fort.FortDataReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public FortData() {
      OnConstruction();
    }

    partial void OnConstruction();

    public FortData(FortData other) : this() {
      id_ = other.id_;
      lastModifiedTimestampMs_ = other.lastModifiedTimestampMs_;
      latitude_ = other.latitude_;
      longitude_ = other.longitude_;
      enabled_ = other.enabled_;
      type_ = other.type_;
      ownedByTeam_ = other.ownedByTeam_;
      guardPokemonType_ = other.guardPokemonType_;
      guardPokemonLevel_ = other.guardPokemonLevel_;
      gymPoints_ = other.gymPoints_;
      isInBattle_ = other.isInBattle_;
      cooldownCompleteTimestampMs_ = other.cooldownCompleteTimestampMs_;
      sponsor_ = other.sponsor_;
      renderingType_ = other.renderingType_;
      activeFortModifier_ = other.activeFortModifier_;
      LureInfo = other.lureInfo_ != null ? other.LureInfo.Clone() : null;
    }

    public FortData Clone() {
      return new FortData(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "last_modified_timestamp_ms" field.</summary>
    public const int LastModifiedTimestampMsFieldNumber = 2;
    private long lastModifiedTimestampMs_;
    public long LastModifiedTimestampMs {
      get { return lastModifiedTimestampMs_; }
      set {
        lastModifiedTimestampMs_ = value;
      }
    }

    /// <summary>Field number for the "latitude" field.</summary>
    public const int LatitudeFieldNumber = 3;
    private double latitude_;
    public double Latitude {
      get { return latitude_; }
      set {
        latitude_ = value;
      }
    }

    /// <summary>Field number for the "longitude" field.</summary>
    public const int LongitudeFieldNumber = 4;
    private double longitude_;
    public double Longitude {
      get { return longitude_; }
      set {
        longitude_ = value;
      }
    }

    /// <summary>Field number for the "enabled" field.</summary>
    public const int EnabledFieldNumber = 8;
    private bool enabled_;
    public bool Enabled {
      get { return enabled_; }
      set {
        enabled_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 9;
    private global::POGOProtos.Map.Fort.FortType type_ = 0;
    public global::POGOProtos.Map.Fort.FortType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "owned_by_team" field.</summary>
    public const int OwnedByTeamFieldNumber = 5;
    private global::POGOProtos.Enums.TeamColor ownedByTeam_ = 0;
    /// <summary>
    ///  Team that owns the gym
    /// </summary>
    public global::POGOProtos.Enums.TeamColor OwnedByTeam {
      get { return ownedByTeam_; }
      set {
        ownedByTeam_ = value;
      }
    }

    /// <summary>Field number for the "guard_pokemon_type" field.</summary>
    public const int GuardPokemonTypeFieldNumber = 6;
    private global::POGOProtos.Enums.PokemonType guardPokemonType_ = 0;
    /// <summary>
    ///  Highest CP Pokemon at the gym
    /// </summary>
    public global::POGOProtos.Enums.PokemonType GuardPokemonType {
      get { return guardPokemonType_; }
      set {
        guardPokemonType_ = value;
      }
    }

    /// <summary>Field number for the "guard_pokemon_level" field.</summary>
    public const int GuardPokemonLevelFieldNumber = 7;
    private int guardPokemonLevel_;
    public int GuardPokemonLevel {
      get { return guardPokemonLevel_; }
      set {
        guardPokemonLevel_ = value;
      }
    }

    /// <summary>Field number for the "gym_points" field.</summary>
    public const int GymPointsFieldNumber = 10;
    private long gymPoints_;
    /// <summary>
    ///  Prestigate / experience of the gym
    /// </summary>
    public long GymPoints {
      get { return gymPoints_; }
      set {
        gymPoints_ = value;
      }
    }

    /// <summary>Field number for the "is_in_battle" field.</summary>
    public const int IsInBattleFieldNumber = 11;
    private bool isInBattle_;
    /// <summary>
    ///  Whether someone is battling at the gym currently
    /// </summary>
    public bool IsInBattle {
      get { return isInBattle_; }
      set {
        isInBattle_ = value;
      }
    }

    /// <summary>Field number for the "cooldown_complete_timestamp_ms" field.</summary>
    public const int CooldownCompleteTimestampMsFieldNumber = 14;
    private long cooldownCompleteTimestampMs_;
    /// <summary>
    ///  Timestamp when the pokestop can be activated again to get items / xp
    /// </summary>
    public long CooldownCompleteTimestampMs {
      get { return cooldownCompleteTimestampMs_; }
      set {
        cooldownCompleteTimestampMs_ = value;
      }
    }

    /// <summary>Field number for the "sponsor" field.</summary>
    public const int SponsorFieldNumber = 15;
    private global::POGOProtos.Map.Fort.FortSponsor sponsor_ = 0;
    public global::POGOProtos.Map.Fort.FortSponsor Sponsor {
      get { return sponsor_; }
      set {
        sponsor_ = value;
      }
    }

    /// <summary>Field number for the "rendering_type" field.</summary>
    public const int RenderingTypeFieldNumber = 16;
    private global::POGOProtos.Map.Fort.FortRenderingType renderingType_ = 0;
    public global::POGOProtos.Map.Fort.FortRenderingType RenderingType {
      get { return renderingType_; }
      set {
        renderingType_ = value;
      }
    }

    /// <summary>Field number for the "active_fort_modifier" field.</summary>
    public const int ActiveFortModifierFieldNumber = 12;
    private pb::ByteString activeFortModifier_ = pb::ByteString.Empty;
    /// <summary>
    ///  Might represent the type of item applied to the pokestop, right now only lures can be applied
    /// </summary>
    public pb::ByteString ActiveFortModifier {
      get { return activeFortModifier_; }
      set {
        activeFortModifier_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "lure_info" field.</summary>
    public const int LureInfoFieldNumber = 13;
    private global::POGOProtos.Map.Fort.FortLureInfo lureInfo_;
    public global::POGOProtos.Map.Fort.FortLureInfo LureInfo {
      get { return lureInfo_; }
      set {
        lureInfo_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as FortData);
    }

    public bool Equals(FortData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (LastModifiedTimestampMs != other.LastModifiedTimestampMs) return false;
      if (Latitude != other.Latitude) return false;
      if (Longitude != other.Longitude) return false;
      if (Enabled != other.Enabled) return false;
      if (Type != other.Type) return false;
      if (OwnedByTeam != other.OwnedByTeam) return false;
      if (GuardPokemonType != other.GuardPokemonType) return false;
      if (GuardPokemonLevel != other.GuardPokemonLevel) return false;
      if (GymPoints != other.GymPoints) return false;
      if (IsInBattle != other.IsInBattle) return false;
      if (CooldownCompleteTimestampMs != other.CooldownCompleteTimestampMs) return false;
      if (Sponsor != other.Sponsor) return false;
      if (RenderingType != other.RenderingType) return false;
      if (ActiveFortModifier != other.ActiveFortModifier) return false;
      if (!object.Equals(LureInfo, other.LureInfo)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (LastModifiedTimestampMs != 0L) hash ^= LastModifiedTimestampMs.GetHashCode();
      if (Latitude != 0D) hash ^= Latitude.GetHashCode();
      if (Longitude != 0D) hash ^= Longitude.GetHashCode();
      if (Enabled != false) hash ^= Enabled.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
      if (OwnedByTeam != 0) hash ^= OwnedByTeam.GetHashCode();
      if (GuardPokemonType != 0) hash ^= GuardPokemonType.GetHashCode();
      if (GuardPokemonLevel != 0) hash ^= GuardPokemonLevel.GetHashCode();
      if (GymPoints != 0L) hash ^= GymPoints.GetHashCode();
      if (IsInBattle != false) hash ^= IsInBattle.GetHashCode();
      if (CooldownCompleteTimestampMs != 0L) hash ^= CooldownCompleteTimestampMs.GetHashCode();
      if (Sponsor != 0) hash ^= Sponsor.GetHashCode();
      if (RenderingType != 0) hash ^= RenderingType.GetHashCode();
      if (ActiveFortModifier.Length != 0) hash ^= ActiveFortModifier.GetHashCode();
      if (lureInfo_ != null) hash ^= LureInfo.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (LastModifiedTimestampMs != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(LastModifiedTimestampMs);
      }
      if (Latitude != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(Latitude);
      }
      if (Longitude != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Longitude);
      }
      if (OwnedByTeam != 0) {
        output.WriteRawTag(40);
        output.WriteEnum((int) OwnedByTeam);
      }
      if (GuardPokemonType != 0) {
        output.WriteRawTag(48);
        output.WriteEnum((int) GuardPokemonType);
      }
      if (GuardPokemonLevel != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(GuardPokemonLevel);
      }
      if (Enabled != false) {
        output.WriteRawTag(64);
        output.WriteBool(Enabled);
      }
      if (Type != 0) {
        output.WriteRawTag(72);
        output.WriteEnum((int) Type);
      }
      if (GymPoints != 0L) {
        output.WriteRawTag(80);
        output.WriteInt64(GymPoints);
      }
      if (IsInBattle != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsInBattle);
      }
      if (ActiveFortModifier.Length != 0) {
        output.WriteRawTag(98);
        output.WriteBytes(ActiveFortModifier);
      }
      if (lureInfo_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(LureInfo);
      }
      if (CooldownCompleteTimestampMs != 0L) {
        output.WriteRawTag(112);
        output.WriteInt64(CooldownCompleteTimestampMs);
      }
      if (Sponsor != 0) {
        output.WriteRawTag(120);
        output.WriteEnum((int) Sponsor);
      }
      if (RenderingType != 0) {
        output.WriteRawTag(128, 1);
        output.WriteEnum((int) RenderingType);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (LastModifiedTimestampMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(LastModifiedTimestampMs);
      }
      if (Latitude != 0D) {
        size += 1 + 8;
      }
      if (Longitude != 0D) {
        size += 1 + 8;
      }
      if (Enabled != false) {
        size += 1 + 1;
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (OwnedByTeam != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OwnedByTeam);
      }
      if (GuardPokemonType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) GuardPokemonType);
      }
      if (GuardPokemonLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(GuardPokemonLevel);
      }
      if (GymPoints != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(GymPoints);
      }
      if (IsInBattle != false) {
        size += 1 + 1;
      }
      if (CooldownCompleteTimestampMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CooldownCompleteTimestampMs);
      }
      if (Sponsor != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Sponsor);
      }
      if (RenderingType != 0) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) RenderingType);
      }
      if (ActiveFortModifier.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(ActiveFortModifier);
      }
      if (lureInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LureInfo);
      }
      return size;
    }

    public void MergeFrom(FortData other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.LastModifiedTimestampMs != 0L) {
        LastModifiedTimestampMs = other.LastModifiedTimestampMs;
      }
      if (other.Latitude != 0D) {
        Latitude = other.Latitude;
      }
      if (other.Longitude != 0D) {
        Longitude = other.Longitude;
      }
      if (other.Enabled != false) {
        Enabled = other.Enabled;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.OwnedByTeam != 0) {
        OwnedByTeam = other.OwnedByTeam;
      }
      if (other.GuardPokemonType != 0) {
        GuardPokemonType = other.GuardPokemonType;
      }
      if (other.GuardPokemonLevel != 0) {
        GuardPokemonLevel = other.GuardPokemonLevel;
      }
      if (other.GymPoints != 0L) {
        GymPoints = other.GymPoints;
      }
      if (other.IsInBattle != false) {
        IsInBattle = other.IsInBattle;
      }
      if (other.CooldownCompleteTimestampMs != 0L) {
        CooldownCompleteTimestampMs = other.CooldownCompleteTimestampMs;
      }
      if (other.Sponsor != 0) {
        Sponsor = other.Sponsor;
      }
      if (other.RenderingType != 0) {
        RenderingType = other.RenderingType;
      }
      if (other.ActiveFortModifier.Length != 0) {
        ActiveFortModifier = other.ActiveFortModifier;
      }
      if (other.lureInfo_ != null) {
        if (lureInfo_ == null) {
          lureInfo_ = new global::POGOProtos.Map.Fort.FortLureInfo();
        }
        LureInfo.MergeFrom(other.LureInfo);
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 16: {
            LastModifiedTimestampMs = input.ReadInt64();
            break;
          }
          case 25: {
            Latitude = input.ReadDouble();
            break;
          }
          case 33: {
            Longitude = input.ReadDouble();
            break;
          }
          case 40: {
            ownedByTeam_ = (global::POGOProtos.Enums.TeamColor) input.ReadEnum();
            break;
          }
          case 48: {
            guardPokemonType_ = (global::POGOProtos.Enums.PokemonType) input.ReadEnum();
            break;
          }
          case 56: {
            GuardPokemonLevel = input.ReadInt32();
            break;
          }
          case 64: {
            Enabled = input.ReadBool();
            break;
          }
          case 72: {
            type_ = (global::POGOProtos.Map.Fort.FortType) input.ReadEnum();
            break;
          }
          case 80: {
            GymPoints = input.ReadInt64();
            break;
          }
          case 88: {
            IsInBattle = input.ReadBool();
            break;
          }
          case 98: {
            ActiveFortModifier = input.ReadBytes();
            break;
          }
          case 106: {
            if (lureInfo_ == null) {
              lureInfo_ = new global::POGOProtos.Map.Fort.FortLureInfo();
            }
            input.ReadMessage(lureInfo_);
            break;
          }
          case 112: {
            CooldownCompleteTimestampMs = input.ReadInt64();
            break;
          }
          case 120: {
            sponsor_ = (global::POGOProtos.Map.Fort.FortSponsor) input.ReadEnum();
            break;
          }
          case 128: {
            renderingType_ = (global::POGOProtos.Map.Fort.FortRenderingType) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code