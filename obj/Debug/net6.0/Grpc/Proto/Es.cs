// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Grpc/Proto/es.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace RecycleCoin.Grpc {

  /// <summary>Holder for reflection information generated from Grpc/Proto/es.proto</summary>
  public static partial class EsReflection {

    #region Descriptor
    /// <summary>File descriptor for Grpc/Proto/es.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNHcnBjL1Byb3RvL2VzLnByb3RvGhtnb29nbGUvcHJvdG9idWYvZW1wdHku",
            "cHJvdG8iMQoHRXNJc3RlaxIPCgJlcxgBIAEoCzIDLkVzEhUKDWR1Z3VtSXBB",
            "ZHJlc2kYAiABKAkiqwEKB0VzRHVydW0SDQoFZHVydW0YASABKAgSDQoFbWVz",
            "YWoYAiABKAkSDwoCZXMYAyABKAsyAy5FcxISCgVlc2xlchgEIAMoCzIDLkVz",
            "Eg0KBWthcm1hGAUgASgJEhEKCXl1a3Nla2xpaxgGIAEoAxIaCg1iaWxpbmVu",
            "X2VzbGVyGAcgAygLMgMuRXMSDQoFYWRyZXMYCCABKAkSEAoIdmVyc2l5b24Y",
            "CSABKAUidwoCRXMSCgoCSWQYASABKAUSDQoFYWRyZXMYAiABKAkSEgoKc29u",
            "X2VyaXNpbRgDIAEoAxISCgpvbnl1a2x1X211GAQgASgIEhcKD2VyaXNpbGVi",
            "aWxpcl9taRgFIAEoCBIVCg16YW1hbl9kYW1nYXNpGAYgASgDMoABCghFc1Nl",
            "cnZpcxIaCgRFa2xlEgguRXNJc3RlaxoILkVzRHVydW0SMAoMSGVwc2luaUdl",
            "dGlyEhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5GgguRXNEdXJ1bRImChBEdWd1",
            "bUR1cnVtdUdldGlyEgguRXNJc3RlaxoILkVzRHVydW1CE6oCEFJlY3ljbGVD",
            "b2luLkdycGNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::RecycleCoin.Grpc.EsIstek), global::RecycleCoin.Grpc.EsIstek.Parser, new[]{ "Es", "DugumIpAdresi" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::RecycleCoin.Grpc.EsDurum), global::RecycleCoin.Grpc.EsDurum.Parser, new[]{ "Durum", "Mesaj", "Es", "Esler", "Karma", "Yukseklik", "BilinenEsler", "Adres", "Versiyon" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::RecycleCoin.Grpc.Es), global::RecycleCoin.Grpc.Es.Parser, new[]{ "Id", "Adres", "SonErisim", "OnyukluMu", "ErisilebilirMi", "ZamanDamgasi" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EsIstek : pb::IMessage<EsIstek>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EsIstek> _parser = new pb::MessageParser<EsIstek>(() => new EsIstek());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EsIstek> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::RecycleCoin.Grpc.EsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EsIstek() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EsIstek(EsIstek other) : this() {
      es_ = other.es_ != null ? other.es_.Clone() : null;
      dugumIpAdresi_ = other.dugumIpAdresi_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EsIstek Clone() {
      return new EsIstek(this);
    }

    /// <summary>Field number for the "es" field.</summary>
    public const int EsFieldNumber = 1;
    private global::RecycleCoin.Grpc.Es es_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::RecycleCoin.Grpc.Es Es {
      get { return es_; }
      set {
        es_ = value;
      }
    }

    /// <summary>Field number for the "dugumIpAdresi" field.</summary>
    public const int DugumIpAdresiFieldNumber = 2;
    private string dugumIpAdresi_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DugumIpAdresi {
      get { return dugumIpAdresi_; }
      set {
        dugumIpAdresi_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EsIstek);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EsIstek other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Es, other.Es)) return false;
      if (DugumIpAdresi != other.DugumIpAdresi) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (es_ != null) hash ^= Es.GetHashCode();
      if (DugumIpAdresi.Length != 0) hash ^= DugumIpAdresi.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (es_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Es);
      }
      if (DugumIpAdresi.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DugumIpAdresi);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (es_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Es);
      }
      if (DugumIpAdresi.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DugumIpAdresi);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (es_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Es);
      }
      if (DugumIpAdresi.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DugumIpAdresi);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EsIstek other) {
      if (other == null) {
        return;
      }
      if (other.es_ != null) {
        if (es_ == null) {
          Es = new global::RecycleCoin.Grpc.Es();
        }
        Es.MergeFrom(other.Es);
      }
      if (other.DugumIpAdresi.Length != 0) {
        DugumIpAdresi = other.DugumIpAdresi;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (es_ == null) {
              Es = new global::RecycleCoin.Grpc.Es();
            }
            input.ReadMessage(Es);
            break;
          }
          case 18: {
            DugumIpAdresi = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (es_ == null) {
              Es = new global::RecycleCoin.Grpc.Es();
            }
            input.ReadMessage(Es);
            break;
          }
          case 18: {
            DugumIpAdresi = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class EsDurum : pb::IMessage<EsDurum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EsDurum> _parser = new pb::MessageParser<EsDurum>(() => new EsDurum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EsDurum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::RecycleCoin.Grpc.EsReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EsDurum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EsDurum(EsDurum other) : this() {
      durum_ = other.durum_;
      mesaj_ = other.mesaj_;
      es_ = other.es_ != null ? other.es_.Clone() : null;
      esler_ = other.esler_.Clone();
      karma_ = other.karma_;
      yukseklik_ = other.yukseklik_;
      bilinenEsler_ = other.bilinenEsler_.Clone();
      adres_ = other.adres_;
      versiyon_ = other.versiyon_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EsDurum Clone() {
      return new EsDurum(this);
    }

    /// <summary>Field number for the "durum" field.</summary>
    public const int DurumFieldNumber = 1;
    private bool durum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Durum {
      get { return durum_; }
      set {
        durum_ = value;
      }
    }

    /// <summary>Field number for the "mesaj" field.</summary>
    public const int MesajFieldNumber = 2;
    private string mesaj_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Mesaj {
      get { return mesaj_; }
      set {
        mesaj_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "es" field.</summary>
    public const int EsFieldNumber = 3;
    private global::RecycleCoin.Grpc.Es es_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::RecycleCoin.Grpc.Es Es {
      get { return es_; }
      set {
        es_ = value;
      }
    }

    /// <summary>Field number for the "esler" field.</summary>
    public const int EslerFieldNumber = 4;
    private static readonly pb::FieldCodec<global::RecycleCoin.Grpc.Es> _repeated_esler_codec
        = pb::FieldCodec.ForMessage(34, global::RecycleCoin.Grpc.Es.Parser);
    private readonly pbc::RepeatedField<global::RecycleCoin.Grpc.Es> esler_ = new pbc::RepeatedField<global::RecycleCoin.Grpc.Es>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::RecycleCoin.Grpc.Es> Esler {
      get { return esler_; }
    }

    /// <summary>Field number for the "karma" field.</summary>
    public const int KarmaFieldNumber = 5;
    private string karma_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Karma {
      get { return karma_; }
      set {
        karma_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "yukseklik" field.</summary>
    public const int YukseklikFieldNumber = 6;
    private long yukseklik_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Yukseklik {
      get { return yukseklik_; }
      set {
        yukseklik_ = value;
      }
    }

    /// <summary>Field number for the "bilinen_esler" field.</summary>
    public const int BilinenEslerFieldNumber = 7;
    private static readonly pb::FieldCodec<global::RecycleCoin.Grpc.Es> _repeated_bilinenEsler_codec
        = pb::FieldCodec.ForMessage(58, global::RecycleCoin.Grpc.Es.Parser);
    private readonly pbc::RepeatedField<global::RecycleCoin.Grpc.Es> bilinenEsler_ = new pbc::RepeatedField<global::RecycleCoin.Grpc.Es>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::RecycleCoin.Grpc.Es> BilinenEsler {
      get { return bilinenEsler_; }
    }

    /// <summary>Field number for the "adres" field.</summary>
    public const int AdresFieldNumber = 8;
    private string adres_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Adres {
      get { return adres_; }
      set {
        adres_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "versiyon" field.</summary>
    public const int VersiyonFieldNumber = 9;
    private int versiyon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Versiyon {
      get { return versiyon_; }
      set {
        versiyon_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EsDurum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EsDurum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Durum != other.Durum) return false;
      if (Mesaj != other.Mesaj) return false;
      if (!object.Equals(Es, other.Es)) return false;
      if(!esler_.Equals(other.esler_)) return false;
      if (Karma != other.Karma) return false;
      if (Yukseklik != other.Yukseklik) return false;
      if(!bilinenEsler_.Equals(other.bilinenEsler_)) return false;
      if (Adres != other.Adres) return false;
      if (Versiyon != other.Versiyon) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Durum != false) hash ^= Durum.GetHashCode();
      if (Mesaj.Length != 0) hash ^= Mesaj.GetHashCode();
      if (es_ != null) hash ^= Es.GetHashCode();
      hash ^= esler_.GetHashCode();
      if (Karma.Length != 0) hash ^= Karma.GetHashCode();
      if (Yukseklik != 0L) hash ^= Yukseklik.GetHashCode();
      hash ^= bilinenEsler_.GetHashCode();
      if (Adres.Length != 0) hash ^= Adres.GetHashCode();
      if (Versiyon != 0) hash ^= Versiyon.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Durum != false) {
        output.WriteRawTag(8);
        output.WriteBool(Durum);
      }
      if (Mesaj.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Mesaj);
      }
      if (es_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Es);
      }
      esler_.WriteTo(output, _repeated_esler_codec);
      if (Karma.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Karma);
      }
      if (Yukseklik != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(Yukseklik);
      }
      bilinenEsler_.WriteTo(output, _repeated_bilinenEsler_codec);
      if (Adres.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Adres);
      }
      if (Versiyon != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(Versiyon);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Durum != false) {
        output.WriteRawTag(8);
        output.WriteBool(Durum);
      }
      if (Mesaj.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Mesaj);
      }
      if (es_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Es);
      }
      esler_.WriteTo(ref output, _repeated_esler_codec);
      if (Karma.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Karma);
      }
      if (Yukseklik != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(Yukseklik);
      }
      bilinenEsler_.WriteTo(ref output, _repeated_bilinenEsler_codec);
      if (Adres.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Adres);
      }
      if (Versiyon != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(Versiyon);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Durum != false) {
        size += 1 + 1;
      }
      if (Mesaj.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Mesaj);
      }
      if (es_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Es);
      }
      size += esler_.CalculateSize(_repeated_esler_codec);
      if (Karma.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Karma);
      }
      if (Yukseklik != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Yukseklik);
      }
      size += bilinenEsler_.CalculateSize(_repeated_bilinenEsler_codec);
      if (Adres.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Adres);
      }
      if (Versiyon != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Versiyon);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EsDurum other) {
      if (other == null) {
        return;
      }
      if (other.Durum != false) {
        Durum = other.Durum;
      }
      if (other.Mesaj.Length != 0) {
        Mesaj = other.Mesaj;
      }
      if (other.es_ != null) {
        if (es_ == null) {
          Es = new global::RecycleCoin.Grpc.Es();
        }
        Es.MergeFrom(other.Es);
      }
      esler_.Add(other.esler_);
      if (other.Karma.Length != 0) {
        Karma = other.Karma;
      }
      if (other.Yukseklik != 0L) {
        Yukseklik = other.Yukseklik;
      }
      bilinenEsler_.Add(other.bilinenEsler_);
      if (other.Adres.Length != 0) {
        Adres = other.Adres;
      }
      if (other.Versiyon != 0) {
        Versiyon = other.Versiyon;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Durum = input.ReadBool();
            break;
          }
          case 18: {
            Mesaj = input.ReadString();
            break;
          }
          case 26: {
            if (es_ == null) {
              Es = new global::RecycleCoin.Grpc.Es();
            }
            input.ReadMessage(Es);
            break;
          }
          case 34: {
            esler_.AddEntriesFrom(input, _repeated_esler_codec);
            break;
          }
          case 42: {
            Karma = input.ReadString();
            break;
          }
          case 48: {
            Yukseklik = input.ReadInt64();
            break;
          }
          case 58: {
            bilinenEsler_.AddEntriesFrom(input, _repeated_bilinenEsler_codec);
            break;
          }
          case 66: {
            Adres = input.ReadString();
            break;
          }
          case 72: {
            Versiyon = input.ReadInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Durum = input.ReadBool();
            break;
          }
          case 18: {
            Mesaj = input.ReadString();
            break;
          }
          case 26: {
            if (es_ == null) {
              Es = new global::RecycleCoin.Grpc.Es();
            }
            input.ReadMessage(Es);
            break;
          }
          case 34: {
            esler_.AddEntriesFrom(ref input, _repeated_esler_codec);
            break;
          }
          case 42: {
            Karma = input.ReadString();
            break;
          }
          case 48: {
            Yukseklik = input.ReadInt64();
            break;
          }
          case 58: {
            bilinenEsler_.AddEntriesFrom(ref input, _repeated_bilinenEsler_codec);
            break;
          }
          case 66: {
            Adres = input.ReadString();
            break;
          }
          case 72: {
            Versiyon = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class Es : pb::IMessage<Es>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Es> _parser = new pb::MessageParser<Es>(() => new Es());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Es> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::RecycleCoin.Grpc.EsReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Es() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Es(Es other) : this() {
      id_ = other.id_;
      adres_ = other.adres_;
      sonErisim_ = other.sonErisim_;
      onyukluMu_ = other.onyukluMu_;
      erisilebilirMi_ = other.erisilebilirMi_;
      zamanDamgasi_ = other.zamanDamgasi_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Es Clone() {
      return new Es(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "adres" field.</summary>
    public const int AdresFieldNumber = 2;
    private string adres_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Adres {
      get { return adres_; }
      set {
        adres_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "son_erisim" field.</summary>
    public const int SonErisimFieldNumber = 3;
    private long sonErisim_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long SonErisim {
      get { return sonErisim_; }
      set {
        sonErisim_ = value;
      }
    }

    /// <summary>Field number for the "onyuklu_mu" field.</summary>
    public const int OnyukluMuFieldNumber = 4;
    private bool onyukluMu_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool OnyukluMu {
      get { return onyukluMu_; }
      set {
        onyukluMu_ = value;
      }
    }

    /// <summary>Field number for the "erisilebilir_mi" field.</summary>
    public const int ErisilebilirMiFieldNumber = 5;
    private bool erisilebilirMi_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool ErisilebilirMi {
      get { return erisilebilirMi_; }
      set {
        erisilebilirMi_ = value;
      }
    }

    /// <summary>Field number for the "zaman_damgasi" field.</summary>
    public const int ZamanDamgasiFieldNumber = 6;
    private long zamanDamgasi_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long ZamanDamgasi {
      get { return zamanDamgasi_; }
      set {
        zamanDamgasi_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Es);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Es other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Adres != other.Adres) return false;
      if (SonErisim != other.SonErisim) return false;
      if (OnyukluMu != other.OnyukluMu) return false;
      if (ErisilebilirMi != other.ErisilebilirMi) return false;
      if (ZamanDamgasi != other.ZamanDamgasi) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Adres.Length != 0) hash ^= Adres.GetHashCode();
      if (SonErisim != 0L) hash ^= SonErisim.GetHashCode();
      if (OnyukluMu != false) hash ^= OnyukluMu.GetHashCode();
      if (ErisilebilirMi != false) hash ^= ErisilebilirMi.GetHashCode();
      if (ZamanDamgasi != 0L) hash ^= ZamanDamgasi.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (Adres.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Adres);
      }
      if (SonErisim != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(SonErisim);
      }
      if (OnyukluMu != false) {
        output.WriteRawTag(32);
        output.WriteBool(OnyukluMu);
      }
      if (ErisilebilirMi != false) {
        output.WriteRawTag(40);
        output.WriteBool(ErisilebilirMi);
      }
      if (ZamanDamgasi != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(ZamanDamgasi);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (Adres.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Adres);
      }
      if (SonErisim != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(SonErisim);
      }
      if (OnyukluMu != false) {
        output.WriteRawTag(32);
        output.WriteBool(OnyukluMu);
      }
      if (ErisilebilirMi != false) {
        output.WriteRawTag(40);
        output.WriteBool(ErisilebilirMi);
      }
      if (ZamanDamgasi != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(ZamanDamgasi);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (Adres.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Adres);
      }
      if (SonErisim != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(SonErisim);
      }
      if (OnyukluMu != false) {
        size += 1 + 1;
      }
      if (ErisilebilirMi != false) {
        size += 1 + 1;
      }
      if (ZamanDamgasi != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ZamanDamgasi);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Es other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Adres.Length != 0) {
        Adres = other.Adres;
      }
      if (other.SonErisim != 0L) {
        SonErisim = other.SonErisim;
      }
      if (other.OnyukluMu != false) {
        OnyukluMu = other.OnyukluMu;
      }
      if (other.ErisilebilirMi != false) {
        ErisilebilirMi = other.ErisilebilirMi;
      }
      if (other.ZamanDamgasi != 0L) {
        ZamanDamgasi = other.ZamanDamgasi;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 18: {
            Adres = input.ReadString();
            break;
          }
          case 24: {
            SonErisim = input.ReadInt64();
            break;
          }
          case 32: {
            OnyukluMu = input.ReadBool();
            break;
          }
          case 40: {
            ErisilebilirMi = input.ReadBool();
            break;
          }
          case 48: {
            ZamanDamgasi = input.ReadInt64();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 18: {
            Adres = input.ReadString();
            break;
          }
          case 24: {
            SonErisim = input.ReadInt64();
            break;
          }
          case 32: {
            OnyukluMu = input.ReadBool();
            break;
          }
          case 40: {
            ErisilebilirMi = input.ReadBool();
            break;
          }
          case 48: {
            ZamanDamgasi = input.ReadInt64();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
