// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/credit_rating_service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace CreditRatingService.Protos {
  public static partial class CreditRatingCheck
  {
    static readonly string __ServiceName = "CreditRating.CreditRatingCheck";

    static readonly grpc::Marshaller<global::CreditRatingService.Protos.CreditRequest> __Marshaller_CreditRating_CreditRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CreditRatingService.Protos.CreditRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::CreditRatingService.Protos.CreditReply> __Marshaller_CreditRating_CreditReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CreditRatingService.Protos.CreditReply.Parser.ParseFrom);

    static readonly grpc::Method<global::CreditRatingService.Protos.CreditRequest, global::CreditRatingService.Protos.CreditReply> __Method_CheckCreditRequest = new grpc::Method<global::CreditRatingService.Protos.CreditRequest, global::CreditRatingService.Protos.CreditReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CheckCreditRequest",
        __Marshaller_CreditRating_CreditRequest,
        __Marshaller_CreditRating_CreditReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::CreditRatingService.Protos.CreditRatingServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CreditRatingCheck</summary>
    [grpc::BindServiceMethod(typeof(CreditRatingCheck), "BindService")]
    public abstract partial class CreditRatingCheckBase
    {
      public virtual global::System.Threading.Tasks.Task<global::CreditRatingService.Protos.CreditReply> CheckCreditRequest(global::CreditRatingService.Protos.CreditRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CreditRatingCheckBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CheckCreditRequest, serviceImpl.CheckCreditRequest).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CreditRatingCheckBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CheckCreditRequest, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CreditRatingService.Protos.CreditRequest, global::CreditRatingService.Protos.CreditReply>(serviceImpl.CheckCreditRequest));
    }

  }
}
#endregion
