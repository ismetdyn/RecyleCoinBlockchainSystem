// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/blok.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace RecycleCoin.Grpc {
  public static partial class BlokServis
  {
    static readonly string __ServiceName = "BlokServis";

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
    static readonly grpc::Marshaller<global::RecycleCoin.Grpc.Blok> __Marshaller_Blok = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::RecycleCoin.Grpc.Blok.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::RecycleCoin.Grpc.BlokEkleDurum> __Marshaller_BlokEkleDurum = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::RecycleCoin.Grpc.BlokEkleDurum.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::RecycleCoin.Grpc.TabanYukseklik> __Marshaller_TabanYukseklik = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::RecycleCoin.Grpc.TabanYukseklik.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::RecycleCoin.Grpc.BlokListesi> __Marshaller_BlokListesi = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::RecycleCoin.Grpc.BlokListesi.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::RecycleCoin.Grpc.Blok, global::RecycleCoin.Grpc.BlokEkleDurum> __Method_Ekle = new grpc::Method<global::RecycleCoin.Grpc.Blok, global::RecycleCoin.Grpc.BlokEkleDurum>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Ekle",
        __Marshaller_Blok,
        __Marshaller_BlokEkleDurum);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::RecycleCoin.Grpc.TabanYukseklik, global::RecycleCoin.Grpc.BlokListesi> __Method_TabanYukseklikIleListeGetir = new grpc::Method<global::RecycleCoin.Grpc.TabanYukseklik, global::RecycleCoin.Grpc.BlokListesi>(
        grpc::MethodType.Unary,
        __ServiceName,
        "TabanYukseklikIleListeGetir",
        __Marshaller_TabanYukseklik,
        __Marshaller_BlokListesi);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::RecycleCoin.Grpc.Blok, global::RecycleCoin.Grpc.Blok> __Method_YukseklikIleTekilGetir = new grpc::Method<global::RecycleCoin.Grpc.Blok, global::RecycleCoin.Grpc.Blok>(
        grpc::MethodType.Unary,
        __ServiceName,
        "YukseklikIleTekilGetir",
        __Marshaller_Blok,
        __Marshaller_Blok);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::RecycleCoin.Grpc.Blok, global::RecycleCoin.Grpc.Blok> __Method_KarmaIleTekilGetir = new grpc::Method<global::RecycleCoin.Grpc.Blok, global::RecycleCoin.Grpc.Blok>(
        grpc::MethodType.Unary,
        __ServiceName,
        "KarmaIleTekilGetir",
        __Marshaller_Blok,
        __Marshaller_Blok);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::RecycleCoin.Grpc.Blok> __Method_BasGetir = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::RecycleCoin.Grpc.Blok>(
        grpc::MethodType.Unary,
        __ServiceName,
        "BasGetir",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_Blok);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::RecycleCoin.Grpc.Blok> __Method_SonGetir = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::RecycleCoin.Grpc.Blok>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SonGetir",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_Blok);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::RecycleCoin.Grpc.BlokReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of BlokServis</summary>
    [grpc::BindServiceMethod(typeof(BlokServis), "BindService")]
    public abstract partial class BlokServisBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::RecycleCoin.Grpc.BlokEkleDurum> Ekle(global::RecycleCoin.Grpc.Blok request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::RecycleCoin.Grpc.BlokListesi> TabanYukseklikIleListeGetir(global::RecycleCoin.Grpc.TabanYukseklik request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::RecycleCoin.Grpc.Blok> YukseklikIleTekilGetir(global::RecycleCoin.Grpc.Blok request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::RecycleCoin.Grpc.Blok> KarmaIleTekilGetir(global::RecycleCoin.Grpc.Blok request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::RecycleCoin.Grpc.Blok> BasGetir(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::RecycleCoin.Grpc.Blok> SonGetir(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for BlokServis</summary>
    public partial class BlokServisClient : grpc::ClientBase<BlokServisClient>
    {
      /// <summary>Creates a new client for BlokServis</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public BlokServisClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for BlokServis that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public BlokServisClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected BlokServisClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected BlokServisClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.BlokEkleDurum Ekle(global::RecycleCoin.Grpc.Blok request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Ekle(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.BlokEkleDurum Ekle(global::RecycleCoin.Grpc.Blok request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Ekle, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.BlokEkleDurum> EkleAsync(global::RecycleCoin.Grpc.Blok request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return EkleAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.BlokEkleDurum> EkleAsync(global::RecycleCoin.Grpc.Blok request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Ekle, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.BlokListesi TabanYukseklikIleListeGetir(global::RecycleCoin.Grpc.TabanYukseklik request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return TabanYukseklikIleListeGetir(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.BlokListesi TabanYukseklikIleListeGetir(global::RecycleCoin.Grpc.TabanYukseklik request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_TabanYukseklikIleListeGetir, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.BlokListesi> TabanYukseklikIleListeGetirAsync(global::RecycleCoin.Grpc.TabanYukseklik request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return TabanYukseklikIleListeGetirAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.BlokListesi> TabanYukseklikIleListeGetirAsync(global::RecycleCoin.Grpc.TabanYukseklik request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_TabanYukseklikIleListeGetir, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Blok YukseklikIleTekilGetir(global::RecycleCoin.Grpc.Blok request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return YukseklikIleTekilGetir(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Blok YukseklikIleTekilGetir(global::RecycleCoin.Grpc.Blok request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_YukseklikIleTekilGetir, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Blok> YukseklikIleTekilGetirAsync(global::RecycleCoin.Grpc.Blok request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return YukseklikIleTekilGetirAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Blok> YukseklikIleTekilGetirAsync(global::RecycleCoin.Grpc.Blok request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_YukseklikIleTekilGetir, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Blok KarmaIleTekilGetir(global::RecycleCoin.Grpc.Blok request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return KarmaIleTekilGetir(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Blok KarmaIleTekilGetir(global::RecycleCoin.Grpc.Blok request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_KarmaIleTekilGetir, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Blok> KarmaIleTekilGetirAsync(global::RecycleCoin.Grpc.Blok request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return KarmaIleTekilGetirAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Blok> KarmaIleTekilGetirAsync(global::RecycleCoin.Grpc.Blok request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_KarmaIleTekilGetir, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Blok BasGetir(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return BasGetir(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Blok BasGetir(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_BasGetir, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Blok> BasGetirAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return BasGetirAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Blok> BasGetirAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_BasGetir, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Blok SonGetir(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SonGetir(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RecycleCoin.Grpc.Blok SonGetir(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SonGetir, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Blok> SonGetirAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SonGetirAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RecycleCoin.Grpc.Blok> SonGetirAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SonGetir, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override BlokServisClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new BlokServisClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(BlokServisBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Ekle, serviceImpl.Ekle)
          .AddMethod(__Method_TabanYukseklikIleListeGetir, serviceImpl.TabanYukseklikIleListeGetir)
          .AddMethod(__Method_YukseklikIleTekilGetir, serviceImpl.YukseklikIleTekilGetir)
          .AddMethod(__Method_KarmaIleTekilGetir, serviceImpl.KarmaIleTekilGetir)
          .AddMethod(__Method_BasGetir, serviceImpl.BasGetir)
          .AddMethod(__Method_SonGetir, serviceImpl.SonGetir).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, BlokServisBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Ekle, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::RecycleCoin.Grpc.Blok, global::RecycleCoin.Grpc.BlokEkleDurum>(serviceImpl.Ekle));
      serviceBinder.AddMethod(__Method_TabanYukseklikIleListeGetir, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::RecycleCoin.Grpc.TabanYukseklik, global::RecycleCoin.Grpc.BlokListesi>(serviceImpl.TabanYukseklikIleListeGetir));
      serviceBinder.AddMethod(__Method_YukseklikIleTekilGetir, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::RecycleCoin.Grpc.Blok, global::RecycleCoin.Grpc.Blok>(serviceImpl.YukseklikIleTekilGetir));
      serviceBinder.AddMethod(__Method_KarmaIleTekilGetir, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::RecycleCoin.Grpc.Blok, global::RecycleCoin.Grpc.Blok>(serviceImpl.KarmaIleTekilGetir));
      serviceBinder.AddMethod(__Method_BasGetir, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::RecycleCoin.Grpc.Blok>(serviceImpl.BasGetir));
      serviceBinder.AddMethod(__Method_SonGetir, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::RecycleCoin.Grpc.Blok>(serviceImpl.SonGetir));
    }

  }
}
#endregion