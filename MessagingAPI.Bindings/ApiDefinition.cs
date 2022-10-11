using System;
using Foundation;
using ObjCRuntime;

namespace MessagingAPI.Bindings
{
    // @interface ZDKObservationToken : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDKObservationToken
    {
        // -(void)cancel;
        [Export("cancel")]
        void Cancel();

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);
    }

    // @interface ZDKTransferOptionDescription : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDKTransferOptionDescription
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull engineId;
        [Export("engineId")]
        string EngineId { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull displayName;
        [Export("displayName")]
        string DisplayName { get; }

        // -(instancetype _Nonnull)initWithEngineId:(NSString * _Nonnull)engineId displayName:(NSString * _Nonnull)displayName __attribute__((objc_designated_initializer));
        [Export("initWithEngineId:displayName:")]
        [DesignatedInitializer]
        IntPtr Constructor(string engineId, string displayName);

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);
    }

    [Protocol(Name = "_TtP12MessagingAPI9ZDKEngine_"), Model]
    [BaseType(typeof(NSObject))]
    interface ZDKEngine
    {
    }

    interface IZDKEngine
    {
    }
}
