// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Grpc/Proto/es.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace RecycleCoin.Grpc {
  public static partial class EsServis
  {
    static readonly string __ServiceName = "EsServis";

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
    static readonly grpc::Marshaller<global::RecycleCoin.Grpc.EsIstek> __Marshaller_EsIstek = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::RecycleCoin.Grpc.EsIstek.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::RecycleCoin.Grpc.EsDurum> __Marshaller_EsDurum = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::RecycleCoin.Grpc.EsDurum.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::RecycleCoin.Grpc.EsIstek, global::RecycleCoin.Grpc.EsDurum> __Method_Ekle = new grpc::Method<global::RecycleCoin.Grpc.EsIstek, global::RecycleCoin.Grpc.EsDurum>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Ekle",
        __Marshaller_EsIstek,
        __Marshaller_EsDurum);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::RecycleCoin.Grpc.EsDurum> __Method_HepsiniGetir = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::RecycleCoin.Grpc.EsDurum>(
        grpc::MethodType.Unary,
        __ServiceName,
        "HepsiniGetir",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_EsDurum);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::RecycleCoin.Grpc.EsIstek, global::RecycleCoin.Grpc.EsDurum> __Method_DugumDurumuGetir = new grpc::Method<global::RecycleCoin.Grpc.EsIstek, global::RecycleCoin.Grpc.EsDurum>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DugumDurumuGetir",
        __Marshaller_EsIstek,
        __Marshaller_EsDurum);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::RecycleCoin.Grpc.EsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of EsServis</summary>
    [grpc::BindServiceMethod(typeof(EsServis), "BindService")]
    public abstract partial class EsServisBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::RecycleCoin.Grpc.EsDurum> Ekle(global::RecycleCoin.Grpc.EsIstek request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::RecycleCoin.Grpc.EsDurum> HepsiniGetir(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::RecycleCoin.Grpc.EsDurum> DugumDurumuGetir(global::RecycleCoin.Grpc.EsIstek request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for EsServis</summary>
    public partial class EsServisClient : grpc::ClientBase<EsServisClient>
    {
      /// <summary>Creates a new client for EsServis</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public EsServisClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for EsServis that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public EsServisClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected EsServisClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected EsServisClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.EsDurum Ekle(global::RecycleCoin.Grpc.EsIstek request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Ekle(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.EsDurum Ekle(global::RecycleCoin.Grpc.EsIstek request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Ekle, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.EsDurum> EkleAsync(global::RecycleCoin.Grpc.EsIstek request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return EkleAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.EsDurum> EkleAsync(global::RecycleCoin.Grpc.EsIstek request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Ekle, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.EsDurum HepsiniGetir(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return HepsiniGetir(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.EsDurum HepsiniGetir(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_HepsiniGetir, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.EsDurum> HepsiniGetirAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return HepsiniGetirAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.EsDurum> HepsiniGetirAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_HepsiniGetir, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.EsDurum DugumDurumuGetir(global::RecycleCoin.Grpc.EsIstek request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DugumDurumuGetir(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.EsDurum DugumDurumuGetir(global::RecycleCoin.Grpc.EsIstek request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DugumDurumuGetir, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.EsDurum> DugumDurumuGetirAsync(global::RecycleCoin.Grpc.EsIstek request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DugumDurumuGetirAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.EsDurum> DugumDurumuGetirAsync(global::RecycleCoin.Grpc.EsIstek request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DugumDurumuGetir, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override EsServisClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new EsServisClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(EsServisBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Ekle, serviceImpl.Ekle)
          .AddMethod(__Method_HepsiniGetir, serviceImpl.HepsiniGetir)
          .AddMethod(__Method_DugumDurumuGetir, serviceImpl.DugumDurumuGetir).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, EsServisBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Ekle, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::RecycleCoin.Grpc.EsIstek, global::RecycleCoin.Grpc.EsDurum>(serviceImpl.Ekle));
      serviceBinder.AddMethod(__Method_HepsiniGetir, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::RecycleCoin.Grpc.EsDurum>(serviceImpl.HepsiniGetir));
      serviceBinder.AddMethod(__Method_DugumDurumuGetir, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::RecycleCoin.Grpc.EsIstek, global::RecycleCoin.Grpc.EsDurum>(serviceImpl.DugumDurumuGetir));
    }

  }
}
#endregion
