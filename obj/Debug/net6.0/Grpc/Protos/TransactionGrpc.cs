// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Grpc/Protos/transaction.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace RecycleCoin.Grpc.Protos {
  public static partial class TransactionService
  {
    static readonly string __ServiceName = "TransactionService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::RecycleCoin.Grpc.Protos.TransactionPost> __Marshaller_TransactionPost = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::RecycleCoin.Grpc.Protos.TransactionPost.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::RecycleCoin.Grpc.Protos.TransactionStatus> __Marshaller_TransactionStatus = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::RecycleCoin.Grpc.Protos.TransactionStatus.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::RecycleCoin.Grpc.Protos.Transaction> __Marshaller_Transaction = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::RecycleCoin.Grpc.Protos.Transaction.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::RecycleCoin.Grpc.Protos.TransactionPaging> __Marshaller_TransactionPaging = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::RecycleCoin.Grpc.Protos.TransactionPaging.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::RecycleCoin.Grpc.Protos.TransactionList> __Marshaller_TransactionList = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::RecycleCoin.Grpc.Protos.TransactionList.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::RecycleCoin.Grpc.Protos.TransactionPost, global::RecycleCoin.Grpc.Protos.TransactionStatus> __Method_Receive = new grpc::Method<global::RecycleCoin.Grpc.Protos.TransactionPost, global::RecycleCoin.Grpc.Protos.TransactionStatus>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Receive",
        __Marshaller_TransactionPost,
        __Marshaller_TransactionStatus);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::RecycleCoin.Grpc.Protos.TransactionPost, global::RecycleCoin.Grpc.Protos.TransactionStatus> __Method_Transfer = new grpc::Method<global::RecycleCoin.Grpc.Protos.TransactionPost, global::RecycleCoin.Grpc.Protos.TransactionStatus>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Transfer",
        __Marshaller_TransactionPost,
        __Marshaller_TransactionStatus);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::RecycleCoin.Grpc.Protos.Transaction, global::RecycleCoin.Grpc.Protos.Transaction> __Method_GetByHash = new grpc::Method<global::RecycleCoin.Grpc.Protos.Transaction, global::RecycleCoin.Grpc.Protos.Transaction>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetByHash",
        __Marshaller_Transaction,
        __Marshaller_Transaction);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::RecycleCoin.Grpc.Protos.TransactionPaging, global::RecycleCoin.Grpc.Protos.TransactionList> __Method_GetRangeByAddress = new grpc::Method<global::RecycleCoin.Grpc.Protos.TransactionPaging, global::RecycleCoin.Grpc.Protos.TransactionList>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetRangeByAddress",
        __Marshaller_TransactionPaging,
        __Marshaller_TransactionList);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::RecycleCoin.Grpc.Protos.TransactionPaging, global::RecycleCoin.Grpc.Protos.TransactionList> __Method_GetRange = new grpc::Method<global::RecycleCoin.Grpc.Protos.TransactionPaging, global::RecycleCoin.Grpc.Protos.TransactionList>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetRange",
        __Marshaller_TransactionPaging,
        __Marshaller_TransactionList);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::RecycleCoin.Grpc.Protos.TransactionPaging, global::RecycleCoin.Grpc.Protos.TransactionList> __Method_GetPoolRange = new grpc::Method<global::RecycleCoin.Grpc.Protos.TransactionPaging, global::RecycleCoin.Grpc.Protos.TransactionList>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPoolRange",
        __Marshaller_TransactionPaging,
        __Marshaller_TransactionList);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::RecycleCoin.Grpc.Protos.TransactionPaging, global::RecycleCoin.Grpc.Protos.TransactionList> __Method_GetPendingTxns = new grpc::Method<global::RecycleCoin.Grpc.Protos.TransactionPaging, global::RecycleCoin.Grpc.Protos.TransactionList>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPendingTxns",
        __Marshaller_TransactionPaging,
        __Marshaller_TransactionList);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::RecycleCoin.Grpc.Protos.TransactionReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of TransactionService</summary>
    [grpc::BindServiceMethod(typeof(TransactionService), "BindService")]
    public abstract partial class TransactionServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::RecycleCoin.Grpc.Protos.TransactionStatus> Receive(global::RecycleCoin.Grpc.Protos.TransactionPost request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::RecycleCoin.Grpc.Protos.TransactionStatus> Transfer(global::RecycleCoin.Grpc.Protos.TransactionPost request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::RecycleCoin.Grpc.Protos.Transaction> GetByHash(global::RecycleCoin.Grpc.Protos.Transaction request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::RecycleCoin.Grpc.Protos.TransactionList> GetRangeByAddress(global::RecycleCoin.Grpc.Protos.TransactionPaging request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::RecycleCoin.Grpc.Protos.TransactionList> GetRange(global::RecycleCoin.Grpc.Protos.TransactionPaging request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::RecycleCoin.Grpc.Protos.TransactionList> GetPoolRange(global::RecycleCoin.Grpc.Protos.TransactionPaging request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::RecycleCoin.Grpc.Protos.TransactionList> GetPendingTxns(global::RecycleCoin.Grpc.Protos.TransactionPaging request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for TransactionService</summary>
    public partial class TransactionServiceClient : grpc::ClientBase<TransactionServiceClient>
    {
      /// <summary>Creates a new client for TransactionService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public TransactionServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for TransactionService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public TransactionServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected TransactionServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected TransactionServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Protos.TransactionStatus Receive(global::RecycleCoin.Grpc.Protos.TransactionPost request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Receive(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Protos.TransactionStatus Receive(global::RecycleCoin.Grpc.Protos.TransactionPost request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Receive, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Protos.TransactionStatus> ReceiveAsync(global::RecycleCoin.Grpc.Protos.TransactionPost request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ReceiveAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Protos.TransactionStatus> ReceiveAsync(global::RecycleCoin.Grpc.Protos.TransactionPost request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Receive, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Protos.TransactionStatus Transfer(global::RecycleCoin.Grpc.Protos.TransactionPost request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Transfer(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Protos.TransactionStatus Transfer(global::RecycleCoin.Grpc.Protos.TransactionPost request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Transfer, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Protos.TransactionStatus> TransferAsync(global::RecycleCoin.Grpc.Protos.TransactionPost request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return TransferAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Protos.TransactionStatus> TransferAsync(global::RecycleCoin.Grpc.Protos.TransactionPost request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Transfer, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Protos.Transaction GetByHash(global::RecycleCoin.Grpc.Protos.Transaction request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetByHash(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Protos.Transaction GetByHash(global::RecycleCoin.Grpc.Protos.Transaction request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetByHash, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Protos.Transaction> GetByHashAsync(global::RecycleCoin.Grpc.Protos.Transaction request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetByHashAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Protos.Transaction> GetByHashAsync(global::RecycleCoin.Grpc.Protos.Transaction request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetByHash, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Protos.TransactionList GetRangeByAddress(global::RecycleCoin.Grpc.Protos.TransactionPaging request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetRangeByAddress(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Protos.TransactionList GetRangeByAddress(global::RecycleCoin.Grpc.Protos.TransactionPaging request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetRangeByAddress, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Protos.TransactionList> GetRangeByAddressAsync(global::RecycleCoin.Grpc.Protos.TransactionPaging request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetRangeByAddressAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Protos.TransactionList> GetRangeByAddressAsync(global::RecycleCoin.Grpc.Protos.TransactionPaging request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetRangeByAddress, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Protos.TransactionList GetRange(global::RecycleCoin.Grpc.Protos.TransactionPaging request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetRange(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Protos.TransactionList GetRange(global::RecycleCoin.Grpc.Protos.TransactionPaging request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetRange, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Protos.TransactionList> GetRangeAsync(global::RecycleCoin.Grpc.Protos.TransactionPaging request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetRangeAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Protos.TransactionList> GetRangeAsync(global::RecycleCoin.Grpc.Protos.TransactionPaging request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetRange, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Protos.TransactionList GetPoolRange(global::RecycleCoin.Grpc.Protos.TransactionPaging request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPoolRange(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Protos.TransactionList GetPoolRange(global::RecycleCoin.Grpc.Protos.TransactionPaging request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetPoolRange, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Protos.TransactionList> GetPoolRangeAsync(global::RecycleCoin.Grpc.Protos.TransactionPaging request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPoolRangeAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Protos.TransactionList> GetPoolRangeAsync(global::RecycleCoin.Grpc.Protos.TransactionPaging request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetPoolRange, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Protos.TransactionList GetPendingTxns(global::RecycleCoin.Grpc.Protos.TransactionPaging request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPendingTxns(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Protos.TransactionList GetPendingTxns(global::RecycleCoin.Grpc.Protos.TransactionPaging request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetPendingTxns, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Protos.TransactionList> GetPendingTxnsAsync(global::RecycleCoin.Grpc.Protos.TransactionPaging request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPendingTxnsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Protos.TransactionList> GetPendingTxnsAsync(global::RecycleCoin.Grpc.Protos.TransactionPaging request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetPendingTxns, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override TransactionServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new TransactionServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(TransactionServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Receive, serviceImpl.Receive)
          .AddMethod(__Method_Transfer, serviceImpl.Transfer)
          .AddMethod(__Method_GetByHash, serviceImpl.GetByHash)
          .AddMethod(__Method_GetRangeByAddress, serviceImpl.GetRangeByAddress)
          .AddMethod(__Method_GetRange, serviceImpl.GetRange)
          .AddMethod(__Method_GetPoolRange, serviceImpl.GetPoolRange)
          .AddMethod(__Method_GetPendingTxns, serviceImpl.GetPendingTxns).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, TransactionServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Receive, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::RecycleCoin.Grpc.Protos.TransactionPost, global::RecycleCoin.Grpc.Protos.TransactionStatus>(serviceImpl.Receive));
      serviceBinder.AddMethod(__Method_Transfer, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::RecycleCoin.Grpc.Protos.TransactionPost, global::RecycleCoin.Grpc.Protos.TransactionStatus>(serviceImpl.Transfer));
      serviceBinder.AddMethod(__Method_GetByHash, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::RecycleCoin.Grpc.Protos.Transaction, global::RecycleCoin.Grpc.Protos.Transaction>(serviceImpl.GetByHash));
      serviceBinder.AddMethod(__Method_GetRangeByAddress, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::RecycleCoin.Grpc.Protos.TransactionPaging, global::RecycleCoin.Grpc.Protos.TransactionList>(serviceImpl.GetRangeByAddress));
      serviceBinder.AddMethod(__Method_GetRange, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::RecycleCoin.Grpc.Protos.TransactionPaging, global::RecycleCoin.Grpc.Protos.TransactionList>(serviceImpl.GetRange));
      serviceBinder.AddMethod(__Method_GetPoolRange, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::RecycleCoin.Grpc.Protos.TransactionPaging, global::RecycleCoin.Grpc.Protos.TransactionList>(serviceImpl.GetPoolRange));
      serviceBinder.AddMethod(__Method_GetPendingTxns, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::RecycleCoin.Grpc.Protos.TransactionPaging, global::RecycleCoin.Grpc.Protos.TransactionList>(serviceImpl.GetPendingTxns));
    }

  }
}
#endregion
