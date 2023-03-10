// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Grpc/Protos/block.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace RecycleCoin.Grpc.Protos {
  public static partial class BlockService
  {
    static readonly string __ServiceName = "BlockService";

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
    static readonly grpc::Marshaller<global::RecycleCoin.Grpc.Protos.Block> __Marshaller_Block = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::RecycleCoin.Grpc.Protos.Block.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::RecycleCoin.Grpc.Protos.AddBlockStatus> __Marshaller_AddBlockStatus = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::RecycleCoin.Grpc.Protos.AddBlockStatus.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::RecycleCoin.Grpc.Protos.StartingParams> __Marshaller_StartingParams = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::RecycleCoin.Grpc.Protos.StartingParams.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::RecycleCoin.Grpc.Protos.BlockList> __Marshaller_BlockList = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::RecycleCoin.Grpc.Protos.BlockList.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::RecycleCoin.Grpc.Protos.BlockParams> __Marshaller_BlockParams = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::RecycleCoin.Grpc.Protos.BlockParams.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::RecycleCoin.Grpc.Protos.EmptyRequest> __Marshaller_EmptyRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::RecycleCoin.Grpc.Protos.EmptyRequest.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::RecycleCoin.Grpc.Protos.Block, global::RecycleCoin.Grpc.Protos.AddBlockStatus> __Method_Add = new grpc::Method<global::RecycleCoin.Grpc.Protos.Block, global::RecycleCoin.Grpc.Protos.AddBlockStatus>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Add",
        __Marshaller_Block,
        __Marshaller_AddBlockStatus);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::RecycleCoin.Grpc.Protos.StartingParams, global::RecycleCoin.Grpc.Protos.BlockList> __Method_GetRemains = new grpc::Method<global::RecycleCoin.Grpc.Protos.StartingParams, global::RecycleCoin.Grpc.Protos.BlockList>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetRemains",
        __Marshaller_StartingParams,
        __Marshaller_BlockList);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::RecycleCoin.Grpc.Protos.BlockParams, global::RecycleCoin.Grpc.Protos.BlockList> __Method_GetRange = new grpc::Method<global::RecycleCoin.Grpc.Protos.BlockParams, global::RecycleCoin.Grpc.Protos.BlockList>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetRange",
        __Marshaller_BlockParams,
        __Marshaller_BlockList);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::RecycleCoin.Grpc.Protos.Block, global::RecycleCoin.Grpc.Protos.Block> __Method_GetByHeight = new grpc::Method<global::RecycleCoin.Grpc.Protos.Block, global::RecycleCoin.Grpc.Protos.Block>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetByHeight",
        __Marshaller_Block,
        __Marshaller_Block);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::RecycleCoin.Grpc.Protos.Block, global::RecycleCoin.Grpc.Protos.Block> __Method_GetByHash = new grpc::Method<global::RecycleCoin.Grpc.Protos.Block, global::RecycleCoin.Grpc.Protos.Block>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetByHash",
        __Marshaller_Block,
        __Marshaller_Block);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::RecycleCoin.Grpc.Protos.EmptyRequest, global::RecycleCoin.Grpc.Protos.Block> __Method_GetFirst = new grpc::Method<global::RecycleCoin.Grpc.Protos.EmptyRequest, global::RecycleCoin.Grpc.Protos.Block>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetFirst",
        __Marshaller_EmptyRequest,
        __Marshaller_Block);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::RecycleCoin.Grpc.Protos.EmptyRequest, global::RecycleCoin.Grpc.Protos.Block> __Method_GetLast = new grpc::Method<global::RecycleCoin.Grpc.Protos.EmptyRequest, global::RecycleCoin.Grpc.Protos.Block>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetLast",
        __Marshaller_EmptyRequest,
        __Marshaller_Block);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::RecycleCoin.Grpc.Protos.BlockReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of BlockService</summary>
    [grpc::BindServiceMethod(typeof(BlockService), "BindService")]
    public abstract partial class BlockServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::RecycleCoin.Grpc.Protos.AddBlockStatus> Add(global::RecycleCoin.Grpc.Protos.Block request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::RecycleCoin.Grpc.Protos.BlockList> GetRemains(global::RecycleCoin.Grpc.Protos.StartingParams request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::RecycleCoin.Grpc.Protos.BlockList> GetRange(global::RecycleCoin.Grpc.Protos.BlockParams request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::RecycleCoin.Grpc.Protos.Block> GetByHeight(global::RecycleCoin.Grpc.Protos.Block request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::RecycleCoin.Grpc.Protos.Block> GetByHash(global::RecycleCoin.Grpc.Protos.Block request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::RecycleCoin.Grpc.Protos.Block> GetFirst(global::RecycleCoin.Grpc.Protos.EmptyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::RecycleCoin.Grpc.Protos.Block> GetLast(global::RecycleCoin.Grpc.Protos.EmptyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for BlockService</summary>
    public partial class BlockServiceClient : grpc::ClientBase<BlockServiceClient>
    {
      /// <summary>Creates a new client for BlockService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public BlockServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for BlockService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public BlockServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected BlockServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected BlockServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Protos.AddBlockStatus Add(global::RecycleCoin.Grpc.Protos.Block request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Add(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Protos.AddBlockStatus Add(global::RecycleCoin.Grpc.Protos.Block request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Add, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Protos.AddBlockStatus> AddAsync(global::RecycleCoin.Grpc.Protos.Block request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Protos.AddBlockStatus> AddAsync(global::RecycleCoin.Grpc.Protos.Block request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Add, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Protos.BlockList GetRemains(global::RecycleCoin.Grpc.Protos.StartingParams request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetRemains(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Protos.BlockList GetRemains(global::RecycleCoin.Grpc.Protos.StartingParams request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetRemains, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Protos.BlockList> GetRemainsAsync(global::RecycleCoin.Grpc.Protos.StartingParams request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetRemainsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Protos.BlockList> GetRemainsAsync(global::RecycleCoin.Grpc.Protos.StartingParams request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetRemains, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Protos.BlockList GetRange(global::RecycleCoin.Grpc.Protos.BlockParams request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetRange(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Protos.BlockList GetRange(global::RecycleCoin.Grpc.Protos.BlockParams request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetRange, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Protos.BlockList> GetRangeAsync(global::RecycleCoin.Grpc.Protos.BlockParams request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetRangeAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Protos.BlockList> GetRangeAsync(global::RecycleCoin.Grpc.Protos.BlockParams request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetRange, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Protos.Block GetByHeight(global::RecycleCoin.Grpc.Protos.Block request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetByHeight(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Protos.Block GetByHeight(global::RecycleCoin.Grpc.Protos.Block request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetByHeight, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Protos.Block> GetByHeightAsync(global::RecycleCoin.Grpc.Protos.Block request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetByHeightAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Protos.Block> GetByHeightAsync(global::RecycleCoin.Grpc.Protos.Block request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetByHeight, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Protos.Block GetByHash(global::RecycleCoin.Grpc.Protos.Block request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetByHash(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Protos.Block GetByHash(global::RecycleCoin.Grpc.Protos.Block request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetByHash, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Protos.Block> GetByHashAsync(global::RecycleCoin.Grpc.Protos.Block request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetByHashAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Protos.Block> GetByHashAsync(global::RecycleCoin.Grpc.Protos.Block request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetByHash, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Protos.Block GetFirst(global::RecycleCoin.Grpc.Protos.EmptyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetFirst(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Protos.Block GetFirst(global::RecycleCoin.Grpc.Protos.EmptyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetFirst, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Protos.Block> GetFirstAsync(global::RecycleCoin.Grpc.Protos.EmptyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetFirstAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Protos.Block> GetFirstAsync(global::RecycleCoin.Grpc.Protos.EmptyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetFirst, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Protos.Block GetLast(global::RecycleCoin.Grpc.Protos.EmptyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetLast(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Protos.Block GetLast(global::RecycleCoin.Grpc.Protos.EmptyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetLast, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Protos.Block> GetLastAsync(global::RecycleCoin.Grpc.Protos.EmptyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetLastAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Protos.Block> GetLastAsync(global::RecycleCoin.Grpc.Protos.EmptyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetLast, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override BlockServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new BlockServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(BlockServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Add, serviceImpl.Add)
          .AddMethod(__Method_GetRemains, serviceImpl.GetRemains)
          .AddMethod(__Method_GetRange, serviceImpl.GetRange)
          .AddMethod(__Method_GetByHeight, serviceImpl.GetByHeight)
          .AddMethod(__Method_GetByHash, serviceImpl.GetByHash)
          .AddMethod(__Method_GetFirst, serviceImpl.GetFirst)
          .AddMethod(__Method_GetLast, serviceImpl.GetLast).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, BlockServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Add, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::RecycleCoin.Grpc.Protos.Block, global::RecycleCoin.Grpc.Protos.AddBlockStatus>(serviceImpl.Add));
      serviceBinder.AddMethod(__Method_GetRemains, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::RecycleCoin.Grpc.Protos.StartingParams, global::RecycleCoin.Grpc.Protos.BlockList>(serviceImpl.GetRemains));
      serviceBinder.AddMethod(__Method_GetRange, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::RecycleCoin.Grpc.Protos.BlockParams, global::RecycleCoin.Grpc.Protos.BlockList>(serviceImpl.GetRange));
      serviceBinder.AddMethod(__Method_GetByHeight, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::RecycleCoin.Grpc.Protos.Block, global::RecycleCoin.Grpc.Protos.Block>(serviceImpl.GetByHeight));
      serviceBinder.AddMethod(__Method_GetByHash, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::RecycleCoin.Grpc.Protos.Block, global::RecycleCoin.Grpc.Protos.Block>(serviceImpl.GetByHash));
      serviceBinder.AddMethod(__Method_GetFirst, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::RecycleCoin.Grpc.Protos.EmptyRequest, global::RecycleCoin.Grpc.Protos.Block>(serviceImpl.GetFirst));
      serviceBinder.AddMethod(__Method_GetLast, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::RecycleCoin.Grpc.Protos.EmptyRequest, global::RecycleCoin.Grpc.Protos.Block>(serviceImpl.GetLast));
    }

  }
}
#endregion
