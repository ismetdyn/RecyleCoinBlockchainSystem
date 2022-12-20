// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Grpc/Protos/account.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace RecycleCoin.Grpc.Protos {

  /// <summary>Holder for reflection information generated from Grpc/Protos/account.proto</summary>
  public static partial class AccountReflection {

    #region Descriptor
    /// <summary>File descriptor for Grpc/Protos/account.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AccountReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlHcnBjL1Byb3Rvcy9hY2NvdW50LnByb3RvIj0KDUFjY291bnRQYXJhbXMS",
            "EwoLcGFnZV9udW1iZXIYASABKAUSFwoPcmVzdWx0X3Blcl9wYWdlGAIgASgF",
            "IikKC0FjY291bnRMaXN0EhoKCGFjY291bnRzGAEgAygLMgguQWNjb3VudCJ9",
            "CgdBY2NvdW50EgoKAklkGAEgASgDEg8KB2FkZHJlc3MYAiABKAkSDwoHcHVi",
            "X2tleRgDIAEoCRIPCgdiYWxhbmNlGAQgASgBEhEKCXR4bl9jb3VudBgFIAEo",
            "AxIPCgdjcmVhdGVkGAYgASgDEg8KB3VwZGF0ZWQYByABKAMyugEKDkFjY291",
            "bnRTZXJ2aWNlEhkKA0FkZBIILkFjY291bnQaCC5BY2NvdW50EhwKBlVwZGF0",
            "ZRIILkFjY291bnQaCC5BY2NvdW50EiEKC0dldEJ5UHViS2V5EgguQWNjb3Vu",
            "dBoILkFjY291bnQSIgoMR2V0QnlBZGRyZXNzEgguQWNjb3VudBoILkFjY291",
            "bnQSKAoIR2V0UmFuZ2USDi5BY2NvdW50UGFyYW1zGgwuQWNjb3VudExpc3RC",
            "GqoCF1JlY3ljbGVDb2luLkdycGMuUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::RecycleCoin.Grpc.Protos.AccountParams), global::RecycleCoin.Grpc.Protos.AccountParams.Parser, new[]{ "PageNumber", "ResultPerPage" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::RecycleCoin.Grpc.Protos.AccountList), global::RecycleCoin.Grpc.Protos.AccountList.Parser, new[]{ "Accounts" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::RecycleCoin.Grpc.Protos.Account), global::RecycleCoin.Grpc.Protos.Account.Parser, new[]{ "Id", "Address", "PubKey", "Balance", "TxnCount", "Created", "Updated" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AccountParams : pb::IMessage<AccountParams>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AccountParams> _parser = new pb::MessageParser<AccountParams>(() => new AccountParams());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AccountParams> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::RecycleCoin.Grpc.Protos.AccountReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccountParams() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccountParams(AccountParams other) : this() {
      pageNumber_ = other.pageNumber_;
      resultPerPage_ = other.resultPerPage_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccountParams Clone() {
      return new AccountParams(this);
    }

    /// <summary>Field number for the "page_number" field.</summary>
    public const int PageNumberFieldNumber = 1;
    private int pageNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int PageNumber {
      get { return pageNumber_; }
      set {
        pageNumber_ = value;
      }
    }

    /// <summary>Field number for the "result_per_page" field.</summary>
    public const int ResultPerPageFieldNumber = 2;
    private int resultPerPage_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int ResultPerPage {
      get { return resultPerPage_; }
      set {
        resultPerPage_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AccountParams);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AccountParams other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PageNumber != other.PageNumber) return false;
      if (ResultPerPage != other.ResultPerPage) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PageNumber != 0) hash ^= PageNumber.GetHashCode();
      if (ResultPerPage != 0) hash ^= ResultPerPage.GetHashCode();
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
      if (PageNumber != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(PageNumber);
      }
      if (ResultPerPage != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(ResultPerPage);
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
      if (PageNumber != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(PageNumber);
      }
      if (ResultPerPage != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(ResultPerPage);
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
      if (PageNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PageNumber);
      }
      if (ResultPerPage != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ResultPerPage);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AccountParams other) {
      if (other == null) {
        return;
      }
      if (other.PageNumber != 0) {
        PageNumber = other.PageNumber;
      }
      if (other.ResultPerPage != 0) {
        ResultPerPage = other.ResultPerPage;
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
            PageNumber = input.ReadInt32();
            break;
          }
          case 16: {
            ResultPerPage = input.ReadInt32();
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
            PageNumber = input.ReadInt32();
            break;
          }
          case 16: {
            ResultPerPage = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class AccountList : pb::IMessage<AccountList>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AccountList> _parser = new pb::MessageParser<AccountList>(() => new AccountList());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AccountList> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::RecycleCoin.Grpc.Protos.AccountReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccountList() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccountList(AccountList other) : this() {
      accounts_ = other.accounts_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccountList Clone() {
      return new AccountList(this);
    }

    /// <summary>Field number for the "accounts" field.</summary>
    public const int AccountsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::RecycleCoin.Grpc.Protos.Account> _repeated_accounts_codec
        = pb::FieldCodec.ForMessage(10, global::RecycleCoin.Grpc.Protos.Account.Parser);
    private readonly pbc::RepeatedField<global::RecycleCoin.Grpc.Protos.Account> accounts_ = new pbc::RepeatedField<global::RecycleCoin.Grpc.Protos.Account>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::RecycleCoin.Grpc.Protos.Account> Accounts {
      get { return accounts_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AccountList);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AccountList other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!accounts_.Equals(other.accounts_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= accounts_.GetHashCode();
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
      accounts_.WriteTo(output, _repeated_accounts_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      accounts_.WriteTo(ref output, _repeated_accounts_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += accounts_.CalculateSize(_repeated_accounts_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AccountList other) {
      if (other == null) {
        return;
      }
      accounts_.Add(other.accounts_);
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
            accounts_.AddEntriesFrom(input, _repeated_accounts_codec);
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
            accounts_.AddEntriesFrom(ref input, _repeated_accounts_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class Account : pb::IMessage<Account>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Account> _parser = new pb::MessageParser<Account>(() => new Account());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Account> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::RecycleCoin.Grpc.Protos.AccountReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Account() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Account(Account other) : this() {
      id_ = other.id_;
      address_ = other.address_;
      pubKey_ = other.pubKey_;
      balance_ = other.balance_;
      txnCount_ = other.txnCount_;
      created_ = other.created_;
      updated_ = other.updated_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Account Clone() {
      return new Account(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private long id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "address" field.</summary>
    public const int AddressFieldNumber = 2;
    private string address_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Address {
      get { return address_; }
      set {
        address_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "pub_key" field.</summary>
    public const int PubKeyFieldNumber = 3;
    private string pubKey_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PubKey {
      get { return pubKey_; }
      set {
        pubKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "balance" field.</summary>
    public const int BalanceFieldNumber = 4;
    private double balance_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Balance {
      get { return balance_; }
      set {
        balance_ = value;
      }
    }

    /// <summary>Field number for the "txn_count" field.</summary>
    public const int TxnCountFieldNumber = 5;
    private long txnCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long TxnCount {
      get { return txnCount_; }
      set {
        txnCount_ = value;
      }
    }

    /// <summary>Field number for the "created" field.</summary>
    public const int CreatedFieldNumber = 6;
    private long created_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Created {
      get { return created_; }
      set {
        created_ = value;
      }
    }

    /// <summary>Field number for the "updated" field.</summary>
    public const int UpdatedFieldNumber = 7;
    private long updated_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Updated {
      get { return updated_; }
      set {
        updated_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Account);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Account other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Address != other.Address) return false;
      if (PubKey != other.PubKey) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Balance, other.Balance)) return false;
      if (TxnCount != other.TxnCount) return false;
      if (Created != other.Created) return false;
      if (Updated != other.Updated) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0L) hash ^= Id.GetHashCode();
      if (Address.Length != 0) hash ^= Address.GetHashCode();
      if (PubKey.Length != 0) hash ^= PubKey.GetHashCode();
      if (Balance != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Balance);
      if (TxnCount != 0L) hash ^= TxnCount.GetHashCode();
      if (Created != 0L) hash ^= Created.GetHashCode();
      if (Updated != 0L) hash ^= Updated.GetHashCode();
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
      if (Id != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Id);
      }
      if (Address.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Address);
      }
      if (PubKey.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PubKey);
      }
      if (Balance != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Balance);
      }
      if (TxnCount != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(TxnCount);
      }
      if (Created != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(Created);
      }
      if (Updated != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(Updated);
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
      if (Id != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Id);
      }
      if (Address.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Address);
      }
      if (PubKey.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PubKey);
      }
      if (Balance != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Balance);
      }
      if (TxnCount != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(TxnCount);
      }
      if (Created != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(Created);
      }
      if (Updated != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(Updated);
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
      if (Id != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Id);
      }
      if (Address.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Address);
      }
      if (PubKey.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PubKey);
      }
      if (Balance != 0D) {
        size += 1 + 8;
      }
      if (TxnCount != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(TxnCount);
      }
      if (Created != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Created);
      }
      if (Updated != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Updated);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Account other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0L) {
        Id = other.Id;
      }
      if (other.Address.Length != 0) {
        Address = other.Address;
      }
      if (other.PubKey.Length != 0) {
        PubKey = other.PubKey;
      }
      if (other.Balance != 0D) {
        Balance = other.Balance;
      }
      if (other.TxnCount != 0L) {
        TxnCount = other.TxnCount;
      }
      if (other.Created != 0L) {
        Created = other.Created;
      }
      if (other.Updated != 0L) {
        Updated = other.Updated;
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
            Id = input.ReadInt64();
            break;
          }
          case 18: {
            Address = input.ReadString();
            break;
          }
          case 26: {
            PubKey = input.ReadString();
            break;
          }
          case 33: {
            Balance = input.ReadDouble();
            break;
          }
          case 40: {
            TxnCount = input.ReadInt64();
            break;
          }
          case 48: {
            Created = input.ReadInt64();
            break;
          }
          case 56: {
            Updated = input.ReadInt64();
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
            Id = input.ReadInt64();
            break;
          }
          case 18: {
            Address = input.ReadString();
            break;
          }
          case 26: {
            PubKey = input.ReadString();
            break;
          }
          case 33: {
            Balance = input.ReadDouble();
            break;
          }
          case 40: {
            TxnCount = input.ReadInt64();
            break;
          }
          case 48: {
            Created = input.ReadInt64();
            break;
          }
          case 56: {
            Updated = input.ReadInt64();
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
