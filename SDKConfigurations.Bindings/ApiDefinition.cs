using System;

using ObjCRuntime;
using Foundation;
using UIKit;

namespace SDKConfigurations.Bindings
{
    [Static]
    //[Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern double SDKConfigurationsVersionNumber;
        [Field("SDKConfigurationsVersionNumber", "__Internal")]
        double SDKConfigurationsVersionNumber { get; }

        // extern const unsigned char[] SDKConfigurationsVersionString;
        //[Field("SDKConfigurationsVersionString", "__Internal")]
        //byte[] SDKConfigurationsVersionString { get; }
    }

    // @protocol ZDKConfiguration <NSObject>
    /*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
    [Protocol]
	[BaseType(typeof(NSObject))]
	interface ZDKConfiguration
	{
	}

	// @interface ZDKConfigurations : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKConfigurations
	{
		// @property (readonly, copy, nonatomic) NSArray<id<ZDKConfiguration>> * _Nonnull configs;
		[Export("configs", ArgumentSemantic.Copy)]
		ZDKConfiguration[] Configs { get; }

		// -(instancetype _Nonnull)initWithConfigs:(NSArray<id<ZDKConfiguration>> * _Nonnull)configs __attribute__((objc_designated_initializer));
		[Export("initWithConfigs:")]
		[DesignatedInitializer]
		IntPtr Constructor(ZDKConfiguration[] configs);
	}

	//// @interface SDKConfigurations_Swift_746 (ZDKConfigurations)
	//[Category]
	//[BaseType(typeof(ZDKConfigurations))]
	//interface ZDKConfigurations_SDKConfigurations_Swift_746
	//{
	//	// @property (readonly, nonatomic) NSInteger startIndex;
	//	[Export("startIndex")]
	//	nint StartIndex { get; }

	//	// @property (readonly, nonatomic) NSInteger endIndex;
	//	[Export("endIndex")]
	//	nint EndIndex { get; }

	//	// -(void)insert:(id<ZDKConfiguration> _Nonnull)configuration;
	//	[Export("insert:")]
	//	void Insert(ZDKConfiguration configuration);

	//	// -(id<ZDKConfiguration> _Nonnull)objectAtIndexedSubscript:(NSInteger)index __attribute__((warn_unused_result));
	//	[Export("objectAtIndexedSubscript:")]
	//	ZDKConfiguration ObjectAtIndexedSubscript(nint index);

	//	// -(void)addDefaultConfigIfNeeded:(id<ZDKConfiguration> _Nonnull)config;
	//	[Export("addDefaultConfigIfNeeded:")]
	//	void AddDefaultConfigIfNeeded(ZDKConfiguration config);
	//}
}

