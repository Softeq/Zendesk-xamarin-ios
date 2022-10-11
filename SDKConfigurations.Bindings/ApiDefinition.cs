using System;
using Foundation;
using ObjCRuntime;

namespace SDKConfigurations.Bindings
{
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface ZDKConfiguration
    {
    }

    interface IZDKConfiguration
    {
    }

    // @interface ZDKConfigurations : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ZDKConfigurations
    {
        // @property (readonly, copy, nonatomic) NSArray<id<ZDKConfiguration>> * _Nonnull configs;
        [Export("configs", ArgumentSemantic.Copy)]
        IZDKConfiguration[] Configs { get; }

        // -(instancetype _Nonnull)initWithConfigs:(NSArray<id<ZDKConfiguration>> * _Nonnull)configs __attribute__((objc_designated_initializer));
        [Export("initWithConfigs:")]
        [DesignatedInitializer]
        IntPtr Constructor(IZDKConfiguration[] configs);

        // @property (readonly, nonatomic) NSInteger startIndex;
        [Export("startIndex")]
        nint StartIndex { get; }

        // @property (readonly, nonatomic) NSInteger endIndex;
        [Export("endIndex")]
        nint EndIndex { get; }

        // -(void)insert:(id<ZDKConfiguration> _Nonnull)configuration;
        [Export("insert:")]
        void Insert(IZDKConfiguration configuration);

        // -(id<ZDKConfiguration> _Nonnull)objectAtIndexedSubscript:(NSInteger)index __attribute__((warn_unused_result("")));
        [Export("objectAtIndexedSubscript:")]
        IZDKConfiguration ObjectAtIndexedSubscript(nint index);

        // -(void)addDefaultConfigIfNeeded:(id<ZDKConfiguration> _Nonnull)config;
        [Export("addDefaultConfigIfNeeded:")]
        void AddDefaultConfigIfNeeded(IZDKConfiguration config);
    }
}
